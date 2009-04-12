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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenTK.Graphics;

namespace OpenTK.Platform
{
    sealed class WinFormsNativeWindow : Form, INativeWindow
    {
        #region Fields

        GLControl control;

        EventHandler<EventArgs> event_load = delegate(object sender, EventArgs e) { };
        EventHandler<EventArgs> event_unload = delegate(object sender, EventArgs e) { };
        EventHandler<ResizeEventArgs> event_resize = delegate(object sender, ResizeEventArgs e) { };
        EventHandler<CancelEventArgs> event_closing = delegate(object sender, CancelEventArgs e) { };
        EventHandler<EventArgs> event_closed = delegate(object sender, EventArgs e) { };
        EventHandler<EventArgs> event_idle = delegate(object sender, EventArgs e) { };

        ResizeEventArgs resize_args = new ResizeEventArgs();

        bool exiting, disposed;

        object event_lock = new object();

        IMessageFilter input_filter;

        #endregion

        #region Constructors

        public WinFormsNativeWindow(GraphicsMode mode, int major, int minor, GraphicsContextFlags flags, DisplayDevice device)
            : this(String.Empty, Point.Empty, Size.Empty, Size.Empty, mode, major, minor, flags, device)
        {
        }

        public WinFormsNativeWindow(string title, Point location, Size size, Size client_size, GraphicsMode mode,
            int major, int minor, GraphicsContextFlags flags, DisplayDevice device)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);

            KeyPreview = true;

            GraphicsControl = new GLControl(mode, major, minor, flags);

            SuspendLayout();
            GraphicsControl.Dock = DockStyle.Fill;
            GraphicsControl.Name = GraphicsControl.Text = "GraphicsControl";
            GraphicsControl.TabIndex = 0;
            GraphicsControl.VSync = true;

            Text = title;

            if (location != Point.Empty)
                (this as INativeWindow).Location = location;
            if (size != Size.Empty)
                (this as INativeWindow).Size = size;
            if (client_size != Size.Empty)
                (this as INativeWindow).Viewport = new Rectangle(Point.Empty, client_size);

