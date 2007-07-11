using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK
{
    public class GameWindow : OpenTK.Platform.IGLWindow, IDisposable
    {
        OpenTK.Platform.IGLWindow glWindow;

        #region Contructors

        /// <summary>
        /// Constructs a new GameWindow, using a safe DisplayMode.
        /// </summary>
        public GameWindow()
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
                Environment.OSVersion.Platform == PlatformID.Win32Windows)
            {
                glWindow = new OpenTK.Platform.Windows.WinGLNative();
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix ||
                    Environment.OSVersion.Platform == (PlatformID)128) // some older versions of Mono reported 128.
            {
                glWindow = new OpenTK.Platform.X11.X11GLNative();
            }
            else
            {
                throw new PlatformNotSupportedException(
                    "Your operating system is not currently supported. We are sorry for the inconvenience."
                );
            }
        }

        #endregion

        #region IGLWindow Members

        public OpenTK.OpenGL.DisplayMode SelectDisplayMode(OpenTK.OpenGL.DisplayMode mode)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public OpenTK.OpenGL.DisplayMode SelectDisplayMode(OpenTK.OpenGL.DisplayMode mode, OpenTK.Platform.DisplayModeMatchOptions options)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void SetDisplayMode(OpenTK.OpenGL.DisplayMode mode)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public bool IsIdle
        {
            get { return glWindow.IsIdle; }
        }

        public bool Fullscreen
        {
            get
            {
                return glWindow.Fullscreen;
            }
            set
            {
                value = glWindow.Fullscreen;
            }
        }

        public OpenTK.Platform.IGLContext Context
        {
            get { return glWindow.Context; }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            //glWindow.Dispose();
            //glWindow = null;
        }

        #endregion
    }
}
