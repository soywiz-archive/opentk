using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace OpenTK.Platform.X11
{
    class X11GLControl : IGLWindow
    {
        IntPtr display;
        UIntPtr rootWindow;
        int screenNo;

        private Type xplatui;

        private Size fullScreenSize;

        IGLContext context;

        public X11GLControl(Control c, int width, int height, bool fullscreen)
        {
            if (c == null/* || c.TopLevelControl == null*/)
            {
                throw new Exception("Attempted to bind to non-existent control.");
            }
        
            xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");

            Console.WriteLine("Got XplatUIX11 type.");
            Console.Out.Flush();

            if (xplatui != null)
            {
                display = (IntPtr)xplatui.GetField("DisplayHandle",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).GetValue(null);

                rootWindow = (UIntPtr)xplatui.GetField("RootWindow",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).GetValue(null);

                screenNo = (int)xplatui.GetField("ScreenNo",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).GetValue(null);

                Console.WriteLine("DisplayHandle: {0}  RootWindow: {1}   ScreenNo: {2}",
                    display, rootWindow, screenNo);
                Console.Out.Flush();

				IntPtr handleToTopLevelControl;
				if (c.TopLevelControl == null)
					handleToTopLevelControl = c.Handle;
				else
					handleToTopLevelControl = c.TopLevelControl.Handle;
					
                context = new X11GLContext(
                    c.Handle,
                    display,
                    rootWindow,
                    screenNo,
                    handleToTopLevelControl,
                    new OpenTK.OpenGL.ColorDepth(32),
                    new OpenTK.OpenGL.ColorDepth(0),
                    16,
                    0,
                    0,
                    false,
                    true
                );

                xplatui.GetField(
                    "CustomVisual",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).SetValue(
                        null,
                        ((X11GLContext)context).visual
                    );

                xplatui.GetField(
                    "CustomColormap",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).SetValue(
                        null,
                        ((X11GLContext)context).colormap
                    );

                ((X11GLContext)context).CreateContext();

                X11Api.XMapRaised(display, handleToTopLevelControl);
            }
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
            get
            {
                return (X11Api.Pending(IntPtr.Zero) == 0) ? true : false;
            }
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
            get
            {
                return context;
            }
        }

        public void DoEvents()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
