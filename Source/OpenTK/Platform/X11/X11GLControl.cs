#region --- License ---
/* Copyright (c) 2007 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace OpenTK.Platform.X11
{
    class X11GLControl// : OpenTK.Platform.IGLWindow
    {
        IntPtr display;
        IntPtr rootWindow;
        int screenNo;

        private Type xplatui;

        private Size fullScreenSize;

        OpenTK.Platform.IGLContext context;

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

                rootWindow = (IntPtr)xplatui.GetField("RootWindow",
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
                    new ColorDepth(32),
                    new ColorDepth(0),
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

                X11Api.MapRaised(display, handleToTopLevelControl);
            }
        }

        #region IGLWindow Members

        public int Width
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

        public int Height
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

        public OpenTK.Platform.IGLContext Context
        {
            get
            {
                return context;
            }
        }

        public void ProcessEvents()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region IGLWindow Members


        public void Run()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void RenderFrame()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void UpdateFrame()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public event ResizeEvent<X11GLControl> Resize;

        #endregion
    }
}
