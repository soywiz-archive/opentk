using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.OpenGL;

namespace OpenTK.Platform.X11
{
    class X11GLNative : IGLWindow
    {
        private X11GLContext glContext;

        private IntPtr display;
        string displayString;
        int screen;
        int rootWindow;

        public X11GLNative()
        {
            // Get default display
            display = X11Api.OpenDisplay(null);
            screen = X11Api.DefaultScreen(display);
            rootWindow = X11Api.RootWindow(display, screen);
            ulong mask;
            int window;

            ColorDepth color = new ColorDepth(32);
            int depthBits = 16;

            // Create the Visual
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

            Console.WriteLine(
                "Requesting visual: {0} ({1}{2}{3}{4})",
                color.ToString(),
                color.Red,
                color.Green,
                color.Blue,
                color.Alpha);

            IntPtr glxVisualInfo = Glx.ChooseVisual(display, screen, attributes.ToArray());
            
            Console.WriteLine("GLXVisualInfo: {0}", glxVisualInfo);
            Console.Out.Flush();

            // Create a window on this display using the visual above
            

            glContext = new X11GLContext(
                IntPtr.Zero,
                display,
                new IntPtr(rootWindow),
                X11Api.DefaultScreen(display),
                IntPtr.Zero,
                new OpenTK.OpenGL.ColorDepth(32),
                new OpenTK.OpenGL.ColorDepth(0),
                16,
                0,
                0,
                false,
                true
            );


        }

        #region IGLWindow Members

        public OpenTK.OpenGL.DisplayMode SelectDisplayMode(OpenTK.OpenGL.DisplayMode mode)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public OpenTK.OpenGL.DisplayMode SelectDisplayMode(OpenTK.OpenGL.DisplayMode mode, DisplayModeMatchOptions options)
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
