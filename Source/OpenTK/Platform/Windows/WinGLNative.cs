using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OpenTK.Platform.Windows
{
    /*
    class WindowHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
    {
        protected override bool ReleaseHandle()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override bool IsInvalid
        {
            get
            {
                return base.IsInvalid;
            }
        }
    }
    */

    class WinGLNative : NativeWindow, IGLWindow, IDisposable
    {
        WinGLContext glContext;

        #region Contructors

        /// <summary>
        /// Constructs a new WinGLNative window, using safe defaults for the DisplayMode.
        /// </summary>
        public WinGLNative()
        {
            CreateParams cp = new CreateParams();
            cp.ClassStyle =
                (int)WinApi.WindowClassStyle.OwnDC |
                (int)WinApi.WindowClassStyle.VRedraw | 
                (int)WinApi.WindowClassStyle.HRedraw;
            cp.Style =
                (int)WinApi.WindowStyle.Visible |
                (int)WinApi.WindowStyle.ClipChildren |
                (int)WinApi.WindowStyle.ClipSiblings |
                (int)WinApi.WindowStyle.OverlappedWindow;
            cp.Width = 640;
            cp.Height = 480;
            cp.Caption = "OpenTK Game Window";
            CreateHandle(cp);


            glContext = new OpenTK.Platform.Windows.WinGLContext(
                this.Handle,
                new OpenTK.OpenGL.ColorDepth(32),
                new OpenTK.OpenGL.ColorDepth(0),
                24,
                8,
                0,
                false,
                true
            );
        }

        #endregion

        #region protected void CreateWindow()
        /*
        protected void CreateWindow()
        {
            WinApi.WindowClass wc = new WinApi.WindowClass();
            wc.style =
                WinApi.WindowClassStyle.HRedraw |
                WinApi.WindowClassStyle.VRedraw |
                WinApi.WindowClassStyle.OwnDC;
            wc.WindowProcedure = new WinApi.WindowProcedureEventHandler(WndProc);
            wc.Instance = instance;
            //wc.ClassName = Marshal.StringToHGlobalAuto(className);
            wc.ClassName = className;

            classAtom = WinApi.RegisterClass(wc);

            if (classAtom == 0)
            {
                throw new Exception("Could not register class, error: " + Marshal.GetLastWin32Error());
            }
            
            // Change for fullscreen!
            handle = WinApi.CreateWindowEx(
                WinApi.ExtendedWindowStyle.ApplicationWindow |
                WinApi.ExtendedWindowStyle.OverlappedWindow |
                WinApi.ExtendedWindowStyle.Topmost,
                className,
                //Marshal.StringToHGlobalAuto("OpenTK Game Window"),
                "OpenTK Game Window",
                WinApi.WindowStyle.OverlappedWindow |
                WinApi.WindowStyle.ClipChildren |
                WinApi.WindowStyle.ClipSiblings,
                0, 0,
                640, 480,
                IntPtr.Zero,
                IntPtr.Zero,
                instance,
                IntPtr.Zero
            );

            if (handle == IntPtr.Zero)
            {
                throw new Exception("Could not create window, error: " + Marshal.GetLastWin32Error());
            }
        }
        */
        #endregion

        #region protected override void WndProc(ref Message m)

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WinApi.Constants.WM_CLOSE:
                    WinApi.PostQuitMessage(0);
                    return;

                case WinApi.Constants.WM_QUIT:
                    quit = true;
                    break;
            }
            
 	        base.WndProc(ref m);
        }

        #endregion

        #region IGLWindow Members

        private System.Windows.Forms.Message msg;
        public void DoEvents()
        {
            isIdle = false;
            while (WinApi.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0))
            {
                WinApi.GetMessage(out msg, IntPtr.Zero, 0, 0);
                WndProc(ref msg);
            }
            isIdle = true;
        }

        #region public bool Quit

        private bool quit;
        public bool Quit
        {
            get { return quit; }
            set
            {
                if (value)
                {
                    WinApi.PostQuitMessage(0);
                    quit = true;
                }
            }
        }

        #endregion

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

        bool fullscreen;
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

        bool isIdle;
        public bool IsIdle
        {
            get
            {
                //return !WinApi.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
                return isIdle;
            }
            protected set
            {
                isIdle = value;
            }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            this.Context.Destroy();
            this.DestroyHandle();
        }

        #endregion
    }
}
