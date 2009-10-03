using System;
using System.Drawing;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

using Examples.Shapes;

namespace Examples.Tutorial
{

    [Example("Deferred Picking", ExampleCategory.OpenGL, "GLSL", Documentation = "DeferredPicking")]
    class DeferredPicking : GameWindow
    {
        /// <summary>Creates a 800x600 window with the specified title.</summary>
        public DeferredPicking()
            : base(800, 600, GraphicsMode.Default, "OpenTK Quick Start Sample")
        {
            VSync = VSyncMode.On;
        }

        const TextureTarget Target = TextureTarget.TextureRectangleArb;
        const int FBO_width = 800;
        const int FBO_height= 600;
        uint[] Attachments = new uint[2];
        uint FBO;

        DrawableShape KochStar;

        /// <summary>Load resources here.</summary>
        /// <param name="e">Not used.</param>
        public override void OnLoad(EventArgs e)
        {
            GL.ClearColor(.1f, .2f, .3f, 1f);
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.CullFace);

            #region Prepare FBO Attachments
            GL.GenTextures(2, Attachments);
            for (int i = 0; i < Attachments.Length; i++)
            {
                GL.BindTexture(Target, Attachments[i]);
                GL.TexImage2D(Target, 0, PixelInternalFormat.Rgba8, FBO_width, FBO_height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, IntPtr.Zero);
                GL.TexParameter(Target, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
                GL.TexParameter(Target, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);
                GL.TexParameter(Target, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
                GL.TexParameter(Target, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);
            }
            GL.BindTexture(Target, 0);
            #endregion Prepare FBO Attachments

            #region Prepare FBO
            GL.GenFramebuffers(1, out FBO);
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, FBO);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.ColorAttachment0, Target, Attachments[0], 0);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.ColorAttachment1, Target, Attachments[1], 0);
            FramebufferErrorCode FBOerr = GL.CheckFramebufferStatus(FramebufferTarget.Framebuffer);
            if (FBOerr != FramebufferErrorCode.FramebufferComplete)
                Console.WriteLine("FBO creation failed. Error: " + FBOerr.ToString());

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
            #endregion Prepare FBO

            KochStar = new KochTetrahedron(1.5f, 0.4, 0.5, KochTetrahedron.eSubdivisions.Three, true);
        }

        public override void OnUnload(EventArgs e)
        {
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, FBO);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.ColorAttachment0, Target, 0, 0);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.ColorAttachment1, Target, 0, 0);
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);

            GL.DeleteFramebuffers(1, ref FBO);
            GL.DeleteTextures(2, Attachments);

            if (KochStar != null)
            KochStar.Dispose();

            base.OnUnload(e);
        }

        /// <summary>
        /// Called when your window is resized. Set your viewport here. It is also
        /// a good place to set up your projection matrix (which probably changes
        /// along when the aspect ratio of your window).
        /// </summary>
        /// <param name="e">Contains information on the new Width and Size of the GameWindow.</param>
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(ClientRectangle);

            Matrix4 projection = Matrix4.Perspective(45.0f, Width / (float)Height, 0.1f, 50.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        }

        /// <summary>
        /// Called when it is time to setup the next frame. Add you game logic here.
        /// </summary>
        /// <param name="e">Contains timing information for framerate independent logic.</param>
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            if (Keyboard[Key.Escape])
                Exit();
        }

        /// <summary>
        /// Called when it is time to render the next frame. Add your rendering code here.
        /// </summary>
        /// <param name="e">Contains timing information.</param>
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 modelview = Matrix4.LookAt( Vector3.UnitZ, Vector3.Zero,Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);

            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Light0);


            GL.Color3(1f, 1f, 1f);
            GL.Translate(0f, 0f, -3f);
            KochStar.Draw();
            

            SwapBuffers();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // The 'using' idiom guarantees proper resource cleanup.
            // We request 30 UpdateFrame events per second, and unlimited
            // RenderFrame events (as fast as the computer can handle).
            using (DeferredPicking example = new DeferredPicking())
            {
                // Get the title and category  of this example using reflection.
                ExampleAttribute info = ((ExampleAttribute)example.GetType().GetCustomAttributes(false)[0]);
                example.Title = String.Format("OpenTK | {0} {1}: {2}", info.Category, info.Difficulty, info.Title);
                example.Run(30.0);
            }
        }
    }
}