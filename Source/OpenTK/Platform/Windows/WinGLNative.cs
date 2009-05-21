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
    internal sealed class WinGLNative : INativeWindow
    {
        #region --- Fields ---

        readonly IntPtr Instance = Marshal.GetHINSTANCE(typeof(WinGLNative).Module);
        readonly string ClassName = "OpenTK.INativeWindow" + WindowCount++.ToString();
        WindowProcedure WindowProcedureDelegate;

        IInputDriver driver;

        bool visible = true;
        bool disposed;
        bool exists;
        WinWindowInfo window;
        WindowBorder windowBorder = WindowBorder.Resizable, previous_window_border;
        WindowState windowState = WindowState.Normal;

        System.Drawing.Rectangle previous_client_area;

        System.Drawing.Rectangle bounds = new System.Drawing.Rectangle();
        System.Drawing.Rectangle client_rectangle = new System.Drawing.Rectangle();

        ResizeEventArgs resizeEventArgs = new ResizeEventArgs();

        static readonly ClassStyle ClassStyle =
            ClassStyle.OwnDC | ClassStyle.VRedraw | ClassStyle.HRedraw | ClassStyle.Ime;

        static int WindowCount = 0; // Used to create unique window class names.

        IntPtr DefaultWindowProcedure =
            Marshal.GetFunctionPointerForDelegate(new WindowProcedure(Functions.DefWindowProc));

        #endregion

        #region --- Contructors ---

        public WinGLNative(int x, int y, int width, int height, string title, GameWindowFlags options, DisplayDevice device)
        {
            // Use win32 to create the native window.
            // Keep in mind that some construction code runs in the WM_CREATE message handler.

            WindowStyle style = WindowStyle.Visible | WindowStyle.ClipChildren |
                WindowStyle.ClipSiblings | WindowStyle.OverlappedWindow;

            ExtendedWindowStyle ex_style = ExtendedWindowStyle.OverlappedWindow;

            // Find out the final window rectangle, after the WM has added its chrome (titlebar, sidebars etc).
            Rectangle rect = new Rectangle();
            rect.left = x; rect.top = y; rect.right = x + width; rect.bottom = y + height;
            Functions.AdjustWindowRectEx(ref rect, style, false, ex_style);

            // This is the main window procedure callback (called WndProc in the win32 world).
            WindowProcedureDelegate = WindowProcedure;

            // Create the window class that we will use for this window.
            // The current approach is to register a new class for each WinNativeWindow we create.
            ExtendedWindowClass wc = new ExtendedWindowClass();
            wc.Size = ExtendedWindowClass.SizeInBytes;
            wc.Style = ClassStyle;
            wc.Instance = Instance;
            //wc.WndProc = Marshal.GetFunctionPointerForDelegate(WindowProcedureDelegate);
            wc.WndProc = WindowProcedureDelegate;
            wc.ClassName = ClassName;
            //wc.Background = Functions.GetStockObject(5);
            ushort atom = Functions.RegisterClassEx(ref wc);

            if (atom == 0)
                throw new Exception(String.Format("Failed to register window class. Error: {0}", Marshal.GetLastWin32Error()));

            wc = new ExtendedWindowClass();
            wc.Size = ExtendedWindowClass.SizeInBytes;
            //if (!Functions.GetClassInfoEx(Instance, ClassName, ref wc))
            //{
            //}

            IntPtr handle = IntPtr.Zero;

            // Todo: Is this necessary? C strings are null terminated.
            // Maybe we should add an overload to handle the marshaling automatically?
            handle = Functions.CreateWindowEx(
               ex_style, ClassName, title, style,
               rect.left, rect.right, rect.Width, rect.Height,
               IntPtr.Zero, IntPtr.Zero, Instance, IntPtr.Zero);
            // Todo: make exception more specific.

            if (handle == IntPtr.Zero)
                throw new Exception(String.Format("Failed to create window. Error: {0}", Marshal.GetLastWin32Error()));

            window = new WinWindowInfo(handle, null);

            Location = new Point(x, y);
            ClientSize = new Size(width, height);
        }

        #endregion

        #region --- Protected Members ---

        #region WindowProcedure

        IntPtr WindowProcedure(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            switch (message)
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
                        WindowPosition* pos = (WindowPosition*)lParam;
                        bounds.X = pos->x;
                        bounds.Y = pos->y;
                        bounds.Width = pos->cx;
                        bounds.Height = pos->cy;

                        Rectangle rect;
                        Functions.GetClientRect(window.WindowHandle, out rect);
                        client_rectangle = rect.ToRectangle();
                    }

                    if (Resize != null)
                        Resize(this, EventArgs.Empty);
                    break;

                case WindowMessage.STYLECHANGED:
                    WindowStyle style = (WindowStyle)(long)Functions.GetWindowLong(window.WindowHandle, GetWindowLongOffsets.STYLE);
                    if ((style & WindowStyle.Popup) != 0)
                        windowBorder = WindowBorder.Hidden;
                    else if ((style & WindowStyle.ThickFrame) != 0)
                        windowBorder = WindowBorder.Resizable;
                    else if ((style & ~(WindowStyle.ThickFrame | WindowStyle.MaximizeBox)) != 0)
                        windowBorder = WindowBorder.Fixed;

                    //ClientRectangle = ClientRectangle;
                    break;

                case WindowMessage.SIZE:
                    SizeMessage state = (SizeMessage)wParam.ToInt64();
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
                    CreateStruct cs = (CreateStruct)Marshal.PtrToStructure(lParam, typeof(CreateStruct));
                    bounds.X = cs.x;
                    bounds.Y = cs.y;
                    bounds.Width = cs.cx;
                    bounds.Height = cs.cy;

                    // Raise the Create event
                    this.OnCreate(EventArgs.Empty);
                    return IntPtr.Zero;

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

                    return IntPtr.Zero;

                case WindowMessage.DESTROY:
                    exists = false;
                    
                    if (Closed != null)
                        Closed(this, EventArgs.Empty);
                    
                    break;
            }

            return Functions.DefWindowProc(handle, message, wParam, lParam);
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
                Functions.SetWindowPos(window.WindowHandle, IntPtr.Zero, value.X, value.Y, value.Width, value.Height, 0);
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
                Functions.SetWindowPos(window.WindowHandle, IntPtr.Zero, value.X, value.Y, 0, 0, SetWindowPosFlags.NOSIZE);
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
                Functions.SetWindowPos(window.WindowHandle, IntPtr.Zero, 0, 0, value.Width, value.Height, SetWindowPosFlags.NOMOVE);
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
                WindowStyle style = (WindowStyle)Functions.GetWindowLong(window.WindowHandle, GetWindowLongOffsets.STYLE);
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
                ret = Functions.GetMessage(ref msg, window.WindowHandle, 0, 0);
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
                MSG message = new MSG();
                return !Functions.PeekMessage(ref message, window.WindowHandle, 0, 0, 0);
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
                    Functions.ShowWindow(window.WindowHandle, ShowWindowCommand.SHOWNORMAL);
                    visible = true;
                }
                else if (!value && Visible)
                {
                    Functions.ShowWindow(window.WindowHandle, ShowWindowCommand.HIDE);
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
            this.window = new WinWindowInfo(window.WindowHandle, null);
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
            if (!Functions.ScreenToClient(window.WindowHandle, ref point))
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

                UIntPtr style = Functions.GetWindowLong(window.WindowHandle, GetWindowLongOffsets.STYLE);
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

                Functions.ShowWindow(window.WindowHandle, command);
                Functions.SetWindowPos(window.WindowHandle, IntPtr.Zero, 0, 0, 0, 0, flags);

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

                Functions.SetWindowLong(window.WindowHandle, GetWindowLongOffsets.STYLE, (IntPtr)(int)style);
                Functions.SetWindowPos(window.WindowHandle, IntPtr.Zero, Bounds.X, Bounds.Y, Bounds.Width, Bounds.Height,
                    SetWindowPosFlags.NOMOVE | SetWindowPosFlags.NOSIZE | SetWindowPosFlags.NOZORDER |
                    SetWindowPosFlags.FRAMECHANGED | SetWindowPosFlags.SHOWWINDOW);

                // Make sure the client rectangle does not change when changing the border style.
                //ClientSize = current_size;
            }
        }

        void OnHandleChange()
        {
            if (window != null)
                window.Dispose();
            
            window = new WinWindowInfo(window.WindowHandle, null);

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

        void Dispose(bool calledManually)
        {
            if (!disposed)
            {
                if (calledManually)
                {
                    // Safe to clean managed resources
                    if (Exists)
                    {
                        window.Dispose();
                        Functions.DestroyWindow(window.WindowHandle);
                        Functions.UnregisterClass(ClassName, Instance);
                    }
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
}
