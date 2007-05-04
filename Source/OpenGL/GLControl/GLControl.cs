using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
//using System.Data;
using System.Text;
using System.Windows.Forms;

namespace OpenTK.OpenGL
{
    public partial class GLControl : UserControl, IGLControl
    {
        #region --- Private Fields ---

        private GLContext glContext;
        private IGLControl glControl;
        private bool fullscreen;

        #endregion

        #region --- Contructors ---

        public GLControl()
        {
            InitializeComponent();

            this.Setup(0, 0, false);
        }

        /// <summary>
        /// Constructs a new GLControl with the specified width, height and fullscreen modes.
        /// </summary>
        /// <param name="width">The width of the control. Only used if the control is not bound to a parent.</param>
        /// <param name="height">The height of the control. Only used if the control is not bound to a parent.</param>
        /// <param name="fullscreen">Set to true if you wish the control to occupy the whole screen.</param>
        public GLControl(int width, int height, bool fullscreen)
        {
            InitializeComponent();

            this.Setup(width, height, fullscreen);
        }

        protected void Setup(int width, int height, bool fullscreen)
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
                Environment.OSVersion.Platform == PlatformID.Win32Windows)
            {
                glControl = new IGLControlWindows();
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix ||
                     Environment.OSVersion.Platform == (PlatformID)128) // some older versions of Mono reported 128.
            {
                //glControl =  new X11GLControl(width, height, fullscreen);
            }
            else
            {
                throw new PlatformNotSupportedException(
                    "Your operating system is not currently supported. We are sorry for the inconvenience."
                );
            }

            glContext = new GLContext(this, new OpenTK.OpenGL.ColorDepth(8, 8, 8, 8), 16, 0, 0, false);

            glContext.MakeCurrent();

            //GL.ReloadFunctions();

            if (width > 0)
                this.Width = width;
            if (height > 0)
                this.Height = height;
            if (fullscreen)
                this.Fullscreen = true;

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        #endregion

        #region --- Public Methods ---

        /// <summary>
        /// Swaps the front and back buffers, and presents the rendered scene to the screen.
        /// </summary>
        public void SwapBuffers()
        {
            glContext.SwapBuffers();
        }

        /// <summary>
        /// Makes the underlying GLContext of this GLControl current. All OpenGL commands issued
        /// from this point are interpreted by this GLContext.
        /// </summary>
        public void MakeCurrent()
        {
            glContext.MakeCurrent();
        }

        #endregion

        #region --- Public Properties ---

        /// <summary>
        /// Gets the AspectRatio of the control this GLContext object
        /// renders to. This is usually used in a call to Glu.Perspective.
        /// </summary>
        public double AspectRatio
        {
            get
            {
                return this.Width / (double)this.Height;
            }
        }

        /// <summary>
        /// Gets or sets the display mode of the control.
        /// </summary>
        public bool Fullscreen
        {
            get
            {
                return fullscreen;
            }
            set
            {
                if (!fullscreen && value)
                {
                    fullscreen = this.SetFullscreenResolution(this.Width, this.Height);
                }
                else if (fullscreen && !value)
                {
                }
            }
        }

        #endregion

        #region --- IGLControl Members ---

        /// <summary>
        /// Sets the resolution of a fullscreen mode.
        /// </summary>
        /// <param name="width">The requested screen width, in pixels.</param>
        /// <param name="height">The requested screen height, in pixels.</param>
        /// <returns></returns>
        public bool SetFullscreenResolution(int width, int height)
        {
            return glControl.SetFullscreenResolution(width, height);
        }

        #endregion
    }
}
