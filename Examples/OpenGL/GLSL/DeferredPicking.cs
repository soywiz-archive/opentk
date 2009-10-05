using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;

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
            : base(800, 600, GraphicsMode.Default, "OpenTK Quick Start Sample", GameWindowFlags.Default, DisplayDevice.Default, 2, 1, GraphicsContextFlags.Default)
        {
            VSync = VSyncMode.On;
        }

        const TextureTarget Target = TextureTarget.TextureRectangleArb;
        const int FBO_width = 800;
        const int FBO_height = 600;
        uint[] ColorAttachments = new uint[2];
        uint DepthAttachment;
        uint FBO;
        DrawBuffersEnum[] FBO_Buffers = new DrawBuffersEnum[] { DrawBuffersEnum.ColorAttachment0, DrawBuffersEnum.ColorAttachment1 }; 

        struct Byte4
        {
            public byte R, G, B, A;

            public Byte4(byte[] input)
            {
                R = input[0];
                G = input[1];
                B = input[2];
                A = input[3];
            }

            public uint GetUint()
            { 
                byte[] temp= new byte[]{this.R, this.G, this.B, this.A};
                return BitConverter.ToUInt32(temp, 0);
            }
        }

        struct Vertex
        {
            public Vector3 Position; // 12 bytes
            public Byte4 Color; // 4 bytes

            public const byte SizeInBytes = 16;
        }

        BeginMode VBO_PrimMode;
        Vertex[] VBO_Array;
        uint VBO_Handle;

        int VertexShaderObject, FragmentShaderObject, ProgramObject;

        /// <summary>Load resources here.</summary>
        /// <param name="e">Not used.</param>
        public override void OnLoad(EventArgs e)
        {
            GL.ClearColor(.1f, .2f, .3f, 1f);
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.CullFace);

            #region Prepare FBO Attachments

            // Depth Attachment
            GL.GenTextures(1, out DepthAttachment);
            GL.BindTexture(Target, DepthAttachment);
            GL.TexImage2D(Target, 0, PixelInternalFormat.DepthComponent, FBO_width, FBO_height, 0, PixelFormat.DepthComponent, PixelType.UnsignedInt, IntPtr.Zero);
            GL.TexParameter(Target, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(Target, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(Target, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
            GL.TexParameter(Target, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);

            // Color Attachment
            GL.GenTextures(2, ColorAttachments);
            for (int i = 0; i < ColorAttachments.Length; i++)
            {
                GL.BindTexture(Target, ColorAttachments[i]);
                GL.TexImage2D(Target, 0, PixelInternalFormat.Rgba8, FBO_width, FBO_height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, IntPtr.Zero);
                GL.TexParameter(Target, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
                GL.TexParameter(Target, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);
                GL.TexParameter(Target, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
                GL.TexParameter(Target, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);
            }
            GL.BindTexture(Target, 0);

            ErrorCode err = GL.GetError();
            if (err != ErrorCode.NoError)
                Trace.WriteLine("Texture creation failed (Error: " + err + "). Attempting to continue.");
            #endregion Prepare FBO Attachments

            #region Prepare FBO
            GL.GenFramebuffers(1, out FBO);
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, FBO);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.DepthAttachment, Target, DepthAttachment, 0);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.ColorAttachment0, Target, ColorAttachments[0], 0);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.ColorAttachment1, Target, ColorAttachments[1], 0);
            FramebufferErrorCode FBOerr = GL.CheckFramebufferStatus(FramebufferTarget.Framebuffer);
            if (FBOerr != FramebufferErrorCode.FramebufferComplete)
                Trace.WriteLine("FBO creation failed. Error: " + FBOerr.ToString());

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);

            err = GL.GetError();
            if (err != ErrorCode.NoError)
                Trace.WriteLine("FBO creation failed (Error: " + err + "). Attempting to continue.");
            #endregion Prepare FBO

            #region prepare data for VBO from procedural object
            DrawableShape temp_obj = new KochTetrahedron(1.5f, 0.2, 1.1, KochTetrahedron.eSubdivisions.Three, false);
            VertexT2fN3fV3f[] temp_VBO;
            uint[] temp_IBO;
            temp_obj.GetArraysforVBO(out VBO_PrimMode, out temp_VBO, out temp_IBO);
            temp_obj.Dispose();
            if (temp_IBO != null)
                throw new Exception("Expected data for GL.DrawArrays, but Element Array is not null.");

            VBO_Array = new Vertex[temp_VBO.Length];
            int tricounter = -1;
            for (int i = 0; i < temp_VBO.Length; i++)
            {
                // Position
                VBO_Array[i].Position = temp_VBO[i].Position;

                // Index
                if (i % 3 == 0)
                    tricounter++;
                // TODO: pack uint to Byte4
                VBO_Array[i].Color = new Byte4(BitConverter.GetBytes(tricounter));
            }
            #endregion prepare data for VBO from procedural object

            #region Setup VBO for drawing

            GL.GenBuffers(1, out VBO_Handle);
            GL.BindBuffer(BufferTarget.ArrayBuffer, VBO_Handle);
            GL.BufferData<Vertex>(BufferTarget.ArrayBuffer, (IntPtr)(VBO_Array.Length * Vertex.SizeInBytes), VBO_Array, BufferUsageHint.StaticDraw);
  
            // Position
            GL.EnableVertexAttribArray(0);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, Vertex.SizeInBytes, 0);
            // Color
            GL.EnableVertexAttribArray(1);
            GL.VertexAttribPointer(1, 4, VertexAttribPointerType.UnsignedByte, true, Vertex.SizeInBytes, 12);
          
            err = GL.GetError();
            if (err != ErrorCode.NoError)
                Trace.WriteLine("VBO Setup failed (Error: " + err + "). Attempting to continue.");

            #endregion Setup VBO for drawing

            #region Shader

            // Load&Compile Vertex Shader

            using (StreamReader sr = new StreamReader("Data/Shaders/Picking_VS.glsl"))
            {
                VertexShaderObject = GL.CreateShader(ShaderType.VertexShader);
                GL.ShaderSource(VertexShaderObject, sr.ReadToEnd());
                GL.CompileShader(VertexShaderObject);
            }

            err = GL.GetError();
            if (err != ErrorCode.NoError)
                Trace.WriteLine("Vertex Shader: " + err);

            string LogInfo;
            GL.GetShaderInfoLog(VertexShaderObject, out LogInfo);
            if (LogInfo.Length > 0 && !LogInfo.Contains("hardware"))
                Trace.WriteLine("Vertex Shader failed!\nLog:\n" + LogInfo);
            else
                Trace.WriteLine("Vertex Shader compiled without complaint.");

            // Load&Compile Fragment Shader

            using (StreamReader sr = new StreamReader("Data/Shaders/Picking_FS.glsl"))
            {
                FragmentShaderObject = GL.CreateShader(ShaderType.FragmentShader);
                GL.ShaderSource(FragmentShaderObject, sr.ReadToEnd());
                GL.CompileShader(FragmentShaderObject);
            }
            GL.GetShaderInfoLog(FragmentShaderObject, out LogInfo);

            err = GL.GetError();
            if (err != ErrorCode.NoError)
                Trace.WriteLine("Fragment Shader: " + err);

            if (LogInfo.Length > 0 && !LogInfo.Contains("hardware"))
                Trace.WriteLine("Fragment Shader failed!\nLog:\n" + LogInfo);
            else
                Trace.WriteLine("Fragment Shader compiled without complaint.");

            // Link the Shaders to a usable Program
            ProgramObject = GL.CreateProgram();
            GL.AttachShader(ProgramObject, VertexShaderObject);
            GL.AttachShader(ProgramObject, FragmentShaderObject);

            // must bind the attributes before linking

            GL.BindAttribLocation(ProgramObject, 1, "Color");
            GL.BindAttribLocation(ProgramObject, 0, "Position");

            // link it all together
            GL.LinkProgram(ProgramObject);

            err = GL.GetError();
            if (err != ErrorCode.NoError)
                Trace.WriteLine("LinkProgram: " + err);

            GL.UseProgram(ProgramObject);

            err = GL.GetError();
            if (err != ErrorCode.NoError)
                Trace.WriteLine("UseProgram: " + err);

            // flag ShaderObjects for delete when not used anymore
            GL.DeleteShader(VertexShaderObject);
            GL.DeleteShader(FragmentShaderObject);

            int temp;
            GL.GetProgram(ProgramObject, ProgramParameter.LinkStatus, out temp);
            Trace.WriteLine("Linking Program (" + ProgramObject + ") " + ((temp == 1) ? "succeeded." : "FAILED!"));
            if (temp != 1)
            {
                GL.GetProgramInfoLog(ProgramObject, out LogInfo);
                Trace.WriteLine("Program Log:\n" + LogInfo);
            }

            GL.GetProgram(ProgramObject, ProgramParameter.ActiveAttributes, out temp);
            Trace.WriteLine("Program registered " + temp + " Attributes. (Should be 2: Color and Position)");

            Trace.WriteLine("Color attribute bind location: " + GL.GetAttribLocation(ProgramObject, "Color"));
            Trace.WriteLine("Position attribute bind location: " + GL.GetAttribLocation(ProgramObject, "Position"));

            Trace.WriteLine("End of Shader build. GL Error: " + GL.GetError());

            GL.UseProgram(0);

            #endregion Shader

        }

        public override void OnUnload(EventArgs e)
        {
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, FBO);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.DepthAttachment, Target, 0, 0);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.ColorAttachment0, Target, 0, 0);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.ColorAttachment1, Target, 0, 0);
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);

            GL.DeleteFramebuffers(1, ref FBO);
            GL.DeleteTextures(1, ref DepthAttachment);
            GL.DeleteTextures(2, ColorAttachments);

            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.DeleteBuffers(1, ref VBO_Handle);

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

            #region Draw Object into FBO
            Matrix4 modelview = Matrix4.LookAt(Vector3.UnitZ, Vector3.Zero, Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, FBO);
            GL.DrawBuffers(2, FBO_Buffers);
            GL.UseProgram(ProgramObject);

            GL.Translate(0f, 0f, -3f);
            GL.DrawArrays(VBO_PrimMode, 0, VBO_Array.Length);

            GL.UseProgram(0);
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
            // GL.DrawBuffers(1, DrawBuffersEnum.BackLeft);
            GL.DrawBuffer(DrawBufferMode.Back);
            #endregion Draw Object into FBO

            #region Show Color Attachment 0 in backbuffer
            GL.MatrixMode(MatrixMode.Projection);
            GL.PushMatrix();
            Matrix4 portho = Matrix4.CreateOrthographicOffCenter(-1f, 1f, -1f, 1f, -1f, 1f);
            GL.LoadMatrix(ref portho);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

           // GL.Enable(EnableCap.Texture2D);
            GL.Enable( (EnableCap)All.TextureRectangleArb );
            GL.BindTexture(Target, ColorAttachments[0]);
            GL.Begin(BeginMode.Quads);
            {
                GL.Color3(1f, 1f, 1f);
                GL.TexCoord2(0f,(float)FBO_height); GL.Vertex3(-1f, +1f, 0f);
                GL.TexCoord2(0f, 0f); GL.Vertex3(-1f, -1f, 0f);
                GL.TexCoord2((float)FBO_width, 0f); GL.Vertex3(+1f, -1f, 0f);
                GL.TexCoord2((float)FBO_width, (float)FBO_height); GL.Vertex3(+1f, +1f, 0f);
            }
            GL.End();
            GL.BindTexture(Target,0);
          //  GL.Disable(EnableCap.Texture2D);
            GL.Disable((EnableCap)All.TextureRectangleArb);

            GL.MatrixMode(MatrixMode.Projection);
            GL.PopMatrix();
            #endregion Show Color Attachment 0 in backbuffer

            this.SwapBuffers();
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