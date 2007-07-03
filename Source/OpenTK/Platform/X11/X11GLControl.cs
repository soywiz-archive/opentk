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
        IntPtr rootWindow;
        int screenNo;

        private Type xplatui;

        private Size fullScreenSize;

        IGLContext context;

        public X11GLControl(Control c, int width, int height, bool fullscreen)
        {
            xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");

            Console.WriteLine("Got XplatUIX11 type.");

            if (xplatui != null)
            {
                display = (IntPtr)xplatui.GetField("DisplayHandle",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).GetValue(null);

                rootWindow = (IntPtr)xplatui.GetField("RootWindow",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).GetValue(null);

                screenNo = (int)xplatui.GetField("ScreenNo",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).GetValue(null);

                Console.WriteLine("DisplayHandle: {0}  RootWindow: {1}   ScreenNo: {2}",
                    display, rootWindow, screenNo);

                context = new X11GLContext(
                    c.Handle,
                    display,
                    rootWindow,
                    screenNo,
                    c.TopLevelControl.Handle,
                    new OpenTK.OpenGL.ColorDepth(32),
                    new OpenTK.OpenGL.ColorDepth(0),
                    24,
                    8,
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
                throw new Exception("The method or operation is not implemented.");
            }
        }

        #endregion
    }
}
