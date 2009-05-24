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
using OpenTK.Graphics;
using OpenTK.Input;
using System.Collections.Generic;

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// Drives GameWindow on Windows.
    /// This class supports OpenTK, and is not intended for use by OpenTK programs.
    /// </summary>
    internal sealed class WinGLNative : INativeWindow, IInputDriver
    {
        #region Fields

        readonly IntPtr Instance = Marshal.GetHINSTANCE(typeof(WinGLNative).Module);
        readonly IntPtr ClassName = Marshal.StringToHGlobalUni("OpenTK.INativeWindow" + WindowCount++.ToString());
        readonly WindowProcedure WindowProcedureDelegate;

        bool class_registered;
        bool visible = true;
        bool disposed;
        bool exists;
        WinWindowInfo window, child_window;
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

        // Used for IInputDriver implementation
        WinMMJoystick joystick_driver = new WinMMJoystick();
        KeyboardDevice keyboard = new KeyboardDevice();
        MouseDevice mouse = new MouseDevice();
        IList<KeyboardDevice> keyboards = new List<KeyboardDevice>(1);
        IList<MouseDevice> mice = new List<MouseDevice>(1);
        internal static readonly WinKeyMap KeyMap = new WinKeyMap();
        const long ExtendedBit = 1 << 24;           // Used to distinguish left and right control, alt and enter keys.
        static readonly uint ShiftRightScanCode = Functions.MapVirtualKey(VirtualKeys.RSHIFT, 0);         // Used to distinguish left and right shift keys.

        #endregion

        #region Contructors

        public WinGLNative(int x, int y, int width, int height, string title, GameWindowFlags options, DisplayDevice device)
        {
            // This is the main window procedure callback. We need the callback in order to create the window, so
            // don't move it below the CreateWindow calls.
            WindowProcedureDelegate = WindowProcedure;

            // To avoid issues with Ati drivers on Windows 6+ with compositing enabled, the context will not be
            // bound to the top-level window, but rather to a child window docked in the parent.
            window = new WinWindowInfo(
                CreateWindow(x, y, width, height, title, options, device, IntPtr.Zero), null);
            child_window = new WinWindowInfo(
                CreateWindow(0, 0, ClientSize.Width, ClientSize.Height, title, options, device, window.WindowHandle), window);

            exists = true;

            keyboard.Description = "Standard Windows keyboard";
            keyboard.NumberOfFunctionKeys = 12;
            keyboard.NumberOfKeys = 101;
            keyboard.NumberOfLeds = 3;

            mouse.Description = "Standard Windows mouse";
            mouse.NumberOfButtons = 3;
            mouse.NumberOfWheels = 1;

            keyboards.Add(keyboard);
            mice.Add(mouse);
        }

        #endregion

        #region Private Members

        #region WindowProcedure

        IntPtr WindowProcedure(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam)
        {
            bool mouse_about_to_enter = false;

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

                case WindowMessage.ERASEBKGND:
                    return new IntPtr(1);

                case WindowMessage.WINDOWPOSCHANGED:
                    unsafe
                    {
                        WindowPosition* pos = (WindowPosition*)lParam;

                        bounds.X = pos->x;
                        bounds.Y = pos->y;
                        bounds.Width = pos->cx;
                        bounds.Height = pos->cy;

                        Rectangle rect;
                        Functions.GetClientRect(handle, out rect);
                        client_rectangle = rect.ToRectangle();

                        if (pos->hwnd == window.WindowHandle)
                        {
                            Functions.SetWindowPos(child_window.WindowHandle, IntPtr.Zero, 0, 0, ClientRectangle.Width, ClientRectangle.Height,
                                SetWindowPosFlags.NOZORDER | SetWindowPosFlags.NOOWNERZORDER |
                                SetWindowPosFlags.NOACTIVATE | SetWindowPosFlags.NOSENDCHANGING);
                        }

                        if (Resize != null)
                            Resize(this, EventArgs.Empty);
                    }
                    break;

                case WindowMessage.STYLECHANGED:
                    WindowStyle style = (WindowStyle)(long)Functions.GetWindowLong(handle, GetWindowLongOffsets.STYLE);
                    if ((style & WindowStyle.Popup) != 0)
                        windowBorder = WindowBorder.Hidden;
                    else if ((style & WindowStyle.ThickFrame) != 0)
                        windowBorder = WindowBorder.Resizable;
                    else if ((style & ~(WindowStyle.ThickFrame | WindowStyle.MaximizeBox)) != 0)
                        windowBorder = WindowBorder.Fixed;

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

                #region Input events

                // Mouse events:
                case WindowMessage.NCMOUSEMOVE:
                    mouse_about_to_enter = true;   // Used to simulate a mouse enter event.
                    break;

                case WindowMessage.MOUSEMOVE:
                    mouse.Position = new System.Drawing.Point(
                                                        (int)(lParam.ToInt32() & 0x0000FFFF),
                                                        (int)(lParam.ToInt32() & 0xFFFF0000) >> 16);
                    if (mouse_about_to_enter)
                    {
                        //Cursor.Current = Cursors.Default;
                        mouse_about_to_enter = false;
                    }
                    break;

                case WindowMessage.MOUSEWHEEL:
                    // This is due to inconsistent behavior of the WParam value on 64bit arch, whese
                    // wparam = 0xffffffffff880000 or wparam = 0x00000000ff100000
                    mouse.Wheel += (int)((long)msg.WParam << 32 >> 48) / 120;
                    break;

                case WindowMessage.LBUTTONDOWN:
                    mouse[MouseButton.Left] = true;
                    break;

                case WindowMessage.MBUTTONDOWN:
                    mouse[MouseButton.Middle] = true;
                    break;

                case WindowMessage.RBUTTONDOWN:
                    mouse[MouseButton.Right] = true;
                    break;

                case WindowMessage.XBUTTONDOWN:
                    mouse[((wParam.ToInt32() & 0xFFFF0000) >> 16) != (int)MouseKeys.XButton1 ? MouseButton.Button1 : MouseButton.Button2] = true;
                    break;

                case WindowMessage.LBUTTONUP:
                    mouse[MouseButton.Left] = false;
                    break;

                case WindowMessage.MBUTTONUP:
                    mouse[MouseButton.Middle] = false;
                    break;

                case WindowMessage.RBUTTONUP:
                    mouse[MouseButton.Right] = false;
                    break;

                case WindowMessage.XBUTTONUP:
                    // TODO: Is this correct?
                    mouse[((wParam.ToInt32() & 0xFFFF0000) >> 16) != (int)MouseKeys.XButton1 ? MouseButton.Button1 : MouseButton.Button2] = false;
                    break;

                // Keyboard events:
                case WindowMessage.KEYDOWN:
                case WindowMessage.KEYUP:
                case WindowMessage.SYSKEYDOWN:
                case WindowMessage.SYSKEYUP:
                    bool pressed =
                        message == WindowMessage.KEYDOWN ||
                        message == WindowMessage.SYSKEYDOWN;

                    // Shift/Control/Alt behave strangely when e.g. ShiftRight is held down and ShiftLeft is pressed
                    // and released. It looks like neither key is released in this case, or that the wrong key is
                    // released in the case of Control and Alt.
                    // To combat this, we are going to release both keys when either is released. Hacky, but should work.
                    // Win95 does not distinguish left/right key constants (GetAsyncKeyState returns 0).
                    // In this case, both keys will be reported as pressed.

                    bool extended = (msg.LParam.ToInt64() & ExtendedBit) != 0;
                    switch ((VirtualKeys)wParam)
                    {
                        case VirtualKeys.SHIFT:
                            // The behavior of this key is very strange. Unlike Control and Alt, there is no extended bit
                            // to distinguish between left and right keys. Moreover, pressing both keys and releasing one
                            // may result in both keys being held down (but not always).
                            // The only reliably way to solve this was reported by BlueMonkMN at the forums: we should
                            // check the scancodes. It looks like GLFW does the same thing, so it should be reliable.

                            // TODO: Not 100% reliable, when both keys are pressed at once.
                            if (ShiftRightScanCode != 0)
                            {
                                unchecked
                                {
                                    if (((lParam.ToInt32() >> 16) & 0xFF) == ShiftRightScanCode)
                                        keyboard[Input.Key.ShiftRight] = pressed;
                                    else
                                        keyboard[Input.Key.ShiftLeft] = pressed;
                                }
                            }
                            else
                            {
                                // Should only fall here on Windows 9x and NT4.0-
                                keyboard[Input.Key.ShiftLeft] = pressed;
                            }
                            break;

                        case VirtualKeys.CONTROL:
                            if (extended)
                                keyboard[Input.Key.ControlRight] = pressed;
                            else
                                keyboard[Input.Key.ControlLeft] = pressed;
                            break;

                        case VirtualKeys.MENU:
                            if (extended)
                                keyboard[Input.Key.AltRight] = pressed;
                            else
                                keyboard[Input.Key.AltLeft] = pressed;
                            break;

                        case VirtualKeys.RETURN:
                            if (extended)
                                keyboard[Key.KeypadEnter] = pressed;
                            else
                                keyboard[Key.Enter] = pressed;
                            break;

                        default:
                            if (!WMInput.KeyMap.ContainsKey((VirtualKeys)msg.WParam))
                            {
                                Debug.Print("Virtual key {0} ({1}) not mapped.", (VirtualKeys)msg.WParam, (int)msg.WParam);
                                break;
                            }
                            else
                            {
                                keyboard[WMInput.KeyMap[(VirtualKeys)msg.WParam]] = pressed;
                            }
                            break;
                    }
                    break;

                case WindowMessage.KILLFOCUS:
                    keyboard.ClearKeys();
                    break;

                #endregion

                case WindowMessage.CREATE:
                    // Set the window width and height:
                    CreateStruct cs = (CreateStruct)Marshal.PtrToStructure(lParam, typeof(CreateStruct));
                    bounds.X = cs.x;
                    bounds.Y = cs.y;
                    bounds.Width = cs.cx;
                    bounds.Height = cs.cy;

                    break;

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

                    Functions.UnregisterClass(ClassName, Instance);
                    Marshal.FreeHGlobal(ClassName);
                    window.Dispose();
                    //window = null;

                    if (Closed != null)
                        Closed(this, EventArgs.Empty);
                    
                    break;
            }

            return Functions.DefWindowProc(handle, message, wParam, lParam);
        }

        #endregion

        #region IsIdle

       bool IsIdle
        {
            get
            {
                MSG message = new MSG();
                return !Functions.PeekMessage(ref message, window.WindowHandle, 0, 0, 0);
            }
        }

        #endregion

        #region CreateWindow

        IntPtr CreateWindow(int x, int y, int width, int height, string title, GameWindowFlags options, DisplayDevice device, IntPtr parentHandle)
        {
            // Use win32 to create the native window.
            // Keep in mind that some construction code runs in the WM_CREATE message handler.

            WindowStyle style =
                WindowStyle.Visible | WindowStyle.ClipChildren |
                WindowStyle.ClipSiblings |
                (parentHandle == IntPtr.Zero ? WindowStyle.OverlappedWindow : WindowStyle.Child);

            ExtendedWindowStyle ex_style =
                (parentHandle == IntPtr.Zero ? ExtendedWindowStyle.OverlappedWindow : 0);

            // Find out the final window rectangle, after the WM has added its chrome (titlebar, sidebars etc).
            Rectangle rect = new Rectangle();
            rect.left = x; rect.top = y; rect.right = x + width; rect.bottom = y + height;
            Functions.AdjustWindowRectEx(ref rect, style, false, ex_style);

            // Create the window class that we will use for this window.
            // The current approach is to register a new class for each top-level WinGLWindow we create.
            if (!class_registered)
            {
                ExtendedWindowClass wc = new ExtendedWindowClass();
                wc.Size = ExtendedWindowClass.SizeInBytes;
                wc.Style = ClassStyle;
                wc.Instance = Instance;
                wc.WndProc = WindowProcedureDelegate;
                wc.ClassName = ClassName;
                //wc.Background = Functions.GetStockObject(5);
                ushort atom = Functions.RegisterClassEx(ref wc);

                if (atom == 0)
                    throw new PlatformException(String.Format("Failed to register window class. Error: {0}", Marshal.GetLastWin32Error()));

                class_registered = true;
            }

            // Create the actual window
            IntPtr handle = Functions.CreateWindowEx(
                ex_style, ClassName, IntPtr.Zero, style,
                rect.left, rect.top, rect.Width, rect.Height,
                parentHandle, IntPtr.Zero, Instance, IntPtr.Zero);

            if (handle == IntPtr.Zero)
                throw new PlatformException(String.Format("Failed to create window. Error: {0}", Marshal.GetLastWin32Error()));

            return handle;
        }

        #endregion

        #region DestroyWindow

        /// <summary>
        /// Starts the teardown sequence for the current window.
        /// </summary>
        void DestroyWindow()
        {
            if (Exists)
            {
                Debug.Print("Destroying window: {0}", window.ToString());
                Functions.DestroyWindow(window.WindowHandle);
                exists = false;
            }
        }

        #endregion

        #endregion

        #region INativeWindow Members

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

        #region Title

        StringBuilder sb_title = new StringBuilder(256);
        public string Title
        {
            get
            {
                sb_title.Remove(0, sb_title.Length);
                Functions.GetWindowText(window.WindowHandle, sb_title, sb_title.MaxCapacity);
                return sb_title.ToString();
            }
            set
            {
                bool ret = Functions.SetWindowText(window.WindowHandle, value);

                if (ret)
                    Debug.Print("Window {0} title changed to '{1}'.", window.WindowHandle, Title);
                else
                    Debug.Print("Window {0} title failed to change to '{1}'.", window.WindowHandle, Title);
            }
        }

        #endregion

        #region Visible

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

        #region Exists

        public bool Exists { get { return exists; } }

        #endregion

        #region Close

        public void Close()
        {
            DestroyWindow();
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

        #region INativeGLWindow Members

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
                    throw new PlatformException(String.Format(
                        "An error happened while processing the message queue. Windows error: {0}",
                        Marshal.GetLastWin32Error()));
                }

                Functions.DispatchMessage(ref msg);
            }
        }

        #endregion

        #region public IInputDriver InputDriver

        public IInputDriver InputDriver
        {
            get { return this; }
        }

        #endregion

        #region public IWindowInfo WindowInfo

        public IWindowInfo WindowInfo
        {
            get { return child_window; }
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

        #endregion

        #region IInputDriver Members

        public void Poll()
        {
            joystick_driver.Poll();
        }

        #endregion

        #region IKeyboardDriver Members

        public IList<KeyboardDevice> Keyboard
        {
            get { return keyboards; }
        }

        #endregion

        #region IMouseDriver Members

        public IList<MouseDevice> Mouse
        {
            get { return mice; }
        }

        #endregion

        #region IJoystickDriver Members

        public IList<JoystickDevice> Joysticks
        {
            get { return joystick_driver.Joysticks; }
        }

        #endregion

        #region IDisposable Members

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
                    DestroyWindow();
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
