using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    class GLNative : IGLWindow, IDisposable
    {
        IGLWindow glWindow;

        public GLNative()
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
                Environment.OSVersion.Platform == PlatformID.Win32Windows)
            {
                glWindow = new OpenTK.Platform.Windows.WinGLNative();
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix ||
                    Environment.OSVersion.Platform == (PlatformID)128) // some older versions of Mono reported 128.
            {
                //glWindow = new OpenTK.Platform.X11.X11GLControl(this, width, height, fullscreen);
            }
            else
            {
                throw new PlatformNotSupportedException(
                    "Your operating system is not currently supported. We are sorry for the inconvenience."
                );
            }
        }

        #region IGLWindow Members

        public OpenTK.OpenGL.DisplayMode SelectDisplayMode(OpenTK.OpenGL.DisplayMode mode)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public OpenTK.OpenGL.DisplayMode SelectDisplayMode(OpenTK.OpenGL.DisplayMode mode, DisplayModeMatchOptions options)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void SetDisplayMode(OpenTK.OpenGL.DisplayMode mode)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public bool IsIdle
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public bool Fullscreen
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public IGLContext Context
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
