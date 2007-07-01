#region --- License ---
/* This source file is released under the MIT license. See License.txt for more information.
 * Coded by Erik Ylvisaker and Stephen Apostolopoulos.
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using OpenTK.OpenGL;
using Enums = OpenTK.OpenGL.Enums;
using OpenTK.Platform;

#endregion

namespace Lesson01
{
    public class Cube : Form
    {
        static float angle;
        private GLControl glControl;

        #region Entry point

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Cube c = new Cube();
            c.Run();
        }

        #endregion

        #region Load event handler

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Text =
                GL.GetString(Enums.StringName.VENDOR) + " " +
                GL.GetString(Enums.StringName.RENDERER) + " " +
                GL.GetString(Enums.StringName.VERSION);

            GL.ClearColor(0.1f, 0.1f, 0.5f, 0.0f);
            GL.Enable(Enums.EnableCap.DEPTH_TEST);

            OnResize(e);
        }

        #endregion

        #region Resize event handler

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            //            if (this.Context == null)
            //                return;

            if (ClientSize.Height == 0)
                ClientSize = new System.Drawing.Size(ClientSize.Width, 1);

            GL.Viewport(0, 0, ClientSize.Width, ClientSize.Height);

            double ratio = 0.0;
            ratio = ClientSize.Width / (double)ClientSize.Height;
            //if (ClientSize.Width > ClientSize.Height)
            //    ratio = ClientSize.Width / (double)ClientSize.Height;
            //else
            //    ratio = ClientSize.Height / (double)ClientSize.Width;

            GL.MatrixMode(Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);
        }

        #endregion

        #region Paint event handler

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GL.MatrixMode(Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 5.0, 5.0,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );
            GL.Rotatef(angle, 0.0f, 1.0f, 0.0f);
            angle += 0.5f;

            GL.Clear(Enums.ClearBufferMask.COLOR_BUFFER_BIT | Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            DrawCube();

            //ActiveContext.SwapBuffers();
        }

        #endregion

        #region KeyDown event handler

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            switch (e.KeyData)
            {
                case Keys.Escape:
                    Application.Exit();
                    break;

                case Keys.F1:
                    //this.SetResolution(this.Width, this.Height, this.ColorDepth, !this.IsFullscreen);
                    break;
            }
        }

        #endregion

        #region DrawCube
        public void DrawCube()
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

        #region --- Main Loop ---

        /// <summary>
        /// Enters the Framework's main loop, updating state and rendering.
        /// </summary>
        public void Run()
        {
            while (true)
            {
                // TODO: Find a better main loop. This is evil! (Probably a custom main loop or something based on the Idle event).
                if (this.Focused)
                {
                    OnPaint(null);

                    //if (platform.IsIdle() == false)
                    Application.DoEvents();

                    System.Threading.Thread.Sleep(0);
                }
            }
        }

        #endregion

        Cube()
        {
            System.Console.WriteLine("Launching application.");

            this.Show();

            System.Console.WriteLine("Launched!");
        }

        private void CreateWindowedDisplay(int width, int height)
        {

            //activeContext = GLContext.Create(activeForm,
            //    this.ColorDepth, this.ZDepth, this.StencilDepth);
            //activeContext = new OpenTK.Platform.Windows.WinGLContext(

            //AttachEvents(activeForm);

            //activeForm.ClientSize = new Size(width, height);

            //activeForm.TopMost = true;
            //activeForm.Enabled = true;

            //activeForm.Show();
        }

        private void InitializeComponent()
        {
            this.glControl = new OpenTK.Platform.GLControl();
            this.SuspendLayout();
            // 
            // glControl
            // 
            this.glControl.BackColor = System.Drawing.SystemColors.WindowText;
            this.glControl.Fullscreen = false;
            this.glControl.Location = new System.Drawing.Point(24, 23);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(150, 150);
            this.glControl.TabIndex = 0;
            // 
            // Cube
            // 
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.glControl);
            this.Name = "Cube";
            this.ResumeLayout(false);

        }
    }
}