#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using directives ---

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK;
using OpenTK.OpenGL;

#endregion

namespace Examples.WinForms
{
    public partial class W01_First_Window : Form
    {
        /// <summary>
        /// Launches this example.
        /// </summary>
        /// <remarks>
        /// Provides a simple way for the example launcher to launch the examples.
        /// </remarks>
        public static void Launch()
        {
            using (W01_First_Window ex = new W01_First_Window())
            {
                // We need to use ShowDialog, because a message loop already exists
                // in the current thread (the one from the ExampleLauncher).
                //ex.ShowDialog();
                Application.Run(ex);
            }
        }

        public W01_First_Window()
        {
            InitializeComponent();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            GL.ClearColor(0.7f, 0.0f, 0.0f, 0.0f);
            glControl1.Invalidate();
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            GL.ClearColor(0.0f, 0.5f, 0.0f, 0.0f);
            glControl1.Invalidate();
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.7f, 0.0f);
            glControl1.Invalidate();
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(OpenTK.OpenGL.Enums.ClearBufferMask.COLOR_BUFFER_BIT);

            glControl1.Context.SwapBuffers();
        }

        private void glControl1_Resize(object sender, OpenTK.Platform.ResizeEventArgs e)
        {
            if (glControl1.ClientSize.Height == 0)
                glControl1.ClientSize = new System.Drawing.Size(glControl1.ClientSize.Width, 1);

            GL.Viewport(0, 0, glControl1.ClientSize.Width, glControl1.ClientSize.Height);

            double ratio = 0.0;
            ratio = glControl1.ClientSize.Width / (double)glControl1.ClientSize.Height;
            //if (ClientSize.Width > ClientSize.Height)
            //    ratio = ClientSize.Width / (double)ClientSize.Height;
            //else
            //    ratio = ClientSize.Height / (double)ClientSize.Width;

            GL.MatrixMode(OpenTK.OpenGL.Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);
        }
    }
}