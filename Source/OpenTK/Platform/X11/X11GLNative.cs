using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.OpenGL;

namespace OpenTK.Platform.X11
{
    sealed class X11GLNative : IGLWindow
    {
        private X11GLContext glContext;

        private IntPtr display;
        string displayString;
        int screen;
        IntPtr rootWindow;
        IntPtr window;

        public X11GLNative()
        {
            display = X11Api.OpenDisplay(null);             // null == default display
            screen = X11Api.DefaultScreen(display);
            rootWindow = X11Api.RootWindow(display, screen);
            

            ColorDepth color = new ColorDepth(32);
            int depthBits = 16;

            // Create the Visual
            List<int> visualAttributes = new List<int>();
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.RGBA);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.RED_SIZE);
            visualAttributes.Add((int)color.Red);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.GREEN_SIZE);
            visualAttributes.Add((int)color.Green);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.BLUE_SIZE);
            visualAttributes.Add((int)color.Blue);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.ALPHA_SIZE);
            visualAttributes.Add((int)color.Alpha);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.DEPTH_SIZE);
            visualAttributes.Add((int)depthBits);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.DOUBLEBUFFER);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.NONE);

#if DEBUG
            Console.WriteLine(
                "Requesting visual: {0} ({1}{2}{3}{4})",
                color.ToString(),
                color.Red,
                color.Green,
                color.Blue,
                color.Alpha);
            Console.Out.Flush();
#endif
            
            VisualInfo glxVisualInfo =
                Glx.ChooseVisual(display, screen, visualAttributes.ToArray());

#if DEBUG
            Console.WriteLine("GLXVisualInfo: {0}", glxVisualInfo);
            Console.Out.Flush();
#endif

            // Create a window on this display using the visual above
            SetWindowAttributes windowAttributes = new SetWindowAttributes();
            windowAttributes.background_pixel = 0;
            windowAttributes.border_pixel = 0;
            windowAttributes.colormap =
                X11Api.CreateColormap(display, window, glxVisualInfo.visual, 0/*AllocNone*/);
            windowAttributes.event_mask =
                EventMask.StructureNotifyMask |
                EventMask.ExposureMask |
                EventMask.KeyPressMask;
            X11.CreateWindowMask cw_mask =
                CreateWindowMask.CWBackPixel |
                CreateWindowMask.CWBorderPixel |
                CreateWindowMask.CWColormap |
                CreateWindowMask.CWEventMask;

            window = X11Api.CreateWindow(
                display,
                rootWindow,
                0, 0,
                640, 480,
                0,
                0, // depth?
                Constants.InputOutput,
                glxVisualInfo.visual,
                cw_mask,
                windowAttributes
            );

            // Set the window hints
            /*
            SizeHints hints = new SizeHints();
            hints.x = 0;
            hints.y = 0;
            hints.width = 640;
            hints.height = 480;
            hints.flags = USSize | USPosition;
            X11Api.SetNormalHints(display, window, hints);
            X11Api.SetStandardProperties(
                display,
                window,
                name,
                name,
                0,  // None
                null,
                0,
                hints
            );
            */

            // Create the OpenGL Context
            /*
            glContext = new X11GLContext(
                IntPtr.Zero,
                display,
                rootWindow,
                screen,
                IntPtr.Zero,
                new OpenTK.OpenGL.ColorDepth(32),
                new OpenTK.OpenGL.ColorDepth(0),
                16,
                0,
                0,
                false,
                true
            );
            */

            // Create the GLX context with the specified parameters
            glContext = new X11GLContext();
            glContext.x11context = Glx.CreateContext(
                display,
                glxVisualInfo.visual,
                IntPtr.Zero,
                true
            );
            if (glContext.x11context == IntPtr.Zero)
            {
                // If we couldn't get a context, retry with indirect rendering.
                glContext.x11context = Glx.CreateContext(
                    display,
                    glxVisualInfo.visual,
                    IntPtr.Zero,
                    false
                );
            }
            if (glContext.x11context == IntPtr.Zero)
            {
                // If we failed again, stop trying.
                // TODO: Create a specific exception!
                throw new Exception("Could not create GLX Context");
            }

            X11Api.Free(glxVisualInfo);
        }

        #region IGLWindow Members

        public OpenTK.OpenGL.DisplayMode SelectDisplayMode(OpenTK.OpenGL.DisplayMode mode)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public OpenTK.OpenGL.DisplayMode SelectDisplayMode(
            OpenTK.OpenGL.DisplayMode mode,
            DisplayModeMatchOptions options)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void SetDisplayMode(OpenTK.OpenGL.DisplayMode mode)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #region public bool Quit

        public bool Quit
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        #endregion

        public bool IsIdle
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public bool Fullscreen
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public IGLContext Context
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        public void DoEvents()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
