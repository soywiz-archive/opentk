#region --- License ---
/* Copyright (c) 2006, 2007 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using OpenTK;
using OpenTK.OpenGL;
using OpenTK.Platform;
using Enums = OpenTK.OpenGL.Enums;

namespace Examples
{
    class Cube
    {
        GameWindow window;

        public Cube()
        {
            window = new GameWindow();
            window.Context.MakeCurrent();

            window.UpdateFrameNotify += new OpenTK.Platform.UpdateFrameEvent(window_UpdateFrameNotify);
            window.RenderFrameNotify += new OpenTK.Platform.RenderFrameEvent(window_RenderFrameNotify);
            window.ResizeNotify += new OpenTK.Platform.ResizeEvent<OpenTK.Platform.IGLWindow>(window_ResizeNotify);

            window.Context.MakeCurrent();
            /*
            window.Text =
                GL.GetString(Enums.StringName.VENDOR) + " " +
                GL.GetString(Enums.StringName.RENDERER) + " " +
                GL.GetString(Enums.StringName.VERSION);
            */
            GL.ClearColor(0.1f, 0.1f, 0.5f, 0.0f);
            GL.Enable(Enums.EnableCap.DEPTH_TEST);

            this.window_ResizeNotify(null, new ResizeEventArgs(window.Width, window.Height));
        }

        void window_ResizeNotify(OpenTK.Platform.IGLWindow sender, OpenTK.Platform.ResizeEventArgs e)
        {
            GL.Viewport(0, 0, e.Width, e.Height);

            double ratio = 0.0;
            ratio = e.Width / (double)e.Height;

            GL.MatrixMode(Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);
        }

        void window_RenderFrameNotify(EventArgs e)
        {
            Render();
        }

        void window_UpdateFrameNotify(EventArgs e)
        {
            if (Key.Escape)
            {
                window.Quit = true;
                return;
            }

            GL.MatrixMode(Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 5.0, 5.0,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );

            GL.Rotatef(angle, 0.0f, 1.0f, 0.0f);
            angle += 0.5f;
        }

        #region public void Run()

        public void Run()
        {
            window.Run();
        }

        #endregion

        #region protected void Render()

        float angle = 0.0f;
        protected void Render()
        {
            GL.Clear(Enums.ClearBufferMask.COLOR_BUFFER_BIT | Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            DrawCube();

            window.Context.SwapBuffers();
        }

        #endregion

        #region KeyDown event handler
        /*
        void Cube_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.Shift)
            {
                //this.SetResolution(this.Width, this.Height, this.ColorDepth, !this.IsFullscreen);
                glControl.Fullscreen = !glControl.Fullscreen;
            }

            switch (e.KeyData)
            {
                case Keys.Escape:
                    Application.Exit();
                    break;
            }
        }
        */
        #endregion

        #region protected void DrawCube()

        protected void DrawCube()
        {
            GL.Begin(Enums.BeginMode.QUADS);

            GL.Color3f(1, 0, 0);
            GL.Vertex3f(-1.0f, -1.0f, -1.0f);
            GL.Vertex3f(-1.0f, 1.0f, -1.0f);
            GL.Vertex3f(1.0f, 1.0f, -1.0f);
            GL.Vertex3f(1.0f, -1.0f, -1.0f);

            GL.Color3f(1, 1, 0);
            GL.Vertex3f(-1.0f, -1.0f, -1.0f);
            GL.Vertex3f(1.0f, -1.0f, -1.0f);
            GL.Vertex3f(1.0f, -1.0f, 1.0f);
            GL.Vertex3f(-1.0f, -1.0f, 1.0f);

            GL.Color3f(1, 0, 1);
            GL.Vertex3f(-1.0f, -1.0f, -1.0f);
            GL.Vertex3f(-1.0f, -1.0f, 1.0f);
            GL.Vertex3f(-1.0f, 1.0f, 1.0f);
            GL.Vertex3f(-1.0f, 1.0f, -1.0f);

            GL.Color3f(0, 1, 0);
            GL.Vertex3f(-1.0f, -1.0f, 1.0f);
            GL.Vertex3f(1.0f, -1.0f, 1.0f);
            GL.Vertex3f(1.0f, 1.0f, 1.0f);
            GL.Vertex3f(-1.0f, 1.0f, 1.0f);

            GL.Color3f(0, 0, 1);
            GL.Vertex3f(-1.0f, 1.0f, -1.0f);
            GL.Vertex3f(-1.0f, 1.0f, 1.0f);
            GL.Vertex3f(1.0f, 1.0f, 1.0f);
            GL.Vertex3f(1.0f, 1.0f, -1.0f);

            GL.Color3f(0, 1, 1);
            GL.Vertex3f(1.0f, -1.0f, -1.0f);
            GL.Vertex3f(1.0f, 1.0f, -1.0f);
            GL.Vertex3f(1.0f, 1.0f, 1.0f);
            GL.Vertex3f(1.0f, -1.0f, 1.0f);

            GL.End();
        }

        #endregion
    }
}