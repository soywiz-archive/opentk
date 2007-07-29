namespace OpenTK.OpenGL
{
    using GLsizei = System.Int32;
    using GLsizeiptr = System.IntPtr;
    using GLintptr = System.IntPtr;
    using GLboolean = System.Boolean;
    using GLbitfield = System.Int32;
    using GLchar = System.Char;
    using GLbyte = System.Byte;
    using GLubyte = System.Byte;
    using GLshort = System.Int16;
    using GLushort = System.Int16;
    using GLint = System.Int32;
    using GLuint = System.Int32;
    using GLfloat = System.Single;
    using GLclampf = System.Single;
    using GLdouble = System.Double;
    using GLclampd = System.Double;
    using GLstring = System.String;
    using GLsizeiptrARB = System.IntPtr;
    using GLintptrARB = System.IntPtr;
    using GLhandleARB = System.Int32;
    using GLhalfARB = System.Int16;
    using GLhalfNV = System.Int16;
    using GLcharARB = System.Char;
    using GLint64EXT = System.Int64;
    using GLuint64EXT = System.Int64;
    using GLint64 = System.Int64;
    using GLuint64 = System.Int64;
    public static partial class GL
    {
        static GL() { }

        public static 
        void NewList(GLuint list, GL.Enums.ListMode mode)
        {
            Delegates.glNewList(list, mode);
        }
        
        public static 
        void EndList()
        {
            Delegates.glEndList();
        }
        
        public static 
        void CallList(GLuint list)
        {
            Delegates.glCallList(list);
        }
        
        public static 
        unsafe void CallLists(GLsizei n, GL.Enums.ListNameType type, void* lists)
        {
            Delegates.glCallLists(n, type, lists);
        }
        
        public static 
        void DeleteLists(GLuint list, GLsizei range)
        {
            Delegates.glDeleteLists(list, range);
        }
        
        public static 
        GLuint GenLists(GLsizei range)
        {
            return Delegates.glGenLists(range);
        }
        
        public static 
        void ListBase(GLuint @base)
        {
            Delegates.glListBase(@base);
        }
        
        public static 
        void Begin(GL.Enums.BeginMode mode)
        {
            Delegates.glBegin(mode);
        }
        
        public static 
        unsafe void Bitmap(GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, GLubyte* bitmap)
        {
            Delegates.glBitmap(width, height, xorig, yorig, xmove, ymove, bitmap);
        }
        
        public static 
        void Color3b(GLbyte red, GLbyte green, GLbyte blue)
        {
            Delegates.glColor3b(red, green, blue);
        }
        
        public static 
        unsafe void Color3bv(GLbyte* v)
        {
            Delegates.glColor3bv(v);
        }
        
        public static 
        void Color3d(GLdouble red, GLdouble green, GLdouble blue)
        {
            Delegates.glColor3d(red, green, blue);
        }
        
        public static 
        unsafe void Color3dv(GLdouble* v)
        {
            Delegates.glColor3dv(v);
        }
        
        public static 
        void Color3f(GLfloat red, GLfloat green, GLfloat blue)
        {
            Delegates.glColor3f(red, green, blue);
        }
        
        public static 
        unsafe void Color3fv(GLfloat* v)
        {
            Delegates.glColor3fv(v);
        }
        
        public static 
        void Color3i(GLint red, GLint green, GLint blue)
        {
            Delegates.glColor3i(red, green, blue);
        }
        
        public static 
        unsafe void Color3iv(GLint* v)
        {
            Delegates.glColor3iv(v);
        }
        
        public static 
        void Color3s(GLshort red, GLshort green, GLshort blue)
        {
            Delegates.glColor3s(red, green, blue);
        }
        
        public static 
        unsafe void Color3sv(GLshort* v)
        {
            Delegates.glColor3sv(v);
        }
        
        public static 
        void Color3ub(GLubyte red, GLubyte green, GLubyte blue)
        {
            Delegates.glColor3ub(red, green, blue);
        }
        
        public static 
        unsafe void Color3ubv(GLubyte* v)
        {
            Delegates.glColor3ubv(v);
        }
        
        public static 
        void Color3ui(GLuint red, GLuint green, GLuint blue)
        {
            Delegates.glColor3ui(red, green, blue);
        }
        
        public static 
        unsafe void Color3uiv(GLuint* v)
        {
            Delegates.glColor3uiv(v);
        }
        
        public static 
        void Color3us(GLushort red, GLushort green, GLushort blue)
        {
            Delegates.glColor3us(red, green, blue);
        }
        
        public static 
        unsafe void Color3usv(GLushort* v)
        {
            Delegates.glColor3usv(v);
        }
        
        public static 
        void Color4b(GLbyte red, GLbyte green, GLbyte blue, GLbyte alpha)
        {
            Delegates.glColor4b(red, green, blue, alpha);
        }
        
        public static 
        unsafe void Color4bv(GLbyte* v)
        {
            Delegates.glColor4bv(v);
        }
        
        public static 
        void Color4d(GLdouble red, GLdouble green, GLdouble blue, GLdouble alpha)
        {
            Delegates.glColor4d(red, green, blue, alpha);
        }
        
        public static 
        unsafe void Color4dv(GLdouble* v)
        {
            Delegates.glColor4dv(v);
        }
        
        public static 
        void Color4f(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)
        {
            Delegates.glColor4f(red, green, blue, alpha);
        }
        
        public static 
        unsafe void Color4fv(GLfloat* v)
        {
            Delegates.glColor4fv(v);
        }
        
        public static 
        void Color4i(GLint red, GLint green, GLint blue, GLint alpha)
        {
            Delegates.glColor4i(red, green, blue, alpha);
        }
        
        public static 
        unsafe void Color4iv(GLint* v)
        {
            Delegates.glColor4iv(v);
        }
        
        public static 
        void Color4s(GLshort red, GLshort green, GLshort blue, GLshort alpha)
        {
            Delegates.glColor4s(red, green, blue, alpha);
        }
        
        public static 
        unsafe void Color4sv(GLshort* v)
        {
            Delegates.glColor4sv(v);
        }
        
        public static 
        void Color4ub(GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha)
        {
            Delegates.glColor4ub(red, green, blue, alpha);
        }
        
        public static 
        unsafe void Color4ubv(GLubyte* v)
        {
            Delegates.glColor4ubv(v);
        }
        
        public static 
        void Color4ui(GLuint red, GLuint green, GLuint blue, GLuint alpha)
        {
            Delegates.glColor4ui(red, green, blue, alpha);
        }
        
        public static 
        unsafe void Color4uiv(GLuint* v)
        {
            Delegates.glColor4uiv(v);
        }
        
        public static 
        void Color4us(GLushort red, GLushort green, GLushort blue, GLushort alpha)
        {
            Delegates.glColor4us(red, green, blue, alpha);
        }
        
        public static 
        unsafe void Color4usv(GLushort* v)
        {
            Delegates.glColor4usv(v);
        }
        
        public static 
        unsafe void EdgeFlagv(GL.Enums.Boolean* flag)
        {
            Delegates.glEdgeFlagv(flag);
        }
        
        public static 
        void End()
        {
            Delegates.glEnd();
        }
        
        public static 
        void Indexd(GLdouble c)
        {
            Delegates.glIndexd(c);
        }
        
        public static 
        unsafe void Indexdv(GLdouble* c)
        {
            Delegates.glIndexdv(c);
        }
        
        public static 
        void Indexf(GLfloat c)
        {
            Delegates.glIndexf(c);
        }
        
        public static 
        unsafe void Indexfv(GLfloat* c)
        {
            Delegates.glIndexfv(c);
        }
        
        public static 
        void Indexi(GLint c)
        {
            Delegates.glIndexi(c);
        }
        
        public static 
        unsafe void Indexiv(GLint* c)
        {
            Delegates.glIndexiv(c);
        }
        
        public static 
        void Indexs(GLshort c)
        {
            Delegates.glIndexs(c);
        }
        
        public static 
        unsafe void Indexsv(GLshort* c)
        {
            Delegates.glIndexsv(c);
        }
        
        public static 
        void Normal3b(GLbyte nx, GLbyte ny, GLbyte nz)
        {
            Delegates.glNormal3b(nx, ny, nz);
        }
        
        public static 
        unsafe void Normal3bv(GLbyte* v)
        {
            Delegates.glNormal3bv(v);
        }
        
        public static 
        void Normal3d(GLdouble nx, GLdouble ny, GLdouble nz)
        {
            Delegates.glNormal3d(nx, ny, nz);
        }
        
        public static 
        unsafe void Normal3dv(GLdouble* v)
        {
            Delegates.glNormal3dv(v);
        }
        
        public static 
        void Normal3f(GLfloat nx, GLfloat ny, GLfloat nz)
        {
            Delegates.glNormal3f(nx, ny, nz);
        }
        
        public static 
        unsafe void Normal3fv(GLfloat* v)
        {
            Delegates.glNormal3fv(v);
        }
        
        public static 
        void Normal3i(GLint nx, GLint ny, GLint nz)
        {
            Delegates.glNormal3i(nx, ny, nz);
        }
        
        public static 
        unsafe void Normal3iv(GLint* v)
        {
            Delegates.glNormal3iv(v);
        }
        
        public static 
        void Normal3s(GLshort nx, GLshort ny, GLshort nz)
        {
            Delegates.glNormal3s(nx, ny, nz);
        }
        
        public static 
        unsafe void Normal3sv(GLshort* v)
        {
            Delegates.glNormal3sv(v);
        }
        
        public static 
        void RasterPos2d(GLdouble x, GLdouble y)
        {
            Delegates.glRasterPos2d(x, y);
        }
        
        public static 
        unsafe void RasterPos2dv(GLdouble* v)
        {
            Delegates.glRasterPos2dv(v);
        }
        
        public static 
        void RasterPos2f(GLfloat x, GLfloat y)
        {
            Delegates.glRasterPos2f(x, y);
        }
        
        public static 
        unsafe void RasterPos2fv(GLfloat* v)
        {
            Delegates.glRasterPos2fv(v);
        }
        
        public static 
        void RasterPos2i(GLint x, GLint y)
        {
            Delegates.glRasterPos2i(x, y);
        }
        
        public static 
        unsafe void RasterPos2iv(GLint* v)
        {
            Delegates.glRasterPos2iv(v);
        }
        
        public static 
        void RasterPos2s(GLshort x, GLshort y)
        {
            Delegates.glRasterPos2s(x, y);
        }
        
        public static 
        unsafe void RasterPos2sv(GLshort* v)
        {
            Delegates.glRasterPos2sv(v);
        }
        
        public static 
        void RasterPos3d(GLdouble x, GLdouble y, GLdouble z)
        {
            Delegates.glRasterPos3d(x, y, z);
        }
        
        public static 
        unsafe void RasterPos3dv(GLdouble* v)
        {
            Delegates.glRasterPos3dv(v);
        }
        
        public static 
        void RasterPos3f(GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glRasterPos3f(x, y, z);
        }
        
        public static 
        unsafe void RasterPos3fv(GLfloat* v)
        {
            Delegates.glRasterPos3fv(v);
        }
        
        public static 
        void RasterPos3i(GLint x, GLint y, GLint z)
        {
            Delegates.glRasterPos3i(x, y, z);
        }
        
        public static 
        unsafe void RasterPos3iv(GLint* v)
        {
            Delegates.glRasterPos3iv(v);
        }
        
        public static 
        void RasterPos3s(GLshort x, GLshort y, GLshort z)
        {
            Delegates.glRasterPos3s(x, y, z);
        }
        
        public static 
        unsafe void RasterPos3sv(GLshort* v)
        {
            Delegates.glRasterPos3sv(v);
        }
        
        public static 
        void RasterPos4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            Delegates.glRasterPos4d(x, y, z, w);
        }
        
        public static 
        unsafe void RasterPos4dv(GLdouble* v)
        {
            Delegates.glRasterPos4dv(v);
        }
        
        public static 
        void RasterPos4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            Delegates.glRasterPos4f(x, y, z, w);
        }
        
        public static 
        unsafe void RasterPos4fv(GLfloat* v)
        {
            Delegates.glRasterPos4fv(v);
        }
        
        public static 
        void RasterPos4i(GLint x, GLint y, GLint z, GLint w)
        {
            Delegates.glRasterPos4i(x, y, z, w);
        }
        
        public static 
        unsafe void RasterPos4iv(GLint* v)
        {
            Delegates.glRasterPos4iv(v);
        }
        
        public static 
        void RasterPos4s(GLshort x, GLshort y, GLshort z, GLshort w)
        {
            Delegates.glRasterPos4s(x, y, z, w);
        }
        
        public static 
        unsafe void RasterPos4sv(GLshort* v)
        {
            Delegates.glRasterPos4sv(v);
        }
        
        public static 
        void Rectd(GLdouble x1, GLdouble y1, GLdouble x2, GLdouble y2)
        {
            Delegates.glRectd(x1, y1, x2, y2);
        }
        
        public static 
        unsafe void Rectdv(GLdouble* v1, GLdouble* v2)
        {
            Delegates.glRectdv(v1, v2);
        }
        
        public static 
        void Rectf(GLfloat x1, GLfloat y1, GLfloat x2, GLfloat y2)
        {
            Delegates.glRectf(x1, y1, x2, y2);
        }
        
        public static 
        unsafe void Rectfv(GLfloat* v1, GLfloat* v2)
        {
            Delegates.glRectfv(v1, v2);
        }
        
        public static 
        void Recti(GLint x1, GLint y1, GLint x2, GLint y2)
        {
            Delegates.glRecti(x1, y1, x2, y2);
        }
        
        public static 
        unsafe void Rectiv(GLint* v1, GLint* v2)
        {
            Delegates.glRectiv(v1, v2);
        }
        
        public static 
        void Rects(GLshort x1, GLshort y1, GLshort x2, GLshort y2)
        {
            Delegates.glRects(x1, y1, x2, y2);
        }
        
        public static 
        unsafe void Rectsv(GLshort* v1, GLshort* v2)
        {
            Delegates.glRectsv(v1, v2);
        }
        
        public static 
        void TexCoord1d(GLdouble s)
        {
            Delegates.glTexCoord1d(s);
        }
        
        public static 
        unsafe void TexCoord1dv(GLdouble* v)
        {
            Delegates.glTexCoord1dv(v);
        }
        
        public static 
        void TexCoord1f(GLfloat s)
        {
            Delegates.glTexCoord1f(s);
        }
        
        public static 
        unsafe void TexCoord1fv(GLfloat* v)
        {
            Delegates.glTexCoord1fv(v);
        }
        
        public static 
        void TexCoord1i(GLint s)
        {
            Delegates.glTexCoord1i(s);
        }
        
        public static 
        unsafe void TexCoord1iv(GLint* v)
        {
            Delegates.glTexCoord1iv(v);
        }
        
        public static 
        void TexCoord1s(GLshort s)
        {
            Delegates.glTexCoord1s(s);
        }
        
        public static 
        unsafe void TexCoord1sv(GLshort* v)
        {
            Delegates.glTexCoord1sv(v);
        }
        
        public static 
        void TexCoord2d(GLdouble s, GLdouble t)
        {
            Delegates.glTexCoord2d(s, t);
        }
        
        public static 
        unsafe void TexCoord2dv(GLdouble* v)
        {
            Delegates.glTexCoord2dv(v);
        }
        
        public static 
        void TexCoord2f(GLfloat s, GLfloat t)
        {
            Delegates.glTexCoord2f(s, t);
        }
        
        public static 
        unsafe void TexCoord2fv(GLfloat* v)
        {
            Delegates.glTexCoord2fv(v);
        }
        
        public static 
        void TexCoord2i(GLint s, GLint t)
        {
            Delegates.glTexCoord2i(s, t);
        }
        
        public static 
        unsafe void TexCoord2iv(GLint* v)
        {
            Delegates.glTexCoord2iv(v);
        }
        
        public static 
        void TexCoord2s(GLshort s, GLshort t)
        {
            Delegates.glTexCoord2s(s, t);
        }
        
        public static 
        unsafe void TexCoord2sv(GLshort* v)
        {
            Delegates.glTexCoord2sv(v);
        }
        
        public static 
        void TexCoord3d(GLdouble s, GLdouble t, GLdouble r)
        {
            Delegates.glTexCoord3d(s, t, r);
        }
        
        public static 
        unsafe void TexCoord3dv(GLdouble* v)
        {
            Delegates.glTexCoord3dv(v);
        }
        
        public static 
        void TexCoord3f(GLfloat s, GLfloat t, GLfloat r)
        {
            Delegates.glTexCoord3f(s, t, r);
        }
        
        public static 
        unsafe void TexCoord3fv(GLfloat* v)
        {
            Delegates.glTexCoord3fv(v);
        }
        
        public static 
        void TexCoord3i(GLint s, GLint t, GLint r)
        {
            Delegates.glTexCoord3i(s, t, r);
        }
        
        public static 
        unsafe void TexCoord3iv(GLint* v)
        {
            Delegates.glTexCoord3iv(v);
        }
        
        public static 
        void TexCoord3s(GLshort s, GLshort t, GLshort r)
        {
            Delegates.glTexCoord3s(s, t, r);
        }
        
        public static 
        unsafe void TexCoord3sv(GLshort* v)
        {
            Delegates.glTexCoord3sv(v);
        }
        
        public static 
        void TexCoord4d(GLdouble s, GLdouble t, GLdouble r, GLdouble q)
        {
            Delegates.glTexCoord4d(s, t, r, q);
        }
        
        public static 
        unsafe void TexCoord4dv(GLdouble* v)
        {
            Delegates.glTexCoord4dv(v);
        }
        
        public static 
        void TexCoord4f(GLfloat s, GLfloat t, GLfloat r, GLfloat q)
        {
            Delegates.glTexCoord4f(s, t, r, q);
        }
        
        public static 
        unsafe void TexCoord4fv(GLfloat* v)
        {
            Delegates.glTexCoord4fv(v);
        }
        
        public static 
        void TexCoord4i(GLint s, GLint t, GLint r, GLint q)
        {
            Delegates.glTexCoord4i(s, t, r, q);
        }
        
        public static 
        unsafe void TexCoord4iv(GLint* v)
        {
            Delegates.glTexCoord4iv(v);
        }
        
        public static 
        void TexCoord4s(GLshort s, GLshort t, GLshort r, GLshort q)
        {
            Delegates.glTexCoord4s(s, t, r, q);
        }
        
        public static 
        unsafe void TexCoord4sv(GLshort* v)
        {
            Delegates.glTexCoord4sv(v);
        }
        
        public static 
        void Vertex2d(GLdouble x, GLdouble y)
        {
            Delegates.glVertex2d(x, y);
        }
        
        public static 
        unsafe void Vertex2dv(GLdouble* v)
        {
            Delegates.glVertex2dv(v);
        }
        
        public static 
        void Vertex2f(GLfloat x, GLfloat y)
        {
            Delegates.glVertex2f(x, y);
        }
        
        public static 
        unsafe void Vertex2fv(GLfloat* v)
        {
            Delegates.glVertex2fv(v);
        }
        
        public static 
        void Vertex2i(GLint x, GLint y)
        {
            Delegates.glVertex2i(x, y);
        }
        
        public static 
        unsafe void Vertex2iv(GLint* v)
        {
            Delegates.glVertex2iv(v);
        }
        
        public static 
        void Vertex2s(GLshort x, GLshort y)
        {
            Delegates.glVertex2s(x, y);
        }
        
        public static 
        unsafe void Vertex2sv(GLshort* v)
        {
            Delegates.glVertex2sv(v);
        }
        
        public static 
        void Vertex3d(GLdouble x, GLdouble y, GLdouble z)
        {
            Delegates.glVertex3d(x, y, z);
        }
        
        public static 
        unsafe void Vertex3dv(GLdouble* v)
        {
            Delegates.glVertex3dv(v);
        }
        
        public static 
        void Vertex3f(GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glVertex3f(x, y, z);
        }
        
        public static 
        unsafe void Vertex3fv(GLfloat* v)
        {
            Delegates.glVertex3fv(v);
        }
        
        public static 
        void Vertex3i(GLint x, GLint y, GLint z)
        {
            Delegates.glVertex3i(x, y, z);
        }
        
        public static 
        unsafe void Vertex3iv(GLint* v)
        {
            Delegates.glVertex3iv(v);
        }
        
        public static 
        void Vertex3s(GLshort x, GLshort y, GLshort z)
        {
            Delegates.glVertex3s(x, y, z);
        }
        
        public static 
        unsafe void Vertex3sv(GLshort* v)
        {
            Delegates.glVertex3sv(v);
        }
        
        public static 
        void Vertex4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            Delegates.glVertex4d(x, y, z, w);
        }
        
        public static 
        unsafe void Vertex4dv(GLdouble* v)
        {
            Delegates.glVertex4dv(v);
        }
        
        public static 
        void Vertex4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            Delegates.glVertex4f(x, y, z, w);
        }
        
        public static 
        unsafe void Vertex4fv(GLfloat* v)
        {
            Delegates.glVertex4fv(v);
        }
        
        public static 
        void Vertex4i(GLint x, GLint y, GLint z, GLint w)
        {
            Delegates.glVertex4i(x, y, z, w);
        }
        
        public static 
        unsafe void Vertex4iv(GLint* v)
        {
            Delegates.glVertex4iv(v);
        }
        
        public static 
        void Vertex4s(GLshort x, GLshort y, GLshort z, GLshort w)
        {
            Delegates.glVertex4s(x, y, z, w);
        }
        
        public static 
        unsafe void Vertex4sv(GLshort* v)
        {
            Delegates.glVertex4sv(v);
        }
        
        public static 
        unsafe void ClipPlane(GL.Enums.ClipPlaneName plane, GLdouble* equation)
        {
            Delegates.glClipPlane(plane, equation);
        }
        
        public static 
        void ColorMaterial(GL.Enums.MaterialFace face, GL.Enums.ColorMaterialParameter mode)
        {
            Delegates.glColorMaterial(face, mode);
        }
        
        public static 
        void CullFace(GL.Enums.CullFaceMode mode)
        {
            Delegates.glCullFace(mode);
        }
        
        public static 
        void Fogf(GL.Enums.FogParameter pname, GLfloat param)
        {
            Delegates.glFogf(pname, param);
        }
        
        public static 
        unsafe void Fogfv(GL.Enums.FogParameter pname, GLfloat* @params)
        {
            Delegates.glFogfv(pname, @params);
        }
        
        public static 
        void Fogi(GL.Enums.FogParameter pname, GLint param)
        {
            Delegates.glFogi(pname, param);
        }
        
        public static 
        unsafe void Fogiv(GL.Enums.FogParameter pname, GLint* @params)
        {
            Delegates.glFogiv(pname, @params);
        }
        
        public static 
        void FrontFace(GL.Enums.FrontFaceDirection mode)
        {
            Delegates.glFrontFace(mode);
        }
        
        public static 
        void Hint(GL.Enums.HintTarget target, GL.Enums.HintMode mode)
        {
            Delegates.glHint(target, mode);
        }
        
        public static 
        void Lightf(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLfloat param)
        {
            Delegates.glLightf(light, pname, param);
        }
        
        public static 
        unsafe void Lightfv(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLfloat* @params)
        {
            Delegates.glLightfv(light, pname, @params);
        }
        
        public static 
        void Lighti(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLint param)
        {
            Delegates.glLighti(light, pname, param);
        }
        
        public static 
        unsafe void Lightiv(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLint* @params)
        {
            Delegates.glLightiv(light, pname, @params);
        }
        
        public static 
        void LightModelf(GL.Enums.LightModelParameter pname, GLfloat param)
        {
            Delegates.glLightModelf(pname, param);
        }
        
        public static 
        unsafe void LightModelfv(GL.Enums.LightModelParameter pname, GLfloat* @params)
        {
            Delegates.glLightModelfv(pname, @params);
        }
        
        public static 
        void LightModeli(GL.Enums.LightModelParameter pname, GLint param)
        {
            Delegates.glLightModeli(pname, param);
        }
        
        public static 
        unsafe void LightModeliv(GL.Enums.LightModelParameter pname, GLint* @params)
        {
            Delegates.glLightModeliv(pname, @params);
        }
        
        public static 
        void LineWidth(GLfloat width)
        {
            Delegates.glLineWidth(width);
        }
        
        public static 
        void Materialf(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat param)
        {
            Delegates.glMaterialf(face, pname, param);
        }
        
        public static 
        unsafe void Materialfv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat* @params)
        {
            Delegates.glMaterialfv(face, pname, @params);
        }
        
        public static 
        void Materiali(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint param)
        {
            Delegates.glMateriali(face, pname, param);
        }
        
        public static 
        unsafe void Materialiv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint* @params)
        {
            Delegates.glMaterialiv(face, pname, @params);
        }
        
        public static 
        void PointSize(GLfloat size)
        {
            Delegates.glPointSize(size);
        }
        
        public static 
        void PolygonMode(GL.Enums.MaterialFace face, GL.Enums.PolygonMode mode)
        {
            Delegates.glPolygonMode(face, mode);
        }
        
        public static 
        unsafe void PolygonStipple(GLubyte* mask)
        {
            Delegates.glPolygonStipple(mask);
        }
        
        public static 
        void Scissor(GLint x, GLint y, GLsizei width, GLsizei height)
        {
            Delegates.glScissor(x, y, width, height);
        }
        
        public static 
        void ShadeModel(GL.Enums.ShadingModel mode)
        {
            Delegates.glShadeModel(mode);
        }
        
        public static 
        void TexParameterf(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLfloat param)
        {
            Delegates.glTexParameterf(target, pname, param);
        }
        
        public static 
        unsafe void TexParameterfv(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLfloat* @params)
        {
            Delegates.glTexParameterfv(target, pname, @params);
        }
        
        public static 
        void TexParameteri(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLint param)
        {
            Delegates.glTexParameteri(target, pname, param);
        }
        
        public static 
        unsafe void TexParameteriv(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLint* @params)
        {
            Delegates.glTexParameteriv(target, pname, @params);
        }
        
        public static 
        unsafe void TexImage1D(GL.Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            Delegates.glTexImage1D(target, level, internalformat, width, border, format, type, pixels);
        }
        
        public static 
        unsafe void TexImage2D(GL.Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            Delegates.glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
        }
        
        public static 
        void TexEnvf(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLfloat param)
        {
            Delegates.glTexEnvf(target, pname, param);
        }
        
        public static 
        unsafe void TexEnvfv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLfloat* @params)
        {
            Delegates.glTexEnvfv(target, pname, @params);
        }
        
        public static 
        void TexEnvi(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLint param)
        {
            Delegates.glTexEnvi(target, pname, param);
        }
        
        public static 
        unsafe void TexEnviv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLint* @params)
        {
            Delegates.glTexEnviv(target, pname, @params);
        }
        
        public static 
        void TexGend(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLdouble param)
        {
            Delegates.glTexGend(coord, pname, param);
        }
        
        public static 
        unsafe void TexGendv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLdouble* @params)
        {
            Delegates.glTexGendv(coord, pname, @params);
        }
        
        public static 
        void TexGenf(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLfloat param)
        {
            Delegates.glTexGenf(coord, pname, param);
        }
        
        public static 
        unsafe void TexGenfv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLfloat* @params)
        {
            Delegates.glTexGenfv(coord, pname, @params);
        }
        
        public static 
        void TexGeni(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLint param)
        {
            Delegates.glTexGeni(coord, pname, param);
        }
        
        public static 
        unsafe void TexGeniv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLint* @params)
        {
            Delegates.glTexGeniv(coord, pname, @params);
        }
        
        public static 
        unsafe void FeedbackBuffer(GLsizei size, GL.Enums.FeedbackType type, GLfloat* buffer)
        {
            Delegates.glFeedbackBuffer(size, type, buffer);
        }
        
        public static 
        unsafe void SelectBuffer(GLsizei size, GLuint* buffer)
        {
            Delegates.glSelectBuffer(size, buffer);
        }
        
        public static 
        GLint RenderMode(GL.Enums.RenderingMode mode)
        {
            return Delegates.glRenderMode(mode);
        }
        
        public static 
        void InitNames()
        {
            Delegates.glInitNames();
        }
        
        public static 
        void LoadName(GLuint name)
        {
            Delegates.glLoadName(name);
        }
        
        public static 
        void PassThrough(GLfloat token)
        {
            Delegates.glPassThrough(token);
        }
        
        public static 
        void PopName()
        {
            Delegates.glPopName();
        }
        
        public static 
        void PushName(GLuint name)
        {
            Delegates.glPushName(name);
        }
        
        public static 
        void DrawBuffer(GL.Enums.DrawBufferMode mode)
        {
            Delegates.glDrawBuffer(mode);
        }
        
        public static 
        void Clear(GL.Enums.ClearBufferMask mask)
        {
            Delegates.glClear(mask);
        }
        
        public static 
        void ClearAccum(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)
        {
            Delegates.glClearAccum(red, green, blue, alpha);
        }
        
        public static 
        void ClearIndex(GLfloat c)
        {
            Delegates.glClearIndex(c);
        }
        
        public static 
        void ClearColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha)
        {
            Delegates.glClearColor(red, green, blue, alpha);
        }
        
        public static 
        void ClearStencil(GLint s)
        {
            Delegates.glClearStencil(s);
        }
        
        public static 
        void ClearDepth(GLclampd depth)
        {
            Delegates.glClearDepth(depth);
        }
        
        public static 
        void StencilMask(GLuint mask)
        {
            Delegates.glStencilMask(mask);
        }
        
        public static 
        void IndexMask(GLuint mask)
        {
            Delegates.glIndexMask(mask);
        }
        
        public static 
        void Accum(GL.Enums.AccumOp op, GLfloat value)
        {
            Delegates.glAccum(op, value);
        }
        
        public static 
        void Disable(GL.Enums.EnableCap cap)
        {
            Delegates.glDisable(cap);
        }
        
        public static 
        void Enable(GL.Enums.EnableCap cap)
        {
            Delegates.glEnable(cap);
        }
        
        public static 
        void Finish()
        {
            Delegates.glFinish();
        }
        
        public static 
        void Flush()
        {
            Delegates.glFlush();
        }
        
        public static 
        void PopAttrib()
        {
            Delegates.glPopAttrib();
        }
        
        public static 
        void PushAttrib(GL.Enums.AttribMask mask)
        {
            Delegates.glPushAttrib(mask);
        }
        
        public static 
        unsafe void Map1d(GL.Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint stride, GLint order, GLdouble* points)
        {
            Delegates.glMap1d(target, u1, u2, stride, order, points);
        }
        
        public static 
        unsafe void Map1f(GL.Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint stride, GLint order, GLfloat* points)
        {
            Delegates.glMap1f(target, u1, u2, stride, order, points);
        }
        
        public static 
        unsafe void Map2d(GL.Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble* points)
        {
            Delegates.glMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        }
        
        public static 
        unsafe void Map2f(GL.Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat* points)
        {
            Delegates.glMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        }
        
        public static 
        void MapGrid1d(GLint un, GLdouble u1, GLdouble u2)
        {
            Delegates.glMapGrid1d(un, u1, u2);
        }
        
        public static 
        void MapGrid1f(GLint un, GLfloat u1, GLfloat u2)
        {
            Delegates.glMapGrid1f(un, u1, u2);
        }
        
        public static 
        void MapGrid2d(GLint un, GLdouble u1, GLdouble u2, GLint vn, GLdouble v1, GLdouble v2)
        {
            Delegates.glMapGrid2d(un, u1, u2, vn, v1, v2);
        }
        
        public static 
        void MapGrid2f(GLint un, GLfloat u1, GLfloat u2, GLint vn, GLfloat v1, GLfloat v2)
        {
            Delegates.glMapGrid2f(un, u1, u2, vn, v1, v2);
        }
        
        public static 
        void EvalCoord1d(GLdouble u)
        {
            Delegates.glEvalCoord1d(u);
        }
        
        public static 
        unsafe void EvalCoord1dv(GLdouble* u)
        {
            Delegates.glEvalCoord1dv(u);
        }
        
        public static 
        void EvalCoord1f(GLfloat u)
        {
            Delegates.glEvalCoord1f(u);
        }
        
        public static 
        unsafe void EvalCoord1fv(GLfloat* u)
        {
            Delegates.glEvalCoord1fv(u);
        }
        
        public static 
        void EvalCoord2d(GLdouble u, GLdouble v)
        {
            Delegates.glEvalCoord2d(u, v);
        }
        
        public static 
        unsafe void EvalCoord2dv(GLdouble* u)
        {
            Delegates.glEvalCoord2dv(u);
        }
        
        public static 
        void EvalCoord2f(GLfloat u, GLfloat v)
        {
            Delegates.glEvalCoord2f(u, v);
        }
        
        public static 
        unsafe void EvalCoord2fv(GLfloat* u)
        {
            Delegates.glEvalCoord2fv(u);
        }
        
        public static 
        void EvalMesh1(GL.Enums.MeshMode1 mode, GLint i1, GLint i2)
        {
            Delegates.glEvalMesh1(mode, i1, i2);
        }
        
        public static 
        void EvalPoint1(GLint i)
        {
            Delegates.glEvalPoint1(i);
        }
        
        public static 
        void EvalMesh2(GL.Enums.MeshMode2 mode, GLint i1, GLint i2, GLint j1, GLint j2)
        {
            Delegates.glEvalMesh2(mode, i1, i2, j1, j2);
        }
        
        public static 
        void EvalPoint2(GLint i, GLint j)
        {
            Delegates.glEvalPoint2(i, j);
        }
        
        public static 
        void AlphaFunc(GL.Enums.AlphaFunction func, GLclampf @ref)
        {
            Delegates.glAlphaFunc(func, @ref);
        }
        
        public static 
        void BlendFunc(GL.Enums.BlendingFactorSrc sfactor, GL.Enums.BlendingFactorDest dfactor)
        {
            Delegates.glBlendFunc(sfactor, dfactor);
        }
        
        public static 
        void LogicOp(GL.Enums.LogicOp opcode)
        {
            Delegates.glLogicOp(opcode);
        }
        
        public static 
        void StencilFunc(GL.Enums.StencilFunction func, GLint @ref, GLuint mask)
        {
            Delegates.glStencilFunc(func, @ref, mask);
        }
        
        public static 
        void StencilOp(GL.Enums.StencilOp fail, GL.Enums.StencilOp zfail, GL.Enums.StencilOp zpass)
        {
            Delegates.glStencilOp(fail, zfail, zpass);
        }
        
        public static 
        void DepthFunc(GL.Enums.DepthFunction func)
        {
            Delegates.glDepthFunc(func);
        }
        
        public static 
        void PixelZoom(GLfloat xfactor, GLfloat yfactor)
        {
            Delegates.glPixelZoom(xfactor, yfactor);
        }
        
        public static 
        void PixelTransferf(GL.Enums.PixelTransferParameter pname, GLfloat param)
        {
            Delegates.glPixelTransferf(pname, param);
        }
        
        public static 
        void PixelTransferi(GL.Enums.PixelTransferParameter pname, GLint param)
        {
            Delegates.glPixelTransferi(pname, param);
        }
        
        public static 
        void PixelStoref(GL.Enums.PixelStoreParameter pname, GLfloat param)
        {
            Delegates.glPixelStoref(pname, param);
        }
        
        public static 
        void PixelStorei(GL.Enums.PixelStoreParameter pname, GLint param)
        {
            Delegates.glPixelStorei(pname, param);
        }
        
        public static 
        unsafe void PixelMapfv(GL.Enums.PixelMap map, GLint mapsize, GLfloat* values)
        {
            Delegates.glPixelMapfv(map, mapsize, values);
        }
        
        public static 
        unsafe void PixelMapuiv(GL.Enums.PixelMap map, GLint mapsize, GLuint* values)
        {
            Delegates.glPixelMapuiv(map, mapsize, values);
        }
        
        public static 
        unsafe void PixelMapusv(GL.Enums.PixelMap map, GLint mapsize, GLushort* values)
        {
            Delegates.glPixelMapusv(map, mapsize, values);
        }
        
        public static 
        void ReadBuffer(GL.Enums.ReadBufferMode mode)
        {
            Delegates.glReadBuffer(mode);
        }
        
        public static 
        void CopyPixels(GLint x, GLint y, GLsizei width, GLsizei height, GL.Enums.PixelCopyType type)
        {
            Delegates.glCopyPixels(x, y, width, height, type);
        }
        
        public static 
        unsafe void ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            Delegates.glReadPixels(x, y, width, height, format, type, pixels);
        }
        
        public static 
        unsafe void DrawPixels(GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            Delegates.glDrawPixels(width, height, format, type, pixels);
        }
        
        public static 
        unsafe void GetBooleanv(GL.Enums.GetPName pname, GL.Enums.Boolean* @params)
        {
            Delegates.glGetBooleanv(pname, @params);
        }
        
        public static 
        unsafe void GetClipPlane(GL.Enums.ClipPlaneName plane, GLdouble* equation)
        {
            Delegates.glGetClipPlane(plane, equation);
        }
        
        public static 
        unsafe void GetDoublev(GL.Enums.GetPName pname, GLdouble* @params)
        {
            Delegates.glGetDoublev(pname, @params);
        }
        
        public static 
        GL.Enums.GLenum GetError()
        {
            return Delegates.glGetError();
        }
        
        public static 
        unsafe void GetFloatv(GL.Enums.GetPName pname, GLfloat* @params)
        {
            Delegates.glGetFloatv(pname, @params);
        }
        
        public static 
        unsafe void GetIntegerv(GL.Enums.GetPName pname, GLint* @params)
        {
            Delegates.glGetIntegerv(pname, @params);
        }
        
        public static 
        unsafe void GetLightfv(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLfloat* @params)
        {
            Delegates.glGetLightfv(light, pname, @params);
        }
        
        public static 
        unsafe void GetLightiv(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLint* @params)
        {
            Delegates.glGetLightiv(light, pname, @params);
        }
        
        public static 
        unsafe void GetMapdv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, GLdouble* v)
        {
            Delegates.glGetMapdv(target, query, v);
        }
        
        public static 
        unsafe void GetMapfv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, GLfloat* v)
        {
            Delegates.glGetMapfv(target, query, v);
        }
        
        public static 
        unsafe void GetMapiv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, GLint* v)
        {
            Delegates.glGetMapiv(target, query, v);
        }
        
        public static 
        unsafe void GetMaterialfv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat* @params)
        {
            Delegates.glGetMaterialfv(face, pname, @params);
        }
        
        public static 
        unsafe void GetMaterialiv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint* @params)
        {
            Delegates.glGetMaterialiv(face, pname, @params);
        }
        
        public static 
        unsafe void GetPixelMapfv(GL.Enums.PixelMap map, GLfloat* values)
        {
            Delegates.glGetPixelMapfv(map, values);
        }
        
        public static 
        unsafe void GetPixelMapuiv(GL.Enums.PixelMap map, GLuint* values)
        {
            Delegates.glGetPixelMapuiv(map, values);
        }
        
        public static 
        unsafe void GetPixelMapusv(GL.Enums.PixelMap map, GLushort* values)
        {
            Delegates.glGetPixelMapusv(map, values);
        }
        
        public static 
        unsafe void GetPolygonStipple(GLubyte* mask)
        {
            Delegates.glGetPolygonStipple(mask);
        }
        
        public static 
        System.String GetString(GL.Enums.StringName name)
        {
            return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Delegates.glGetString(name));
        }
        
        public static 
        unsafe void GetTexEnvfv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLfloat* @params)
        {
            Delegates.glGetTexEnvfv(target, pname, @params);
        }
        
        public static 
        unsafe void GetTexEnviv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLint* @params)
        {
            Delegates.glGetTexEnviv(target, pname, @params);
        }
        
        public static 
        unsafe void GetTexGendv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLdouble* @params)
        {
            Delegates.glGetTexGendv(coord, pname, @params);
        }
        
        public static 
        unsafe void GetTexGenfv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLfloat* @params)
        {
            Delegates.glGetTexGenfv(coord, pname, @params);
        }
        
        public static 
        unsafe void GetTexGeniv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLint* @params)
        {
            Delegates.glGetTexGeniv(coord, pname, @params);
        }
        
        public static 
        unsafe void GetTexImage(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            Delegates.glGetTexImage(target, level, format, type, pixels);
        }
        
        public static 
        unsafe void GetTexParameterfv(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, GLfloat* @params)
        {
            Delegates.glGetTexParameterfv(target, pname, @params);
        }
        
        public static 
        unsafe void GetTexParameteriv(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, GLint* @params)
        {
            Delegates.glGetTexParameteriv(target, pname, @params);
        }
        
        public static 
        unsafe void GetTexLevelParameterfv(GL.Enums.TextureTarget target, GLint level, GL.Enums.GetTextureParameter pname, GLfloat* @params)
        {
            Delegates.glGetTexLevelParameterfv(target, level, pname, @params);
        }
        
        public static 
        unsafe void GetTexLevelParameteriv(GL.Enums.TextureTarget target, GLint level, GL.Enums.GetTextureParameter pname, GLint* @params)
        {
            Delegates.glGetTexLevelParameteriv(target, level, pname, @params);
        }
        
        public static 
        GLboolean IsEnabled(GL.Enums.EnableCap cap)
        {
            return Delegates.glIsEnabled(cap);
        }
        
        public static 
        GLboolean IsList(GLuint list)
        {
            return Delegates.glIsList(list);
        }
        
        public static 
        void DepthRange(GLclampd near, GLclampd far)
        {
            Delegates.glDepthRange(near, far);
        }
        
        public static 
        void Frustum(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar)
        {
            Delegates.glFrustum(left, right, bottom, top, zNear, zFar);
        }
        
        public static 
        void LoadIdentity()
        {
            Delegates.glLoadIdentity();
        }
        
        public static 
        unsafe void LoadMatrixf(GLfloat* m)
        {
            Delegates.glLoadMatrixf(m);
        }
        
        public static 
        unsafe void LoadMatrixd(GLdouble* m)
        {
            Delegates.glLoadMatrixd(m);
        }
        
        public static 
        void MatrixMode(GL.Enums.MatrixMode mode)
        {
            Delegates.glMatrixMode(mode);
        }
        
        public static 
        unsafe void MultMatrixf(GLfloat* m)
        {
            Delegates.glMultMatrixf(m);
        }
        
        public static 
        unsafe void MultMatrixd(GLdouble* m)
        {
            Delegates.glMultMatrixd(m);
        }
        
        public static 
        void Ortho(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar)
        {
            Delegates.glOrtho(left, right, bottom, top, zNear, zFar);
        }
        
        public static 
        void PopMatrix()
        {
            Delegates.glPopMatrix();
        }
        
        public static 
        void PushMatrix()
        {
            Delegates.glPushMatrix();
        }
        
        public static 
        void Rotated(GLdouble angle, GLdouble x, GLdouble y, GLdouble z)
        {
            Delegates.glRotated(angle, x, y, z);
        }
        
        public static 
        void Rotatef(GLfloat angle, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glRotatef(angle, x, y, z);
        }
        
        public static 
        void Scaled(GLdouble x, GLdouble y, GLdouble z)
        {
            Delegates.glScaled(x, y, z);
        }
        
        public static 
        void Scalef(GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glScalef(x, y, z);
        }
        
        public static 
        void Translated(GLdouble x, GLdouble y, GLdouble z)
        {
            Delegates.glTranslated(x, y, z);
        }
        
        public static 
        void Translatef(GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glTranslatef(x, y, z);
        }
        
        public static 
        void Viewport(GLint x, GLint y, GLsizei width, GLsizei height)
        {
            Delegates.glViewport(x, y, width, height);
        }
        
        public static 
        void ArrayElement(GLint i)
        {
            Delegates.glArrayElement(i);
        }
        
        public static 
        unsafe void ColorPointer(GLint size, GL.Enums.ColorPointerType type, GLsizei stride, void* pointer)
        {
            Delegates.glColorPointer(size, type, stride, pointer);
        }
        
        public static 
        void DisableClientState(GL.Enums.EnableCap array)
        {
            Delegates.glDisableClientState(array);
        }
        
        public static 
        void DrawArrays(GL.Enums.BeginMode mode, GLint first, GLsizei count)
        {
            Delegates.glDrawArrays(mode, first, count);
        }
        
        public static 
        unsafe void DrawElements(GL.Enums.BeginMode mode, GLsizei count, GL.Enums.GLenum type, void* indices)
        {
            Delegates.glDrawElements(mode, count, type, indices);
        }
        
        public static 
        unsafe void EdgeFlagPointer(GLsizei stride, void* pointer)
        {
            Delegates.glEdgeFlagPointer(stride, pointer);
        }
        
        public static 
        void EnableClientState(GL.Enums.EnableCap array)
        {
            Delegates.glEnableClientState(array);
        }
        
        public static 
        unsafe void GetPointerv(GL.Enums.GetPointervPName pname, void* @params)
        {
            Delegates.glGetPointerv(pname, @params);
        }
        
        public static 
        unsafe void IndexPointer(GL.Enums.IndexPointerType type, GLsizei stride, void* pointer)
        {
            Delegates.glIndexPointer(type, stride, pointer);
        }
        
        public static 
        unsafe void InterleavedArrays(GL.Enums.InterleavedArrayFormat format, GLsizei stride, void* pointer)
        {
            Delegates.glInterleavedArrays(format, stride, pointer);
        }
        
        public static 
        unsafe void NormalPointer(GL.Enums.NormalPointerType type, GLsizei stride, void* pointer)
        {
            Delegates.glNormalPointer(type, stride, pointer);
        }
        
        public static 
        unsafe void TexCoordPointer(GLint size, GL.Enums.TexCoordPointerType type, GLsizei stride, void* pointer)
        {
            Delegates.glTexCoordPointer(size, type, stride, pointer);
        }
        
        public static 
        unsafe void VertexPointer(GLint size, GL.Enums.VertexPointerType type, GLsizei stride, void* pointer)
        {
            Delegates.glVertexPointer(size, type, stride, pointer);
        }
        
        public static 
        void PolygonOffset(GLfloat factor, GLfloat units)
        {
            Delegates.glPolygonOffset(factor, units);
        }
        
        public static 
        void CopyTexImage1D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLint border)
        {
            Delegates.glCopyTexImage1D(target, level, internalformat, x, y, width, border);
        }
        
        public static 
        void CopyTexImage2D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)
        {
            Delegates.glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
        }
        
        public static 
        void CopyTexSubImage1D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
        {
            Delegates.glCopyTexSubImage1D(target, level, xoffset, x, y, width);
        }
        
        public static 
        void CopyTexSubImage2D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            Delegates.glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
        }
        
        public static 
        unsafe void TexSubImage1D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            Delegates.glTexSubImage1D(target, level, xoffset, width, format, type, pixels);
        }
        
        public static 
        unsafe void TexSubImage2D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            Delegates.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }
        
        public static 
        unsafe GLboolean AreTexturesResident(GLsizei n, GLuint* textures, GL.Enums.Boolean* residences)
        {
            return Delegates.glAreTexturesResident(n, textures, residences);
        }
        
        public static 
        void BindTexture(GL.Enums.TextureTarget target, GLuint texture)
        {
            Delegates.glBindTexture(target, texture);
        }
        
        public static 
        unsafe void DeleteTextures(GLsizei n, GLuint* textures)
        {
            Delegates.glDeleteTextures(n, textures);
        }
        
        public static 
        unsafe void GenTextures(GLsizei n, GLuint* textures)
        {
            Delegates.glGenTextures(n, textures);
        }
        
        public static 
        GLboolean IsTexture(GLuint texture)
        {
            return Delegates.glIsTexture(texture);
        }
        
        public static 
        unsafe void PrioritizeTextures(GLsizei n, GLuint* textures, GLclampf* priorities)
        {
            Delegates.glPrioritizeTextures(n, textures, priorities);
        }
        
        public static 
        void Indexub(GLubyte c)
        {
            Delegates.glIndexub(c);
        }
        
        public static 
        unsafe void Indexubv(GLubyte* c)
        {
            Delegates.glIndexubv(c);
        }
        
        public static 
        void PopClientAttrib()
        {
            Delegates.glPopClientAttrib();
        }
        
        public static 
        void PushClientAttrib(GL.Enums.ClientAttribMask mask)
        {
            Delegates.glPushClientAttrib(mask);
        }
        
        public static 
        void BlendColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha)
        {
            Delegates.glBlendColor(red, green, blue, alpha);
        }
        
        public static 
        void BlendEquation(GL.Enums.VERSION_1_2 mode)
        {
            Delegates.glBlendEquation(mode);
        }
        
        public static 
        unsafe void DrawRangeElements(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count, GL.Enums.VERSION_1_2 type, void* indices)
        {
            Delegates.glDrawRangeElements(mode, start, end, count, type, indices);
        }
        
        public static 
        unsafe void ColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table)
        {
            Delegates.glColorTable(target, internalformat, width, format, type, table);
        }
        
        public static 
        unsafe void ColorTableParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params)
        {
            Delegates.glColorTableParameterfv(target, pname, @params);
        }
        
        public static 
        unsafe void ColorTableParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params)
        {
            Delegates.glColorTableParameteriv(target, pname, @params);
        }
        
        public static 
        void CopyColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width)
        {
            Delegates.glCopyColorTable(target, internalformat, x, y, width);
        }
        
        public static 
        unsafe void GetColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table)
        {
            Delegates.glGetColorTable(target, format, type, table);
        }
        
        public static 
        unsafe void GetColorTableParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params)
        {
            Delegates.glGetColorTableParameterfv(target, pname, @params);
        }
        
        public static 
        unsafe void GetColorTableParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params)
        {
            Delegates.glGetColorTableParameteriv(target, pname, @params);
        }
        
        public static 
        unsafe void ColorSubTable(GL.Enums.VERSION_1_2 target, GLsizei start, GLsizei count, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data)
        {
            Delegates.glColorSubTable(target, start, count, format, type, data);
        }
        
        public static 
        void CopyColorSubTable(GL.Enums.VERSION_1_2 target, GLsizei start, GLint x, GLint y, GLsizei width)
        {
            Delegates.glCopyColorSubTable(target, start, x, y, width);
        }
        
        public static 
        unsafe void ConvolutionFilter1D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image)
        {
            Delegates.glConvolutionFilter1D(target, internalformat, width, format, type, image);
        }
        
        public static 
        unsafe void ConvolutionFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image)
        {
            Delegates.glConvolutionFilter2D(target, internalformat, width, height, format, type, image);
        }
        
        public static 
        void ConvolutionParameterf(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat @params)
        {
            Delegates.glConvolutionParameterf(target, pname, @params);
        }
        
        public static 
        unsafe void ConvolutionParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params)
        {
            Delegates.glConvolutionParameterfv(target, pname, @params);
        }
        
        public static 
        void ConvolutionParameteri(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint @params)
        {
            Delegates.glConvolutionParameteri(target, pname, @params);
        }
        
        public static 
        unsafe void ConvolutionParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params)
        {
            Delegates.glConvolutionParameteriv(target, pname, @params);
        }
        
        public static 
        void CopyConvolutionFilter1D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width)
        {
            Delegates.glCopyConvolutionFilter1D(target, internalformat, x, y, width);
        }
        
        public static 
        void CopyConvolutionFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            Delegates.glCopyConvolutionFilter2D(target, internalformat, x, y, width, height);
        }
        
        public static 
        unsafe void GetConvolutionFilter(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image)
        {
            Delegates.glGetConvolutionFilter(target, format, type, image);
        }
        
        public static 
        unsafe void GetConvolutionParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params)
        {
            Delegates.glGetConvolutionParameterfv(target, pname, @params);
        }
        
        public static 
        unsafe void GetConvolutionParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params)
        {
            Delegates.glGetConvolutionParameteriv(target, pname, @params);
        }
        
        public static 
        unsafe void GetSeparableFilter(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column, void* span)
        {
            Delegates.glGetSeparableFilter(target, format, type, row, column, span);
        }
        
        public static 
        unsafe void SeparableFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column)
        {
            Delegates.glSeparableFilter2D(target, internalformat, width, height, format, type, row, column);
        }
        
        public static 
        unsafe void GetHistogram(GL.Enums.VERSION_1_2 target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* values)
        {
            Delegates.glGetHistogram(target, reset, format, type, values);
        }
        
        public static 
        unsafe void GetHistogramParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params)
        {
            Delegates.glGetHistogramParameterfv(target, pname, @params);
        }
        
        public static 
        unsafe void GetHistogramParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params)
        {
            Delegates.glGetHistogramParameteriv(target, pname, @params);
        }
        
        public static 
        unsafe void GetMinmax(GL.Enums.VERSION_1_2 target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* values)
        {
            Delegates.glGetMinmax(target, reset, format, type, values);
        }
        
        public static 
        unsafe void GetMinmaxParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params)
        {
            Delegates.glGetMinmaxParameterfv(target, pname, @params);
        }
        
        public static 
        unsafe void GetMinmaxParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params)
        {
            Delegates.glGetMinmaxParameteriv(target, pname, @params);
        }
        
        public static 
        void ResetHistogram(GL.Enums.VERSION_1_2 target)
        {
            Delegates.glResetHistogram(target);
        }
        
        public static 
        void ResetMinmax(GL.Enums.VERSION_1_2 target)
        {
            Delegates.glResetMinmax(target);
        }
        
        public static 
        unsafe void TexImage3D(GL.Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            Delegates.glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
        }
        
        public static 
        unsafe void TexSubImage3D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            Delegates.glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }
        
        public static 
        void CopyTexSubImage3D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            Delegates.glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
        }
        
        public static 
        void ActiveTexture(GL.Enums.VERSION_1_3 texture)
        {
            Delegates.glActiveTexture(texture);
        }
        
        public static 
        void ClientActiveTexture(GL.Enums.VERSION_1_3 texture)
        {
            Delegates.glClientActiveTexture(texture);
        }
        
        public static 
        void MultiTexCoord1d(GL.Enums.VERSION_1_3 target, GLdouble s)
        {
            Delegates.glMultiTexCoord1d(target, s);
        }
        
        public static 
        unsafe void MultiTexCoord1dv(GL.Enums.VERSION_1_3 target, GLdouble* v)
        {
            Delegates.glMultiTexCoord1dv(target, v);
        }
        
        public static 
        void MultiTexCoord1f(GL.Enums.VERSION_1_3 target, GLfloat s)
        {
            Delegates.glMultiTexCoord1f(target, s);
        }
        
        public static 
        unsafe void MultiTexCoord1fv(GL.Enums.VERSION_1_3 target, GLfloat* v)
        {
            Delegates.glMultiTexCoord1fv(target, v);
        }
        
        public static 
        void MultiTexCoord1i(GL.Enums.VERSION_1_3 target, GLint s)
        {
            Delegates.glMultiTexCoord1i(target, s);
        }
        
        public static 
        unsafe void MultiTexCoord1iv(GL.Enums.VERSION_1_3 target, GLint* v)
        {
            Delegates.glMultiTexCoord1iv(target, v);
        }
        
        public static 
        void MultiTexCoord1s(GL.Enums.VERSION_1_3 target, GLshort s)
        {
            Delegates.glMultiTexCoord1s(target, s);
        }
        
        public static 
        unsafe void MultiTexCoord1sv(GL.Enums.VERSION_1_3 target, GLshort* v)
        {
            Delegates.glMultiTexCoord1sv(target, v);
        }
        
        public static 
        void MultiTexCoord2d(GL.Enums.VERSION_1_3 target, GLdouble s, GLdouble t)
        {
            Delegates.glMultiTexCoord2d(target, s, t);
        }
        
        public static 
        unsafe void MultiTexCoord2dv(GL.Enums.VERSION_1_3 target, GLdouble* v)
        {
            Delegates.glMultiTexCoord2dv(target, v);
        }
        
        public static 
        void MultiTexCoord2f(GL.Enums.VERSION_1_3 target, GLfloat s, GLfloat t)
        {
            Delegates.glMultiTexCoord2f(target, s, t);
        }
        
        public static 
        unsafe void MultiTexCoord2fv(GL.Enums.VERSION_1_3 target, GLfloat* v)
        {
            Delegates.glMultiTexCoord2fv(target, v);
        }
        
        public static 
        void MultiTexCoord2i(GL.Enums.VERSION_1_3 target, GLint s, GLint t)
        {
            Delegates.glMultiTexCoord2i(target, s, t);
        }
        
        public static 
        unsafe void MultiTexCoord2iv(GL.Enums.VERSION_1_3 target, GLint* v)
        {
            Delegates.glMultiTexCoord2iv(target, v);
        }
        
        public static 
        void MultiTexCoord2s(GL.Enums.VERSION_1_3 target, GLshort s, GLshort t)
        {
            Delegates.glMultiTexCoord2s(target, s, t);
        }
        
        public static 
        unsafe void MultiTexCoord2sv(GL.Enums.VERSION_1_3 target, GLshort* v)
        {
            Delegates.glMultiTexCoord2sv(target, v);
        }
        
        public static 
        void MultiTexCoord3d(GL.Enums.VERSION_1_3 target, GLdouble s, GLdouble t, GLdouble r)
        {
            Delegates.glMultiTexCoord3d(target, s, t, r);
        }
        
        public static 
        unsafe void MultiTexCoord3dv(GL.Enums.VERSION_1_3 target, GLdouble* v)
        {
            Delegates.glMultiTexCoord3dv(target, v);
        }
        
        public static 
        void MultiTexCoord3f(GL.Enums.VERSION_1_3 target, GLfloat s, GLfloat t, GLfloat r)
        {
            Delegates.glMultiTexCoord3f(target, s, t, r);
        }
        
        public static 
        unsafe void MultiTexCoord3fv(GL.Enums.VERSION_1_3 target, GLfloat* v)
        {
            Delegates.glMultiTexCoord3fv(target, v);
        }
        
        public static 
        void MultiTexCoord3i(GL.Enums.VERSION_1_3 target, GLint s, GLint t, GLint r)
        {
            Delegates.glMultiTexCoord3i(target, s, t, r);
        }
        
        public static 
        unsafe void MultiTexCoord3iv(GL.Enums.VERSION_1_3 target, GLint* v)
        {
            Delegates.glMultiTexCoord3iv(target, v);
        }
        
        public static 
        void MultiTexCoord3s(GL.Enums.VERSION_1_3 target, GLshort s, GLshort t, GLshort r)
        {
            Delegates.glMultiTexCoord3s(target, s, t, r);
        }
        
        public static 
        unsafe void MultiTexCoord3sv(GL.Enums.VERSION_1_3 target, GLshort* v)
        {
            Delegates.glMultiTexCoord3sv(target, v);
        }
        
        public static 
        void MultiTexCoord4d(GL.Enums.VERSION_1_3 target, GLdouble s, GLdouble t, GLdouble r, GLdouble q)
        {
            Delegates.glMultiTexCoord4d(target, s, t, r, q);
        }
        
        public static 
        unsafe void MultiTexCoord4dv(GL.Enums.VERSION_1_3 target, GLdouble* v)
        {
            Delegates.glMultiTexCoord4dv(target, v);
        }
        
        public static 
        void MultiTexCoord4f(GL.Enums.VERSION_1_3 target, GLfloat s, GLfloat t, GLfloat r, GLfloat q)
        {
            Delegates.glMultiTexCoord4f(target, s, t, r, q);
        }
        
        public static 
        unsafe void MultiTexCoord4fv(GL.Enums.VERSION_1_3 target, GLfloat* v)
        {
            Delegates.glMultiTexCoord4fv(target, v);
        }
        
        public static 
        void MultiTexCoord4i(GL.Enums.VERSION_1_3 target, GLint s, GLint t, GLint r, GLint q)
        {
            Delegates.glMultiTexCoord4i(target, s, t, r, q);
        }
        
        public static 
        unsafe void MultiTexCoord4iv(GL.Enums.VERSION_1_3 target, GLint* v)
        {
            Delegates.glMultiTexCoord4iv(target, v);
        }
        
        public static 
        void MultiTexCoord4s(GL.Enums.VERSION_1_3 target, GLshort s, GLshort t, GLshort r, GLshort q)
        {
            Delegates.glMultiTexCoord4s(target, s, t, r, q);
        }
        
        public static 
        unsafe void MultiTexCoord4sv(GL.Enums.VERSION_1_3 target, GLshort* v)
        {
            Delegates.glMultiTexCoord4sv(target, v);
        }
        
        public static 
        unsafe void LoadTransposeMatrixf(GLfloat* m)
        {
            Delegates.glLoadTransposeMatrixf(m);
        }
        
        public static 
        unsafe void LoadTransposeMatrixd(GLdouble* m)
        {
            Delegates.glLoadTransposeMatrixd(m);
        }
        
        public static 
        unsafe void MultTransposeMatrixf(GLfloat* m)
        {
            Delegates.glMultTransposeMatrixf(m);
        }
        
        public static 
        unsafe void MultTransposeMatrixd(GLdouble* m)
        {
            Delegates.glMultTransposeMatrixd(m);
        }
        
        public static 
        unsafe void CompressedTexImage3D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data)
        {
            Delegates.glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
        }
        
        public static 
        unsafe void CompressedTexImage2D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data)
        {
            Delegates.glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
        }
        
        public static 
        unsafe void CompressedTexImage1D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data)
        {
            Delegates.glCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
        }
        
        public static 
        unsafe void CompressedTexSubImage3D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GL.Enums.PixelFormat format, GLsizei imageSize, void* data)
        {
            Delegates.glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }
        
        public static 
        unsafe void CompressedTexSubImage2D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GLsizei imageSize, void* data)
        {
            Delegates.glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }
        
        public static 
        unsafe void CompressedTexSubImage1D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, GL.Enums.PixelFormat format, GLsizei imageSize, void* data)
        {
            Delegates.glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
        }
        
        public static 
        unsafe void GetCompressedTexImage(GL.Enums.TextureTarget target, GLint level, void* img)
        {
            Delegates.glGetCompressedTexImage(target, level, img);
        }
        
        public static 
        void BlendFuncSeparate(GL.Enums.VERSION_1_4 sfactorRGB, GL.Enums.VERSION_1_4 dfactorRGB, GL.Enums.VERSION_1_4 sfactorAlpha, GL.Enums.VERSION_1_4 dfactorAlpha)
        {
            Delegates.glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        }
        
        public static 
        void FogCoordf(GLfloat coord)
        {
            Delegates.glFogCoordf(coord);
        }
        
        public static 
        unsafe void FogCoordfv(GLfloat* coord)
        {
            Delegates.glFogCoordfv(coord);
        }
        
        public static 
        void FogCoordd(GLdouble coord)
        {
            Delegates.glFogCoordd(coord);
        }
        
        public static 
        unsafe void FogCoorddv(GLdouble* coord)
        {
            Delegates.glFogCoorddv(coord);
        }
        
        public static 
        unsafe void FogCoordPointer(GL.Enums.VERSION_1_4 type, GLsizei stride, void* pointer)
        {
            Delegates.glFogCoordPointer(type, stride, pointer);
        }
        
        public static 
        unsafe void MultiDrawArrays(GL.Enums.BeginMode mode, GLint* first, GLsizei* count, GLsizei primcount)
        {
            Delegates.glMultiDrawArrays(mode, first, count, primcount);
        }
        
        public static 
        unsafe void MultiDrawElements(GL.Enums.BeginMode mode, GLsizei* count, GL.Enums.VERSION_1_4 type, void* indices, GLsizei primcount)
        {
            Delegates.glMultiDrawElements(mode, count, type, indices, primcount);
        }
        
        public static 
        void PointParameterf(GL.Enums.VERSION_1_4 pname, GLfloat param)
        {
            Delegates.glPointParameterf(pname, param);
        }
        
        public static 
        unsafe void PointParameterfv(GL.Enums.VERSION_1_4 pname, GLfloat* @params)
        {
            Delegates.glPointParameterfv(pname, @params);
        }
        
        public static 
        void PointParameteri(GL.Enums.VERSION_1_4 pname, GLint param)
        {
            Delegates.glPointParameteri(pname, param);
        }
        
        public static 
        unsafe void PointParameteriv(GL.Enums.VERSION_1_4 pname, GLint* @params)
        {
            Delegates.glPointParameteriv(pname, @params);
        }
        
        public static 
        void SecondaryColor3b(GLbyte red, GLbyte green, GLbyte blue)
        {
            Delegates.glSecondaryColor3b(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3bv(GLbyte* v)
        {
            Delegates.glSecondaryColor3bv(v);
        }
        
        public static 
        void SecondaryColor3d(GLdouble red, GLdouble green, GLdouble blue)
        {
            Delegates.glSecondaryColor3d(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3dv(GLdouble* v)
        {
            Delegates.glSecondaryColor3dv(v);
        }
        
        public static 
        void SecondaryColor3f(GLfloat red, GLfloat green, GLfloat blue)
        {
            Delegates.glSecondaryColor3f(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3fv(GLfloat* v)
        {
            Delegates.glSecondaryColor3fv(v);
        }
        
        public static 
        void SecondaryColor3i(GLint red, GLint green, GLint blue)
        {
            Delegates.glSecondaryColor3i(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3iv(GLint* v)
        {
            Delegates.glSecondaryColor3iv(v);
        }
        
        public static 
        void SecondaryColor3s(GLshort red, GLshort green, GLshort blue)
        {
            Delegates.glSecondaryColor3s(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3sv(GLshort* v)
        {
            Delegates.glSecondaryColor3sv(v);
        }
        
        public static 
        void SecondaryColor3ub(GLubyte red, GLubyte green, GLubyte blue)
        {
            Delegates.glSecondaryColor3ub(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3ubv(GLubyte* v)
        {
            Delegates.glSecondaryColor3ubv(v);
        }
        
        public static 
        void SecondaryColor3ui(GLuint red, GLuint green, GLuint blue)
        {
            Delegates.glSecondaryColor3ui(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3uiv(GLuint* v)
        {
            Delegates.glSecondaryColor3uiv(v);
        }
        
        public static 
        void SecondaryColor3us(GLushort red, GLushort green, GLushort blue)
        {
            Delegates.glSecondaryColor3us(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3usv(GLushort* v)
        {
            Delegates.glSecondaryColor3usv(v);
        }
        
        public static 
        unsafe void SecondaryColorPointer(GLint size, GL.Enums.ColorPointerType type, GLsizei stride, void* pointer)
        {
            Delegates.glSecondaryColorPointer(size, type, stride, pointer);
        }
        
        public static 
        void WindowPos2d(GLdouble x, GLdouble y)
        {
            Delegates.glWindowPos2d(x, y);
        }
        
        public static 
        unsafe void WindowPos2dv(GLdouble* v)
        {
            Delegates.glWindowPos2dv(v);
        }
        
        public static 
        void WindowPos2f(GLfloat x, GLfloat y)
        {
            Delegates.glWindowPos2f(x, y);
        }
        
        public static 
        unsafe void WindowPos2fv(GLfloat* v)
        {
            Delegates.glWindowPos2fv(v);
        }
        
        public static 
        void WindowPos2i(GLint x, GLint y)
        {
            Delegates.glWindowPos2i(x, y);
        }
        
        public static 
        unsafe void WindowPos2iv(GLint* v)
        {
            Delegates.glWindowPos2iv(v);
        }
        
        public static 
        void WindowPos2s(GLshort x, GLshort y)
        {
            Delegates.glWindowPos2s(x, y);
        }
        
        public static 
        unsafe void WindowPos2sv(GLshort* v)
        {
            Delegates.glWindowPos2sv(v);
        }
        
        public static 
        void WindowPos3d(GLdouble x, GLdouble y, GLdouble z)
        {
            Delegates.glWindowPos3d(x, y, z);
        }
        
        public static 
        unsafe void WindowPos3dv(GLdouble* v)
        {
            Delegates.glWindowPos3dv(v);
        }
        
        public static 
        void WindowPos3f(GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glWindowPos3f(x, y, z);
        }
        
        public static 
        unsafe void WindowPos3fv(GLfloat* v)
        {
            Delegates.glWindowPos3fv(v);
        }
        
        public static 
        void WindowPos3i(GLint x, GLint y, GLint z)
        {
            Delegates.glWindowPos3i(x, y, z);
        }
        
        public static 
        unsafe void WindowPos3iv(GLint* v)
        {
            Delegates.glWindowPos3iv(v);
        }
        
        public static 
        void WindowPos3s(GLshort x, GLshort y, GLshort z)
        {
            Delegates.glWindowPos3s(x, y, z);
        }
        
        public static 
        unsafe void WindowPos3sv(GLshort* v)
        {
            Delegates.glWindowPos3sv(v);
        }
        
        public static 
        unsafe void GenQueries(GLsizei n, GLuint* ids)
        {
            Delegates.glGenQueries(n, ids);
        }
        
        public static 
        unsafe void DeleteQueries(GLsizei n, GLuint* ids)
        {
            Delegates.glDeleteQueries(n, ids);
        }
        
        public static 
        GLboolean IsQuery(GLuint id)
        {
            return Delegates.glIsQuery(id);
        }
        
        public static 
        void BeginQuery(GL.Enums.GLenum target, GLuint id)
        {
            Delegates.glBeginQuery(target, id);
        }
        
        public static 
        void EndQuery(GL.Enums.GLenum target)
        {
            Delegates.glEndQuery(target);
        }
        
        public static 
        unsafe void GetQueryiv(GL.Enums.GLenum target, GL.Enums.GLenum pname, GLint* @params)
        {
            Delegates.glGetQueryiv(target, pname, @params);
        }
        
        public static 
        unsafe void GetQueryObjectiv(GLuint id, GL.Enums.GLenum pname, GLint* @params)
        {
            Delegates.glGetQueryObjectiv(id, pname, @params);
        }
        
        public static 
        unsafe void GetQueryObjectuiv(GLuint id, GL.Enums.GLenum pname, GLuint* @params)
        {
            Delegates.glGetQueryObjectuiv(id, pname, @params);
        }
        
        public static 
        void BindBuffer(GL.Enums.VERSION_1_5 target, GLuint buffer)
        {
            Delegates.glBindBuffer(target, buffer);
        }
        
        public static 
        unsafe void DeleteBuffers(GLsizei n, GLuint* buffers)
        {
            Delegates.glDeleteBuffers(n, buffers);
        }
        
        public static 
        unsafe void GenBuffers(GLsizei n, GLuint* buffers)
        {
            Delegates.glGenBuffers(n, buffers);
        }
        
        public static 
        GLboolean IsBuffer(GLuint buffer)
        {
            return Delegates.glIsBuffer(buffer);
        }
        
        public static 
        unsafe void BufferData(GL.Enums.VERSION_1_5 target, GLsizeiptr size, void* data, GL.Enums.VERSION_1_5 usage)
        {
            Delegates.glBufferData(target, size, data, usage);
        }
        
        public static 
        unsafe void BufferSubData(GL.Enums.VERSION_1_5 target, GLintptr offset, GLsizeiptr size, void* data)
        {
            Delegates.glBufferSubData(target, offset, size, data);
        }
        
        public static 
        unsafe void GetBufferSubData(GL.Enums.VERSION_1_5 target, GLintptr offset, GLsizeiptr size, void* data)
        {
            Delegates.glGetBufferSubData(target, offset, size, data);
        }
        
        public static 
        void MapBuffer(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 access)
        {
            Delegates.glMapBuffer(target, access);
        }
        
        public static 
        GLboolean UnmapBuffer(GL.Enums.VERSION_1_5 target)
        {
            return Delegates.glUnmapBuffer(target);
        }
        
        public static 
        unsafe void GetBufferParameteriv(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 pname, GLint* @params)
        {
            Delegates.glGetBufferParameteriv(target, pname, @params);
        }
        
        public static 
        unsafe void GetBufferPointerv(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 pname, void* @params)
        {
            Delegates.glGetBufferPointerv(target, pname, @params);
        }
        
        public static 
        void BlendEquationSeparate(GL.Enums.BlendEquationModeEXT modeRGB, GL.Enums.BlendEquationModeEXT modeAlpha)
        {
            Delegates.glBlendEquationSeparate(modeRGB, modeAlpha);
        }
        
        public static 
        unsafe void DrawBuffers(GLsizei n, GL.Enums.VERSION_2_0* bufs)
        {
            Delegates.glDrawBuffers(n, bufs);
        }
        
        public static 
        void StencilOpSeparate(GL.Enums.VERSION_2_0 face, GL.Enums.StencilOp sfail, GL.Enums.StencilOp dpfail, GL.Enums.StencilOp dppass)
        {
            Delegates.glStencilOpSeparate(face, sfail, dpfail, dppass);
        }
        
        public static 
        void StencilFuncSeparate(GL.Enums.StencilFunction frontfunc, GL.Enums.StencilFunction backfunc, GLint @ref, GLuint mask)
        {
            Delegates.glStencilFuncSeparate(frontfunc, backfunc, @ref, mask);
        }
        
        public static 
        void StencilMaskSeparate(GL.Enums.VERSION_2_0 face, GLuint mask)
        {
            Delegates.glStencilMaskSeparate(face, mask);
        }
        
        public static 
        void AttachShader(GLuint program, GLuint shader)
        {
            Delegates.glAttachShader(program, shader);
        }
        
        public static 
        void CompileShader(GLuint shader)
        {
            Delegates.glCompileShader(shader);
        }
        
        public static 
        GLuint CreateProgram()
        {
            return Delegates.glCreateProgram();
        }
        
        public static 
        GLuint CreateShader(GL.Enums.GLenum type)
        {
            return Delegates.glCreateShader(type);
        }
        
        public static 
        void DeleteProgram(GLuint program)
        {
            Delegates.glDeleteProgram(program);
        }
        
        public static 
        void DeleteShader(GLuint shader)
        {
            Delegates.glDeleteShader(shader);
        }
        
        public static 
        void DetachShader(GLuint program, GLuint shader)
        {
            Delegates.glDetachShader(program, shader);
        }
        
        public static 
        void DisableVertexAttribArray(GLuint index)
        {
            Delegates.glDisableVertexAttribArray(index);
        }
        
        public static 
        void EnableVertexAttribArray(GLuint index)
        {
            Delegates.glEnableVertexAttribArray(index);
        }
        
        public static 
        unsafe void GetActiveAttrib(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GL.Enums.GLenum* type, System.Text.StringBuilder name)
        {
            Delegates.glGetActiveAttrib(program, index, bufSize, length, size, type, name);
        }
        
        public static 
        unsafe void GetActiveUniform(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GL.Enums.GLenum* type, System.Text.StringBuilder name)
        {
            Delegates.glGetActiveUniform(program, index, bufSize, length, size, type, name);
        }
        
        public static 
        unsafe void GetAttachedShaders(GLuint program, GLsizei maxCount, GLsizei* count, GLuint* obj)
        {
            Delegates.glGetAttachedShaders(program, maxCount, count, obj);
        }
        
        public static 
        unsafe void GetProgramiv(GLuint program, GL.Enums.GLenum pname, GLint* @params)
        {
            Delegates.glGetProgramiv(program, pname, @params);
        }
        
        public static 
        unsafe void GetProgramInfoLog(GLuint program, GLsizei bufSize, GLsizei* length, System.Text.StringBuilder infoLog)
        {
            Delegates.glGetProgramInfoLog(program, bufSize, length, infoLog);
        }
        
        public static 
        unsafe void GetShaderiv(GLuint shader, GL.Enums.GLenum pname, GLint* @params)
        {
            Delegates.glGetShaderiv(shader, pname, @params);
        }
        
        public static 
        unsafe void GetShaderInfoLog(GLuint shader, GLsizei bufSize, GLsizei* length, System.Text.StringBuilder infoLog)
        {
            Delegates.glGetShaderInfoLog(shader, bufSize, length, infoLog);
        }
        
        public static 
        unsafe void GetShaderSource(GLuint shader, GLsizei bufSize, GLsizei* length, System.Text.StringBuilder source)
        {
            Delegates.glGetShaderSource(shader, bufSize, length, source);
        }
        
        public static 
        unsafe void GetUniformfv(GLuint program, GLint location, GLfloat* @params)
        {
            Delegates.glGetUniformfv(program, location, @params);
        }
        
        public static 
        unsafe void GetUniformiv(GLuint program, GLint location, GLint* @params)
        {
            Delegates.glGetUniformiv(program, location, @params);
        }
        
        public static 
        unsafe void GetVertexAttribdv(GLuint index, GL.Enums.VERSION_2_0 pname, GLdouble* @params)
        {
            Delegates.glGetVertexAttribdv(index, pname, @params);
        }
        
        public static 
        unsafe void GetVertexAttribfv(GLuint index, GL.Enums.VERSION_2_0 pname, GLfloat* @params)
        {
            Delegates.glGetVertexAttribfv(index, pname, @params);
        }
        
        public static 
        unsafe void GetVertexAttribiv(GLuint index, GL.Enums.VERSION_2_0 pname, GLint* @params)
        {
            Delegates.glGetVertexAttribiv(index, pname, @params);
        }
        
        public static 
        unsafe void GetVertexAttribPointerv(GLuint index, GL.Enums.VERSION_2_0 pname, void* pointer)
        {
            Delegates.glGetVertexAttribPointerv(index, pname, pointer);
        }
        
        public static 
        GLboolean IsProgram(GLuint program)
        {
            return Delegates.glIsProgram(program);
        }
        
        public static 
        GLboolean IsShader(GLuint shader)
        {
            return Delegates.glIsShader(shader);
        }
        
        public static 
        void LinkProgram(GLuint program)
        {
            Delegates.glLinkProgram(program);
        }
        
        public static 
        unsafe void ShaderSource(GLuint shader, GLsizei count, System.String @string, GLint* length)
        {
            Delegates.glShaderSource(shader, count, @string, length);
        }
        
        public static 
        void UseProgram(GLuint program)
        {
            Delegates.glUseProgram(program);
        }
        
        public static 
        void Uniform1f(GLint location, GLfloat v0)
        {
            Delegates.glUniform1f(location, v0);
        }
        
        public static 
        void Uniform2f(GLint location, GLfloat v0, GLfloat v1)
        {
            Delegates.glUniform2f(location, v0, v1);
        }
        
        public static 
        void Uniform3f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
        {
            Delegates.glUniform3f(location, v0, v1, v2);
        }
        
        public static 
        void Uniform4f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
        {
            Delegates.glUniform4f(location, v0, v1, v2, v3);
        }
        
        public static 
        void Uniform1i(GLint location, GLint v0)
        {
            Delegates.glUniform1i(location, v0);
        }
        
        public static 
        void Uniform2i(GLint location, GLint v0, GLint v1)
        {
            Delegates.glUniform2i(location, v0, v1);
        }
        
        public static 
        void Uniform3i(GLint location, GLint v0, GLint v1, GLint v2)
        {
            Delegates.glUniform3i(location, v0, v1, v2);
        }
        
        public static 
        void Uniform4i(GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
        {
            Delegates.glUniform4i(location, v0, v1, v2, v3);
        }
        
        public static 
        unsafe void Uniform1fv(GLint location, GLsizei count, GLfloat* value)
        {
            Delegates.glUniform1fv(location, count, value);
        }
        
        public static 
        unsafe void Uniform2fv(GLint location, GLsizei count, GLfloat* value)
        {
            Delegates.glUniform2fv(location, count, value);
        }
        
        public static 
        unsafe void Uniform3fv(GLint location, GLsizei count, GLfloat* value)
        {
            Delegates.glUniform3fv(location, count, value);
        }
        
        public static 
        unsafe void Uniform4fv(GLint location, GLsizei count, GLfloat* value)
        {
            Delegates.glUniform4fv(location, count, value);
        }
        
        public static 
        unsafe void Uniform1iv(GLint location, GLsizei count, GLint* value)
        {
            Delegates.glUniform1iv(location, count, value);
        }
        
        public static 
        unsafe void Uniform2iv(GLint location, GLsizei count, GLint* value)
        {
            Delegates.glUniform2iv(location, count, value);
        }
        
        public static 
        unsafe void Uniform3iv(GLint location, GLsizei count, GLint* value)
        {
            Delegates.glUniform3iv(location, count, value);
        }
        
        public static 
        unsafe void Uniform4iv(GLint location, GLsizei count, GLint* value)
        {
            Delegates.glUniform4iv(location, count, value);
        }
        
        public static 
        unsafe void UniformMatrix2fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            Delegates.glUniformMatrix2fv(location, count, transpose, value);
        }
        
        public static 
        unsafe void UniformMatrix3fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            Delegates.glUniformMatrix3fv(location, count, transpose, value);
        }
        
        public static 
        unsafe void UniformMatrix4fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            Delegates.glUniformMatrix4fv(location, count, transpose, value);
        }
        
        public static 
        void ValidateProgram(GLuint program)
        {
            Delegates.glValidateProgram(program);
        }
        
        public static 
        void VertexAttrib1d(GLuint index, GLdouble x)
        {
            Delegates.glVertexAttrib1d(index, x);
        }
        
        public static 
        unsafe void VertexAttrib1dv(GLuint index, GLdouble* v)
        {
            Delegates.glVertexAttrib1dv(index, v);
        }
        
        public static 
        void VertexAttrib1f(GLuint index, GLfloat x)
        {
            Delegates.glVertexAttrib1f(index, x);
        }
        
        public static 
        unsafe void VertexAttrib1fv(GLuint index, GLfloat* v)
        {
            Delegates.glVertexAttrib1fv(index, v);
        }
        
        public static 
        void VertexAttrib1s(GLuint index, GLshort x)
        {
            Delegates.glVertexAttrib1s(index, x);
        }
        
        public static 
        unsafe void VertexAttrib1sv(GLuint index, GLshort* v)
        {
            Delegates.glVertexAttrib1sv(index, v);
        }
        
        public static 
        void VertexAttrib2d(GLuint index, GLdouble x, GLdouble y)
        {
            Delegates.glVertexAttrib2d(index, x, y);
        }
        
        public static 
        unsafe void VertexAttrib2dv(GLuint index, GLdouble* v)
        {
            Delegates.glVertexAttrib2dv(index, v);
        }
        
        public static 
        void VertexAttrib2f(GLuint index, GLfloat x, GLfloat y)
        {
            Delegates.glVertexAttrib2f(index, x, y);
        }
        
        public static 
        unsafe void VertexAttrib2fv(GLuint index, GLfloat* v)
        {
            Delegates.glVertexAttrib2fv(index, v);
        }
        
        public static 
        void VertexAttrib2s(GLuint index, GLshort x, GLshort y)
        {
            Delegates.glVertexAttrib2s(index, x, y);
        }
        
        public static 
        unsafe void VertexAttrib2sv(GLuint index, GLshort* v)
        {
            Delegates.glVertexAttrib2sv(index, v);
        }
        
        public static 
        void VertexAttrib3d(GLuint index, GLdouble x, GLdouble y, GLdouble z)
        {
            Delegates.glVertexAttrib3d(index, x, y, z);
        }
        
        public static 
        unsafe void VertexAttrib3dv(GLuint index, GLdouble* v)
        {
            Delegates.glVertexAttrib3dv(index, v);
        }
        
        public static 
        void VertexAttrib3f(GLuint index, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glVertexAttrib3f(index, x, y, z);
        }
        
        public static 
        unsafe void VertexAttrib3fv(GLuint index, GLfloat* v)
        {
            Delegates.glVertexAttrib3fv(index, v);
        }
        
        public static 
        void VertexAttrib3s(GLuint index, GLshort x, GLshort y, GLshort z)
        {
            Delegates.glVertexAttrib3s(index, x, y, z);
        }
        
        public static 
        unsafe void VertexAttrib3sv(GLuint index, GLshort* v)
        {
            Delegates.glVertexAttrib3sv(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4Nbv(GLuint index, GLbyte* v)
        {
            Delegates.glVertexAttrib4Nbv(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4Niv(GLuint index, GLint* v)
        {
            Delegates.glVertexAttrib4Niv(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4Nsv(GLuint index, GLshort* v)
        {
            Delegates.glVertexAttrib4Nsv(index, v);
        }
        
        public static 
        void VertexAttrib4Nub(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)
        {
            Delegates.glVertexAttrib4Nub(index, x, y, z, w);
        }
        
        public static 
        unsafe void VertexAttrib4Nubv(GLuint index, GLubyte* v)
        {
            Delegates.glVertexAttrib4Nubv(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4Nuiv(GLuint index, GLuint* v)
        {
            Delegates.glVertexAttrib4Nuiv(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4Nusv(GLuint index, GLushort* v)
        {
            Delegates.glVertexAttrib4Nusv(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4bv(GLuint index, GLbyte* v)
        {
            Delegates.glVertexAttrib4bv(index, v);
        }
        
        public static 
        void VertexAttrib4d(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            Delegates.glVertexAttrib4d(index, x, y, z, w);
        }
        
        public static 
        unsafe void VertexAttrib4dv(GLuint index, GLdouble* v)
        {
            Delegates.glVertexAttrib4dv(index, v);
        }
        
        public static 
        void VertexAttrib4f(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            Delegates.glVertexAttrib4f(index, x, y, z, w);
        }
        
        public static 
        unsafe void VertexAttrib4fv(GLuint index, GLfloat* v)
        {
            Delegates.glVertexAttrib4fv(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4iv(GLuint index, GLint* v)
        {
            Delegates.glVertexAttrib4iv(index, v);
        }
        
        public static 
        void VertexAttrib4s(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)
        {
            Delegates.glVertexAttrib4s(index, x, y, z, w);
        }
        
        public static 
        unsafe void VertexAttrib4sv(GLuint index, GLshort* v)
        {
            Delegates.glVertexAttrib4sv(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4ubv(GLuint index, GLubyte* v)
        {
            Delegates.glVertexAttrib4ubv(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4uiv(GLuint index, GLuint* v)
        {
            Delegates.glVertexAttrib4uiv(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4usv(GLuint index, GLushort* v)
        {
            Delegates.glVertexAttrib4usv(index, v);
        }
        
        public static 
        unsafe void VertexAttribPointer(GLuint index, GLint size, GL.Enums.VERSION_2_0 type, GL.Enums.Boolean normalized, GLsizei stride, void* pointer)
        {
            Delegates.glVertexAttribPointer(index, size, type, normalized, stride, pointer);
        }
        
        public static 
        unsafe void UniformMatrix2x3fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            Delegates.glUniformMatrix2x3fv(location, count, transpose, value);
        }
        
        public static 
        unsafe void UniformMatrix3x2fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            Delegates.glUniformMatrix3x2fv(location, count, transpose, value);
        }
        
        public static 
        unsafe void UniformMatrix2x4fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            Delegates.glUniformMatrix2x4fv(location, count, transpose, value);
        }
        
        public static 
        unsafe void UniformMatrix4x2fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            Delegates.glUniformMatrix4x2fv(location, count, transpose, value);
        }
        
        public static 
        unsafe void UniformMatrix3x4fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            Delegates.glUniformMatrix3x4fv(location, count, transpose, value);
        }
        
        public static 
        unsafe void UniformMatrix4x3fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            Delegates.glUniformMatrix4x3fv(location, count, transpose, value);
        }
        
        public static 
        void ActiveTextureARB(GL.Enums.ARB_multitexture texture)
        {
            Delegates.glActiveTextureARB(texture);
        }
        
        public static 
        void ClientActiveTextureARB(GL.Enums.ARB_multitexture texture)
        {
            Delegates.glClientActiveTextureARB(texture);
        }
        
        public static 
        void MultiTexCoord1dARB(GL.Enums.ARB_multitexture target, GLdouble s)
        {
            Delegates.glMultiTexCoord1dARB(target, s);
        }
        
        public static 
        unsafe void MultiTexCoord1dvARB(GL.Enums.ARB_multitexture target, GLdouble* v)
        {
            Delegates.glMultiTexCoord1dvARB(target, v);
        }
        
        public static 
        void MultiTexCoord1fARB(GL.Enums.ARB_multitexture target, GLfloat s)
        {
            Delegates.glMultiTexCoord1fARB(target, s);
        }
        
        public static 
        unsafe void MultiTexCoord1fvARB(GL.Enums.ARB_multitexture target, GLfloat* v)
        {
            Delegates.glMultiTexCoord1fvARB(target, v);
        }
        
        public static 
        void MultiTexCoord1iARB(GL.Enums.ARB_multitexture target, GLint s)
        {
            Delegates.glMultiTexCoord1iARB(target, s);
        }
        
        public static 
        unsafe void MultiTexCoord1ivARB(GL.Enums.ARB_multitexture target, GLint* v)
        {
            Delegates.glMultiTexCoord1ivARB(target, v);
        }
        
        public static 
        void MultiTexCoord1sARB(GL.Enums.ARB_multitexture target, GLshort s)
        {
            Delegates.glMultiTexCoord1sARB(target, s);
        }
        
        public static 
        unsafe void MultiTexCoord1svARB(GL.Enums.ARB_multitexture target, GLshort* v)
        {
            Delegates.glMultiTexCoord1svARB(target, v);
        }
        
        public static 
        void MultiTexCoord2dARB(GL.Enums.ARB_multitexture target, GLdouble s, GLdouble t)
        {
            Delegates.glMultiTexCoord2dARB(target, s, t);
        }
        
        public static 
        unsafe void MultiTexCoord2dvARB(GL.Enums.ARB_multitexture target, GLdouble* v)
        {
            Delegates.glMultiTexCoord2dvARB(target, v);
        }
        
        public static 
        void MultiTexCoord2fARB(GL.Enums.ARB_multitexture target, GLfloat s, GLfloat t)
        {
            Delegates.glMultiTexCoord2fARB(target, s, t);
        }
        
        public static 
        unsafe void MultiTexCoord2fvARB(GL.Enums.ARB_multitexture target, GLfloat* v)
        {
            Delegates.glMultiTexCoord2fvARB(target, v);
        }
        
        public static 
        void MultiTexCoord2iARB(GL.Enums.ARB_multitexture target, GLint s, GLint t)
        {
            Delegates.glMultiTexCoord2iARB(target, s, t);
        }
        
        public static 
        unsafe void MultiTexCoord2ivARB(GL.Enums.ARB_multitexture target, GLint* v)
        {
            Delegates.glMultiTexCoord2ivARB(target, v);
        }
        
        public static 
        void MultiTexCoord2sARB(GL.Enums.ARB_multitexture target, GLshort s, GLshort t)
        {
            Delegates.glMultiTexCoord2sARB(target, s, t);
        }
        
        public static 
        unsafe void MultiTexCoord2svARB(GL.Enums.ARB_multitexture target, GLshort* v)
        {
            Delegates.glMultiTexCoord2svARB(target, v);
        }
        
        public static 
        void MultiTexCoord3dARB(GL.Enums.ARB_multitexture target, GLdouble s, GLdouble t, GLdouble r)
        {
            Delegates.glMultiTexCoord3dARB(target, s, t, r);
        }
        
        public static 
        unsafe void MultiTexCoord3dvARB(GL.Enums.ARB_multitexture target, GLdouble* v)
        {
            Delegates.glMultiTexCoord3dvARB(target, v);
        }
        
        public static 
        void MultiTexCoord3fARB(GL.Enums.ARB_multitexture target, GLfloat s, GLfloat t, GLfloat r)
        {
            Delegates.glMultiTexCoord3fARB(target, s, t, r);
        }
        
        public static 
        unsafe void MultiTexCoord3fvARB(GL.Enums.ARB_multitexture target, GLfloat* v)
        {
            Delegates.glMultiTexCoord3fvARB(target, v);
        }
        
        public static 
        void MultiTexCoord3iARB(GL.Enums.ARB_multitexture target, GLint s, GLint t, GLint r)
        {
            Delegates.glMultiTexCoord3iARB(target, s, t, r);
        }
        
        public static 
        unsafe void MultiTexCoord3ivARB(GL.Enums.ARB_multitexture target, GLint* v)
        {
            Delegates.glMultiTexCoord3ivARB(target, v);
        }
        
        public static 
        void MultiTexCoord3sARB(GL.Enums.ARB_multitexture target, GLshort s, GLshort t, GLshort r)
        {
            Delegates.glMultiTexCoord3sARB(target, s, t, r);
        }
        
        public static 
        unsafe void MultiTexCoord3svARB(GL.Enums.ARB_multitexture target, GLshort* v)
        {
            Delegates.glMultiTexCoord3svARB(target, v);
        }
        
        public static 
        void MultiTexCoord4dARB(GL.Enums.ARB_multitexture target, GLdouble s, GLdouble t, GLdouble r, GLdouble q)
        {
            Delegates.glMultiTexCoord4dARB(target, s, t, r, q);
        }
        
        public static 
        unsafe void MultiTexCoord4dvARB(GL.Enums.ARB_multitexture target, GLdouble* v)
        {
            Delegates.glMultiTexCoord4dvARB(target, v);
        }
        
        public static 
        void MultiTexCoord4fARB(GL.Enums.ARB_multitexture target, GLfloat s, GLfloat t, GLfloat r, GLfloat q)
        {
            Delegates.glMultiTexCoord4fARB(target, s, t, r, q);
        }
        
        public static 
        unsafe void MultiTexCoord4fvARB(GL.Enums.ARB_multitexture target, GLfloat* v)
        {
            Delegates.glMultiTexCoord4fvARB(target, v);
        }
        
        public static 
        void MultiTexCoord4iARB(GL.Enums.ARB_multitexture target, GLint s, GLint t, GLint r, GLint q)
        {
            Delegates.glMultiTexCoord4iARB(target, s, t, r, q);
        }
        
        public static 
        unsafe void MultiTexCoord4ivARB(GL.Enums.ARB_multitexture target, GLint* v)
        {
            Delegates.glMultiTexCoord4ivARB(target, v);
        }
        
        public static 
        void MultiTexCoord4sARB(GL.Enums.ARB_multitexture target, GLshort s, GLshort t, GLshort r, GLshort q)
        {
            Delegates.glMultiTexCoord4sARB(target, s, t, r, q);
        }
        
        public static 
        unsafe void MultiTexCoord4svARB(GL.Enums.ARB_multitexture target, GLshort* v)
        {
            Delegates.glMultiTexCoord4svARB(target, v);
        }
        
        public static 
        unsafe void LoadTransposeMatrixfARB(GLfloat* m)
        {
            Delegates.glLoadTransposeMatrixfARB(m);
        }
        
        public static 
        unsafe void LoadTransposeMatrixdARB(GLdouble* m)
        {
            Delegates.glLoadTransposeMatrixdARB(m);
        }
        
        public static 
        unsafe void MultTransposeMatrixfARB(GLfloat* m)
        {
            Delegates.glMultTransposeMatrixfARB(m);
        }
        
        public static 
        unsafe void MultTransposeMatrixdARB(GLdouble* m)
        {
            Delegates.glMultTransposeMatrixdARB(m);
        }
        
        public static 
        unsafe void CompressedTexImage3DARB(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data)
        {
            Delegates.glCompressedTexImage3DARB(target, level, internalformat, width, height, depth, border, imageSize, data);
        }
        
        public static 
        unsafe void CompressedTexImage2DARB(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data)
        {
            Delegates.glCompressedTexImage2DARB(target, level, internalformat, width, height, border, imageSize, data);
        }
        
        public static 
        unsafe void CompressedTexImage1DARB(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data)
        {
            Delegates.glCompressedTexImage1DARB(target, level, internalformat, width, border, imageSize, data);
        }
        
        public static 
        unsafe void CompressedTexSubImage3DARB(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GL.Enums.PixelFormat format, GLsizei imageSize, void* data)
        {
            Delegates.glCompressedTexSubImage3DARB(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }
        
        public static 
        unsafe void CompressedTexSubImage2DARB(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GLsizei imageSize, void* data)
        {
            Delegates.glCompressedTexSubImage2DARB(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }
        
        public static 
        unsafe void CompressedTexSubImage1DARB(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, GL.Enums.PixelFormat format, GLsizei imageSize, void* data)
        {
            Delegates.glCompressedTexSubImage1DARB(target, level, xoffset, width, format, imageSize, data);
        }
        
        public static 
        unsafe void GetCompressedTexImageARB(GL.Enums.TextureTarget target, GLint level, void* img)
        {
            Delegates.glGetCompressedTexImageARB(target, level, img);
        }
        
        public static 
        void PointParameterfARB(GL.Enums.ARB_point_parameters pname, GLfloat param)
        {
            Delegates.glPointParameterfARB(pname, param);
        }
        
        public static 
        unsafe void PointParameterfvARB(GL.Enums.ARB_point_parameters pname, GLfloat* @params)
        {
            Delegates.glPointParameterfvARB(pname, @params);
        }
        
        public static 
        unsafe void WeightbvARB(GLint size, GLbyte* weights)
        {
            Delegates.glWeightbvARB(size, weights);
        }
        
        public static 
        unsafe void WeightsvARB(GLint size, GLshort* weights)
        {
            Delegates.glWeightsvARB(size, weights);
        }
        
        public static 
        unsafe void WeightivARB(GLint size, GLint* weights)
        {
            Delegates.glWeightivARB(size, weights);
        }
        
        public static 
        unsafe void WeightfvARB(GLint size, GLfloat* weights)
        {
            Delegates.glWeightfvARB(size, weights);
        }
        
        public static 
        unsafe void WeightdvARB(GLint size, GLdouble* weights)
        {
            Delegates.glWeightdvARB(size, weights);
        }
        
        public static 
        unsafe void WeightubvARB(GLint size, GLubyte* weights)
        {
            Delegates.glWeightubvARB(size, weights);
        }
        
        public static 
        unsafe void WeightusvARB(GLint size, GLushort* weights)
        {
            Delegates.glWeightusvARB(size, weights);
        }
        
        public static 
        unsafe void WeightuivARB(GLint size, GLuint* weights)
        {
            Delegates.glWeightuivARB(size, weights);
        }
        
        public static 
        unsafe void WeightPointerARB(GLint size, GL.Enums.ARB_vertex_blend type, GLsizei stride, void* pointer)
        {
            Delegates.glWeightPointerARB(size, type, stride, pointer);
        }
        
        public static 
        void VertexBlendARB(GLint count)
        {
            Delegates.glVertexBlendARB(count);
        }
        
        public static 
        void CurrentPaletteMatrixARB(GLint index)
        {
            Delegates.glCurrentPaletteMatrixARB(index);
        }
        
        public static 
        unsafe void MatrixIndexubvARB(GLint size, GLubyte* indices)
        {
            Delegates.glMatrixIndexubvARB(size, indices);
        }
        
        public static 
        unsafe void MatrixIndexusvARB(GLint size, GLushort* indices)
        {
            Delegates.glMatrixIndexusvARB(size, indices);
        }
        
        public static 
        unsafe void MatrixIndexuivARB(GLint size, GLuint* indices)
        {
            Delegates.glMatrixIndexuivARB(size, indices);
        }
        
        public static 
        unsafe void MatrixIndexPointerARB(GLint size, GL.Enums.ARB_matrix_palette type, GLsizei stride, void* pointer)
        {
            Delegates.glMatrixIndexPointerARB(size, type, stride, pointer);
        }
        
        public static 
        void WindowPos2dARB(GLdouble x, GLdouble y)
        {
            Delegates.glWindowPos2dARB(x, y);
        }
        
        public static 
        unsafe void WindowPos2dvARB(GLdouble* v)
        {
            Delegates.glWindowPos2dvARB(v);
        }
        
        public static 
        void WindowPos2fARB(GLfloat x, GLfloat y)
        {
            Delegates.glWindowPos2fARB(x, y);
        }
        
        public static 
        unsafe void WindowPos2fvARB(GLfloat* v)
        {
            Delegates.glWindowPos2fvARB(v);
        }
        
        public static 
        void WindowPos2iARB(GLint x, GLint y)
        {
            Delegates.glWindowPos2iARB(x, y);
        }
        
        public static 
        unsafe void WindowPos2ivARB(GLint* v)
        {
            Delegates.glWindowPos2ivARB(v);
        }
        
        public static 
        void WindowPos2sARB(GLshort x, GLshort y)
        {
            Delegates.glWindowPos2sARB(x, y);
        }
        
        public static 
        unsafe void WindowPos2svARB(GLshort* v)
        {
            Delegates.glWindowPos2svARB(v);
        }
        
        public static 
        void WindowPos3dARB(GLdouble x, GLdouble y, GLdouble z)
        {
            Delegates.glWindowPos3dARB(x, y, z);
        }
        
        public static 
        unsafe void WindowPos3dvARB(GLdouble* v)
        {
            Delegates.glWindowPos3dvARB(v);
        }
        
        public static 
        void WindowPos3fARB(GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glWindowPos3fARB(x, y, z);
        }
        
        public static 
        unsafe void WindowPos3fvARB(GLfloat* v)
        {
            Delegates.glWindowPos3fvARB(v);
        }
        
        public static 
        void WindowPos3iARB(GLint x, GLint y, GLint z)
        {
            Delegates.glWindowPos3iARB(x, y, z);
        }
        
        public static 
        unsafe void WindowPos3ivARB(GLint* v)
        {
            Delegates.glWindowPos3ivARB(v);
        }
        
        public static 
        void WindowPos3sARB(GLshort x, GLshort y, GLshort z)
        {
            Delegates.glWindowPos3sARB(x, y, z);
        }
        
        public static 
        unsafe void WindowPos3svARB(GLshort* v)
        {
            Delegates.glWindowPos3svARB(v);
        }
        
        public static 
        void VertexAttrib1dARB(GLuint index, GLdouble x)
        {
            Delegates.glVertexAttrib1dARB(index, x);
        }
        
        public static 
        unsafe void VertexAttrib1dvARB(GLuint index, GLdouble* v)
        {
            Delegates.glVertexAttrib1dvARB(index, v);
        }
        
        public static 
        void VertexAttrib1fARB(GLuint index, GLfloat x)
        {
            Delegates.glVertexAttrib1fARB(index, x);
        }
        
        public static 
        unsafe void VertexAttrib1fvARB(GLuint index, GLfloat* v)
        {
            Delegates.glVertexAttrib1fvARB(index, v);
        }
        
        public static 
        void VertexAttrib1sARB(GLuint index, GLshort x)
        {
            Delegates.glVertexAttrib1sARB(index, x);
        }
        
        public static 
        unsafe void VertexAttrib1svARB(GLuint index, GLshort* v)
        {
            Delegates.glVertexAttrib1svARB(index, v);
        }
        
        public static 
        void VertexAttrib2dARB(GLuint index, GLdouble x, GLdouble y)
        {
            Delegates.glVertexAttrib2dARB(index, x, y);
        }
        
        public static 
        unsafe void VertexAttrib2dvARB(GLuint index, GLdouble* v)
        {
            Delegates.glVertexAttrib2dvARB(index, v);
        }
        
        public static 
        void VertexAttrib2fARB(GLuint index, GLfloat x, GLfloat y)
        {
            Delegates.glVertexAttrib2fARB(index, x, y);
        }
        
        public static 
        unsafe void VertexAttrib2fvARB(GLuint index, GLfloat* v)
        {
            Delegates.glVertexAttrib2fvARB(index, v);
        }
        
        public static 
        void VertexAttrib2sARB(GLuint index, GLshort x, GLshort y)
        {
            Delegates.glVertexAttrib2sARB(index, x, y);
        }
        
        public static 
        unsafe void VertexAttrib2svARB(GLuint index, GLshort* v)
        {
            Delegates.glVertexAttrib2svARB(index, v);
        }
        
        public static 
        void VertexAttrib3dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z)
        {
            Delegates.glVertexAttrib3dARB(index, x, y, z);
        }
        
        public static 
        unsafe void VertexAttrib3dvARB(GLuint index, GLdouble* v)
        {
            Delegates.glVertexAttrib3dvARB(index, v);
        }
        
        public static 
        void VertexAttrib3fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glVertexAttrib3fARB(index, x, y, z);
        }
        
        public static 
        unsafe void VertexAttrib3fvARB(GLuint index, GLfloat* v)
        {
            Delegates.glVertexAttrib3fvARB(index, v);
        }
        
        public static 
        void VertexAttrib3sARB(GLuint index, GLshort x, GLshort y, GLshort z)
        {
            Delegates.glVertexAttrib3sARB(index, x, y, z);
        }
        
        public static 
        unsafe void VertexAttrib3svARB(GLuint index, GLshort* v)
        {
            Delegates.glVertexAttrib3svARB(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4NbvARB(GLuint index, GLbyte* v)
        {
            Delegates.glVertexAttrib4NbvARB(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4NivARB(GLuint index, GLint* v)
        {
            Delegates.glVertexAttrib4NivARB(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4NsvARB(GLuint index, GLshort* v)
        {
            Delegates.glVertexAttrib4NsvARB(index, v);
        }
        
        public static 
        void VertexAttrib4NubARB(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)
        {
            Delegates.glVertexAttrib4NubARB(index, x, y, z, w);
        }
        
        public static 
        unsafe void VertexAttrib4NubvARB(GLuint index, GLubyte* v)
        {
            Delegates.glVertexAttrib4NubvARB(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4NuivARB(GLuint index, GLuint* v)
        {
            Delegates.glVertexAttrib4NuivARB(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4NusvARB(GLuint index, GLushort* v)
        {
            Delegates.glVertexAttrib4NusvARB(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4bvARB(GLuint index, GLbyte* v)
        {
            Delegates.glVertexAttrib4bvARB(index, v);
        }
        
        public static 
        void VertexAttrib4dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            Delegates.glVertexAttrib4dARB(index, x, y, z, w);
        }
        
        public static 
        unsafe void VertexAttrib4dvARB(GLuint index, GLdouble* v)
        {
            Delegates.glVertexAttrib4dvARB(index, v);
        }
        
        public static 
        void VertexAttrib4fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            Delegates.glVertexAttrib4fARB(index, x, y, z, w);
        }
        
        public static 
        unsafe void VertexAttrib4fvARB(GLuint index, GLfloat* v)
        {
            Delegates.glVertexAttrib4fvARB(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4ivARB(GLuint index, GLint* v)
        {
            Delegates.glVertexAttrib4ivARB(index, v);
        }
        
        public static 
        void VertexAttrib4sARB(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)
        {
            Delegates.glVertexAttrib4sARB(index, x, y, z, w);
        }
        
        public static 
        unsafe void VertexAttrib4svARB(GLuint index, GLshort* v)
        {
            Delegates.glVertexAttrib4svARB(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4ubvARB(GLuint index, GLubyte* v)
        {
            Delegates.glVertexAttrib4ubvARB(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4uivARB(GLuint index, GLuint* v)
        {
            Delegates.glVertexAttrib4uivARB(index, v);
        }
        
        public static 
        unsafe void VertexAttrib4usvARB(GLuint index, GLushort* v)
        {
            Delegates.glVertexAttrib4usvARB(index, v);
        }
        
        public static 
        unsafe void VertexAttribPointerARB(GLuint index, GLint size, GL.Enums.ARB_vertex_program type, GL.Enums.Boolean normalized, GLsizei stride, void* pointer)
        {
            Delegates.glVertexAttribPointerARB(index, size, type, normalized, stride, pointer);
        }
        
        public static 
        void EnableVertexAttribArrayARB(GLuint index)
        {
            Delegates.glEnableVertexAttribArrayARB(index);
        }
        
        public static 
        void DisableVertexAttribArrayARB(GLuint index)
        {
            Delegates.glDisableVertexAttribArrayARB(index);
        }
        
        public static 
        unsafe void ProgramStringARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program format, GLsizei len, void* @string)
        {
            Delegates.glProgramStringARB(target, format, len, @string);
        }
        
        public static 
        void BindProgramARB(GL.Enums.ARB_vertex_program target, GLuint program)
        {
            Delegates.glBindProgramARB(target, program);
        }
        
        public static 
        unsafe void DeleteProgramsARB(GLsizei n, GLuint* programs)
        {
            Delegates.glDeleteProgramsARB(n, programs);
        }
        
        public static 
        unsafe void GenProgramsARB(GLsizei n, GLuint* programs)
        {
            Delegates.glGenProgramsARB(n, programs);
        }
        
        public static 
        void ProgramEnvParameter4dARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            Delegates.glProgramEnvParameter4dARB(target, index, x, y, z, w);
        }
        
        public static 
        unsafe void ProgramEnvParameter4dvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble* @params)
        {
            Delegates.glProgramEnvParameter4dvARB(target, index, @params);
        }
        
        public static 
        void ProgramEnvParameter4fARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            Delegates.glProgramEnvParameter4fARB(target, index, x, y, z, w);
        }
        
        public static 
        unsafe void ProgramEnvParameter4fvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat* @params)
        {
            Delegates.glProgramEnvParameter4fvARB(target, index, @params);
        }
        
        public static 
        void ProgramLocalParameter4dARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            Delegates.glProgramLocalParameter4dARB(target, index, x, y, z, w);
        }
        
        public static 
        unsafe void ProgramLocalParameter4dvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble* @params)
        {
            Delegates.glProgramLocalParameter4dvARB(target, index, @params);
        }
        
        public static 
        void ProgramLocalParameter4fARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            Delegates.glProgramLocalParameter4fARB(target, index, x, y, z, w);
        }
        
        public static 
        unsafe void ProgramLocalParameter4fvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat* @params)
        {
            Delegates.glProgramLocalParameter4fvARB(target, index, @params);
        }
        
        public static 
        unsafe void GetProgramEnvParameterdvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble* @params)
        {
            Delegates.glGetProgramEnvParameterdvARB(target, index, @params);
        }
        
        public static 
        unsafe void GetProgramEnvParameterfvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat* @params)
        {
            Delegates.glGetProgramEnvParameterfvARB(target, index, @params);
        }
        
        public static 
        unsafe void GetProgramLocalParameterdvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble* @params)
        {
            Delegates.glGetProgramLocalParameterdvARB(target, index, @params);
        }
        
        public static 
        unsafe void GetProgramLocalParameterfvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat* @params)
        {
            Delegates.glGetProgramLocalParameterfvARB(target, index, @params);
        }
        
        public static 
        unsafe void GetProgramivARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program pname, GLint* @params)
        {
            Delegates.glGetProgramivARB(target, pname, @params);
        }
        
        public static 
        unsafe void GetProgramStringARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program pname, void* @string)
        {
            Delegates.glGetProgramStringARB(target, pname, @string);
        }
        
        public static 
        unsafe void GetVertexAttribdvARB(GLuint index, GL.Enums.ARB_vertex_program pname, GLdouble* @params)
        {
            Delegates.glGetVertexAttribdvARB(index, pname, @params);
        }
        
        public static 
        unsafe void GetVertexAttribfvARB(GLuint index, GL.Enums.ARB_vertex_program pname, GLfloat* @params)
        {
            Delegates.glGetVertexAttribfvARB(index, pname, @params);
        }
        
        public static 
        unsafe void GetVertexAttribivARB(GLuint index, GL.Enums.ARB_vertex_program pname, GLint* @params)
        {
            Delegates.glGetVertexAttribivARB(index, pname, @params);
        }
        
        public static 
        unsafe void GetVertexAttribPointervARB(GLuint index, GL.Enums.ARB_vertex_program pname, void* pointer)
        {
            Delegates.glGetVertexAttribPointervARB(index, pname, pointer);
        }
        
        public static 
        GLboolean IsProgramARB(GLuint program)
        {
            return Delegates.glIsProgramARB(program);
        }
        
        public static 
        void BindBufferARB(GL.Enums.ARB_vertex_buffer_object target, GLuint buffer)
        {
            Delegates.glBindBufferARB(target, buffer);
        }
        
        public static 
        unsafe void DeleteBuffersARB(GLsizei n, GLuint* buffers)
        {
            Delegates.glDeleteBuffersARB(n, buffers);
        }
        
        public static 
        unsafe void GenBuffersARB(GLsizei n, GLuint* buffers)
        {
            Delegates.glGenBuffersARB(n, buffers);
        }
        
        public static 
        GLboolean IsBufferARB(GLuint buffer)
        {
            return Delegates.glIsBufferARB(buffer);
        }
        
        public static 
        unsafe void BufferDataARB(GL.Enums.ARB_vertex_buffer_object target, GLsizeiptrARB size, void* data, GL.Enums.ARB_vertex_buffer_object usage)
        {
            Delegates.glBufferDataARB(target, size, data, usage);
        }
        
        public static 
        unsafe void BufferSubDataARB(GL.Enums.ARB_vertex_buffer_object target, GLintptrARB offset, GLsizeiptrARB size, void* data)
        {
            Delegates.glBufferSubDataARB(target, offset, size, data);
        }
        
        public static 
        unsafe void GetBufferSubDataARB(GL.Enums.ARB_vertex_buffer_object target, GLintptrARB offset, GLsizeiptrARB size, void* data)
        {
            Delegates.glGetBufferSubDataARB(target, offset, size, data);
        }
        
        public static 
        void MapBufferARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object access)
        {
            Delegates.glMapBufferARB(target, access);
        }
        
        public static 
        GLboolean UnmapBufferARB(GL.Enums.ARB_vertex_buffer_object target)
        {
            return Delegates.glUnmapBufferARB(target);
        }
        
        public static 
        unsafe void GetBufferParameterivARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object pname, GLint* @params)
        {
            Delegates.glGetBufferParameterivARB(target, pname, @params);
        }
        
        public static 
        unsafe void GetBufferPointervARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object pname, void* @params)
        {
            Delegates.glGetBufferPointervARB(target, pname, @params);
        }
        
        public static 
        unsafe void GenQueriesARB(GLsizei n, GLuint* ids)
        {
            Delegates.glGenQueriesARB(n, ids);
        }
        
        public static 
        unsafe void DeleteQueriesARB(GLsizei n, GLuint* ids)
        {
            Delegates.glDeleteQueriesARB(n, ids);
        }
        
        public static 
        GLboolean IsQueryARB(GLuint id)
        {
            return Delegates.glIsQueryARB(id);
        }
        
        public static 
        void BeginQueryARB(GL.Enums.GLenum target, GLuint id)
        {
            Delegates.glBeginQueryARB(target, id);
        }
        
        public static 
        void EndQueryARB(GL.Enums.GLenum target)
        {
            Delegates.glEndQueryARB(target);
        }
        
        public static 
        unsafe void GetQueryivARB(GL.Enums.GLenum target, GL.Enums.GLenum pname, GLint* @params)
        {
            Delegates.glGetQueryivARB(target, pname, @params);
        }
        
        public static 
        unsafe void GetQueryObjectivARB(GLuint id, GL.Enums.GLenum pname, GLint* @params)
        {
            Delegates.glGetQueryObjectivARB(id, pname, @params);
        }
        
        public static 
        unsafe void GetQueryObjectuivARB(GLuint id, GL.Enums.GLenum pname, GLuint* @params)
        {
            Delegates.glGetQueryObjectuivARB(id, pname, @params);
        }
        
        public static 
        void DeleteObjectARB(GLhandleARB obj)
        {
            Delegates.glDeleteObjectARB(obj);
        }
        
        public static 
        GLhandleARB GetHandleARB(GL.Enums.GLenum pname)
        {
            return Delegates.glGetHandleARB(pname);
        }
        
        public static 
        void DetachObjectARB(GLhandleARB containerObj, GLhandleARB attachedObj)
        {
            Delegates.glDetachObjectARB(containerObj, attachedObj);
        }
        
        public static 
        GLhandleARB CreateShaderObjectARB(GL.Enums.GLenum shaderType)
        {
            return Delegates.glCreateShaderObjectARB(shaderType);
        }
        
        public static 
        unsafe void ShaderSourceARB(GLhandleARB shaderObj, GLsizei count, System.String @string, GLint* length)
        {
            Delegates.glShaderSourceARB(shaderObj, count, @string, length);
        }
        
        public static 
        void CompileShaderARB(GLhandleARB shaderObj)
        {
            Delegates.glCompileShaderARB(shaderObj);
        }
        
        public static 
        GLhandleARB CreateProgramObjectARB()
        {
            return Delegates.glCreateProgramObjectARB();
        }
        
        public static 
        void AttachObjectARB(GLhandleARB containerObj, GLhandleARB obj)
        {
            Delegates.glAttachObjectARB(containerObj, obj);
        }
        
        public static 
        void LinkProgramARB(GLhandleARB programObj)
        {
            Delegates.glLinkProgramARB(programObj);
        }
        
        public static 
        void UseProgramObjectARB(GLhandleARB programObj)
        {
            Delegates.glUseProgramObjectARB(programObj);
        }
        
        public static 
        void ValidateProgramARB(GLhandleARB programObj)
        {
            Delegates.glValidateProgramARB(programObj);
        }
        
        public static 
        void Uniform1fARB(GLint location, GLfloat v0)
        {
            Delegates.glUniform1fARB(location, v0);
        }
        
        public static 
        void Uniform2fARB(GLint location, GLfloat v0, GLfloat v1)
        {
            Delegates.glUniform2fARB(location, v0, v1);
        }
        
        public static 
        void Uniform3fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
        {
            Delegates.glUniform3fARB(location, v0, v1, v2);
        }
        
        public static 
        void Uniform4fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
        {
            Delegates.glUniform4fARB(location, v0, v1, v2, v3);
        }
        
        public static 
        void Uniform1iARB(GLint location, GLint v0)
        {
            Delegates.glUniform1iARB(location, v0);
        }
        
        public static 
        void Uniform2iARB(GLint location, GLint v0, GLint v1)
        {
            Delegates.glUniform2iARB(location, v0, v1);
        }
        
        public static 
        void Uniform3iARB(GLint location, GLint v0, GLint v1, GLint v2)
        {
            Delegates.glUniform3iARB(location, v0, v1, v2);
        }
        
        public static 
        void Uniform4iARB(GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
        {
            Delegates.glUniform4iARB(location, v0, v1, v2, v3);
        }
        
        public static 
        unsafe void Uniform1fvARB(GLint location, GLsizei count, GLfloat* value)
        {
            Delegates.glUniform1fvARB(location, count, value);
        }
        
        public static 
        unsafe void Uniform2fvARB(GLint location, GLsizei count, GLfloat* value)
        {
            Delegates.glUniform2fvARB(location, count, value);
        }
        
        public static 
        unsafe void Uniform3fvARB(GLint location, GLsizei count, GLfloat* value)
        {
            Delegates.glUniform3fvARB(location, count, value);
        }
        
        public static 
        unsafe void Uniform4fvARB(GLint location, GLsizei count, GLfloat* value)
        {
            Delegates.glUniform4fvARB(location, count, value);
        }
        
        public static 
        unsafe void Uniform1ivARB(GLint location, GLsizei count, GLint* value)
        {
            Delegates.glUniform1ivARB(location, count, value);
        }
        
        public static 
        unsafe void Uniform2ivARB(GLint location, GLsizei count, GLint* value)
        {
            Delegates.glUniform2ivARB(location, count, value);
        }
        
        public static 
        unsafe void Uniform3ivARB(GLint location, GLsizei count, GLint* value)
        {
            Delegates.glUniform3ivARB(location, count, value);
        }
        
        public static 
        unsafe void Uniform4ivARB(GLint location, GLsizei count, GLint* value)
        {
            Delegates.glUniform4ivARB(location, count, value);
        }
        
        public static 
        unsafe void UniformMatrix2fvARB(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            Delegates.glUniformMatrix2fvARB(location, count, transpose, value);
        }
        
        public static 
        unsafe void UniformMatrix3fvARB(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            Delegates.glUniformMatrix3fvARB(location, count, transpose, value);
        }
        
        public static 
        unsafe void UniformMatrix4fvARB(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            Delegates.glUniformMatrix4fvARB(location, count, transpose, value);
        }
        
        public static 
        unsafe void GetObjectParameterfvARB(GLhandleARB obj, GL.Enums.GLenum pname, GLfloat* @params)
        {
            Delegates.glGetObjectParameterfvARB(obj, pname, @params);
        }
        
        public static 
        unsafe void GetObjectParameterivARB(GLhandleARB obj, GL.Enums.GLenum pname, GLint* @params)
        {
            Delegates.glGetObjectParameterivARB(obj, pname, @params);
        }
        
        public static 
        unsafe void GetInfoLogARB(GLhandleARB obj, GLsizei maxLength, GLsizei* length, System.Text.StringBuilder infoLog)
        {
            Delegates.glGetInfoLogARB(obj, maxLength, length, infoLog);
        }
        
        public static 
        unsafe void GetAttachedObjectsARB(GLhandleARB containerObj, GLsizei maxCount, GLsizei* count, GLhandleARB* obj)
        {
            Delegates.glGetAttachedObjectsARB(containerObj, maxCount, count, obj);
        }
        
        public static 
        unsafe void GetActiveUniformARB(GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GL.Enums.GLenum* type, System.Text.StringBuilder name)
        {
            Delegates.glGetActiveUniformARB(programObj, index, maxLength, length, size, type, name);
        }
        
        public static 
        unsafe void GetUniformfvARB(GLhandleARB programObj, GLint location, GLfloat* @params)
        {
            Delegates.glGetUniformfvARB(programObj, location, @params);
        }
        
        public static 
        unsafe void GetUniformivARB(GLhandleARB programObj, GLint location, GLint* @params)
        {
            Delegates.glGetUniformivARB(programObj, location, @params);
        }
        
        public static 
        unsafe void GetShaderSourceARB(GLhandleARB obj, GLsizei maxLength, GLsizei* length, System.Text.StringBuilder source)
        {
            Delegates.glGetShaderSourceARB(obj, maxLength, length, source);
        }
        
        public static 
        unsafe void GetActiveAttribARB(GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GL.Enums.GLenum* type, System.Text.StringBuilder name)
        {
            Delegates.glGetActiveAttribARB(programObj, index, maxLength, length, size, type, name);
        }
        
        public static 
        unsafe void DrawBuffersARB(GLsizei n, GL.Enums.ARB_draw_buffers* bufs)
        {
            Delegates.glDrawBuffersARB(n, bufs);
        }
        
        public static 
        void ClampColorARB(GL.Enums.ARB_color_buffer_float target, GL.Enums.ARB_color_buffer_float clamp)
        {
            Delegates.glClampColorARB(target, clamp);
        }
        
        public static 
        void BlendColorEXT(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha)
        {
            Delegates.glBlendColorEXT(red, green, blue, alpha);
        }
        
        public static 
        void PolygonOffsetEXT(GLfloat factor, GLfloat bias)
        {
            Delegates.glPolygonOffsetEXT(factor, bias);
        }
        
        public static 
        unsafe void TexImage3DEXT(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            Delegates.glTexImage3DEXT(target, level, internalformat, width, height, depth, border, format, type, pixels);
        }
        
        public static 
        unsafe void TexSubImage3DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            Delegates.glTexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }
        
        public static 
        unsafe void GetTexFilterFuncSGIS(GL.Enums.TextureTarget target, GL.Enums.SGIS_texture_filter4 filter, GLfloat* weights)
        {
            Delegates.glGetTexFilterFuncSGIS(target, filter, weights);
        }
        
        public static 
        unsafe void TexFilterFuncSGIS(GL.Enums.TextureTarget target, GL.Enums.SGIS_texture_filter4 filter, GLsizei n, GLfloat* weights)
        {
            Delegates.glTexFilterFuncSGIS(target, filter, n, weights);
        }
        
        public static 
        unsafe void TexSubImage1DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            Delegates.glTexSubImage1DEXT(target, level, xoffset, width, format, type, pixels);
        }
        
        public static 
        unsafe void TexSubImage2DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            Delegates.glTexSubImage2DEXT(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }
        
        public static 
        void CopyTexImage1DEXT(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLint border)
        {
            Delegates.glCopyTexImage1DEXT(target, level, internalformat, x, y, width, border);
        }
        
        public static 
        void CopyTexImage2DEXT(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)
        {
            Delegates.glCopyTexImage2DEXT(target, level, internalformat, x, y, width, height, border);
        }
        
        public static 
        void CopyTexSubImage1DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
        {
            Delegates.glCopyTexSubImage1DEXT(target, level, xoffset, x, y, width);
        }
        
        public static 
        void CopyTexSubImage2DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            Delegates.glCopyTexSubImage2DEXT(target, level, xoffset, yoffset, x, y, width, height);
        }
        
        public static 
        void CopyTexSubImage3DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            Delegates.glCopyTexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, x, y, width, height);
        }
        
        public static 
        unsafe void GetHistogramEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* values)
        {
            Delegates.glGetHistogramEXT(target, reset, format, type, values);
        }
        
        public static 
        unsafe void GetHistogramParameterfvEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.GetHistogramParameterPNameEXT pname, GLfloat* @params)
        {
            Delegates.glGetHistogramParameterfvEXT(target, pname, @params);
        }
        
        public static 
        unsafe void GetHistogramParameterivEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.GetHistogramParameterPNameEXT pname, GLint* @params)
        {
            Delegates.glGetHistogramParameterivEXT(target, pname, @params);
        }
        
        public static 
        unsafe void GetMinmaxEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* values)
        {
            Delegates.glGetMinmaxEXT(target, reset, format, type, values);
        }
        
        public static 
        unsafe void GetMinmaxParameterfvEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.GetMinmaxParameterPNameEXT pname, GLfloat* @params)
        {
            Delegates.glGetMinmaxParameterfvEXT(target, pname, @params);
        }
        
        public static 
        unsafe void GetMinmaxParameterivEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.GetMinmaxParameterPNameEXT pname, GLint* @params)
        {
            Delegates.glGetMinmaxParameterivEXT(target, pname, @params);
        }
        
        public static 
        void ResetHistogramEXT(GL.Enums.HistogramTargetEXT target)
        {
            Delegates.glResetHistogramEXT(target);
        }
        
        public static 
        void ResetMinmaxEXT(GL.Enums.MinmaxTargetEXT target)
        {
            Delegates.glResetMinmaxEXT(target);
        }
        
        public static 
        unsafe void ConvolutionFilter1DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image)
        {
            Delegates.glConvolutionFilter1DEXT(target, internalformat, width, format, type, image);
        }
        
        public static 
        unsafe void ConvolutionFilter2DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image)
        {
            Delegates.glConvolutionFilter2DEXT(target, internalformat, width, height, format, type, image);
        }
        
        public static 
        void ConvolutionParameterfEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLfloat @params)
        {
            Delegates.glConvolutionParameterfEXT(target, pname, @params);
        }
        
        public static 
        unsafe void ConvolutionParameterfvEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLfloat* @params)
        {
            Delegates.glConvolutionParameterfvEXT(target, pname, @params);
        }
        
        public static 
        void ConvolutionParameteriEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLint @params)
        {
            Delegates.glConvolutionParameteriEXT(target, pname, @params);
        }
        
        public static 
        unsafe void ConvolutionParameterivEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLint* @params)
        {
            Delegates.glConvolutionParameterivEXT(target, pname, @params);
        }
        
        public static 
        void CopyConvolutionFilter1DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width)
        {
            Delegates.glCopyConvolutionFilter1DEXT(target, internalformat, x, y, width);
        }
        
        public static 
        void CopyConvolutionFilter2DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            Delegates.glCopyConvolutionFilter2DEXT(target, internalformat, x, y, width, height);
        }
        
        public static 
        unsafe void GetConvolutionFilterEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image)
        {
            Delegates.glGetConvolutionFilterEXT(target, format, type, image);
        }
        
        public static 
        unsafe void GetConvolutionParameterfvEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLfloat* @params)
        {
            Delegates.glGetConvolutionParameterfvEXT(target, pname, @params);
        }
        
        public static 
        unsafe void GetConvolutionParameterivEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLint* @params)
        {
            Delegates.glGetConvolutionParameterivEXT(target, pname, @params);
        }
        
        public static 
        unsafe void GetSeparableFilterEXT(GL.Enums.SeparableTargetEXT target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column, void* span)
        {
            Delegates.glGetSeparableFilterEXT(target, format, type, row, column, span);
        }
        
        public static 
        unsafe void SeparableFilter2DEXT(GL.Enums.SeparableTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column)
        {
            Delegates.glSeparableFilter2DEXT(target, internalformat, width, height, format, type, row, column);
        }
        
        public static 
        unsafe void ColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table)
        {
            Delegates.glColorTableSGI(target, internalformat, width, format, type, table);
        }
        
        public static 
        unsafe void ColorTableParameterfvSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.ColorTableParameterPNameSGI pname, GLfloat* @params)
        {
            Delegates.glColorTableParameterfvSGI(target, pname, @params);
        }
        
        public static 
        unsafe void ColorTableParameterivSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.ColorTableParameterPNameSGI pname, GLint* @params)
        {
            Delegates.glColorTableParameterivSGI(target, pname, @params);
        }
        
        public static 
        void CopyColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width)
        {
            Delegates.glCopyColorTableSGI(target, internalformat, x, y, width);
        }
        
        public static 
        unsafe void GetColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table)
        {
            Delegates.glGetColorTableSGI(target, format, type, table);
        }
        
        public static 
        unsafe void GetColorTableParameterfvSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.GetColorTableParameterPNameSGI pname, GLfloat* @params)
        {
            Delegates.glGetColorTableParameterfvSGI(target, pname, @params);
        }
        
        public static 
        unsafe void GetColorTableParameterivSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.GetColorTableParameterPNameSGI pname, GLint* @params)
        {
            Delegates.glGetColorTableParameterivSGI(target, pname, @params);
        }
        
        public static 
        void PixelTexGenSGIX(GL.Enums.SGIX_pixel_texture mode)
        {
            Delegates.glPixelTexGenSGIX(mode);
        }
        
        public static 
        void PixelTexGenParameteriSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLint param)
        {
            Delegates.glPixelTexGenParameteriSGIS(pname, param);
        }
        
        public static 
        unsafe void PixelTexGenParameterivSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLint* @params)
        {
            Delegates.glPixelTexGenParameterivSGIS(pname, @params);
        }
        
        public static 
        void PixelTexGenParameterfSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLfloat param)
        {
            Delegates.glPixelTexGenParameterfSGIS(pname, param);
        }
        
        public static 
        unsafe void PixelTexGenParameterfvSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLfloat* @params)
        {
            Delegates.glPixelTexGenParameterfvSGIS(pname, @params);
        }
        
        public static 
        unsafe void GetPixelTexGenParameterivSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLint* @params)
        {
            Delegates.glGetPixelTexGenParameterivSGIS(pname, @params);
        }
        
        public static 
        unsafe void GetPixelTexGenParameterfvSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLfloat* @params)
        {
            Delegates.glGetPixelTexGenParameterfvSGIS(pname, @params);
        }
        
        public static 
        unsafe void TexImage4DSGIS(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            Delegates.glTexImage4DSGIS(target, level, internalformat, width, height, depth, size4d, border, format, type, pixels);
        }
        
        public static 
        unsafe void TexSubImage4DSGIS(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint woffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            Delegates.glTexSubImage4DSGIS(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels);
        }
        
        public static 
        unsafe GLboolean AreTexturesResidentEXT(GLsizei n, GLuint* textures, GL.Enums.Boolean* residences)
        {
            return Delegates.glAreTexturesResidentEXT(n, textures, residences);
        }
        
        public static 
        void BindTextureEXT(GL.Enums.TextureTarget target, GLuint texture)
        {
            Delegates.glBindTextureEXT(target, texture);
        }
        
        public static 
        unsafe void DeleteTexturesEXT(GLsizei n, GLuint* textures)
        {
            Delegates.glDeleteTexturesEXT(n, textures);
        }
        
        public static 
        unsafe void GenTexturesEXT(GLsizei n, GLuint* textures)
        {
            Delegates.glGenTexturesEXT(n, textures);
        }
        
        public static 
        GLboolean IsTextureEXT(GLuint texture)
        {
            return Delegates.glIsTextureEXT(texture);
        }
        
        public static 
        unsafe void PrioritizeTexturesEXT(GLsizei n, GLuint* textures, GLclampf* priorities)
        {
            Delegates.glPrioritizeTexturesEXT(n, textures, priorities);
        }
        
        public static 
        unsafe void DetailTexFuncSGIS(GL.Enums.TextureTarget target, GLsizei n, GLfloat* points)
        {
            Delegates.glDetailTexFuncSGIS(target, n, points);
        }
        
        public static 
        unsafe void GetDetailTexFuncSGIS(GL.Enums.TextureTarget target, GLfloat* points)
        {
            Delegates.glGetDetailTexFuncSGIS(target, points);
        }
        
        public static 
        unsafe void SharpenTexFuncSGIS(GL.Enums.TextureTarget target, GLsizei n, GLfloat* points)
        {
            Delegates.glSharpenTexFuncSGIS(target, n, points);
        }
        
        public static 
        unsafe void GetSharpenTexFuncSGIS(GL.Enums.TextureTarget target, GLfloat* points)
        {
            Delegates.glGetSharpenTexFuncSGIS(target, points);
        }
        
        public static 
        void SamplePatternSGIS(GL.Enums.SamplePatternSGIS pattern)
        {
            Delegates.glSamplePatternSGIS(pattern);
        }
        
        public static 
        void ArrayElementEXT(GLint i)
        {
            Delegates.glArrayElementEXT(i);
        }
        
        public static 
        unsafe void ColorPointerEXT(GLint size, GL.Enums.ColorPointerType type, GLsizei stride, GLsizei count, void* pointer)
        {
            Delegates.glColorPointerEXT(size, type, stride, count, pointer);
        }
        
        public static 
        void DrawArraysEXT(GL.Enums.BeginMode mode, GLint first, GLsizei count)
        {
            Delegates.glDrawArraysEXT(mode, first, count);
        }
        
        public static 
        unsafe void EdgeFlagPointerEXT(GLsizei stride, GLsizei count, GL.Enums.Boolean* pointer)
        {
            Delegates.glEdgeFlagPointerEXT(stride, count, pointer);
        }
        
        public static 
        unsafe void GetPointervEXT(GL.Enums.GetPointervPName pname, void* @params)
        {
            Delegates.glGetPointervEXT(pname, @params);
        }
        
        public static 
        unsafe void IndexPointerEXT(GL.Enums.IndexPointerType type, GLsizei stride, GLsizei count, void* pointer)
        {
            Delegates.glIndexPointerEXT(type, stride, count, pointer);
        }
        
        public static 
        unsafe void NormalPointerEXT(GL.Enums.NormalPointerType type, GLsizei stride, GLsizei count, void* pointer)
        {
            Delegates.glNormalPointerEXT(type, stride, count, pointer);
        }
        
        public static 
        unsafe void TexCoordPointerEXT(GLint size, GL.Enums.TexCoordPointerType type, GLsizei stride, GLsizei count, void* pointer)
        {
            Delegates.glTexCoordPointerEXT(size, type, stride, count, pointer);
        }
        
        public static 
        unsafe void VertexPointerEXT(GLint size, GL.Enums.VertexPointerType type, GLsizei stride, GLsizei count, void* pointer)
        {
            Delegates.glVertexPointerEXT(size, type, stride, count, pointer);
        }
        
        public static 
        void BlendEquationEXT(GL.Enums.BlendEquationModeEXT mode)
        {
            Delegates.glBlendEquationEXT(mode);
        }
        
        public static 
        void SpriteParameterfSGIX(GL.Enums.SGIX_sprite pname, GLfloat param)
        {
            Delegates.glSpriteParameterfSGIX(pname, param);
        }
        
        public static 
        unsafe void SpriteParameterfvSGIX(GL.Enums.SGIX_sprite pname, GLfloat* @params)
        {
            Delegates.glSpriteParameterfvSGIX(pname, @params);
        }
        
        public static 
        void SpriteParameteriSGIX(GL.Enums.SGIX_sprite pname, GLint param)
        {
            Delegates.glSpriteParameteriSGIX(pname, param);
        }
        
        public static 
        unsafe void SpriteParameterivSGIX(GL.Enums.SGIX_sprite pname, GLint* @params)
        {
            Delegates.glSpriteParameterivSGIX(pname, @params);
        }
        
        public static 
        void PointParameterfEXT(GL.Enums.EXT_point_parameters pname, GLfloat param)
        {
            Delegates.glPointParameterfEXT(pname, param);
        }
        
        public static 
        unsafe void PointParameterfvEXT(GL.Enums.EXT_point_parameters pname, GLfloat* @params)
        {
            Delegates.glPointParameterfvEXT(pname, @params);
        }
        
        public static 
        void PointParameterfSGIS(GL.Enums.SGIS_point_parameters pname, GLfloat param)
        {
            Delegates.glPointParameterfSGIS(pname, param);
        }
        
        public static 
        unsafe void PointParameterfvSGIS(GL.Enums.SGIS_point_parameters pname, GLfloat* @params)
        {
            Delegates.glPointParameterfvSGIS(pname, @params);
        }
        
        public static 
        GLint GetInstrumentsSGIX()
        {
            return Delegates.glGetInstrumentsSGIX();
        }
        
        public static 
        unsafe void InstrumentsBufferSGIX(GLsizei size, GLint* buffer)
        {
            Delegates.glInstrumentsBufferSGIX(size, buffer);
        }
        
        public static 
        unsafe GLint PollInstrumentsSGIX(GLint* marker_p)
        {
            return Delegates.glPollInstrumentsSGIX(marker_p);
        }
        
        public static 
        void ReadInstrumentsSGIX(GLint marker)
        {
            Delegates.glReadInstrumentsSGIX(marker);
        }
        
        public static 
        void StartInstrumentsSGIX()
        {
            Delegates.glStartInstrumentsSGIX();
        }
        
        public static 
        void StopInstrumentsSGIX(GLint marker)
        {
            Delegates.glStopInstrumentsSGIX(marker);
        }
        
        public static 
        void FrameZoomSGIX(GLint factor)
        {
            Delegates.glFrameZoomSGIX(factor);
        }
        
        public static 
        void TagSampleBufferSGIX()
        {
            Delegates.glTagSampleBufferSGIX();
        }
        
        public static 
        unsafe void DeformationMap3dSGIX(GL.Enums.FfdTargetSGIX target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble w1, GLdouble w2, GLint wstride, GLint worder, GLdouble* points)
        {
            Delegates.glDeformationMap3dSGIX(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points);
        }
        
        public static 
        unsafe void DeformationMap3fSGIX(GL.Enums.FfdTargetSGIX target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat w1, GLfloat w2, GLint wstride, GLint worder, GLfloat* points)
        {
            Delegates.glDeformationMap3fSGIX(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points);
        }
        
        public static 
        void DeformSGIX(GL.Enums.FfdMaskSGIX mask)
        {
            Delegates.glDeformSGIX(mask);
        }
        
        public static 
        void LoadIdentityDeformationMapSGIX(GL.Enums.FfdMaskSGIX mask)
        {
            Delegates.glLoadIdentityDeformationMapSGIX(mask);
        }
        
        public static 
        unsafe void ReferencePlaneSGIX(GLdouble* equation)
        {
            Delegates.glReferencePlaneSGIX(equation);
        }
        
        public static 
        void FlushRasterSGIX()
        {
            Delegates.glFlushRasterSGIX();
        }
        
        public static 
        unsafe void FogFuncSGIS(GLsizei n, GLfloat* points)
        {
            Delegates.glFogFuncSGIS(n, points);
        }
        
        public static 
        unsafe void GetFogFuncSGIS(GLfloat* points)
        {
            Delegates.glGetFogFuncSGIS(points);
        }
        
        public static 
        void ImageTransformParameteriHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLint param)
        {
            Delegates.glImageTransformParameteriHP(target, pname, param);
        }
        
        public static 
        void ImageTransformParameterfHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLfloat param)
        {
            Delegates.glImageTransformParameterfHP(target, pname, param);
        }
        
        public static 
        unsafe void ImageTransformParameterivHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLint* @params)
        {
            Delegates.glImageTransformParameterivHP(target, pname, @params);
        }
        
        public static 
        unsafe void ImageTransformParameterfvHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLfloat* @params)
        {
            Delegates.glImageTransformParameterfvHP(target, pname, @params);
        }
        
        public static 
        unsafe void GetImageTransformParameterivHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLint* @params)
        {
            Delegates.glGetImageTransformParameterivHP(target, pname, @params);
        }
        
        public static 
        unsafe void GetImageTransformParameterfvHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLfloat* @params)
        {
            Delegates.glGetImageTransformParameterfvHP(target, pname, @params);
        }
        
        public static 
        unsafe void ColorSubTableEXT(GL.Enums.EXT_color_subtable target, GLsizei start, GLsizei count, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data)
        {
            Delegates.glColorSubTableEXT(target, start, count, format, type, data);
        }
        
        public static 
        void CopyColorSubTableEXT(GL.Enums.EXT_color_subtable target, GLsizei start, GLint x, GLint y, GLsizei width)
        {
            Delegates.glCopyColorSubTableEXT(target, start, x, y, width);
        }
        
        public static 
        void HintPGI(GL.Enums.PGI_misc_hints target, GLint mode)
        {
            Delegates.glHintPGI(target, mode);
        }
        
        public static 
        unsafe void ColorTableEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.PixelInternalFormat internalFormat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table)
        {
            Delegates.glColorTableEXT(target, internalFormat, width, format, type, table);
        }
        
        public static 
        unsafe void GetColorTableEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data)
        {
            Delegates.glGetColorTableEXT(target, format, type, data);
        }
        
        public static 
        unsafe void GetColorTableParameterivEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.EXT_paletted_texture pname, GLint* @params)
        {
            Delegates.glGetColorTableParameterivEXT(target, pname, @params);
        }
        
        public static 
        unsafe void GetColorTableParameterfvEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.EXT_paletted_texture pname, GLfloat* @params)
        {
            Delegates.glGetColorTableParameterfvEXT(target, pname, @params);
        }
        
        public static 
        unsafe void GetListParameterfvSGIX(GLuint list, GL.Enums.ListParameterName pname, GLfloat* @params)
        {
            Delegates.glGetListParameterfvSGIX(list, pname, @params);
        }
        
        public static 
        unsafe void GetListParameterivSGIX(GLuint list, GL.Enums.ListParameterName pname, GLint* @params)
        {
            Delegates.glGetListParameterivSGIX(list, pname, @params);
        }
        
        public static 
        void ListParameterfSGIX(GLuint list, GL.Enums.ListParameterName pname, GLfloat param)
        {
            Delegates.glListParameterfSGIX(list, pname, param);
        }
        
        public static 
        unsafe void ListParameterfvSGIX(GLuint list, GL.Enums.ListParameterName pname, GLfloat* @params)
        {
            Delegates.glListParameterfvSGIX(list, pname, @params);
        }
        
        public static 
        void ListParameteriSGIX(GLuint list, GL.Enums.ListParameterName pname, GLint param)
        {
            Delegates.glListParameteriSGIX(list, pname, param);
        }
        
        public static 
        unsafe void ListParameterivSGIX(GLuint list, GL.Enums.ListParameterName pname, GLint* @params)
        {
            Delegates.glListParameterivSGIX(list, pname, @params);
        }
        
        public static 
        void IndexMaterialEXT(GL.Enums.MaterialFace face, GL.Enums.EXT_index_material mode)
        {
            Delegates.glIndexMaterialEXT(face, mode);
        }
        
        public static 
        void IndexFuncEXT(GL.Enums.EXT_index_func func, GLclampf @ref)
        {
            Delegates.glIndexFuncEXT(func, @ref);
        }
        
        public static 
        void LockArraysEXT(GLint first, GLsizei count)
        {
            Delegates.glLockArraysEXT(first, count);
        }
        
        public static 
        void UnlockArraysEXT()
        {
            Delegates.glUnlockArraysEXT();
        }
        
        public static 
        unsafe void CullParameterdvEXT(GL.Enums.EXT_cull_vertex pname, GLdouble* @params)
        {
            Delegates.glCullParameterdvEXT(pname, @params);
        }
        
        public static 
        unsafe void CullParameterfvEXT(GL.Enums.EXT_cull_vertex pname, GLfloat* @params)
        {
            Delegates.glCullParameterfvEXT(pname, @params);
        }
        
        public static 
        void FragmentColorMaterialSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter mode)
        {
            Delegates.glFragmentColorMaterialSGIX(face, mode);
        }
        
        public static 
        void FragmentLightfSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLfloat param)
        {
            Delegates.glFragmentLightfSGIX(light, pname, param);
        }
        
        public static 
        unsafe void FragmentLightfvSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLfloat* @params)
        {
            Delegates.glFragmentLightfvSGIX(light, pname, @params);
        }
        
        public static 
        void FragmentLightiSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLint param)
        {
            Delegates.glFragmentLightiSGIX(light, pname, param);
        }
        
        public static 
        unsafe void FragmentLightivSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLint* @params)
        {
            Delegates.glFragmentLightivSGIX(light, pname, @params);
        }
        
        public static 
        void FragmentLightModelfSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, GLfloat param)
        {
            Delegates.glFragmentLightModelfSGIX(pname, param);
        }
        
        public static 
        unsafe void FragmentLightModelfvSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, GLfloat* @params)
        {
            Delegates.glFragmentLightModelfvSGIX(pname, @params);
        }
        
        public static 
        void FragmentLightModeliSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, GLint param)
        {
            Delegates.glFragmentLightModeliSGIX(pname, param);
        }
        
        public static 
        unsafe void FragmentLightModelivSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, GLint* @params)
        {
            Delegates.glFragmentLightModelivSGIX(pname, @params);
        }
        
        public static 
        void FragmentMaterialfSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat param)
        {
            Delegates.glFragmentMaterialfSGIX(face, pname, param);
        }
        
        public static 
        unsafe void FragmentMaterialfvSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat* @params)
        {
            Delegates.glFragmentMaterialfvSGIX(face, pname, @params);
        }
        
        public static 
        void FragmentMaterialiSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint param)
        {
            Delegates.glFragmentMaterialiSGIX(face, pname, param);
        }
        
        public static 
        unsafe void FragmentMaterialivSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint* @params)
        {
            Delegates.glFragmentMaterialivSGIX(face, pname, @params);
        }
        
        public static 
        unsafe void GetFragmentLightfvSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLfloat* @params)
        {
            Delegates.glGetFragmentLightfvSGIX(light, pname, @params);
        }
        
        public static 
        unsafe void GetFragmentLightivSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLint* @params)
        {
            Delegates.glGetFragmentLightivSGIX(light, pname, @params);
        }
        
        public static 
        unsafe void GetFragmentMaterialfvSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat* @params)
        {
            Delegates.glGetFragmentMaterialfvSGIX(face, pname, @params);
        }
        
        public static 
        unsafe void GetFragmentMaterialivSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint* @params)
        {
            Delegates.glGetFragmentMaterialivSGIX(face, pname, @params);
        }
        
        public static 
        void LightEnviSGIX(GL.Enums.LightEnvParameterSGIX pname, GLint param)
        {
            Delegates.glLightEnviSGIX(pname, param);
        }
        
        public static 
        unsafe void DrawRangeElementsEXT(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count, GL.Enums.EXT_draw_range_elements type, void* indices)
        {
            Delegates.glDrawRangeElementsEXT(mode, start, end, count, type, indices);
        }
        
        public static 
        void ApplyTextureEXT(GL.Enums.EXT_light_texture mode)
        {
            Delegates.glApplyTextureEXT(mode);
        }
        
        public static 
        void TextureLightEXT(GL.Enums.EXT_light_texture pname)
        {
            Delegates.glTextureLightEXT(pname);
        }
        
        public static 
        void TextureMaterialEXT(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter mode)
        {
            Delegates.glTextureMaterialEXT(face, mode);
        }
        
        public static 
        void AsyncMarkerSGIX(GLuint marker)
        {
            Delegates.glAsyncMarkerSGIX(marker);
        }
        
        public static 
        unsafe GLint FinishAsyncSGIX(GLuint* markerp)
        {
            return Delegates.glFinishAsyncSGIX(markerp);
        }
        
        public static 
        unsafe GLint PollAsyncSGIX(GLuint* markerp)
        {
            return Delegates.glPollAsyncSGIX(markerp);
        }
        
        public static 
        GLuint GenAsyncMarkersSGIX(GLsizei range)
        {
            return Delegates.glGenAsyncMarkersSGIX(range);
        }
        
        public static 
        void DeleteAsyncMarkersSGIX(GLuint marker, GLsizei range)
        {
            Delegates.glDeleteAsyncMarkersSGIX(marker, range);
        }
        
        public static 
        GLboolean IsAsyncMarkerSGIX(GLuint marker)
        {
            return Delegates.glIsAsyncMarkerSGIX(marker);
        }
        
        public static 
        unsafe void VertexPointervINTEL(GLint size, GL.Enums.VertexPointerType type, void* pointer)
        {
            Delegates.glVertexPointervINTEL(size, type, pointer);
        }
        
        public static 
        unsafe void NormalPointervINTEL(GL.Enums.NormalPointerType type, void* pointer)
        {
            Delegates.glNormalPointervINTEL(type, pointer);
        }
        
        public static 
        unsafe void ColorPointervINTEL(GLint size, GL.Enums.VertexPointerType type, void* pointer)
        {
            Delegates.glColorPointervINTEL(size, type, pointer);
        }
        
        public static 
        unsafe void TexCoordPointervINTEL(GLint size, GL.Enums.VertexPointerType type, void* pointer)
        {
            Delegates.glTexCoordPointervINTEL(size, type, pointer);
        }
        
        public static 
        void PixelTransformParameteriEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, GLint param)
        {
            Delegates.glPixelTransformParameteriEXT(target, pname, param);
        }
        
        public static 
        void PixelTransformParameterfEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, GLfloat param)
        {
            Delegates.glPixelTransformParameterfEXT(target, pname, param);
        }
        
        public static 
        unsafe void PixelTransformParameterivEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, GLint* @params)
        {
            Delegates.glPixelTransformParameterivEXT(target, pname, @params);
        }
        
        public static 
        unsafe void PixelTransformParameterfvEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, GLfloat* @params)
        {
            Delegates.glPixelTransformParameterfvEXT(target, pname, @params);
        }
        
        public static 
        void SecondaryColor3bEXT(GLbyte red, GLbyte green, GLbyte blue)
        {
            Delegates.glSecondaryColor3bEXT(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3bvEXT(GLbyte* v)
        {
            Delegates.glSecondaryColor3bvEXT(v);
        }
        
        public static 
        void SecondaryColor3dEXT(GLdouble red, GLdouble green, GLdouble blue)
        {
            Delegates.glSecondaryColor3dEXT(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3dvEXT(GLdouble* v)
        {
            Delegates.glSecondaryColor3dvEXT(v);
        }
        
        public static 
        void SecondaryColor3fEXT(GLfloat red, GLfloat green, GLfloat blue)
        {
            Delegates.glSecondaryColor3fEXT(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3fvEXT(GLfloat* v)
        {
            Delegates.glSecondaryColor3fvEXT(v);
        }
        
        public static 
        void SecondaryColor3iEXT(GLint red, GLint green, GLint blue)
        {
            Delegates.glSecondaryColor3iEXT(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3ivEXT(GLint* v)
        {
            Delegates.glSecondaryColor3ivEXT(v);
        }
        
        public static 
        void SecondaryColor3sEXT(GLshort red, GLshort green, GLshort blue)
        {
            Delegates.glSecondaryColor3sEXT(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3svEXT(GLshort* v)
        {
            Delegates.glSecondaryColor3svEXT(v);
        }
        
        public static 
        void SecondaryColor3ubEXT(GLubyte red, GLubyte green, GLubyte blue)
        {
            Delegates.glSecondaryColor3ubEXT(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3ubvEXT(GLubyte* v)
        {
            Delegates.glSecondaryColor3ubvEXT(v);
        }
        
        public static 
        void SecondaryColor3uiEXT(GLuint red, GLuint green, GLuint blue)
        {
            Delegates.glSecondaryColor3uiEXT(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3uivEXT(GLuint* v)
        {
            Delegates.glSecondaryColor3uivEXT(v);
        }
        
        public static 
        void SecondaryColor3usEXT(GLushort red, GLushort green, GLushort blue)
        {
            Delegates.glSecondaryColor3usEXT(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3usvEXT(GLushort* v)
        {
            Delegates.glSecondaryColor3usvEXT(v);
        }
        
        public static 
        unsafe void SecondaryColorPointerEXT(GLint size, GL.Enums.ColorPointerType type, GLsizei stride, void* pointer)
        {
            Delegates.glSecondaryColorPointerEXT(size, type, stride, pointer);
        }
        
        public static 
        void TextureNormalEXT(GL.Enums.EXT_texture_perturb_normal mode)
        {
            Delegates.glTextureNormalEXT(mode);
        }
        
        public static 
        unsafe void MultiDrawArraysEXT(GL.Enums.BeginMode mode, GLint* first, GLsizei* count, GLsizei primcount)
        {
            Delegates.glMultiDrawArraysEXT(mode, first, count, primcount);
        }
        
        public static 
        unsafe void MultiDrawElementsEXT(GL.Enums.BeginMode mode, GLsizei* count, GL.Enums.EXT_multi_draw_arrays type, void* indices, GLsizei primcount)
        {
            Delegates.glMultiDrawElementsEXT(mode, count, type, indices, primcount);
        }
        
        public static 
        void FogCoordfEXT(GLfloat coord)
        {
            Delegates.glFogCoordfEXT(coord);
        }
        
        public static 
        unsafe void FogCoordfvEXT(GLfloat* coord)
        {
            Delegates.glFogCoordfvEXT(coord);
        }
        
        public static 
        void FogCoorddEXT(GLdouble coord)
        {
            Delegates.glFogCoorddEXT(coord);
        }
        
        public static 
        unsafe void FogCoorddvEXT(GLdouble* coord)
        {
            Delegates.glFogCoorddvEXT(coord);
        }
        
        public static 
        unsafe void FogCoordPointerEXT(GL.Enums.EXT_fog_coord type, GLsizei stride, void* pointer)
        {
            Delegates.glFogCoordPointerEXT(type, stride, pointer);
        }
        
        public static 
        void Tangent3bEXT(GLbyte tx, GLbyte ty, GLbyte tz)
        {
            Delegates.glTangent3bEXT(tx, ty, tz);
        }
        
        public static 
        unsafe void Tangent3bvEXT(GLbyte* v)
        {
            Delegates.glTangent3bvEXT(v);
        }
        
        public static 
        void Tangent3dEXT(GLdouble tx, GLdouble ty, GLdouble tz)
        {
            Delegates.glTangent3dEXT(tx, ty, tz);
        }
        
        public static 
        unsafe void Tangent3dvEXT(GLdouble* v)
        {
            Delegates.glTangent3dvEXT(v);
        }
        
        public static 
        void Tangent3fEXT(GLfloat tx, GLfloat ty, GLfloat tz)
        {
            Delegates.glTangent3fEXT(tx, ty, tz);
        }
        
        public static 
        unsafe void Tangent3fvEXT(GLfloat* v)
        {
            Delegates.glTangent3fvEXT(v);
        }
        
        public static 
        void Tangent3iEXT(GLint tx, GLint ty, GLint tz)
        {
            Delegates.glTangent3iEXT(tx, ty, tz);
        }
        
        public static 
        unsafe void Tangent3ivEXT(GLint* v)
        {
            Delegates.glTangent3ivEXT(v);
        }
        
        public static 
        void Tangent3sEXT(GLshort tx, GLshort ty, GLshort tz)
        {
            Delegates.glTangent3sEXT(tx, ty, tz);
        }
        
        public static 
        unsafe void Tangent3svEXT(GLshort* v)
        {
            Delegates.glTangent3svEXT(v);
        }
        
        public static 
        void Binormal3bEXT(GLbyte bx, GLbyte by, GLbyte bz)
        {
            Delegates.glBinormal3bEXT(bx, by, bz);
        }
        
        public static 
        unsafe void Binormal3bvEXT(GLbyte* v)
        {
            Delegates.glBinormal3bvEXT(v);
        }
        
        public static 
        void Binormal3dEXT(GLdouble bx, GLdouble by, GLdouble bz)
        {
            Delegates.glBinormal3dEXT(bx, by, bz);
        }
        
        public static 
        unsafe void Binormal3dvEXT(GLdouble* v)
        {
            Delegates.glBinormal3dvEXT(v);
        }
        
        public static 
        void Binormal3fEXT(GLfloat bx, GLfloat by, GLfloat bz)
        {
            Delegates.glBinormal3fEXT(bx, by, bz);
        }
        
        public static 
        unsafe void Binormal3fvEXT(GLfloat* v)
        {
            Delegates.glBinormal3fvEXT(v);
        }
        
        public static 
        void Binormal3iEXT(GLint bx, GLint by, GLint bz)
        {
            Delegates.glBinormal3iEXT(bx, by, bz);
        }
        
        public static 
        unsafe void Binormal3ivEXT(GLint* v)
        {
            Delegates.glBinormal3ivEXT(v);
        }
        
        public static 
        void Binormal3sEXT(GLshort bx, GLshort by, GLshort bz)
        {
            Delegates.glBinormal3sEXT(bx, by, bz);
        }
        
        public static 
        unsafe void Binormal3svEXT(GLshort* v)
        {
            Delegates.glBinormal3svEXT(v);
        }
        
        public static 
        unsafe void TangentPointerEXT(GL.Enums.EXT_coordinate_frame type, GLsizei stride, void* pointer)
        {
            Delegates.glTangentPointerEXT(type, stride, pointer);
        }
        
        public static 
        unsafe void BinormalPointerEXT(GL.Enums.EXT_coordinate_frame type, GLsizei stride, void* pointer)
        {
            Delegates.glBinormalPointerEXT(type, stride, pointer);
        }
        
        public static 
        void FinishTextureSUNX()
        {
            Delegates.glFinishTextureSUNX();
        }
        
        public static 
        void GlobalAlphaFactorbSUN(GLbyte factor)
        {
            Delegates.glGlobalAlphaFactorbSUN(factor);
        }
        
        public static 
        void GlobalAlphaFactorsSUN(GLshort factor)
        {
            Delegates.glGlobalAlphaFactorsSUN(factor);
        }
        
        public static 
        void GlobalAlphaFactoriSUN(GLint factor)
        {
            Delegates.glGlobalAlphaFactoriSUN(factor);
        }
        
        public static 
        void GlobalAlphaFactorfSUN(GLfloat factor)
        {
            Delegates.glGlobalAlphaFactorfSUN(factor);
        }
        
        public static 
        void GlobalAlphaFactordSUN(GLdouble factor)
        {
            Delegates.glGlobalAlphaFactordSUN(factor);
        }
        
        public static 
        void GlobalAlphaFactorubSUN(GLubyte factor)
        {
            Delegates.glGlobalAlphaFactorubSUN(factor);
        }
        
        public static 
        void GlobalAlphaFactorusSUN(GLushort factor)
        {
            Delegates.glGlobalAlphaFactorusSUN(factor);
        }
        
        public static 
        void GlobalAlphaFactoruiSUN(GLuint factor)
        {
            Delegates.glGlobalAlphaFactoruiSUN(factor);
        }
        
        public static 
        void ReplacementCodeuiSUN(GLuint code)
        {
            Delegates.glReplacementCodeuiSUN(code);
        }
        
        public static 
        void ReplacementCodeusSUN(GLushort code)
        {
            Delegates.glReplacementCodeusSUN(code);
        }
        
        public static 
        void ReplacementCodeubSUN(GLubyte code)
        {
            Delegates.glReplacementCodeubSUN(code);
        }
        
        public static 
        unsafe void ReplacementCodeuivSUN(GLuint* code)
        {
            Delegates.glReplacementCodeuivSUN(code);
        }
        
        public static 
        unsafe void ReplacementCodeusvSUN(GLushort* code)
        {
            Delegates.glReplacementCodeusvSUN(code);
        }
        
        public static 
        unsafe void ReplacementCodeubvSUN(GLubyte* code)
        {
            Delegates.glReplacementCodeubvSUN(code);
        }
        
        public static 
        unsafe void ReplacementCodePointerSUN(GL.Enums.SUN_triangle_list type, GLsizei stride, void* pointer)
        {
            Delegates.glReplacementCodePointerSUN(type, stride, pointer);
        }
        
        public static 
        void Color4ubVertex2fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y)
        {
            Delegates.glColor4ubVertex2fSUN(r, g, b, a, x, y);
        }
        
        public static 
        unsafe void Color4ubVertex2fvSUN(GLubyte* c, GLfloat* v)
        {
            Delegates.glColor4ubVertex2fvSUN(c, v);
        }
        
        public static 
        void Color4ubVertex3fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glColor4ubVertex3fSUN(r, g, b, a, x, y, z);
        }
        
        public static 
        unsafe void Color4ubVertex3fvSUN(GLubyte* c, GLfloat* v)
        {
            Delegates.glColor4ubVertex3fvSUN(c, v);
        }
        
        public static 
        void Color3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glColor3fVertex3fSUN(r, g, b, x, y, z);
        }
        
        public static 
        unsafe void Color3fVertex3fvSUN(GLfloat* c, GLfloat* v)
        {
            Delegates.glColor3fVertex3fvSUN(c, v);
        }
        
        public static 
        void Normal3fVertex3fSUN(GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glNormal3fVertex3fSUN(nx, ny, nz, x, y, z);
        }
        
        public static 
        unsafe void Normal3fVertex3fvSUN(GLfloat* n, GLfloat* v)
        {
            Delegates.glNormal3fVertex3fvSUN(n, v);
        }
        
        public static 
        void Color4fNormal3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glColor4fNormal3fVertex3fSUN(r, g, b, a, nx, ny, nz, x, y, z);
        }
        
        public static 
        unsafe void Color4fNormal3fVertex3fvSUN(GLfloat* c, GLfloat* n, GLfloat* v)
        {
            Delegates.glColor4fNormal3fVertex3fvSUN(c, n, v);
        }
        
        public static 
        void TexCoord2fVertex3fSUN(GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glTexCoord2fVertex3fSUN(s, t, x, y, z);
        }
        
        public static 
        unsafe void TexCoord2fVertex3fvSUN(GLfloat* tc, GLfloat* v)
        {
            Delegates.glTexCoord2fVertex3fvSUN(tc, v);
        }
        
        public static 
        void TexCoord4fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            Delegates.glTexCoord4fVertex4fSUN(s, t, p, q, x, y, z, w);
        }
        
        public static 
        unsafe void TexCoord4fVertex4fvSUN(GLfloat* tc, GLfloat* v)
        {
            Delegates.glTexCoord4fVertex4fvSUN(tc, v);
        }
        
        public static 
        void TexCoord2fColor4ubVertex3fSUN(GLfloat s, GLfloat t, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glTexCoord2fColor4ubVertex3fSUN(s, t, r, g, b, a, x, y, z);
        }
        
        public static 
        unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat* tc, GLubyte* c, GLfloat* v)
        {
            Delegates.glTexCoord2fColor4ubVertex3fvSUN(tc, c, v);
        }
        
        public static 
        void TexCoord2fColor3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glTexCoord2fColor3fVertex3fSUN(s, t, r, g, b, x, y, z);
        }
        
        public static 
        unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat* v)
        {
            Delegates.glTexCoord2fColor3fVertex3fvSUN(tc, c, v);
        }
        
        public static 
        void TexCoord2fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glTexCoord2fNormal3fVertex3fSUN(s, t, nx, ny, nz, x, y, z);
        }
        
        public static 
        unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* n, GLfloat* v)
        {
            Delegates.glTexCoord2fNormal3fVertex3fvSUN(tc, n, v);
        }
        
        public static 
        void TexCoord2fColor4fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glTexCoord2fColor4fNormal3fVertex3fSUN(s, t, r, g, b, a, nx, ny, nz, x, y, z);
        }
        
        public static 
        unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            Delegates.glTexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n, v);
        }
        
        public static 
        void TexCoord4fColor4fNormal3fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            Delegates.glTexCoord4fColor4fNormal3fVertex4fSUN(s, t, p, q, r, g, b, a, nx, ny, nz, x, y, z, w);
        }
        
        public static 
        unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            Delegates.glTexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n, v);
        }
        
        public static 
        void ReplacementCodeuiVertex3fSUN(GLuint rc, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glReplacementCodeuiVertex3fSUN(rc, x, y, z);
        }
        
        public static 
        unsafe void ReplacementCodeuiVertex3fvSUN(GLuint* rc, GLfloat* v)
        {
            Delegates.glReplacementCodeuiVertex3fvSUN(rc, v);
        }
        
        public static 
        void ReplacementCodeuiColor4ubVertex3fSUN(GLuint rc, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glReplacementCodeuiColor4ubVertex3fSUN(rc, r, g, b, a, x, y, z);
        }
        
        public static 
        unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint* rc, GLubyte* c, GLfloat* v)
        {
            Delegates.glReplacementCodeuiColor4ubVertex3fvSUN(rc, c, v);
        }
        
        public static 
        void ReplacementCodeuiColor3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glReplacementCodeuiColor3fVertex3fSUN(rc, r, g, b, x, y, z);
        }
        
        public static 
        unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat* v)
        {
            Delegates.glReplacementCodeuiColor3fVertex3fvSUN(rc, c, v);
        }
        
        public static 
        void ReplacementCodeuiNormal3fVertex3fSUN(GLuint rc, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glReplacementCodeuiNormal3fVertex3fSUN(rc, nx, ny, nz, x, y, z);
        }
        
        public static 
        unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint* rc, GLfloat* n, GLfloat* v)
        {
            Delegates.glReplacementCodeuiNormal3fVertex3fvSUN(rc, n, v);
        }
        
        public static 
        void ReplacementCodeuiColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glReplacementCodeuiColor4fNormal3fVertex3fSUN(rc, r, g, b, a, nx, ny, nz, x, y, z);
        }
        
        public static 
        unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            Delegates.glReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n, v);
        }
        
        public static 
        void ReplacementCodeuiTexCoord2fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glReplacementCodeuiTexCoord2fVertex3fSUN(rc, s, t, x, y, z);
        }
        
        public static 
        unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* v)
        {
            Delegates.glReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc, v);
        }
        
        public static 
        void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(rc, s, t, nx, ny, nz, x, y, z);
        }
        
        public static 
        unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* n, GLfloat* v)
        {
            Delegates.glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n, v);
        }
        
        public static 
        void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(rc, s, t, r, g, b, a, nx, ny, nz, x, y, z);
        }
        
        public static 
        unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            Delegates.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n, v);
        }
        
        public static 
        void BlendFuncSeparateEXT(GL.Enums.EXT_blend_func_separate sfactorRGB, GL.Enums.EXT_blend_func_separate dfactorRGB, GL.Enums.EXT_blend_func_separate sfactorAlpha, GL.Enums.EXT_blend_func_separate dfactorAlpha)
        {
            Delegates.glBlendFuncSeparateEXT(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        }
        
        public static 
        void BlendFuncSeparateINGR(GL.Enums.GLenum sfactorRGB, GL.Enums.GLenum dfactorRGB, GL.Enums.GLenum sfactorAlpha, GL.Enums.GLenum dfactorAlpha)
        {
            Delegates.glBlendFuncSeparateINGR(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        }
        
        public static 
        void VertexWeightfEXT(GLfloat weight)
        {
            Delegates.glVertexWeightfEXT(weight);
        }
        
        public static 
        unsafe void VertexWeightfvEXT(GLfloat* weight)
        {
            Delegates.glVertexWeightfvEXT(weight);
        }
        
        public static 
        unsafe void VertexWeightPointerEXT(GLsizei size, GL.Enums.EXT_vertex_weighting type, GLsizei stride, void* pointer)
        {
            Delegates.glVertexWeightPointerEXT(size, type, stride, pointer);
        }
        
        public static 
        void FlushVertexArrayRangeNV()
        {
            Delegates.glFlushVertexArrayRangeNV();
        }
        
        public static 
        unsafe void VertexArrayRangeNV(GLsizei length, void* pointer)
        {
            Delegates.glVertexArrayRangeNV(length, pointer);
        }
        
        public static 
        unsafe void CombinerParameterfvNV(GL.Enums.NV_register_combiners pname, GLfloat* @params)
        {
            Delegates.glCombinerParameterfvNV(pname, @params);
        }
        
        public static 
        void CombinerParameterfNV(GL.Enums.NV_register_combiners pname, GLfloat param)
        {
            Delegates.glCombinerParameterfNV(pname, param);
        }
        
        public static 
        unsafe void CombinerParameterivNV(GL.Enums.NV_register_combiners pname, GLint* @params)
        {
            Delegates.glCombinerParameterivNV(pname, @params);
        }
        
        public static 
        void CombinerParameteriNV(GL.Enums.NV_register_combiners pname, GLint param)
        {
            Delegates.glCombinerParameteriNV(pname, param);
        }
        
        public static 
        void CombinerInputNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners input, GL.Enums.NV_register_combiners mapping, GL.Enums.NV_register_combiners componentUsage)
        {
            Delegates.glCombinerInputNV(stage, portion, variable, input, mapping, componentUsage);
        }
        
        public static 
        void FinalCombinerInputNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners input, GL.Enums.NV_register_combiners mapping, GL.Enums.NV_register_combiners componentUsage)
        {
            Delegates.glFinalCombinerInputNV(variable, input, mapping, componentUsage);
        }
        
        public static 
        unsafe void GetCombinerInputParameterfvNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, GLfloat* @params)
        {
            Delegates.glGetCombinerInputParameterfvNV(stage, portion, variable, pname, @params);
        }
        
        public static 
        unsafe void GetCombinerInputParameterivNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, GLint* @params)
        {
            Delegates.glGetCombinerInputParameterivNV(stage, portion, variable, pname, @params);
        }
        
        public static 
        unsafe void GetCombinerOutputParameterfvNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners pname, GLfloat* @params)
        {
            Delegates.glGetCombinerOutputParameterfvNV(stage, portion, pname, @params);
        }
        
        public static 
        unsafe void GetCombinerOutputParameterivNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners pname, GLint* @params)
        {
            Delegates.glGetCombinerOutputParameterivNV(stage, portion, pname, @params);
        }
        
        public static 
        unsafe void GetFinalCombinerInputParameterfvNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, GLfloat* @params)
        {
            Delegates.glGetFinalCombinerInputParameterfvNV(variable, pname, @params);
        }
        
        public static 
        unsafe void GetFinalCombinerInputParameterivNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, GLint* @params)
        {
            Delegates.glGetFinalCombinerInputParameterivNV(variable, pname, @params);
        }
        
        public static 
        void ResizeBuffersMESA()
        {
            Delegates.glResizeBuffersMESA();
        }
        
        public static 
        void WindowPos2dMESA(GLdouble x, GLdouble y)
        {
            Delegates.glWindowPos2dMESA(x, y);
        }
        
        public static 
        unsafe void WindowPos2dvMESA(GLdouble* v)
        {
            Delegates.glWindowPos2dvMESA(v);
        }
        
        public static 
        void WindowPos2fMESA(GLfloat x, GLfloat y)
        {
            Delegates.glWindowPos2fMESA(x, y);
        }
        
        public static 
        unsafe void WindowPos2fvMESA(GLfloat* v)
        {
            Delegates.glWindowPos2fvMESA(v);
        }
        
        public static 
        void WindowPos2iMESA(GLint x, GLint y)
        {
            Delegates.glWindowPos2iMESA(x, y);
        }
        
        public static 
        unsafe void WindowPos2ivMESA(GLint* v)
        {
            Delegates.glWindowPos2ivMESA(v);
        }
        
        public static 
        void WindowPos2sMESA(GLshort x, GLshort y)
        {
            Delegates.glWindowPos2sMESA(x, y);
        }
        
        public static 
        unsafe void WindowPos2svMESA(GLshort* v)
        {
            Delegates.glWindowPos2svMESA(v);
        }
        
        public static 
        void WindowPos3dMESA(GLdouble x, GLdouble y, GLdouble z)
        {
            Delegates.glWindowPos3dMESA(x, y, z);
        }
        
        public static 
        unsafe void WindowPos3dvMESA(GLdouble* v)
        {
            Delegates.glWindowPos3dvMESA(v);
        }
        
        public static 
        void WindowPos3fMESA(GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glWindowPos3fMESA(x, y, z);
        }
        
        public static 
        unsafe void WindowPos3fvMESA(GLfloat* v)
        {
            Delegates.glWindowPos3fvMESA(v);
        }
        
        public static 
        void WindowPos3iMESA(GLint x, GLint y, GLint z)
        {
            Delegates.glWindowPos3iMESA(x, y, z);
        }
        
        public static 
        unsafe void WindowPos3ivMESA(GLint* v)
        {
            Delegates.glWindowPos3ivMESA(v);
        }
        
        public static 
        void WindowPos3sMESA(GLshort x, GLshort y, GLshort z)
        {
            Delegates.glWindowPos3sMESA(x, y, z);
        }
        
        public static 
        unsafe void WindowPos3svMESA(GLshort* v)
        {
            Delegates.glWindowPos3svMESA(v);
        }
        
        public static 
        void WindowPos4dMESA(GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            Delegates.glWindowPos4dMESA(x, y, z, w);
        }
        
        public static 
        unsafe void WindowPos4dvMESA(GLdouble* v)
        {
            Delegates.glWindowPos4dvMESA(v);
        }
        
        public static 
        void WindowPos4fMESA(GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            Delegates.glWindowPos4fMESA(x, y, z, w);
        }
        
        public static 
        unsafe void WindowPos4fvMESA(GLfloat* v)
        {
            Delegates.glWindowPos4fvMESA(v);
        }
        
        public static 
        void WindowPos4iMESA(GLint x, GLint y, GLint z, GLint w)
        {
            Delegates.glWindowPos4iMESA(x, y, z, w);
        }
        
        public static 
        unsafe void WindowPos4ivMESA(GLint* v)
        {
            Delegates.glWindowPos4ivMESA(v);
        }
        
        public static 
        void WindowPos4sMESA(GLshort x, GLshort y, GLshort z, GLshort w)
        {
            Delegates.glWindowPos4sMESA(x, y, z, w);
        }
        
        public static 
        unsafe void WindowPos4svMESA(GLshort* v)
        {
            Delegates.glWindowPos4svMESA(v);
        }
        
        public static 
        unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode* mode, GLint* first, GLsizei* count, GLsizei primcount, GLint modestride)
        {
            Delegates.glMultiModeDrawArraysIBM(mode, first, count, primcount, modestride);
        }
        
        public static 
        unsafe void MultiModeDrawElementsIBM(GL.Enums.BeginMode* mode, GLsizei* count, GL.Enums.IBM_multimode_draw_arrays type, void* indices, GLsizei primcount, GLint modestride)
        {
            Delegates.glMultiModeDrawElementsIBM(mode, count, type, indices, primcount, modestride);
        }
        
        public static 
        unsafe void ColorPointerListIBM(GLint size, GL.Enums.ColorPointerType type, GLint stride, void* pointer, GLint ptrstride)
        {
            Delegates.glColorPointerListIBM(size, type, stride, pointer, ptrstride);
        }
        
        public static 
        unsafe void SecondaryColorPointerListIBM(GLint size, GL.Enums.IBM_vertex_array_lists type, GLint stride, void* pointer, GLint ptrstride)
        {
            Delegates.glSecondaryColorPointerListIBM(size, type, stride, pointer, ptrstride);
        }
        
        public static 
        unsafe void EdgeFlagPointerListIBM(GLint stride, GLboolean* pointer, GLint ptrstride)
        {
            Delegates.glEdgeFlagPointerListIBM(stride, pointer, ptrstride);
        }
        
        public static 
        unsafe void FogCoordPointerListIBM(GL.Enums.IBM_vertex_array_lists type, GLint stride, void* pointer, GLint ptrstride)
        {
            Delegates.glFogCoordPointerListIBM(type, stride, pointer, ptrstride);
        }
        
        public static 
        unsafe void IndexPointerListIBM(GL.Enums.IndexPointerType type, GLint stride, void* pointer, GLint ptrstride)
        {
            Delegates.glIndexPointerListIBM(type, stride, pointer, ptrstride);
        }
        
        public static 
        unsafe void NormalPointerListIBM(GL.Enums.NormalPointerType type, GLint stride, void* pointer, GLint ptrstride)
        {
            Delegates.glNormalPointerListIBM(type, stride, pointer, ptrstride);
        }
        
        public static 
        unsafe void TexCoordPointerListIBM(GLint size, GL.Enums.TexCoordPointerType type, GLint stride, void* pointer, GLint ptrstride)
        {
            Delegates.glTexCoordPointerListIBM(size, type, stride, pointer, ptrstride);
        }
        
        public static 
        unsafe void VertexPointerListIBM(GLint size, GL.Enums.VertexPointerType type, GLint stride, void* pointer, GLint ptrstride)
        {
            Delegates.glVertexPointerListIBM(size, type, stride, pointer, ptrstride);
        }
        
        public static 
        void TbufferMask3DFX(GLuint mask)
        {
            Delegates.glTbufferMask3DFX(mask);
        }
        
        public static 
        void SamplePatternEXT(GL.Enums.EXT_multisample pattern)
        {
            Delegates.glSamplePatternEXT(pattern);
        }
        
        public static 
        unsafe void IglooInterfaceSGIX(GL.Enums.GLenum pname, void* @params)
        {
            Delegates.glIglooInterfaceSGIX(pname, @params);
        }
        
        public static 
        unsafe void DeleteFencesNV(GLsizei n, GLuint* fences)
        {
            Delegates.glDeleteFencesNV(n, fences);
        }
        
        public static 
        unsafe void GenFencesNV(GLsizei n, GLuint* fences)
        {
            Delegates.glGenFencesNV(n, fences);
        }
        
        public static 
        GLboolean IsFenceNV(GLuint fence)
        {
            return Delegates.glIsFenceNV(fence);
        }
        
        public static 
        GLboolean TestFenceNV(GLuint fence)
        {
            return Delegates.glTestFenceNV(fence);
        }
        
        public static 
        unsafe void GetFenceivNV(GLuint fence, GL.Enums.NV_fence pname, GLint* @params)
        {
            Delegates.glGetFenceivNV(fence, pname, @params);
        }
        
        public static 
        void FinishFenceNV(GLuint fence)
        {
            Delegates.glFinishFenceNV(fence);
        }
        
        public static 
        void SetFenceNV(GLuint fence, GL.Enums.NV_fence condition)
        {
            Delegates.glSetFenceNV(fence, condition);
        }
        
        public static 
        unsafe void MapControlPointsNV(GL.Enums.NV_evaluators target, GLuint index, GL.Enums.NV_evaluators type, GLsizei ustride, GLsizei vstride, GLint uorder, GLint vorder, GL.Enums.Boolean packed, void* points)
        {
            Delegates.glMapControlPointsNV(target, index, type, ustride, vstride, uorder, vorder, packed, points);
        }
        
        public static 
        unsafe void MapParameterivNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, GLint* @params)
        {
            Delegates.glMapParameterivNV(target, pname, @params);
        }
        
        public static 
        unsafe void MapParameterfvNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, GLfloat* @params)
        {
            Delegates.glMapParameterfvNV(target, pname, @params);
        }
        
        public static 
        unsafe void GetMapControlPointsNV(GL.Enums.NV_evaluators target, GLuint index, GL.Enums.NV_evaluators type, GLsizei ustride, GLsizei vstride, GL.Enums.Boolean packed, void* points)
        {
            Delegates.glGetMapControlPointsNV(target, index, type, ustride, vstride, packed, points);
        }
        
        public static 
        unsafe void GetMapParameterivNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, GLint* @params)
        {
            Delegates.glGetMapParameterivNV(target, pname, @params);
        }
        
        public static 
        unsafe void GetMapParameterfvNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, GLfloat* @params)
        {
            Delegates.glGetMapParameterfvNV(target, pname, @params);
        }
        
        public static 
        unsafe void GetMapAttribParameterivNV(GL.Enums.NV_evaluators target, GLuint index, GL.Enums.NV_evaluators pname, GLint* @params)
        {
            Delegates.glGetMapAttribParameterivNV(target, index, pname, @params);
        }
        
        public static 
        unsafe void GetMapAttribParameterfvNV(GL.Enums.NV_evaluators target, GLuint index, GL.Enums.NV_evaluators pname, GLfloat* @params)
        {
            Delegates.glGetMapAttribParameterfvNV(target, index, pname, @params);
        }
        
        public static 
        void EvalMapsNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators mode)
        {
            Delegates.glEvalMapsNV(target, mode);
        }
        
        public static 
        unsafe void CombinerStageParameterfvNV(GL.Enums.NV_register_combiners2 stage, GL.Enums.NV_register_combiners2 pname, GLfloat* @params)
        {
            Delegates.glCombinerStageParameterfvNV(stage, pname, @params);
        }
        
        public static 
        unsafe void GetCombinerStageParameterfvNV(GL.Enums.NV_register_combiners2 stage, GL.Enums.NV_register_combiners2 pname, GLfloat* @params)
        {
            Delegates.glGetCombinerStageParameterfvNV(stage, pname, @params);
        }
        
        public static 
        unsafe GLboolean AreProgramsResidentNV(GLsizei n, GLuint* programs, GL.Enums.Boolean* residences)
        {
            return Delegates.glAreProgramsResidentNV(n, programs, residences);
        }
        
        public static 
        void BindProgramNV(GL.Enums.NV_vertex_program target, GLuint id)
        {
            Delegates.glBindProgramNV(target, id);
        }
        
        public static 
        unsafe void DeleteProgramsNV(GLsizei n, GLuint* programs)
        {
            Delegates.glDeleteProgramsNV(n, programs);
        }
        
        public static 
        unsafe void ExecuteProgramNV(GL.Enums.NV_vertex_program target, GLuint id, GLfloat* @params)
        {
            Delegates.glExecuteProgramNV(target, id, @params);
        }
        
        public static 
        unsafe void GenProgramsNV(GLsizei n, GLuint* programs)
        {
            Delegates.glGenProgramsNV(n, programs);
        }
        
        public static 
        unsafe void GetProgramParameterdvNV(GL.Enums.NV_vertex_program target, GLuint index, GL.Enums.NV_vertex_program pname, GLdouble* @params)
        {
            Delegates.glGetProgramParameterdvNV(target, index, pname, @params);
        }
        
        public static 
        unsafe void GetProgramParameterfvNV(GL.Enums.NV_vertex_program target, GLuint index, GL.Enums.NV_vertex_program pname, GLfloat* @params)
        {
            Delegates.glGetProgramParameterfvNV(target, index, pname, @params);
        }
        
        public static 
        unsafe void GetProgramivNV(GLuint id, GL.Enums.NV_vertex_program pname, GLint* @params)
        {
            Delegates.glGetProgramivNV(id, pname, @params);
        }
        
        public static 
        unsafe void GetProgramStringNV(GLuint id, GL.Enums.NV_vertex_program pname, GLubyte* program)
        {
            Delegates.glGetProgramStringNV(id, pname, program);
        }
        
        public static 
        unsafe void GetTrackMatrixivNV(GL.Enums.NV_vertex_program target, GLuint address, GL.Enums.NV_vertex_program pname, GLint* @params)
        {
            Delegates.glGetTrackMatrixivNV(target, address, pname, @params);
        }
        
        public static 
        unsafe void GetVertexAttribdvNV(GLuint index, GL.Enums.NV_vertex_program pname, GLdouble* @params)
        {
            Delegates.glGetVertexAttribdvNV(index, pname, @params);
        }
        
        public static 
        unsafe void GetVertexAttribfvNV(GLuint index, GL.Enums.NV_vertex_program pname, GLfloat* @params)
        {
            Delegates.glGetVertexAttribfvNV(index, pname, @params);
        }
        
        public static 
        unsafe void GetVertexAttribivNV(GLuint index, GL.Enums.NV_vertex_program pname, GLint* @params)
        {
            Delegates.glGetVertexAttribivNV(index, pname, @params);
        }
        
        public static 
        unsafe void GetVertexAttribPointervNV(GLuint index, GL.Enums.NV_vertex_program pname, void* pointer)
        {
            Delegates.glGetVertexAttribPointervNV(index, pname, pointer);
        }
        
        public static 
        GLboolean IsProgramNV(GLuint id)
        {
            return Delegates.glIsProgramNV(id);
        }
        
        public static 
        unsafe void LoadProgramNV(GL.Enums.NV_vertex_program target, GLuint id, GLsizei len, GLubyte* program)
        {
            Delegates.glLoadProgramNV(target, id, len, program);
        }
        
        public static 
        void ProgramParameter4dNV(GL.Enums.NV_vertex_program target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            Delegates.glProgramParameter4dNV(target, index, x, y, z, w);
        }
        
        public static 
        unsafe void ProgramParameter4dvNV(GL.Enums.NV_vertex_program target, GLuint index, GLdouble* v)
        {
            Delegates.glProgramParameter4dvNV(target, index, v);
        }
        
        public static 
        void ProgramParameter4fNV(GL.Enums.NV_vertex_program target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            Delegates.glProgramParameter4fNV(target, index, x, y, z, w);
        }
        
        public static 
        unsafe void ProgramParameter4fvNV(GL.Enums.NV_vertex_program target, GLuint index, GLfloat* v)
        {
            Delegates.glProgramParameter4fvNV(target, index, v);
        }
        
        public static 
        unsafe void ProgramParameters4dvNV(GL.Enums.NV_vertex_program target, GLuint index, GLuint count, GLdouble* v)
        {
            Delegates.glProgramParameters4dvNV(target, index, count, v);
        }
        
        public static 
        unsafe void ProgramParameters4fvNV(GL.Enums.NV_vertex_program target, GLuint index, GLuint count, GLfloat* v)
        {
            Delegates.glProgramParameters4fvNV(target, index, count, v);
        }
        
        public static 
        unsafe void RequestResidentProgramsNV(GLsizei n, GLuint* programs)
        {
            Delegates.glRequestResidentProgramsNV(n, programs);
        }
        
        public static 
        void TrackMatrixNV(GL.Enums.NV_vertex_program target, GLuint address, GL.Enums.NV_vertex_program matrix, GL.Enums.NV_vertex_program transform)
        {
            Delegates.glTrackMatrixNV(target, address, matrix, transform);
        }
        
        public static 
        unsafe void VertexAttribPointerNV(GLuint index, GLint fsize, GL.Enums.NV_vertex_program type, GLsizei stride, void* pointer)
        {
            Delegates.glVertexAttribPointerNV(index, fsize, type, stride, pointer);
        }
        
        public static 
        void VertexAttrib1dNV(GLuint index, GLdouble x)
        {
            Delegates.glVertexAttrib1dNV(index, x);
        }
        
        public static 
        unsafe void VertexAttrib1dvNV(GLuint index, GLdouble* v)
        {
            Delegates.glVertexAttrib1dvNV(index, v);
        }
        
        public static 
        void VertexAttrib1fNV(GLuint index, GLfloat x)
        {
            Delegates.glVertexAttrib1fNV(index, x);
        }
        
        public static 
        unsafe void VertexAttrib1fvNV(GLuint index, GLfloat* v)
        {
            Delegates.glVertexAttrib1fvNV(index, v);
        }
        
        public static 
        void VertexAttrib1sNV(GLuint index, GLshort x)
        {
            Delegates.glVertexAttrib1sNV(index, x);
        }
        
        public static 
        unsafe void VertexAttrib1svNV(GLuint index, GLshort* v)
        {
            Delegates.glVertexAttrib1svNV(index, v);
        }
        
        public static 
        void VertexAttrib2dNV(GLuint index, GLdouble x, GLdouble y)
        {
            Delegates.glVertexAttrib2dNV(index, x, y);
        }
        
        public static 
        unsafe void VertexAttrib2dvNV(GLuint index, GLdouble* v)
        {
            Delegates.glVertexAttrib2dvNV(index, v);
        }
        
        public static 
        void VertexAttrib2fNV(GLuint index, GLfloat x, GLfloat y)
        {
            Delegates.glVertexAttrib2fNV(index, x, y);
        }
        
        public static 
        unsafe void VertexAttrib2fvNV(GLuint index, GLfloat* v)
        {
            Delegates.glVertexAttrib2fvNV(index, v);
        }
        
        public static 
        void VertexAttrib2sNV(GLuint index, GLshort x, GLshort y)
        {
            Delegates.glVertexAttrib2sNV(index, x, y);
        }
        
        public static 
        unsafe void VertexAttrib2svNV(GLuint index, GLshort* v)
        {
            Delegates.glVertexAttrib2svNV(index, v);
        }
        
        public static 
        void VertexAttrib3dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z)
        {
            Delegates.glVertexAttrib3dNV(index, x, y, z);
        }
        
        public static 
        unsafe void VertexAttrib3dvNV(GLuint index, GLdouble* v)
        {
            Delegates.glVertexAttrib3dvNV(index, v);
        }
        
        public static 
        void VertexAttrib3fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glVertexAttrib3fNV(index, x, y, z);
        }
        
        public static 
        unsafe void VertexAttrib3fvNV(GLuint index, GLfloat* v)
        {
            Delegates.glVertexAttrib3fvNV(index, v);
        }
        
        public static 
        void VertexAttrib3sNV(GLuint index, GLshort x, GLshort y, GLshort z)
        {
            Delegates.glVertexAttrib3sNV(index, x, y, z);
        }
        
        public static 
        unsafe void VertexAttrib3svNV(GLuint index, GLshort* v)
        {
            Delegates.glVertexAttrib3svNV(index, v);
        }
        
        public static 
        void VertexAttrib4dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            Delegates.glVertexAttrib4dNV(index, x, y, z, w);
        }
        
        public static 
        unsafe void VertexAttrib4dvNV(GLuint index, GLdouble* v)
        {
            Delegates.glVertexAttrib4dvNV(index, v);
        }
        
        public static 
        void VertexAttrib4fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            Delegates.glVertexAttrib4fNV(index, x, y, z, w);
        }
        
        public static 
        unsafe void VertexAttrib4fvNV(GLuint index, GLfloat* v)
        {
            Delegates.glVertexAttrib4fvNV(index, v);
        }
        
        public static 
        void VertexAttrib4sNV(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)
        {
            Delegates.glVertexAttrib4sNV(index, x, y, z, w);
        }
        
        public static 
        unsafe void VertexAttrib4svNV(GLuint index, GLshort* v)
        {
            Delegates.glVertexAttrib4svNV(index, v);
        }
        
        public static 
        void VertexAttrib4ubNV(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)
        {
            Delegates.glVertexAttrib4ubNV(index, x, y, z, w);
        }
        
        public static 
        unsafe void VertexAttrib4ubvNV(GLuint index, GLubyte* v)
        {
            Delegates.glVertexAttrib4ubvNV(index, v);
        }
        
        public static 
        unsafe void VertexAttribs1dvNV(GLuint index, GLsizei count, GLdouble* v)
        {
            Delegates.glVertexAttribs1dvNV(index, count, v);
        }
        
        public static 
        unsafe void VertexAttribs1fvNV(GLuint index, GLsizei count, GLfloat* v)
        {
            Delegates.glVertexAttribs1fvNV(index, count, v);
        }
        
        public static 
        unsafe void VertexAttribs1svNV(GLuint index, GLsizei count, GLshort* v)
        {
            Delegates.glVertexAttribs1svNV(index, count, v);
        }
        
        public static 
        unsafe void VertexAttribs2dvNV(GLuint index, GLsizei count, GLdouble* v)
        {
            Delegates.glVertexAttribs2dvNV(index, count, v);
        }
        
        public static 
        unsafe void VertexAttribs2fvNV(GLuint index, GLsizei count, GLfloat* v)
        {
            Delegates.glVertexAttribs2fvNV(index, count, v);
        }
        
        public static 
        unsafe void VertexAttribs2svNV(GLuint index, GLsizei count, GLshort* v)
        {
            Delegates.glVertexAttribs2svNV(index, count, v);
        }
        
        public static 
        unsafe void VertexAttribs3dvNV(GLuint index, GLsizei count, GLdouble* v)
        {
            Delegates.glVertexAttribs3dvNV(index, count, v);
        }
        
        public static 
        unsafe void VertexAttribs3fvNV(GLuint index, GLsizei count, GLfloat* v)
        {
            Delegates.glVertexAttribs3fvNV(index, count, v);
        }
        
        public static 
        unsafe void VertexAttribs3svNV(GLuint index, GLsizei count, GLshort* v)
        {
            Delegates.glVertexAttribs3svNV(index, count, v);
        }
        
        public static 
        unsafe void VertexAttribs4dvNV(GLuint index, GLsizei count, GLdouble* v)
        {
            Delegates.glVertexAttribs4dvNV(index, count, v);
        }
        
        public static 
        unsafe void VertexAttribs4fvNV(GLuint index, GLsizei count, GLfloat* v)
        {
            Delegates.glVertexAttribs4fvNV(index, count, v);
        }
        
        public static 
        unsafe void VertexAttribs4svNV(GLuint index, GLsizei count, GLshort* v)
        {
            Delegates.glVertexAttribs4svNV(index, count, v);
        }
        
        public static 
        unsafe void VertexAttribs4ubvNV(GLuint index, GLsizei count, GLubyte* v)
        {
            Delegates.glVertexAttribs4ubvNV(index, count, v);
        }
        
        public static 
        unsafe void TexBumpParameterivATI(GL.Enums.ATI_envmap_bumpmap pname, GLint* param)
        {
            Delegates.glTexBumpParameterivATI(pname, param);
        }
        
        public static 
        unsafe void TexBumpParameterfvATI(GL.Enums.ATI_envmap_bumpmap pname, GLfloat* param)
        {
            Delegates.glTexBumpParameterfvATI(pname, param);
        }
        
        public static 
        unsafe void GetTexBumpParameterivATI(GL.Enums.ATI_envmap_bumpmap pname, GLint* param)
        {
            Delegates.glGetTexBumpParameterivATI(pname, param);
        }
        
        public static 
        unsafe void GetTexBumpParameterfvATI(GL.Enums.ATI_envmap_bumpmap pname, GLfloat* param)
        {
            Delegates.glGetTexBumpParameterfvATI(pname, param);
        }
        
        public static 
        GLuint GenFragmentShadersATI(GLuint range)
        {
            return Delegates.glGenFragmentShadersATI(range);
        }
        
        public static 
        void BindFragmentShaderATI(GLuint id)
        {
            Delegates.glBindFragmentShaderATI(id);
        }
        
        public static 
        void DeleteFragmentShaderATI(GLuint id)
        {
            Delegates.glDeleteFragmentShaderATI(id);
        }
        
        public static 
        void BeginFragmentShaderATI()
        {
            Delegates.glBeginFragmentShaderATI();
        }
        
        public static 
        void EndFragmentShaderATI()
        {
            Delegates.glEndFragmentShaderATI();
        }
        
        public static 
        void PassTexCoordATI(GLuint dst, GLuint coord, GL.Enums.ATI_fragment_shader swizzle)
        {
            Delegates.glPassTexCoordATI(dst, coord, swizzle);
        }
        
        public static 
        void SampleMapATI(GLuint dst, GLuint interp, GL.Enums.ATI_fragment_shader swizzle)
        {
            Delegates.glSampleMapATI(dst, interp, swizzle);
        }
        
        public static 
        void ColorFragmentOp1ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod)
        {
            Delegates.glColorFragmentOp1ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod);
        }
        
        public static 
        void ColorFragmentOp2ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod)
        {
            Delegates.glColorFragmentOp2ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
        }
        
        public static 
        void ColorFragmentOp3ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod)
        {
            Delegates.glColorFragmentOp3ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
        }
        
        public static 
        void AlphaFragmentOp1ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod)
        {
            Delegates.glAlphaFragmentOp1ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod);
        }
        
        public static 
        void AlphaFragmentOp2ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod)
        {
            Delegates.glAlphaFragmentOp2ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
        }
        
        public static 
        void AlphaFragmentOp3ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod)
        {
            Delegates.glAlphaFragmentOp3ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
        }
        
        public static 
        unsafe void SetFragmentShaderConstantATI(GLuint dst, GLfloat* value)
        {
            Delegates.glSetFragmentShaderConstantATI(dst, value);
        }
        
        public static 
        void PNTrianglesiATI(GL.Enums.ATI_pn_triangles pname, GLint param)
        {
            Delegates.glPNTrianglesiATI(pname, param);
        }
        
        public static 
        void PNTrianglesfATI(GL.Enums.ATI_pn_triangles pname, GLfloat param)
        {
            Delegates.glPNTrianglesfATI(pname, param);
        }
        
        public static 
        unsafe GLuint NewObjectBufferATI(GLsizei size, void* pointer, GL.Enums.ATI_vertex_array_object usage)
        {
            return Delegates.glNewObjectBufferATI(size, pointer, usage);
        }
        
        public static 
        GLboolean IsObjectBufferATI(GLuint buffer)
        {
            return Delegates.glIsObjectBufferATI(buffer);
        }
        
        public static 
        unsafe void UpdateObjectBufferATI(GLuint buffer, GLuint offset, GLsizei size, void* pointer, GL.Enums.ATI_vertex_array_object preserve)
        {
            Delegates.glUpdateObjectBufferATI(buffer, offset, size, pointer, preserve);
        }
        
        public static 
        unsafe void GetObjectBufferfvATI(GLuint buffer, GL.Enums.ATI_vertex_array_object pname, GLfloat* @params)
        {
            Delegates.glGetObjectBufferfvATI(buffer, pname, @params);
        }
        
        public static 
        unsafe void GetObjectBufferivATI(GLuint buffer, GL.Enums.ATI_vertex_array_object pname, GLint* @params)
        {
            Delegates.glGetObjectBufferivATI(buffer, pname, @params);
        }
        
        public static 
        void FreeObjectBufferATI(GLuint buffer)
        {
            Delegates.glFreeObjectBufferATI(buffer);
        }
        
        public static 
        void ArrayObjectATI(GL.Enums.EnableCap array, GLint size, GL.Enums.ATI_vertex_array_object type, GLsizei stride, GLuint buffer, GLuint offset)
        {
            Delegates.glArrayObjectATI(array, size, type, stride, buffer, offset);
        }
        
        public static 
        unsafe void GetArrayObjectfvATI(GL.Enums.EnableCap array, GL.Enums.ATI_vertex_array_object pname, GLfloat* @params)
        {
            Delegates.glGetArrayObjectfvATI(array, pname, @params);
        }
        
        public static 
        unsafe void GetArrayObjectivATI(GL.Enums.EnableCap array, GL.Enums.ATI_vertex_array_object pname, GLint* @params)
        {
            Delegates.glGetArrayObjectivATI(array, pname, @params);
        }
        
        public static 
        void VariantArrayObjectATI(GLuint id, GL.Enums.ATI_vertex_array_object type, GLsizei stride, GLuint buffer, GLuint offset)
        {
            Delegates.glVariantArrayObjectATI(id, type, stride, buffer, offset);
        }
        
        public static 
        unsafe void GetVariantArrayObjectfvATI(GLuint id, GL.Enums.ATI_vertex_array_object pname, GLfloat* @params)
        {
            Delegates.glGetVariantArrayObjectfvATI(id, pname, @params);
        }
        
        public static 
        unsafe void GetVariantArrayObjectivATI(GLuint id, GL.Enums.ATI_vertex_array_object pname, GLint* @params)
        {
            Delegates.glGetVariantArrayObjectivATI(id, pname, @params);
        }
        
        public static 
        void BeginVertexShaderEXT()
        {
            Delegates.glBeginVertexShaderEXT();
        }
        
        public static 
        void EndVertexShaderEXT()
        {
            Delegates.glEndVertexShaderEXT();
        }
        
        public static 
        void BindVertexShaderEXT(GLuint id)
        {
            Delegates.glBindVertexShaderEXT(id);
        }
        
        public static 
        GLuint GenVertexShadersEXT(GLuint range)
        {
            return Delegates.glGenVertexShadersEXT(range);
        }
        
        public static 
        void DeleteVertexShaderEXT(GLuint id)
        {
            Delegates.glDeleteVertexShaderEXT(id);
        }
        
        public static 
        void ShaderOp1EXT(GL.Enums.EXT_vertex_shader op, GLuint res, GLuint arg1)
        {
            Delegates.glShaderOp1EXT(op, res, arg1);
        }
        
        public static 
        void ShaderOp2EXT(GL.Enums.EXT_vertex_shader op, GLuint res, GLuint arg1, GLuint arg2)
        {
            Delegates.glShaderOp2EXT(op, res, arg1, arg2);
        }
        
        public static 
        void ShaderOp3EXT(GL.Enums.EXT_vertex_shader op, GLuint res, GLuint arg1, GLuint arg2, GLuint arg3)
        {
            Delegates.glShaderOp3EXT(op, res, arg1, arg2, arg3);
        }
        
        public static 
        void SwizzleEXT(GLuint res, GLuint @in, GL.Enums.EXT_vertex_shader outX, GL.Enums.EXT_vertex_shader outY, GL.Enums.EXT_vertex_shader outZ, GL.Enums.EXT_vertex_shader outW)
        {
            Delegates.glSwizzleEXT(res, @in, outX, outY, outZ, outW);
        }
        
        public static 
        void WriteMaskEXT(GLuint res, GLuint @in, GL.Enums.EXT_vertex_shader outX, GL.Enums.EXT_vertex_shader outY, GL.Enums.EXT_vertex_shader outZ, GL.Enums.EXT_vertex_shader outW)
        {
            Delegates.glWriteMaskEXT(res, @in, outX, outY, outZ, outW);
        }
        
        public static 
        void InsertComponentEXT(GLuint res, GLuint src, GLuint num)
        {
            Delegates.glInsertComponentEXT(res, src, num);
        }
        
        public static 
        void ExtractComponentEXT(GLuint res, GLuint src, GLuint num)
        {
            Delegates.glExtractComponentEXT(res, src, num);
        }
        
        public static 
        GLuint GenSymbolsEXT(GL.Enums.EXT_vertex_shader datatype, GL.Enums.EXT_vertex_shader storagetype, GL.Enums.EXT_vertex_shader range, GLuint components)
        {
            return Delegates.glGenSymbolsEXT(datatype, storagetype, range, components);
        }
        
        public static 
        unsafe void SetInvariantEXT(GLuint id, GL.Enums.EXT_vertex_shader type, void* addr)
        {
            Delegates.glSetInvariantEXT(id, type, addr);
        }
        
        public static 
        unsafe void SetLocalConstantEXT(GLuint id, GL.Enums.EXT_vertex_shader type, void* addr)
        {
            Delegates.glSetLocalConstantEXT(id, type, addr);
        }
        
        public static 
        unsafe void VariantbvEXT(GLuint id, GLbyte* addr)
        {
            Delegates.glVariantbvEXT(id, addr);
        }
        
        public static 
        unsafe void VariantsvEXT(GLuint id, GLshort* addr)
        {
            Delegates.glVariantsvEXT(id, addr);
        }
        
        public static 
        unsafe void VariantivEXT(GLuint id, GLint* addr)
        {
            Delegates.glVariantivEXT(id, addr);
        }
        
        public static 
        unsafe void VariantfvEXT(GLuint id, GLfloat* addr)
        {
            Delegates.glVariantfvEXT(id, addr);
        }
        
        public static 
        unsafe void VariantdvEXT(GLuint id, GLdouble* addr)
        {
            Delegates.glVariantdvEXT(id, addr);
        }
        
        public static 
        unsafe void VariantubvEXT(GLuint id, GLubyte* addr)
        {
            Delegates.glVariantubvEXT(id, addr);
        }
        
        public static 
        unsafe void VariantusvEXT(GLuint id, GLushort* addr)
        {
            Delegates.glVariantusvEXT(id, addr);
        }
        
        public static 
        unsafe void VariantuivEXT(GLuint id, GLuint* addr)
        {
            Delegates.glVariantuivEXT(id, addr);
        }
        
        public static 
        unsafe void VariantPointerEXT(GLuint id, GL.Enums.EXT_vertex_shader type, GLuint stride, void* addr)
        {
            Delegates.glVariantPointerEXT(id, type, stride, addr);
        }
        
        public static 
        void EnableVariantClientStateEXT(GLuint id)
        {
            Delegates.glEnableVariantClientStateEXT(id);
        }
        
        public static 
        void DisableVariantClientStateEXT(GLuint id)
        {
            Delegates.glDisableVariantClientStateEXT(id);
        }
        
        public static 
        GLuint BindLightParameterEXT(GL.Enums.LightName light, GL.Enums.LightParameter value)
        {
            return Delegates.glBindLightParameterEXT(light, value);
        }
        
        public static 
        GLuint BindMaterialParameterEXT(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter value)
        {
            return Delegates.glBindMaterialParameterEXT(face, value);
        }
        
        public static 
        GLuint BindTexGenParameterEXT(GL.Enums.EXT_vertex_shader unit, GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter value)
        {
            return Delegates.glBindTexGenParameterEXT(unit, coord, value);
        }
        
        public static 
        GLuint BindTextureUnitParameterEXT(GL.Enums.EXT_vertex_shader unit, GL.Enums.EXT_vertex_shader value)
        {
            return Delegates.glBindTextureUnitParameterEXT(unit, value);
        }
        
        public static 
        GLuint BindParameterEXT(GL.Enums.EXT_vertex_shader value)
        {
            return Delegates.glBindParameterEXT(value);
        }
        
        public static 
        GLboolean IsVariantEnabledEXT(GLuint id, GL.Enums.EXT_vertex_shader cap)
        {
            return Delegates.glIsVariantEnabledEXT(id, cap);
        }
        
        public static 
        unsafe void GetVariantBooleanvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GL.Enums.Boolean* data)
        {
            Delegates.glGetVariantBooleanvEXT(id, value, data);
        }
        
        public static 
        unsafe void GetVariantIntegervEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLint* data)
        {
            Delegates.glGetVariantIntegervEXT(id, value, data);
        }
        
        public static 
        unsafe void GetVariantFloatvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLfloat* data)
        {
            Delegates.glGetVariantFloatvEXT(id, value, data);
        }
        
        public static 
        unsafe void GetVariantPointervEXT(GLuint id, GL.Enums.EXT_vertex_shader value, void* data)
        {
            Delegates.glGetVariantPointervEXT(id, value, data);
        }
        
        public static 
        unsafe void GetInvariantBooleanvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GL.Enums.Boolean* data)
        {
            Delegates.glGetInvariantBooleanvEXT(id, value, data);
        }
        
        public static 
        unsafe void GetInvariantIntegervEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLint* data)
        {
            Delegates.glGetInvariantIntegervEXT(id, value, data);
        }
        
        public static 
        unsafe void GetInvariantFloatvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLfloat* data)
        {
            Delegates.glGetInvariantFloatvEXT(id, value, data);
        }
        
        public static 
        unsafe void GetLocalConstantBooleanvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GL.Enums.Boolean* data)
        {
            Delegates.glGetLocalConstantBooleanvEXT(id, value, data);
        }
        
        public static 
        unsafe void GetLocalConstantIntegervEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLint* data)
        {
            Delegates.glGetLocalConstantIntegervEXT(id, value, data);
        }
        
        public static 
        unsafe void GetLocalConstantFloatvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLfloat* data)
        {
            Delegates.glGetLocalConstantFloatvEXT(id, value, data);
        }
        
        public static 
        void VertexStream1sATI(GL.Enums.ATI_vertex_streams stream, GLshort x)
        {
            Delegates.glVertexStream1sATI(stream, x);
        }
        
        public static 
        unsafe void VertexStream1svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords)
        {
            Delegates.glVertexStream1svATI(stream, coords);
        }
        
        public static 
        void VertexStream1iATI(GL.Enums.ATI_vertex_streams stream, GLint x)
        {
            Delegates.glVertexStream1iATI(stream, x);
        }
        
        public static 
        unsafe void VertexStream1ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords)
        {
            Delegates.glVertexStream1ivATI(stream, coords);
        }
        
        public static 
        void VertexStream1fATI(GL.Enums.ATI_vertex_streams stream, GLfloat x)
        {
            Delegates.glVertexStream1fATI(stream, x);
        }
        
        public static 
        unsafe void VertexStream1fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords)
        {
            Delegates.glVertexStream1fvATI(stream, coords);
        }
        
        public static 
        void VertexStream1dATI(GL.Enums.ATI_vertex_streams stream, GLdouble x)
        {
            Delegates.glVertexStream1dATI(stream, x);
        }
        
        public static 
        unsafe void VertexStream1dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords)
        {
            Delegates.glVertexStream1dvATI(stream, coords);
        }
        
        public static 
        void VertexStream2sATI(GL.Enums.ATI_vertex_streams stream, GLshort x, GLshort y)
        {
            Delegates.glVertexStream2sATI(stream, x, y);
        }
        
        public static 
        unsafe void VertexStream2svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords)
        {
            Delegates.glVertexStream2svATI(stream, coords);
        }
        
        public static 
        void VertexStream2iATI(GL.Enums.ATI_vertex_streams stream, GLint x, GLint y)
        {
            Delegates.glVertexStream2iATI(stream, x, y);
        }
        
        public static 
        unsafe void VertexStream2ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords)
        {
            Delegates.glVertexStream2ivATI(stream, coords);
        }
        
        public static 
        void VertexStream2fATI(GL.Enums.ATI_vertex_streams stream, GLfloat x, GLfloat y)
        {
            Delegates.glVertexStream2fATI(stream, x, y);
        }
        
        public static 
        unsafe void VertexStream2fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords)
        {
            Delegates.glVertexStream2fvATI(stream, coords);
        }
        
        public static 
        void VertexStream2dATI(GL.Enums.ATI_vertex_streams stream, GLdouble x, GLdouble y)
        {
            Delegates.glVertexStream2dATI(stream, x, y);
        }
        
        public static 
        unsafe void VertexStream2dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords)
        {
            Delegates.glVertexStream2dvATI(stream, coords);
        }
        
        public static 
        void VertexStream3sATI(GL.Enums.ATI_vertex_streams stream, GLshort x, GLshort y, GLshort z)
        {
            Delegates.glVertexStream3sATI(stream, x, y, z);
        }
        
        public static 
        unsafe void VertexStream3svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords)
        {
            Delegates.glVertexStream3svATI(stream, coords);
        }
        
        public static 
        void VertexStream3iATI(GL.Enums.ATI_vertex_streams stream, GLint x, GLint y, GLint z)
        {
            Delegates.glVertexStream3iATI(stream, x, y, z);
        }
        
        public static 
        unsafe void VertexStream3ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords)
        {
            Delegates.glVertexStream3ivATI(stream, coords);
        }
        
        public static 
        void VertexStream3fATI(GL.Enums.ATI_vertex_streams stream, GLfloat x, GLfloat y, GLfloat z)
        {
            Delegates.glVertexStream3fATI(stream, x, y, z);
        }
        
        public static 
        unsafe void VertexStream3fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords)
        {
            Delegates.glVertexStream3fvATI(stream, coords);
        }
        
        public static 
        void VertexStream3dATI(GL.Enums.ATI_vertex_streams stream, GLdouble x, GLdouble y, GLdouble z)
        {
            Delegates.glVertexStream3dATI(stream, x, y, z);
        }
        
        public static 
        unsafe void VertexStream3dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords)
        {
            Delegates.glVertexStream3dvATI(stream, coords);
        }
        
        public static 
        void VertexStream4sATI(GL.Enums.ATI_vertex_streams stream, GLshort x, GLshort y, GLshort z, GLshort w)
        {
            Delegates.glVertexStream4sATI(stream, x, y, z, w);
        }
        
        public static 
        unsafe void VertexStream4svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords)
        {
            Delegates.glVertexStream4svATI(stream, coords);
        }
        
        public static 
        void VertexStream4iATI(GL.Enums.ATI_vertex_streams stream, GLint x, GLint y, GLint z, GLint w)
        {
            Delegates.glVertexStream4iATI(stream, x, y, z, w);
        }
        
        public static 
        unsafe void VertexStream4ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords)
        {
            Delegates.glVertexStream4ivATI(stream, coords);
        }
        
        public static 
        void VertexStream4fATI(GL.Enums.ATI_vertex_streams stream, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            Delegates.glVertexStream4fATI(stream, x, y, z, w);
        }
        
        public static 
        unsafe void VertexStream4fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords)
        {
            Delegates.glVertexStream4fvATI(stream, coords);
        }
        
        public static 
        void VertexStream4dATI(GL.Enums.ATI_vertex_streams stream, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            Delegates.glVertexStream4dATI(stream, x, y, z, w);
        }
        
        public static 
        unsafe void VertexStream4dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords)
        {
            Delegates.glVertexStream4dvATI(stream, coords);
        }
        
        public static 
        void NormalStream3bATI(GL.Enums.ATI_vertex_streams stream, GLbyte nx, GLbyte ny, GLbyte nz)
        {
            Delegates.glNormalStream3bATI(stream, nx, ny, nz);
        }
        
        public static 
        unsafe void NormalStream3bvATI(GL.Enums.ATI_vertex_streams stream, GLbyte* coords)
        {
            Delegates.glNormalStream3bvATI(stream, coords);
        }
        
        public static 
        void NormalStream3sATI(GL.Enums.ATI_vertex_streams stream, GLshort nx, GLshort ny, GLshort nz)
        {
            Delegates.glNormalStream3sATI(stream, nx, ny, nz);
        }
        
        public static 
        unsafe void NormalStream3svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords)
        {
            Delegates.glNormalStream3svATI(stream, coords);
        }
        
        public static 
        void NormalStream3iATI(GL.Enums.ATI_vertex_streams stream, GLint nx, GLint ny, GLint nz)
        {
            Delegates.glNormalStream3iATI(stream, nx, ny, nz);
        }
        
        public static 
        unsafe void NormalStream3ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords)
        {
            Delegates.glNormalStream3ivATI(stream, coords);
        }
        
        public static 
        void NormalStream3fATI(GL.Enums.ATI_vertex_streams stream, GLfloat nx, GLfloat ny, GLfloat nz)
        {
            Delegates.glNormalStream3fATI(stream, nx, ny, nz);
        }
        
        public static 
        unsafe void NormalStream3fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords)
        {
            Delegates.glNormalStream3fvATI(stream, coords);
        }
        
        public static 
        void NormalStream3dATI(GL.Enums.ATI_vertex_streams stream, GLdouble nx, GLdouble ny, GLdouble nz)
        {
            Delegates.glNormalStream3dATI(stream, nx, ny, nz);
        }
        
        public static 
        unsafe void NormalStream3dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords)
        {
            Delegates.glNormalStream3dvATI(stream, coords);
        }
        
        public static 
        void ClientActiveVertexStreamATI(GL.Enums.ATI_vertex_streams stream)
        {
            Delegates.glClientActiveVertexStreamATI(stream);
        }
        
        public static 
        void VertexBlendEnviATI(GL.Enums.ATI_vertex_streams pname, GLint param)
        {
            Delegates.glVertexBlendEnviATI(pname, param);
        }
        
        public static 
        void VertexBlendEnvfATI(GL.Enums.ATI_vertex_streams pname, GLfloat param)
        {
            Delegates.glVertexBlendEnvfATI(pname, param);
        }
        
        public static 
        unsafe void ElementPointerATI(GL.Enums.ATI_element_array type, void* pointer)
        {
            Delegates.glElementPointerATI(type, pointer);
        }
        
        public static 
        void DrawElementArrayATI(GL.Enums.BeginMode mode, GLsizei count)
        {
            Delegates.glDrawElementArrayATI(mode, count);
        }
        
        public static 
        void DrawRangeElementArrayATI(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count)
        {
            Delegates.glDrawRangeElementArrayATI(mode, start, end, count);
        }
        
        public static 
        void DrawMeshArraysSUN(GL.Enums.BeginMode mode, GLint first, GLsizei count, GLsizei width)
        {
            Delegates.glDrawMeshArraysSUN(mode, first, count, width);
        }
        
        public static 
        unsafe void GenOcclusionQueriesNV(GLsizei n, GLuint* ids)
        {
            Delegates.glGenOcclusionQueriesNV(n, ids);
        }
        
        public static 
        unsafe void DeleteOcclusionQueriesNV(GLsizei n, GLuint* ids)
        {
            Delegates.glDeleteOcclusionQueriesNV(n, ids);
        }
        
        public static 
        GLboolean IsOcclusionQueryNV(GLuint id)
        {
            return Delegates.glIsOcclusionQueryNV(id);
        }
        
        public static 
        void BeginOcclusionQueryNV(GLuint id)
        {
            Delegates.glBeginOcclusionQueryNV(id);
        }
        
        public static 
        void EndOcclusionQueryNV()
        {
            Delegates.glEndOcclusionQueryNV();
        }
        
        public static 
        unsafe void GetOcclusionQueryivNV(GLuint id, GL.Enums.NV_occlusion_query pname, GLint* @params)
        {
            Delegates.glGetOcclusionQueryivNV(id, pname, @params);
        }
        
        public static 
        unsafe void GetOcclusionQueryuivNV(GLuint id, GL.Enums.NV_occlusion_query pname, GLuint* @params)
        {
            Delegates.glGetOcclusionQueryuivNV(id, pname, @params);
        }
        
        public static 
        void PointParameteriNV(GL.Enums.NV_point_sprite pname, GLint param)
        {
            Delegates.glPointParameteriNV(pname, param);
        }
        
        public static 
        unsafe void PointParameterivNV(GL.Enums.NV_point_sprite pname, GLint* @params)
        {
            Delegates.glPointParameterivNV(pname, @params);
        }
        
        public static 
        void ActiveStencilFaceEXT(GL.Enums.EXT_stencil_two_side face)
        {
            Delegates.glActiveStencilFaceEXT(face);
        }
        
        public static 
        unsafe void ElementPointerAPPLE(GL.Enums.APPLE_element_array type, void* pointer)
        {
            Delegates.glElementPointerAPPLE(type, pointer);
        }
        
        public static 
        void DrawElementArrayAPPLE(GL.Enums.BeginMode mode, GLint first, GLsizei count)
        {
            Delegates.glDrawElementArrayAPPLE(mode, first, count);
        }
        
        public static 
        void DrawRangeElementArrayAPPLE(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLint first, GLsizei count)
        {
            Delegates.glDrawRangeElementArrayAPPLE(mode, start, end, first, count);
        }
        
        public static 
        unsafe void MultiDrawElementArrayAPPLE(GL.Enums.BeginMode mode, GLint* first, GLsizei* count, GLsizei primcount)
        {
            Delegates.glMultiDrawElementArrayAPPLE(mode, first, count, primcount);
        }
        
        public static 
        unsafe void MultiDrawRangeElementArrayAPPLE(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLint* first, GLsizei* count, GLsizei primcount)
        {
            Delegates.glMultiDrawRangeElementArrayAPPLE(mode, start, end, first, count, primcount);
        }
        
        public static 
        unsafe void GenFencesAPPLE(GLsizei n, GLuint* fences)
        {
            Delegates.glGenFencesAPPLE(n, fences);
        }
        
        public static 
        unsafe void DeleteFencesAPPLE(GLsizei n, GLuint* fences)
        {
            Delegates.glDeleteFencesAPPLE(n, fences);
        }
        
        public static 
        void SetFenceAPPLE(GLuint fence)
        {
            Delegates.glSetFenceAPPLE(fence);
        }
        
        public static 
        GLboolean IsFenceAPPLE(GLuint fence)
        {
            return Delegates.glIsFenceAPPLE(fence);
        }
        
        public static 
        GLboolean TestFenceAPPLE(GLuint fence)
        {
            return Delegates.glTestFenceAPPLE(fence);
        }
        
        public static 
        void FinishFenceAPPLE(GLuint fence)
        {
            Delegates.glFinishFenceAPPLE(fence);
        }
        
        public static 
        GLboolean TestObjectAPPLE(GL.Enums.APPLE_fence @object, GLuint name)
        {
            return Delegates.glTestObjectAPPLE(@object, name);
        }
        
        public static 
        void FinishObjectAPPLE(GL.Enums.APPLE_fence @object, GLint name)
        {
            Delegates.glFinishObjectAPPLE(@object, name);
        }
        
        public static 
        void BindVertexArrayAPPLE(GLuint array)
        {
            Delegates.glBindVertexArrayAPPLE(array);
        }
        
        public static 
        unsafe void DeleteVertexArraysAPPLE(GLsizei n, GLuint* arrays)
        {
            Delegates.glDeleteVertexArraysAPPLE(n, arrays);
        }
        
        public static 
        unsafe void GenVertexArraysAPPLE(GLsizei n, GLuint* arrays)
        {
            Delegates.glGenVertexArraysAPPLE(n, arrays);
        }
        
        public static 
        GLboolean IsVertexArrayAPPLE(GLuint array)
        {
            return Delegates.glIsVertexArrayAPPLE(array);
        }
        
        public static 
        unsafe void VertexArrayRangeAPPLE(GLsizei length, void* pointer)
        {
            Delegates.glVertexArrayRangeAPPLE(length, pointer);
        }
        
        public static 
        unsafe void FlushVertexArrayRangeAPPLE(GLsizei length, void* pointer)
        {
            Delegates.glFlushVertexArrayRangeAPPLE(length, pointer);
        }
        
        public static 
        void VertexArrayParameteriAPPLE(GL.Enums.APPLE_vertex_array_range pname, GLint param)
        {
            Delegates.glVertexArrayParameteriAPPLE(pname, param);
        }
        
        public static 
        unsafe void DrawBuffersATI(GLsizei n, GL.Enums.ATI_draw_buffers* bufs)
        {
            Delegates.glDrawBuffersATI(n, bufs);
        }
        
        public static 
        unsafe void ProgramNamedParameter4fNV(GLuint id, GLsizei len, GLubyte* name, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            Delegates.glProgramNamedParameter4fNV(id, len, name, x, y, z, w);
        }
        
        public static 
        unsafe void ProgramNamedParameter4dNV(GLuint id, GLsizei len, GLubyte* name, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            Delegates.glProgramNamedParameter4dNV(id, len, name, x, y, z, w);
        }
        
        public static 
        unsafe void ProgramNamedParameter4fvNV(GLuint id, GLsizei len, GLubyte* name, GLfloat* v)
        {
            Delegates.glProgramNamedParameter4fvNV(id, len, name, v);
        }
        
        public static 
        unsafe void ProgramNamedParameter4dvNV(GLuint id, GLsizei len, GLubyte* name, GLdouble* v)
        {
            Delegates.glProgramNamedParameter4dvNV(id, len, name, v);
        }
        
        public static 
        unsafe void GetProgramNamedParameterfvNV(GLuint id, GLsizei len, GLubyte* name, GLfloat* @params)
        {
            Delegates.glGetProgramNamedParameterfvNV(id, len, name, @params);
        }
        
        public static 
        unsafe void GetProgramNamedParameterdvNV(GLuint id, GLsizei len, GLubyte* name, GLdouble* @params)
        {
            Delegates.glGetProgramNamedParameterdvNV(id, len, name, @params);
        }
        
        public static 
        void Vertex2hNV(GLhalfNV x, GLhalfNV y)
        {
            Delegates.glVertex2hNV(x, y);
        }
        
        public static 
        unsafe void Vertex2hvNV(GLhalfNV* v)
        {
            Delegates.glVertex2hvNV(v);
        }
        
        public static 
        void Vertex3hNV(GLhalfNV x, GLhalfNV y, GLhalfNV z)
        {
            Delegates.glVertex3hNV(x, y, z);
        }
        
        public static 
        unsafe void Vertex3hvNV(GLhalfNV* v)
        {
            Delegates.glVertex3hvNV(v);
        }
        
        public static 
        void Vertex4hNV(GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w)
        {
            Delegates.glVertex4hNV(x, y, z, w);
        }
        
        public static 
        unsafe void Vertex4hvNV(GLhalfNV* v)
        {
            Delegates.glVertex4hvNV(v);
        }
        
        public static 
        void Normal3hNV(GLhalfNV nx, GLhalfNV ny, GLhalfNV nz)
        {
            Delegates.glNormal3hNV(nx, ny, nz);
        }
        
        public static 
        unsafe void Normal3hvNV(GLhalfNV* v)
        {
            Delegates.glNormal3hvNV(v);
        }
        
        public static 
        void Color3hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue)
        {
            Delegates.glColor3hNV(red, green, blue);
        }
        
        public static 
        unsafe void Color3hvNV(GLhalfNV* v)
        {
            Delegates.glColor3hvNV(v);
        }
        
        public static 
        void Color4hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue, GLhalfNV alpha)
        {
            Delegates.glColor4hNV(red, green, blue, alpha);
        }
        
        public static 
        unsafe void Color4hvNV(GLhalfNV* v)
        {
            Delegates.glColor4hvNV(v);
        }
        
        public static 
        void TexCoord1hNV(GLhalfNV s)
        {
            Delegates.glTexCoord1hNV(s);
        }
        
        public static 
        unsafe void TexCoord1hvNV(GLhalfNV* v)
        {
            Delegates.glTexCoord1hvNV(v);
        }
        
        public static 
        void TexCoord2hNV(GLhalfNV s, GLhalfNV t)
        {
            Delegates.glTexCoord2hNV(s, t);
        }
        
        public static 
        unsafe void TexCoord2hvNV(GLhalfNV* v)
        {
            Delegates.glTexCoord2hvNV(v);
        }
        
        public static 
        void TexCoord3hNV(GLhalfNV s, GLhalfNV t, GLhalfNV r)
        {
            Delegates.glTexCoord3hNV(s, t, r);
        }
        
        public static 
        unsafe void TexCoord3hvNV(GLhalfNV* v)
        {
            Delegates.glTexCoord3hvNV(v);
        }
        
        public static 
        void TexCoord4hNV(GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q)
        {
            Delegates.glTexCoord4hNV(s, t, r, q);
        }
        
        public static 
        unsafe void TexCoord4hvNV(GLhalfNV* v)
        {
            Delegates.glTexCoord4hvNV(v);
        }
        
        public static 
        void MultiTexCoord1hNV(GL.Enums.NV_half_float target, GLhalfNV s)
        {
            Delegates.glMultiTexCoord1hNV(target, s);
        }
        
        public static 
        unsafe void MultiTexCoord1hvNV(GL.Enums.NV_half_float target, GLhalfNV* v)
        {
            Delegates.glMultiTexCoord1hvNV(target, v);
        }
        
        public static 
        void MultiTexCoord2hNV(GL.Enums.NV_half_float target, GLhalfNV s, GLhalfNV t)
        {
            Delegates.glMultiTexCoord2hNV(target, s, t);
        }
        
        public static 
        unsafe void MultiTexCoord2hvNV(GL.Enums.NV_half_float target, GLhalfNV* v)
        {
            Delegates.glMultiTexCoord2hvNV(target, v);
        }
        
        public static 
        void MultiTexCoord3hNV(GL.Enums.NV_half_float target, GLhalfNV s, GLhalfNV t, GLhalfNV r)
        {
            Delegates.glMultiTexCoord3hNV(target, s, t, r);
        }
        
        public static 
        unsafe void MultiTexCoord3hvNV(GL.Enums.NV_half_float target, GLhalfNV* v)
        {
            Delegates.glMultiTexCoord3hvNV(target, v);
        }
        
        public static 
        void MultiTexCoord4hNV(GL.Enums.NV_half_float target, GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q)
        {
            Delegates.glMultiTexCoord4hNV(target, s, t, r, q);
        }
        
        public static 
        unsafe void MultiTexCoord4hvNV(GL.Enums.NV_half_float target, GLhalfNV* v)
        {
            Delegates.glMultiTexCoord4hvNV(target, v);
        }
        
        public static 
        void FogCoordhNV(GLhalfNV fog)
        {
            Delegates.glFogCoordhNV(fog);
        }
        
        public static 
        unsafe void FogCoordhvNV(GLhalfNV* fog)
        {
            Delegates.glFogCoordhvNV(fog);
        }
        
        public static 
        void SecondaryColor3hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue)
        {
            Delegates.glSecondaryColor3hNV(red, green, blue);
        }
        
        public static 
        unsafe void SecondaryColor3hvNV(GLhalfNV* v)
        {
            Delegates.glSecondaryColor3hvNV(v);
        }
        
        public static 
        void VertexWeighthNV(GLhalfNV weight)
        {
            Delegates.glVertexWeighthNV(weight);
        }
        
        public static 
        unsafe void VertexWeighthvNV(GLhalfNV* weight)
        {
            Delegates.glVertexWeighthvNV(weight);
        }
        
        public static 
        void VertexAttrib1hNV(GLuint index, GLhalfNV x)
        {
            Delegates.glVertexAttrib1hNV(index, x);
        }
        
        public static 
        unsafe void VertexAttrib1hvNV(GLuint index, GLhalfNV* v)
        {
            Delegates.glVertexAttrib1hvNV(index, v);
        }
        
        public static 
        void VertexAttrib2hNV(GLuint index, GLhalfNV x, GLhalfNV y)
        {
            Delegates.glVertexAttrib2hNV(index, x, y);
        }
        
        public static 
        unsafe void VertexAttrib2hvNV(GLuint index, GLhalfNV* v)
        {
            Delegates.glVertexAttrib2hvNV(index, v);
        }
        
        public static 
        void VertexAttrib3hNV(GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z)
        {
            Delegates.glVertexAttrib3hNV(index, x, y, z);
        }
        
        public static 
        unsafe void VertexAttrib3hvNV(GLuint index, GLhalfNV* v)
        {
            Delegates.glVertexAttrib3hvNV(index, v);
        }
        
        public static 
        void VertexAttrib4hNV(GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w)
        {
            Delegates.glVertexAttrib4hNV(index, x, y, z, w);
        }
        
        public static 
        unsafe void VertexAttrib4hvNV(GLuint index, GLhalfNV* v)
        {
            Delegates.glVertexAttrib4hvNV(index, v);
        }
        
        public static 
        unsafe void VertexAttribs1hvNV(GLuint index, GLsizei n, GLhalfNV* v)
        {
            Delegates.glVertexAttribs1hvNV(index, n, v);
        }
        
        public static 
        unsafe void VertexAttribs2hvNV(GLuint index, GLsizei n, GLhalfNV* v)
        {
            Delegates.glVertexAttribs2hvNV(index, n, v);
        }
        
        public static 
        unsafe void VertexAttribs3hvNV(GLuint index, GLsizei n, GLhalfNV* v)
        {
            Delegates.glVertexAttribs3hvNV(index, n, v);
        }
        
        public static 
        unsafe void VertexAttribs4hvNV(GLuint index, GLsizei n, GLhalfNV* v)
        {
            Delegates.glVertexAttribs4hvNV(index, n, v);
        }
        
        public static 
        unsafe void PixelDataRangeNV(GL.Enums.NV_pixel_data_range target, GLsizei length, void* pointer)
        {
            Delegates.glPixelDataRangeNV(target, length, pointer);
        }
        
        public static 
        void FlushPixelDataRangeNV(GL.Enums.NV_pixel_data_range target)
        {
            Delegates.glFlushPixelDataRangeNV(target);
        }
        
        public static 
        void PrimitiveRestartNV()
        {
            Delegates.glPrimitiveRestartNV();
        }
        
        public static 
        void PrimitiveRestartIndexNV(GLuint index)
        {
            Delegates.glPrimitiveRestartIndexNV(index);
        }
        
        public static 
        void MapObjectBufferATI(GLuint buffer)
        {
            Delegates.glMapObjectBufferATI(buffer);
        }
        
        public static 
        void UnmapObjectBufferATI(GLuint buffer)
        {
            Delegates.glUnmapObjectBufferATI(buffer);
        }
        
        public static 
        void StencilOpSeparateATI(GL.Enums.ATI_separate_stencil face, GL.Enums.StencilOp sfail, GL.Enums.StencilOp dpfail, GL.Enums.StencilOp dppass)
        {
            Delegates.glStencilOpSeparateATI(face, sfail, dpfail, dppass);
        }
        
        public static 
        void StencilFuncSeparateATI(GL.Enums.StencilFunction frontfunc, GL.Enums.StencilFunction backfunc, GLint @ref, GLuint mask)
        {
            Delegates.glStencilFuncSeparateATI(frontfunc, backfunc, @ref, mask);
        }
        
        public static 
        unsafe void GetVertexAttribArrayObjectfvATI(GLuint index, GL.Enums.ATI_vertex_attrib_array_object pname, GLfloat* @params)
        {
            Delegates.glGetVertexAttribArrayObjectfvATI(index, pname, @params);
        }
        
        public static 
        unsafe void GetVertexAttribArrayObjectivATI(GLuint index, GL.Enums.ATI_vertex_attrib_array_object pname, GLint* @params)
        {
            Delegates.glGetVertexAttribArrayObjectivATI(index, pname, @params);
        }
        
        public static 
        void DepthBoundsEXT(GLclampd zmin, GLclampd zmax)
        {
            Delegates.glDepthBoundsEXT(zmin, zmax);
        }
        
        public static 
        void BlendEquationSeparateEXT(GL.Enums.BlendEquationModeEXT modeRGB, GL.Enums.BlendEquationModeEXT modeAlpha)
        {
            Delegates.glBlendEquationSeparateEXT(modeRGB, modeAlpha);
        }
        
        public static 
        GLboolean IsRenderbufferEXT(GLuint renderbuffer)
        {
            return Delegates.glIsRenderbufferEXT(renderbuffer);
        }
        
        public static 
        void BindRenderbufferEXT(GL.Enums.EXT_framebuffer_object target, GLuint renderbuffer)
        {
            Delegates.glBindRenderbufferEXT(target, renderbuffer);
        }
        
        public static 
        unsafe void DeleteRenderbuffersEXT(GLsizei n, GLuint* renderbuffers)
        {
            Delegates.glDeleteRenderbuffersEXT(n, renderbuffers);
        }
        
        public static 
        unsafe void GenRenderbuffersEXT(GLsizei n, GLuint* renderbuffers)
        {
            Delegates.glGenRenderbuffersEXT(n, renderbuffers);
        }
        
        public static 
        void RenderbufferStorageEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.GLenum internalformat, GLsizei width, GLsizei height)
        {
            Delegates.glRenderbufferStorageEXT(target, internalformat, width, height);
        }
        
        public static 
        unsafe void GetRenderbufferParameterivEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.GLenum pname, GLint* @params)
        {
            Delegates.glGetRenderbufferParameterivEXT(target, pname, @params);
        }
        
        public static 
        GLboolean IsFramebufferEXT(GLuint framebuffer)
        {
            return Delegates.glIsFramebufferEXT(framebuffer);
        }
        
        public static 
        void BindFramebufferEXT(GL.Enums.EXT_framebuffer_object target, GLuint framebuffer)
        {
            Delegates.glBindFramebufferEXT(target, framebuffer);
        }
        
        public static 
        unsafe void DeleteFramebuffersEXT(GLsizei n, GLuint* framebuffers)
        {
            Delegates.glDeleteFramebuffersEXT(n, framebuffers);
        }
        
        public static 
        unsafe void GenFramebuffersEXT(GLsizei n, GLuint* framebuffers)
        {
            Delegates.glGenFramebuffersEXT(n, framebuffers);
        }
        
        public static 
        GL.Enums.GLenum CheckFramebufferStatusEXT(GL.Enums.EXT_framebuffer_object target)
        {
            return Delegates.glCheckFramebufferStatusEXT(target);
        }
        
        public static 
        void FramebufferTexture1DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.GLenum textarget, GLuint texture, GLint level)
        {
            Delegates.glFramebufferTexture1DEXT(target, attachment, textarget, texture, level);
        }
        
        public static 
        void FramebufferTexture2DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.GLenum textarget, GLuint texture, GLint level)
        {
            Delegates.glFramebufferTexture2DEXT(target, attachment, textarget, texture, level);
        }
        
        public static 
        void FramebufferTexture3DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.GLenum textarget, GLuint texture, GLint level, GLint zoffset)
        {
            Delegates.glFramebufferTexture3DEXT(target, attachment, textarget, texture, level, zoffset);
        }
        
        public static 
        void FramebufferRenderbufferEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.EXT_framebuffer_object renderbuffertarget, GLuint renderbuffer)
        {
            Delegates.glFramebufferRenderbufferEXT(target, attachment, renderbuffertarget, renderbuffer);
        }
        
        public static 
        unsafe void GetFramebufferAttachmentParameterivEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.GLenum pname, GLint* @params)
        {
            Delegates.glGetFramebufferAttachmentParameterivEXT(target, attachment, pname, @params);
        }
        
        public static 
        void GenerateMipmapEXT(GL.Enums.GLenum target)
        {
            Delegates.glGenerateMipmapEXT(target);
        }
        
        public static 
        unsafe void StringMarkerGREMEDY(GLsizei len, void* @string)
        {
            Delegates.glStringMarkerGREMEDY(len, @string);
        }
        
        public static 
        void StencilClearTagEXT(GLsizei stencilTagBits, GLuint stencilClearTag)
        {
            Delegates.glStencilClearTagEXT(stencilTagBits, stencilClearTag);
        }
        
        public static 
        void BlitFramebufferEXT(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GL.Enums.ClearBufferMask mask, GL.Enums.GLenum filter)
        {
            Delegates.glBlitFramebufferEXT(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }
        
        public static 
        void RenderbufferStorageMultisampleEXT(GL.Enums.GLenum target, GLsizei samples, GL.Enums.GLenum internalformat, GLsizei width, GLsizei height)
        {
            Delegates.glRenderbufferStorageMultisampleEXT(target, samples, internalformat, width, height);
        }
        
        public static 
        unsafe void GetQueryObjecti64vEXT(GLuint id, GL.Enums.GLenum pname, GLint64EXT* @params)
        {
            Delegates.glGetQueryObjecti64vEXT(id, pname, @params);
        }
        
        public static 
        unsafe void GetQueryObjectui64vEXT(GLuint id, GL.Enums.GLenum pname, GLuint64EXT* @params)
        {
            Delegates.glGetQueryObjectui64vEXT(id, pname, @params);
        }
        
        public static 
        unsafe void ProgramEnvParameters4fvEXT(GL.Enums.EXT_gpu_program_parameters target, GLuint index, GLsizei count, GLfloat* @params)
        {
            Delegates.glProgramEnvParameters4fvEXT(target, index, count, @params);
        }
        
        public static 
        unsafe void ProgramLocalParameters4fvEXT(GL.Enums.EXT_gpu_program_parameters target, GLuint index, GLsizei count, GLfloat* @params)
        {
            Delegates.glProgramLocalParameters4fvEXT(target, index, count, @params);
        }
        
        public static 
        void BufferParameteriAPPLE(GL.Enums.GLenum target, GL.Enums.GLenum pname, GLint param)
        {
            Delegates.glBufferParameteriAPPLE(target, pname, param);
        }
        
        public static 
        void FlushMappedBufferRangeAPPLE(GL.Enums.GLenum target, GLintptr offset, GLsizeiptr size)
        {
            Delegates.glFlushMappedBufferRangeAPPLE(target, offset, size);
        }
        
        public static 
        void ProgramLocalParameterI4iNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint x, GLint y, GLint z, GLint w)
        {
            Delegates.glProgramLocalParameterI4iNV(target, index, x, y, z, w);
        }
        
        public static 
        unsafe void ProgramLocalParameterI4ivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint* @params)
        {
            Delegates.glProgramLocalParameterI4ivNV(target, index, @params);
        }
        
        public static 
        unsafe void ProgramLocalParametersI4ivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLsizei count, GLint* @params)
        {
            Delegates.glProgramLocalParametersI4ivNV(target, index, count, @params);
        }
        
        public static 
        void ProgramLocalParameterI4uiNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
        {
            Delegates.glProgramLocalParameterI4uiNV(target, index, x, y, z, w);
        }
        
        public static 
        unsafe void ProgramLocalParameterI4uivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint* @params)
        {
            Delegates.glProgramLocalParameterI4uivNV(target, index, @params);
        }
        
        public static 
        unsafe void ProgramLocalParametersI4uivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLsizei count, GLuint* @params)
        {
            Delegates.glProgramLocalParametersI4uivNV(target, index, count, @params);
        }
        
        public static 
        void ProgramEnvParameterI4iNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint x, GLint y, GLint z, GLint w)
        {
            Delegates.glProgramEnvParameterI4iNV(target, index, x, y, z, w);
        }
        
        public static 
        unsafe void ProgramEnvParameterI4ivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint* @params)
        {
            Delegates.glProgramEnvParameterI4ivNV(target, index, @params);
        }
        
        public static 
        unsafe void ProgramEnvParametersI4ivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLsizei count, GLint* @params)
        {
            Delegates.glProgramEnvParametersI4ivNV(target, index, count, @params);
        }
        
        public static 
        void ProgramEnvParameterI4uiNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
        {
            Delegates.glProgramEnvParameterI4uiNV(target, index, x, y, z, w);
        }
        
        public static 
        unsafe void ProgramEnvParameterI4uivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint* @params)
        {
            Delegates.glProgramEnvParameterI4uivNV(target, index, @params);
        }
        
        public static 
        unsafe void ProgramEnvParametersI4uivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLsizei count, GLuint* @params)
        {
            Delegates.glProgramEnvParametersI4uivNV(target, index, count, @params);
        }
        
        public static 
        unsafe void GetProgramLocalParameterIivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint* @params)
        {
            Delegates.glGetProgramLocalParameterIivNV(target, index, @params);
        }
        
        public static 
        unsafe void GetProgramLocalParameterIuivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint* @params)
        {
            Delegates.glGetProgramLocalParameterIuivNV(target, index, @params);
        }
        
        public static 
        unsafe void GetProgramEnvParameterIivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint* @params)
        {
            Delegates.glGetProgramEnvParameterIivNV(target, index, @params);
        }
        
        public static 
        unsafe void GetProgramEnvParameterIuivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint* @params)
        {
            Delegates.glGetProgramEnvParameterIuivNV(target, index, @params);
        }
        
        public static 
        void ProgramVertexLimitNV(GL.Enums.NV_geometry_program4 target, GLint limit)
        {
            Delegates.glProgramVertexLimitNV(target, limit);
        }
        
        public static 
        void FramebufferTextureEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, GLuint texture, GLint level)
        {
            Delegates.glFramebufferTextureEXT(target, attachment, texture, level);
        }
        
        public static 
        void FramebufferTextureLayerEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, GLuint texture, GLint level, GLint layer)
        {
            Delegates.glFramebufferTextureLayerEXT(target, attachment, texture, level, layer);
        }
        
        public static 
        void FramebufferTextureFaceEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, GLuint texture, GLint level, GL.Enums.TextureTarget face)
        {
            Delegates.glFramebufferTextureFaceEXT(target, attachment, texture, level, face);
        }
        
        public static 
        void ProgramParameteriEXT(GLuint program, GL.Enums.EXT_geometry_shader4 pname, GLint value)
        {
            Delegates.glProgramParameteriEXT(program, pname, value);
        }
        
        public static 
        void VertexAttribI1iEXT(GLuint index, GLint x)
        {
            Delegates.glVertexAttribI1iEXT(index, x);
        }
        
        public static 
        void VertexAttribI2iEXT(GLuint index, GLint x, GLint y)
        {
            Delegates.glVertexAttribI2iEXT(index, x, y);
        }
        
        public static 
        void VertexAttribI3iEXT(GLuint index, GLint x, GLint y, GLint z)
        {
            Delegates.glVertexAttribI3iEXT(index, x, y, z);
        }
        
        public static 
        void VertexAttribI4iEXT(GLuint index, GLint x, GLint y, GLint z, GLint w)
        {
            Delegates.glVertexAttribI4iEXT(index, x, y, z, w);
        }
        
        public static 
        void VertexAttribI1uiEXT(GLuint index, GLuint x)
        {
            Delegates.glVertexAttribI1uiEXT(index, x);
        }
        
        public static 
        void VertexAttribI2uiEXT(GLuint index, GLuint x, GLuint y)
        {
            Delegates.glVertexAttribI2uiEXT(index, x, y);
        }
        
        public static 
        void VertexAttribI3uiEXT(GLuint index, GLuint x, GLuint y, GLuint z)
        {
            Delegates.glVertexAttribI3uiEXT(index, x, y, z);
        }
        
        public static 
        void VertexAttribI4uiEXT(GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
        {
            Delegates.glVertexAttribI4uiEXT(index, x, y, z, w);
        }
        
        public static 
        unsafe void VertexAttribI1ivEXT(GLuint index, GLint* v)
        {
            Delegates.glVertexAttribI1ivEXT(index, v);
        }
        
        public static 
        unsafe void VertexAttribI2ivEXT(GLuint index, GLint* v)
        {
            Delegates.glVertexAttribI2ivEXT(index, v);
        }
        
        public static 
        unsafe void VertexAttribI3ivEXT(GLuint index, GLint* v)
        {
            Delegates.glVertexAttribI3ivEXT(index, v);
        }
        
        public static 
        unsafe void VertexAttribI4ivEXT(GLuint index, GLint* v)
        {
            Delegates.glVertexAttribI4ivEXT(index, v);
        }
        
        public static 
        unsafe void VertexAttribI1uivEXT(GLuint index, GLuint* v)
        {
            Delegates.glVertexAttribI1uivEXT(index, v);
        }
        
        public static 
        unsafe void VertexAttribI2uivEXT(GLuint index, GLuint* v)
        {
            Delegates.glVertexAttribI2uivEXT(index, v);
        }
        
        public static 
        unsafe void VertexAttribI3uivEXT(GLuint index, GLuint* v)
        {
            Delegates.glVertexAttribI3uivEXT(index, v);
        }
        
        public static 
        unsafe void VertexAttribI4uivEXT(GLuint index, GLuint* v)
        {
            Delegates.glVertexAttribI4uivEXT(index, v);
        }
        
        public static 
        unsafe void VertexAttribI4bvEXT(GLuint index, GLbyte* v)
        {
            Delegates.glVertexAttribI4bvEXT(index, v);
        }
        
        public static 
        unsafe void VertexAttribI4svEXT(GLuint index, GLshort* v)
        {
            Delegates.glVertexAttribI4svEXT(index, v);
        }
        
        public static 
        unsafe void VertexAttribI4ubvEXT(GLuint index, GLubyte* v)
        {
            Delegates.glVertexAttribI4ubvEXT(index, v);
        }
        
        public static 
        unsafe void VertexAttribI4usvEXT(GLuint index, GLushort* v)
        {
            Delegates.glVertexAttribI4usvEXT(index, v);
        }
        
        public static 
        unsafe void VertexAttribIPointerEXT(GLuint index, GLint size, GL.Enums.NV_vertex_program4 type, GLsizei stride, void* pointer)
        {
            Delegates.glVertexAttribIPointerEXT(index, size, type, stride, pointer);
        }
        
        public static 
        unsafe void GetVertexAttribIivEXT(GLuint index, GL.Enums.NV_vertex_program4 pname, GLint* @params)
        {
            Delegates.glGetVertexAttribIivEXT(index, pname, @params);
        }
        
        public static 
        unsafe void GetVertexAttribIuivEXT(GLuint index, GL.Enums.NV_vertex_program4 pname, GLuint* @params)
        {
            Delegates.glGetVertexAttribIuivEXT(index, pname, @params);
        }
        
        public static 
        unsafe void GetUniformuivEXT(GLuint program, GLint location, GLuint* @params)
        {
            Delegates.glGetUniformuivEXT(program, location, @params);
        }
        
        public static 
        void Uniform1uiEXT(GLint location, GLuint v0)
        {
            Delegates.glUniform1uiEXT(location, v0);
        }
        
        public static 
        void Uniform2uiEXT(GLint location, GLuint v0, GLuint v1)
        {
            Delegates.glUniform2uiEXT(location, v0, v1);
        }
        
        public static 
        void Uniform3uiEXT(GLint location, GLuint v0, GLuint v1, GLuint v2)
        {
            Delegates.glUniform3uiEXT(location, v0, v1, v2);
        }
        
        public static 
        void Uniform4uiEXT(GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)
        {
            Delegates.glUniform4uiEXT(location, v0, v1, v2, v3);
        }
        
        public static 
        unsafe void Uniform1uivEXT(GLint location, GLsizei count, GLuint* value)
        {
            Delegates.glUniform1uivEXT(location, count, value);
        }
        
        public static 
        unsafe void Uniform2uivEXT(GLint location, GLsizei count, GLuint* value)
        {
            Delegates.glUniform2uivEXT(location, count, value);
        }
        
        public static 
        unsafe void Uniform3uivEXT(GLint location, GLsizei count, GLuint* value)
        {
            Delegates.glUniform3uivEXT(location, count, value);
        }
        
        public static 
        unsafe void Uniform4uivEXT(GLint location, GLsizei count, GLuint* value)
        {
            Delegates.glUniform4uivEXT(location, count, value);
        }
        
        public static 
        void DrawArraysInstancedEXT(GL.Enums.BeginMode mode, GLint start, GLsizei count, GLsizei primcount)
        {
            Delegates.glDrawArraysInstancedEXT(mode, start, count, primcount);
        }
        
        public static 
        unsafe void DrawElementsInstancedEXT(GL.Enums.BeginMode mode, GLsizei count, GL.Enums.EXT_draw_instanced type, void* indices, GLsizei primcount)
        {
            Delegates.glDrawElementsInstancedEXT(mode, count, type, indices, primcount);
        }
        
        public static 
        void TexBufferEXT(GL.Enums.TextureTarget target, GL.Enums.GLenum internalformat, GLuint buffer)
        {
            Delegates.glTexBufferEXT(target, internalformat, buffer);
        }
        
        public static 
        void DepthRangedNV(GLdouble zNear, GLdouble zFar)
        {
            Delegates.glDepthRangedNV(zNear, zFar);
        }
        
        public static 
        void ClearDepthdNV(GLdouble depth)
        {
            Delegates.glClearDepthdNV(depth);
        }
        
        public static 
        void DepthBoundsdNV(GLdouble zmin, GLdouble zmax)
        {
            Delegates.glDepthBoundsdNV(zmin, zmax);
        }
        
        public static 
        void RenderbufferStorageMultisampleCoverageNV(GL.Enums.NV_framebuffer_multisample_coverage target, GLsizei coverageSamples, GLsizei colorSamples, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height)
        {
            Delegates.glRenderbufferStorageMultisampleCoverageNV(target, coverageSamples, colorSamples, internalformat, width, height);
        }
        
        public static 
        unsafe void ProgramBufferParametersfvNV(GL.Enums.NV_parameter_buffer_object target, GLuint buffer, GLuint index, GLsizei count, GLfloat* @params)
        {
            Delegates.glProgramBufferParametersfvNV(target, buffer, index, count, @params);
        }
        
        public static 
        unsafe void ProgramBufferParametersIivNV(GL.Enums.NV_parameter_buffer_object target, GLuint buffer, GLuint index, GLsizei count, GLint* @params)
        {
            Delegates.glProgramBufferParametersIivNV(target, buffer, index, count, @params);
        }
        
        public static 
        unsafe void ProgramBufferParametersIuivNV(GL.Enums.NV_parameter_buffer_object target, GLuint buffer, GLuint index, GLsizei count, GLuint* @params)
        {
            Delegates.glProgramBufferParametersIuivNV(target, buffer, index, count, @params);
        }
        
        public static 
        unsafe void GetBooleanIndexedvEXT(GL.Enums.GLenum target, GLuint index, GL.Enums.Boolean* data)
        {
            Delegates.glGetBooleanIndexedvEXT(target, index, data);
        }
        
        public static 
        unsafe void GetIntegerIndexedvEXT(GL.Enums.GLenum target, GLuint index, GLint* data)
        {
            Delegates.glGetIntegerIndexedvEXT(target, index, data);
        }
        
        public static 
        void EnableIndexedEXT(GL.Enums.GLenum target, GLuint index)
        {
            Delegates.glEnableIndexedEXT(target, index);
        }
        
        public static 
        void DisableIndexedEXT(GL.Enums.GLenum target, GLuint index)
        {
            Delegates.glDisableIndexedEXT(target, index);
        }
        
        public static 
        GLboolean IsEnabledIndexedEXT(GL.Enums.GLenum target, GLuint index)
        {
            return Delegates.glIsEnabledIndexedEXT(target, index);
        }
        
        public static 
        void BeginTransformFeedbackNV(GL.Enums.GLenum primitiveMode)
        {
            Delegates.glBeginTransformFeedbackNV(primitiveMode);
        }
        
        public static 
        void EndTransformFeedbackNV()
        {
            Delegates.glEndTransformFeedbackNV();
        }
        
        public static 
        unsafe void TransformFeedbackAttribsNV(GLuint count, GLint* attribs, GL.Enums.GLenum bufferMode)
        {
            Delegates.glTransformFeedbackAttribsNV(count, attribs, bufferMode);
        }
        
        public static 
        void BindBufferRangeNV(GL.Enums.GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)
        {
            Delegates.glBindBufferRangeNV(target, index, buffer, offset, size);
        }
        
        public static 
        void BindBufferOffsetNV(GL.Enums.GLenum target, GLuint index, GLuint buffer, GLintptr offset)
        {
            Delegates.glBindBufferOffsetNV(target, index, buffer, offset);
        }
        
        public static 
        void BindBufferBaseNV(GL.Enums.GLenum target, GLuint index, GLuint buffer)
        {
            Delegates.glBindBufferBaseNV(target, index, buffer);
        }
        
        public static 
        unsafe void TransformFeedbackVaryingsNV(GLuint program, GLsizei count, GLint* locations, GL.Enums.GLenum bufferMode)
        {
            Delegates.glTransformFeedbackVaryingsNV(program, count, locations, bufferMode);
        }
        
        public static 
        unsafe void GetActiveVaryingNV(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GL.Enums.GLenum* type, System.Text.StringBuilder name)
        {
            Delegates.glGetActiveVaryingNV(program, index, bufSize, length, size, type, name);
        }
        
        public static 
        unsafe void GetTransformFeedbackVaryingNV(GLuint program, GLuint index, GLint* location)
        {
            Delegates.glGetTransformFeedbackVaryingNV(program, index, location);
        }
        
        public static 
        void UniformBufferEXT(GLuint program, GLint location, GLuint buffer)
        {
            Delegates.glUniformBufferEXT(program, location, buffer);
        }
        
        public static 
        GLint GetUniformBufferSizeEXT(GLuint program, GLint location)
        {
            return Delegates.glGetUniformBufferSizeEXT(program, location);
        }
        
        public static 
        GLintptr GetUniformOffsetEXT(GLuint program, GLint location)
        {
            return Delegates.glGetUniformOffsetEXT(program, location);
        }
        
        public static 
        unsafe void TexParameterIivEXT(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLint* @params)
        {
            Delegates.glTexParameterIivEXT(target, pname, @params);
        }
        
        public static 
        unsafe void TexParameterIuivEXT(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLuint* @params)
        {
            Delegates.glTexParameterIuivEXT(target, pname, @params);
        }
        
        public static 
        unsafe void GetTexParameterIivEXT(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, GLint* @params)
        {
            Delegates.glGetTexParameterIivEXT(target, pname, @params);
        }
        
        public static 
        unsafe void GetTexParameterIuivEXT(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, GLuint* @params)
        {
            Delegates.glGetTexParameterIuivEXT(target, pname, @params);
        }
        
        public static 
        void ClearColorIiEXT(GLint red, GLint green, GLint blue, GLint alpha)
        {
            Delegates.glClearColorIiEXT(red, green, blue, alpha);
        }
        
        public static 
        void ClearColorIuiEXT(GLuint red, GLuint green, GLuint blue, GLuint alpha)
        {
            Delegates.glClearColorIuiEXT(red, green, blue, alpha);
        }
        
    }
}
