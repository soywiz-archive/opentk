#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace OpenTK.Platform.X11
{
    sealed class X11GLControl : IGLControl
    {
        IntPtr display;
        IntPtr rootWindow;
        int screenNo;
        private Type xplatui;
        X11GLContext context;

        private bool quit;

        #region --- Contructors ---

        public X11GLControl(Control c, int width, int height, bool fullscreen)
        {
            Trace.WriteLine("Creating GLControl (X11)");
            Trace.Indent();

            if (c == null/* || c.TopLevelControl == null*/)
            {
                throw new Exception("Attempted to bind to non-existent control.");
            }

            Trace.WriteLine(String.Format("Binding to control: {0}", c.ToString()));
            Trace.WriteLine(
                String.Format(
                    "TopLevel control is: {0}",
                    c.TopLevelControl != null ? c.TopLevelControl.ToString() : "not available"
                )
            );

            xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");

            Trace.WriteLine("Acquired System.Windows.Forms.XplatUIX11 type.");

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

                Trace.WriteLine(
                    String.Format(
                        "DisplayHandle: {0}  RootWindow: {1}   ScreenNo: {2}",
                        display,
                        rootWindow,
                        screenNo
                    )
                );

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
                    new ColorDepth(24),
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
                        context.visual
                    );

                xplatui.GetField(
                    "CustomColormap",
                    System.Reflection.BindingFlags.Static |
                    System.Reflection.BindingFlags.NonPublic).SetValue(
                        null,
                        context.colormap
                    );

                context.CreateContext(null, true);

                Trace.WriteLine("Mapping window");
                API.MapRaised(display, handleToTopLevelControl);
                Trace.Unindent();
            }
        }

        #endregion

        #region --- IGLControl Members ---

        public event CreateEvent Create;

        private void OnCreate(object sender, EventArgs e)
        {
            if (this.Create != null)
                this.Create(sender, e);
        }

        #region public bool Quit

        public bool Quit
        {
            get { return quit; }
            set
            {
                throw new NotImplementedException();
                quit = value;
            }
        }

        #endregion

        public bool IsIdle
        {
            get
            {
                return (API.Pending(this.display) == 0) ? true : false;
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

        #region --- IDisposable Members ---

        public void Dispose()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