            Controls.Add(GraphicsControl);
            ResumeLayout(true);
        }

        #endregion

        #region INativeWindow Members

        #region Events

        event EventHandler<EventArgs> INativeWindow.Load
        {
            add { lock (event_lock) { event_load += value; } }
            remove { lock (event_lock) { event_load -= value; } }
        }

        event EventHandler<EventArgs> INativeWindow.Unload
        {
            add { lock (event_lock) { event_unload += value; } }
            remove { lock (event_lock) { event_unload -= value; } }
        }

        event EventHandler<ResizeEventArgs> INativeWindow.Resize
        {
            add { lock (event_lock) { event_resize += value; } }
            remove { lock (event_lock) { event_resize -= value; } }
        }

        event EventHandler<CancelEventArgs> INativeWindow.Closing
        {
            add { lock (event_lock) { event_closing += value; } }
            remove { lock (event_lock) { event_closing -= value; } }
        }

        event EventHandler<EventArgs> INativeWindow.Closed
        {
            add { lock (event_lock) { event_closed += value; } }
            remove { lock (event_lock) { event_closed -= value; } }
        }

        event EventHandler<EventArgs> INativeWindow.Idle
        {
            add { lock (event_lock) { event_idle += value; } }
            remove { lock (event_lock) { event_idle -= value; } }
        }

        #endregion

        #region Position

        Point INativeWindow.Location
        {
            get { return Location; }
            set { Location = value; }
        }

        Size INativeWindow.Size
        {
            get { return Size; }
            set { Size = value; }
        }

        int INativeWindow.X { get { return Location.X; } }
        int INativeWindow.Y { get { return Location.Y; } }
        int INativeWindow.Width { get { return Width; } }
        int INativeWindow.Height { get { return Height; } }

        #endregion

        #region Window

        string INativeWindow.Title
        {
            get { return Text; }
            set { Text = value; }
        }

        Icon INativeWindow.Icon
        {
            get { return Icon; }
            set { Icon = value; }
        }

        WindowState INativeWindow.WindowState
        {
            get
            {
                if (base.WindowState == FormWindowState.Maximized && base.FormBorderStyle == FormBorderStyle.None)
                    return OpenTK.WindowState.Fullscreen;

                if (base.WindowState == FormWindowState.Maximized)
                    return OpenTK.WindowState.Maximized;

                if (base.WindowState == FormWindowState.Normal)
                    return OpenTK.WindowState.Normal;

                if (base.WindowState == FormWindowState.Minimized)
                    return OpenTK.WindowState.Minimized;

                throw new InvalidOperationException();
            }
            set
            {
                switch (value)
                {
                    case OpenTK.WindowState.Fullscreen:
                        base.FormBorderStyle = FormBorderStyle.None;
                        base.WindowState = FormWindowState.Maximized;
                        break;

                    case OpenTK.WindowState.Maximized:
                        base.WindowState = FormWindowState.Maximized;
                        break;

                    case OpenTK.WindowState.Normal:
                        base.WindowState = FormWindowState.Normal;
                        break;

                    case OpenTK.WindowState.Minimized:
                        base.WindowState = FormWindowState.Minimized;
                        break;
                }
            }
        }

        WindowBorder INativeWindow.WindowBorder
        {
            get
            {
                if (base.FormBorderStyle == FormBorderStyle.None)
                    return WindowBorder.Hidden;

                if (base.FormBorderStyle == FormBorderStyle.Sizable ||
                    base.FormBorderStyle == FormBorderStyle.SizableToolWindow)
                    return WindowBorder.Resizable;

                if (base.FormBorderStyle == FormBorderStyle.Fixed3D ||
                    base.FormBorderStyle == FormBorderStyle.FixedDialog ||
                    base.FormBorderStyle == FormBorderStyle.FixedSingle)
                    return WindowBorder.Fixed;

                throw new NotSupportedException();
            }
            set
            {
                switch (value)
                {
                    case WindowBorder.Resizable:
                        base.FormBorderStyle = FormBorderStyle.Sizable;
                        break;

                    case WindowBorder.Fixed:
                        base.FormBorderStyle = FormBorderStyle.Fixed3D;
                        break;

                    case WindowBorder.Hidden:
                        base.FormBorderStyle = FormBorderStyle.None;
                        break;

                    default:
                        throw new NotSupportedException();
                }
            }
        }

        #endregion

        #region Context

        IGraphicsContext INativeWindow.Context
        {
            get { return GraphicsControl.Context; }
        }

        Rectangle INativeWindow.Viewport
        {
            get { return ClientRectangle; }
            set { SetClientSizeCore(value.Width, value.Height); }
        }

        #endregion

        #region Methods

        void INativeWindow.Run()
        {
            Application.Idle += delegate(object sender, EventArgs e)
            {
                while (IsIdle && !exiting)
                    event_idle(this, EventArgs.Empty);
            };

            //if (!Application.MessageLoop)
            //    Application.Run(this);
            //else
            ShowDialog();
        }

        void INativeWindow.Close()
        {
            Close();
        }

        #endregion

        #endregion

        #region Protected Members

        protected override void OnLoad(EventArgs e)
        {
            OnResize(EventArgs.Empty);

            base.OnLoad(e);
            event_load(this, e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            resize_args.Location = (this as INativeWindow).Location;
            resize_args.Size = (this as INativeWindow).Size;
            resize_args.Viewport = (this as INativeWindow).Viewport;
            event_resize(this, resize_args);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            event_closing(this, e);

            if (!e.Cancel)
            {
                exiting = true;
                event_unload(this, e);
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            event_closed(this, e);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            input_filter = new EventFilter(Handle);
            Application.AddMessageFilter(input_filter);
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);

            Application.RemoveMessageFilter(input_filter);
            input_filter = null;
        }

        #endregion

        #region Private Members

        GLControl GraphicsControl
        {
            get { return control; }
            set { control = value; }
        }

        bool IsIdle
        {
            get { return GraphicsControl.IsIdle; }
        }

        #endregion

        #region IDisposable Members

        protected override void Dispose(bool manual)
        {
            if (!disposed)
            {
                exiting = true;

                if (manual)
                {
                    GraphicsControl.Dispose();
                    event_closed = null;
                    event_closing = null;
                    event_idle = null;
                    event_load = null;
                    event_resize = null;
                    event_unload = null;
                }

                base.Dispose(manual);
                disposed = true;
            }
        }

        #endregion

        #region class EventFilter

        // Windows.Forms allocate EventArgs on the heap every time you move your mouse or press a keyboard key.
        // We cannot have that! As a workaround, we'll filter these messages and write our own event handlers.
        class EventFilter : IMessageFilter
        {
            IntPtr handle;

            public EventFilter(IntPtr handle)
            {
                this.handle = handle;
            }

            public bool PreFilterMessage(ref Message m)
            {
                //if (m.HWnd != handle)
                //   return false;

                switch (m.Msg)
                {
                    case WM_KEYDOWN:
                    case WM_KEYUP:
                    case WM_LBUTTONDBLCLK:
                    case WM_LBUTTONDOWN:
                    case WM_LBUTTONUP:
                    case WM_MBUTTONDBLCLK:
                    case WM_MBUTTONDOWN:
                    case WM_MBUTTONUP:
                    case WM_MOUSEMOVE:
                    case WM_MOUSEWHEEL:
                    case WM_RBUTTONDBLCLK:
                    case WM_RBUTTONDOWN:
                    case WM_RBUTTONUP:
                    case WM_SYSKEYDOWN:
                    case WM_SYSKEYUP:
                    case WM_XBUTTONDBLCLK:
                    case WM_XBUTTONDOWN:
                    case WM_XBUTTONUP:
                        return true;
                    default: return false;
                }
            }

            const int WM_KEYDOWN = 0x0100;
            const int WM_KEYUP = 0x0101;
            const int WM_SYSKEYDOWN = 0x0104;
            const int WM_SYSKEYUP = 0x0105;
            const int WM_MOUSEMOVE = 0x0200;
            const int WM_LBUTTONDOWN = 0x0201;
            const int WM_LBUTTONUP = 0x0202;
            const int WM_LBUTTONDBLCLK = 0x0203;
            const int WM_RBUTTONDOWN = 0x0204;
            const int WM_RBUTTONUP = 0x0205;
            const int WM_RBUTTONDBLCLK = 0x0206;
            const int WM_MBUTTONDOWN = 0x0207;
            const int WM_MBUTTONUP = 0x0208;
            const int WM_MBUTTONDBLCLK = 0x0209;
            const int WM_MOUSEWHEEL = 0x020A;
            const int WM_XBUTTONDOWN = 0x020B;
            const int WM_XBUTTONUP = 0x020C;
            const int WM_XBUTTONDBLCLK = 0x020D;
        }

        #endregion
    }
}
