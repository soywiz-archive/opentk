using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OpenTK.Platform.Windows
{
    class WinGLControl : IGLWindow
    {
        private IGLContext glContext;
        bool fullscreen = false;

        public WinGLControl(Control c, int width, int height, bool fullscreen)
        {
            glContext = new OpenTK.Platform.Windows.WinGLContext(
                c.Handle,
                new OpenTK.OpenGL.ColorDepth(32),
                new OpenTK.OpenGL.ColorDepth(0),
                24,
                8,
                0,
                false,
                true
            );
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

        public IGLContext Context
        {
            get { return glContext; }
        }

        public bool Fullscreen
        {
            get
            {
                return false;
            }
            set
            {
                fullscreen = fullscreen;
            }
        }

        private WinApi.Message msg;
        public bool IsIdle
        {
            get
            {
                return !WinApi.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
            }
        }

        #endregion
    }
}
