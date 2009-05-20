#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using OpenTK.Graphics;
using OpenTK.Input;

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// Drives GameWindow on Windows.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class WinGLNative : System.Windows.Forms.NativeWindow, INativeGLWindow, INativeWindow
    {
        #region --- Fields ---

        private IInputDriver driver;

        private bool visible = true;
        private bool disposed;
        private bool exists;
        private WinWindowInfo window;
        private WindowBorder windowBorder = WindowBorder.Resizable, previous_window_border;
        private WindowState windowState = WindowState.Normal;

        private System.Drawing.Rectangle previous_client_area;

        private System.Drawing.Rectangle bounds = new System.Drawing.Rectangle();
        private System.Drawing.Rectangle client_rectangle = new System.Drawing.Rectangle();

        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();

        // For use in PeekMessage.
        private MSG myGoodMsg = new MSG();

        private static readonly ClassStyle ClassStyle =
            ClassStyle.OwnDC | ClassStyle.VRedraw | ClassStyle.HRedraw | ClassStyle.Ime;

        #endregion

        #region --- Contructors ---

        public WinGLNative(int x, int y, int width, int height, string title, GameWindowFlags options, DisplayDevice device)
        {
            CreateParams cp = new CreateParams();
            cp.ClassStyle = (int)ClassStyle;
                
            cp.Style =
                (int)WindowStyle.Visible | (int)WindowStyle.ClipChildren |
                (int)WindowStyle.ClipSiblings | (int)WindowStyle.OverlappedWindow;
            //cp.ExStyle = 

            // Keep in mind that some construction code runs in WM_CREATE,
            // which is raised CreateHandle()
            Rectangle rect = new Rectangle();
            rect.left = x; rect.top = y; rect.right = x + width; rect.bottom = y + height;
            Functions.AdjustWindowRect(ref rect, (WindowStyle)cp.Style, false);
            cp.X = rect.left;
            cp.Y = rect.top;
            cp.Width = rect.Width;
            cp.Height = rect.Height;
            CreateHandle(cp);
        }

        #endregion

        #region --- Protected Members ---

        #region protected override void WndProc(ref Message m)

        /// <summary>
        /// Processes incoming WM_* messages.
        /// </summary>
        /// <param name="m">Reference to the incoming Windows Message.</param>
        protected override void WndProc(ref Message m)
        {
            switch ((WindowMessage)m.Msg)
            {
                case WindowMessage.ACTIVATE:
                    break;

                case WindowMessage.NCCALCSIZE:
                    // Need to update the client rectangle, because it has the wrong size on Vista with Aero enabled.
                    //if (m.WParam == new IntPtr(1))
                    //{
                    //    unsafe
                    //    {
                    //        NcCalculateSize* nc_calc_size = (NcCalculateSize*)m.LParam;
                    //        //nc_calc_size->NewBounds = nc_calc_size->OldBounds;
                    //        //nc_calc_size->OldBounds = nc_calc_size->NewBounds;
                    //        //client_rectangle = rect.OldClientRectangle;
                    //    }

                    //    m.Result = new IntPtr((int)(NcCalcSizeOptions.ALIGNTOP | NcCalcSizeOptions.ALIGNLEFT/* | NcCalcSizeOptions.REDRAW*/));
                    //}
                    break;

                case WindowMessage.WINDOWPOSCHANGED:
                    unsafe
                    {
                        WindowPosition* pos = (WindowPosition*)m.LParam;
                        bounds.X = pos->x;
                        bounds.Y = pos->y;
                        bounds.Width = pos->cx;
                        bounds.Height = pos->cy;

                        // This code returns the *window* rectangle, not the *client* rectangle.
                        //int aero_enabled;
                        //Functions.DwmGetWindowAttribute(Handle, DwmWindowAttribute.NCRENDERING_ENABLED, (void*)&aero_enabled, sizeof(int));
                        //if (aero_enabled != 0)
                        //{
                        //    Rectangle rect;
                        //    Functions.DwmGetWindowAttribute(Handle, DwmWindowAttribute.EXTENDED_FRAME_BOUNDS, (void*)&rect, sizeof(System.Drawing.Rectangle));
                        //    client_rectangle = rect.ToRectangle();
                        //    client_rectangle.X = 0;
                        //    client_rectangle.Y = 0;
                        //}
                        //else
                        {
                            Rectangle rect;
                            Functions.GetClientRect(Handle, out rect);
                            client_rectangle = rect.ToRectangle();
                        }
                    }

                    if (Resize != null)
                        Resize(this, EventArgs.Empty);
                    break;

                case WindowMessage.STYLECHANGED:
                    WindowStyle style = (WindowStyle)(long)Functions.GetWindowLong(Handle, GetWindowLongOffsets.STYLE);
                    if ((style & WindowStyle.Popup) != 0)
                        windowBorder = WindowBorder.Hidden;
                    else if ((style & WindowStyle.ThickFrame) != 0)
                        windowBorder = WindowBorder.Resizable;
                    else if ((style & ~(WindowStyle.ThickFrame | WindowStyle.MaximizeBox)) != 0)
                        windowBorder = WindowBorder.Fixed;

                    //ClientRectangle = ClientRectangle;
                    break;

                case WindowMessage.SIZE:
                    SizeMessage state = (SizeMessage)m.WParam.ToInt64();
                    switch (state)
                    {
                        case SizeMessage.RESTORED: windowState = WindowState.Normal; break;
                        case SizeMessage.MINIMIZED: windowState = WindowState.Minimized; break;
                        case SizeMessage.MAXIMIZED:
                            windowState = WindowBorder == WindowBorder.Hidden ? WindowState.Fullscreen : WindowState.Maximized;
                            break;
                    }

                    break;

                //case WindowMessage.MOUSELEAVE:
                //    Cursor.Current = Cursors.Default;
                //    break;

                //case WindowMessage.MOUSE_ENTER:
                //    Cursor.Current = Cursors.Default;
                //    break;

                case WindowMessage.CREATE:
                    // Set the window width and height:
                    CreateStruct cs = (CreateStruct)Marshal.PtrToStructure(m.LParam, typeof(CreateStruct));
                    bounds.X = cs.x;
                    bounds.Y = cs.y;
                    bounds.Width = cs.cx;
                    bounds.Height = cs.cy;

                    // Raise the Create event
                    this.OnCreate(EventArgs.Empty);
                    return;

                case WindowMessage.CLOSE:
                    System.ComponentModel.CancelEventArgs e = new System.ComponentModel.CancelEventArgs();
                    
                    if (Closing != null)
                        Closing(this, e);

                    if (!e.Cancel)
                    {
                        if (Unload != null)
                            Unload(this, e);

                        DestroyWindow();
                        break;
                    }

                    return;

                case WindowMessage.DESTROY:
                    exists = false;
                    
                    if (Closed != null)
                        Closed(this, EventArgs.Empty);
                    
                    break;
            }

            base.WndProc(ref m);
        }

        #endregion

        #endregion

        #region --- INativeWindow Members ---

        #region Bounds

        public System.Drawing.Rectangle Bounds
        {
            get { return bounds; }
            set
            {
                // Note: the bounds variable is updated when the resize/move message arrives.
                Functions.SetWindowPos(Handle, IntPtr.Zero, value.X, value.Y, value.Width, value.Height, 0);
            }
        }

        #endregion

        #region Location

        public Point Location
        {
            get { return Bounds.Location; }
            set
            {
                // Note: the bounds variable is updated when the resize/move message arrives.
                Functions.SetWindowPos(Handle, IntPtr.Zero, value.X, value.Y, 0, 0, SetWindowPosFlags.NOSIZE);
            }
        }

        #endregion

        #region Size

        public Size Size
        {
            get { return Bounds.Size; }
            set
            {
                // Note: the bounds variable is updated when the resize/move message arrives.
                Functions.SetWindowPos(Handle, IntPtr.Zero, 0, 0, value.Width, value.Height, SetWindowPosFlags.NOMOVE);
            }
        }

        #endregion

        #region ClientRectangle

        public System.Drawing.Rectangle ClientRectangle
        {
            get { return client_rectangle; }
            set
            {
                //WindowStyle style = (WindowStyle)(ulong)Functions.GetWindowLong(Handle, GetWindowLongOffsets.STYLE);
                //ExtendedWindowStyle exstyle = (ExtendedWindowStyle)(ulong)Functions.GetWindowLong(Handle, GetWindowLongOffsets.EXSTYLE);
                //Rectangle rect = Rectangle.From(value);

                //if (!Functions.AdjustWindowRectEx(ref rect, style, false, exstyle))
                //{
                //    Size = new Size(value.Width, value.Height);
                //    return;
                //}

                //Size = new Size(rect.Width, rect.Height);
            }
        }

        #endregion

        #region ClientSize

        public Size ClientSize
        {
            get
            {
                return ClientRectangle.Size;
            }
            set
            {
                WindowStyle style = (WindowStyle)Functions.GetWindowLong(Handle, GetWindowLongOffsets.STYLE);
                Rectangle rect = Rectangle.From(value);
                Functions.AdjustWindowRect(ref rect, style, false);
                Size = new Size(rect.Width, rect.Height);
            }
        }

        #endregion

        #region Width

        public int Width
        {
            get { return ClientRectangle.Width; }
            set { ClientRectangle = new System.Drawing.Rectangle(Location, new Size(value, Height)); }
        }

        #endregion

        #region Height

        public int Height
        {
            get { return ClientRectangle.Height; }
            set { ClientRectangle = new System.Drawing.Rectangle(Location, new Size(Width, value)); }
        }

        #endregion

        #region X

        public int X
        {
            get { return ClientRectangle.X; }
            set { ClientRectangle = new System.Drawing.Rectangle(new Point(value, Y), Size); }
        }

        #endregion

        #region Y

        public int Y
        {
            get { return ClientRectangle.Y; }
            set { ClientRectangle = new System.Drawing.Rectangle(new Point(X, value), Size); }
        }

        #endregion

        #region Icon

        public Icon Icon
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

        #region Focused

        public bool Focused
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

        #region Exists

        public bool Exists { get { return exists; } }

        #endregion

        #region Close

        public void Close()
        {
            DestroyWindow();
        }

        #endregion

        #region Events

        public event EventHandler<EventArgs> Idle;

        public event EventHandler<EventArgs> Load;

        public event EventHandler<EventArgs> Unload;

        public event EventHandler<EventArgs> Move;

        public event EventHandler<EventArgs> Resize;

        public event EventHandler<System.ComponentModel.CancelEventArgs> Closing;

        public event EventHandler<EventArgs> Closed;

        public event EventHandler<EventArgs> Disposed;

        public event EventHandler<EventArgs> IconChanged;

        public event EventHandler<EventArgs> TitleChanged;

        public event EventHandler<EventArgs> ClientSizeChanged;

        public event EventHandler<EventArgs> VisibleChanged;

        public event EventHandler<EventArgs> WindowInfoChanged;

        #endregion

        #endregion

        #region --- INativeGLWindow Members ---

        #region public void ProcessEvents()

        private int ret;
        MSG msg;
        public void ProcessEvents()
        {
            while (!IsIdle)
            {
                ret = Functions.GetMessage(ref msg, Handle, 0, 0);
                if (ret == -1)
                {
                    throw new ApplicationException(String.Format(
                        "An error happened while processing the message queue. Windows error: {0}",
                        Marshal.GetLastWin32Error()));
                }
                Functions.DispatchMessage(ref msg);
                //WndProc(ref msg);
            }
        }

        #endregion

        #region public IInputDriver InputDriver

        public IInputDriver InputDriver
        {
            get
            {
                return driver;
            }
        }

        #endregion

        #region public bool IsIdle

        public bool IsIdle
        {
            get
            {
                //return !API.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
                return !Functions.PeekMessage(ref myGoodMsg, this.Handle, 0, 0, 0);
                //return API.GetQueueStatus(API.QueueStatusFlags.ALLEVENTS) == 0;
            }
        }

        #endregion

        #region public string Text

        public string Title
        {
            get
            {
                StringBuilder title = new StringBuilder(256);
                Functions.GetWindowText(window.WindowHandle, title, title.Capacity);
                return title.ToString();
            }
            set
            {
#if DEBUG
                bool ret = Functions.SetWindowText(window.WindowHandle, value);
                if (ret)
                    Debug.Print("Window {0} title changed to {1}.", window.WindowHandle, value);
                else
                    Debug.Print("Window {0} title failed to change to {1}.", window.WindowHandle, value);
#else
                Functions.SetWindowText(window.WindowHandle, value);
#endif
            }
        }

        #endregion

        #region public bool Visible

        /// <summary>
        /// TODO
        /// </summary>
        public bool Visible
        {
            get
            {
                return visible;
            }
            set
            {
                if (value && !Visible)
                {
                    Functions.ShowWindow(Handle, ShowWindowCommand.SHOWNORMAL);
                    visible = true;
                }
                else if (!value && Visible)
                {
                    Functions.ShowWindow(Handle, ShowWindowCommand.HIDE);
                    visible = false;
                }
            }
        }

        #endregion

        #region public IWindowInfo WindowInfo

        public IWindowInfo WindowInfo
        {
            get { return window; }
            //private set { window = value as WindowInfo; }
        }

        #endregion

        #region public void CreateWindow(int width, int height, GraphicsMode mode, out IGraphicsContext context)

        public void CreateWindow(int width, int height, GraphicsMode mode, int major, int minor, GraphicsContextFlags flags,
            out IGraphicsContext context)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region OnCreate

        public event CreateEvent Create;

        public void OnCreate(EventArgs e)
        {
            this.window = new WinWindowInfo(Handle, null);
            exists = true;

            //driver = new WinRawInput(this.window);    // Disabled until the mouse issues are resolved.
            driver = new WMInput(this.window);

            Debug.Print("Window created: {0}", window);

            if (this.Create != null)
                this.Create(this, e);
        }

        #endregion

        #region private void DestroyWindow()

        /// <summary>
        /// Starts the teardown sequence for the current window.
        /// </summary>
        public void DestroyWindow()
        {
            Debug.Print("Destroying window: {0}", window.ToString());
            //Functions.PostMessage(this.Handle, WindowMessage.DESTROY, IntPtr.Zero, IntPtr.Zero);
            Functions.DestroyWindow(this.Handle);
        }

        #endregion

        #region OnDestroy

        public void OnDestroy(EventArgs e)
        {
            Debug.Print("Destroy event fired from window: {0}", window.ToString());

            if (this.Destroy != null)
                this.Destroy(this, e);
        }

        public event DestroyEvent Destroy;

        #endregion

        #region PointToClient

        public Point PointToClient(Point point)
        {
            if (!Functions.ScreenToClient(this.Handle, ref point))
                throw new InvalidOperationException(String.Format(
                    "Could not convert point {0} from client to screen coordinates. Windows error: {1}",
                    point.ToString(), Marshal.GetLastWin32Error()));

            return point;
        }

        #endregion

        #region PointToScreen

        public Point PointToScreen(Point p)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region public WindowState WindowState

        public WindowState WindowState
        {
            get
            {
                return windowState;   
            }
            set
            {
                if (WindowState == value)
                    return;

                UIntPtr style = Functions.GetWindowLong(Handle, GetWindowLongOffsets.STYLE);
                ShowWindowCommand command = (ShowWindowCommand)0;
                SetWindowPosFlags flags = SetWindowPosFlags.NOREPOSITION | SetWindowPosFlags.NOMOVE;

                switch (value)
                {
                    case WindowState.Normal:
                        command = ShowWindowCommand.RESTORE;
                        flags |= SetWindowPosFlags.SHOWWINDOW | SetWindowPosFlags.FRAMECHANGED;

                        if (WindowState == WindowState.Fullscreen || WindowState == WindowState.Maximized)
                            WindowBorder = previous_window_border;

                        ClientRectangle = previous_client_area;
                        break;

                    case WindowState.Minimized:
                        command = ShowWindowCommand.SHOWMINIMIZED;
                        flags |= SetWindowPosFlags.NOSIZE;
                        break;

                    case WindowState.Maximized:
                    case WindowState.Fullscreen:
                        if (WindowState == WindowState.Normal || WindowState == WindowState.Minimized)
                        {
                            // Get the normal size of the window, so we can set it when reverting from fullscreen/maximized to normal.
                            previous_client_area = ClientRectangle;
                            previous_window_border = WindowBorder;
                        }

                        command = ShowWindowCommand.SHOWMAXIMIZED;
                        flags |= SetWindowPosFlags.SHOWWINDOW | SetWindowPosFlags.DRAWFRAME | SetWindowPosFlags.NOSIZE;

                        if (value == WindowState.Fullscreen)
                            this.WindowBorder = WindowBorder.Hidden;
                        else
                            this.WindowBorder = previous_window_border;

                        break;
                }

                Functions.ShowWindow(Handle, command);
                Functions.SetWindowPos(Handle, IntPtr.Zero, 0, 0, 0, 0, flags);

                //windowState = value;
            }
        }

        #endregion

        #region public WindowBorder WindowBorder
        
        public WindowBorder WindowBorder
        {
            get
            {
                return windowBorder;
            }
            set
            {
                if (windowBorder == value)
                    return;

                WindowStyle style = WindowStyle.ClipChildren | WindowStyle.ClipSiblings;

                switch (value)
                {
                    case WindowBorder.Resizable:
                        style |= WindowStyle.OverlappedWindow;
                        break;

                    case WindowBorder.Fixed:
                        style |= WindowStyle.OverlappedWindow &
                            ~(WindowStyle.ThickFrame | WindowStyle.MaximizeBox | WindowStyle.SizeBox);
                        break;

                    case WindowBorder.Hidden:
                        style |= WindowStyle.Popup;
                        break;
                }

                //Size current_size = ClientSize;

                Functions.SetWindowLong(Handle, GetWindowLongOffsets.STYLE, (IntPtr)(int)style);
                Functions.SetWindowPos(Handle, IntPtr.Zero, Bounds.X, Bounds.Y, Bounds.Width, Bounds.Height,
                    SetWindowPosFlags.NOMOVE | SetWindowPosFlags.NOSIZE | SetWindowPosFlags.NOZORDER |
                    SetWindowPosFlags.FRAMECHANGED | SetWindowPosFlags.SHOWWINDOW);

                // Make sure the client rectangle does not change when changing the border style.
                //ClientSize = current_size;

                //CreateParams cp = new CreateParams();
                //cp.Caption = this.Title;
                //cp.X = X;
                //cp.Y = Y;
                //cp.Width = Width;
                //cp.Height = Height;
                //cp.Style = (int)style;
                //cp.ExStyle = unchecked((int)(uint)Functions.GetWindowLong(Handle, GetWindowLongOffsets.EXSTYLE));
                //cp.ClassStyle = (int)ClassStyle;
                //base.DestroyHandle();
                //base.CreateHandle(cp);
            }
        }

        protected override void OnHandleChange()
        {
            base.OnHandleChange();

            if (window != null)
                window.Dispose();
            
            window = new WinWindowInfo(Handle, null);

            if (WindowInfoChanged != null)
                WindowInfoChanged(this, EventArgs.Empty);
        }

        #endregion

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool calledManually)
        {
            if (!disposed)
            {
                if (calledManually)
                {
                    // Safe to clean managed resources
                    if (Exists)
                        DestroyWindow();

                    WindowInfo.Dispose();
                }
                else
                {
                    Debug.Print("[Warning] INativeWindow leaked ({0}). Did you forget to call INativeWindow.Dispose()?", this);
                }

                disposed = true;
            }
        }

        ~WinGLNative()
        {
            Dispose(false);
        }

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
