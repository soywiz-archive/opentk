using System;
using System.Collections.Generic;
using System.Text;

using OpenTK;
using OpenTK.OpenGL;

namespace Examples
{
    class VBO : OpenTK.GameWindow
    {
        int vbo, ibo, nbo; // vertex, index and normal buffer objects.

        #region Cube data

        // Cube vertices
        float[,] vdata = 
            {
                { 0.0f, 0.0f, 0.0f },
                { 1.0f, 0.0f, 0.0f },
                { 1.0f, 1.0f, 0.0f },
                { 0.0f, 1.0f, 0.0f },
                { 0.0f, 0.0f, -1.0f },
                { 1.0f, 0.0f, -1.0f },
                { 1.0f, 1.0f, -1.0f },
                { 0.0f, 1.0f, -1.0f },
            };

        // Cube normals
        float[,] ndata =
            {
                { 1.0f, 0.0f, 0.0f },
                { 0.0f, 1.0f, 0.0f },                
                { 0.0f, 0.0f, 1.0f },
                { -1.0f, 0.0f, 0.0f },
                { 0.0f, -1.0f, 0.0f },                
                { 0.0f, 0.0f, -1.0f },
            };

        // Indices
        ushort[] idata =
            {
                // front face
                0, 1, 2, 3,
                // top face
                3, 4, 6, 7,
                // back face
                7, 6, 5, 4,
                // left face
                4, 0, 3, 7,
                // bottom face
                0, 1, 5, 4,
                // right face
                1, 5, 6, 2,
            };

        #endregion

        public VBO()
        {
            GL.ClearColor(0.1f, 0.1f, 0.5f, 0.0f);
            GL.Enable(OpenTK.OpenGL.Enums.EnableCap.DEPTH_TEST);
            //GL.EnableClientState(OpenTK.OpenGL.Enums.EnableCap.VERTEX_ARRAY);
            //GL.EnableClientState(OpenTK.OpenGL.Enums.EnableCap.INDEX_ARRAY);
            GL.Enable(OpenTK.OpenGL.Enums.EnableCap.VERTEX_ARRAY);
            GL.Enable(OpenTK.OpenGL.Enums.EnableCap.INDEX_ARRAY);

            LoadCube();
        }

        public override void RenderFrame()
        {
            base.RenderFrame();

            GL.Clear(
                OpenTK.OpenGL.Enums.ClearBufferMask.COLOR_BUFFER_BIT |
                OpenTK.OpenGL.Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            //GL.BindBuffer(OpenTK.OpenGL.Enums.VERSION_1_5.ARRAY_BUFFER, nbo);
            //GL.NormalPointer(OpenTK.OpenGL.Enums.NormalPointerType.FLOAT, 0, 0);

            GL.BindBuffer(OpenTK.OpenGL.Enums.VERSION_1_5.ARRAY_BUFFER, vbo);
            GL.VertexPointer(3, OpenTK.OpenGL.Enums.VertexPointerType.FLOAT, 0, 0);

            GL.BindBuffer(OpenTK.OpenGL.Enums.VERSION_1_5.ELEMENT_ARRAY_BUFFER, ibo);
            //GL.IndexPointer(OpenTK.OpenGL.Enums.IndexPointerType.SHORT, 0, 0);

            GL.Color3f(1.0f, 1.0f, 1.0f);
            GL.DrawElements(
                OpenTK.OpenGL.Enums.BeginMode.QUADS,
                idata.Length,
                OpenTK.OpenGL.Enums.GLenum.UNSIGNED_SHORT,
                (IntPtr)0);
        }

        float angle = 0.0f;
        public override void UpdateFrame()
        {
            base.UpdateFrame();

            GL.Rotatef(angle, 0.0f, 1.0f, 0.0f);
            angle += 0.5f;
        }

        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            //base.Resize(e);

            GL.Viewport(0, 0, e.Width, e.Height);

            double ratio = e.Width / (double)e.Height;

            GL.MatrixMode(OpenTK.OpenGL.Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);

            GL.MatrixMode(OpenTK.OpenGL.Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 5.0, 5.0,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );
        }

        private void LoadCube()
        {
            // Generate the buffer objects
            GL.GenBuffers(1, out vbo);
            //GL.GenBuffers(1, out nbo);
            GL.GenBuffers(1, out ibo);

            // Upload the data for each object
            GL.BindBuffer(OpenTK.OpenGL.Enums.VERSION_1_5.ARRAY_BUFFER, vbo);
            GL.BufferData(
                OpenTK.OpenGL.Enums.VERSION_1_5.ARRAY_BUFFER,
                (IntPtr)(vdata.Length*4),
                vdata,
                OpenTK.OpenGL.Enums.VERSION_1_5.STATIC_DRAW
            );
            /*
            GL.BindBuffer(OpenTK.OpenGL.Enums.VERSION_1_5.ARRAY_BUFFER, nbo);
            GL.BufferData(
                OpenTK.OpenGL.Enums.VERSION_1_5.ARRAY_BUFFER,
                (IntPtr)ndata.Length,
                ndata,
                OpenTK.OpenGL.Enums.VERSION_1_5.STATIC_DRAW
            );
            */
            GL.BindBuffer(OpenTK.OpenGL.Enums.VERSION_1_5.ELEMENT_ARRAY_BUFFER, ibo);
            GL.BufferData(
                OpenTK.OpenGL.Enums.VERSION_1_5.ELEMENT_ARRAY_BUFFER,
                (IntPtr)(idata.Length*2),
                idata,
                OpenTK.OpenGL.Enums.VERSION_1_5.STATIC_DRAW
            );

        }
    }
}
