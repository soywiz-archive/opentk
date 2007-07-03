using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

using OpenTK.OpenGL;


namespace OpenTK.Platform.Windows
{
    class WinGLContext : IGLContext, IDisposable
    {
        IntPtr deviceContext;
        IntPtr renderContext;
        IntPtr dllHandle;

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
            if (dllHandle == IntPtr.Zero)
            {
                dllHandle = OpenTK.Platform.Windows.WinApi.LoadLibrary("opengl32.dll");
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

        #region public void SwapBuffers()

        public void SwapBuffers()
        {
            WinApi.SwapBuffers(deviceContext);
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

        #region GetDisplayModes

        public DisplayMode[] GetDisplayModes()
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

            return modes.ToArray();
        }

        #endregion

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
