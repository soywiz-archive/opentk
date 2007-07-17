#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * Contributions from Erik Ylvisaker
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

using OpenTK.OpenGL;


namespace OpenTK.Platform.Windows
{
    public class WinGLContext : OpenTK.Platform.IGLContext, IDisposable
    {
        private IntPtr deviceContext;
        private IntPtr renderContext;
        private IntPtr opengl32Handle;
        private string opengl32Name = "OPENGL32.DLL";

        #region --- Contructors ---

        public WinGLContext(
            IntPtr handle,
            ColorDepth color,
            ColorDepth accum,
            int depthBits,
            int stencilBits,
            int auxBits,
            bool stereo,
            bool doublebuffer
        )
        {
            this.Setup(handle, color, accum, depthBits, stencilBits, auxBits, stereo, doublebuffer);
        }

        protected void Setup(
            IntPtr handle,
            ColorDepth color,
            ColorDepth accum,
            int depthBits,
            int stencilBits,
            int auxBits,
            bool stereo,
            bool doublebuffer
        )
        {
            // TODO: Better error handling.

            // Dynamically load the OpenGL32.dll in order to use the extension loading capabilities of Wgl.
            if (opengl32Handle == IntPtr.Zero)
            {
                opengl32Handle = API.LoadLibrary(opengl32Name);
                if (opengl32Handle == IntPtr.Zero)
                {
                    //System.Diagnostics.Debug.WriteLine("LoadLibrary({0}) set error code: {1}. Will not load extensions.", _dll_name, error_code);
                    throw new ApplicationException(
                        String.Format(
                            "LoadLibrary(\"{0}\") call failed with code {1}",
                            opengl32Name,
                            Marshal.GetLastWin32Error()
                        )
                    );
                }
                else
                {
                    //System.Diagnostics.Debug.WriteLine("Loaded dll: {0}", _dll_name);
                }
            }

            deviceContext = API.GetDC(handle);
            API.PixelFormatDescriptor pixelFormat = new API.PixelFormatDescriptor();

            pixelFormat.ColorBits = (byte)(color.Red + color.Green + color.Blue);
            pixelFormat.RedBits = (byte)color.Red;
            pixelFormat.GreenBits = (byte)color.Green;
            pixelFormat.BlueBits = (byte)color.Blue;
            pixelFormat.AlphaBits = (byte)color.Alpha;

            if (accum != null)
            {
                pixelFormat.AccumBits = (byte)(accum.Red + accum.Green + accum.Blue);
                pixelFormat.AccumRedBits = (byte)accum.Red;
                pixelFormat.AccumGreenBits = (byte)accum.Green;
                pixelFormat.AccumBlueBits = (byte)accum.Blue;
                pixelFormat.AccumAlphaBits = (byte)accum.Alpha;
            }

            pixelFormat.DepthBits = (byte)depthBits;
            pixelFormat.StencilBits = (byte)stencilBits;

            if (depthBits <= 0)
            {
                pixelFormat.Flags |= API.PixelFormatDescriptorFlags.DEPTH_DONTCARE;
            }

            if (stereo)
            {
                pixelFormat.Flags |= API.PixelFormatDescriptorFlags.STEREO;
            }

            if (doublebuffer)
            {
                pixelFormat.Flags |= API.PixelFormatDescriptorFlags.DOUBLEBUFFER;
            }

            // TODO: More elaborate mode setting, using DescribePixelFormat.

            int pixel = API.ChoosePixelFormat(deviceContext, pixelFormat);

            if (pixel == 0)
            {
                throw new Exception("The requested pixel format is not supported by the hardware configuration.");
            }

            API.SetPixelFormat(deviceContext, pixel, pixelFormat);

            renderContext = Wgl.CreateContext(deviceContext);

            MakeCurrent();

            //c.TopLevelControl.Move += new EventHandler(c_Move);
            //c.Move += new EventHandler(c_Move);
            //c.Resize += new EventHandler(c_Resize);

            //GL.ReloadFunctions();
        }

        #endregion

        #region --- IGLContext Members ---

        #region public void SwapBuffers()

        public void SwapBuffers()
        {
            API.SwapBuffers(deviceContext);
        }

        #endregion

        #region public IntPtr GetAddress(string function_string)

        public IntPtr GetAddress(string function_string)
        {
            return Wgl.GetProcAddress(function_string);
        }

        #endregion

        #region public void MakeCurrent()
        
        public void MakeCurrent()
        {
            Wgl.MakeCurrent(deviceContext, renderContext);
        }

	    #endregion

        #region public DisplayMode[] GetDisplayModes()

        public DisplayMode[] GetDisplayModes()
        {
            List<DisplayMode> modes = new List<DisplayMode>();
            bool done = false;
            int index = 0;

            while (!done)
            {
                API.DeviceMode currentMode = new API.DeviceMode();
                IntPtr handle = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(API.DeviceMode)));
                Marshal.StructureToPtr(currentMode, handle, true);

                done = (API.EnumDisplaySettings(null, index++, handle) != 0) ? false : true;
                int error = Marshal.GetLastWin32Error();

                Marshal.PtrToStructure(handle, currentMode);
                Marshal.FreeHGlobal(handle);

                if (error != 0)
                {
                    Console.WriteLine("Error: {0}", error);
                    continue;
                }
                if (done)
                    break;

                //DisplayMode mode = new DisplayMode(currentMode.PelsWidth, currentMode.PelsHeight);
                DisplayMode mode = new DisplayMode(
                    currentMode.PelsWidth,
                    currentMode.PelsHeight,
                    currentMode.BitsPerPel,
                    currentMode.DisplayFrequency
                );

                modes.Add(mode);
            }

            return modes.ToArray();
        }

        #endregion

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            this.Dispose(true);
        }

        private void Dispose(bool calledManually)
        {
            if (calledManually)
            {
                this.ReleaseResources();
                GC.SuppressFinalize(this);
            }
            else
            {
                this.ReleaseResources();
            }
        }

        ~WinGLContext()
        {
            Dispose(false);
        }

        #region public void ReleaseResources()

        private void ReleaseResources()
        {
            if (renderContext != IntPtr.Zero)
            {
                if (!Wgl.DeleteContext(renderContext))
                {
                    throw new ApplicationException(
                        "Could not destroy the OpenGL render context. Error: " + Marshal.GetLastWin32Error()
                    );
                }
                renderContext = IntPtr.Zero;
            }

            if (!API.FreeLibrary(this.opengl32Handle))
            {
                throw new ApplicationException(
                    "FreeLibray call failed ('opengl32.dll'), Error: " + Marshal.GetLastWin32Error()
                );
            }
        }

        #endregion

        #endregion
    }
}
