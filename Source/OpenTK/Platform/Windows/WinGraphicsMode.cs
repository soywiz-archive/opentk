#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

using OpenTK.Graphics;
using ColorDepth = OpenTK.Graphics.ColorFormat;

namespace OpenTK.Platform.Windows
{
    internal class WinGraphicsMode : IGraphicsMode
    {
        // Todo: Get rid of the System.Windows.Forms.Control dependency.

        #region --- Fields ---

        // To avoid recursion when calling GraphicsMode.Default
        bool creating;

        readonly IList<GraphicsMode> GraphicsModes = QueryARBModes() ?? QueryPFDModes();

        #endregion

        #region --- Constructors ---

        public WinGraphicsMode()
        {
            if (GraphicsModes == null)
                throw new GraphicsModeException("Failed to retrieve available graphics modes. Please report a bug at http://www.opentk.com/project/issues/opentk");
        }

        #endregion

        #region --- IGraphicsMode Members ---

        public GraphicsMode SelectGraphicsMode(ColorDepth color, int depth, int stencil, int samples, ColorDepth accum, 
            int buffers, bool stereo)
        {
            // Selection code inspired by GLFW.
            IntPtr best_mode = new IntPtr(-1);
            int best_missing = int.MaxValue;
            int best_color_diff = int.MaxValue;
            int best_extra_diff = int.MaxValue;

            // Todo: this only returns exact matches. Add fuziness.
            foreach (GraphicsMode mode in GraphicsModes)
            {
                // Calculate number of missing buffers
                int missing = 0;
                if (color.Alpha > 0 && mode.ColorFormat.Alpha == 0) missing++;
                if (depth > 0 && mode.Depth == 0) missing++;
                if (stencil > 0 && mode.Stencil == 0) missing++;
                if (accum.BitsPerPixel > 0 && mode.AccumulatorFormat.BitsPerPixel == 0) missing++;
                if (samples > 0 && mode.Samples == 0) missing++;

                // Calculate color difference
                int color_diff = (int)(
                    Math.Pow(color.Red - mode.ColorFormat.Red, 2) +
                    Math.Pow(color.Green - mode.ColorFormat.Green, 2) +
                    Math.Pow(color.Blue - mode.ColorFormat.Blue, 2));

                // Calculate 'extra' difference
                int extra_diff = 0;
                if (color.Alpha > 0)
                {
                    extra_diff += (int)Math.Pow(color.Alpha - mode.ColorFormat.Alpha, 2);
                }
                if (depth > 0)
                {
                    extra_diff += (int)Math.Pow(depth - mode.Depth, 2);
                }
                if (stencil > 0)
                {
                    extra_diff += (int)Math.Pow(stencil - mode.Stencil, 2);
                }
                if (accum.BitsPerPixel > 0)
                {
                    extra_diff += (int)(
                        Math.Pow(accum.Red - mode.AccumulatorFormat.Red, 2) +
                        Math.Pow(accum.Green - mode.AccumulatorFormat.Green, 2) +
                        Math.Pow(accum.Blue - mode.AccumulatorFormat.Blue, 2) +
                        Math.Pow(accum.Alpha - mode.AccumulatorFormat.Alpha, 2));
                }
                if (buffers > 0)
                {
                    extra_diff += 20 * (int)Math.Pow(buffers - mode.Buffers, 2);
                }
                if (samples > 0)
                {
                    extra_diff += (int)Math.Pow(samples - mode.Samples, 2);
                }

                // Check if this is a better match. We implement some
                // complicated rules, by prioritizing in this order:
                //  1) Visuals with the least number of missing buffers always
                //     have priority
                //  2a) If (r,g,b)!=(0,0,0), color depth has priority over
                //      other buffers
                //  2b) If (r,g,b)==(0,0,0), other buffers have priority over
                //      color depth
                if (missing < best_missing)
                {
                    best_mode = mode.Index.Value;
                }
                else if (missing == best_missing)
                {
                    if (color.BitsPerPixel > 0)
                    {
                        if ((color_diff < best_color_diff) || (color_diff == best_color_diff && extra_diff < best_extra_diff))
                        {
                            best_mode = mode.Index.Value;
                        }
                    }
                    else
                    {
                        if ((extra_diff < best_extra_diff) || (extra_diff == best_extra_diff && color_diff < best_color_diff))
                        {
                            best_mode = mode.Index.Value;
                        }
                    }
                }
                if (best_mode == mode.Index)
                {
                    best_missing = missing;
                    best_color_diff = color_diff;
                    best_extra_diff = extra_diff;
                }
            }

            if (best_mode != new IntPtr(-1))
                return GraphicsModes[best_mode.ToInt32()];
            else
                throw new GraphicsModeException("Failed to find a suitable GraphicsMode.");

            //GraphicsMode mode = null;
            //if (!creating)
            //{
            //    try
            //    {
            //        creating = true;
            //        mode = SelectGraphicsModeARB(color, depth, stencil, samples, accum, buffers, stereo) ??
            //            SelectGraphicsModePFD(color, depth, stencil, samples, accum, buffers, stereo);
            //    }
            //    finally
            //    {
            //        creating = false;
            //    }
            //}

            //return mode;
        }

