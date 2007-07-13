#region --- License ---
/* Copyright (c) 2006, 2007 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Platform;

namespace OpenTK
{
    public class GameWindow : OpenTK.Platform.IGLWindow, OpenTK.Platform.IGameWindow
    {
        OpenTK.Platform.IGLWindow glWindow;

        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();

        #region --- Contructors ---

        /// <summary>
        /// Constructs a new GameWindow, using a safe DisplayMode.
        /// </summary>
        public GameWindow()
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
                Environment.OSVersion.Platform == PlatformID.Win32Windows)
            {
                glWindow = new OpenTK.Platform.WinGLNative();
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix ||
                    Environment.OSVersion.Platform == (PlatformID)128) // some older versions of Mono reported 128.
            {
                glWindow = new OpenTK.Platform.X11.X11GLNative();
            }
            else
            {
                throw new PlatformNotSupportedException(
                    "Your operating system is not currently supported. We are sorry for the inconvenience."
                );
            }

            resizeEventArgs.Width = this.Width;
            resizeEventArgs.Height = this.Height;
            glWindow.ResizeNotify += new ResizeEvent<IGLWindow>(glWindow_ResizeNotify);
            glWindow.Resize(resizeEventArgs);
        }

        #endregion

        #region IGLWindow Members

        #region public bool IsIdle

        public bool IsIdle
        {
            get { return glWindow.IsIdle; }
        }

        #endregion

        #region public bool Fullscreen

        public bool Fullscreen
        {
            get { return glWindow.Fullscreen; }
            set { glWindow.Fullscreen = value; }
        }

        #endregion

        #region public OpenTK.Platform.IGLContext Context

        public OpenTK.Platform.IGLContext Context
        {
            get { return glWindow.Context; }
        }

        #endregion

        #region public bool Quit

        public bool Quit
        {
            get { return glWindow.Quit; }
            set { glWindow.Quit = value; }
        }

        #endregion

        #endregion

        #region IGameWindow Members

        /// <summary>
        /// Runs a default game loop on the GameWindow.
        /// </summary>
        /// <remarks>
        /// <para>
        /// A default game loop consists of three parts: Event processing,
        /// a frame update and a frame render.
        /// </para>
        /// <para>
        /// Override this function if you want to change the behaviour of the
        /// default game loop. If you override this function, you must place
        /// a call to the ProcessEvents function, so that your window will respond
        /// to Operating System events.
        /// </para>
        /// </remarks>
        public virtual void Run()
        {
            while (!this.Quit)
            {
                this.ProcessEvents();
                this.UpdateFrame();
                this.RenderFrame();
            }
        }

        public void ProcessEvents()
        {
            glWindow.ProcessEvents();
        }

        public virtual void RenderFrame()
        {
            if (RenderFrameNotify != null)
                RenderFrameNotify(EventArgs.Empty);
        }

        public virtual void UpdateFrame()
        {
            if (UpdateFrameNotify != null)
                UpdateFrameNotify(EventArgs.Empty);
        }

        public event UpdateFrameEvent UpdateFrameNotify;
        public event RenderFrameEvent RenderFrameNotify;

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            glWindow.Dispose();
            glWindow = null;
        }

        #endregion

        #region IResizable Members

        #region public int Width, Height

        public int Width
        {
            get { return glWindow.Width; }
            set
            {
                if (value == this.Width)
                {
                    return;
                }
                else if (value > 0)
                {
                    resizeEventArgs.Width = value;
                    resizeEventArgs.Height = this.Height;
                    glWindow.Resize(resizeEventArgs);
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                        "Width",
                        value,
                        "Width must be greater than 0"
                    );
                }
            }
        }

        public int Height
        {
            get { return glWindow.Height; }
            set
            {
                if (value == this.Height)
                {
                    return;
                }
                else if (value > 0)
                {
                    resizeEventArgs.Width = this.Width;
                    resizeEventArgs.Height = value;
                    glWindow.Resize(resizeEventArgs);
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                        "Height",
                        value,
                        "Height must be greater than 0"
                    );
                }
            }
        }

        #endregion

        public event ResizeEvent<IGLWindow> ResizeNotify;

        void glWindow_ResizeNotify(IGLWindow sender, ResizeEventArgs e)
        {
            this.Resize(e);
        }

        public virtual void Resize(ResizeEventArgs e)
        {
            if (this.ResizeNotify != null)
                this.ResizeNotify(this, e);
        }

        #endregion
    }
}
