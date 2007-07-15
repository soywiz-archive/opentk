#region --- License ---
/* Copyright (c) 2006, 2007 Stephen Apostolopoulos
 * Contributions from Erik Ylvisaker
 * See license.txt for license info
 */
#endregion

#region --- Using directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

#endregion

namespace OpenTK.Platform
{
    sealed class WinGLControl// : OpenTK.Platform.IGLWindow
    {
        private OpenTK.Platform.WinGLContext glContext;

        #region --- Constructors ---

        public WinGLControl(Control c, int width, int height, bool fullscreen)
        {
            glContext = new OpenTK.Platform.WinGLContext(
                c.Handle,
                new ColorDepth(32),
                new ColorDepth(0),
                24,
                8,
                0,
                false,
                true
            );
        }

        #endregion

        #region --- IGLWindow membmers ---

        #region public void ProcessEvents()

        private WinApi.Message msg;
        public void ProcessEvents()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region public bool Quit

        public bool Quit
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        #endregion

        #region public bool IsIdle

        public bool IsIdle
        {
            get
            {
                return !WinApi.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
            }
        }

        #endregion

        #region public OpenTK.Platform.IGLContext Context

        public OpenTK.Platform.IGLContext Context
        {
            get { return glContext; }
        }

        #endregion

        #region public bool Fullscreen

        bool fullscreen = false;
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

        #endregion

        #endregion

        #region --- IResizable Members ---

        #region public int Width

        public int Width
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

        #endregion

        #region public int Height

        public int Height
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

        #endregion

        #region public event ResizeEvent Resize

        public event ResizeEvent Resize;
        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();
        public void OnResize(int width, int height)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        private void Dispose(bool calledManually)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
