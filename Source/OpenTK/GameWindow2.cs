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
using OpenTK.Platform;
using System.Drawing;
using OpenTK.Graphics;
using System.ComponentModel;
using OpenTK.Input;

namespace OpenTK
{
    public class GameWindow2 : NativeWindow, IGameWindow2
    {
        #region Fields

        IScheduler scheduler;
        IInputDriver input;

        FrameEventArgs render_args = new FrameEventArgs(), update_args = new FrameEventArgs();

        #endregion

        #region Constructors

        public GameWindow2()
            : this("OpenTK Game Window", Point.Empty, Size.Empty, new Size(640, 480), GraphicsMode.Default, 
            GameWindowFlags.Default, 1, 0, GraphicsContextFlags.Default, DisplayDevice.Default)
        { }

        public GameWindow2(int width, int height)
            : this("OpenTK Game Window", Point.Empty, Size.Empty, new Size(width, height), GraphicsMode.Default,
            GameWindowFlags.Default, 1, 0, GraphicsContextFlags.Default, DisplayDevice.Default)
        { }

        public GameWindow2(int width, int height, GraphicsMode mode)
            : this("OpenTK Game Window", Point.Empty, Size.Empty, new Size(width, height), GraphicsMode.Default,
            GameWindowFlags.Default, 1, 0, GraphicsContextFlags.Default, DisplayDevice.Default)
        { }

        public GameWindow2(string title, Point location, Size size, Size clientSize, GraphicsMode mode,
            GameWindowFlags options, int major, int minor, GraphicsContextFlags flags, DisplayDevice device)
            : base(title, location, size, clientSize, mode, major, minor, flags, device)
        {
            if ((options & GameWindowFlags.Fullscreen) != 0)
            {
                device.ChangeResolution(Width, Height, mode.ColorFormat.BitsPerPixel, 0);
                WindowState = WindowState.Fullscreen;
            }

            VSync = VSyncMode.On;

            input = Platform.Factory.CreateInputDriver();
        }

        #endregion

        #region IGameWindow Members

        public event EventHandler<FrameEventArgs> UpdateFrame = delegate(object sender, FrameEventArgs e) { };

        public event EventHandler<FrameEventArgs> RenderFrame = delegate(object sender, FrameEventArgs e) { };

        #endregion

        #region Public Members

        public sealed override void Run()
        {
            Run(0);
        }

        public void Run(double updateFrequency)
        {
            if (updateFrequency < 0)
                throw new ArgumentOutOfRangeException("updateFrequency");

            scheduler = new AccurateScheduler(updateFrequency);
            scheduler.Start();

            base.Run();
        }

        public KeyboardDevice Keyboard
        {
            get { return input.Keyboard[0]; }
        }

        public IList<KeyboardDevice> Keyboards
        {
            get { return input.Keyboard; }
        }

        public IList<MouseDevice> Mice
        {
            get { return input.Mouse; }
        }

        public MouseDevice Mouse
        {
            get { return input.Mouse[0]; }
        }

        public IList<JoystickDevice> Joysticks
        {
            get { return input.Joysticks; }
        }

        #endregion

        #region Protected Members

        protected virtual void OnRenderFrame(FrameEventArgs e)
        {
        }

        protected virtual void OnUpdateFrame(FrameEventArgs e)
        {
        }

        protected override void OnIdle(EventArgs e)
        {
            double elapsed, render_elapsed = 0;
            int skipped_frames = -1;

            while (scheduler.Poll(out elapsed) && ++skipped_frames < 10)
            {
                input.Poll();
                render_elapsed += elapsed;

                update_args.Time = elapsed;
                OnUpdateFrameInternal(update_args);
            }

            scheduler.Start();

            render_args.Time = render_elapsed + elapsed;
            OnRenderFrameInternal(render_args);

            scheduler.Sleep();
        }

        #endregion

        #region Protected Members

        protected virtual void OnRenderFrameInternal(FrameEventArgs e)
        {
            OnRenderFrame(e);

            RenderFrame(this, e);
        }

        protected virtual void OnUpdateFrameInternal(FrameEventArgs e)
        {
            OnUpdateFrame(e);

            UpdateFrame(this, e);
        }

        #endregion

        #region Compatibility Members

        [Obsolete("Use protected virtual void OnUpdateFrame(object sender, FrameEventArgs e) instead.")]
        public virtual void OnUpdateFrame(UpdateFrameEventArgs e)
        {
        }

        [Obsolete("Use protected virtual void OnRenderFrame(object sender, FrameEventArgs e) instead.")]
        public virtual void OnRenderFrame(RenderFrameEventArgs e)
        {
        }

        public void Exit()
        {
            Close();
        }

        [Obsolete("Use public void Run(double updateFrequency) instead.")]
        public void Run(double updateFrequency, double renderFrequency)
        {
            Run(updateFrequency);
        }

        #endregion
    }
}
