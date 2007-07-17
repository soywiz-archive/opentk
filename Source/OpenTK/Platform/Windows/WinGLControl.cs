#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
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

namespace OpenTK.Platform.Windows
{
    sealed class WinGLControl : OpenTK.Platform.IGLControl
    {
        private WinGLContext glContext;
        private bool fullscreen;
        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();

        #region --- Constructors ---

        public WinGLControl(Control c, int width, int height, bool fullscreen)
        {
            glContext = new WinGLContext(
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

        #region --- IGLControl membmers ---

        public event CreateEvent Create;

        #region public void ProcessEvents()

        private API.Message msg;
        public void ProcessEvents()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
        
        #region public bool IsIdle

        public bool IsIdle
        {
            get
            {
                return !API.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
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

        public bool Fullscreen
        {
            get
            {
                return fullscreen;
            }
            set
            {
                throw new NotImplementedException();
                fullscreen = true;
            }
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