        #endregion

        #region --- Private Methods ---

        #region SelectGraphicsModePFD

        GraphicsMode SelectGraphicsModePFD(ColorDepth color, int depth, int stencil, int samples, ColorDepth accum,
            int buffers, bool stereo)
        {
            using (INativeWindow native_window = new NativeWindow())
            //using (IGraphicsContext context = new GraphicsContext(new GraphicsMode(new ColorFormat(), 0, 0, 0, new ColorFormat(), 2, false), native_window.WindowInfo, 1, 0, GraphicsContextFlags.Default))
            {
                WinWindowInfo window = (WinWindowInfo)native_window.WindowInfo;

                IntPtr deviceContext = ((WinWindowInfo)window).DeviceContext;
                Debug.WriteLine(String.Format("Device context: {0}", deviceContext));

                Debug.Write("Selecting pixel format... ");
                PixelFormatDescriptor pixelFormat = new PixelFormatDescriptor();
                pixelFormat.Size = API.PixelFormatDescriptorSize;
                pixelFormat.Version = API.PixelFormatDescriptorVersion;
                pixelFormat.Flags =
                    PixelFormatDescriptorFlags.SUPPORT_OPENGL |
                    PixelFormatDescriptorFlags.DRAW_TO_WINDOW;
                pixelFormat.ColorBits = (byte)(color.Red + color.Green + color.Blue);

                pixelFormat.PixelType = color.IsIndexed ? PixelType.INDEXED : PixelType.RGBA;
                pixelFormat.RedBits = (byte)color.Red;
                pixelFormat.GreenBits = (byte)color.Green;
                pixelFormat.BlueBits = (byte)color.Blue;
                pixelFormat.AlphaBits = (byte)color.Alpha;

                if (accum.BitsPerPixel > 0)
                {
                    pixelFormat.AccumBits = (byte)(accum.Red + accum.Green + accum.Blue);
                    pixelFormat.AccumRedBits = (byte)accum.Red;
                    pixelFormat.AccumGreenBits = (byte)accum.Green;
                    pixelFormat.AccumBlueBits = (byte)accum.Blue;
                    pixelFormat.AccumAlphaBits = (byte)accum.Alpha;
                }

                pixelFormat.DepthBits = (byte)depth;
                pixelFormat.StencilBits = (byte)stencil;

                if (depth <= 0) pixelFormat.Flags |= PixelFormatDescriptorFlags.DEPTH_DONTCARE;
                if (stereo) pixelFormat.Flags |= PixelFormatDescriptorFlags.STEREO;
                if (buffers > 1) pixelFormat.Flags |= PixelFormatDescriptorFlags.DOUBLEBUFFER;

                int pixel = Functions.ChoosePixelFormat(deviceContext, ref pixelFormat);
                if (pixel == 0)
                    throw new GraphicsModeException("The requested GraphicsMode is not available.");

                // Find out what we really got as a format:
                PixelFormatDescriptor pfd = new PixelFormatDescriptor();
                pixelFormat.Size = API.PixelFormatDescriptorSize;
                pixelFormat.Version = API.PixelFormatDescriptorVersion;
                Functions.DescribePixelFormat(deviceContext, pixel, API.PixelFormatDescriptorSize, ref pfd);
                GraphicsMode fmt = new GraphicsMode((IntPtr)pixel,
                    new ColorDepth(pfd.RedBits, pfd.GreenBits, pfd.BlueBits, pfd.AlphaBits),
                    pfd.DepthBits,
                    pfd.StencilBits,
                    0,
                    new ColorDepth(pfd.AccumBits),
                    (pfd.Flags & PixelFormatDescriptorFlags.DOUBLEBUFFER) != 0 ? 2 : 1,
                    (pfd.Flags & PixelFormatDescriptorFlags.STEREO) != 0);

                return fmt;
            }
        }

