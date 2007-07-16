#region --- License ---
/* Copyright (c) 2006, 2007 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK.OpenGL;

#endregion

namespace OpenTK.Platform
{
    // TODO: Document the GLControl class.

    /// <summary>
    /// 
    /// </summary>
    public partial class GLControl : UserControl, IGLWindow, IDisposable
    {
        #region --- Private Fields ---

        private bool fullscreen;
        private IGLWindow glWindow;

        #endregion

        #region --- Contructors ---

        public GLControl()
        {
            InitializeComponent();

            this.Setup(640, 480, false);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
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
                //glWindow = new OpenTK.Platform.WinGLControl(this, width, height, fullscreen);
            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix ||
                     Environment.OSVersion.Platform == (PlatformID)128) // some older versions of Mono reported 128.
            {
                //glWindow =  new OpenTK.Platform.X11.X11GLControl(this, width, height, fullscreen);
            }
            else
            {
                throw new PlatformNotSupportedException(
                    "Your operating system is not currently supported. We are sorry for the inconvenience."
                );
            }

            Context.MakeCurrent();

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
            Context.SwapBuffers();
        }

        /// <summary>
        /// Makes the underlying GLContext of this GLControl current. All OpenGL commands issued
        /// from this point are interpreted by this GLContext.
        /// </summary>
        public void MakeCurrent()
        {
            Context.MakeCurrent();
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
                    //fullscreen = this.SetFullscreenResolution(this.Width, this.Height);
                }
                else if (fullscreen && !value)
                {
                }
            }
        }

        #endregion

        #region --- IGLWindow Members ---

        #region public bool Quit

        public bool Quit
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        #endregion

        /// <summary>
        /// Gets the idle status of the control.
        /// </summary>
        public bool IsIdle
        {
            get { return glWindow.IsIdle; }
        }

        /// <summary>
        /// Gets the opengl context associated with this control.
        /// </summary>
        public IGLContext Context
        {
            get { return glWindow.Context; }
        }

        #region DisplayMode changes

        /// <summary>
        /// Selects the fullscreen DisplayMode closest to the DisplayMode requested.
        /// </summary>
        /// <param name="mode">
        /// The fullscreen DisplayMode to match, or null to get the current screen DisplayMode.
        /// </param>
        /// <returns>The DisplayMode closest to the requested one, or null if no DisplayModes are available.</returns>
        /// <remarks>
        /// <see cref="SetDisplayMode">SetDisplayMode</see>
        /// </remarks>
        public DisplayMode SelectDisplayMode(DisplayMode mode)
        {
            throw new NotImplementedException();
            //return glWindow.SelectDisplayMode(mode);
        }

        /// <summary>
        /// Selects the fullscreen DisplayMode closest to the DisplayMode requested, accoriding to the specified
        /// parameters.
        /// </summary>
        /// <param name="mode">
        /// The fullscreen DisplayMode to match, or null to get the current screen DisplayMode.
        /// </param>
        /// <param name="options">
        /// The DisplayModeMatchOptions flags that indicate how to search for the requested DisplayMode.
        /// </param>
        /// <returns>
        /// The DisplayMode closest to the requested one, or null if no DisplayModes are available or
        /// DisplayModeMatchOptions.ExactMatch was passed.
        /// </returns>
        /// <remarks>
        /// <see cref="SetDisplayMode">SetDisplayMode</see>
        /// </remarks>
        public DisplayMode SelectDisplayMode(DisplayMode mode, DisplayModeMatchOptions options)
        {
            throw new NotImplementedException();
            //return glWindow.SelectDisplayMode(mode, options);
        }

        /// <summary>
        /// Sets the requested DisplayMode.
        /// </summary>
        /// <param name="mode">
        /// The fulscreen DisplayMode to set. Passing null will return the application to windowed
        ///  mode.
        /// </param>
        /// <remarks>
        /// Use SelectDisplayMode to select one of the available fullscreen modes.
        /// <para>
        /// If the mode requested is not available, this function will throw a
        ///  <exception cref="DisplayModeNotAvailable">DisplayModeNotAvailable</exception> exception.
        /// </para>
        /// <para>
        /// Pass null to return to windowed mode. The previous desktop DisplayMode will be automatically reset by this
        /// function. This function cannot be used to permanently change the user's desktop DisplayMode.
        /// </para>
        /// <see cref="SelectDisplayMode(DisplayMode mode)">SelectDisplayMode</see>
        /// <seealso cref="DisplayModeNotAvailable">DisplayModeNotAvailable exception</seealso>
        /// </remarks>
        public void SetDisplayMode(DisplayMode mode)
        {
            throw new NotImplementedException();
            //glWindow.SetDisplayMode(mode);
        }

        #endregion

        #endregion

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region IGLWindow Members


        public event CreateEvent Create;

        #endregion

        #region IResizable Members


        public new event ResizeEvent Resize;

        #endregion
    }

    public class DisplayModeMatchOptions { }
}
