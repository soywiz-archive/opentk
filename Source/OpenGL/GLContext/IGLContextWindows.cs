#region --- License ---
/* This source file is released under the MIT license. See License.txt for more information.
 * Coded by Stephen Apostolopoulos and Erik Ylvisaker.
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text;

//using OpenTK.OpenGL;
using OpenTK.Platform.Windows;

#endregion

namespace OpenTK.OpenGL.Platform
{
    public class IGLContextWindows : IGLContext
    {
        IntPtr deviceContext;
        IntPtr renderContext;
        IntPtr dllHandle;

        #region --- Contructors ---

        public IGLContextWindows(
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
            if (dllHandle == IntPtr.Zero)
            {
                dllHandle = OpenTK.Platform.Windows.WinApi.LoadLibrary("OPENGL32.DLL");
                int errorCode = Marshal.GetLastWin32Error();

                if (errorCode != 0)
                {
                    //System.Diagnostics.Debug.WriteLine("LoadLibrary({0}) set error code: {1}. Will not load extensions.", _dll_name, error_code);
                    throw new Exception("LoadLibrary(\"OPENGL32.DLL\") call failed with code: " + errorCode);
                }
                else
                {
                    //System.Diagnostics.Debug.WriteLine("Loaded dll: {0}", _dll_name);
                }
            }

            deviceContext = OpenTK.Platform.Windows.WinApi.GetDC(handle);
            WinApi.PixelFormatDescriptor pixelFormat = new WinApi.PixelFormatDescriptor();

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
                pixelFormat.Flags |= WinApi.PixelFormatDescriptorFlags.DEPTH_DONTCARE;
            }

            if (stereo)
            {
                pixelFormat.Flags |= WinApi.PixelFormatDescriptorFlags.STEREO;
            }

            if (doublebuffer)
            {
                pixelFormat.Flags |= WinApi.PixelFormatDescriptorFlags.DOUBLEBUFFER;
            }

            // TODO: More elaborate mode setting, using DescribePixelFormat.

            int pixel = WinApi.ChoosePixelFormat(deviceContext, pixelFormat);

            if (pixel == 0)
            {
                throw new Exception("The requested pixel format is not supported by the hardware configuration.");
            }

            WinApi.SetPixelFormat(deviceContext, pixel, pixelFormat);

            renderContext = Wgl.CreateContext(deviceContext);

            MakeCurrent();

            //c.TopLevelControl.Move += new EventHandler(c_Move);
            //c.Move += new EventHandler(c_Move);
            //c.Resize += new EventHandler(c_Resize);

            //GL.ReloadFunctions();
        }

        #endregion

        #region --- IGLContext Members ---

        public void SwapBuffers()
        {
            WinApi.SwapBuffers(deviceContext);
            //Wgl.
        }

        public IntPtr GetAddress(string function_string)
        {
            return Wgl.GetProcAddress(function_string);
        }

        public void MakeCurrent()
        {
            Wgl.MakeCurrent(deviceContext, renderContext);
        }

        public List<DisplayMode> GetDisplayModes()
        {
            List<DisplayMode> modes = new List<DisplayMode>();
            bool done = false;
            int index = 0;

            while (!done)
            {
                WinApi.DeviceMode currentMode = new WinApi.DeviceMode();
                IntPtr handle = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(WinApi.DeviceMode)));
                Marshal.StructureToPtr(currentMode, handle, true);

                done = (WinApi.EnumDisplaySettings(null, index++, handle) != 0) ? false : true;
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

            return modes;
        }

        #endregion
    }

    /*
    public class WindowsContext : GLContext
    {
        void c_Resize(object sender, EventArgs e)
        {
            if (IsFullscreen)
                SetCursorClip();
        }

        void c_Move(object sender, EventArgs e)
        {
            if (IsFullscreen)
                SetCursorClip();
        }

        protected override void Dispose(bool disposing)
        {
            //if (IsFullscreen)
            //    SetWindowed();

            if (_render_context != 0)
                Wgl.DeleteContext(_render_context);

            if (_device_context != 0)
                OpenTK.Platform.Windows.WinApi.ReleaseDC(_window_handle.ToInt32(), _device_context);

            if (_dll_handle != 0)
                OpenTK.Platform.Windows.WinApi.FreeLibrary(_dll_handle);

            _render_context = 0;
            _device_context = 0;
            _dll_handle = 0;
        }

        public override void SetWindowed()
        {
            WinApi.ChangeDisplaySettings(null, 0);
            IsFullscreen = false;
        }

        public override void SetFullScreen(int width, int height, OpenTK.OpenGL.ColorDepth color)
        {
            CheckAnyFullScreen();

            WinApi.DeviceMode ScreenSettings = new WinApi.DeviceMode();
            ScreenSettings.PelsWidth = width;                       // Selected Screen Width
            ScreenSettings.PelsHeight = height;                     // Selected Screen Height
            ScreenSettings.BitsPerPel = color.Alpha +               // Selected Bits Per Pixel
                                        color.Red +
                                        color.Green +
                                        color.Blue;
            ScreenSettings.Fields = WinApi.Constants.DM_BITSPERPEL
                | WinApi.Constants.DM_PELSWIDTH
                | WinApi.Constants.DM_PELSHEIGHT;

            // Try To Set Selected Mode And Get Results.  NOTE: CDS_FULLSCREEN Gets Rid Of Start Bar.
            if (WinApi.ChangeDisplaySettings(ScreenSettings,
                WinApi.Constants.CDS_FULLSCREEN) == WinApi.Constants.DISP_CHANGE_SUCCESSFUL)
            {
                IsFullscreen = true;

                SetCursorClip();
            }
            else
            {
                throw new Exception("Could not change full-screen resolution.");
            }
        }
        
        /// <summary>
        /// Clips the cursor's available positions to within the render target.
        /// </summary>
        private void SetCursorClip()
        {
            Cursor.Clip = new Rectangle(this.Control.PointToScreen(Point.Empty), this.Control.Size);
        }
    }
    */
}