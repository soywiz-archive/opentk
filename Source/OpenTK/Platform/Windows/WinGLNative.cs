#region --- License ---
/* Copyright (c) 2007 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#endregion

namespace OpenTK.Platform
{
    sealed class WinGLNative : NativeWindow, OpenTK.Platform.IGLWindow, IDisposable
    {
        WinGLContext glContext;
        OpenTK.OpenGL.DisplayMode mode;

        #region --- Contructors ---

        /// <summary>
        /// Constructs a new WinGLNative window, using safe defaults for the DisplayMode.
        /// </summary>
        public WinGLNative()
        {
            mode = new OpenTK.OpenGL.DisplayMode();
            mode.Width = 640;
            mode.Height = 480;

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
            cp.Width = mode.Width;
            cp.Height = mode.Height;
            cp.Caption = "OpenTK Game Window";
            CreateHandle(cp);

            glContext = new OpenTK.Platform.WinGLContext(
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
                case WinApi.Constants.WM_SIZE:
                    resizeEventArgs.Width = (int)m.LParam & 0x0000FFFF;
                    resizeEventArgs.Height = (int)(((long)m.LParam & 0xFFFF0000) >> 16);
                    this.Resize(resizeEventArgs);
                    // Must pass WM_WINDOWPOSCHANGED to DefWndProc
                    m.Msg = WinApi.Constants.WM_WINDOWPOSCHANGED;
                    break;

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

        #region --- IGLWindow Members ---

        #region public void ProcessEvents()

        private System.Windows.Forms.Message msg;
        public void ProcessEvents()
        {
            while (WinApi.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0))
            {
                WinApi.GetMessage(out msg, IntPtr.Zero, 0, 0);
                WndProc(ref msg);
            }
        }

        #endregion

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

        #region public IGLContext Context

        public IGLContext Context
        {
            get { return glContext; }
        }

        #endregion

        #region public bool Fullscreen

        bool fullscreen;
        public bool Fullscreen
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
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

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            this.Context.Destroy();
            this.DestroyHandle();
        }

        #endregion

        #region --- IResizable Members ---

        #region public int Width

        private int width;
        public int Width
        {
            get
            {
                return mode.Width;
            }
            set
            {
                mode.Width = value;
                // Call to resize window?
            }
        }

        #endregion

        #region public int Height

        private int height;
        public int Height
        {
            get
            {
                return mode.Height;
            }
            set
            {
                mode.Height = value;
                // Call to resize window?
            }
        }

        #endregion

        #region public void Resize(int width, int height)
        public event ResizeEvent<IGLWindow> ResizeNotify;
        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();
        public void Resize(ResizeEventArgs e)
        {
            width = e.Width;
            height = e.Height;
            if (this.ResizeNotify != null)
                this.ResizeNotify(this, e);
        }

        #endregion

        #endregion
    }

    #region class WindowHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid

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

    #endregion
}