        #endregion

        #region SelectGraphicsModeARB

        GraphicsMode SelectGraphicsModeARB(ColorDepth color, int depth, int stencil, int samples, ColorDepth accum,
            int buffers, bool stereo)
        {
            using (INativeWindow native_window = new NativeWindow())
            using (IGraphicsContext context = new GraphicsContext(new GraphicsMode(new ColorFormat(), 0, 0, 0, new ColorFormat(), 2, false), native_window.WindowInfo, 1, 0, GraphicsContextFlags.Default))
            {
                WinWindowInfo window = (WinWindowInfo)native_window.WindowInfo;

                Debug.Write("Selecting pixel format (ARB)... ");
                if (Wgl.Delegates.wglChoosePixelFormatARB == null || Wgl.Delegates.wglGetPixelFormatAttribivARB == null)
                {
                    Debug.WriteLine("failed");
                    return null;
                }

                int[] attribs = new int[]
                {
                    (int)WGL_ARB_pixel_format.AccelerationArb,

                    (int)WGL_ARB_pixel_format.AlphaBitsArb,
                    (int)WGL_ARB_pixel_format.RedBitsArb,
                    (int)WGL_ARB_pixel_format.GreenBitsArb,
                    (int)WGL_ARB_pixel_format.BlueBitsArb,
                    (int)WGL_ARB_pixel_format.ColorBitsArb,
                    
                    (int)WGL_ARB_pixel_format.DepthBitsArb,
                    (int)WGL_ARB_pixel_format.StencilBitsArb,
                    
                    (int)WGL_ARB_multisample.SampleBuffersArb,
                    (int)WGL_ARB_multisample.SamplesArb,

                    (int)WGL_ARB_pixel_format.AccumAlphaBitsArb,
                    (int)WGL_ARB_pixel_format.AccumRedBitsArb,
                    (int)WGL_ARB_pixel_format.AccumGreenBitsArb,
                    (int)WGL_ARB_pixel_format.AccumBlueBitsArb,
                    (int)WGL_ARB_pixel_format.AccumBitsArb,

                    (int)WGL_ARB_pixel_format.DoubleBufferArb,
                    (int)WGL_ARB_pixel_format.StereoArb,
                    0
                };

                int[] values = new int[attribs.Length];

                int[] attribs_values = new int[]
                {
                    (int)WGL_ARB_pixel_format.AccelerationArb, (int)WGL_ARB_pixel_format.FullAccelerationArb,

                    (int)WGL_ARB_pixel_format.RedBitsArb, color.Red,
                    (int)WGL_ARB_pixel_format.GreenBitsArb, color.Green,
                    (int)WGL_ARB_pixel_format.BlueBitsArb, color.Blue,
                    (int)WGL_ARB_pixel_format.AlphaBitsArb, color.Alpha,
                    (int)WGL_ARB_pixel_format.ColorBitsArb, color.BitsPerPixel,
                    
                    (int)WGL_ARB_pixel_format.DepthBitsArb, depth,
                    (int)WGL_ARB_pixel_format.StencilBitsArb, stencil,
                    
                    (int)WGL_ARB_multisample.SampleBuffersArb, samples > 0 ? 1 : 0,
                    (int)WGL_ARB_multisample.SamplesArb, samples,

                    (int)WGL_ARB_pixel_format.AccumRedBitsArb, accum.Red,
                    (int)WGL_ARB_pixel_format.AccumGreenBitsArb, accum.Green,
                    (int)WGL_ARB_pixel_format.AccumBlueBitsArb, accum.Blue,
                    (int)WGL_ARB_pixel_format.AccumAlphaBitsArb, accum.Alpha,
                    (int)WGL_ARB_pixel_format.AccumBitsArb, accum.BitsPerPixel,

                    (int)WGL_ARB_pixel_format.DoubleBufferArb, 1,
                    (int)WGL_ARB_pixel_format.StereoArb, stereo ? 1 : 0,
                    0, 0
                };

                int[] pixel = new int[1], num_formats = new int[1];
                Wgl.Arb.ChoosePixelFormat(window.DeviceContext, attribs_values, null, 1, pixel, num_formats);
                if (num_formats[0] == 0 || pixel[0] == 0)
                {
                    // Try again without an accumulator. Many modern cards cannot accelerate multisampled formats with accumulator buffers.
                    attribs_values[10 * 2 + 1] = attribs_values[11 * 2 + 1] = attribs_values[12 * 2 + 1] = attribs_values[13 * 2 + 1] = attribs_values[14 * 2 + 1] = 0;
                    Wgl.Arb.ChoosePixelFormat(window.DeviceContext, attribs_values, null, 1, pixel, num_formats);
                }
                if (num_formats[0] == 0 || pixel[0] == 0)
                {
                    Debug.WriteLine("failed");
                    return null;
                }

                // Find out what we really got as a format:
                Wgl.Arb.GetPixelFormatAttrib(window.DeviceContext, pixel[0], 0, attribs.Length, attribs, values);

                GraphicsMode mode = new GraphicsMode(new IntPtr(pixel[0]),
                    new ColorDepth(values[1], values[2], values[3], values[4]),
                    values[6],
                    values[7],
                    values[8] != 0 ? values[9] : 0,
                    new ColorDepth(values[10], values[11], values[12], values[13]),
                    values[15] == 1 ? 2 : 1,
                    values[16] == 1 ? true : false);

                Debug.WriteLine("success!");
                return mode;
            }
        }

