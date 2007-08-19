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
        WindowInfo info = new WindowInfo();
        DisplayMode mode;
        private Type xplatui;
        X11GLContext glContext;

        private bool disposed;
        private bool fullscreen;

        #region --- Contructors ---

        public X11GLControl(UserControl c, DisplayMode mode)
        {
            Debug.WriteLine("Creating opengl control (X11GLControl driver)");
            Debug.Indent();

            this.mode = mode;//new DisplayMode(mode);
            glContext = new X11GLContext(mode);

            if (c == null/* || c.TopLevelControl == null*/)
            {
                throw new ArgumentException("UserControl c may not be null.");
            }

            xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
            Debug.Write("System.Windows.Forms.XplatUIX11: ");

            if (xplatui != null)
            {
                info.Display = (IntPtr)xplatui.GetField("DisplayHandle",
                    System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);

                info.RootWindow = (IntPtr)xplatui.GetField("RootWindow",
                    System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);

                info.Screen = (int)xplatui.GetField("ScreenNo",
                    System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);

                Debug.Print("Screen: {0}, Display: {1}, Root Window: {2}, Handle: {3}",
                    info.Screen, info.Display, info.RootWindow, info.Handle);

                try
                {
                    glContext.PrepareContext(info);
                }
                catch (ApplicationException e)
                {
                    Debug.Print(e.ToString());
                    return;
                }
                info.VisualInfo = glContext.windowInfo.VisualInfo;
                /*
                xplatui.GetField("CustomVisual", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic)
                    .SetValue(null, glContext.windowInfo.VisualInfo.visual);

                xplatui.GetField("CustomColormap", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic)
                    .SetValue(null, FindColormap());*/
            }

            c.HandleCreated += new EventHandler(c_HandleCreated);
            c.HandleDestroyed += new EventHandler(c_HandleDestroyed);
            //c.ParentChanged += new EventHandler(c_ParentChanged);
            c.Load += new EventHandler(c_Load);

            Debug.Print("GLControl events hooked to X11GLControl.");
        }

        void c_HandleCreated(object sender, EventArgs e)
        {
            UserControl c = (sender as UserControl);
            Debug.Print("X11GLControl handle created, creating X11GLContext.");
            glContext.windowInfo.Handle = info.Handle = (sender as UserControl).Handle;

            try
            {
                glContext.CreateContext(null, true);
            }
            catch (ApplicationException expt)
            {
                Debug.Print(expt.ToString());
                throw;
            }

            Debug.WriteLine(String.Format("Mapping control {0} to parent {1}", c.Handle, c.FindForm().Handle));
            API.MapRaised(info.Display, c.FindForm().Handle);
        }

        void c_HandleDestroyed(object sender, EventArgs e)
        {
            Debug.Print("X11GLControl handle destroyed, disposing X11GLContext.");
            glContext.Dispose();
        }

        void c_ParentChanged(object sender, EventArgs e)
        {
            Debug.Print("Mapping X11GLControl.");

            Control c = sender as Control;
            Debug.Print("TopLevel control is {0}",
                c.TopLevelControl != null ? c.TopLevelControl.ToString() : "not available");

            if (c.TopLevelControl == null)
            {
                info.TopLevelWindow = c.Handle;
                throw new ApplicationException("Problem: GLControl does not have a parent, aborting.");
            }
            else
            {
                info.TopLevelWindow = c.TopLevelControl.Handle;
            }

            Debug.WriteLine(String.Format("Mapping window {0} to top level {1}", info.Handle, info.TopLevelWindow));
            API.MapRaised(info.Display, info.TopLevelWindow);
            //API.MapRaised(info.Display, info.Handle);
            Debug.Unindent();
        }

        void c_Load(object sender, EventArgs e)
        {
            Debug.Print("GLControl loaded, will now try to make context current and load all GL functions.");
            Context.MakeCurrent();
            OpenTK.OpenGL.GL.LoadAll();
        }

        /// <summary>
        /// Finds a colormap suitable for use with the GLControl.
        /// </summary>
        /// <returns>A pointer to the colormap</returns>
        /// <remarks>
        /// If the visual of the GLControl matches the default visual, the function returns
        /// the default colormap (i.e. the colormap of the root window). Otherwise, it creates
        /// a new, private colormap.
        /// </remarks>
        private IntPtr FindColormap()
        {
            if (info.VisualInfo.visual == Functions.XDefaultVisual(info.Display, info.Screen))
            {
                return Functions.XDefaultColormap(info.Display, info.Screen);
            }

            return API.CreateColormap(info.Display, info.RootWindow, glContext.windowInfo.VisualInfo.visual, 0/*AllocNone*/);
        }

        #endregion

        #region --- IGLControl Members ---

        public event CreateEvent Create;

        private void OnCreate(object sender, EventArgs e)
        {
            if (this.Create != null)
                this.Create(sender, e);
        }

        #region public bool IsIdle

        public bool IsIdle
        {
            get
            {
                return API.Pending(info.Display) == 0;
            }
        }

        #endregion

        #region public bool Fullscreen

        public bool Fullscreen
        {
            get
            {
                return fullscreen;
            }
            set
            {
                //throw new Exception("The method or operation is not implemented.");
                fullscreen = false;
            }
        }

        #endregion

        #region public IGLContext Context

        public IGLContext Context
        {
            get
            {
                return glContext;
            }
        }

        #endregion

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manuallyCalled)
        {
            if (!disposed)
            {
                // Clean unmanaged resources:
                // Nothing

                if (manuallyCalled)
                {
                    // Clean managed resources, too
                    glContext.Dispose();
                }
            }
            disposed = true;
        }

        ~X11GLControl()
        {
            this.Dispose(false);
        }

        #endregion
    }
}
