using System;
using System.Collections.Generic;
using System.Text;

using OpenTK;
using OpenTK.OpenGL;
using OpenTK.Platform;

namespace Examples.Tutorial
{
    public class T04_Lit_Cube : GameWindow, IExample
    {
        #region --- Fields ---

        /// <summary>
        /// Denotes the cube rotation.
        /// </summary>
        float angle = 0.0f;

        #endregion

        #region --- Constructors ---

        #region public T04_Lit_Cube()

        public T04_Lit_Cube()
        {
            Context.MakeCurrent();
        
            GL.ClearColor(0.1f, 0.1f, 0.5f, 0.0f);
            GL.Enable(GL.Enums.EnableCap.DEPTH_TEST);
            GL.Enable(GL.Enums.EnableCap.LIGHTING);
            GL.Lightv(GL.Enums.LightName.LIGHT0, GL.Enums.LightParameter.AMBIENT, new float[] { 0.4f, 0.2f, 0.7f, 1.0f });
            //GL.Light(GL.Enums.LightName.LIGHT0, GL.Enums.LightParameter.DIFFUSE, new float[] { 1.0f, 1.0f, 0.4f, 1.0f });
            //GL.Light(GL.Enums.LightName.LIGHT0, GL.Enums.LightParameter.POSITION, new float[] { 1.0f, 1.0f, -1.0f });
            GL.Enable(GL.Enums.EnableCap.LIGHT0);

            this.OnResize(new ResizeEventArgs(this.Width, this.Height));
        }

        #endregion

        #region static public void Launch()

        /// <summary>
        /// Launches this example.
        /// </summary>
        /// <remarks>
        /// Provides a simple way for the example launcher to launch the examples.
        /// </remarks>
        static public void Launch()
        {
            using (T04_Lit_Cube ex = new T04_Lit_Cube())
            {
                ex.Run();
            }
        }

        #endregion

        #endregion

        #region --- Events ---

        #region OnResize event

        /// <summary>
        /// Called when the user resizes the window.
        /// </summary>
        /// <param name="e">Contains the new width/height of the window.</param>
        /// <remarks>
        /// You want the OpenGL viewport to match the window. This is the place to do it!
        /// </remarks>
        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, e.Width, e.Height);

            double ratio = e.Width / (double)e.Height;

            GL.MatrixMode(GL.Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);
        }

        #endregion

        #region UpdateFrame event

        /// <summary>
        /// Prepares the next frame for rendering.
        /// </summary>
        /// <remarks>
        /// Place your control logic here. This is the place to respond to user input,
        /// update object positions etc.
        /// </remarks>
        public override void UpdateFrame()
        {
            // Notify all event listeners that the event has fired.
            base.UpdateFrame();

            if (Key[OpenTK.Input.Keys.Escape])
            {
                Quit = true;
                return;
            }

            GL.MatrixMode(GL.Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 5.0, 5.0,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );

            GL.Rotatef(angle, 0.0f, 1.0f, 0.0f);
            angle += 0.5f;
        }

        #endregion

        #region RenderFrame event

        /// <summary>
        /// Place your rendering code here.
        /// </summary>
        public override void RenderFrame()
        {
            // Notify all event listeners that the event has fired.
            base.RenderFrame();

            GL.Clear(GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT | GL.Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            DrawCube();

            Context.SwapBuffers();
        }

        #endregion

        #region private void DrawCube()

        /// <summary>
        /// Draws simple, colored cube.
        /// </summary>
        private void DrawCube()
        {
            GL.Begin(GL.Enums.BeginMode.QUADS);

            GL.Normal3(0.0f, 0.0f, -1.0f);
            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);
            GL.Vertex3(1.0f, 1.0f, -1.0f);
            GL.Vertex3(1.0f, -1.0f, -1.0f);

            GL.Normal3(0.0f, -1.0f, 0.0f);
            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Vertex3(1.0f, -1.0f, -1.0f);
            GL.Vertex3(1.0f, -1.0f, 1.0f);
            GL.Vertex3(-1.0f, -1.0f, 1.0f);

            GL.Normal3(-1.0f, 0.0f, 0.0f);
            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Vertex3(-1.0f, -1.0f, 1.0f);
            GL.Vertex3(-1.0f, 1.0f, 1.0f);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);

            GL.Normal3(0.0f, 0.0f, 1.0f);
            GL.Vertex3(-1.0f, -1.0f, 1.0f);
            GL.Vertex3(1.0f, -1.0f, 1.0f);
            GL.Vertex3(1.0f, 1.0f, 1.0f);
            GL.Vertex3(-1.0f, 1.0f, 1.0f);

            GL.Normal3(0.0f, 1.0f, 0.0f);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);
            GL.Vertex3(-1.0f, 1.0f, 1.0f);
            GL.Vertex3(1.0f, 1.0f, 1.0f);
            GL.Vertex3(1.0f, 1.0f, -1.0f);

            GL.Normal3(1.0f, 0.0f, 0.0f);
            GL.Vertex3(1.0f, -1.0f, -1.0f);
            GL.Vertex3(1.0f, 1.0f, -1.0f);
            GL.Vertex3(1.0f, 1.0f, 1.0f);
            GL.Vertex3(1.0f, -1.0f, 1.0f);

            GL.End();
        }

        #endregion

        #endregion
    }
}
