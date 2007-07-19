#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.OpenGL;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace OpenTK.Platform.X11
{
    public class X11GLContext : OpenTK.Platform.IGLContext
    {
        internal IntPtr handle;
        internal IntPtr x11context;
        internal IntPtr display;
        internal IntPtr rootWindow;
        internal int screenNo;

        private DisplayMode mode = new DisplayMode();

        //private IntPtr desktopResolution = IntPtr.Zero;

        //private int depthBits;
        //private int stencilBits;

        // These have to be used by the X11GLControl.
        internal IntPtr visual;
        internal IntPtr colormap;

        #region --- Public Constructor ---

        public X11GLContext()
        {
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
            Console.WriteLine("Creating X11Context.");
            Console.Out.Flush();

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

        protected void Setup(
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
            Trace.WriteLine("Creating opengl context (X11)");

            this.handle = handle;
            this.display = display;
            this.rootWindow = rootWindow;
            this.screenNo = screenNo;
            //this.depthBits = depthBits;
            //this.stencilBits = stencilBits;
    
            List<int> attributes = new List<int>();
			attributes.Add((int)Glx.Enums.GLXAttribute.RGBA);
            attributes.Add((int)Glx.Enums.GLXAttribute.RED_SIZE);
            attributes.Add((int)color.Red);
            attributes.Add((int)Glx.Enums.GLXAttribute.GREEN_SIZE);
            attributes.Add((int)color.Green);
            attributes.Add((int)Glx.Enums.GLXAttribute.BLUE_SIZE);
            attributes.Add((int)color.Blue);
            attributes.Add((int)Glx.Enums.GLXAttribute.ALPHA_SIZE);
            attributes.Add((int)color.Alpha);
            attributes.Add((int)Glx.Enums.GLXAttribute.DEPTH_SIZE);
            attributes.Add((int)depthBits);
            attributes.Add((int)Glx.Enums.GLXAttribute.DOUBLEBUFFER);
            attributes.Add((int)Glx.Enums.GLXAttribute.NONE);

			Trace.Indent();
            Trace.WriteLine(
                String.Format(
                    "Requesting visual: {0} ({1}{2}{3}{4})",
                    color.ToString(),
                    color.Red,
                    color.Green,
                    color.Blue,
                    color.Alpha
                )
            );

            visual = Glx.ChooseVisual(display, screenNo, attributes.ToArray());

            if (visual == IntPtr.Zero)
			{
				throw new Exception("Requested visual is not available");
			}

            Trace.WriteLine(String.Format("Visual id: {0}", visual));

            VisualInfo xVisualInfo =
                (VisualInfo)Marshal.PtrToStructure(visual, typeof(VisualInfo));

            //colormap = API.CreateColormap(display, rootWindow, xVisualInfo.visual, 0/*AllocNone*/);

            //Trace.WriteLine(String.Format("colormap: {0}", colormap));
        }

        #endregion

        internal void CreateContext()
        {
            x11context = Glx.CreateContext(display, visual, IntPtr.Zero, true);
            Console.WriteLine("x11context: {0}", x11context);
            Console.Out.Flush();

            MakeCurrent();
        }

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

        public OpenTK.Platform.DisplayMode[] GetDisplayModes()
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
    }
}
