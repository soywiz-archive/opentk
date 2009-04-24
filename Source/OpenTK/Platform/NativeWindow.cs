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
using System.Text;
using System.ComponentModel;
using System.Drawing;
using OpenTK.Graphics;

namespace OpenTK.Platform
{
    public class NativeWindow : INativeWindow
    {
        #region Fields

        INativeWindow implementation;
        bool disposed;

        #endregion

        #region Constructors

        public NativeWindow(string title, Point location, Size size, Size clientSize, GraphicsMode mode,
            int major, int minor, GraphicsContextFlags flags, DisplayDevice device)
            : this(new WinFormsNativeWindow(title, location, size, clientSize, mode, major, minor, flags, device))
        {
        }

        public NativeWindow(INativeWindow implementation)
        {
            if (implementation == null)
                throw new ArgumentNullException("implementation");

            this.implementation = implementation;
            implementation.Load += delegate(object sender, EventArgs e) { OnLoadInternal(e); };
            implementation.Resize += delegate(object sender, ResizeEventArgs e) { OnResizeInternal(e); };
            implementation.Unload += delegate(object sender, EventArgs e) { OnUnloadInternal(e); };
            implementation.Idle += delegate(object sender, EventArgs e) { OnIdleInternal(e); };
            implementation.Closing += delegate(object sender, CancelEventArgs e) { OnClosingInternal(e); };
            implementation.Closed += delegate(object sender, EventArgs e) { OnClosedInternal(e); };
        }

        #endregion

        #region IWindowInfo Members

        #endregion

        #region INativeWindow Members

        public event EventHandler<EventArgs> Load = delegate(object sender, EventArgs e) { };

        public event EventHandler<EventArgs> Unload = delegate(object sender, EventArgs e) { };

        public event EventHandler<ResizeEventArgs> Resize = delegate(object sender, ResizeEventArgs e) { };

        public event EventHandler<CancelEventArgs> Closing = delegate(object sender, CancelEventArgs e) { };

        public event EventHandler<EventArgs> Closed = delegate(object sender, EventArgs e) { };

        public event EventHandler<EventArgs> Idle = delegate(object sender, EventArgs e) { };

        public Point Location { get { return implementation.Location; } set { implementation.Location = value; } }

        public Size Size { get { return implementation.Size; } set { implementation.Size = value; } }

        public Rectangle Viewport { get { return implementation.Viewport; } set { implementation.Viewport = value; } }

        public int X { get { return implementation.X; } }

        public int Y { get { return implementation.Y; } }

        public int Width
        {
            get { return implementation.Width; }
            set { implementation.Size = new Size(value, implementation.Height); }
        }

        public int Height
        {
            get { return implementation.Height; }
            set { implementation.Size = new Size(implementation.Width, value); }
        }

        public Icon Icon
        {
            get { return implementation.Icon; }
            set { implementation.Icon = value; }
        }

        public WindowState WindowState
        {
            get { return implementation.WindowState; }
            set { implementation.WindowState = value; }
        }

        public WindowBorder WindowBorder
        {
            get { return implementation.WindowBorder; }
            set { implementation.WindowBorder = value; }
        }

        public bool Visible
        {
            get { return implementation.Visible; }
            set { implementation.Visible = value; }
        }

        public IGraphicsContext Context
        {
            get { return implementation.Context; }
        }

        public virtual void Run()
        {
            implementation.Run();
        }

        public void Close()
        {
            implementation.Close();
        }

        public string Title { get { return implementation.Title; } set { implementation.Title = value; } }

        #endregion

        #region Protected Members

        protected virtual void OnLoad(EventArgs e)
        {
        }

        protected virtual void OnUnload(EventArgs e)
        {
        }

        protected virtual void OnResize(ResizeEventArgs e)
        {
        }

        protected virtual void OnIdle(EventArgs e)
        {
        }

        protected virtual void OnClosing(CancelEventArgs e)
        {
        }

        protected virtual void OnClosed(EventArgs e)
        {
        }

        #endregion

        #region Private Members

        void OnLoadInternal(EventArgs e)
        {
            OnLoad(e);
            Load(this, e);
        }

        void OnUnloadInternal(EventArgs e)
        {
            implementation.Idle -= delegate(object sender, EventArgs args) { OnIdleInternal(args); };
            OnUnload(e);

            Unload(this, e);
        }

        void OnResizeInternal(ResizeEventArgs e)
        {
            GL.Viewport(e.Viewport.X, e.Viewport.Y, e.Viewport.Width, e.Viewport.Height);

            OnResize(e);
            Resize(this, e);
        }

        void OnIdleInternal(EventArgs e)
        {
            OnIdle(e);
            Idle(this, e);
        }

        void OnClosingInternal(CancelEventArgs e)
        {
            OnClosing(e);
            Closing(this, e);
        }

        void OnClosedInternal(EventArgs e)
        {
            OnClosed(e);
            Closed(this, e);
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            DisposeInternal(true);
            GC.SuppressFinalize(this);
        }

        void DisposeInternal(bool manual)
        {
            Dispose(manual);
            if (!disposed)
            {
                if (manual)
                {
                    implementation.Dispose();
                }
                disposed = true;
            }
        }

        protected virtual void Dispose(bool manual)
        {
        }

        #endregion
    }
}
