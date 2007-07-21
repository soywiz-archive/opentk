#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

using OpenTK.OpenGL;

namespace OpenTK.Platform.X11
{
    public class X11GLContext : OpenTK.Platform.IGLContext
    {
        private IntPtr handle;
        private IntPtr x11context;
        private IntPtr display;
        private IntPtr rootWindow;
        private int screenNo;

        private DisplayMode mode;// = new DisplayMode();
        private X11WindowInfo windowInfo;
        private VisualInfo visualInfo;

        //private IntPtr desktopResolution = IntPtr.Zero;

        //private int depthBits;
        //private int stencilBits;

        // These have to be used by the X11GLControl.
        internal IntPtr visual;
        internal IntPtr colormap;

        #region --- Public Constructor ---

        private X11GLContext()
        {
        }

        public X11GLContext(IWindowInfo info, DisplayMode mode)
        {
            windowInfo = info as X11WindowInfo;
        }

        public X11GLContext(
            IntPtr handle,
            IntPtr display,
            IntPtr rootWindow,
            int screenNo,
            IntPtr handleToTopLevelControl,
            ColorDepth color,
            ColorDepth accum,
            int depthBits,
            int stencilBits,
            int auxBits,
            bool stereo,
            bool doublebuffer
        )
        {
            this.Setup(
                handle,
                display,
                rootWindow,
                screenNo,
                handleToTopLevelControl,
                color,
                accum,
                depthBits,
                stencilBits,
                auxBits,
                stereo,
                doublebuffer);
        }

        #endregion

        #region protected void Setup()

        private void Setup(
            IntPtr handle,
            IntPtr display,
            IntPtr rootWindow,
            int screenNo,
            IntPtr handleToTopLevelControl,
            ColorDepth color,
            ColorDepth accum,
            int depthBits,
            int stencilBits,
            int auxBits,
            bool stereo,
            bool doublebuffer
        )
        {
            Trace.WriteLine("Setting up opengl context (X11)");
            Trace.Indent();

            this.handle = handle;
            this.display = display;
            this.rootWindow = rootWindow;
            this.screenNo = screenNo;
            //this.depthBits = depthBits;
            //this.stencilBits = stencilBits;

            this.CreateVisual();
        }

        #endregion

        #region IGLContext Members

        public void SwapBuffers()
        {
            Glx.SwapBuffers(display, handle);
        }

        public void MakeCurrent()
        {
            bool result = Glx.MakeCurrent(display, handle, x11context);

            if (!result)
            {
                Trace.WriteLine(String.Format("Failed to make context {0} current.", x11context));
                // probably need to recreate context here.
                //throw new Exception("Failed to make context {0} current.", x11context);
            }
        }

        public IntPtr GetAddress(string function)
        {
            return Glx.GetProcAddress(function);
        }

        public IEnumerable<DisplayMode> GetDisplayModes()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manuallyCalled)
        {
            // Clean unmanaged resources:
            Glx.DestroyContext(display, x11context);
            API.Free(visual);

            if (manuallyCalled)
            {
                // Safe to clean managed resources, too
            }
        }

        ~X11GLContext()
        {
            this.Dispose(false);
        }

        #endregion

        public void CreateContext()
        {
            x11context = Glx.CreateContext(display, visual, IntPtr.Zero, true);
            Trace.WriteLine(String.Format("Created x11context: {0}", x11context));

            MakeCurrent();
        }

        public void CreateVisual()
        {
            List<int> attributes = new List<int>();
            attributes.Add((int)Glx.Enums.GLXAttribute.RGBA);
            attributes.Add((int)Glx.Enums.GLXAttribute.RED_SIZE);
            attributes.Add((int)mode.Color.Red);
            attributes.Add((int)Glx.Enums.GLXAttribute.GREEN_SIZE);
            attributes.Add((int)mode.Color.Green);
            attributes.Add((int)Glx.Enums.GLXAttribute.BLUE_SIZE);
            attributes.Add((int)mode.Color.Blue);
            attributes.Add((int)Glx.Enums.GLXAttribute.ALPHA_SIZE);
            attributes.Add((int)mode.Color.Alpha);
            attributes.Add((int)Glx.Enums.GLXAttribute.DEPTH_SIZE);
            attributes.Add((int)mode.DepthBits);
            attributes.Add((int)Glx.Enums.GLXAttribute.DOUBLEBUFFER);
            attributes.Add((int)Glx.Enums.GLXAttribute.NONE);

            Trace.WriteLine(
                String.Format(
                    "Requesting visual: {0} ({1}{2}{3}{4})",
                    mode.ToString(),
                    mode.Color.Red,
                    mode.Color.Green,
                    mode.Color.Blue,
                    mode.Color.Alpha
                )
            );

            // Create the requested visual
            visual = Glx.ChooseVisual(display, screenNo, attributes.ToArray());

            if (visual == IntPtr.Zero)
            {
                throw new Exception("Requested visual is not available");
            }

            visualInfo = (VisualInfo)Marshal.PtrToStructure(visual, typeof(VisualInfo));
            Trace.WriteLine(String.Format("Visual id: {0}", visual));

            // Create a colormap (is this needed)?
            colormap = API.CreateColormap(display, rootWindow, visualInfo.visual, 0/*AllocNone*/);
            Trace.WriteLine(String.Format("colormap: {0}", colormap));

            Trace.Unindent();
        }

        public IntPtr XVisual
        {
            get { return this.visual; }
        }

        public VisualInfo XVisualInfo
        {
            get { return this.visualInfo; }
        }

        public IntPtr XColormap
        {
            get { return colormap; }
        }
    }
}