        #endregion

        #region QueryPFDModes

        static IList<GraphicsMode> QueryPFDModes()
        {
            List<GraphicsMode> modes = new List<GraphicsMode>();

            // Todo: this code is not multiscreen aware.
            IntPtr dc = IntPtr.Zero;
            try
            {
                dc = Functions.GetDC(IntPtr.Zero); // Get the DC for the primary screen.
                if (dc == IntPtr.Zero)
                    throw new GraphicsModeException(String.Format("Failed to obtain device context, error: {0}", Marshal.GetLastWin32Error()));

                PixelFormatDescriptor pfd = new PixelFormatDescriptor();
                pfd.Size = PixelFormatDescriptor.SizeInBytes;
                pfd.Version = PixelFormatDescriptor.StructureVersion;

                int num_formats = 0;
                //num_formats = Functions.DescribePixelFormat(dc, 0, PixelFormatDescriptor.SizeInBytes, null);
                unsafe { num_formats = Wgl.Imports.DescribePixelFormat(dc, 0, (uint)PixelFormatDescriptor.SizeInBytes, null); }

                for (int format = 0; format < num_formats; format++)
                {
                    // GDI DescribePixelFormat carries a significant performance overhead (~60ms on nvidia). The wgl functions
                    // behave better, so we use those.
                    //Functions.DescribePixelFormat(dc, format, PixelFormatDescriptor.SizeInBytes, ref pfd);
                    unsafe { Wgl.Imports.DescribePixelFormat(dc, format, (uint)PixelFormatDescriptor.SizeInBytes, &pfd); }
                    modes.Add(new GraphicsMode(
                        new IntPtr(format),
                        new ColorDepth(pfd.RedBits, pfd.GreenBits, pfd.BlueBits, pfd.AlphaBits),
                        pfd.DepthBits,
                        pfd.StencilBits,
                        0,
                        new ColorDepth(pfd.AccumBits),
                        (pfd.Flags & PixelFormatDescriptorFlags.DOUBLEBUFFER) != 0 ? 2 : 1,
                        (pfd.Flags & PixelFormatDescriptorFlags.STEREO) != 0));
                }
            }
            finally
            {
                Functions.ReleaseDC(IntPtr.Zero, dc);
            }

            return modes.AsReadOnly();
        }

        #endregion

        #region QueryARBModes

        static IList<GraphicsMode> QueryARBModes()
        {
            return null;
        }

        #endregion

        #endregion
    }
}
