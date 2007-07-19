#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion


using System;
using System.Drawing;
using System.Globalization;

namespace OpenTK.Platform
{
    public sealed class DisplayMode
    {
        #region --- Constructors ---

        /// <summary>
        /// Constructs a new DisplayMode from the given parameters.
        /// </summary>
        /// <param name="width">The Width of the DisplayMode, in pixels.</param>
        /// <param name="height">The Height of the DisplayMode, in pixels.</param>
        /// <param name="color">The ColorDepth of the DisplayMode.</param>
        /// <param name="depth">The size of the Depth Buffer, in bits.</param>
        /// <param name="stencil">The size of Stencil Buffer, in bits.</param>
        /// <param name="aux">The size of the Auxilliary Buffer, in bits.</param>
        /// <param name="fullscreen">Set to true for a fullscreen DisplayMode.</param>
        /// <param name="stereo">Set to true for a DisplayMode with stereographic capabilities.</param>
        /// <param name="buffers">The number of Display Buffers. Usually one, two or three.</param>
        /// <param name="vsync">Set to true to sync the updates to the screen refresh rate.</param>
        /// <param name="refresh">The desired RefreshRate. Taken into account only for Fullscreen DisplayModes.</param>
        public DisplayMode(
            int width,
            int height,
            ColorDepth color,
            int depth,
            int stencil,
            int aux,
            int buffers,
            bool fullscreen,
            bool stereo,
            bool vsync,
            float refresh
        )
        {
            this.Width = width;
            this.Height = height;
            this.Color = color;
            this.DepthBits = depth;
            this.StencilBits = stencil;
            this.AuxBits = aux;
            this.Buffers = buffers;
            this.Fullscreen = fullscreen;
            this.Stereo = stereo;
            this.Vsync = vsync;
            this.RefreshRate = refresh;
        }

        /// <summary>
        /// Constructs a new DisplayMode with default values.
        /// </summary>
        public DisplayMode()
            : this(0, 0, new ColorDepth(0), 0, 0, 0, 0, false, false, false, 0.0f)
        {
        }

        /// <summary>
        /// Creates a DisplayMode.
        /// </summary>
        /// <param name="width">The Width of the DisplayMode in pixels.</param>
        /// <param name="height">The Height of the DisplayMode in pixels.</param>
        public DisplayMode(int width, int height)
            : this(width, height, new ColorDepth(0), 0, 0, 0, 0, false, false, false, 0.0f)
        {
        }
        /*
        public DisplayMode(int width, int height, int bpp, int frequency)
            : this(width, height, 0, 0, 0, 0, frequency)
        {
            color = new ColorDepth(bpp);
        }
        */
        /*
        public DisplayMode(int width, int height, int r, int g, int b, int a, int frequency)
        {
            size = new Size(width, height);
            color = new ColorDepth(r, g, b, a);
            displayFrequency = frequency;
        }
        */
        #endregion

        #region --- Private Variables ---

        private int width, height;
        private ColorDepth color;

        private int depthBits;
        private int alphaBits;

        private float displayFrequency;
        private bool vsync;
        private bool fullscreen;
        private int buffers;
        private bool stereo;

        #endregion

        #region --- Public Properties ---

        #region public int Height

        /// <summary>
        /// Gets or sets the Height of the DisplayMode. Height is the vertical span measured in pixels.
        /// </summary>
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0 /* && (value < Screen[0].Height) */)
                {
                    height = value;
                }
            }
        }

        #endregion

        #region public int Width

        /// <summary>
        /// Gets or sets the Width of the DisplayMode. Width is the horizontal span measured in pixels.
        /// </summary>
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0 /* && (value < Screen[0].Width) */)
                {
                    width = value;
                }
            }
        }

        #endregion

        public ColorDepth Color
        {
            get { return this.color; }
            set { throw new NotImplementedException(); }
        }

        public int DepthBits
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int StencilBits
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int AuxBits
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool Stereo
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool Fullscreen
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool Vsync
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int Buffers
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public float RefreshRate
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }


        #endregion

        public override string ToString()
        {
            return string.Format(
                CultureInfo.CurrentCulture,
                "{0}x{1}, {2}, {3}Hz",
                Width, Height,
                Color,
                RefreshRate
            );
        }

    }

    public class DisplayModeMatchOptions { }
}
