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

    [Example("Picking", ExampleCategory.OpenGL, "GLSL", Documentation = "Picking")]
    class Picking : GameWindow
    {
        /// <summary>Creates a 800x600 window with the specified title.</summary>
        public Picking()
            : base(800, 600, GraphicsMode.Default, "OpenTK Quick Start Sample", GameWindowFlags.Default, DisplayDevice.Default, 2, 1, GraphicsContextFlags.Default)
        {
            VSync = VSyncMode.On;
        }

        const TextureTarget Target = TextureTarget.TextureRectangleArb;
        const int FBO_width = 800;
        const int FBO_height = 600;
        uint ColorAttachment;
        uint DepthAttachment;
        uint FBO;
        DrawBuffersEnum[] FBO_Buffers = new DrawBuffersEnum[] { DrawBuffersEnum.ColorAttachment0 };

        float angle; 

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

            public uint ToUInt32()
            {
                byte[] temp = new byte[] { this.R, this.G, this.B, this.A };
                return BitConverter.ToUInt32(temp, 0);
            }

            public string GetValues()
            {
                return this.R + ", " + this.G + ", " + this.B + ", " + this.A;
            }
        }

        struct Vertex
        {
            public Byte4 Color; // 4 bytes
            public Vector3 Position; // 12 bytes

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
            GL.GenTextures(1, out ColorAttachment);
            GL.BindTexture(Target, ColorAttachment);
            GL.TexImage2D(Target, 0, PixelInternalFormat.Rgba8, FBO_width, FBO_height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, IntPtr.Zero);
            GL.TexParameter(Target, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(Target, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(Target, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
            GL.TexParameter(Target, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);

            GL.BindTexture(Target, 0);

            ErrorCode err = GL.GetError();
            if (err != ErrorCode.NoError)
                Trace.WriteLine("Texture creation failed (Error: " + err + "). Attempting to continue.");
            #endregion Prepare FBO Attachments

            #region Prepare FBO
            GL.GenFramebuffers(1, out FBO);
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, FBO);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.DepthAttachment, Target, DepthAttachment, 0);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.ColorAttachment0, Target, ColorAttachment, 0);
            FramebufferErrorCode FBOerr = GL.CheckFramebufferStatus(FramebufferTarget.Framebuffer);
            if (FBOerr != FramebufferErrorCode.FramebufferComplete)
                Trace.WriteLine("FBO creation failed. Error: " + FBOerr.ToString());

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);

            err = GL.GetError();
            if (err != ErrorCode.NoError)
                Trace.WriteLine("FBO creation failed (Error: " + err + "). Attempting to continue.");
            #endregion Prepare FBO

            #region prepare data for VBO from procedural object
            DrawableShape temp_obj = new SierpinskiTetrahedron(3f, SierpinskiTetrahedron.eSubdivisions.One, false);
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
                VBO_Array[i].Color = new Byte4(BitConverter.GetBytes(tricounter));
            }
            #endregion prepare data for VBO from procedural object

            #region Setup VBO for drawing

            GL.GenBuffers(1, out VBO_Handle);
            GL.BindBuffer(BufferTarget.ArrayBuffer, VBO_Handle);
            GL.BufferData<Vertex>(BufferTarget.ArrayBuffer, (IntPtr)(VBO_Array.Length * Vertex.SizeInBytes), VBO_Array, BufferUsageHint.StaticDraw);
            GL.InterleavedArrays(InterleavedArrayFormat.C4ubV3f, 0, IntPtr.Zero);

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

            Trace.WriteLine("End of Shader build. GL Error: " + GL.GetError());

            GL.UseProgram(0);

            #endregion Shader

        }

        public override void OnUnload(EventArgs e)
        {
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, FBO);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.DepthAttachment, Target, 0, 0);
            GL.FramebufferTexture2D(FramebufferTarget.Framebuffer, FramebufferAttachment.ColorAttachment0, Target, 0, 0);
            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);

            GL.DeleteFramebuffers(1, ref FBO);
            GL.DeleteTextures(1, ref DepthAttachment);
            GL.DeleteTextures(1, ref ColorAttachment);

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
            #region Pass 1: Draw Object into FBO
            Matrix4 modelview = Matrix4.LookAt(Vector3.UnitZ, Vector3.Zero, Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, FBO);
            GL.DrawBuffers(FBO_Buffers.Length, FBO_Buffers);
         // GL.ReadBuffer(ReadBufferMode.ColorAttachment0);
            GL.Viewport(0, 0, FBO_width, FBO_height);

            GL.ClearColor(1f, 1f, 1f, 1f);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.UseProgram(ProgramObject);
            GL.Translate(0f, 0f, -3f);
            GL.Rotate(angle, Vector3.UnitX);
            GL.Rotate(angle, Vector3.UnitY);
            angle += (float)e.Time*3.0f;
            GL.DrawArrays(VBO_PrimMode, 0, VBO_Array.Length);
            GL.UseProgram(0);

            /*
            // Read Pixel under mouse cursor
            Byte4 Pixel = new Byte4();
            GL.ReadPixels<Byte4>(Mouse.X, FBO_height-Mouse.Y, 1, 1, PixelFormat.Rgba, PixelType.UnsignedByte, ref Pixel);
            uint SelectedTriangle = Pixel.ToUInt32();
            
            if (SelectedTriangle > 0)
            {
                Trace.WriteLine("Hovered over triangle: " + SelectedTriangle);
            }*/

            GL.BindFramebuffer(FramebufferTarget.Framebuffer, 0);
            GL.DrawBuffer(DrawBufferMode.Back);
            #endregion Pass 1: Draw Object into FBO

            #region Remove this in favor of GL.ReadPixels()
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(Target, ColorAttachment);
            Byte4[] Tex = new Byte4[FBO_width * FBO_height];
            GL.GetTexImage<Byte4>(Target, 0, PixelFormat.Rgba, PixelType.UnsignedByte, Tex);
            GL.BindTexture(Target, 0);
            GL.Disable(EnableCap.Texture2D);
            uint SelectedTriangle = Tex[(FBO_height-Mouse.Y)*FBO_width+Mouse.X].ToUInt32();
            #endregion Remove this in favor of GL.ReadPixels()

            #region Pass 2: Draw Wireframe of whole object
            GL.ClearColor(.2f, .1f, .3f, 1f);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.PolygonMode(MaterialFace.Front, PolygonMode.Line);
            GL.DrawArrays(VBO_PrimMode, 0, VBO_Array.Length);
            GL.PolygonMode(MaterialFace.Front, PolygonMode.Fill);
            #endregion Pass 2: Draw Wireframe of whole object

            #region Pass 3: Draw selected Triangle
            GL.Disable(EnableCap.DepthTest);
            GL.DrawArrays(VBO_PrimMode, (int)SelectedTriangle * 3, 3);
            GL.Enable(EnableCap.DepthTest);
            #endregion Pass 3: Draw selected Triangle

            this.SwapBuffers();

            ErrorCode err = GL.GetError();
            if (err != ErrorCode.NoError)
                Trace.WriteLine("Error at Swapbuffers: " + err);
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
            using (Picking example = new Picking())
            {
                // Get the title and category  of this example using reflection.
                ExampleAttribute info = ((ExampleAttribute)example.GetType().GetCustomAttributes(false)[0]);
                example.Title = String.Format("OpenTK | {0} {1}: {2}", info.Category, info.Difficulty, info.Title);
                example.Run(30.0);
            }
        }
    }
}