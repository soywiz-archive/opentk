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
        public static void NewList(GLuint list, GL.Enums.ListMode mode)
        {
            NewList(list, mode);
        }
        
        public static void EndList()
        {
            EndList();
        }
        
        public static void CallList(GLuint list)
        {
            CallList(list);
        }
        
        public static unsafe void CallLists(GLsizei n, GL.Enums.ListNameType type, void* lists)
        {
            return CallLists(n, type, lists);
        }
        
        public static void DeleteLists(GLuint list, GLsizei range)
        {
            DeleteLists(list, range);
        }
        
        public static GLuint GenLists(GLsizei range)
        {
            return GenLists(range);
        }
        
        public static void ListBase(GLuint @base)
        {
            ListBase(@base);
        }
        
        public static void Begin(GL.Enums.BeginMode mode)
        {
            Begin(mode);
        }
        
        public static unsafe void Bitmap(GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, GLubyte* bitmap)
        {
            return Bitmap(width, height, xorig, yorig, xmove, ymove, bitmap);
        }
        
        public static void Color3b(GLbyte red, GLbyte green, GLbyte blue)
        {
            Color3b(red, green, blue);
        }
        
        public static unsafe void Color3bv(GLbyte* v)
        {
            return Color3bv(v);
        }
        
        public static unsafe void Color3bv(GLbyte[] v)
        {
            fixed (GLbyte v_ptr = v)
            {
                Color3bv(v_ptr);
            }
        }
        
        public static unsafe void Color3bv(ref GLbyte v)
        {
            fixed (GLbyte v_ptr = &v)
            {
                Color3bv(v_ptr);
            }
        }
        
        public static void Color3d(GLdouble red, GLdouble green, GLdouble blue)
        {
            Color3d(red, green, blue);
        }
        
        public static unsafe void Color3dv(GLdouble* v)
        {
            return Color3dv(v);
        }
        
        public static unsafe void Color3dv(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                Color3dv(v_ptr);
            }
        }
        
        public static unsafe void Color3dv(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                Color3dv(v_ptr);
            }
        }
        
        public static void Color3f(GLfloat red, GLfloat green, GLfloat blue)
        {
            Color3f(red, green, blue);
        }
        
        public static unsafe void Color3fv(GLfloat* v)
        {
            return Color3fv(v);
        }
        
        public static unsafe void Color3fv(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                Color3fv(v_ptr);
            }
        }
        
        public static unsafe void Color3fv(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                Color3fv(v_ptr);
            }
        }
        
        public static void Color3i(GLint red, GLint green, GLint blue)
        {
            Color3i(red, green, blue);
        }
        
        public static unsafe void Color3iv(GLint* v)
        {
            return Color3iv(v);
        }
        
        public static unsafe void Color3iv(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                Color3iv(v_ptr);
            }
        }
        
        public static unsafe void Color3iv(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                Color3iv(v_ptr);
            }
        }
        
        public static void Color3s(GLshort red, GLshort green, GLshort blue)
        {
            Color3s(red, green, blue);
        }
        
        public static unsafe void Color3sv(GLshort* v)
        {
            return Color3sv(v);
        }
        
        public static unsafe void Color3sv(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                Color3sv(v_ptr);
            }
        }
        
        public static unsafe void Color3sv(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                Color3sv(v_ptr);
            }
        }
        
        public static void Color3ub(GLubyte red, GLubyte green, GLubyte blue)
        {
            Color3ub(red, green, blue);
        }
        
        public static unsafe void Color3ubv(GLubyte* v)
        {
            return Color3ubv(v);
        }
        
        public static unsafe void Color3ubv(GLubyte[] v)
        {
            fixed (GLubyte v_ptr = v)
            {
                Color3ubv(v_ptr);
            }
        }
        
        public static unsafe void Color3ubv(ref GLubyte v)
        {
            fixed (GLubyte v_ptr = &v)
            {
                Color3ubv(v_ptr);
            }
        }
        
        public static void Color3ui(GLuint red, GLuint green, GLuint blue)
        {
            Color3ui(red, green, blue);
        }
        
        public static unsafe void Color3uiv(GLuint* v)
        {
            return Color3uiv(v);
        }
        
        public static unsafe void Color3uiv(GLuint[] v)
        {
            fixed (GLuint v_ptr = v)
            {
                Color3uiv(v_ptr);
            }
        }
        
        public static unsafe void Color3uiv(ref GLuint v)
        {
            fixed (GLuint v_ptr = &v)
            {
                Color3uiv(v_ptr);
            }
        }
        
        public static void Color3us(GLushort red, GLushort green, GLushort blue)
        {
            Color3us(red, green, blue);
        }
        
        public static unsafe void Color3usv(GLushort* v)
        {
            return Color3usv(v);
        }
        
        public static unsafe void Color3usv(GLushort[] v)
        {
            fixed (GLushort v_ptr = v)
            {
                Color3usv(v_ptr);
            }
        }
        
        public static unsafe void Color3usv(ref GLushort v)
        {
            fixed (GLushort v_ptr = &v)
            {
                Color3usv(v_ptr);
            }
        }
        
        public static void Color4b(GLbyte red, GLbyte green, GLbyte blue, GLbyte alpha)
        {
            Color4b(red, green, blue, alpha);
        }
        
        public static unsafe void Color4bv(GLbyte* v)
        {
            return Color4bv(v);
        }
        
        public static unsafe void Color4bv(GLbyte[] v)
        {
            fixed (GLbyte v_ptr = v)
            {
                Color4bv(v_ptr);
            }
        }
        
        public static unsafe void Color4bv(ref GLbyte v)
        {
            fixed (GLbyte v_ptr = &v)
            {
                Color4bv(v_ptr);
            }
        }
        
        public static void Color4d(GLdouble red, GLdouble green, GLdouble blue, GLdouble alpha)
        {
            Color4d(red, green, blue, alpha);
        }
        
        public static unsafe void Color4dv(GLdouble* v)
        {
            return Color4dv(v);
        }
        
        public static unsafe void Color4dv(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                Color4dv(v_ptr);
            }
        }
        
        public static unsafe void Color4dv(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                Color4dv(v_ptr);
            }
        }
        
        public static void Color4f(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)
        {
            Color4f(red, green, blue, alpha);
        }
        
        public static unsafe void Color4fv(GLfloat* v)
        {
            return Color4fv(v);
        }
        
        public static unsafe void Color4fv(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                Color4fv(v_ptr);
            }
        }
        
        public static unsafe void Color4fv(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                Color4fv(v_ptr);
            }
        }
        
        public static void Color4i(GLint red, GLint green, GLint blue, GLint alpha)
        {
            Color4i(red, green, blue, alpha);
        }
        
        public static unsafe void Color4iv(GLint* v)
        {
            return Color4iv(v);
        }
        
        public static unsafe void Color4iv(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                Color4iv(v_ptr);
            }
        }
        
        public static unsafe void Color4iv(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                Color4iv(v_ptr);
            }
        }
        
        public static void Color4s(GLshort red, GLshort green, GLshort blue, GLshort alpha)
        {
            Color4s(red, green, blue, alpha);
        }
        
        public static unsafe void Color4sv(GLshort* v)
        {
            return Color4sv(v);
        }
        
        public static unsafe void Color4sv(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                Color4sv(v_ptr);
            }
        }
        
        public static unsafe void Color4sv(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                Color4sv(v_ptr);
            }
        }
        
        public static void Color4ub(GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha)
        {
            Color4ub(red, green, blue, alpha);
        }
        
        public static unsafe void Color4ubv(GLubyte* v)
        {
            return Color4ubv(v);
        }
        
        public static unsafe void Color4ubv(GLubyte[] v)
        {
            fixed (GLubyte v_ptr = v)
            {
                Color4ubv(v_ptr);
            }
        }
        
        public static unsafe void Color4ubv(ref GLubyte v)
        {
            fixed (GLubyte v_ptr = &v)
            {
                Color4ubv(v_ptr);
            }
        }
        
        public static void Color4ui(GLuint red, GLuint green, GLuint blue, GLuint alpha)
        {
            Color4ui(red, green, blue, alpha);
        }
        
        public static unsafe void Color4uiv(GLuint* v)
        {
            return Color4uiv(v);
        }
        
        public static unsafe void Color4uiv(GLuint[] v)
        {
            fixed (GLuint v_ptr = v)
            {
                Color4uiv(v_ptr);
            }
        }
        
        public static unsafe void Color4uiv(ref GLuint v)
        {
            fixed (GLuint v_ptr = &v)
            {
                Color4uiv(v_ptr);
            }
        }
        
        public static void Color4us(GLushort red, GLushort green, GLushort blue, GLushort alpha)
        {
            Color4us(red, green, blue, alpha);
        }
        
        public static unsafe void Color4usv(GLushort* v)
        {
            return Color4usv(v);
        }
        
        public static unsafe void Color4usv(GLushort[] v)
        {
            fixed (GLushort v_ptr = v)
            {
                Color4usv(v_ptr);
            }
        }
        
        public static unsafe void Color4usv(ref GLushort v)
        {
            fixed (GLushort v_ptr = &v)
            {
                Color4usv(v_ptr);
            }
        }
        
        public static unsafe void EdgeFlagv(GL.Enums.Boolean* flag)
        {
            return EdgeFlagv(flag);
        }
        
        public static void End()
        {
            End();
        }
        
        public static void Indexd(GLdouble c)
        {
            Indexd(c);
        }
        
        public static unsafe void Indexdv(GLdouble* c)
        {
            return Indexdv(c);
        }
        
        public static unsafe void Indexdv(GLdouble[] c)
        {
            fixed (GLdouble c_ptr = c)
            {
                Indexdv(c_ptr);
            }
        }
        
        public static unsafe void Indexdv(ref GLdouble c)
        {
            fixed (GLdouble c_ptr = &c)
            {
                Indexdv(c_ptr);
            }
        }
        
        public static void Indexf(GLfloat c)
        {
            Indexf(c);
        }
        
        public static unsafe void Indexfv(GLfloat* c)
        {
            return Indexfv(c);
        }
        
        public static unsafe void Indexfv(GLfloat[] c)
        {
            fixed (GLfloat c_ptr = c)
            {
                Indexfv(c_ptr);
            }
        }
        
        public static unsafe void Indexfv(ref GLfloat c)
        {
            fixed (GLfloat c_ptr = &c)
            {
                Indexfv(c_ptr);
            }
        }
        
        public static void Indexi(GLint c)
        {
            Indexi(c);
        }
        
        public static unsafe void Indexiv(GLint* c)
        {
            return Indexiv(c);
        }
        
        public static unsafe void Indexiv(GLint[] c)
        {
            fixed (GLint c_ptr = c)
            {
                Indexiv(c_ptr);
            }
        }
        
        public static unsafe void Indexiv(ref GLint c)
        {
            fixed (GLint c_ptr = &c)
            {
                Indexiv(c_ptr);
            }
        }
        
        public static void Indexs(GLshort c)
        {
            Indexs(c);
        }
        
        public static unsafe void Indexsv(GLshort* c)
        {
            return Indexsv(c);
        }
        
        public static unsafe void Indexsv(GLshort[] c)
        {
            fixed (GLshort c_ptr = c)
            {
                Indexsv(c_ptr);
            }
        }
        
        public static unsafe void Indexsv(ref GLshort c)
        {
            fixed (GLshort c_ptr = &c)
            {
                Indexsv(c_ptr);
            }
        }
        
        public static void Normal3b(GLbyte nx, GLbyte ny, GLbyte nz)
        {
            Normal3b(nx, ny, nz);
        }
        
        public static unsafe void Normal3bv(GLbyte* v)
        {
            return Normal3bv(v);
        }
        
        public static unsafe void Normal3bv(GLbyte[] v)
        {
            fixed (GLbyte v_ptr = v)
            {
                Normal3bv(v_ptr);
            }
        }
        
        public static unsafe void Normal3bv(ref GLbyte v)
        {
            fixed (GLbyte v_ptr = &v)
            {
                Normal3bv(v_ptr);
            }
        }
        
        public static void Normal3d(GLdouble nx, GLdouble ny, GLdouble nz)
        {
            Normal3d(nx, ny, nz);
        }
        
        public static unsafe void Normal3dv(GLdouble* v)
        {
            return Normal3dv(v);
        }
        
        public static unsafe void Normal3dv(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                Normal3dv(v_ptr);
            }
        }
        
        public static unsafe void Normal3dv(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                Normal3dv(v_ptr);
            }
        }
        
        public static void Normal3f(GLfloat nx, GLfloat ny, GLfloat nz)
        {
            Normal3f(nx, ny, nz);
        }
        
        public static unsafe void Normal3fv(GLfloat* v)
        {
            return Normal3fv(v);
        }
        
        public static unsafe void Normal3fv(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                Normal3fv(v_ptr);
            }
        }
        
        public static unsafe void Normal3fv(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                Normal3fv(v_ptr);
            }
        }
        
        public static void Normal3i(GLint nx, GLint ny, GLint nz)
        {
            Normal3i(nx, ny, nz);
        }
        
        public static unsafe void Normal3iv(GLint* v)
        {
            return Normal3iv(v);
        }
        
        public static unsafe void Normal3iv(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                Normal3iv(v_ptr);
            }
        }
        
        public static unsafe void Normal3iv(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                Normal3iv(v_ptr);
            }
        }
        
        public static void Normal3s(GLshort nx, GLshort ny, GLshort nz)
        {
            Normal3s(nx, ny, nz);
        }
        
        public static unsafe void Normal3sv(GLshort* v)
        {
            return Normal3sv(v);
        }
        
        public static unsafe void Normal3sv(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                Normal3sv(v_ptr);
            }
        }
        
        public static unsafe void Normal3sv(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                Normal3sv(v_ptr);
            }
        }
        
        public static void RasterPos2d(GLdouble x, GLdouble y)
        {
            RasterPos2d(x, y);
        }
        
        public static unsafe void RasterPos2dv(GLdouble* v)
        {
            return RasterPos2dv(v);
        }
        
        public static unsafe void RasterPos2dv(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                RasterPos2dv(v_ptr);
            }
        }
        
        public static unsafe void RasterPos2dv(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                RasterPos2dv(v_ptr);
            }
        }
        
        public static void RasterPos2f(GLfloat x, GLfloat y)
        {
            RasterPos2f(x, y);
        }
        
        public static unsafe void RasterPos2fv(GLfloat* v)
        {
            return RasterPos2fv(v);
        }
        
        public static unsafe void RasterPos2fv(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                RasterPos2fv(v_ptr);
            }
        }
        
        public static unsafe void RasterPos2fv(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                RasterPos2fv(v_ptr);
            }
        }
        
        public static void RasterPos2i(GLint x, GLint y)
        {
            RasterPos2i(x, y);
        }
        
        public static unsafe void RasterPos2iv(GLint* v)
        {
            return RasterPos2iv(v);
        }
        
        public static unsafe void RasterPos2iv(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                RasterPos2iv(v_ptr);
            }
        }
        
        public static unsafe void RasterPos2iv(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                RasterPos2iv(v_ptr);
            }
        }
        
        public static void RasterPos2s(GLshort x, GLshort y)
        {
            RasterPos2s(x, y);
        }
        
        public static unsafe void RasterPos2sv(GLshort* v)
        {
            return RasterPos2sv(v);
        }
        
        public static unsafe void RasterPos2sv(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                RasterPos2sv(v_ptr);
            }
        }
        
        public static unsafe void RasterPos2sv(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                RasterPos2sv(v_ptr);
            }
        }
        
        public static void RasterPos3d(GLdouble x, GLdouble y, GLdouble z)
        {
            RasterPos3d(x, y, z);
        }
        
        public static unsafe void RasterPos3dv(GLdouble* v)
        {
            return RasterPos3dv(v);
        }
        
        public static unsafe void RasterPos3dv(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                RasterPos3dv(v_ptr);
            }
        }
        
        public static unsafe void RasterPos3dv(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                RasterPos3dv(v_ptr);
            }
        }
        
        public static void RasterPos3f(GLfloat x, GLfloat y, GLfloat z)
        {
            RasterPos3f(x, y, z);
        }
        
        public static unsafe void RasterPos3fv(GLfloat* v)
        {
            return RasterPos3fv(v);
        }
        
        public static unsafe void RasterPos3fv(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                RasterPos3fv(v_ptr);
            }
        }
        
        public static unsafe void RasterPos3fv(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                RasterPos3fv(v_ptr);
            }
        }
        
        public static void RasterPos3i(GLint x, GLint y, GLint z)
        {
            RasterPos3i(x, y, z);
        }
        
        public static unsafe void RasterPos3iv(GLint* v)
        {
            return RasterPos3iv(v);
        }
        
        public static unsafe void RasterPos3iv(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                RasterPos3iv(v_ptr);
            }
        }
        
        public static unsafe void RasterPos3iv(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                RasterPos3iv(v_ptr);
            }
        }
        
        public static void RasterPos3s(GLshort x, GLshort y, GLshort z)
        {
            RasterPos3s(x, y, z);
        }
        
        public static unsafe void RasterPos3sv(GLshort* v)
        {
            return RasterPos3sv(v);
        }
        
        public static unsafe void RasterPos3sv(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                RasterPos3sv(v_ptr);
            }
        }
        
        public static unsafe void RasterPos3sv(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                RasterPos3sv(v_ptr);
            }
        }
        
        public static void RasterPos4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            RasterPos4d(x, y, z, w);
        }
        
        public static unsafe void RasterPos4dv(GLdouble* v)
        {
            return RasterPos4dv(v);
        }
        
        public static unsafe void RasterPos4dv(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                RasterPos4dv(v_ptr);
            }
        }
        
        public static unsafe void RasterPos4dv(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                RasterPos4dv(v_ptr);
            }
        }
        
        public static void RasterPos4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            RasterPos4f(x, y, z, w);
        }
        
        public static unsafe void RasterPos4fv(GLfloat* v)
        {
            return RasterPos4fv(v);
        }
        
        public static unsafe void RasterPos4fv(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                RasterPos4fv(v_ptr);
            }
        }
        
        public static unsafe void RasterPos4fv(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                RasterPos4fv(v_ptr);
            }
        }
        
        public static void RasterPos4i(GLint x, GLint y, GLint z, GLint w)
        {
            RasterPos4i(x, y, z, w);
        }
        
        public static unsafe void RasterPos4iv(GLint* v)
        {
            return RasterPos4iv(v);
        }
        
        public static unsafe void RasterPos4iv(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                RasterPos4iv(v_ptr);
            }
        }
        
        public static unsafe void RasterPos4iv(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                RasterPos4iv(v_ptr);
            }
        }
        
        public static void RasterPos4s(GLshort x, GLshort y, GLshort z, GLshort w)
        {
            RasterPos4s(x, y, z, w);
        }
        
        public static unsafe void RasterPos4sv(GLshort* v)
        {
            return RasterPos4sv(v);
        }
        
        public static unsafe void RasterPos4sv(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                RasterPos4sv(v_ptr);
            }
        }
        
        public static unsafe void RasterPos4sv(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                RasterPos4sv(v_ptr);
            }
        }
        
        public static void Rectd(GLdouble x1, GLdouble y1, GLdouble x2, GLdouble y2)
        {
            Rectd(x1, y1, x2, y2);
        }
        
        public static unsafe void Rectdv(GLdouble* v1, GLdouble* v2)
        {
            return Rectdv(v1, v2);
        }
        
        public static unsafe void Rectdv(GLdouble* v1, GLdouble[] v2)
        {
            fixed (GLdouble v2_ptr = v2)
            {
                Rectdv(v1, v2_ptr);
            }
        }
        
        public static unsafe void Rectdv(GLdouble* v1, ref GLdouble v2)
        {
            fixed (GLdouble v2_ptr = &v2)
            {
                Rectdv(v1, v2_ptr);
            }
        }
        
        public static unsafe void Rectdv(GLdouble[] v1, GLdouble* v2)
        {
            fixed (GLdouble v1_ptr = v1)
            {
                Rectdv(v1_ptr, v2);
            }
        }
        
        public static unsafe void Rectdv(GLdouble[] v1, GLdouble[] v2)
        {
            fixed (GLdouble v1_ptr = v1)
            {
                Rectdv(v1_ptr, v2);
            }
            fixed (GLdouble v1_ptr = v1)
            fixed (GLdouble v2_ptr = v2)
            {
                Rectdv(v1_ptr, v2_ptr);
            }
        }
        
        public static unsafe void Rectdv(GLdouble[] v1, ref GLdouble v2)
        {
            fixed (GLdouble v1_ptr = v1)
            {
                Rectdv(v1_ptr, v2);
            }
            fixed (GLdouble v1_ptr = v1)
            fixed (GLdouble v2_ptr = &v2)
            {
                Rectdv(v1_ptr, v2_ptr);
            }
        }
        
        public static unsafe void Rectdv(ref GLdouble v1, GLdouble* v2)
        {
            fixed (GLdouble v1_ptr = &v1)
            {
                Rectdv(v1_ptr, v2);
            }
        }
        
        public static unsafe void Rectdv(ref GLdouble v1, GLdouble[] v2)
        {
            fixed (GLdouble v1_ptr = &v1)
            {
                Rectdv(v1_ptr, v2);
            }
            fixed (GLdouble v1_ptr = &v1)
            fixed (GLdouble v2_ptr = v2)
            {
                Rectdv(v1_ptr, v2_ptr);
            }
        }
        
        public static unsafe void Rectdv(ref GLdouble v1, ref GLdouble v2)
        {
            fixed (GLdouble v1_ptr = &v1)
            {
                Rectdv(v1_ptr, v2);
            }
            fixed (GLdouble v1_ptr = &v1)
            fixed (GLdouble v2_ptr = &v2)
            {
                Rectdv(v1_ptr, v2_ptr);
            }
        }
        
        public static void Rectf(GLfloat x1, GLfloat y1, GLfloat x2, GLfloat y2)
        {
            Rectf(x1, y1, x2, y2);
        }
        
        public static unsafe void Rectfv(GLfloat* v1, GLfloat* v2)
        {
            return Rectfv(v1, v2);
        }
        
        public static unsafe void Rectfv(GLfloat* v1, GLfloat[] v2)
        {
            fixed (GLfloat v2_ptr = v2)
            {
                Rectfv(v1, v2_ptr);
            }
        }
        
        public static unsafe void Rectfv(GLfloat* v1, ref GLfloat v2)
        {
            fixed (GLfloat v2_ptr = &v2)
            {
                Rectfv(v1, v2_ptr);
            }
        }
        
        public static unsafe void Rectfv(GLfloat[] v1, GLfloat* v2)
        {
            fixed (GLfloat v1_ptr = v1)
            {
                Rectfv(v1_ptr, v2);
            }
        }
        
        public static unsafe void Rectfv(GLfloat[] v1, GLfloat[] v2)
        {
            fixed (GLfloat v1_ptr = v1)
            {
                Rectfv(v1_ptr, v2);
            }
            fixed (GLfloat v1_ptr = v1)
            fixed (GLfloat v2_ptr = v2)
            {
                Rectfv(v1_ptr, v2_ptr);
            }
        }
        
        public static unsafe void Rectfv(GLfloat[] v1, ref GLfloat v2)
        {
            fixed (GLfloat v1_ptr = v1)
            {
                Rectfv(v1_ptr, v2);
            }
            fixed (GLfloat v1_ptr = v1)
            fixed (GLfloat v2_ptr = &v2)
            {
                Rectfv(v1_ptr, v2_ptr);
            }
        }
        
        public static unsafe void Rectfv(ref GLfloat v1, GLfloat* v2)
        {
            fixed (GLfloat v1_ptr = &v1)
            {
                Rectfv(v1_ptr, v2);
            }
        }
        
        public static unsafe void Rectfv(ref GLfloat v1, GLfloat[] v2)
        {
            fixed (GLfloat v1_ptr = &v1)
            {
                Rectfv(v1_ptr, v2);
            }
            fixed (GLfloat v1_ptr = &v1)
            fixed (GLfloat v2_ptr = v2)
            {
                Rectfv(v1_ptr, v2_ptr);
            }
        }
        
        public static unsafe void Rectfv(ref GLfloat v1, ref GLfloat v2)
        {
            fixed (GLfloat v1_ptr = &v1)
            {
                Rectfv(v1_ptr, v2);
            }
            fixed (GLfloat v1_ptr = &v1)
            fixed (GLfloat v2_ptr = &v2)
            {
                Rectfv(v1_ptr, v2_ptr);
            }
        }
        
        public static void Recti(GLint x1, GLint y1, GLint x2, GLint y2)
        {
            Recti(x1, y1, x2, y2);
        }
        
        public static unsafe void Rectiv(GLint* v1, GLint* v2)
        {
            return Rectiv(v1, v2);
        }
        
        public static unsafe void Rectiv(GLint* v1, GLint[] v2)
        {
            fixed (GLint v2_ptr = v2)
            {
                Rectiv(v1, v2_ptr);
            }
        }
        
        public static unsafe void Rectiv(GLint* v1, ref GLint v2)
        {
            fixed (GLint v2_ptr = &v2)
            {
                Rectiv(v1, v2_ptr);
            }
        }
        
        public static unsafe void Rectiv(GLint[] v1, GLint* v2)
        {
            fixed (GLint v1_ptr = v1)
            {
                Rectiv(v1_ptr, v2);
            }
        }
        
        public static unsafe void Rectiv(GLint[] v1, GLint[] v2)
        {
            fixed (GLint v1_ptr = v1)
            {
                Rectiv(v1_ptr, v2);
            }
            fixed (GLint v1_ptr = v1)
            fixed (GLint v2_ptr = v2)
            {
                Rectiv(v1_ptr, v2_ptr);
            }
        }
        
        public static unsafe void Rectiv(GLint[] v1, ref GLint v2)
        {
            fixed (GLint v1_ptr = v1)
            {
                Rectiv(v1_ptr, v2);
            }
            fixed (GLint v1_ptr = v1)
            fixed (GLint v2_ptr = &v2)
            {
                Rectiv(v1_ptr, v2_ptr);
            }
        }
        
        public static unsafe void Rectiv(ref GLint v1, GLint* v2)
        {
            fixed (GLint v1_ptr = &v1)
            {
                Rectiv(v1_ptr, v2);
            }
        }
        
        public static unsafe void Rectiv(ref GLint v1, GLint[] v2)
        {
            fixed (GLint v1_ptr = &v1)
            {
                Rectiv(v1_ptr, v2);
            }
            fixed (GLint v1_ptr = &v1)
            fixed (GLint v2_ptr = v2)
            {
                Rectiv(v1_ptr, v2_ptr);
            }
        }
        
        public static unsafe void Rectiv(ref GLint v1, ref GLint v2)
        {
            fixed (GLint v1_ptr = &v1)
            {
                Rectiv(v1_ptr, v2);
            }
            fixed (GLint v1_ptr = &v1)
            fixed (GLint v2_ptr = &v2)
            {
                Rectiv(v1_ptr, v2_ptr);
            }
        }
        
        public static void Rects(GLshort x1, GLshort y1, GLshort x2, GLshort y2)
        {
            Rects(x1, y1, x2, y2);
        }
        
        public static unsafe void Rectsv(GLshort* v1, GLshort* v2)
        {
            return Rectsv(v1, v2);
        }
        
        public static unsafe void Rectsv(GLshort* v1, GLshort[] v2)
        {
            fixed (GLshort v2_ptr = v2)
            {
                Rectsv(v1, v2_ptr);
            }
        }
        
        public static unsafe void Rectsv(GLshort* v1, ref GLshort v2)
        {
            fixed (GLshort v2_ptr = &v2)
            {
                Rectsv(v1, v2_ptr);
            }
        }
        
        public static unsafe void Rectsv(GLshort[] v1, GLshort* v2)
        {
            fixed (GLshort v1_ptr = v1)
            {
                Rectsv(v1_ptr, v2);
            }
        }
        
        public static unsafe void Rectsv(GLshort[] v1, GLshort[] v2)
        {
            fixed (GLshort v1_ptr = v1)
            {
                Rectsv(v1_ptr, v2);
            }
            fixed (GLshort v1_ptr = v1)
            fixed (GLshort v2_ptr = v2)
            {
                Rectsv(v1_ptr, v2_ptr);
            }
        }
        
        public static unsafe void Rectsv(GLshort[] v1, ref GLshort v2)
        {
            fixed (GLshort v1_ptr = v1)
            {
                Rectsv(v1_ptr, v2);
            }
            fixed (GLshort v1_ptr = v1)
            fixed (GLshort v2_ptr = &v2)
            {
                Rectsv(v1_ptr, v2_ptr);
            }
        }
        
        public static unsafe void Rectsv(ref GLshort v1, GLshort* v2)
        {
            fixed (GLshort v1_ptr = &v1)
            {
                Rectsv(v1_ptr, v2);
            }
        }
        
        public static unsafe void Rectsv(ref GLshort v1, GLshort[] v2)
        {
            fixed (GLshort v1_ptr = &v1)
            {
                Rectsv(v1_ptr, v2);
            }
            fixed (GLshort v1_ptr = &v1)
            fixed (GLshort v2_ptr = v2)
            {
                Rectsv(v1_ptr, v2_ptr);
            }
        }
        
        public static unsafe void Rectsv(ref GLshort v1, ref GLshort v2)
        {
            fixed (GLshort v1_ptr = &v1)
            {
                Rectsv(v1_ptr, v2);
            }
            fixed (GLshort v1_ptr = &v1)
            fixed (GLshort v2_ptr = &v2)
            {
                Rectsv(v1_ptr, v2_ptr);
            }
        }
        
        public static void TexCoord1d(GLdouble s)
        {
            TexCoord1d(s);
        }
        
        public static unsafe void TexCoord1dv(GLdouble* v)
        {
            return TexCoord1dv(v);
        }
        
        public static unsafe void TexCoord1dv(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                TexCoord1dv(v_ptr);
            }
        }
        
        public static unsafe void TexCoord1dv(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                TexCoord1dv(v_ptr);
            }
        }
        
        public static void TexCoord1f(GLfloat s)
        {
            TexCoord1f(s);
        }
        
        public static unsafe void TexCoord1fv(GLfloat* v)
        {
            return TexCoord1fv(v);
        }
        
        public static unsafe void TexCoord1fv(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                TexCoord1fv(v_ptr);
            }
        }
        
        public static unsafe void TexCoord1fv(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord1fv(v_ptr);
            }
        }
        
        public static void TexCoord1i(GLint s)
        {
            TexCoord1i(s);
        }
        
        public static unsafe void TexCoord1iv(GLint* v)
        {
            return TexCoord1iv(v);
        }
        
        public static unsafe void TexCoord1iv(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                TexCoord1iv(v_ptr);
            }
        }
        
        public static unsafe void TexCoord1iv(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                TexCoord1iv(v_ptr);
            }
        }
        
        public static void TexCoord1s(GLshort s)
        {
            TexCoord1s(s);
        }
        
        public static unsafe void TexCoord1sv(GLshort* v)
        {
            return TexCoord1sv(v);
        }
        
        public static unsafe void TexCoord1sv(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                TexCoord1sv(v_ptr);
            }
        }
        
        public static unsafe void TexCoord1sv(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                TexCoord1sv(v_ptr);
            }
        }
        
        public static void TexCoord2d(GLdouble s, GLdouble t)
        {
            TexCoord2d(s, t);
        }
        
        public static unsafe void TexCoord2dv(GLdouble* v)
        {
            return TexCoord2dv(v);
        }
        
        public static unsafe void TexCoord2dv(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                TexCoord2dv(v_ptr);
            }
        }
        
        public static unsafe void TexCoord2dv(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                TexCoord2dv(v_ptr);
            }
        }
        
        public static void TexCoord2f(GLfloat s, GLfloat t)
        {
            TexCoord2f(s, t);
        }
        
        public static unsafe void TexCoord2fv(GLfloat* v)
        {
            return TexCoord2fv(v);
        }
        
        public static unsafe void TexCoord2fv(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fv(v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fv(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fv(v_ptr);
            }
        }
        
        public static void TexCoord2i(GLint s, GLint t)
        {
            TexCoord2i(s, t);
        }
        
        public static unsafe void TexCoord2iv(GLint* v)
        {
            return TexCoord2iv(v);
        }
        
        public static unsafe void TexCoord2iv(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                TexCoord2iv(v_ptr);
            }
        }
        
        public static unsafe void TexCoord2iv(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                TexCoord2iv(v_ptr);
            }
        }
        
        public static void TexCoord2s(GLshort s, GLshort t)
        {
            TexCoord2s(s, t);
        }
        
        public static unsafe void TexCoord2sv(GLshort* v)
        {
            return TexCoord2sv(v);
        }
        
        public static unsafe void TexCoord2sv(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                TexCoord2sv(v_ptr);
            }
        }
        
        public static unsafe void TexCoord2sv(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                TexCoord2sv(v_ptr);
            }
        }
        
        public static void TexCoord3d(GLdouble s, GLdouble t, GLdouble r)
        {
            TexCoord3d(s, t, r);
        }
        
        public static unsafe void TexCoord3dv(GLdouble* v)
        {
            return TexCoord3dv(v);
        }
        
        public static unsafe void TexCoord3dv(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                TexCoord3dv(v_ptr);
            }
        }
        
        public static unsafe void TexCoord3dv(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                TexCoord3dv(v_ptr);
            }
        }
        
        public static void TexCoord3f(GLfloat s, GLfloat t, GLfloat r)
        {
            TexCoord3f(s, t, r);
        }
        
        public static unsafe void TexCoord3fv(GLfloat* v)
        {
            return TexCoord3fv(v);
        }
        
        public static unsafe void TexCoord3fv(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                TexCoord3fv(v_ptr);
            }
        }
        
        public static unsafe void TexCoord3fv(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord3fv(v_ptr);
            }
        }
        
        public static void TexCoord3i(GLint s, GLint t, GLint r)
        {
            TexCoord3i(s, t, r);
        }
        
        public static unsafe void TexCoord3iv(GLint* v)
        {
            return TexCoord3iv(v);
        }
        
        public static unsafe void TexCoord3iv(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                TexCoord3iv(v_ptr);
            }
        }
        
        public static unsafe void TexCoord3iv(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                TexCoord3iv(v_ptr);
            }
        }
        
        public static void TexCoord3s(GLshort s, GLshort t, GLshort r)
        {
            TexCoord3s(s, t, r);
        }
        
        public static unsafe void TexCoord3sv(GLshort* v)
        {
            return TexCoord3sv(v);
        }
        
        public static unsafe void TexCoord3sv(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                TexCoord3sv(v_ptr);
            }
        }
        
        public static unsafe void TexCoord3sv(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                TexCoord3sv(v_ptr);
            }
        }
        
        public static void TexCoord4d(GLdouble s, GLdouble t, GLdouble r, GLdouble q)
        {
            TexCoord4d(s, t, r, q);
        }
        
        public static unsafe void TexCoord4dv(GLdouble* v)
        {
            return TexCoord4dv(v);
        }
        
        public static unsafe void TexCoord4dv(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                TexCoord4dv(v_ptr);
            }
        }
        
        public static unsafe void TexCoord4dv(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                TexCoord4dv(v_ptr);
            }
        }
        
        public static void TexCoord4f(GLfloat s, GLfloat t, GLfloat r, GLfloat q)
        {
            TexCoord4f(s, t, r, q);
        }
        
        public static unsafe void TexCoord4fv(GLfloat* v)
        {
            return TexCoord4fv(v);
        }
        
        public static unsafe void TexCoord4fv(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fv(v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fv(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fv(v_ptr);
            }
        }
        
        public static void TexCoord4i(GLint s, GLint t, GLint r, GLint q)
        {
            TexCoord4i(s, t, r, q);
        }
        
        public static unsafe void TexCoord4iv(GLint* v)
        {
            return TexCoord4iv(v);
        }
        
        public static unsafe void TexCoord4iv(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                TexCoord4iv(v_ptr);
            }
        }
        
        public static unsafe void TexCoord4iv(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                TexCoord4iv(v_ptr);
            }
        }
        
        public static void TexCoord4s(GLshort s, GLshort t, GLshort r, GLshort q)
        {
            TexCoord4s(s, t, r, q);
        }
        
        public static unsafe void TexCoord4sv(GLshort* v)
        {
            return TexCoord4sv(v);
        }
        
        public static unsafe void TexCoord4sv(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                TexCoord4sv(v_ptr);
            }
        }
        
        public static unsafe void TexCoord4sv(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                TexCoord4sv(v_ptr);
            }
        }
        
        public static void Vertex2d(GLdouble x, GLdouble y)
        {
            Vertex2d(x, y);
        }
        
        public static unsafe void Vertex2dv(GLdouble* v)
        {
            return Vertex2dv(v);
        }
        
        public static unsafe void Vertex2dv(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                Vertex2dv(v_ptr);
            }
        }
        
        public static unsafe void Vertex2dv(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                Vertex2dv(v_ptr);
            }
        }
        
        public static void Vertex2f(GLfloat x, GLfloat y)
        {
            Vertex2f(x, y);
        }
        
        public static unsafe void Vertex2fv(GLfloat* v)
        {
            return Vertex2fv(v);
        }
        
        public static unsafe void Vertex2fv(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                Vertex2fv(v_ptr);
            }
        }
        
        public static unsafe void Vertex2fv(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                Vertex2fv(v_ptr);
            }
        }
        
        public static void Vertex2i(GLint x, GLint y)
        {
            Vertex2i(x, y);
        }
        
        public static unsafe void Vertex2iv(GLint* v)
        {
            return Vertex2iv(v);
        }
        
        public static unsafe void Vertex2iv(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                Vertex2iv(v_ptr);
            }
        }
        
        public static unsafe void Vertex2iv(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                Vertex2iv(v_ptr);
            }
        }
        
        public static void Vertex2s(GLshort x, GLshort y)
        {
            Vertex2s(x, y);
        }
        
        public static unsafe void Vertex2sv(GLshort* v)
        {
            return Vertex2sv(v);
        }
        
        public static unsafe void Vertex2sv(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                Vertex2sv(v_ptr);
            }
        }
        
        public static unsafe void Vertex2sv(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                Vertex2sv(v_ptr);
            }
        }
        
        public static void Vertex3d(GLdouble x, GLdouble y, GLdouble z)
        {
            Vertex3d(x, y, z);
        }
        
        public static unsafe void Vertex3dv(GLdouble* v)
        {
            return Vertex3dv(v);
        }
        
        public static unsafe void Vertex3dv(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                Vertex3dv(v_ptr);
            }
        }
        
        public static unsafe void Vertex3dv(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                Vertex3dv(v_ptr);
            }
        }
        
        public static void Vertex3f(GLfloat x, GLfloat y, GLfloat z)
        {
            Vertex3f(x, y, z);
        }
        
        public static unsafe void Vertex3fv(GLfloat* v)
        {
            return Vertex3fv(v);
        }
        
        public static unsafe void Vertex3fv(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                Vertex3fv(v_ptr);
            }
        }
        
        public static unsafe void Vertex3fv(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                Vertex3fv(v_ptr);
            }
        }
        
        public static void Vertex3i(GLint x, GLint y, GLint z)
        {
            Vertex3i(x, y, z);
        }
        
        public static unsafe void Vertex3iv(GLint* v)
        {
            return Vertex3iv(v);
        }
        
        public static unsafe void Vertex3iv(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                Vertex3iv(v_ptr);
            }
        }
        
        public static unsafe void Vertex3iv(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                Vertex3iv(v_ptr);
            }
        }
        
        public static void Vertex3s(GLshort x, GLshort y, GLshort z)
        {
            Vertex3s(x, y, z);
        }
        
        public static unsafe void Vertex3sv(GLshort* v)
        {
            return Vertex3sv(v);
        }
        
        public static unsafe void Vertex3sv(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                Vertex3sv(v_ptr);
            }
        }
        
        public static unsafe void Vertex3sv(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                Vertex3sv(v_ptr);
            }
        }
        
        public static void Vertex4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            Vertex4d(x, y, z, w);
        }
        
        public static unsafe void Vertex4dv(GLdouble* v)
        {
            return Vertex4dv(v);
        }
        
        public static unsafe void Vertex4dv(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                Vertex4dv(v_ptr);
            }
        }
        
        public static unsafe void Vertex4dv(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                Vertex4dv(v_ptr);
            }
        }
        
        public static void Vertex4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            Vertex4f(x, y, z, w);
        }
        
        public static unsafe void Vertex4fv(GLfloat* v)
        {
            return Vertex4fv(v);
        }
        
        public static unsafe void Vertex4fv(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                Vertex4fv(v_ptr);
            }
        }
        
        public static unsafe void Vertex4fv(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                Vertex4fv(v_ptr);
            }
        }
        
        public static void Vertex4i(GLint x, GLint y, GLint z, GLint w)
        {
            Vertex4i(x, y, z, w);
        }
        
        public static unsafe void Vertex4iv(GLint* v)
        {
            return Vertex4iv(v);
        }
        
        public static unsafe void Vertex4iv(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                Vertex4iv(v_ptr);
            }
        }
        
        public static unsafe void Vertex4iv(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                Vertex4iv(v_ptr);
            }
        }
        
        public static void Vertex4s(GLshort x, GLshort y, GLshort z, GLshort w)
        {
            Vertex4s(x, y, z, w);
        }
        
        public static unsafe void Vertex4sv(GLshort* v)
        {
            return Vertex4sv(v);
        }
        
        public static unsafe void Vertex4sv(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                Vertex4sv(v_ptr);
            }
        }
        
        public static unsafe void Vertex4sv(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                Vertex4sv(v_ptr);
            }
        }
        
        public static unsafe void ClipPlane(GL.Enums.ClipPlaneName plane, GLdouble* equation)
        {
            return ClipPlane(plane, equation);
        }
        
        public static void ColorMaterial(GL.Enums.MaterialFace face, GL.Enums.ColorMaterialParameter mode)
        {
            ColorMaterial(face, mode);
        }
        
        public static void CullFace(GL.Enums.CullFaceMode mode)
        {
            CullFace(mode);
        }
        
        public static void Fogf(GL.Enums.FogParameter pname, GLfloat param)
        {
            Fogf(pname, param);
        }
        
        public static unsafe void Fogfv(GL.Enums.FogParameter pname, GLfloat* @params)
        {
            return Fogfv(pname, @params);
        }
        
        public static void Fogi(GL.Enums.FogParameter pname, GLint param)
        {
            Fogi(pname, param);
        }
        
        public static unsafe void Fogiv(GL.Enums.FogParameter pname, GLint* @params)
        {
            return Fogiv(pname, @params);
        }
        
        public static void FrontFace(GL.Enums.FrontFaceDirection mode)
        {
            FrontFace(mode);
        }
        
        public static void Hint(GL.Enums.HintTarget target, GL.Enums.HintMode mode)
        {
            Hint(target, mode);
        }
        
        public static void Lightf(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLfloat param)
        {
            Lightf(light, pname, param);
        }
        
        public static unsafe void Lightfv(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLfloat* @params)
        {
            return Lightfv(light, pname, @params);
        }
        
        public static void Lighti(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLint param)
        {
            Lighti(light, pname, param);
        }
        
        public static unsafe void Lightiv(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLint* @params)
        {
            return Lightiv(light, pname, @params);
        }
        
        public static void LightModelf(GL.Enums.LightModelParameter pname, GLfloat param)
        {
            LightModelf(pname, param);
        }
        
        public static unsafe void LightModelfv(GL.Enums.LightModelParameter pname, GLfloat* @params)
        {
            return LightModelfv(pname, @params);
        }
        
        public static void LightModeli(GL.Enums.LightModelParameter pname, GLint param)
        {
            LightModeli(pname, param);
        }
        
        public static unsafe void LightModeliv(GL.Enums.LightModelParameter pname, GLint* @params)
        {
            return LightModeliv(pname, @params);
        }
        
        public static void LineWidth(GLfloat width)
        {
            LineWidth(width);
        }
        
        public static void Materialf(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat param)
        {
            Materialf(face, pname, param);
        }
        
        public static unsafe void Materialfv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat* @params)
        {
            return Materialfv(face, pname, @params);
        }
        
        public static void Materiali(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint param)
        {
            Materiali(face, pname, param);
        }
        
        public static unsafe void Materialiv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint* @params)
        {
            return Materialiv(face, pname, @params);
        }
        
        public static void PointSize(GLfloat size)
        {
            PointSize(size);
        }
        
        public static void PolygonMode(GL.Enums.MaterialFace face, GL.Enums.PolygonMode mode)
        {
            PolygonMode(face, mode);
        }
        
        public static unsafe void PolygonStipple(GLubyte* mask)
        {
            return PolygonStipple(mask);
        }
        
        public static unsafe void PolygonStipple(GLubyte[] mask)
        {
            fixed (GLubyte mask_ptr = mask)
            {
                PolygonStipple(mask_ptr);
            }
        }
        
        public static unsafe void PolygonStipple(ref GLubyte mask)
        {
            fixed (GLubyte mask_ptr = &mask)
            {
                PolygonStipple(mask_ptr);
            }
        }
        
        public static void Scissor(GLint x, GLint y, GLsizei width, GLsizei height)
        {
            Scissor(x, y, width, height);
        }
        
        public static void ShadeModel(GL.Enums.ShadingModel mode)
        {
            ShadeModel(mode);
        }
        
        public static void TexParameterf(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLfloat param)
        {
            TexParameterf(target, pname, param);
        }
        
        public static unsafe void TexParameterfv(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLfloat* @params)
        {
            return TexParameterfv(target, pname, @params);
        }
        
        public static void TexParameteri(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLint param)
        {
            TexParameteri(target, pname, param);
        }
        
        public static unsafe void TexParameteriv(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLint* @params)
        {
            return TexParameteriv(target, pname, @params);
        }
        
        public static unsafe void TexImage1D(GL.Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            return TexImage1D(target, level, internalformat, width, border, format, type, pixels);
        }
        
        public static unsafe void TexImage2D(GL.Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            return TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
        }
        
        public static void TexEnvf(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLfloat param)
        {
            TexEnvf(target, pname, param);
        }
        
        public static unsafe void TexEnvfv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLfloat* @params)
        {
            return TexEnvfv(target, pname, @params);
        }
        
        public static void TexEnvi(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLint param)
        {
            TexEnvi(target, pname, param);
        }
        
        public static unsafe void TexEnviv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLint* @params)
        {
            return TexEnviv(target, pname, @params);
        }
        
        public static void TexGend(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLdouble param)
        {
            TexGend(coord, pname, param);
        }
        
        public static unsafe void TexGendv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLdouble* @params)
        {
            return TexGendv(coord, pname, @params);
        }
        
        public static void TexGenf(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLfloat param)
        {
            TexGenf(coord, pname, param);
        }
        
        public static unsafe void TexGenfv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLfloat* @params)
        {
            return TexGenfv(coord, pname, @params);
        }
        
        public static void TexGeni(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLint param)
        {
            TexGeni(coord, pname, param);
        }
        
        public static unsafe void TexGeniv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLint* @params)
        {
            return TexGeniv(coord, pname, @params);
        }
        
        public static unsafe void FeedbackBuffer(GLsizei size, GL.Enums.FeedbackType type, GLfloat* buffer)
        {
            return FeedbackBuffer(size, type, buffer);
        }
        
        public static unsafe void SelectBuffer(GLsizei size, GLuint* buffer)
        {
            return SelectBuffer(size, buffer);
        }
        
        public static GLint RenderMode(GL.Enums.RenderingMode mode)
        {
            return RenderMode(mode);
        }
        
        public static void InitNames()
        {
            InitNames();
        }
        
        public static void LoadName(GLuint name)
        {
            LoadName(name);
        }
        
        public static void PassThrough(GLfloat token)
        {
            PassThrough(token);
        }
        
        public static void PopName()
        {
            PopName();
        }
        
        public static void PushName(GLuint name)
        {
            PushName(name);
        }
        
        public static void DrawBuffer(GL.Enums.DrawBufferMode mode)
        {
            DrawBuffer(mode);
        }
        
        public static void Clear(GL.Enums.ClearBufferMask mask)
        {
            Clear(mask);
        }
        
        public static void ClearAccum(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)
        {
            ClearAccum(red, green, blue, alpha);
        }
        
        public static void ClearIndex(GLfloat c)
        {
            ClearIndex(c);
        }
        
        public static void ClearColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha)
        {
            ClearColor(red, green, blue, alpha);
        }
        
        public static void ClearStencil(GLint s)
        {
            ClearStencil(s);
        }
        
        public static void ClearDepth(GLclampd depth)
        {
            ClearDepth(depth);
        }
        
        public static void StencilMask(GLuint mask)
        {
            StencilMask(mask);
        }
        
        public static void IndexMask(GLuint mask)
        {
            IndexMask(mask);
        }
        
        public static void Accum(GL.Enums.AccumOp op, GLfloat value)
        {
            Accum(op, value);
        }
        
        public static void Disable(GL.Enums.EnableCap cap)
        {
            Disable(cap);
        }
        
        public static void Enable(GL.Enums.EnableCap cap)
        {
            Enable(cap);
        }
        
        public static void Finish()
        {
            Finish();
        }
        
        public static void Flush()
        {
            Flush();
        }
        
        public static void PopAttrib()
        {
            PopAttrib();
        }
        
        public static void PushAttrib(GL.Enums.AttribMask mask)
        {
            PushAttrib(mask);
        }
        
        public static unsafe void Map1d(GL.Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint stride, GLint order, GLdouble* points)
        {
            return Map1d(target, u1, u2, stride, order, points);
        }
        
        public static unsafe void Map1f(GL.Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint stride, GLint order, GLfloat* points)
        {
            return Map1f(target, u1, u2, stride, order, points);
        }
        
        public static unsafe void Map2d(GL.Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble* points)
        {
            return Map2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        }
        
        public static unsafe void Map2f(GL.Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat* points)
        {
            return Map2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        }
        
        public static void MapGrid1d(GLint un, GLdouble u1, GLdouble u2)
        {
            MapGrid1d(un, u1, u2);
        }
        
        public static void MapGrid1f(GLint un, GLfloat u1, GLfloat u2)
        {
            MapGrid1f(un, u1, u2);
        }
        
        public static void MapGrid2d(GLint un, GLdouble u1, GLdouble u2, GLint vn, GLdouble v1, GLdouble v2)
        {
            MapGrid2d(un, u1, u2, vn, v1, v2);
        }
        
        public static void MapGrid2f(GLint un, GLfloat u1, GLfloat u2, GLint vn, GLfloat v1, GLfloat v2)
        {
            MapGrid2f(un, u1, u2, vn, v1, v2);
        }
        
        public static void EvalCoord1d(GLdouble u)
        {
            EvalCoord1d(u);
        }
        
        public static unsafe void EvalCoord1dv(GLdouble* u)
        {
            return EvalCoord1dv(u);
        }
        
        public static unsafe void EvalCoord1dv(GLdouble[] u)
        {
            fixed (GLdouble u_ptr = u)
            {
                EvalCoord1dv(u_ptr);
            }
        }
        
        public static unsafe void EvalCoord1dv(ref GLdouble u)
        {
            fixed (GLdouble u_ptr = &u)
            {
                EvalCoord1dv(u_ptr);
            }
        }
        
        public static void EvalCoord1f(GLfloat u)
        {
            EvalCoord1f(u);
        }
        
        public static unsafe void EvalCoord1fv(GLfloat* u)
        {
            return EvalCoord1fv(u);
        }
        
        public static unsafe void EvalCoord1fv(GLfloat[] u)
        {
            fixed (GLfloat u_ptr = u)
            {
                EvalCoord1fv(u_ptr);
            }
        }
        
        public static unsafe void EvalCoord1fv(ref GLfloat u)
        {
            fixed (GLfloat u_ptr = &u)
            {
                EvalCoord1fv(u_ptr);
            }
        }
        
        public static void EvalCoord2d(GLdouble u, GLdouble v)
        {
            EvalCoord2d(u, v);
        }
        
        public static unsafe void EvalCoord2dv(GLdouble* u)
        {
            return EvalCoord2dv(u);
        }
        
        public static unsafe void EvalCoord2dv(GLdouble[] u)
        {
            fixed (GLdouble u_ptr = u)
            {
                EvalCoord2dv(u_ptr);
            }
        }
        
        public static unsafe void EvalCoord2dv(ref GLdouble u)
        {
            fixed (GLdouble u_ptr = &u)
            {
                EvalCoord2dv(u_ptr);
            }
        }
        
        public static void EvalCoord2f(GLfloat u, GLfloat v)
        {
            EvalCoord2f(u, v);
        }
        
        public static unsafe void EvalCoord2fv(GLfloat* u)
        {
            return EvalCoord2fv(u);
        }
        
        public static unsafe void EvalCoord2fv(GLfloat[] u)
        {
            fixed (GLfloat u_ptr = u)
            {
                EvalCoord2fv(u_ptr);
            }
        }
        
        public static unsafe void EvalCoord2fv(ref GLfloat u)
        {
            fixed (GLfloat u_ptr = &u)
            {
                EvalCoord2fv(u_ptr);
            }
        }
        
        public static void EvalMesh1(GL.Enums.MeshMode1 mode, GLint i1, GLint i2)
        {
            EvalMesh1(mode, i1, i2);
        }
        
        public static void EvalPoint1(GLint i)
        {
            EvalPoint1(i);
        }
        
        public static void EvalMesh2(GL.Enums.MeshMode2 mode, GLint i1, GLint i2, GLint j1, GLint j2)
        {
            EvalMesh2(mode, i1, i2, j1, j2);
        }
        
        public static void EvalPoint2(GLint i, GLint j)
        {
            EvalPoint2(i, j);
        }
        
        public static void AlphaFunc(GL.Enums.AlphaFunction func, GLclampf @ref)
        {
            AlphaFunc(func, @ref);
        }
        
        public static void BlendFunc(GL.Enums.BlendingFactorSrc sfactor, GL.Enums.BlendingFactorDest dfactor)
        {
            BlendFunc(sfactor, dfactor);
        }
        
        public static void LogicOp(GL.Enums.LogicOp opcode)
        {
            LogicOp(opcode);
        }
        
        public static void StencilFunc(GL.Enums.StencilFunction func, GLint @ref, GLuint mask)
        {
            StencilFunc(func, @ref, mask);
        }
        
        public static void StencilOp(GL.Enums.StencilOp fail, GL.Enums.StencilOp zfail, GL.Enums.StencilOp zpass)
        {
            StencilOp(fail, zfail, zpass);
        }
        
        public static void DepthFunc(GL.Enums.DepthFunction func)
        {
            DepthFunc(func);
        }
        
        public static void PixelZoom(GLfloat xfactor, GLfloat yfactor)
        {
            PixelZoom(xfactor, yfactor);
        }
        
        public static void PixelTransferf(GL.Enums.PixelTransferParameter pname, GLfloat param)
        {
            PixelTransferf(pname, param);
        }
        
        public static void PixelTransferi(GL.Enums.PixelTransferParameter pname, GLint param)
        {
            PixelTransferi(pname, param);
        }
        
        public static void PixelStoref(GL.Enums.PixelStoreParameter pname, GLfloat param)
        {
            PixelStoref(pname, param);
        }
        
        public static void PixelStorei(GL.Enums.PixelStoreParameter pname, GLint param)
        {
            PixelStorei(pname, param);
        }
        
        public static unsafe void PixelMapfv(GL.Enums.PixelMap map, GLint mapsize, GLfloat* values)
        {
            return PixelMapfv(map, mapsize, values);
        }
        
        public static unsafe void PixelMapuiv(GL.Enums.PixelMap map, GLint mapsize, GLuint* values)
        {
            return PixelMapuiv(map, mapsize, values);
        }
        
        public static unsafe void PixelMapusv(GL.Enums.PixelMap map, GLint mapsize, GLushort* values)
        {
            return PixelMapusv(map, mapsize, values);
        }
        
        public static void ReadBuffer(GL.Enums.ReadBufferMode mode)
        {
            ReadBuffer(mode);
        }
        
        public static void CopyPixels(GLint x, GLint y, GLsizei width, GLsizei height, GL.Enums.PixelCopyType type)
        {
            CopyPixels(x, y, width, height, type);
        }
        
        public static unsafe void ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            return ReadPixels(x, y, width, height, format, type, pixels);
        }
        
        public static unsafe void DrawPixels(GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            return DrawPixels(width, height, format, type, pixels);
        }
        
        public static unsafe void GetBooleanv(GL.Enums.GetPName pname, GL.Enums.Boolean* @params)
        {
            return GetBooleanv(pname, @params);
        }
        
        public static unsafe void GetClipPlane(GL.Enums.ClipPlaneName plane, GLdouble* equation)
        {
            return GetClipPlane(plane, equation);
        }
        
        public static unsafe void GetDoublev(GL.Enums.GetPName pname, GLdouble* @params)
        {
            return GetDoublev(pname, @params);
        }
        
        public static GL.Enums.GLenum GetError()
        {
            return GetError();
        }
        
        public static unsafe void GetFloatv(GL.Enums.GetPName pname, GLfloat* @params)
        {
            return GetFloatv(pname, @params);
        }
        
        public static unsafe void GetIntegerv(GL.Enums.GetPName pname, GLint* @params)
        {
            return GetIntegerv(pname, @params);
        }
        
        public static unsafe void GetLightfv(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLfloat* @params)
        {
            return GetLightfv(light, pname, @params);
        }
        
        public static unsafe void GetLightiv(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLint* @params)
        {
            return GetLightiv(light, pname, @params);
        }
        
        public static unsafe void GetMapdv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, GLdouble* v)
        {
            return GetMapdv(target, query, v);
        }
        
        public static unsafe void GetMapfv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, GLfloat* v)
        {
            return GetMapfv(target, query, v);
        }
        
        public static unsafe void GetMapiv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, GLint* v)
        {
            return GetMapiv(target, query, v);
        }
        
        public static unsafe void GetMaterialfv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat* @params)
        {
            return GetMaterialfv(face, pname, @params);
        }
        
        public static unsafe void GetMaterialiv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint* @params)
        {
            return GetMaterialiv(face, pname, @params);
        }
        
        public static unsafe void GetPixelMapfv(GL.Enums.PixelMap map, GLfloat* values)
        {
            return GetPixelMapfv(map, values);
        }
        
        public static unsafe void GetPixelMapuiv(GL.Enums.PixelMap map, GLuint* values)
        {
            return GetPixelMapuiv(map, values);
        }
        
        public static unsafe void GetPixelMapusv(GL.Enums.PixelMap map, GLushort* values)
        {
            return GetPixelMapusv(map, values);
        }
        
        public static unsafe void GetPolygonStipple(GLubyte* mask)
        {
            return GetPolygonStipple(mask);
        }
        
        public static unsafe void GetPolygonStipple(GLubyte[] mask)
        {
            mask = default(GLubyte);
            fixed (GLubyte mask_ptr = mask)
            {
                GetPolygonStipple(mask_ptr);
            }
        }
        
        public static unsafe void GetPolygonStipple(out GLubyte mask)
        {
            mask = default(GLubyte);
            fixed (GLubyte mask_ptr = &mask)
            {
                GetPolygonStipple(mask_ptr);
            }
        }
        
        public static System.String GetString(GL.Enums.StringName name)
        {
            return System.Runtime.InteropServices.Marhsal.PtrToStringAnsi(GetString(name));
        }
        
        public static unsafe void GetTexEnvfv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLfloat* @params)
        {
            return GetTexEnvfv(target, pname, @params);
        }
        
        public static unsafe void GetTexEnviv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLint* @params)
        {
            return GetTexEnviv(target, pname, @params);
        }
        
        public static unsafe void GetTexGendv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLdouble* @params)
        {
            return GetTexGendv(coord, pname, @params);
        }
        
        public static unsafe void GetTexGenfv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLfloat* @params)
        {
            return GetTexGenfv(coord, pname, @params);
        }
        
        public static unsafe void GetTexGeniv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLint* @params)
        {
            return GetTexGeniv(coord, pname, @params);
        }
        
        public static unsafe void GetTexImage(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            return GetTexImage(target, level, format, type, pixels);
        }
        
        public static unsafe void GetTexParameterfv(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, GLfloat* @params)
        {
            return GetTexParameterfv(target, pname, @params);
        }
        
        public static unsafe void GetTexParameteriv(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, GLint* @params)
        {
            return GetTexParameteriv(target, pname, @params);
        }
        
        public static unsafe void GetTexLevelParameterfv(GL.Enums.TextureTarget target, GLint level, GL.Enums.GetTextureParameter pname, GLfloat* @params)
        {
            return GetTexLevelParameterfv(target, level, pname, @params);
        }
        
        public static unsafe void GetTexLevelParameteriv(GL.Enums.TextureTarget target, GLint level, GL.Enums.GetTextureParameter pname, GLint* @params)
        {
            return GetTexLevelParameteriv(target, level, pname, @params);
        }
        
        public static GLboolean IsEnabled(GL.Enums.EnableCap cap)
        {
            return IsEnabled(cap);
        }
        
        public static GLboolean IsList(GLuint list)
        {
            return IsList(list);
        }
        
        public static void DepthRange(GLclampd near, GLclampd far)
        {
            DepthRange(near, far);
        }
        
        public static void Frustum(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar)
        {
            Frustum(left, right, bottom, top, zNear, zFar);
        }
        
        public static void LoadIdentity()
        {
            LoadIdentity();
        }
        
        public static unsafe void LoadMatrixf(GLfloat* m)
        {
            return LoadMatrixf(m);
        }
        
        public static unsafe void LoadMatrixf(GLfloat[] m)
        {
            fixed (GLfloat m_ptr = m)
            {
                LoadMatrixf(m_ptr);
            }
        }
        
        public static unsafe void LoadMatrixf(ref GLfloat m)
        {
            fixed (GLfloat m_ptr = &m)
            {
                LoadMatrixf(m_ptr);
            }
        }
        
        public static unsafe void LoadMatrixd(GLdouble* m)
        {
            return LoadMatrixd(m);
        }
        
        public static unsafe void LoadMatrixd(GLdouble[] m)
        {
            fixed (GLdouble m_ptr = m)
            {
                LoadMatrixd(m_ptr);
            }
        }
        
        public static unsafe void LoadMatrixd(ref GLdouble m)
        {
            fixed (GLdouble m_ptr = &m)
            {
                LoadMatrixd(m_ptr);
            }
        }
        
        public static void MatrixMode(GL.Enums.MatrixMode mode)
        {
            MatrixMode(mode);
        }
        
        public static unsafe void MultMatrixf(GLfloat* m)
        {
            return MultMatrixf(m);
        }
        
        public static unsafe void MultMatrixf(GLfloat[] m)
        {
            fixed (GLfloat m_ptr = m)
            {
                MultMatrixf(m_ptr);
            }
        }
        
        public static unsafe void MultMatrixf(ref GLfloat m)
        {
            fixed (GLfloat m_ptr = &m)
            {
                MultMatrixf(m_ptr);
            }
        }
        
        public static unsafe void MultMatrixd(GLdouble* m)
        {
            return MultMatrixd(m);
        }
        
        public static unsafe void MultMatrixd(GLdouble[] m)
        {
            fixed (GLdouble m_ptr = m)
            {
                MultMatrixd(m_ptr);
            }
        }
        
        public static unsafe void MultMatrixd(ref GLdouble m)
        {
            fixed (GLdouble m_ptr = &m)
            {
                MultMatrixd(m_ptr);
            }
        }
        
        public static void Ortho(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar)
        {
            Ortho(left, right, bottom, top, zNear, zFar);
        }
        
        public static void PopMatrix()
        {
            PopMatrix();
        }
        
        public static void PushMatrix()
        {
            PushMatrix();
        }
        
        public static void Rotated(GLdouble angle, GLdouble x, GLdouble y, GLdouble z)
        {
            Rotated(angle, x, y, z);
        }
        
        public static void Rotatef(GLfloat angle, GLfloat x, GLfloat y, GLfloat z)
        {
            Rotatef(angle, x, y, z);
        }
        
        public static void Scaled(GLdouble x, GLdouble y, GLdouble z)
        {
            Scaled(x, y, z);
        }
        
        public static void Scalef(GLfloat x, GLfloat y, GLfloat z)
        {
            Scalef(x, y, z);
        }
        
        public static void Translated(GLdouble x, GLdouble y, GLdouble z)
        {
            Translated(x, y, z);
        }
        
        public static void Translatef(GLfloat x, GLfloat y, GLfloat z)
        {
            Translatef(x, y, z);
        }
        
        public static void Viewport(GLint x, GLint y, GLsizei width, GLsizei height)
        {
            Viewport(x, y, width, height);
        }
        
        public static void ArrayElement(GLint i)
        {
            ArrayElement(i);
        }
        
        public static unsafe void ColorPointer(GLint size, GL.Enums.ColorPointerType type, GLsizei stride, void* pointer)
        {
            return ColorPointer(size, type, stride, pointer);
        }
        
        public static void DisableClientState(GL.Enums.EnableCap array)
        {
            DisableClientState(array);
        }
        
        public static void DrawArrays(GL.Enums.BeginMode mode, GLint first, GLsizei count)
        {
            DrawArrays(mode, first, count);
        }
        
        public static unsafe void DrawElements(GL.Enums.BeginMode mode, GLsizei count, GL.Enums.GLenum type, void* indices)
        {
            return DrawElements(mode, count, type, indices);
        }
        
        public static unsafe void EdgeFlagPointer(GLsizei stride, void* pointer)
        {
            return EdgeFlagPointer(stride, pointer);
        }
        
        public static void EnableClientState(GL.Enums.EnableCap array)
        {
            EnableClientState(array);
        }
        
        public static unsafe void GetPointerv(GL.Enums.GetPointervPName pname, void* @params)
        {
            return GetPointerv(pname, @params);
        }
        
        public static unsafe void IndexPointer(GL.Enums.IndexPointerType type, GLsizei stride, void* pointer)
        {
            return IndexPointer(type, stride, pointer);
        }
        
        public static unsafe void InterleavedArrays(GL.Enums.InterleavedArrayFormat format, GLsizei stride, void* pointer)
        {
            return InterleavedArrays(format, stride, pointer);
        }
        
        public static unsafe void NormalPointer(GL.Enums.NormalPointerType type, GLsizei stride, void* pointer)
        {
            return NormalPointer(type, stride, pointer);
        }
        
        public static unsafe void TexCoordPointer(GLint size, GL.Enums.TexCoordPointerType type, GLsizei stride, void* pointer)
        {
            return TexCoordPointer(size, type, stride, pointer);
        }
        
        public static unsafe void VertexPointer(GLint size, GL.Enums.VertexPointerType type, GLsizei stride, void* pointer)
        {
            return VertexPointer(size, type, stride, pointer);
        }
        
        public static void PolygonOffset(GLfloat factor, GLfloat units)
        {
            PolygonOffset(factor, units);
        }
        
        public static void CopyTexImage1D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLint border)
        {
            CopyTexImage1D(target, level, internalformat, x, y, width, border);
        }
        
        public static void CopyTexImage2D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)
        {
            CopyTexImage2D(target, level, internalformat, x, y, width, height, border);
        }
        
        public static void CopyTexSubImage1D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
        {
            CopyTexSubImage1D(target, level, xoffset, x, y, width);
        }
        
        public static void CopyTexSubImage2D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            CopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
        }
        
        public static unsafe void TexSubImage1D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            return TexSubImage1D(target, level, xoffset, width, format, type, pixels);
        }
        
        public static unsafe void TexSubImage2D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            return TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }
        
        public static unsafe GLboolean AreTexturesResident(GLsizei n, GLuint* textures, GL.Enums.Boolean* residences)
        {
            AreTexturesResident(n, textures, residences);
        }
        
        public static void BindTexture(GL.Enums.TextureTarget target, GLuint texture)
        {
            BindTexture(target, texture);
        }
        
        public static unsafe void DeleteTextures(GLsizei n, GLuint* textures)
        {
            return DeleteTextures(n, textures);
        }
        
        public static unsafe void GenTextures(GLsizei n, GLuint* textures)
        {
            return GenTextures(n, textures);
        }
        
        public static GLboolean IsTexture(GLuint texture)
        {
            return IsTexture(texture);
        }
        
        public static unsafe void PrioritizeTextures(GLsizei n, GLuint* textures, GLclampf* priorities)
        {
            return PrioritizeTextures(n, textures, priorities);
        }
        
        public static void Indexub(GLubyte c)
        {
            Indexub(c);
        }
        
        public static unsafe void Indexubv(GLubyte* c)
        {
            return Indexubv(c);
        }
        
        public static unsafe void Indexubv(GLubyte[] c)
        {
            fixed (GLubyte c_ptr = c)
            {
                Indexubv(c_ptr);
            }
        }
        
        public static unsafe void Indexubv(ref GLubyte c)
        {
            fixed (GLubyte c_ptr = &c)
            {
                Indexubv(c_ptr);
            }
        }
        
        public static void PopClientAttrib()
        {
            PopClientAttrib();
        }
        
        public static void PushClientAttrib(GL.Enums.ClientAttribMask mask)
        {
            PushClientAttrib(mask);
        }
        
        public static void BlendColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha)
        {
            BlendColor(red, green, blue, alpha);
        }
        
        public static void BlendEquation(GL.Enums.VERSION_1_2 mode)
        {
            BlendEquation(mode);
        }
        
        public static unsafe void DrawRangeElements(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count, GL.Enums.VERSION_1_2 type, void* indices)
        {
            return DrawRangeElements(mode, start, end, count, type, indices);
        }
        
        public static unsafe void ColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table)
        {
            return ColorTable(target, internalformat, width, format, type, table);
        }
        
        public static unsafe void ColorTableParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params)
        {
            return ColorTableParameterfv(target, pname, @params);
        }
        
        public static unsafe void ColorTableParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params)
        {
            return ColorTableParameteriv(target, pname, @params);
        }
        
        public static void CopyColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width)
        {
            CopyColorTable(target, internalformat, x, y, width);
        }
        
        public static unsafe void GetColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table)
        {
            return GetColorTable(target, format, type, table);
        }
        
        public static unsafe void GetColorTableParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params)
        {
            return GetColorTableParameterfv(target, pname, @params);
        }
        
        public static unsafe void GetColorTableParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params)
        {
            return GetColorTableParameteriv(target, pname, @params);
        }
        
        public static unsafe void ColorSubTable(GL.Enums.VERSION_1_2 target, GLsizei start, GLsizei count, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data)
        {
            return ColorSubTable(target, start, count, format, type, data);
        }
        
        public static void CopyColorSubTable(GL.Enums.VERSION_1_2 target, GLsizei start, GLint x, GLint y, GLsizei width)
        {
            CopyColorSubTable(target, start, x, y, width);
        }
        
        public static unsafe void ConvolutionFilter1D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image)
        {
            return ConvolutionFilter1D(target, internalformat, width, format, type, image);
        }
        
        public static unsafe void ConvolutionFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image)
        {
            return ConvolutionFilter2D(target, internalformat, width, height, format, type, image);
        }
        
        public static void ConvolutionParameterf(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat @params)
        {
            ConvolutionParameterf(target, pname, @params);
        }
        
        public static unsafe void ConvolutionParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params)
        {
            return ConvolutionParameterfv(target, pname, @params);
        }
        
        public static void ConvolutionParameteri(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint @params)
        {
            ConvolutionParameteri(target, pname, @params);
        }
        
        public static unsafe void ConvolutionParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params)
        {
            return ConvolutionParameteriv(target, pname, @params);
        }
        
        public static void CopyConvolutionFilter1D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width)
        {
            CopyConvolutionFilter1D(target, internalformat, x, y, width);
        }
        
        public static void CopyConvolutionFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            CopyConvolutionFilter2D(target, internalformat, x, y, width, height);
        }
        
        public static unsafe void GetConvolutionFilter(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image)
        {
            return GetConvolutionFilter(target, format, type, image);
        }
        
        public static unsafe void GetConvolutionParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params)
        {
            return GetConvolutionParameterfv(target, pname, @params);
        }
        
        public static unsafe void GetConvolutionParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params)
        {
            return GetConvolutionParameteriv(target, pname, @params);
        }
        
        public static unsafe void GetSeparableFilter(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column, void* span)
        {
            return GetSeparableFilter(target, format, type, row, column, span);
        }
        
        public static unsafe void SeparableFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column)
        {
            return SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
        }
        
        public static unsafe void GetHistogram(GL.Enums.VERSION_1_2 target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* values)
        {
            return GetHistogram(target, reset, format, type, values);
        }
        
        public static unsafe void GetHistogramParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params)
        {
            return GetHistogramParameterfv(target, pname, @params);
        }
        
        public static unsafe void GetHistogramParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params)
        {
            return GetHistogramParameteriv(target, pname, @params);
        }
        
        public static unsafe void GetMinmax(GL.Enums.VERSION_1_2 target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* values)
        {
            return GetMinmax(target, reset, format, type, values);
        }
        
        public static unsafe void GetMinmaxParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params)
        {
            return GetMinmaxParameterfv(target, pname, @params);
        }
        
        public static unsafe void GetMinmaxParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params)
        {
            return GetMinmaxParameteriv(target, pname, @params);
        }
        
        public static void ResetHistogram(GL.Enums.VERSION_1_2 target)
        {
            ResetHistogram(target);
        }
        
        public static void ResetMinmax(GL.Enums.VERSION_1_2 target)
        {
            ResetMinmax(target);
        }
        
        public static unsafe void TexImage3D(GL.Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            return TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
        }
        
        public static unsafe void TexSubImage3D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            return TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }
        
        public static void CopyTexSubImage3D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            CopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
        }
        
        public static void ActiveTexture(GL.Enums.VERSION_1_3 texture)
        {
            ActiveTexture(texture);
        }
        
        public static void ClientActiveTexture(GL.Enums.VERSION_1_3 texture)
        {
            ClientActiveTexture(texture);
        }
        
        public static void MultiTexCoord1d(GL.Enums.VERSION_1_3 target, GLdouble s)
        {
            MultiTexCoord1d(target, s);
        }
        
        public static unsafe void MultiTexCoord1dv(GL.Enums.VERSION_1_3 target, GLdouble* v)
        {
            return MultiTexCoord1dv(target, v);
        }
        
        public static void MultiTexCoord1f(GL.Enums.VERSION_1_3 target, GLfloat s)
        {
            MultiTexCoord1f(target, s);
        }
        
        public static unsafe void MultiTexCoord1fv(GL.Enums.VERSION_1_3 target, GLfloat* v)
        {
            return MultiTexCoord1fv(target, v);
        }
        
        public static void MultiTexCoord1i(GL.Enums.VERSION_1_3 target, GLint s)
        {
            MultiTexCoord1i(target, s);
        }
        
        public static unsafe void MultiTexCoord1iv(GL.Enums.VERSION_1_3 target, GLint* v)
        {
            return MultiTexCoord1iv(target, v);
        }
        
        public static void MultiTexCoord1s(GL.Enums.VERSION_1_3 target, GLshort s)
        {
            MultiTexCoord1s(target, s);
        }
        
        public static unsafe void MultiTexCoord1sv(GL.Enums.VERSION_1_3 target, GLshort* v)
        {
            return MultiTexCoord1sv(target, v);
        }
        
        public static void MultiTexCoord2d(GL.Enums.VERSION_1_3 target, GLdouble s, GLdouble t)
        {
            MultiTexCoord2d(target, s, t);
        }
        
        public static unsafe void MultiTexCoord2dv(GL.Enums.VERSION_1_3 target, GLdouble* v)
        {
            return MultiTexCoord2dv(target, v);
        }
        
        public static void MultiTexCoord2f(GL.Enums.VERSION_1_3 target, GLfloat s, GLfloat t)
        {
            MultiTexCoord2f(target, s, t);
        }
        
        public static unsafe void MultiTexCoord2fv(GL.Enums.VERSION_1_3 target, GLfloat* v)
        {
            return MultiTexCoord2fv(target, v);
        }
        
        public static void MultiTexCoord2i(GL.Enums.VERSION_1_3 target, GLint s, GLint t)
        {
            MultiTexCoord2i(target, s, t);
        }
        
        public static unsafe void MultiTexCoord2iv(GL.Enums.VERSION_1_3 target, GLint* v)
        {
            return MultiTexCoord2iv(target, v);
        }
        
        public static void MultiTexCoord2s(GL.Enums.VERSION_1_3 target, GLshort s, GLshort t)
        {
            MultiTexCoord2s(target, s, t);
        }
        
        public static unsafe void MultiTexCoord2sv(GL.Enums.VERSION_1_3 target, GLshort* v)
        {
            return MultiTexCoord2sv(target, v);
        }
        
        public static void MultiTexCoord3d(GL.Enums.VERSION_1_3 target, GLdouble s, GLdouble t, GLdouble r)
        {
            MultiTexCoord3d(target, s, t, r);
        }
        
        public static unsafe void MultiTexCoord3dv(GL.Enums.VERSION_1_3 target, GLdouble* v)
        {
            return MultiTexCoord3dv(target, v);
        }
        
        public static void MultiTexCoord3f(GL.Enums.VERSION_1_3 target, GLfloat s, GLfloat t, GLfloat r)
        {
            MultiTexCoord3f(target, s, t, r);
        }
        
        public static unsafe void MultiTexCoord3fv(GL.Enums.VERSION_1_3 target, GLfloat* v)
        {
            return MultiTexCoord3fv(target, v);
        }
        
        public static void MultiTexCoord3i(GL.Enums.VERSION_1_3 target, GLint s, GLint t, GLint r)
        {
            MultiTexCoord3i(target, s, t, r);
        }
        
        public static unsafe void MultiTexCoord3iv(GL.Enums.VERSION_1_3 target, GLint* v)
        {
            return MultiTexCoord3iv(target, v);
        }
        
        public static void MultiTexCoord3s(GL.Enums.VERSION_1_3 target, GLshort s, GLshort t, GLshort r)
        {
            MultiTexCoord3s(target, s, t, r);
        }
        
        public static unsafe void MultiTexCoord3sv(GL.Enums.VERSION_1_3 target, GLshort* v)
        {
            return MultiTexCoord3sv(target, v);
        }
        
        public static void MultiTexCoord4d(GL.Enums.VERSION_1_3 target, GLdouble s, GLdouble t, GLdouble r, GLdouble q)
        {
            MultiTexCoord4d(target, s, t, r, q);
        }
        
        public static unsafe void MultiTexCoord4dv(GL.Enums.VERSION_1_3 target, GLdouble* v)
        {
            return MultiTexCoord4dv(target, v);
        }
        
        public static void MultiTexCoord4f(GL.Enums.VERSION_1_3 target, GLfloat s, GLfloat t, GLfloat r, GLfloat q)
        {
            MultiTexCoord4f(target, s, t, r, q);
        }
        
        public static unsafe void MultiTexCoord4fv(GL.Enums.VERSION_1_3 target, GLfloat* v)
        {
            return MultiTexCoord4fv(target, v);
        }
        
        public static void MultiTexCoord4i(GL.Enums.VERSION_1_3 target, GLint s, GLint t, GLint r, GLint q)
        {
            MultiTexCoord4i(target, s, t, r, q);
        }
        
        public static unsafe void MultiTexCoord4iv(GL.Enums.VERSION_1_3 target, GLint* v)
        {
            return MultiTexCoord4iv(target, v);
        }
        
        public static void MultiTexCoord4s(GL.Enums.VERSION_1_3 target, GLshort s, GLshort t, GLshort r, GLshort q)
        {
            MultiTexCoord4s(target, s, t, r, q);
        }
        
        public static unsafe void MultiTexCoord4sv(GL.Enums.VERSION_1_3 target, GLshort* v)
        {
            return MultiTexCoord4sv(target, v);
        }
        
        public static unsafe void LoadTransposeMatrixf(GLfloat* m)
        {
            return LoadTransposeMatrixf(m);
        }
        
        public static unsafe void LoadTransposeMatrixf(GLfloat[] m)
        {
            fixed (GLfloat m_ptr = m)
            {
                LoadTransposeMatrixf(m_ptr);
            }
        }
        
        public static unsafe void LoadTransposeMatrixf(ref GLfloat m)
        {
            fixed (GLfloat m_ptr = &m)
            {
                LoadTransposeMatrixf(m_ptr);
            }
        }
        
        public static unsafe void LoadTransposeMatrixd(GLdouble* m)
        {
            return LoadTransposeMatrixd(m);
        }
        
        public static unsafe void LoadTransposeMatrixd(GLdouble[] m)
        {
            fixed (GLdouble m_ptr = m)
            {
                LoadTransposeMatrixd(m_ptr);
            }
        }
        
        public static unsafe void LoadTransposeMatrixd(ref GLdouble m)
        {
            fixed (GLdouble m_ptr = &m)
            {
                LoadTransposeMatrixd(m_ptr);
            }
        }
        
        public static unsafe void MultTransposeMatrixf(GLfloat* m)
        {
            return MultTransposeMatrixf(m);
        }
        
        public static unsafe void MultTransposeMatrixf(GLfloat[] m)
        {
            fixed (GLfloat m_ptr = m)
            {
                MultTransposeMatrixf(m_ptr);
            }
        }
        
        public static unsafe void MultTransposeMatrixf(ref GLfloat m)
        {
            fixed (GLfloat m_ptr = &m)
            {
                MultTransposeMatrixf(m_ptr);
            }
        }
        
        public static unsafe void MultTransposeMatrixd(GLdouble* m)
        {
            return MultTransposeMatrixd(m);
        }
        
        public static unsafe void MultTransposeMatrixd(GLdouble[] m)
        {
            fixed (GLdouble m_ptr = m)
            {
                MultTransposeMatrixd(m_ptr);
            }
        }
        
        public static unsafe void MultTransposeMatrixd(ref GLdouble m)
        {
            fixed (GLdouble m_ptr = &m)
            {
                MultTransposeMatrixd(m_ptr);
            }
        }
        
        public static unsafe void CompressedTexImage3D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data)
        {
            return CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
        }
        
        public static unsafe void CompressedTexImage2D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data)
        {
            return CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
        }
        
        public static unsafe void CompressedTexImage1D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data)
        {
            return CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
        }
        
        public static unsafe void CompressedTexSubImage3D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GL.Enums.PixelFormat format, GLsizei imageSize, void* data)
        {
            return CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }
        
        public static unsafe void CompressedTexSubImage2D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GLsizei imageSize, void* data)
        {
            return CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }
        
        public static unsafe void CompressedTexSubImage1D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, GL.Enums.PixelFormat format, GLsizei imageSize, void* data)
        {
            return CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
        }
        
        public static unsafe void GetCompressedTexImage(GL.Enums.TextureTarget target, GLint level, void* img)
        {
            return GetCompressedTexImage(target, level, img);
        }
        
        public static void BlendFuncSeparate(GL.Enums.VERSION_1_4 sfactorRGB, GL.Enums.VERSION_1_4 dfactorRGB, GL.Enums.VERSION_1_4 sfactorAlpha, GL.Enums.VERSION_1_4 dfactorAlpha)
        {
            BlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        }
        
        public static void FogCoordf(GLfloat coord)
        {
            FogCoordf(coord);
        }
        
        public static unsafe void FogCoordfv(GLfloat* coord)
        {
            return FogCoordfv(coord);
        }
        
        public static unsafe void FogCoordfv(GLfloat[] coord)
        {
            fixed (GLfloat coord_ptr = coord)
            {
                FogCoordfv(coord_ptr);
            }
        }
        
        public static unsafe void FogCoordfv(ref GLfloat coord)
        {
            fixed (GLfloat coord_ptr = &coord)
            {
                FogCoordfv(coord_ptr);
            }
        }
        
        public static void FogCoordd(GLdouble coord)
        {
            FogCoordd(coord);
        }
        
        public static unsafe void FogCoorddv(GLdouble* coord)
        {
            return FogCoorddv(coord);
        }
        
        public static unsafe void FogCoorddv(GLdouble[] coord)
        {
            fixed (GLdouble coord_ptr = coord)
            {
                FogCoorddv(coord_ptr);
            }
        }
        
        public static unsafe void FogCoorddv(ref GLdouble coord)
        {
            fixed (GLdouble coord_ptr = &coord)
            {
                FogCoorddv(coord_ptr);
            }
        }
        
        public static unsafe void FogCoordPointer(GL.Enums.VERSION_1_4 type, GLsizei stride, void* pointer)
        {
            return FogCoordPointer(type, stride, pointer);
        }
        
        public static unsafe void MultiDrawArrays(GL.Enums.BeginMode mode, GLint* first, GLsizei* count, GLsizei primcount)
        {
            return MultiDrawArrays(mode, first, count, primcount);
        }
        
        public static unsafe void MultiDrawElements(GL.Enums.BeginMode mode, GLsizei* count, GL.Enums.VERSION_1_4 type, void* indices, GLsizei primcount)
        {
            return MultiDrawElements(mode, count, type, indices, primcount);
        }
        
        public static void PointParameterf(GL.Enums.VERSION_1_4 pname, GLfloat param)
        {
            PointParameterf(pname, param);
        }
        
        public static unsafe void PointParameterfv(GL.Enums.VERSION_1_4 pname, GLfloat* @params)
        {
            return PointParameterfv(pname, @params);
        }
        
        public static void PointParameteri(GL.Enums.VERSION_1_4 pname, GLint param)
        {
            PointParameteri(pname, param);
        }
        
        public static unsafe void PointParameteriv(GL.Enums.VERSION_1_4 pname, GLint* @params)
        {
            return PointParameteriv(pname, @params);
        }
        
        public static void SecondaryColor3b(GLbyte red, GLbyte green, GLbyte blue)
        {
            SecondaryColor3b(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3bv(GLbyte* v)
        {
            return SecondaryColor3bv(v);
        }
        
        public static unsafe void SecondaryColor3bv(GLbyte[] v)
        {
            fixed (GLbyte v_ptr = v)
            {
                SecondaryColor3bv(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3bv(ref GLbyte v)
        {
            fixed (GLbyte v_ptr = &v)
            {
                SecondaryColor3bv(v_ptr);
            }
        }
        
        public static void SecondaryColor3d(GLdouble red, GLdouble green, GLdouble blue)
        {
            SecondaryColor3d(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3dv(GLdouble* v)
        {
            return SecondaryColor3dv(v);
        }
        
        public static unsafe void SecondaryColor3dv(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                SecondaryColor3dv(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3dv(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                SecondaryColor3dv(v_ptr);
            }
        }
        
        public static void SecondaryColor3f(GLfloat red, GLfloat green, GLfloat blue)
        {
            SecondaryColor3f(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3fv(GLfloat* v)
        {
            return SecondaryColor3fv(v);
        }
        
        public static unsafe void SecondaryColor3fv(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                SecondaryColor3fv(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3fv(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                SecondaryColor3fv(v_ptr);
            }
        }
        
        public static void SecondaryColor3i(GLint red, GLint green, GLint blue)
        {
            SecondaryColor3i(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3iv(GLint* v)
        {
            return SecondaryColor3iv(v);
        }
        
        public static unsafe void SecondaryColor3iv(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                SecondaryColor3iv(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3iv(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                SecondaryColor3iv(v_ptr);
            }
        }
        
        public static void SecondaryColor3s(GLshort red, GLshort green, GLshort blue)
        {
            SecondaryColor3s(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3sv(GLshort* v)
        {
            return SecondaryColor3sv(v);
        }
        
        public static unsafe void SecondaryColor3sv(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                SecondaryColor3sv(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3sv(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                SecondaryColor3sv(v_ptr);
            }
        }
        
        public static void SecondaryColor3ub(GLubyte red, GLubyte green, GLubyte blue)
        {
            SecondaryColor3ub(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3ubv(GLubyte* v)
        {
            return SecondaryColor3ubv(v);
        }
        
        public static unsafe void SecondaryColor3ubv(GLubyte[] v)
        {
            fixed (GLubyte v_ptr = v)
            {
                SecondaryColor3ubv(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3ubv(ref GLubyte v)
        {
            fixed (GLubyte v_ptr = &v)
            {
                SecondaryColor3ubv(v_ptr);
            }
        }
        
        public static void SecondaryColor3ui(GLuint red, GLuint green, GLuint blue)
        {
            SecondaryColor3ui(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3uiv(GLuint* v)
        {
            return SecondaryColor3uiv(v);
        }
        
        public static unsafe void SecondaryColor3uiv(GLuint[] v)
        {
            fixed (GLuint v_ptr = v)
            {
                SecondaryColor3uiv(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3uiv(ref GLuint v)
        {
            fixed (GLuint v_ptr = &v)
            {
                SecondaryColor3uiv(v_ptr);
            }
        }
        
        public static void SecondaryColor3us(GLushort red, GLushort green, GLushort blue)
        {
            SecondaryColor3us(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3usv(GLushort* v)
        {
            return SecondaryColor3usv(v);
        }
        
        public static unsafe void SecondaryColor3usv(GLushort[] v)
        {
            fixed (GLushort v_ptr = v)
            {
                SecondaryColor3usv(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3usv(ref GLushort v)
        {
            fixed (GLushort v_ptr = &v)
            {
                SecondaryColor3usv(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColorPointer(GLint size, GL.Enums.ColorPointerType type, GLsizei stride, void* pointer)
        {
            return SecondaryColorPointer(size, type, stride, pointer);
        }
        
        public static void WindowPos2d(GLdouble x, GLdouble y)
        {
            WindowPos2d(x, y);
        }
        
        public static unsafe void WindowPos2dv(GLdouble* v)
        {
            return WindowPos2dv(v);
        }
        
        public static unsafe void WindowPos2dv(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                WindowPos2dv(v_ptr);
            }
        }
        
        public static unsafe void WindowPos2dv(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                WindowPos2dv(v_ptr);
            }
        }
        
        public static void WindowPos2f(GLfloat x, GLfloat y)
        {
            WindowPos2f(x, y);
        }
        
        public static unsafe void WindowPos2fv(GLfloat* v)
        {
            return WindowPos2fv(v);
        }
        
        public static unsafe void WindowPos2fv(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                WindowPos2fv(v_ptr);
            }
        }
        
        public static unsafe void WindowPos2fv(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                WindowPos2fv(v_ptr);
            }
        }
        
        public static void WindowPos2i(GLint x, GLint y)
        {
            WindowPos2i(x, y);
        }
        
        public static unsafe void WindowPos2iv(GLint* v)
        {
            return WindowPos2iv(v);
        }
        
        public static unsafe void WindowPos2iv(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                WindowPos2iv(v_ptr);
            }
        }
        
        public static unsafe void WindowPos2iv(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                WindowPos2iv(v_ptr);
            }
        }
        
        public static void WindowPos2s(GLshort x, GLshort y)
        {
            WindowPos2s(x, y);
        }
        
        public static unsafe void WindowPos2sv(GLshort* v)
        {
            return WindowPos2sv(v);
        }
        
        public static unsafe void WindowPos2sv(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                WindowPos2sv(v_ptr);
            }
        }
        
        public static unsafe void WindowPos2sv(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                WindowPos2sv(v_ptr);
            }
        }
        
        public static void WindowPos3d(GLdouble x, GLdouble y, GLdouble z)
        {
            WindowPos3d(x, y, z);
        }
        
        public static unsafe void WindowPos3dv(GLdouble* v)
        {
            return WindowPos3dv(v);
        }
        
        public static unsafe void WindowPos3dv(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                WindowPos3dv(v_ptr);
            }
        }
        
        public static unsafe void WindowPos3dv(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                WindowPos3dv(v_ptr);
            }
        }
        
        public static void WindowPos3f(GLfloat x, GLfloat y, GLfloat z)
        {
            WindowPos3f(x, y, z);
        }
        
        public static unsafe void WindowPos3fv(GLfloat* v)
        {
            return WindowPos3fv(v);
        }
        
        public static unsafe void WindowPos3fv(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                WindowPos3fv(v_ptr);
            }
        }
        
        public static unsafe void WindowPos3fv(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                WindowPos3fv(v_ptr);
            }
        }
        
        public static void WindowPos3i(GLint x, GLint y, GLint z)
        {
            WindowPos3i(x, y, z);
        }
        
        public static unsafe void WindowPos3iv(GLint* v)
        {
            return WindowPos3iv(v);
        }
        
        public static unsafe void WindowPos3iv(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                WindowPos3iv(v_ptr);
            }
        }
        
        public static unsafe void WindowPos3iv(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                WindowPos3iv(v_ptr);
            }
        }
        
        public static void WindowPos3s(GLshort x, GLshort y, GLshort z)
        {
            WindowPos3s(x, y, z);
        }
        
        public static unsafe void WindowPos3sv(GLshort* v)
        {
            return WindowPos3sv(v);
        }
        
        public static unsafe void WindowPos3sv(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                WindowPos3sv(v_ptr);
            }
        }
        
        public static unsafe void WindowPos3sv(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                WindowPos3sv(v_ptr);
            }
        }
        
        public static unsafe void GenQueries(GLsizei n, GLuint* ids)
        {
            return GenQueries(n, ids);
        }
        
        public static unsafe void DeleteQueries(GLsizei n, GLuint* ids)
        {
            return DeleteQueries(n, ids);
        }
        
        public static GLboolean IsQuery(GLuint id)
        {
            return IsQuery(id);
        }
        
        public static void BeginQuery(GL.Enums.GLenum target, GLuint id)
        {
            BeginQuery(target, id);
        }
        
        public static void EndQuery(GL.Enums.GLenum target)
        {
            EndQuery(target);
        }
        
        public static unsafe void GetQueryiv(GL.Enums.GLenum target, GL.Enums.GLenum pname, GLint* @params)
        {
            return GetQueryiv(target, pname, @params);
        }
        
        public static unsafe void GetQueryObjectiv(GLuint id, GL.Enums.GLenum pname, GLint* @params)
        {
            return GetQueryObjectiv(id, pname, @params);
        }
        
        public static unsafe void GetQueryObjectuiv(GLuint id, GL.Enums.GLenum pname, GLuint* @params)
        {
            return GetQueryObjectuiv(id, pname, @params);
        }
        
        public static void BindBuffer(GL.Enums.VERSION_1_5 target, GLuint buffer)
        {
            BindBuffer(target, buffer);
        }
        
        public static unsafe void DeleteBuffers(GLsizei n, GLuint* buffers)
        {
            return DeleteBuffers(n, buffers);
        }
        
        public static unsafe void GenBuffers(GLsizei n, GLuint* buffers)
        {
            return GenBuffers(n, buffers);
        }
        
        public static GLboolean IsBuffer(GLuint buffer)
        {
            return IsBuffer(buffer);
        }
        
        public static unsafe void BufferData(GL.Enums.VERSION_1_5 target, GLsizeiptr size, void* data, GL.Enums.VERSION_1_5 usage)
        {
            return BufferData(target, size, data, usage);
        }
        
        public static unsafe void BufferSubData(GL.Enums.VERSION_1_5 target, GLintptr offset, GLsizeiptr size, void* data)
        {
            return BufferSubData(target, offset, size, data);
        }
        
        public static unsafe void GetBufferSubData(GL.Enums.VERSION_1_5 target, GLintptr offset, GLsizeiptr size, void* data)
        {
            return GetBufferSubData(target, offset, size, data);
        }
        
        public static void MapBuffer(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 access)
        {
            MapBuffer(target, access);
        }
        
        public static GLboolean UnmapBuffer(GL.Enums.VERSION_1_5 target)
        {
            return UnmapBuffer(target);
        }
        
        public static unsafe void GetBufferParameteriv(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 pname, GLint* @params)
        {
            return GetBufferParameteriv(target, pname, @params);
        }
        
        public static unsafe void GetBufferPointerv(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 pname, void* @params)
        {
            return GetBufferPointerv(target, pname, @params);
        }
        
        public static void BlendEquationSeparate(GL.Enums.BlendEquationModeEXT modeRGB, GL.Enums.BlendEquationModeEXT modeAlpha)
        {
            BlendEquationSeparate(modeRGB, modeAlpha);
        }
        
        public static unsafe void DrawBuffers(GLsizei n, GL.Enums.VERSION_2_0* bufs)
        {
            return DrawBuffers(n, bufs);
        }
        
        public static void StencilOpSeparate(GL.Enums.VERSION_2_0 face, GL.Enums.StencilOp sfail, GL.Enums.StencilOp dpfail, GL.Enums.StencilOp dppass)
        {
            StencilOpSeparate(face, sfail, dpfail, dppass);
        }
        
        public static void StencilFuncSeparate(GL.Enums.StencilFunction frontfunc, GL.Enums.StencilFunction backfunc, GLint @ref, GLuint mask)
        {
            StencilFuncSeparate(frontfunc, backfunc, @ref, mask);
        }
        
        public static void StencilMaskSeparate(GL.Enums.VERSION_2_0 face, GLuint mask)
        {
            StencilMaskSeparate(face, mask);
        }
        
        public static void AttachShader(GLuint program, GLuint shader)
        {
            AttachShader(program, shader);
        }
        
        public static void CompileShader(GLuint shader)
        {
            CompileShader(shader);
        }
        
        public static GLuint CreateProgram()
        {
            return CreateProgram();
        }
        
        public static GLuint CreateShader(GL.Enums.GLenum type)
        {
            return CreateShader(type);
        }
        
        public static void DeleteProgram(GLuint program)
        {
            DeleteProgram(program);
        }
        
        public static void DeleteShader(GLuint shader)
        {
            DeleteShader(shader);
        }
        
        public static void DetachShader(GLuint program, GLuint shader)
        {
            DetachShader(program, shader);
        }
        
        public static void DisableVertexAttribArray(GLuint index)
        {
            DisableVertexAttribArray(index);
        }
        
        public static void EnableVertexAttribArray(GLuint index)
        {
            EnableVertexAttribArray(index);
        }
        
        public static unsafe void GetActiveAttrib(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GL.Enums.GLenum* type, System.Text.StringBuilder name)
        {
            return GetActiveAttrib(program, index, bufSize, length, size, type, name);
        }
        
        public static unsafe void GetActiveUniform(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GL.Enums.GLenum* type, System.Text.StringBuilder name)
        {
            return GetActiveUniform(program, index, bufSize, length, size, type, name);
        }
        
        public static unsafe void GetAttachedShaders(GLuint program, GLsizei maxCount, GLsizei* count, GLuint* obj)
        {
            return GetAttachedShaders(program, maxCount, count, obj);
        }
        
        public static unsafe void GetProgramiv(GLuint program, GL.Enums.GLenum pname, GLint* @params)
        {
            return GetProgramiv(program, pname, @params);
        }
        
        public static unsafe void GetProgramInfoLog(GLuint program, GLsizei bufSize, GLsizei* length, System.Text.StringBuilder infoLog)
        {
            return GetProgramInfoLog(program, bufSize, length, infoLog);
        }
        
        public static unsafe void GetShaderiv(GLuint shader, GL.Enums.GLenum pname, GLint* @params)
        {
            return GetShaderiv(shader, pname, @params);
        }
        
        public static unsafe void GetShaderInfoLog(GLuint shader, GLsizei bufSize, GLsizei* length, System.Text.StringBuilder infoLog)
        {
            return GetShaderInfoLog(shader, bufSize, length, infoLog);
        }
        
        public static unsafe void GetShaderSource(GLuint shader, GLsizei bufSize, GLsizei* length, System.Text.StringBuilder source)
        {
            return GetShaderSource(shader, bufSize, length, source);
        }
        
        public static unsafe void GetUniformfv(GLuint program, GLint location, GLfloat* @params)
        {
            return GetUniformfv(program, location, @params);
        }
        
        public static unsafe void GetUniformiv(GLuint program, GLint location, GLint* @params)
        {
            return GetUniformiv(program, location, @params);
        }
        
        public static unsafe void GetVertexAttribdv(GLuint index, GL.Enums.VERSION_2_0 pname, GLdouble* @params)
        {
            return GetVertexAttribdv(index, pname, @params);
        }
        
        public static unsafe void GetVertexAttribfv(GLuint index, GL.Enums.VERSION_2_0 pname, GLfloat* @params)
        {
            return GetVertexAttribfv(index, pname, @params);
        }
        
        public static unsafe void GetVertexAttribiv(GLuint index, GL.Enums.VERSION_2_0 pname, GLint* @params)
        {
            return GetVertexAttribiv(index, pname, @params);
        }
        
        public static unsafe void GetVertexAttribPointerv(GLuint index, GL.Enums.VERSION_2_0 pname, void* pointer)
        {
            return GetVertexAttribPointerv(index, pname, pointer);
        }
        
        public static GLboolean IsProgram(GLuint program)
        {
            return IsProgram(program);
        }
        
        public static GLboolean IsShader(GLuint shader)
        {
            return IsShader(shader);
        }
        
        public static void LinkProgram(GLuint program)
        {
            LinkProgram(program);
        }
        
        public static unsafe void ShaderSource(GLuint shader, GLsizei count, System.String @string, GLint* length)
        {
            return ShaderSource(shader, count, @string, length);
        }
        
        public static void UseProgram(GLuint program)
        {
            UseProgram(program);
        }
        
        public static void Uniform1f(GLint location, GLfloat v0)
        {
            Uniform1f(location, v0);
        }
        
        public static void Uniform2f(GLint location, GLfloat v0, GLfloat v1)
        {
            Uniform2f(location, v0, v1);
        }
        
        public static void Uniform3f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
        {
            Uniform3f(location, v0, v1, v2);
        }
        
        public static void Uniform4f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
        {
            Uniform4f(location, v0, v1, v2, v3);
        }
        
        public static void Uniform1i(GLint location, GLint v0)
        {
            Uniform1i(location, v0);
        }
        
        public static void Uniform2i(GLint location, GLint v0, GLint v1)
        {
            Uniform2i(location, v0, v1);
        }
        
        public static void Uniform3i(GLint location, GLint v0, GLint v1, GLint v2)
        {
            Uniform3i(location, v0, v1, v2);
        }
        
        public static void Uniform4i(GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
        {
            Uniform4i(location, v0, v1, v2, v3);
        }
        
        public static unsafe void Uniform1fv(GLint location, GLsizei count, GLfloat* value)
        {
            return Uniform1fv(location, count, value);
        }
        
        public static unsafe void Uniform2fv(GLint location, GLsizei count, GLfloat* value)
        {
            return Uniform2fv(location, count, value);
        }
        
        public static unsafe void Uniform3fv(GLint location, GLsizei count, GLfloat* value)
        {
            return Uniform3fv(location, count, value);
        }
        
        public static unsafe void Uniform4fv(GLint location, GLsizei count, GLfloat* value)
        {
            return Uniform4fv(location, count, value);
        }
        
        public static unsafe void Uniform1iv(GLint location, GLsizei count, GLint* value)
        {
            return Uniform1iv(location, count, value);
        }
        
        public static unsafe void Uniform2iv(GLint location, GLsizei count, GLint* value)
        {
            return Uniform2iv(location, count, value);
        }
        
        public static unsafe void Uniform3iv(GLint location, GLsizei count, GLint* value)
        {
            return Uniform3iv(location, count, value);
        }
        
        public static unsafe void Uniform4iv(GLint location, GLsizei count, GLint* value)
        {
            return Uniform4iv(location, count, value);
        }
        
        public static unsafe void UniformMatrix2fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            return UniformMatrix2fv(location, count, transpose, value);
        }
        
        public static unsafe void UniformMatrix3fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            return UniformMatrix3fv(location, count, transpose, value);
        }
        
        public static unsafe void UniformMatrix4fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            return UniformMatrix4fv(location, count, transpose, value);
        }
        
        public static void ValidateProgram(GLuint program)
        {
            ValidateProgram(program);
        }
        
        public static void VertexAttrib1d(GLuint index, GLdouble x)
        {
            VertexAttrib1d(index, x);
        }
        
        public static unsafe void VertexAttrib1dv(GLuint index, GLdouble* v)
        {
            return VertexAttrib1dv(index, v);
        }
        
        public static void VertexAttrib1f(GLuint index, GLfloat x)
        {
            VertexAttrib1f(index, x);
        }
        
        public static unsafe void VertexAttrib1fv(GLuint index, GLfloat* v)
        {
            return VertexAttrib1fv(index, v);
        }
        
        public static void VertexAttrib1s(GLuint index, GLshort x)
        {
            VertexAttrib1s(index, x);
        }
        
        public static unsafe void VertexAttrib1sv(GLuint index, GLshort* v)
        {
            return VertexAttrib1sv(index, v);
        }
        
        public static void VertexAttrib2d(GLuint index, GLdouble x, GLdouble y)
        {
            VertexAttrib2d(index, x, y);
        }
        
        public static unsafe void VertexAttrib2dv(GLuint index, GLdouble* v)
        {
            return VertexAttrib2dv(index, v);
        }
        
        public static void VertexAttrib2f(GLuint index, GLfloat x, GLfloat y)
        {
            VertexAttrib2f(index, x, y);
        }
        
        public static unsafe void VertexAttrib2fv(GLuint index, GLfloat* v)
        {
            return VertexAttrib2fv(index, v);
        }
        
        public static void VertexAttrib2s(GLuint index, GLshort x, GLshort y)
        {
            VertexAttrib2s(index, x, y);
        }
        
        public static unsafe void VertexAttrib2sv(GLuint index, GLshort* v)
        {
            return VertexAttrib2sv(index, v);
        }
        
        public static void VertexAttrib3d(GLuint index, GLdouble x, GLdouble y, GLdouble z)
        {
            VertexAttrib3d(index, x, y, z);
        }
        
        public static unsafe void VertexAttrib3dv(GLuint index, GLdouble* v)
        {
            return VertexAttrib3dv(index, v);
        }
        
        public static void VertexAttrib3f(GLuint index, GLfloat x, GLfloat y, GLfloat z)
        {
            VertexAttrib3f(index, x, y, z);
        }
        
        public static unsafe void VertexAttrib3fv(GLuint index, GLfloat* v)
        {
            return VertexAttrib3fv(index, v);
        }
        
        public static void VertexAttrib3s(GLuint index, GLshort x, GLshort y, GLshort z)
        {
            VertexAttrib3s(index, x, y, z);
        }
        
        public static unsafe void VertexAttrib3sv(GLuint index, GLshort* v)
        {
            return VertexAttrib3sv(index, v);
        }
        
        public static unsafe void VertexAttrib4Nbv(GLuint index, GLbyte* v)
        {
            return VertexAttrib4Nbv(index, v);
        }
        
        public static unsafe void VertexAttrib4Niv(GLuint index, GLint* v)
        {
            return VertexAttrib4Niv(index, v);
        }
        
        public static unsafe void VertexAttrib4Nsv(GLuint index, GLshort* v)
        {
            return VertexAttrib4Nsv(index, v);
        }
        
        public static void VertexAttrib4Nub(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)
        {
            VertexAttrib4Nub(index, x, y, z, w);
        }
        
        public static unsafe void VertexAttrib4Nubv(GLuint index, GLubyte* v)
        {
            return VertexAttrib4Nubv(index, v);
        }
        
        public static unsafe void VertexAttrib4Nuiv(GLuint index, GLuint* v)
        {
            return VertexAttrib4Nuiv(index, v);
        }
        
        public static unsafe void VertexAttrib4Nusv(GLuint index, GLushort* v)
        {
            return VertexAttrib4Nusv(index, v);
        }
        
        public static unsafe void VertexAttrib4bv(GLuint index, GLbyte* v)
        {
            return VertexAttrib4bv(index, v);
        }
        
        public static void VertexAttrib4d(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            VertexAttrib4d(index, x, y, z, w);
        }
        
        public static unsafe void VertexAttrib4dv(GLuint index, GLdouble* v)
        {
            return VertexAttrib4dv(index, v);
        }
        
        public static void VertexAttrib4f(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            VertexAttrib4f(index, x, y, z, w);
        }
        
        public static unsafe void VertexAttrib4fv(GLuint index, GLfloat* v)
        {
            return VertexAttrib4fv(index, v);
        }
        
        public static unsafe void VertexAttrib4iv(GLuint index, GLint* v)
        {
            return VertexAttrib4iv(index, v);
        }
        
        public static void VertexAttrib4s(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)
        {
            VertexAttrib4s(index, x, y, z, w);
        }
        
        public static unsafe void VertexAttrib4sv(GLuint index, GLshort* v)
        {
            return VertexAttrib4sv(index, v);
        }
        
        public static unsafe void VertexAttrib4ubv(GLuint index, GLubyte* v)
        {
            return VertexAttrib4ubv(index, v);
        }
        
        public static unsafe void VertexAttrib4uiv(GLuint index, GLuint* v)
        {
            return VertexAttrib4uiv(index, v);
        }
        
        public static unsafe void VertexAttrib4usv(GLuint index, GLushort* v)
        {
            return VertexAttrib4usv(index, v);
        }
        
        public static unsafe void VertexAttribPointer(GLuint index, GLint size, GL.Enums.VERSION_2_0 type, GL.Enums.Boolean normalized, GLsizei stride, void* pointer)
        {
            return VertexAttribPointer(index, size, type, normalized, stride, pointer);
        }
        
        public static unsafe void UniformMatrix2x3fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            return UniformMatrix2x3fv(location, count, transpose, value);
        }
        
        public static unsafe void UniformMatrix3x2fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            return UniformMatrix3x2fv(location, count, transpose, value);
        }
        
        public static unsafe void UniformMatrix2x4fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            return UniformMatrix2x4fv(location, count, transpose, value);
        }
        
        public static unsafe void UniformMatrix4x2fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            return UniformMatrix4x2fv(location, count, transpose, value);
        }
        
        public static unsafe void UniformMatrix3x4fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            return UniformMatrix3x4fv(location, count, transpose, value);
        }
        
        public static unsafe void UniformMatrix4x3fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            return UniformMatrix4x3fv(location, count, transpose, value);
        }
        
        public static void ActiveTextureARB(GL.Enums.ARB_multitexture texture)
        {
            ActiveTextureARB(texture);
        }
        
        public static void ClientActiveTextureARB(GL.Enums.ARB_multitexture texture)
        {
            ClientActiveTextureARB(texture);
        }
        
        public static void MultiTexCoord1dARB(GL.Enums.ARB_multitexture target, GLdouble s)
        {
            MultiTexCoord1dARB(target, s);
        }
        
        public static unsafe void MultiTexCoord1dvARB(GL.Enums.ARB_multitexture target, GLdouble* v)
        {
            return MultiTexCoord1dvARB(target, v);
        }
        
        public static void MultiTexCoord1fARB(GL.Enums.ARB_multitexture target, GLfloat s)
        {
            MultiTexCoord1fARB(target, s);
        }
        
        public static unsafe void MultiTexCoord1fvARB(GL.Enums.ARB_multitexture target, GLfloat* v)
        {
            return MultiTexCoord1fvARB(target, v);
        }
        
        public static void MultiTexCoord1iARB(GL.Enums.ARB_multitexture target, GLint s)
        {
            MultiTexCoord1iARB(target, s);
        }
        
        public static unsafe void MultiTexCoord1ivARB(GL.Enums.ARB_multitexture target, GLint* v)
        {
            return MultiTexCoord1ivARB(target, v);
        }
        
        public static void MultiTexCoord1sARB(GL.Enums.ARB_multitexture target, GLshort s)
        {
            MultiTexCoord1sARB(target, s);
        }
        
        public static unsafe void MultiTexCoord1svARB(GL.Enums.ARB_multitexture target, GLshort* v)
        {
            return MultiTexCoord1svARB(target, v);
        }
        
        public static void MultiTexCoord2dARB(GL.Enums.ARB_multitexture target, GLdouble s, GLdouble t)
        {
            MultiTexCoord2dARB(target, s, t);
        }
        
        public static unsafe void MultiTexCoord2dvARB(GL.Enums.ARB_multitexture target, GLdouble* v)
        {
            return MultiTexCoord2dvARB(target, v);
        }
        
        public static void MultiTexCoord2fARB(GL.Enums.ARB_multitexture target, GLfloat s, GLfloat t)
        {
            MultiTexCoord2fARB(target, s, t);
        }
        
        public static unsafe void MultiTexCoord2fvARB(GL.Enums.ARB_multitexture target, GLfloat* v)
        {
            return MultiTexCoord2fvARB(target, v);
        }
        
        public static void MultiTexCoord2iARB(GL.Enums.ARB_multitexture target, GLint s, GLint t)
        {
            MultiTexCoord2iARB(target, s, t);
        }
        
        public static unsafe void MultiTexCoord2ivARB(GL.Enums.ARB_multitexture target, GLint* v)
        {
            return MultiTexCoord2ivARB(target, v);
        }
        
        public static void MultiTexCoord2sARB(GL.Enums.ARB_multitexture target, GLshort s, GLshort t)
        {
            MultiTexCoord2sARB(target, s, t);
        }
        
        public static unsafe void MultiTexCoord2svARB(GL.Enums.ARB_multitexture target, GLshort* v)
        {
            return MultiTexCoord2svARB(target, v);
        }
        
        public static void MultiTexCoord3dARB(GL.Enums.ARB_multitexture target, GLdouble s, GLdouble t, GLdouble r)
        {
            MultiTexCoord3dARB(target, s, t, r);
        }
        
        public static unsafe void MultiTexCoord3dvARB(GL.Enums.ARB_multitexture target, GLdouble* v)
        {
            return MultiTexCoord3dvARB(target, v);
        }
        
        public static void MultiTexCoord3fARB(GL.Enums.ARB_multitexture target, GLfloat s, GLfloat t, GLfloat r)
        {
            MultiTexCoord3fARB(target, s, t, r);
        }
        
        public static unsafe void MultiTexCoord3fvARB(GL.Enums.ARB_multitexture target, GLfloat* v)
        {
            return MultiTexCoord3fvARB(target, v);
        }
        
        public static void MultiTexCoord3iARB(GL.Enums.ARB_multitexture target, GLint s, GLint t, GLint r)
        {
            MultiTexCoord3iARB(target, s, t, r);
        }
        
        public static unsafe void MultiTexCoord3ivARB(GL.Enums.ARB_multitexture target, GLint* v)
        {
            return MultiTexCoord3ivARB(target, v);
        }
        
        public static void MultiTexCoord3sARB(GL.Enums.ARB_multitexture target, GLshort s, GLshort t, GLshort r)
        {
            MultiTexCoord3sARB(target, s, t, r);
        }
        
        public static unsafe void MultiTexCoord3svARB(GL.Enums.ARB_multitexture target, GLshort* v)
        {
            return MultiTexCoord3svARB(target, v);
        }
        
        public static void MultiTexCoord4dARB(GL.Enums.ARB_multitexture target, GLdouble s, GLdouble t, GLdouble r, GLdouble q)
        {
            MultiTexCoord4dARB(target, s, t, r, q);
        }
        
        public static unsafe void MultiTexCoord4dvARB(GL.Enums.ARB_multitexture target, GLdouble* v)
        {
            return MultiTexCoord4dvARB(target, v);
        }
        
        public static void MultiTexCoord4fARB(GL.Enums.ARB_multitexture target, GLfloat s, GLfloat t, GLfloat r, GLfloat q)
        {
            MultiTexCoord4fARB(target, s, t, r, q);
        }
        
        public static unsafe void MultiTexCoord4fvARB(GL.Enums.ARB_multitexture target, GLfloat* v)
        {
            return MultiTexCoord4fvARB(target, v);
        }
        
        public static void MultiTexCoord4iARB(GL.Enums.ARB_multitexture target, GLint s, GLint t, GLint r, GLint q)
        {
            MultiTexCoord4iARB(target, s, t, r, q);
        }
        
        public static unsafe void MultiTexCoord4ivARB(GL.Enums.ARB_multitexture target, GLint* v)
        {
            return MultiTexCoord4ivARB(target, v);
        }
        
        public static void MultiTexCoord4sARB(GL.Enums.ARB_multitexture target, GLshort s, GLshort t, GLshort r, GLshort q)
        {
            MultiTexCoord4sARB(target, s, t, r, q);
        }
        
        public static unsafe void MultiTexCoord4svARB(GL.Enums.ARB_multitexture target, GLshort* v)
        {
            return MultiTexCoord4svARB(target, v);
        }
        
        public static unsafe void LoadTransposeMatrixfARB(GLfloat* m)
        {
            return LoadTransposeMatrixfARB(m);
        }
        
        public static unsafe void LoadTransposeMatrixfARB(GLfloat[] m)
        {
            fixed (GLfloat m_ptr = m)
            {
                LoadTransposeMatrixfARB(m_ptr);
            }
        }
        
        public static unsafe void LoadTransposeMatrixfARB(ref GLfloat m)
        {
            fixed (GLfloat m_ptr = &m)
            {
                LoadTransposeMatrixfARB(m_ptr);
            }
        }
        
        public static unsafe void LoadTransposeMatrixdARB(GLdouble* m)
        {
            return LoadTransposeMatrixdARB(m);
        }
        
        public static unsafe void LoadTransposeMatrixdARB(GLdouble[] m)
        {
            fixed (GLdouble m_ptr = m)
            {
                LoadTransposeMatrixdARB(m_ptr);
            }
        }
        
        public static unsafe void LoadTransposeMatrixdARB(ref GLdouble m)
        {
            fixed (GLdouble m_ptr = &m)
            {
                LoadTransposeMatrixdARB(m_ptr);
            }
        }
        
        public static unsafe void MultTransposeMatrixfARB(GLfloat* m)
        {
            return MultTransposeMatrixfARB(m);
        }
        
        public static unsafe void MultTransposeMatrixfARB(GLfloat[] m)
        {
            fixed (GLfloat m_ptr = m)
            {
                MultTransposeMatrixfARB(m_ptr);
            }
        }
        
        public static unsafe void MultTransposeMatrixfARB(ref GLfloat m)
        {
            fixed (GLfloat m_ptr = &m)
            {
                MultTransposeMatrixfARB(m_ptr);
            }
        }
        
        public static unsafe void MultTransposeMatrixdARB(GLdouble* m)
        {
            return MultTransposeMatrixdARB(m);
        }
        
        public static unsafe void MultTransposeMatrixdARB(GLdouble[] m)
        {
            fixed (GLdouble m_ptr = m)
            {
                MultTransposeMatrixdARB(m_ptr);
            }
        }
        
        public static unsafe void MultTransposeMatrixdARB(ref GLdouble m)
        {
            fixed (GLdouble m_ptr = &m)
            {
                MultTransposeMatrixdARB(m_ptr);
            }
        }
        
        public static unsafe void CompressedTexImage3DARB(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data)
        {
            return CompressedTexImage3DARB(target, level, internalformat, width, height, depth, border, imageSize, data);
        }
        
        public static unsafe void CompressedTexImage2DARB(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data)
        {
            return CompressedTexImage2DARB(target, level, internalformat, width, height, border, imageSize, data);
        }
        
        public static unsafe void CompressedTexImage1DARB(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data)
        {
            return CompressedTexImage1DARB(target, level, internalformat, width, border, imageSize, data);
        }
        
        public static unsafe void CompressedTexSubImage3DARB(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GL.Enums.PixelFormat format, GLsizei imageSize, void* data)
        {
            return CompressedTexSubImage3DARB(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }
        
        public static unsafe void CompressedTexSubImage2DARB(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GLsizei imageSize, void* data)
        {
            return CompressedTexSubImage2DARB(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }
        
        public static unsafe void CompressedTexSubImage1DARB(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, GL.Enums.PixelFormat format, GLsizei imageSize, void* data)
        {
            return CompressedTexSubImage1DARB(target, level, xoffset, width, format, imageSize, data);
        }
        
        public static unsafe void GetCompressedTexImageARB(GL.Enums.TextureTarget target, GLint level, void* img)
        {
            return GetCompressedTexImageARB(target, level, img);
        }
        
        public static void PointParameterfARB(GL.Enums.ARB_point_parameters pname, GLfloat param)
        {
            PointParameterfARB(pname, param);
        }
        
        public static unsafe void PointParameterfvARB(GL.Enums.ARB_point_parameters pname, GLfloat* @params)
        {
            return PointParameterfvARB(pname, @params);
        }
        
        public static unsafe void WeightbvARB(GLint size, GLbyte* weights)
        {
            return WeightbvARB(size, weights);
        }
        
        public static unsafe void WeightsvARB(GLint size, GLshort* weights)
        {
            return WeightsvARB(size, weights);
        }
        
        public static unsafe void WeightivARB(GLint size, GLint* weights)
        {
            return WeightivARB(size, weights);
        }
        
        public static unsafe void WeightfvARB(GLint size, GLfloat* weights)
        {
            return WeightfvARB(size, weights);
        }
        
        public static unsafe void WeightdvARB(GLint size, GLdouble* weights)
        {
            return WeightdvARB(size, weights);
        }
        
        public static unsafe void WeightubvARB(GLint size, GLubyte* weights)
        {
            return WeightubvARB(size, weights);
        }
        
        public static unsafe void WeightusvARB(GLint size, GLushort* weights)
        {
            return WeightusvARB(size, weights);
        }
        
        public static unsafe void WeightuivARB(GLint size, GLuint* weights)
        {
            return WeightuivARB(size, weights);
        }
        
        public static unsafe void WeightPointerARB(GLint size, GL.Enums.ARB_vertex_blend type, GLsizei stride, void* pointer)
        {
            return WeightPointerARB(size, type, stride, pointer);
        }
        
        public static void VertexBlendARB(GLint count)
        {
            VertexBlendARB(count);
        }
        
        public static void CurrentPaletteMatrixARB(GLint index)
        {
            CurrentPaletteMatrixARB(index);
        }
        
        public static unsafe void MatrixIndexubvARB(GLint size, GLubyte* indices)
        {
            return MatrixIndexubvARB(size, indices);
        }
        
        public static unsafe void MatrixIndexusvARB(GLint size, GLushort* indices)
        {
            return MatrixIndexusvARB(size, indices);
        }
        
        public static unsafe void MatrixIndexuivARB(GLint size, GLuint* indices)
        {
            return MatrixIndexuivARB(size, indices);
        }
        
        public static unsafe void MatrixIndexPointerARB(GLint size, GL.Enums.ARB_matrix_palette type, GLsizei stride, void* pointer)
        {
            return MatrixIndexPointerARB(size, type, stride, pointer);
        }
        
        public static void WindowPos2dARB(GLdouble x, GLdouble y)
        {
            WindowPos2dARB(x, y);
        }
        
        public static unsafe void WindowPos2dvARB(GLdouble* v)
        {
            return WindowPos2dvARB(v);
        }
        
        public static unsafe void WindowPos2dvARB(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                WindowPos2dvARB(v_ptr);
            }
        }
        
        public static unsafe void WindowPos2dvARB(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                WindowPos2dvARB(v_ptr);
            }
        }
        
        public static void WindowPos2fARB(GLfloat x, GLfloat y)
        {
            WindowPos2fARB(x, y);
        }
        
        public static unsafe void WindowPos2fvARB(GLfloat* v)
        {
            return WindowPos2fvARB(v);
        }
        
        public static unsafe void WindowPos2fvARB(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                WindowPos2fvARB(v_ptr);
            }
        }
        
        public static unsafe void WindowPos2fvARB(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                WindowPos2fvARB(v_ptr);
            }
        }
        
        public static void WindowPos2iARB(GLint x, GLint y)
        {
            WindowPos2iARB(x, y);
        }
        
        public static unsafe void WindowPos2ivARB(GLint* v)
        {
            return WindowPos2ivARB(v);
        }
        
        public static unsafe void WindowPos2ivARB(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                WindowPos2ivARB(v_ptr);
            }
        }
        
        public static unsafe void WindowPos2ivARB(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                WindowPos2ivARB(v_ptr);
            }
        }
        
        public static void WindowPos2sARB(GLshort x, GLshort y)
        {
            WindowPos2sARB(x, y);
        }
        
        public static unsafe void WindowPos2svARB(GLshort* v)
        {
            return WindowPos2svARB(v);
        }
        
        public static unsafe void WindowPos2svARB(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                WindowPos2svARB(v_ptr);
            }
        }
        
        public static unsafe void WindowPos2svARB(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                WindowPos2svARB(v_ptr);
            }
        }
        
        public static void WindowPos3dARB(GLdouble x, GLdouble y, GLdouble z)
        {
            WindowPos3dARB(x, y, z);
        }
        
        public static unsafe void WindowPos3dvARB(GLdouble* v)
        {
            return WindowPos3dvARB(v);
        }
        
        public static unsafe void WindowPos3dvARB(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                WindowPos3dvARB(v_ptr);
            }
        }
        
        public static unsafe void WindowPos3dvARB(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                WindowPos3dvARB(v_ptr);
            }
        }
        
        public static void WindowPos3fARB(GLfloat x, GLfloat y, GLfloat z)
        {
            WindowPos3fARB(x, y, z);
        }
        
        public static unsafe void WindowPos3fvARB(GLfloat* v)
        {
            return WindowPos3fvARB(v);
        }
        
        public static unsafe void WindowPos3fvARB(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                WindowPos3fvARB(v_ptr);
            }
        }
        
        public static unsafe void WindowPos3fvARB(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                WindowPos3fvARB(v_ptr);
            }
        }
        
        public static void WindowPos3iARB(GLint x, GLint y, GLint z)
        {
            WindowPos3iARB(x, y, z);
        }
        
        public static unsafe void WindowPos3ivARB(GLint* v)
        {
            return WindowPos3ivARB(v);
        }
        
        public static unsafe void WindowPos3ivARB(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                WindowPos3ivARB(v_ptr);
            }
        }
        
        public static unsafe void WindowPos3ivARB(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                WindowPos3ivARB(v_ptr);
            }
        }
        
        public static void WindowPos3sARB(GLshort x, GLshort y, GLshort z)
        {
            WindowPos3sARB(x, y, z);
        }
        
        public static unsafe void WindowPos3svARB(GLshort* v)
        {
            return WindowPos3svARB(v);
        }
        
        public static unsafe void WindowPos3svARB(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                WindowPos3svARB(v_ptr);
            }
        }
        
        public static unsafe void WindowPos3svARB(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                WindowPos3svARB(v_ptr);
            }
        }
        
        public static void VertexAttrib1dARB(GLuint index, GLdouble x)
        {
            VertexAttrib1dARB(index, x);
        }
        
        public static unsafe void VertexAttrib1dvARB(GLuint index, GLdouble* v)
        {
            return VertexAttrib1dvARB(index, v);
        }
        
        public static void VertexAttrib1fARB(GLuint index, GLfloat x)
        {
            VertexAttrib1fARB(index, x);
        }
        
        public static unsafe void VertexAttrib1fvARB(GLuint index, GLfloat* v)
        {
            return VertexAttrib1fvARB(index, v);
        }
        
        public static void VertexAttrib1sARB(GLuint index, GLshort x)
        {
            VertexAttrib1sARB(index, x);
        }
        
        public static unsafe void VertexAttrib1svARB(GLuint index, GLshort* v)
        {
            return VertexAttrib1svARB(index, v);
        }
        
        public static void VertexAttrib2dARB(GLuint index, GLdouble x, GLdouble y)
        {
            VertexAttrib2dARB(index, x, y);
        }
        
        public static unsafe void VertexAttrib2dvARB(GLuint index, GLdouble* v)
        {
            return VertexAttrib2dvARB(index, v);
        }
        
        public static void VertexAttrib2fARB(GLuint index, GLfloat x, GLfloat y)
        {
            VertexAttrib2fARB(index, x, y);
        }
        
        public static unsafe void VertexAttrib2fvARB(GLuint index, GLfloat* v)
        {
            return VertexAttrib2fvARB(index, v);
        }
        
        public static void VertexAttrib2sARB(GLuint index, GLshort x, GLshort y)
        {
            VertexAttrib2sARB(index, x, y);
        }
        
        public static unsafe void VertexAttrib2svARB(GLuint index, GLshort* v)
        {
            return VertexAttrib2svARB(index, v);
        }
        
        public static void VertexAttrib3dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z)
        {
            VertexAttrib3dARB(index, x, y, z);
        }
        
        public static unsafe void VertexAttrib3dvARB(GLuint index, GLdouble* v)
        {
            return VertexAttrib3dvARB(index, v);
        }
        
        public static void VertexAttrib3fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z)
        {
            VertexAttrib3fARB(index, x, y, z);
        }
        
        public static unsafe void VertexAttrib3fvARB(GLuint index, GLfloat* v)
        {
            return VertexAttrib3fvARB(index, v);
        }
        
        public static void VertexAttrib3sARB(GLuint index, GLshort x, GLshort y, GLshort z)
        {
            VertexAttrib3sARB(index, x, y, z);
        }
        
        public static unsafe void VertexAttrib3svARB(GLuint index, GLshort* v)
        {
            return VertexAttrib3svARB(index, v);
        }
        
        public static unsafe void VertexAttrib4NbvARB(GLuint index, GLbyte* v)
        {
            return VertexAttrib4NbvARB(index, v);
        }
        
        public static unsafe void VertexAttrib4NivARB(GLuint index, GLint* v)
        {
            return VertexAttrib4NivARB(index, v);
        }
        
        public static unsafe void VertexAttrib4NsvARB(GLuint index, GLshort* v)
        {
            return VertexAttrib4NsvARB(index, v);
        }
        
        public static void VertexAttrib4NubARB(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)
        {
            VertexAttrib4NubARB(index, x, y, z, w);
        }
        
        public static unsafe void VertexAttrib4NubvARB(GLuint index, GLubyte* v)
        {
            return VertexAttrib4NubvARB(index, v);
        }
        
        public static unsafe void VertexAttrib4NuivARB(GLuint index, GLuint* v)
        {
            return VertexAttrib4NuivARB(index, v);
        }
        
        public static unsafe void VertexAttrib4NusvARB(GLuint index, GLushort* v)
        {
            return VertexAttrib4NusvARB(index, v);
        }
        
        public static unsafe void VertexAttrib4bvARB(GLuint index, GLbyte* v)
        {
            return VertexAttrib4bvARB(index, v);
        }
        
        public static void VertexAttrib4dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            VertexAttrib4dARB(index, x, y, z, w);
        }
        
        public static unsafe void VertexAttrib4dvARB(GLuint index, GLdouble* v)
        {
            return VertexAttrib4dvARB(index, v);
        }
        
        public static void VertexAttrib4fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            VertexAttrib4fARB(index, x, y, z, w);
        }
        
        public static unsafe void VertexAttrib4fvARB(GLuint index, GLfloat* v)
        {
            return VertexAttrib4fvARB(index, v);
        }
        
        public static unsafe void VertexAttrib4ivARB(GLuint index, GLint* v)
        {
            return VertexAttrib4ivARB(index, v);
        }
        
        public static void VertexAttrib4sARB(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)
        {
            VertexAttrib4sARB(index, x, y, z, w);
        }
        
        public static unsafe void VertexAttrib4svARB(GLuint index, GLshort* v)
        {
            return VertexAttrib4svARB(index, v);
        }
        
        public static unsafe void VertexAttrib4ubvARB(GLuint index, GLubyte* v)
        {
            return VertexAttrib4ubvARB(index, v);
        }
        
        public static unsafe void VertexAttrib4uivARB(GLuint index, GLuint* v)
        {
            return VertexAttrib4uivARB(index, v);
        }
        
        public static unsafe void VertexAttrib4usvARB(GLuint index, GLushort* v)
        {
            return VertexAttrib4usvARB(index, v);
        }
        
        public static unsafe void VertexAttribPointerARB(GLuint index, GLint size, GL.Enums.ARB_vertex_program type, GL.Enums.Boolean normalized, GLsizei stride, void* pointer)
        {
            return VertexAttribPointerARB(index, size, type, normalized, stride, pointer);
        }
        
        public static void EnableVertexAttribArrayARB(GLuint index)
        {
            EnableVertexAttribArrayARB(index);
        }
        
        public static void DisableVertexAttribArrayARB(GLuint index)
        {
            DisableVertexAttribArrayARB(index);
        }
        
        public static unsafe void ProgramStringARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program format, GLsizei len, void* @string)
        {
            return ProgramStringARB(target, format, len, @string);
        }
        
        public static void BindProgramARB(GL.Enums.ARB_vertex_program target, GLuint program)
        {
            BindProgramARB(target, program);
        }
        
        public static unsafe void DeleteProgramsARB(GLsizei n, GLuint* programs)
        {
            return DeleteProgramsARB(n, programs);
        }
        
        public static unsafe void GenProgramsARB(GLsizei n, GLuint* programs)
        {
            return GenProgramsARB(n, programs);
        }
        
        public static void ProgramEnvParameter4dARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            ProgramEnvParameter4dARB(target, index, x, y, z, w);
        }
        
        public static unsafe void ProgramEnvParameter4dvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble* @params)
        {
            return ProgramEnvParameter4dvARB(target, index, @params);
        }
        
        public static void ProgramEnvParameter4fARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            ProgramEnvParameter4fARB(target, index, x, y, z, w);
        }
        
        public static unsafe void ProgramEnvParameter4fvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat* @params)
        {
            return ProgramEnvParameter4fvARB(target, index, @params);
        }
        
        public static void ProgramLocalParameter4dARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            ProgramLocalParameter4dARB(target, index, x, y, z, w);
        }
        
        public static unsafe void ProgramLocalParameter4dvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble* @params)
        {
            return ProgramLocalParameter4dvARB(target, index, @params);
        }
        
        public static void ProgramLocalParameter4fARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            ProgramLocalParameter4fARB(target, index, x, y, z, w);
        }
        
        public static unsafe void ProgramLocalParameter4fvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat* @params)
        {
            return ProgramLocalParameter4fvARB(target, index, @params);
        }
        
        public static unsafe void GetProgramEnvParameterdvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble* @params)
        {
            return GetProgramEnvParameterdvARB(target, index, @params);
        }
        
        public static unsafe void GetProgramEnvParameterfvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat* @params)
        {
            return GetProgramEnvParameterfvARB(target, index, @params);
        }
        
        public static unsafe void GetProgramLocalParameterdvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble* @params)
        {
            return GetProgramLocalParameterdvARB(target, index, @params);
        }
        
        public static unsafe void GetProgramLocalParameterfvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat* @params)
        {
            return GetProgramLocalParameterfvARB(target, index, @params);
        }
        
        public static unsafe void GetProgramivARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program pname, GLint* @params)
        {
            return GetProgramivARB(target, pname, @params);
        }
        
        public static unsafe void GetProgramStringARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program pname, void* @string)
        {
            return GetProgramStringARB(target, pname, @string);
        }
        
        public static unsafe void GetVertexAttribdvARB(GLuint index, GL.Enums.ARB_vertex_program pname, GLdouble* @params)
        {
            return GetVertexAttribdvARB(index, pname, @params);
        }
        
        public static unsafe void GetVertexAttribfvARB(GLuint index, GL.Enums.ARB_vertex_program pname, GLfloat* @params)
        {
            return GetVertexAttribfvARB(index, pname, @params);
        }
        
        public static unsafe void GetVertexAttribivARB(GLuint index, GL.Enums.ARB_vertex_program pname, GLint* @params)
        {
            return GetVertexAttribivARB(index, pname, @params);
        }
        
        public static unsafe void GetVertexAttribPointervARB(GLuint index, GL.Enums.ARB_vertex_program pname, void* pointer)
        {
            return GetVertexAttribPointervARB(index, pname, pointer);
        }
        
        public static GLboolean IsProgramARB(GLuint program)
        {
            return IsProgramARB(program);
        }
        
        public static void BindBufferARB(GL.Enums.ARB_vertex_buffer_object target, GLuint buffer)
        {
            BindBufferARB(target, buffer);
        }
        
        public static unsafe void DeleteBuffersARB(GLsizei n, GLuint* buffers)
        {
            return DeleteBuffersARB(n, buffers);
        }
        
        public static unsafe void GenBuffersARB(GLsizei n, GLuint* buffers)
        {
            return GenBuffersARB(n, buffers);
        }
        
        public static GLboolean IsBufferARB(GLuint buffer)
        {
            return IsBufferARB(buffer);
        }
        
        public static unsafe void BufferDataARB(GL.Enums.ARB_vertex_buffer_object target, GLsizeiptrARB size, void* data, GL.Enums.ARB_vertex_buffer_object usage)
        {
            return BufferDataARB(target, size, data, usage);
        }
        
        public static unsafe void BufferSubDataARB(GL.Enums.ARB_vertex_buffer_object target, GLintptrARB offset, GLsizeiptrARB size, void* data)
        {
            return BufferSubDataARB(target, offset, size, data);
        }
        
        public static unsafe void GetBufferSubDataARB(GL.Enums.ARB_vertex_buffer_object target, GLintptrARB offset, GLsizeiptrARB size, void* data)
        {
            return GetBufferSubDataARB(target, offset, size, data);
        }
        
        public static void MapBufferARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object access)
        {
            MapBufferARB(target, access);
        }
        
        public static GLboolean UnmapBufferARB(GL.Enums.ARB_vertex_buffer_object target)
        {
            return UnmapBufferARB(target);
        }
        
        public static unsafe void GetBufferParameterivARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object pname, GLint* @params)
        {
            return GetBufferParameterivARB(target, pname, @params);
        }
        
        public static unsafe void GetBufferPointervARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object pname, void* @params)
        {
            return GetBufferPointervARB(target, pname, @params);
        }
        
        public static unsafe void GenQueriesARB(GLsizei n, GLuint* ids)
        {
            return GenQueriesARB(n, ids);
        }
        
        public static unsafe void DeleteQueriesARB(GLsizei n, GLuint* ids)
        {
            return DeleteQueriesARB(n, ids);
        }
        
        public static GLboolean IsQueryARB(GLuint id)
        {
            return IsQueryARB(id);
        }
        
        public static void BeginQueryARB(GL.Enums.GLenum target, GLuint id)
        {
            BeginQueryARB(target, id);
        }
        
        public static void EndQueryARB(GL.Enums.GLenum target)
        {
            EndQueryARB(target);
        }
        
        public static unsafe void GetQueryivARB(GL.Enums.GLenum target, GL.Enums.GLenum pname, GLint* @params)
        {
            return GetQueryivARB(target, pname, @params);
        }
        
        public static unsafe void GetQueryObjectivARB(GLuint id, GL.Enums.GLenum pname, GLint* @params)
        {
            return GetQueryObjectivARB(id, pname, @params);
        }
        
        public static unsafe void GetQueryObjectuivARB(GLuint id, GL.Enums.GLenum pname, GLuint* @params)
        {
            return GetQueryObjectuivARB(id, pname, @params);
        }
        
        public static void DeleteObjectARB(GLhandleARB obj)
        {
            DeleteObjectARB(obj);
        }
        
        public static GLhandleARB GetHandleARB(GL.Enums.GLenum pname)
        {
            return GetHandleARB(pname);
        }
        
        public static void DetachObjectARB(GLhandleARB containerObj, GLhandleARB attachedObj)
        {
            DetachObjectARB(containerObj, attachedObj);
        }
        
        public static GLhandleARB CreateShaderObjectARB(GL.Enums.GLenum shaderType)
        {
            return CreateShaderObjectARB(shaderType);
        }
        
        public static unsafe void ShaderSourceARB(GLhandleARB shaderObj, GLsizei count, System.String @string, GLint* length)
        {
            return ShaderSourceARB(shaderObj, count, @string, length);
        }
        
        public static void CompileShaderARB(GLhandleARB shaderObj)
        {
            CompileShaderARB(shaderObj);
        }
        
        public static GLhandleARB CreateProgramObjectARB()
        {
            return CreateProgramObjectARB();
        }
        
        public static void AttachObjectARB(GLhandleARB containerObj, GLhandleARB obj)
        {
            AttachObjectARB(containerObj, obj);
        }
        
        public static void LinkProgramARB(GLhandleARB programObj)
        {
            LinkProgramARB(programObj);
        }
        
        public static void UseProgramObjectARB(GLhandleARB programObj)
        {
            UseProgramObjectARB(programObj);
        }
        
        public static void ValidateProgramARB(GLhandleARB programObj)
        {
            ValidateProgramARB(programObj);
        }
        
        public static void Uniform1fARB(GLint location, GLfloat v0)
        {
            Uniform1fARB(location, v0);
        }
        
        public static void Uniform2fARB(GLint location, GLfloat v0, GLfloat v1)
        {
            Uniform2fARB(location, v0, v1);
        }
        
        public static void Uniform3fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
        {
            Uniform3fARB(location, v0, v1, v2);
        }
        
        public static void Uniform4fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
        {
            Uniform4fARB(location, v0, v1, v2, v3);
        }
        
        public static void Uniform1iARB(GLint location, GLint v0)
        {
            Uniform1iARB(location, v0);
        }
        
        public static void Uniform2iARB(GLint location, GLint v0, GLint v1)
        {
            Uniform2iARB(location, v0, v1);
        }
        
        public static void Uniform3iARB(GLint location, GLint v0, GLint v1, GLint v2)
        {
            Uniform3iARB(location, v0, v1, v2);
        }
        
        public static void Uniform4iARB(GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
        {
            Uniform4iARB(location, v0, v1, v2, v3);
        }
        
        public static unsafe void Uniform1fvARB(GLint location, GLsizei count, GLfloat* value)
        {
            return Uniform1fvARB(location, count, value);
        }
        
        public static unsafe void Uniform2fvARB(GLint location, GLsizei count, GLfloat* value)
        {
            return Uniform2fvARB(location, count, value);
        }
        
        public static unsafe void Uniform3fvARB(GLint location, GLsizei count, GLfloat* value)
        {
            return Uniform3fvARB(location, count, value);
        }
        
        public static unsafe void Uniform4fvARB(GLint location, GLsizei count, GLfloat* value)
        {
            return Uniform4fvARB(location, count, value);
        }
        
        public static unsafe void Uniform1ivARB(GLint location, GLsizei count, GLint* value)
        {
            return Uniform1ivARB(location, count, value);
        }
        
        public static unsafe void Uniform2ivARB(GLint location, GLsizei count, GLint* value)
        {
            return Uniform2ivARB(location, count, value);
        }
        
        public static unsafe void Uniform3ivARB(GLint location, GLsizei count, GLint* value)
        {
            return Uniform3ivARB(location, count, value);
        }
        
        public static unsafe void Uniform4ivARB(GLint location, GLsizei count, GLint* value)
        {
            return Uniform4ivARB(location, count, value);
        }
        
        public static unsafe void UniformMatrix2fvARB(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            return UniformMatrix2fvARB(location, count, transpose, value);
        }
        
        public static unsafe void UniformMatrix3fvARB(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            return UniformMatrix3fvARB(location, count, transpose, value);
        }
        
        public static unsafe void UniformMatrix4fvARB(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value)
        {
            return UniformMatrix4fvARB(location, count, transpose, value);
        }
        
        public static unsafe void GetObjectParameterfvARB(GLhandleARB obj, GL.Enums.GLenum pname, GLfloat* @params)
        {
            return GetObjectParameterfvARB(obj, pname, @params);
        }
        
        public static unsafe void GetObjectParameterivARB(GLhandleARB obj, GL.Enums.GLenum pname, GLint* @params)
        {
            return GetObjectParameterivARB(obj, pname, @params);
        }
        
        public static unsafe void GetInfoLogARB(GLhandleARB obj, GLsizei maxLength, GLsizei* length, System.Text.StringBuilder infoLog)
        {
            return GetInfoLogARB(obj, maxLength, length, infoLog);
        }
        
        public static unsafe void GetAttachedObjectsARB(GLhandleARB containerObj, GLsizei maxCount, GLsizei* count, GLhandleARB* obj)
        {
            return GetAttachedObjectsARB(containerObj, maxCount, count, obj);
        }
        
        public static unsafe void GetActiveUniformARB(GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GL.Enums.GLenum* type, System.Text.StringBuilder name)
        {
            return GetActiveUniformARB(programObj, index, maxLength, length, size, type, name);
        }
        
        public static unsafe void GetUniformfvARB(GLhandleARB programObj, GLint location, GLfloat* @params)
        {
            return GetUniformfvARB(programObj, location, @params);
        }
        
        public static unsafe void GetUniformivARB(GLhandleARB programObj, GLint location, GLint* @params)
        {
            return GetUniformivARB(programObj, location, @params);
        }
        
        public static unsafe void GetShaderSourceARB(GLhandleARB obj, GLsizei maxLength, GLsizei* length, System.Text.StringBuilder source)
        {
            return GetShaderSourceARB(obj, maxLength, length, source);
        }
        
        public static unsafe void GetActiveAttribARB(GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GL.Enums.GLenum* type, System.Text.StringBuilder name)
        {
            return GetActiveAttribARB(programObj, index, maxLength, length, size, type, name);
        }
        
        public static unsafe void DrawBuffersARB(GLsizei n, GL.Enums.ARB_draw_buffers* bufs)
        {
            return DrawBuffersARB(n, bufs);
        }
        
        public static void ClampColorARB(GL.Enums.ARB_color_buffer_float target, GL.Enums.ARB_color_buffer_float clamp)
        {
            ClampColorARB(target, clamp);
        }
        
        public static void BlendColorEXT(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha)
        {
            BlendColorEXT(red, green, blue, alpha);
        }
        
        public static void PolygonOffsetEXT(GLfloat factor, GLfloat bias)
        {
            PolygonOffsetEXT(factor, bias);
        }
        
        public static unsafe void TexImage3DEXT(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            return TexImage3DEXT(target, level, internalformat, width, height, depth, border, format, type, pixels);
        }
        
        public static unsafe void TexSubImage3DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            return TexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }
        
        public static unsafe void GetTexFilterFuncSGIS(GL.Enums.TextureTarget target, GL.Enums.SGIS_texture_filter4 filter, GLfloat* weights)
        {
            return GetTexFilterFuncSGIS(target, filter, weights);
        }
        
        public static unsafe void TexFilterFuncSGIS(GL.Enums.TextureTarget target, GL.Enums.SGIS_texture_filter4 filter, GLsizei n, GLfloat* weights)
        {
            return TexFilterFuncSGIS(target, filter, n, weights);
        }
        
        public static unsafe void TexSubImage1DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            return TexSubImage1DEXT(target, level, xoffset, width, format, type, pixels);
        }
        
        public static unsafe void TexSubImage2DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            return TexSubImage2DEXT(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }
        
        public static void CopyTexImage1DEXT(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLint border)
        {
            CopyTexImage1DEXT(target, level, internalformat, x, y, width, border);
        }
        
        public static void CopyTexImage2DEXT(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)
        {
            CopyTexImage2DEXT(target, level, internalformat, x, y, width, height, border);
        }
        
        public static void CopyTexSubImage1DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
        {
            CopyTexSubImage1DEXT(target, level, xoffset, x, y, width);
        }
        
        public static void CopyTexSubImage2DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            CopyTexSubImage2DEXT(target, level, xoffset, yoffset, x, y, width, height);
        }
        
        public static void CopyTexSubImage3DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            CopyTexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, x, y, width, height);
        }
        
        public static unsafe void GetHistogramEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* values)
        {
            return GetHistogramEXT(target, reset, format, type, values);
        }
        
        public static unsafe void GetHistogramParameterfvEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.GetHistogramParameterPNameEXT pname, GLfloat* @params)
        {
            return GetHistogramParameterfvEXT(target, pname, @params);
        }
        
        public static unsafe void GetHistogramParameterivEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.GetHistogramParameterPNameEXT pname, GLint* @params)
        {
            return GetHistogramParameterivEXT(target, pname, @params);
        }
        
        public static unsafe void GetMinmaxEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* values)
        {
            return GetMinmaxEXT(target, reset, format, type, values);
        }
        
        public static unsafe void GetMinmaxParameterfvEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.GetMinmaxParameterPNameEXT pname, GLfloat* @params)
        {
            return GetMinmaxParameterfvEXT(target, pname, @params);
        }
        
        public static unsafe void GetMinmaxParameterivEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.GetMinmaxParameterPNameEXT pname, GLint* @params)
        {
            return GetMinmaxParameterivEXT(target, pname, @params);
        }
        
        public static void ResetHistogramEXT(GL.Enums.HistogramTargetEXT target)
        {
            ResetHistogramEXT(target);
        }
        
        public static void ResetMinmaxEXT(GL.Enums.MinmaxTargetEXT target)
        {
            ResetMinmaxEXT(target);
        }
        
        public static unsafe void ConvolutionFilter1DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image)
        {
            return ConvolutionFilter1DEXT(target, internalformat, width, format, type, image);
        }
        
        public static unsafe void ConvolutionFilter2DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image)
        {
            return ConvolutionFilter2DEXT(target, internalformat, width, height, format, type, image);
        }
        
        public static void ConvolutionParameterfEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLfloat @params)
        {
            ConvolutionParameterfEXT(target, pname, @params);
        }
        
        public static unsafe void ConvolutionParameterfvEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLfloat* @params)
        {
            return ConvolutionParameterfvEXT(target, pname, @params);
        }
        
        public static void ConvolutionParameteriEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLint @params)
        {
            ConvolutionParameteriEXT(target, pname, @params);
        }
        
        public static unsafe void ConvolutionParameterivEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLint* @params)
        {
            return ConvolutionParameterivEXT(target, pname, @params);
        }
        
        public static void CopyConvolutionFilter1DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width)
        {
            CopyConvolutionFilter1DEXT(target, internalformat, x, y, width);
        }
        
        public static void CopyConvolutionFilter2DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            CopyConvolutionFilter2DEXT(target, internalformat, x, y, width, height);
        }
        
        public static unsafe void GetConvolutionFilterEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image)
        {
            return GetConvolutionFilterEXT(target, format, type, image);
        }
        
        public static unsafe void GetConvolutionParameterfvEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLfloat* @params)
        {
            return GetConvolutionParameterfvEXT(target, pname, @params);
        }
        
        public static unsafe void GetConvolutionParameterivEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLint* @params)
        {
            return GetConvolutionParameterivEXT(target, pname, @params);
        }
        
        public static unsafe void GetSeparableFilterEXT(GL.Enums.SeparableTargetEXT target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column, void* span)
        {
            return GetSeparableFilterEXT(target, format, type, row, column, span);
        }
        
        public static unsafe void SeparableFilter2DEXT(GL.Enums.SeparableTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column)
        {
            return SeparableFilter2DEXT(target, internalformat, width, height, format, type, row, column);
        }
        
        public static unsafe void ColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table)
        {
            return ColorTableSGI(target, internalformat, width, format, type, table);
        }
        
        public static unsafe void ColorTableParameterfvSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.ColorTableParameterPNameSGI pname, GLfloat* @params)
        {
            return ColorTableParameterfvSGI(target, pname, @params);
        }
        
        public static unsafe void ColorTableParameterivSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.ColorTableParameterPNameSGI pname, GLint* @params)
        {
            return ColorTableParameterivSGI(target, pname, @params);
        }
        
        public static void CopyColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width)
        {
            CopyColorTableSGI(target, internalformat, x, y, width);
        }
        
        public static unsafe void GetColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table)
        {
            return GetColorTableSGI(target, format, type, table);
        }
        
        public static unsafe void GetColorTableParameterfvSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.GetColorTableParameterPNameSGI pname, GLfloat* @params)
        {
            return GetColorTableParameterfvSGI(target, pname, @params);
        }
        
        public static unsafe void GetColorTableParameterivSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.GetColorTableParameterPNameSGI pname, GLint* @params)
        {
            return GetColorTableParameterivSGI(target, pname, @params);
        }
        
        public static void PixelTexGenSGIX(GL.Enums.SGIX_pixel_texture mode)
        {
            PixelTexGenSGIX(mode);
        }
        
        public static void PixelTexGenParameteriSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLint param)
        {
            PixelTexGenParameteriSGIS(pname, param);
        }
        
        public static unsafe void PixelTexGenParameterivSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLint* @params)
        {
            return PixelTexGenParameterivSGIS(pname, @params);
        }
        
        public static void PixelTexGenParameterfSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLfloat param)
        {
            PixelTexGenParameterfSGIS(pname, param);
        }
        
        public static unsafe void PixelTexGenParameterfvSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLfloat* @params)
        {
            return PixelTexGenParameterfvSGIS(pname, @params);
        }
        
        public static unsafe void GetPixelTexGenParameterivSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLint* @params)
        {
            return GetPixelTexGenParameterivSGIS(pname, @params);
        }
        
        public static unsafe void GetPixelTexGenParameterfvSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLfloat* @params)
        {
            return GetPixelTexGenParameterfvSGIS(pname, @params);
        }
        
        public static unsafe void TexImage4DSGIS(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            return TexImage4DSGIS(target, level, internalformat, width, height, depth, size4d, border, format, type, pixels);
        }
        
        public static unsafe void TexSubImage4DSGIS(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint woffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels)
        {
            return TexSubImage4DSGIS(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels);
        }
        
        public static unsafe GLboolean AreTexturesResidentEXT(GLsizei n, GLuint* textures, GL.Enums.Boolean* residences)
        {
            AreTexturesResidentEXT(n, textures, residences);
        }
        
        public static void BindTextureEXT(GL.Enums.TextureTarget target, GLuint texture)
        {
            BindTextureEXT(target, texture);
        }
        
        public static unsafe void DeleteTexturesEXT(GLsizei n, GLuint* textures)
        {
            return DeleteTexturesEXT(n, textures);
        }
        
        public static unsafe void GenTexturesEXT(GLsizei n, GLuint* textures)
        {
            return GenTexturesEXT(n, textures);
        }
        
        public static GLboolean IsTextureEXT(GLuint texture)
        {
            return IsTextureEXT(texture);
        }
        
        public static unsafe void PrioritizeTexturesEXT(GLsizei n, GLuint* textures, GLclampf* priorities)
        {
            return PrioritizeTexturesEXT(n, textures, priorities);
        }
        
        public static unsafe void DetailTexFuncSGIS(GL.Enums.TextureTarget target, GLsizei n, GLfloat* points)
        {
            return DetailTexFuncSGIS(target, n, points);
        }
        
        public static unsafe void GetDetailTexFuncSGIS(GL.Enums.TextureTarget target, GLfloat* points)
        {
            return GetDetailTexFuncSGIS(target, points);
        }
        
        public static unsafe void SharpenTexFuncSGIS(GL.Enums.TextureTarget target, GLsizei n, GLfloat* points)
        {
            return SharpenTexFuncSGIS(target, n, points);
        }
        
        public static unsafe void GetSharpenTexFuncSGIS(GL.Enums.TextureTarget target, GLfloat* points)
        {
            return GetSharpenTexFuncSGIS(target, points);
        }
        
        public static void SamplePatternSGIS(GL.Enums.SamplePatternSGIS pattern)
        {
            SamplePatternSGIS(pattern);
        }
        
        public static void ArrayElementEXT(GLint i)
        {
            ArrayElementEXT(i);
        }
        
        public static unsafe void ColorPointerEXT(GLint size, GL.Enums.ColorPointerType type, GLsizei stride, GLsizei count, void* pointer)
        {
            return ColorPointerEXT(size, type, stride, count, pointer);
        }
        
        public static void DrawArraysEXT(GL.Enums.BeginMode mode, GLint first, GLsizei count)
        {
            DrawArraysEXT(mode, first, count);
        }
        
        public static unsafe void EdgeFlagPointerEXT(GLsizei stride, GLsizei count, GL.Enums.Boolean* pointer)
        {
            return EdgeFlagPointerEXT(stride, count, pointer);
        }
        
        public static unsafe void GetPointervEXT(GL.Enums.GetPointervPName pname, void* @params)
        {
            return GetPointervEXT(pname, @params);
        }
        
        public static unsafe void IndexPointerEXT(GL.Enums.IndexPointerType type, GLsizei stride, GLsizei count, void* pointer)
        {
            return IndexPointerEXT(type, stride, count, pointer);
        }
        
        public static unsafe void NormalPointerEXT(GL.Enums.NormalPointerType type, GLsizei stride, GLsizei count, void* pointer)
        {
            return NormalPointerEXT(type, stride, count, pointer);
        }
        
        public static unsafe void TexCoordPointerEXT(GLint size, GL.Enums.TexCoordPointerType type, GLsizei stride, GLsizei count, void* pointer)
        {
            return TexCoordPointerEXT(size, type, stride, count, pointer);
        }
        
        public static unsafe void VertexPointerEXT(GLint size, GL.Enums.VertexPointerType type, GLsizei stride, GLsizei count, void* pointer)
        {
            return VertexPointerEXT(size, type, stride, count, pointer);
        }
        
        public static void BlendEquationEXT(GL.Enums.BlendEquationModeEXT mode)
        {
            BlendEquationEXT(mode);
        }
        
        public static void SpriteParameterfSGIX(GL.Enums.SGIX_sprite pname, GLfloat param)
        {
            SpriteParameterfSGIX(pname, param);
        }
        
        public static unsafe void SpriteParameterfvSGIX(GL.Enums.SGIX_sprite pname, GLfloat* @params)
        {
            return SpriteParameterfvSGIX(pname, @params);
        }
        
        public static void SpriteParameteriSGIX(GL.Enums.SGIX_sprite pname, GLint param)
        {
            SpriteParameteriSGIX(pname, param);
        }
        
        public static unsafe void SpriteParameterivSGIX(GL.Enums.SGIX_sprite pname, GLint* @params)
        {
            return SpriteParameterivSGIX(pname, @params);
        }
        
        public static void PointParameterfEXT(GL.Enums.EXT_point_parameters pname, GLfloat param)
        {
            PointParameterfEXT(pname, param);
        }
        
        public static unsafe void PointParameterfvEXT(GL.Enums.EXT_point_parameters pname, GLfloat* @params)
        {
            return PointParameterfvEXT(pname, @params);
        }
        
        public static void PointParameterfSGIS(GL.Enums.SGIS_point_parameters pname, GLfloat param)
        {
            PointParameterfSGIS(pname, param);
        }
        
        public static unsafe void PointParameterfvSGIS(GL.Enums.SGIS_point_parameters pname, GLfloat* @params)
        {
            return PointParameterfvSGIS(pname, @params);
        }
        
        public static GLint GetInstrumentsSGIX()
        {
            return GetInstrumentsSGIX();
        }
        
        public static unsafe void InstrumentsBufferSGIX(GLsizei size, GLint* buffer)
        {
            return InstrumentsBufferSGIX(size, buffer);
        }
        
        public static unsafe GLint PollInstrumentsSGIX(GLint* marker_p)
        {
            PollInstrumentsSGIX(marker_p);
        }
        
        public static unsafe GLint PollInstrumentsSGIX(GLint[] marker_p)
        {
            marker_p = default(GLint);
            fixed (GLint marker_p_ptr = marker_p)
            {
                GLint retval = PollInstrumentsSGIX(marker_p_ptr);
            }
            return retval;
        }
        
        public static unsafe GLint PollInstrumentsSGIX(out GLint marker_p)
        {
            marker_p = default(GLint);
            fixed (GLint marker_p_ptr = &marker_p)
            {
                GLint retval = PollInstrumentsSGIX(marker_p_ptr);
            }
            return retval;
        }
        
        public static void ReadInstrumentsSGIX(GLint marker)
        {
            ReadInstrumentsSGIX(marker);
        }
        
        public static void StartInstrumentsSGIX()
        {
            StartInstrumentsSGIX();
        }
        
        public static void StopInstrumentsSGIX(GLint marker)
        {
            StopInstrumentsSGIX(marker);
        }
        
        public static void FrameZoomSGIX(GLint factor)
        {
            FrameZoomSGIX(factor);
        }
        
        public static void TagSampleBufferSGIX()
        {
            TagSampleBufferSGIX();
        }
        
        public static unsafe void DeformationMap3dSGIX(GL.Enums.FfdTargetSGIX target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble w1, GLdouble w2, GLint wstride, GLint worder, GLdouble* points)
        {
            return DeformationMap3dSGIX(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points);
        }
        
        public static unsafe void DeformationMap3fSGIX(GL.Enums.FfdTargetSGIX target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat w1, GLfloat w2, GLint wstride, GLint worder, GLfloat* points)
        {
            return DeformationMap3fSGIX(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points);
        }
        
        public static void DeformSGIX(GL.Enums.FfdMaskSGIX mask)
        {
            DeformSGIX(mask);
        }
        
        public static void LoadIdentityDeformationMapSGIX(GL.Enums.FfdMaskSGIX mask)
        {
            LoadIdentityDeformationMapSGIX(mask);
        }
        
        public static unsafe void ReferencePlaneSGIX(GLdouble* equation)
        {
            return ReferencePlaneSGIX(equation);
        }
        
        public static unsafe void ReferencePlaneSGIX(GLdouble[] equation)
        {
            fixed (GLdouble equation_ptr = equation)
            {
                ReferencePlaneSGIX(equation_ptr);
            }
        }
        
        public static unsafe void ReferencePlaneSGIX(ref GLdouble equation)
        {
            fixed (GLdouble equation_ptr = &equation)
            {
                ReferencePlaneSGIX(equation_ptr);
            }
        }
        
        public static void FlushRasterSGIX()
        {
            FlushRasterSGIX();
        }
        
        public static unsafe void FogFuncSGIS(GLsizei n, GLfloat* points)
        {
            return FogFuncSGIS(n, points);
        }
        
        public static unsafe void GetFogFuncSGIS(GLfloat* points)
        {
            return GetFogFuncSGIS(points);
        }
        
        public static unsafe void GetFogFuncSGIS(GLfloat[] points)
        {
            points = default(GLfloat);
            fixed (GLfloat points_ptr = points)
            {
                GetFogFuncSGIS(points_ptr);
            }
        }
        
        public static unsafe void GetFogFuncSGIS(out GLfloat points)
        {
            points = default(GLfloat);
            fixed (GLfloat points_ptr = &points)
            {
                GetFogFuncSGIS(points_ptr);
            }
        }
        
        public static void ImageTransformParameteriHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLint param)
        {
            ImageTransformParameteriHP(target, pname, param);
        }
        
        public static void ImageTransformParameterfHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLfloat param)
        {
            ImageTransformParameterfHP(target, pname, param);
        }
        
        public static unsafe void ImageTransformParameterivHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLint* @params)
        {
            return ImageTransformParameterivHP(target, pname, @params);
        }
        
        public static unsafe void ImageTransformParameterfvHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLfloat* @params)
        {
            return ImageTransformParameterfvHP(target, pname, @params);
        }
        
        public static unsafe void GetImageTransformParameterivHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLint* @params)
        {
            return GetImageTransformParameterivHP(target, pname, @params);
        }
        
        public static unsafe void GetImageTransformParameterfvHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLfloat* @params)
        {
            return GetImageTransformParameterfvHP(target, pname, @params);
        }
        
        public static unsafe void ColorSubTableEXT(GL.Enums.EXT_color_subtable target, GLsizei start, GLsizei count, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data)
        {
            return ColorSubTableEXT(target, start, count, format, type, data);
        }
        
        public static void CopyColorSubTableEXT(GL.Enums.EXT_color_subtable target, GLsizei start, GLint x, GLint y, GLsizei width)
        {
            CopyColorSubTableEXT(target, start, x, y, width);
        }
        
        public static void HintPGI(GL.Enums.PGI_misc_hints target, GLint mode)
        {
            HintPGI(target, mode);
        }
        
        public static unsafe void ColorTableEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.PixelInternalFormat internalFormat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table)
        {
            return ColorTableEXT(target, internalFormat, width, format, type, table);
        }
        
        public static unsafe void GetColorTableEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data)
        {
            return GetColorTableEXT(target, format, type, data);
        }
        
        public static unsafe void GetColorTableParameterivEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.EXT_paletted_texture pname, GLint* @params)
        {
            return GetColorTableParameterivEXT(target, pname, @params);
        }
        
        public static unsafe void GetColorTableParameterfvEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.EXT_paletted_texture pname, GLfloat* @params)
        {
            return GetColorTableParameterfvEXT(target, pname, @params);
        }
        
        public static unsafe void GetListParameterfvSGIX(GLuint list, GL.Enums.ListParameterName pname, GLfloat* @params)
        {
            return GetListParameterfvSGIX(list, pname, @params);
        }
        
        public static unsafe void GetListParameterivSGIX(GLuint list, GL.Enums.ListParameterName pname, GLint* @params)
        {
            return GetListParameterivSGIX(list, pname, @params);
        }
        
        public static void ListParameterfSGIX(GLuint list, GL.Enums.ListParameterName pname, GLfloat param)
        {
            ListParameterfSGIX(list, pname, param);
        }
        
        public static unsafe void ListParameterfvSGIX(GLuint list, GL.Enums.ListParameterName pname, GLfloat* @params)
        {
            return ListParameterfvSGIX(list, pname, @params);
        }
        
        public static void ListParameteriSGIX(GLuint list, GL.Enums.ListParameterName pname, GLint param)
        {
            ListParameteriSGIX(list, pname, param);
        }
        
        public static unsafe void ListParameterivSGIX(GLuint list, GL.Enums.ListParameterName pname, GLint* @params)
        {
            return ListParameterivSGIX(list, pname, @params);
        }
        
        public static void IndexMaterialEXT(GL.Enums.MaterialFace face, GL.Enums.EXT_index_material mode)
        {
            IndexMaterialEXT(face, mode);
        }
        
        public static void IndexFuncEXT(GL.Enums.EXT_index_func func, GLclampf @ref)
        {
            IndexFuncEXT(func, @ref);
        }
        
        public static void LockArraysEXT(GLint first, GLsizei count)
        {
            LockArraysEXT(first, count);
        }
        
        public static void UnlockArraysEXT()
        {
            UnlockArraysEXT();
        }
        
        public static unsafe void CullParameterdvEXT(GL.Enums.EXT_cull_vertex pname, GLdouble* @params)
        {
            return CullParameterdvEXT(pname, @params);
        }
        
        public static unsafe void CullParameterfvEXT(GL.Enums.EXT_cull_vertex pname, GLfloat* @params)
        {
            return CullParameterfvEXT(pname, @params);
        }
        
        public static void FragmentColorMaterialSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter mode)
        {
            FragmentColorMaterialSGIX(face, mode);
        }
        
        public static void FragmentLightfSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLfloat param)
        {
            FragmentLightfSGIX(light, pname, param);
        }
        
        public static unsafe void FragmentLightfvSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLfloat* @params)
        {
            return FragmentLightfvSGIX(light, pname, @params);
        }
        
        public static void FragmentLightiSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLint param)
        {
            FragmentLightiSGIX(light, pname, param);
        }
        
        public static unsafe void FragmentLightivSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLint* @params)
        {
            return FragmentLightivSGIX(light, pname, @params);
        }
        
        public static void FragmentLightModelfSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, GLfloat param)
        {
            FragmentLightModelfSGIX(pname, param);
        }
        
        public static unsafe void FragmentLightModelfvSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, GLfloat* @params)
        {
            return FragmentLightModelfvSGIX(pname, @params);
        }
        
        public static void FragmentLightModeliSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, GLint param)
        {
            FragmentLightModeliSGIX(pname, param);
        }
        
        public static unsafe void FragmentLightModelivSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, GLint* @params)
        {
            return FragmentLightModelivSGIX(pname, @params);
        }
        
        public static void FragmentMaterialfSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat param)
        {
            FragmentMaterialfSGIX(face, pname, param);
        }
        
        public static unsafe void FragmentMaterialfvSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat* @params)
        {
            return FragmentMaterialfvSGIX(face, pname, @params);
        }
        
        public static void FragmentMaterialiSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint param)
        {
            FragmentMaterialiSGIX(face, pname, param);
        }
        
        public static unsafe void FragmentMaterialivSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint* @params)
        {
            return FragmentMaterialivSGIX(face, pname, @params);
        }
        
        public static unsafe void GetFragmentLightfvSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLfloat* @params)
        {
            return GetFragmentLightfvSGIX(light, pname, @params);
        }
        
        public static unsafe void GetFragmentLightivSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLint* @params)
        {
            return GetFragmentLightivSGIX(light, pname, @params);
        }
        
        public static unsafe void GetFragmentMaterialfvSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat* @params)
        {
            return GetFragmentMaterialfvSGIX(face, pname, @params);
        }
        
        public static unsafe void GetFragmentMaterialivSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint* @params)
        {
            return GetFragmentMaterialivSGIX(face, pname, @params);
        }
        
        public static void LightEnviSGIX(GL.Enums.LightEnvParameterSGIX pname, GLint param)
        {
            LightEnviSGIX(pname, param);
        }
        
        public static unsafe void DrawRangeElementsEXT(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count, GL.Enums.EXT_draw_range_elements type, void* indices)
        {
            return DrawRangeElementsEXT(mode, start, end, count, type, indices);
        }
        
        public static void ApplyTextureEXT(GL.Enums.EXT_light_texture mode)
        {
            ApplyTextureEXT(mode);
        }
        
        public static void TextureLightEXT(GL.Enums.EXT_light_texture pname)
        {
            TextureLightEXT(pname);
        }
        
        public static void TextureMaterialEXT(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter mode)
        {
            TextureMaterialEXT(face, mode);
        }
        
        public static void AsyncMarkerSGIX(GLuint marker)
        {
            AsyncMarkerSGIX(marker);
        }
        
        public static unsafe GLint FinishAsyncSGIX(GLuint* markerp)
        {
            FinishAsyncSGIX(markerp);
        }
        
        public static unsafe GLint FinishAsyncSGIX(GLuint[] markerp)
        {
            markerp = default(GLuint);
            fixed (GLuint markerp_ptr = markerp)
            {
                GLint retval = FinishAsyncSGIX(markerp_ptr);
            }
            return retval;
        }
        
        public static unsafe GLint FinishAsyncSGIX(out GLuint markerp)
        {
            markerp = default(GLuint);
            fixed (GLuint markerp_ptr = &markerp)
            {
                GLint retval = FinishAsyncSGIX(markerp_ptr);
            }
            return retval;
        }
        
        public static unsafe GLint PollAsyncSGIX(GLuint* markerp)
        {
            PollAsyncSGIX(markerp);
        }
        
        public static unsafe GLint PollAsyncSGIX(GLuint[] markerp)
        {
            markerp = default(GLuint);
            fixed (GLuint markerp_ptr = markerp)
            {
                GLint retval = PollAsyncSGIX(markerp_ptr);
            }
            return retval;
        }
        
        public static unsafe GLint PollAsyncSGIX(out GLuint markerp)
        {
            markerp = default(GLuint);
            fixed (GLuint markerp_ptr = &markerp)
            {
                GLint retval = PollAsyncSGIX(markerp_ptr);
            }
            return retval;
        }
        
        public static GLuint GenAsyncMarkersSGIX(GLsizei range)
        {
            return GenAsyncMarkersSGIX(range);
        }
        
        public static void DeleteAsyncMarkersSGIX(GLuint marker, GLsizei range)
        {
            DeleteAsyncMarkersSGIX(marker, range);
        }
        
        public static GLboolean IsAsyncMarkerSGIX(GLuint marker)
        {
            return IsAsyncMarkerSGIX(marker);
        }
        
        public static unsafe void VertexPointervINTEL(GLint size, GL.Enums.VertexPointerType type, void* pointer)
        {
            return VertexPointervINTEL(size, type, pointer);
        }
        
        public static unsafe void NormalPointervINTEL(GL.Enums.NormalPointerType type, void* pointer)
        {
            return NormalPointervINTEL(type, pointer);
        }
        
        public static unsafe void ColorPointervINTEL(GLint size, GL.Enums.VertexPointerType type, void* pointer)
        {
            return ColorPointervINTEL(size, type, pointer);
        }
        
        public static unsafe void TexCoordPointervINTEL(GLint size, GL.Enums.VertexPointerType type, void* pointer)
        {
            return TexCoordPointervINTEL(size, type, pointer);
        }
        
        public static void PixelTransformParameteriEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, GLint param)
        {
            PixelTransformParameteriEXT(target, pname, param);
        }
        
        public static void PixelTransformParameterfEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, GLfloat param)
        {
            PixelTransformParameterfEXT(target, pname, param);
        }
        
        public static unsafe void PixelTransformParameterivEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, GLint* @params)
        {
            return PixelTransformParameterivEXT(target, pname, @params);
        }
        
        public static unsafe void PixelTransformParameterfvEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, GLfloat* @params)
        {
            return PixelTransformParameterfvEXT(target, pname, @params);
        }
        
        public static void SecondaryColor3bEXT(GLbyte red, GLbyte green, GLbyte blue)
        {
            SecondaryColor3bEXT(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3bvEXT(GLbyte* v)
        {
            return SecondaryColor3bvEXT(v);
        }
        
        public static unsafe void SecondaryColor3bvEXT(GLbyte[] v)
        {
            fixed (GLbyte v_ptr = v)
            {
                SecondaryColor3bvEXT(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3bvEXT(ref GLbyte v)
        {
            fixed (GLbyte v_ptr = &v)
            {
                SecondaryColor3bvEXT(v_ptr);
            }
        }
        
        public static void SecondaryColor3dEXT(GLdouble red, GLdouble green, GLdouble blue)
        {
            SecondaryColor3dEXT(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3dvEXT(GLdouble* v)
        {
            return SecondaryColor3dvEXT(v);
        }
        
        public static unsafe void SecondaryColor3dvEXT(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                SecondaryColor3dvEXT(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3dvEXT(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                SecondaryColor3dvEXT(v_ptr);
            }
        }
        
        public static void SecondaryColor3fEXT(GLfloat red, GLfloat green, GLfloat blue)
        {
            SecondaryColor3fEXT(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3fvEXT(GLfloat* v)
        {
            return SecondaryColor3fvEXT(v);
        }
        
        public static unsafe void SecondaryColor3fvEXT(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                SecondaryColor3fvEXT(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3fvEXT(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                SecondaryColor3fvEXT(v_ptr);
            }
        }
        
        public static void SecondaryColor3iEXT(GLint red, GLint green, GLint blue)
        {
            SecondaryColor3iEXT(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3ivEXT(GLint* v)
        {
            return SecondaryColor3ivEXT(v);
        }
        
        public static unsafe void SecondaryColor3ivEXT(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                SecondaryColor3ivEXT(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3ivEXT(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                SecondaryColor3ivEXT(v_ptr);
            }
        }
        
        public static void SecondaryColor3sEXT(GLshort red, GLshort green, GLshort blue)
        {
            SecondaryColor3sEXT(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3svEXT(GLshort* v)
        {
            return SecondaryColor3svEXT(v);
        }
        
        public static unsafe void SecondaryColor3svEXT(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                SecondaryColor3svEXT(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3svEXT(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                SecondaryColor3svEXT(v_ptr);
            }
        }
        
        public static void SecondaryColor3ubEXT(GLubyte red, GLubyte green, GLubyte blue)
        {
            SecondaryColor3ubEXT(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3ubvEXT(GLubyte* v)
        {
            return SecondaryColor3ubvEXT(v);
        }
        
        public static unsafe void SecondaryColor3ubvEXT(GLubyte[] v)
        {
            fixed (GLubyte v_ptr = v)
            {
                SecondaryColor3ubvEXT(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3ubvEXT(ref GLubyte v)
        {
            fixed (GLubyte v_ptr = &v)
            {
                SecondaryColor3ubvEXT(v_ptr);
            }
        }
        
        public static void SecondaryColor3uiEXT(GLuint red, GLuint green, GLuint blue)
        {
            SecondaryColor3uiEXT(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3uivEXT(GLuint* v)
        {
            return SecondaryColor3uivEXT(v);
        }
        
        public static unsafe void SecondaryColor3uivEXT(GLuint[] v)
        {
            fixed (GLuint v_ptr = v)
            {
                SecondaryColor3uivEXT(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3uivEXT(ref GLuint v)
        {
            fixed (GLuint v_ptr = &v)
            {
                SecondaryColor3uivEXT(v_ptr);
            }
        }
        
        public static void SecondaryColor3usEXT(GLushort red, GLushort green, GLushort blue)
        {
            SecondaryColor3usEXT(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3usvEXT(GLushort* v)
        {
            return SecondaryColor3usvEXT(v);
        }
        
        public static unsafe void SecondaryColor3usvEXT(GLushort[] v)
        {
            fixed (GLushort v_ptr = v)
            {
                SecondaryColor3usvEXT(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3usvEXT(ref GLushort v)
        {
            fixed (GLushort v_ptr = &v)
            {
                SecondaryColor3usvEXT(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColorPointerEXT(GLint size, GL.Enums.ColorPointerType type, GLsizei stride, void* pointer)
        {
            return SecondaryColorPointerEXT(size, type, stride, pointer);
        }
        
        public static void TextureNormalEXT(GL.Enums.EXT_texture_perturb_normal mode)
        {
            TextureNormalEXT(mode);
        }
        
        public static unsafe void MultiDrawArraysEXT(GL.Enums.BeginMode mode, GLint* first, GLsizei* count, GLsizei primcount)
        {
            return MultiDrawArraysEXT(mode, first, count, primcount);
        }
        
        public static unsafe void MultiDrawElementsEXT(GL.Enums.BeginMode mode, GLsizei* count, GL.Enums.EXT_multi_draw_arrays type, void* indices, GLsizei primcount)
        {
            return MultiDrawElementsEXT(mode, count, type, indices, primcount);
        }
        
        public static void FogCoordfEXT(GLfloat coord)
        {
            FogCoordfEXT(coord);
        }
        
        public static unsafe void FogCoordfvEXT(GLfloat* coord)
        {
            return FogCoordfvEXT(coord);
        }
        
        public static unsafe void FogCoordfvEXT(GLfloat[] coord)
        {
            fixed (GLfloat coord_ptr = coord)
            {
                FogCoordfvEXT(coord_ptr);
            }
        }
        
        public static unsafe void FogCoordfvEXT(ref GLfloat coord)
        {
            fixed (GLfloat coord_ptr = &coord)
            {
                FogCoordfvEXT(coord_ptr);
            }
        }
        
        public static void FogCoorddEXT(GLdouble coord)
        {
            FogCoorddEXT(coord);
        }
        
        public static unsafe void FogCoorddvEXT(GLdouble* coord)
        {
            return FogCoorddvEXT(coord);
        }
        
        public static unsafe void FogCoorddvEXT(GLdouble[] coord)
        {
            fixed (GLdouble coord_ptr = coord)
            {
                FogCoorddvEXT(coord_ptr);
            }
        }
        
        public static unsafe void FogCoorddvEXT(ref GLdouble coord)
        {
            fixed (GLdouble coord_ptr = &coord)
            {
                FogCoorddvEXT(coord_ptr);
            }
        }
        
        public static unsafe void FogCoordPointerEXT(GL.Enums.EXT_fog_coord type, GLsizei stride, void* pointer)
        {
            return FogCoordPointerEXT(type, stride, pointer);
        }
        
        public static void Tangent3bEXT(GLbyte tx, GLbyte ty, GLbyte tz)
        {
            Tangent3bEXT(tx, ty, tz);
        }
        
        public static unsafe void Tangent3bvEXT(GLbyte* v)
        {
            return Tangent3bvEXT(v);
        }
        
        public static unsafe void Tangent3bvEXT(GLbyte[] v)
        {
            fixed (GLbyte v_ptr = v)
            {
                Tangent3bvEXT(v_ptr);
            }
        }
        
        public static unsafe void Tangent3bvEXT(ref GLbyte v)
        {
            fixed (GLbyte v_ptr = &v)
            {
                Tangent3bvEXT(v_ptr);
            }
        }
        
        public static void Tangent3dEXT(GLdouble tx, GLdouble ty, GLdouble tz)
        {
            Tangent3dEXT(tx, ty, tz);
        }
        
        public static unsafe void Tangent3dvEXT(GLdouble* v)
        {
            return Tangent3dvEXT(v);
        }
        
        public static unsafe void Tangent3dvEXT(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                Tangent3dvEXT(v_ptr);
            }
        }
        
        public static unsafe void Tangent3dvEXT(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                Tangent3dvEXT(v_ptr);
            }
        }
        
        public static void Tangent3fEXT(GLfloat tx, GLfloat ty, GLfloat tz)
        {
            Tangent3fEXT(tx, ty, tz);
        }
        
        public static unsafe void Tangent3fvEXT(GLfloat* v)
        {
            return Tangent3fvEXT(v);
        }
        
        public static unsafe void Tangent3fvEXT(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                Tangent3fvEXT(v_ptr);
            }
        }
        
        public static unsafe void Tangent3fvEXT(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                Tangent3fvEXT(v_ptr);
            }
        }
        
        public static void Tangent3iEXT(GLint tx, GLint ty, GLint tz)
        {
            Tangent3iEXT(tx, ty, tz);
        }
        
        public static unsafe void Tangent3ivEXT(GLint* v)
        {
            return Tangent3ivEXT(v);
        }
        
        public static unsafe void Tangent3ivEXT(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                Tangent3ivEXT(v_ptr);
            }
        }
        
        public static unsafe void Tangent3ivEXT(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                Tangent3ivEXT(v_ptr);
            }
        }
        
        public static void Tangent3sEXT(GLshort tx, GLshort ty, GLshort tz)
        {
            Tangent3sEXT(tx, ty, tz);
        }
        
        public static unsafe void Tangent3svEXT(GLshort* v)
        {
            return Tangent3svEXT(v);
        }
        
        public static unsafe void Tangent3svEXT(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                Tangent3svEXT(v_ptr);
            }
        }
        
        public static unsafe void Tangent3svEXT(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                Tangent3svEXT(v_ptr);
            }
        }
        
        public static void Binormal3bEXT(GLbyte bx, GLbyte by, GLbyte bz)
        {
            Binormal3bEXT(bx, by, bz);
        }
        
        public static unsafe void Binormal3bvEXT(GLbyte* v)
        {
            return Binormal3bvEXT(v);
        }
        
        public static unsafe void Binormal3bvEXT(GLbyte[] v)
        {
            fixed (GLbyte v_ptr = v)
            {
                Binormal3bvEXT(v_ptr);
            }
        }
        
        public static unsafe void Binormal3bvEXT(ref GLbyte v)
        {
            fixed (GLbyte v_ptr = &v)
            {
                Binormal3bvEXT(v_ptr);
            }
        }
        
        public static void Binormal3dEXT(GLdouble bx, GLdouble by, GLdouble bz)
        {
            Binormal3dEXT(bx, by, bz);
        }
        
        public static unsafe void Binormal3dvEXT(GLdouble* v)
        {
            return Binormal3dvEXT(v);
        }
        
        public static unsafe void Binormal3dvEXT(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                Binormal3dvEXT(v_ptr);
            }
        }
        
        public static unsafe void Binormal3dvEXT(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                Binormal3dvEXT(v_ptr);
            }
        }
        
        public static void Binormal3fEXT(GLfloat bx, GLfloat by, GLfloat bz)
        {
            Binormal3fEXT(bx, by, bz);
        }
        
        public static unsafe void Binormal3fvEXT(GLfloat* v)
        {
            return Binormal3fvEXT(v);
        }
        
        public static unsafe void Binormal3fvEXT(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                Binormal3fvEXT(v_ptr);
            }
        }
        
        public static unsafe void Binormal3fvEXT(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                Binormal3fvEXT(v_ptr);
            }
        }
        
        public static void Binormal3iEXT(GLint bx, GLint by, GLint bz)
        {
            Binormal3iEXT(bx, by, bz);
        }
        
        public static unsafe void Binormal3ivEXT(GLint* v)
        {
            return Binormal3ivEXT(v);
        }
        
        public static unsafe void Binormal3ivEXT(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                Binormal3ivEXT(v_ptr);
            }
        }
        
        public static unsafe void Binormal3ivEXT(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                Binormal3ivEXT(v_ptr);
            }
        }
        
        public static void Binormal3sEXT(GLshort bx, GLshort by, GLshort bz)
        {
            Binormal3sEXT(bx, by, bz);
        }
        
        public static unsafe void Binormal3svEXT(GLshort* v)
        {
            return Binormal3svEXT(v);
        }
        
        public static unsafe void Binormal3svEXT(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                Binormal3svEXT(v_ptr);
            }
        }
        
        public static unsafe void Binormal3svEXT(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                Binormal3svEXT(v_ptr);
            }
        }
        
        public static unsafe void TangentPointerEXT(GL.Enums.EXT_coordinate_frame type, GLsizei stride, void* pointer)
        {
            return TangentPointerEXT(type, stride, pointer);
        }
        
        public static unsafe void BinormalPointerEXT(GL.Enums.EXT_coordinate_frame type, GLsizei stride, void* pointer)
        {
            return BinormalPointerEXT(type, stride, pointer);
        }
        
        public static void FinishTextureSUNX()
        {
            FinishTextureSUNX();
        }
        
        public static void GlobalAlphaFactorbSUN(GLbyte factor)
        {
            GlobalAlphaFactorbSUN(factor);
        }
        
        public static void GlobalAlphaFactorsSUN(GLshort factor)
        {
            GlobalAlphaFactorsSUN(factor);
        }
        
        public static void GlobalAlphaFactoriSUN(GLint factor)
        {
            GlobalAlphaFactoriSUN(factor);
        }
        
        public static void GlobalAlphaFactorfSUN(GLfloat factor)
        {
            GlobalAlphaFactorfSUN(factor);
        }
        
        public static void GlobalAlphaFactordSUN(GLdouble factor)
        {
            GlobalAlphaFactordSUN(factor);
        }
        
        public static void GlobalAlphaFactorubSUN(GLubyte factor)
        {
            GlobalAlphaFactorubSUN(factor);
        }
        
        public static void GlobalAlphaFactorusSUN(GLushort factor)
        {
            GlobalAlphaFactorusSUN(factor);
        }
        
        public static void GlobalAlphaFactoruiSUN(GLuint factor)
        {
            GlobalAlphaFactoruiSUN(factor);
        }
        
        public static void ReplacementCodeuiSUN(GLuint code)
        {
            ReplacementCodeuiSUN(code);
        }
        
        public static void ReplacementCodeusSUN(GLushort code)
        {
            ReplacementCodeusSUN(code);
        }
        
        public static void ReplacementCodeubSUN(GLubyte code)
        {
            ReplacementCodeubSUN(code);
        }
        
        public static unsafe void ReplacementCodeuivSUN(GLuint* code)
        {
            return ReplacementCodeuivSUN(code);
        }
        
        public static unsafe void ReplacementCodeuivSUN(GLuint[] code)
        {
            fixed (GLuint code_ptr = code)
            {
                ReplacementCodeuivSUN(code_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuivSUN(ref GLuint code)
        {
            fixed (GLuint code_ptr = &code)
            {
                ReplacementCodeuivSUN(code_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeusvSUN(GLushort* code)
        {
            return ReplacementCodeusvSUN(code);
        }
        
        public static unsafe void ReplacementCodeusvSUN(GLushort[] code)
        {
            fixed (GLushort code_ptr = code)
            {
                ReplacementCodeusvSUN(code_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeusvSUN(ref GLushort code)
        {
            fixed (GLushort code_ptr = &code)
            {
                ReplacementCodeusvSUN(code_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeubvSUN(GLubyte* code)
        {
            return ReplacementCodeubvSUN(code);
        }
        
        public static unsafe void ReplacementCodeubvSUN(GLubyte[] code)
        {
            fixed (GLubyte code_ptr = code)
            {
                ReplacementCodeubvSUN(code_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeubvSUN(ref GLubyte code)
        {
            fixed (GLubyte code_ptr = &code)
            {
                ReplacementCodeubvSUN(code_ptr);
            }
        }
        
        public static unsafe void ReplacementCodePointerSUN(GL.Enums.SUN_triangle_list type, GLsizei stride, void* pointer)
        {
            return ReplacementCodePointerSUN(type, stride, pointer);
        }
        
        public static void Color4ubVertex2fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y)
        {
            Color4ubVertex2fSUN(r, g, b, a, x, y);
        }
        
        public static unsafe void Color4ubVertex2fvSUN(GLubyte* c, GLfloat* v)
        {
            return Color4ubVertex2fvSUN(c, v);
        }
        
        public static unsafe void Color4ubVertex2fvSUN(GLubyte* c, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                Color4ubVertex2fvSUN(c, v_ptr);
            }
        }
        
        public static unsafe void Color4ubVertex2fvSUN(GLubyte* c, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                Color4ubVertex2fvSUN(c, v_ptr);
            }
        }
        
        public static unsafe void Color4ubVertex2fvSUN(GLubyte[] c, GLfloat* v)
        {
            fixed (GLubyte c_ptr = c)
            {
                Color4ubVertex2fvSUN(c_ptr, v);
            }
        }
        
        public static unsafe void Color4ubVertex2fvSUN(GLubyte[] c, GLfloat[] v)
        {
            fixed (GLubyte c_ptr = c)
            {
                Color4ubVertex2fvSUN(c_ptr, v);
            }
            fixed (GLubyte c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                Color4ubVertex2fvSUN(c_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4ubVertex2fvSUN(GLubyte[] c, ref GLfloat v)
        {
            fixed (GLubyte c_ptr = c)
            {
                Color4ubVertex2fvSUN(c_ptr, v);
            }
            fixed (GLubyte c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                Color4ubVertex2fvSUN(c_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4ubVertex2fvSUN(ref GLubyte c, GLfloat* v)
        {
            fixed (GLubyte c_ptr = &c)
            {
                Color4ubVertex2fvSUN(c_ptr, v);
            }
        }
        
        public static unsafe void Color4ubVertex2fvSUN(ref GLubyte c, GLfloat[] v)
        {
            fixed (GLubyte c_ptr = &c)
            {
                Color4ubVertex2fvSUN(c_ptr, v);
            }
            fixed (GLubyte c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                Color4ubVertex2fvSUN(c_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4ubVertex2fvSUN(ref GLubyte c, ref GLfloat v)
        {
            fixed (GLubyte c_ptr = &c)
            {
                Color4ubVertex2fvSUN(c_ptr, v);
            }
            fixed (GLubyte c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                Color4ubVertex2fvSUN(c_ptr, v_ptr);
            }
        }
        
        public static void Color4ubVertex3fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)
        {
            Color4ubVertex3fSUN(r, g, b, a, x, y, z);
        }
        
        public static unsafe void Color4ubVertex3fvSUN(GLubyte* c, GLfloat* v)
        {
            return Color4ubVertex3fvSUN(c, v);
        }
        
        public static unsafe void Color4ubVertex3fvSUN(GLubyte* c, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                Color4ubVertex3fvSUN(c, v_ptr);
            }
        }
        
        public static unsafe void Color4ubVertex3fvSUN(GLubyte* c, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                Color4ubVertex3fvSUN(c, v_ptr);
            }
        }
        
        public static unsafe void Color4ubVertex3fvSUN(GLubyte[] c, GLfloat* v)
        {
            fixed (GLubyte c_ptr = c)
            {
                Color4ubVertex3fvSUN(c_ptr, v);
            }
        }
        
        public static unsafe void Color4ubVertex3fvSUN(GLubyte[] c, GLfloat[] v)
        {
            fixed (GLubyte c_ptr = c)
            {
                Color4ubVertex3fvSUN(c_ptr, v);
            }
            fixed (GLubyte c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                Color4ubVertex3fvSUN(c_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4ubVertex3fvSUN(GLubyte[] c, ref GLfloat v)
        {
            fixed (GLubyte c_ptr = c)
            {
                Color4ubVertex3fvSUN(c_ptr, v);
            }
            fixed (GLubyte c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                Color4ubVertex3fvSUN(c_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4ubVertex3fvSUN(ref GLubyte c, GLfloat* v)
        {
            fixed (GLubyte c_ptr = &c)
            {
                Color4ubVertex3fvSUN(c_ptr, v);
            }
        }
        
        public static unsafe void Color4ubVertex3fvSUN(ref GLubyte c, GLfloat[] v)
        {
            fixed (GLubyte c_ptr = &c)
            {
                Color4ubVertex3fvSUN(c_ptr, v);
            }
            fixed (GLubyte c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                Color4ubVertex3fvSUN(c_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4ubVertex3fvSUN(ref GLubyte c, ref GLfloat v)
        {
            fixed (GLubyte c_ptr = &c)
            {
                Color4ubVertex3fvSUN(c_ptr, v);
            }
            fixed (GLubyte c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                Color4ubVertex3fvSUN(c_ptr, v_ptr);
            }
        }
        
        public static void Color3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)
        {
            Color3fVertex3fSUN(r, g, b, x, y, z);
        }
        
        public static unsafe void Color3fVertex3fvSUN(GLfloat* c, GLfloat* v)
        {
            return Color3fVertex3fvSUN(c, v);
        }
        
        public static unsafe void Color3fVertex3fvSUN(GLfloat* c, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                Color3fVertex3fvSUN(c, v_ptr);
            }
        }
        
        public static unsafe void Color3fVertex3fvSUN(GLfloat* c, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                Color3fVertex3fvSUN(c, v_ptr);
            }
        }
        
        public static unsafe void Color3fVertex3fvSUN(GLfloat[] c, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                Color3fVertex3fvSUN(c_ptr, v);
            }
        }
        
        public static unsafe void Color3fVertex3fvSUN(GLfloat[] c, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                Color3fVertex3fvSUN(c_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                Color3fVertex3fvSUN(c_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color3fVertex3fvSUN(GLfloat[] c, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                Color3fVertex3fvSUN(c_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                Color3fVertex3fvSUN(c_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color3fVertex3fvSUN(ref GLfloat c, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                Color3fVertex3fvSUN(c_ptr, v);
            }
        }
        
        public static unsafe void Color3fVertex3fvSUN(ref GLfloat c, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                Color3fVertex3fvSUN(c_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                Color3fVertex3fvSUN(c_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color3fVertex3fvSUN(ref GLfloat c, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                Color3fVertex3fvSUN(c_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                Color3fVertex3fvSUN(c_ptr, v_ptr);
            }
        }
        
        public static void Normal3fVertex3fSUN(GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            Normal3fVertex3fSUN(nx, ny, nz, x, y, z);
        }
        
        public static unsafe void Normal3fVertex3fvSUN(GLfloat* n, GLfloat* v)
        {
            return Normal3fVertex3fvSUN(n, v);
        }
        
        public static unsafe void Normal3fVertex3fvSUN(GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                Normal3fVertex3fvSUN(n, v_ptr);
            }
        }
        
        public static unsafe void Normal3fVertex3fvSUN(GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                Normal3fVertex3fvSUN(n, v_ptr);
            }
        }
        
        public static unsafe void Normal3fVertex3fvSUN(GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = n)
            {
                Normal3fVertex3fvSUN(n_ptr, v);
            }
        }
        
        public static unsafe void Normal3fVertex3fvSUN(GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = n)
            {
                Normal3fVertex3fvSUN(n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                Normal3fVertex3fvSUN(n_ptr, v_ptr);
            }
        }
        
        public static unsafe void Normal3fVertex3fvSUN(GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = n)
            {
                Normal3fVertex3fvSUN(n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                Normal3fVertex3fvSUN(n_ptr, v_ptr);
            }
        }
        
        public static unsafe void Normal3fVertex3fvSUN(ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                Normal3fVertex3fvSUN(n_ptr, v);
            }
        }
        
        public static unsafe void Normal3fVertex3fvSUN(ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                Normal3fVertex3fvSUN(n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                Normal3fVertex3fvSUN(n_ptr, v_ptr);
            }
        }
        
        public static unsafe void Normal3fVertex3fvSUN(ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                Normal3fVertex3fvSUN(n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                Normal3fVertex3fvSUN(n_ptr, v_ptr);
            }
        }
        
        public static void Color4fNormal3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            Color4fNormal3fVertex3fSUN(r, g, b, a, nx, ny, nz, x, y, z);
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat* c, GLfloat* n, GLfloat* v)
        {
            return Color4fNormal3fVertex3fvSUN(c, n, v);
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                Color4fNormal3fVertex3fvSUN(c, n, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                Color4fNormal3fVertex3fvSUN(c, n, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = n)
            {
                Color4fNormal3fVertex3fvSUN(c, n_ptr, v);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = n)
            {
                Color4fNormal3fVertex3fvSUN(c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                Color4fNormal3fVertex3fvSUN(c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = n)
            {
                Color4fNormal3fVertex3fvSUN(c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                Color4fNormal3fVertex3fvSUN(c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                Color4fNormal3fVertex3fvSUN(c, n_ptr, v);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                Color4fNormal3fVertex3fvSUN(c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                Color4fNormal3fVertex3fvSUN(c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                Color4fNormal3fVertex3fvSUN(c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                Color4fNormal3fVertex3fvSUN(c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void Color4fNormal3fVertex3fvSUN(ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                Color4fNormal3fVertex3fvSUN(c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static void TexCoord2fVertex3fSUN(GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z)
        {
            TexCoord2fVertex3fSUN(s, t, x, y, z);
        }
        
        public static unsafe void TexCoord2fVertex3fvSUN(GLfloat* tc, GLfloat* v)
        {
            return TexCoord2fVertex3fvSUN(tc, v);
        }
        
        public static unsafe void TexCoord2fVertex3fvSUN(GLfloat* tc, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fVertex3fvSUN(tc, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fVertex3fvSUN(GLfloat* tc, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fVertex3fvSUN(tc, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fVertex3fvSUN(GLfloat[] tc, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fVertex3fvSUN(tc_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fVertex3fvSUN(GLfloat[] tc, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fVertex3fvSUN(tc_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fVertex3fvSUN(tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fVertex3fvSUN(GLfloat[] tc, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fVertex3fvSUN(tc_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fVertex3fvSUN(tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fVertex3fvSUN(ref GLfloat tc, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fVertex3fvSUN(tc_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fVertex3fvSUN(ref GLfloat tc, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fVertex3fvSUN(tc_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fVertex3fvSUN(tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fVertex3fvSUN(ref GLfloat tc, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fVertex3fvSUN(tc_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fVertex3fvSUN(tc_ptr, v_ptr);
            }
        }
        
        public static void TexCoord4fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            TexCoord4fVertex4fSUN(s, t, p, q, x, y, z, w);
        }
        
        public static unsafe void TexCoord4fVertex4fvSUN(GLfloat* tc, GLfloat* v)
        {
            return TexCoord4fVertex4fvSUN(tc, v);
        }
        
        public static unsafe void TexCoord4fVertex4fvSUN(GLfloat* tc, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fVertex4fvSUN(tc, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fVertex4fvSUN(GLfloat* tc, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fVertex4fvSUN(tc, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fVertex4fvSUN(GLfloat[] tc, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fVertex4fvSUN(tc_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fVertex4fvSUN(GLfloat[] tc, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fVertex4fvSUN(tc_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fVertex4fvSUN(tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fVertex4fvSUN(GLfloat[] tc, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fVertex4fvSUN(tc_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fVertex4fvSUN(tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fVertex4fvSUN(ref GLfloat tc, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fVertex4fvSUN(tc_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fVertex4fvSUN(ref GLfloat tc, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fVertex4fvSUN(tc_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fVertex4fvSUN(tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fVertex4fvSUN(ref GLfloat tc, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fVertex4fvSUN(tc_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fVertex4fvSUN(tc_ptr, v_ptr);
            }
        }
        
        public static void TexCoord2fColor4ubVertex3fSUN(GLfloat s, GLfloat t, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)
        {
            TexCoord2fColor4ubVertex3fSUN(s, t, r, g, b, a, x, y, z);
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat* tc, GLubyte* c, GLfloat* v)
        {
            return TexCoord2fColor4ubVertex3fvSUN(tc, c, v);
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat* tc, GLubyte* c, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc, c, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat* tc, GLubyte* c, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc, c, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat* tc, GLubyte[] c, GLfloat* v)
        {
            fixed (GLubyte c_ptr = c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc, c_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat* tc, GLubyte[] c, GLfloat[] v)
        {
            fixed (GLubyte c_ptr = c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc, c_ptr, v);
            }
            fixed (GLubyte c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat* tc, GLubyte[] c, ref GLfloat v)
        {
            fixed (GLubyte c_ptr = c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc, c_ptr, v);
            }
            fixed (GLubyte c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat* tc, ref GLubyte c, GLfloat* v)
        {
            fixed (GLubyte c_ptr = &c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc, c_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat* tc, ref GLubyte c, GLfloat[] v)
        {
            fixed (GLubyte c_ptr = &c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc, c_ptr, v);
            }
            fixed (GLubyte c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat* tc, ref GLubyte c, ref GLfloat v)
        {
            fixed (GLubyte c_ptr = &c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc, c_ptr, v);
            }
            fixed (GLubyte c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat[] tc, GLubyte* c, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat[] tc, GLubyte* c, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat[] tc, GLubyte* c, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat[] tc, GLubyte[] c, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLubyte c_ptr = c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat[] tc, GLubyte[] c, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLubyte c_ptr = c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLubyte c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat[] tc, GLubyte[] c, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLubyte c_ptr = c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLubyte c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat[] tc, ref GLubyte c, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLubyte c_ptr = &c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat[] tc, ref GLubyte c, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLubyte c_ptr = &c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLubyte c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat[] tc, ref GLubyte c, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLubyte c_ptr = &c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLubyte c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(ref GLfloat tc, GLubyte* c, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(ref GLfloat tc, GLubyte* c, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(ref GLfloat tc, GLubyte* c, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(ref GLfloat tc, GLubyte[] c, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLubyte c_ptr = c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(ref GLfloat tc, GLubyte[] c, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLubyte c_ptr = c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLubyte c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(ref GLfloat tc, GLubyte[] c, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLubyte c_ptr = c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLubyte c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(ref GLfloat tc, ref GLubyte c, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLubyte c_ptr = &c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(ref GLfloat tc, ref GLubyte c, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLubyte c_ptr = &c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLubyte c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4ubVertex3fvSUN(ref GLfloat tc, ref GLubyte c, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLubyte c_ptr = &c)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLubyte c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4ubVertex3fvSUN(tc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static void TexCoord2fColor3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)
        {
            TexCoord2fColor3fVertex3fSUN(s, t, r, g, b, x, y, z);
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat* v)
        {
            return TexCoord2fColor3fVertex3fvSUN(tc, c, v);
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc, c, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat* tc, GLfloat* c, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc, c, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat* tc, GLfloat[] c, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc, c_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat* tc, GLfloat[] c, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc, c_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat* tc, GLfloat[] c, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc, c_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat* tc, ref GLfloat c, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc, c_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat* tc, ref GLfloat c, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc, c_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat* tc, ref GLfloat c, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc, c_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat[] tc, GLfloat* c, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat[] tc, GLfloat* c, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat[] tc, GLfloat* c, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat[] tc, GLfloat[] c, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat[] tc, ref GLfloat c, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat[] tc, ref GLfloat c, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat[] tc, ref GLfloat c, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(ref GLfloat tc, GLfloat* c, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(ref GLfloat tc, GLfloat* c, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(ref GLfloat tc, GLfloat* c, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(ref GLfloat tc, GLfloat[] c, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(ref GLfloat tc, GLfloat[] c, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(ref GLfloat tc, GLfloat[] c, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(ref GLfloat tc, ref GLfloat c, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(ref GLfloat tc, ref GLfloat c, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor3fVertex3fvSUN(ref GLfloat tc, ref GLfloat c, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor3fVertex3fvSUN(tc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static void TexCoord2fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            TexCoord2fNormal3fVertex3fSUN(s, t, nx, ny, nz, x, y, z);
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* n, GLfloat* v)
        {
            return TexCoord2fNormal3fVertex3fvSUN(tc, n, v);
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc, n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc, n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat* tc, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat* tc, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc, n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat* tc, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc, n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat[] tc, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat[] tc, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat[] tc, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(ref GLfloat tc, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(ref GLfloat tc, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fNormal3fVertex3fvSUN(ref GLfloat tc, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fNormal3fVertex3fvSUN(tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static void TexCoord2fColor4fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            TexCoord2fColor4fNormal3fVertex3fSUN(s, t, r, g, b, a, nx, ny, nz, x, y, z);
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            return TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n, v);
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(ref GLfloat tc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord2fColor4fNormal3fVertex3fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static void TexCoord4fColor4fNormal3fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            TexCoord4fColor4fNormal3fVertex4fSUN(s, t, p, q, r, g, b, a, nx, ny, nz, x, y, z, w);
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            return TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n, v);
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(ref GLfloat tc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                TexCoord4fColor4fNormal3fVertex4fvSUN(tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static void ReplacementCodeuiVertex3fSUN(GLuint rc, GLfloat x, GLfloat y, GLfloat z)
        {
            ReplacementCodeuiVertex3fSUN(rc, x, y, z);
        }
        
        public static unsafe void ReplacementCodeuiVertex3fvSUN(GLuint* rc, GLfloat* v)
        {
            return ReplacementCodeuiVertex3fvSUN(rc, v);
        }
        
        public static unsafe void ReplacementCodeuiVertex3fvSUN(GLuint* rc, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiVertex3fvSUN(rc, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiVertex3fvSUN(GLuint* rc, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiVertex3fvSUN(rc, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiVertex3fvSUN(GLuint[] rc, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiVertex3fvSUN(rc_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiVertex3fvSUN(GLuint[] rc, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiVertex3fvSUN(rc_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiVertex3fvSUN(rc_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiVertex3fvSUN(GLuint[] rc, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiVertex3fvSUN(rc_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiVertex3fvSUN(rc_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiVertex3fvSUN(ref GLuint rc, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiVertex3fvSUN(rc_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiVertex3fvSUN(ref GLuint rc, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiVertex3fvSUN(rc_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiVertex3fvSUN(rc_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiVertex3fvSUN(ref GLuint rc, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiVertex3fvSUN(rc_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiVertex3fvSUN(rc_ptr, v_ptr);
            }
        }
        
        public static void ReplacementCodeuiColor4ubVertex3fSUN(GLuint rc, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)
        {
            ReplacementCodeuiColor4ubVertex3fSUN(rc, r, g, b, a, x, y, z);
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint* rc, GLubyte* c, GLfloat* v)
        {
            return ReplacementCodeuiColor4ubVertex3fvSUN(rc, c, v);
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint* rc, GLubyte* c, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc, c, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint* rc, GLubyte* c, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc, c, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint* rc, GLubyte[] c, GLfloat* v)
        {
            fixed (GLubyte c_ptr = c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc, c_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint* rc, GLubyte[] c, GLfloat[] v)
        {
            fixed (GLubyte c_ptr = c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc, c_ptr, v);
            }
            fixed (GLubyte c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint* rc, GLubyte[] c, ref GLfloat v)
        {
            fixed (GLubyte c_ptr = c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc, c_ptr, v);
            }
            fixed (GLubyte c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint* rc, ref GLubyte c, GLfloat* v)
        {
            fixed (GLubyte c_ptr = &c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc, c_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint* rc, ref GLubyte c, GLfloat[] v)
        {
            fixed (GLubyte c_ptr = &c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc, c_ptr, v);
            }
            fixed (GLubyte c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint* rc, ref GLubyte c, ref GLfloat v)
        {
            fixed (GLubyte c_ptr = &c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc, c_ptr, v);
            }
            fixed (GLubyte c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint[] rc, GLubyte* c, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint[] rc, GLubyte* c, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint[] rc, GLubyte* c, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint[] rc, GLubyte[] c, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLubyte c_ptr = c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint[] rc, GLubyte[] c, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLubyte c_ptr = c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLubyte c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint[] rc, GLubyte[] c, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLubyte c_ptr = c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLubyte c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint[] rc, ref GLubyte c, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLubyte c_ptr = &c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint[] rc, ref GLubyte c, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLubyte c_ptr = &c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLubyte c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint[] rc, ref GLubyte c, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLubyte c_ptr = &c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLubyte c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(ref GLuint rc, GLubyte* c, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(ref GLuint rc, GLubyte* c, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(ref GLuint rc, GLubyte* c, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(ref GLuint rc, GLubyte[] c, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLubyte c_ptr = c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(ref GLuint rc, GLubyte[] c, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLubyte c_ptr = c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLubyte c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(ref GLuint rc, GLubyte[] c, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLubyte c_ptr = c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLubyte c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(ref GLuint rc, ref GLubyte c, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLubyte c_ptr = &c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(ref GLuint rc, ref GLubyte c, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLubyte c_ptr = &c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLubyte c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(ref GLuint rc, ref GLubyte c, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLubyte c_ptr = &c)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLubyte c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4ubVertex3fvSUN(rc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static void ReplacementCodeuiColor3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)
        {
            ReplacementCodeuiColor3fVertex3fSUN(rc, r, g, b, x, y, z);
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat* v)
        {
            return ReplacementCodeuiColor3fVertex3fvSUN(rc, c, v);
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc, c, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint* rc, GLfloat* c, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc, c, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint* rc, GLfloat[] c, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc, c_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint* rc, GLfloat[] c, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc, c_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint* rc, GLfloat[] c, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc, c_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint* rc, ref GLfloat c, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc, c_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint* rc, ref GLfloat c, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc, c_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint* rc, ref GLfloat c, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc, c_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint[] rc, GLfloat* c, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint[] rc, GLfloat* c, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint[] rc, GLfloat* c, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint[] rc, GLfloat[] c, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint[] rc, GLfloat[] c, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint[] rc, GLfloat[] c, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint[] rc, ref GLfloat c, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint[] rc, ref GLfloat c, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint[] rc, ref GLfloat c, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(ref GLuint rc, GLfloat* c, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(ref GLuint rc, GLfloat* c, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(ref GLuint rc, GLfloat* c, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(ref GLuint rc, GLfloat[] c, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(ref GLuint rc, GLfloat[] c, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(ref GLuint rc, GLfloat[] c, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(ref GLuint rc, ref GLfloat c, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(ref GLuint rc, ref GLfloat c, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(ref GLuint rc, ref GLfloat c, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor3fVertex3fvSUN(rc_ptr, c_ptr, v_ptr);
            }
        }
        
        public static void ReplacementCodeuiNormal3fVertex3fSUN(GLuint rc, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            ReplacementCodeuiNormal3fVertex3fSUN(rc, nx, ny, nz, x, y, z);
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint* rc, GLfloat* n, GLfloat* v)
        {
            return ReplacementCodeuiNormal3fVertex3fvSUN(rc, n, v);
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint* rc, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint* rc, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc, n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc, n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc, n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc, n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiNormal3fVertex3fvSUN(rc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static void ReplacementCodeuiColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            ReplacementCodeuiColor4fNormal3fVertex3fSUN(rc, r, g, b, a, nx, ny, nz, x, y, z);
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            return ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n, v);
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiColor4fNormal3fVertex3fvSUN(rc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static void ReplacementCodeuiTexCoord2fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z)
        {
            ReplacementCodeuiTexCoord2fVertex3fSUN(rc, s, t, x, y, z);
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* v)
        {
            return ReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc, v);
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint* rc, GLfloat* tc, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint* rc, GLfloat[] tc, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint* rc, ref GLfloat tc, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc, tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint[] rc, GLfloat* tc, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(ref GLuint rc, GLfloat* tc, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fVertex3fvSUN(rc_ptr, tc_ptr, v_ptr);
            }
        }
        
        public static void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(rc, s, t, nx, ny, nz, x, y, z);
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* n, GLfloat* v)
        {
            return ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n, v);
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, n_ptr, v_ptr);
            }
        }
        
        public static void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(rc, s, t, r, g, b, a, nx, ny, nz, x, y, z);
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            return ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n, v);
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n_ptr, v);
            }
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v);
            }
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat[] tc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, ref GLfloat tc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat* tc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, ref GLfloat tc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat* tc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, GLfloat[] tc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat* c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat* c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat* c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat* c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat* c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat* c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat* c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat* c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat* c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat[] c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat[] c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat[] c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat[] c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat[] c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat[] c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat[] c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, GLfloat[] c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, ref GLfloat c, GLfloat* n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, ref GLfloat c, GLfloat* n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, ref GLfloat c, GLfloat* n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, ref GLfloat c, GLfloat[] n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, ref GLfloat c, GLfloat[] n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, ref GLfloat c, GLfloat[] n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, ref GLfloat c, ref GLfloat n, GLfloat* v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, ref GLfloat c, ref GLfloat n, GLfloat[] v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ref GLuint rc, ref GLfloat tc, ref GLfloat c, ref GLfloat n, ref GLfloat v)
        {
            fixed (GLuint rc_ptr = &rc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v);
            }
            fixed (GLuint rc_ptr = &rc)
            fixed (GLfloat tc_ptr = &tc)
            fixed (GLfloat c_ptr = &c)
            fixed (GLfloat n_ptr = &n)
            fixed (GLfloat v_ptr = &v)
            {
                ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(rc_ptr, tc_ptr, c_ptr, n_ptr, v_ptr);
            }
        }
        
        public static void BlendFuncSeparateEXT(GL.Enums.EXT_blend_func_separate sfactorRGB, GL.Enums.EXT_blend_func_separate dfactorRGB, GL.Enums.EXT_blend_func_separate sfactorAlpha, GL.Enums.EXT_blend_func_separate dfactorAlpha)
        {
            BlendFuncSeparateEXT(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        }
        
        public static void BlendFuncSeparateINGR(GL.Enums.GLenum sfactorRGB, GL.Enums.GLenum dfactorRGB, GL.Enums.GLenum sfactorAlpha, GL.Enums.GLenum dfactorAlpha)
        {
            BlendFuncSeparateINGR(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        }
        
        public static void VertexWeightfEXT(GLfloat weight)
        {
            VertexWeightfEXT(weight);
        }
        
        public static unsafe void VertexWeightfvEXT(GLfloat* weight)
        {
            return VertexWeightfvEXT(weight);
        }
        
        public static unsafe void VertexWeightfvEXT(GLfloat[] weight)
        {
            fixed (GLfloat weight_ptr = weight)
            {
                VertexWeightfvEXT(weight_ptr);
            }
        }
        
        public static unsafe void VertexWeightfvEXT(ref GLfloat weight)
        {
            fixed (GLfloat weight_ptr = &weight)
            {
                VertexWeightfvEXT(weight_ptr);
            }
        }
        
        public static unsafe void VertexWeightPointerEXT(GLsizei size, GL.Enums.EXT_vertex_weighting type, GLsizei stride, void* pointer)
        {
            return VertexWeightPointerEXT(size, type, stride, pointer);
        }
        
        public static void FlushVertexArrayRangeNV()
        {
            FlushVertexArrayRangeNV();
        }
        
        public static unsafe void VertexArrayRangeNV(GLsizei length, void* pointer)
        {
            return VertexArrayRangeNV(length, pointer);
        }
        
        public static unsafe void CombinerParameterfvNV(GL.Enums.NV_register_combiners pname, GLfloat* @params)
        {
            return CombinerParameterfvNV(pname, @params);
        }
        
        public static void CombinerParameterfNV(GL.Enums.NV_register_combiners pname, GLfloat param)
        {
            CombinerParameterfNV(pname, param);
        }
        
        public static unsafe void CombinerParameterivNV(GL.Enums.NV_register_combiners pname, GLint* @params)
        {
            return CombinerParameterivNV(pname, @params);
        }
        
        public static void CombinerParameteriNV(GL.Enums.NV_register_combiners pname, GLint param)
        {
            CombinerParameteriNV(pname, param);
        }
        
        public static void CombinerInputNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners input, GL.Enums.NV_register_combiners mapping, GL.Enums.NV_register_combiners componentUsage)
        {
            CombinerInputNV(stage, portion, variable, input, mapping, componentUsage);
        }
        
        public static void FinalCombinerInputNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners input, GL.Enums.NV_register_combiners mapping, GL.Enums.NV_register_combiners componentUsage)
        {
            FinalCombinerInputNV(variable, input, mapping, componentUsage);
        }
        
        public static unsafe void GetCombinerInputParameterfvNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, GLfloat* @params)
        {
            return GetCombinerInputParameterfvNV(stage, portion, variable, pname, @params);
        }
        
        public static unsafe void GetCombinerInputParameterivNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, GLint* @params)
        {
            return GetCombinerInputParameterivNV(stage, portion, variable, pname, @params);
        }
        
        public static unsafe void GetCombinerOutputParameterfvNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners pname, GLfloat* @params)
        {
            return GetCombinerOutputParameterfvNV(stage, portion, pname, @params);
        }
        
        public static unsafe void GetCombinerOutputParameterivNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners pname, GLint* @params)
        {
            return GetCombinerOutputParameterivNV(stage, portion, pname, @params);
        }
        
        public static unsafe void GetFinalCombinerInputParameterfvNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, GLfloat* @params)
        {
            return GetFinalCombinerInputParameterfvNV(variable, pname, @params);
        }
        
        public static unsafe void GetFinalCombinerInputParameterivNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, GLint* @params)
        {
            return GetFinalCombinerInputParameterivNV(variable, pname, @params);
        }
        
        public static void ResizeBuffersMESA()
        {
            ResizeBuffersMESA();
        }
        
        public static void WindowPos2dMESA(GLdouble x, GLdouble y)
        {
            WindowPos2dMESA(x, y);
        }
        
        public static unsafe void WindowPos2dvMESA(GLdouble* v)
        {
            return WindowPos2dvMESA(v);
        }
        
        public static unsafe void WindowPos2dvMESA(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                WindowPos2dvMESA(v_ptr);
            }
        }
        
        public static unsafe void WindowPos2dvMESA(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                WindowPos2dvMESA(v_ptr);
            }
        }
        
        public static void WindowPos2fMESA(GLfloat x, GLfloat y)
        {
            WindowPos2fMESA(x, y);
        }
        
        public static unsafe void WindowPos2fvMESA(GLfloat* v)
        {
            return WindowPos2fvMESA(v);
        }
        
        public static unsafe void WindowPos2fvMESA(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                WindowPos2fvMESA(v_ptr);
            }
        }
        
        public static unsafe void WindowPos2fvMESA(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                WindowPos2fvMESA(v_ptr);
            }
        }
        
        public static void WindowPos2iMESA(GLint x, GLint y)
        {
            WindowPos2iMESA(x, y);
        }
        
        public static unsafe void WindowPos2ivMESA(GLint* v)
        {
            return WindowPos2ivMESA(v);
        }
        
        public static unsafe void WindowPos2ivMESA(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                WindowPos2ivMESA(v_ptr);
            }
        }
        
        public static unsafe void WindowPos2ivMESA(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                WindowPos2ivMESA(v_ptr);
            }
        }
        
        public static void WindowPos2sMESA(GLshort x, GLshort y)
        {
            WindowPos2sMESA(x, y);
        }
        
        public static unsafe void WindowPos2svMESA(GLshort* v)
        {
            return WindowPos2svMESA(v);
        }
        
        public static unsafe void WindowPos2svMESA(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                WindowPos2svMESA(v_ptr);
            }
        }
        
        public static unsafe void WindowPos2svMESA(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                WindowPos2svMESA(v_ptr);
            }
        }
        
        public static void WindowPos3dMESA(GLdouble x, GLdouble y, GLdouble z)
        {
            WindowPos3dMESA(x, y, z);
        }
        
        public static unsafe void WindowPos3dvMESA(GLdouble* v)
        {
            return WindowPos3dvMESA(v);
        }
        
        public static unsafe void WindowPos3dvMESA(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                WindowPos3dvMESA(v_ptr);
            }
        }
        
        public static unsafe void WindowPos3dvMESA(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                WindowPos3dvMESA(v_ptr);
            }
        }
        
        public static void WindowPos3fMESA(GLfloat x, GLfloat y, GLfloat z)
        {
            WindowPos3fMESA(x, y, z);
        }
        
        public static unsafe void WindowPos3fvMESA(GLfloat* v)
        {
            return WindowPos3fvMESA(v);
        }
        
        public static unsafe void WindowPos3fvMESA(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                WindowPos3fvMESA(v_ptr);
            }
        }
        
        public static unsafe void WindowPos3fvMESA(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                WindowPos3fvMESA(v_ptr);
            }
        }
        
        public static void WindowPos3iMESA(GLint x, GLint y, GLint z)
        {
            WindowPos3iMESA(x, y, z);
        }
        
        public static unsafe void WindowPos3ivMESA(GLint* v)
        {
            return WindowPos3ivMESA(v);
        }
        
        public static unsafe void WindowPos3ivMESA(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                WindowPos3ivMESA(v_ptr);
            }
        }
        
        public static unsafe void WindowPos3ivMESA(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                WindowPos3ivMESA(v_ptr);
            }
        }
        
        public static void WindowPos3sMESA(GLshort x, GLshort y, GLshort z)
        {
            WindowPos3sMESA(x, y, z);
        }
        
        public static unsafe void WindowPos3svMESA(GLshort* v)
        {
            return WindowPos3svMESA(v);
        }
        
        public static unsafe void WindowPos3svMESA(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                WindowPos3svMESA(v_ptr);
            }
        }
        
        public static unsafe void WindowPos3svMESA(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                WindowPos3svMESA(v_ptr);
            }
        }
        
        public static void WindowPos4dMESA(GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            WindowPos4dMESA(x, y, z, w);
        }
        
        public static unsafe void WindowPos4dvMESA(GLdouble* v)
        {
            return WindowPos4dvMESA(v);
        }
        
        public static unsafe void WindowPos4dvMESA(GLdouble[] v)
        {
            fixed (GLdouble v_ptr = v)
            {
                WindowPos4dvMESA(v_ptr);
            }
        }
        
        public static unsafe void WindowPos4dvMESA(ref GLdouble v)
        {
            fixed (GLdouble v_ptr = &v)
            {
                WindowPos4dvMESA(v_ptr);
            }
        }
        
        public static void WindowPos4fMESA(GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            WindowPos4fMESA(x, y, z, w);
        }
        
        public static unsafe void WindowPos4fvMESA(GLfloat* v)
        {
            return WindowPos4fvMESA(v);
        }
        
        public static unsafe void WindowPos4fvMESA(GLfloat[] v)
        {
            fixed (GLfloat v_ptr = v)
            {
                WindowPos4fvMESA(v_ptr);
            }
        }
        
        public static unsafe void WindowPos4fvMESA(ref GLfloat v)
        {
            fixed (GLfloat v_ptr = &v)
            {
                WindowPos4fvMESA(v_ptr);
            }
        }
        
        public static void WindowPos4iMESA(GLint x, GLint y, GLint z, GLint w)
        {
            WindowPos4iMESA(x, y, z, w);
        }
        
        public static unsafe void WindowPos4ivMESA(GLint* v)
        {
            return WindowPos4ivMESA(v);
        }
        
        public static unsafe void WindowPos4ivMESA(GLint[] v)
        {
            fixed (GLint v_ptr = v)
            {
                WindowPos4ivMESA(v_ptr);
            }
        }
        
        public static unsafe void WindowPos4ivMESA(ref GLint v)
        {
            fixed (GLint v_ptr = &v)
            {
                WindowPos4ivMESA(v_ptr);
            }
        }
        
        public static void WindowPos4sMESA(GLshort x, GLshort y, GLshort z, GLshort w)
        {
            WindowPos4sMESA(x, y, z, w);
        }
        
        public static unsafe void WindowPos4svMESA(GLshort* v)
        {
            return WindowPos4svMESA(v);
        }
        
        public static unsafe void WindowPos4svMESA(GLshort[] v)
        {
            fixed (GLshort v_ptr = v)
            {
                WindowPos4svMESA(v_ptr);
            }
        }
        
        public static unsafe void WindowPos4svMESA(ref GLshort v)
        {
            fixed (GLshort v_ptr = &v)
            {
                WindowPos4svMESA(v_ptr);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode* mode, GLint* first, GLsizei* count, GLsizei primcount, GLint modestride)
        {
            return MultiModeDrawArraysIBM(mode, first, count, primcount, modestride);
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode* mode, GLint* first, GLsizei[] count, GLsizei primcount, GLint modestride)
        {
            fixed (GLsizei count_ptr = count)
            {
                MultiModeDrawArraysIBM(mode, first, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode* mode, GLint* first, ref GLsizei count, GLsizei primcount, GLint modestride)
        {
            fixed (GLsizei count_ptr = &count)
            {
                MultiModeDrawArraysIBM(mode, first, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode* mode, GLint[] first, GLsizei* count, GLsizei primcount, GLint modestride)
        {
            fixed (GLint first_ptr = first)
            {
                MultiModeDrawArraysIBM(mode, first_ptr, count, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode* mode, GLint[] first, GLsizei[] count, GLsizei primcount, GLint modestride)
        {
            fixed (GLint first_ptr = first)
            {
                MultiModeDrawArraysIBM(mode, first_ptr, count, primcount, modestride);
            }
            fixed (GLint first_ptr = first)
            fixed (GLsizei count_ptr = count)
            {
                MultiModeDrawArraysIBM(mode, first_ptr, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode* mode, GLint[] first, ref GLsizei count, GLsizei primcount, GLint modestride)
        {
            fixed (GLint first_ptr = first)
            {
                MultiModeDrawArraysIBM(mode, first_ptr, count, primcount, modestride);
            }
            fixed (GLint first_ptr = first)
            fixed (GLsizei count_ptr = &count)
            {
                MultiModeDrawArraysIBM(mode, first_ptr, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode* mode, ref GLint first, GLsizei* count, GLsizei primcount, GLint modestride)
        {
            fixed (GLint first_ptr = &first)
            {
                MultiModeDrawArraysIBM(mode, first_ptr, count, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode* mode, ref GLint first, GLsizei[] count, GLsizei primcount, GLint modestride)
        {
            fixed (GLint first_ptr = &first)
            {
                MultiModeDrawArraysIBM(mode, first_ptr, count, primcount, modestride);
            }
            fixed (GLint first_ptr = &first)
            fixed (GLsizei count_ptr = count)
            {
                MultiModeDrawArraysIBM(mode, first_ptr, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode* mode, ref GLint first, ref GLsizei count, GLsizei primcount, GLint modestride)
        {
            fixed (GLint first_ptr = &first)
            {
                MultiModeDrawArraysIBM(mode, first_ptr, count, primcount, modestride);
            }
            fixed (GLint first_ptr = &first)
            fixed (GLsizei count_ptr = &count)
            {
                MultiModeDrawArraysIBM(mode, first_ptr, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode[] mode, GLint* first, GLsizei* count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode[] mode, GLint* first, GLsizei[] count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            fixed (GLsizei count_ptr = count)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode[] mode, GLint* first, ref GLsizei count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            fixed (GLsizei count_ptr = &count)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode[] mode, GLint[] first, GLsizei* count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            fixed (GLint first_ptr = first)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode[] mode, GLint[] first, GLsizei[] count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            fixed (GLint first_ptr = first)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            fixed (GLint first_ptr = first)
            fixed (GLsizei count_ptr = count)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode[] mode, GLint[] first, ref GLsizei count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            fixed (GLint first_ptr = first)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            fixed (GLint first_ptr = first)
            fixed (GLsizei count_ptr = &count)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode[] mode, ref GLint first, GLsizei* count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            fixed (GLint first_ptr = &first)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode[] mode, ref GLint first, GLsizei[] count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            fixed (GLint first_ptr = &first)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            fixed (GLint first_ptr = &first)
            fixed (GLsizei count_ptr = count)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode[] mode, ref GLint first, ref GLsizei count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            fixed (GLint first_ptr = &first)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            fixed (GLint first_ptr = &first)
            fixed (GLsizei count_ptr = &count)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(ref GL.Enums.BeginMode mode, GLint* first, GLsizei* count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(ref GL.Enums.BeginMode mode, GLint* first, GLsizei[] count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            fixed (GLsizei count_ptr = count)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(ref GL.Enums.BeginMode mode, GLint* first, ref GLsizei count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            fixed (GLsizei count_ptr = &count)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(ref GL.Enums.BeginMode mode, GLint[] first, GLsizei* count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            fixed (GLint first_ptr = first)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(ref GL.Enums.BeginMode mode, GLint[] first, GLsizei[] count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            fixed (GLint first_ptr = first)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            fixed (GLint first_ptr = first)
            fixed (GLsizei count_ptr = count)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(ref GL.Enums.BeginMode mode, GLint[] first, ref GLsizei count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            fixed (GLint first_ptr = first)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            fixed (GLint first_ptr = first)
            fixed (GLsizei count_ptr = &count)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(ref GL.Enums.BeginMode mode, ref GLint first, GLsizei* count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            fixed (GLint first_ptr = &first)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(ref GL.Enums.BeginMode mode, ref GLint first, GLsizei[] count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            fixed (GLint first_ptr = &first)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            fixed (GLint first_ptr = &first)
            fixed (GLsizei count_ptr = count)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawArraysIBM(ref GL.Enums.BeginMode mode, ref GLint first, ref GLsizei count, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            {
                MultiModeDrawArraysIBM(mode_ptr, first, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            fixed (GLint first_ptr = &first)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            fixed (GLint first_ptr = &first)
            fixed (GLsizei count_ptr = &count)
            {
                MultiModeDrawArraysIBM(mode_ptr, first_ptr, count_ptr, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawElementsIBM(GL.Enums.BeginMode* mode, GLsizei* count, GL.Enums.IBM_multimode_draw_arrays type, void* indices, GLsizei primcount, GLint modestride)
        {
            return MultiModeDrawElementsIBM(mode, count, type, indices, primcount, modestride);
        }
        
        public static unsafe void MultiModeDrawElementsIBM(GL.Enums.BeginMode* mode, GLsizei[] count, GL.Enums.IBM_multimode_draw_arrays type, void* indices, GLsizei primcount, GLint modestride)
        {
            fixed (GLsizei count_ptr = count)
            {
                MultiModeDrawElementsIBM(mode, count_ptr, type, indices, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawElementsIBM(GL.Enums.BeginMode* mode, ref GLsizei count, GL.Enums.IBM_multimode_draw_arrays type, void* indices, GLsizei primcount, GLint modestride)
        {
            fixed (GLsizei count_ptr = &count)
            {
                MultiModeDrawElementsIBM(mode, count_ptr, type, indices, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawElementsIBM(GL.Enums.BeginMode[] mode, GLsizei* count, GL.Enums.IBM_multimode_draw_arrays type, void* indices, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            {
                MultiModeDrawElementsIBM(mode_ptr, count, type, indices, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawElementsIBM(GL.Enums.BeginMode[] mode, GLsizei[] count, GL.Enums.IBM_multimode_draw_arrays type, void* indices, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            {
                MultiModeDrawElementsIBM(mode_ptr, count, type, indices, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            fixed (GLsizei count_ptr = count)
            {
                MultiModeDrawElementsIBM(mode_ptr, count_ptr, type, indices, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawElementsIBM(GL.Enums.BeginMode[] mode, ref GLsizei count, GL.Enums.IBM_multimode_draw_arrays type, void* indices, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            {
                MultiModeDrawElementsIBM(mode_ptr, count, type, indices, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = mode)
            fixed (GLsizei count_ptr = &count)
            {
                MultiModeDrawElementsIBM(mode_ptr, count_ptr, type, indices, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawElementsIBM(ref GL.Enums.BeginMode mode, GLsizei* count, GL.Enums.IBM_multimode_draw_arrays type, void* indices, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            {
                MultiModeDrawElementsIBM(mode_ptr, count, type, indices, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawElementsIBM(ref GL.Enums.BeginMode mode, GLsizei[] count, GL.Enums.IBM_multimode_draw_arrays type, void* indices, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            {
                MultiModeDrawElementsIBM(mode_ptr, count, type, indices, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            fixed (GLsizei count_ptr = count)
            {
                MultiModeDrawElementsIBM(mode_ptr, count_ptr, type, indices, primcount, modestride);
            }
        }
        
        public static unsafe void MultiModeDrawElementsIBM(ref GL.Enums.BeginMode mode, ref GLsizei count, GL.Enums.IBM_multimode_draw_arrays type, void* indices, GLsizei primcount, GLint modestride)
        {
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            {
                MultiModeDrawElementsIBM(mode_ptr, count, type, indices, primcount, modestride);
            }
            fixed (GL.Enums.BeginMode mode_ptr = &mode)
            fixed (GLsizei count_ptr = &count)
            {
                MultiModeDrawElementsIBM(mode_ptr, count_ptr, type, indices, primcount, modestride);
            }
        }
        
        public static unsafe void ColorPointerListIBM(GLint size, GL.Enums.ColorPointerType type, GLint stride, void* pointer, GLint ptrstride)
        {
            return ColorPointerListIBM(size, type, stride, pointer, ptrstride);
        }
        
        public static unsafe void SecondaryColorPointerListIBM(GLint size, GL.Enums.IBM_vertex_array_lists type, GLint stride, void* pointer, GLint ptrstride)
        {
            return SecondaryColorPointerListIBM(size, type, stride, pointer, ptrstride);
        }
        
        public static unsafe void EdgeFlagPointerListIBM(GLint stride, GLboolean* pointer, GLint ptrstride)
        {
            return EdgeFlagPointerListIBM(stride, pointer, ptrstride);
        }
        
        public static unsafe void FogCoordPointerListIBM(GL.Enums.IBM_vertex_array_lists type, GLint stride, void* pointer, GLint ptrstride)
        {
            return FogCoordPointerListIBM(type, stride, pointer, ptrstride);
        }
        
        public static unsafe void IndexPointerListIBM(GL.Enums.IndexPointerType type, GLint stride, void* pointer, GLint ptrstride)
        {
            return IndexPointerListIBM(type, stride, pointer, ptrstride);
        }
        
        public static unsafe void NormalPointerListIBM(GL.Enums.NormalPointerType type, GLint stride, void* pointer, GLint ptrstride)
        {
            return NormalPointerListIBM(type, stride, pointer, ptrstride);
        }
        
        public static unsafe void TexCoordPointerListIBM(GLint size, GL.Enums.TexCoordPointerType type, GLint stride, void* pointer, GLint ptrstride)
        {
            return TexCoordPointerListIBM(size, type, stride, pointer, ptrstride);
        }
        
        public static unsafe void VertexPointerListIBM(GLint size, GL.Enums.VertexPointerType type, GLint stride, void* pointer, GLint ptrstride)
        {
            return VertexPointerListIBM(size, type, stride, pointer, ptrstride);
        }
        
        public static void TbufferMask3DFX(GLuint mask)
        {
            TbufferMask3DFX(mask);
        }
        
        public static void SamplePatternEXT(GL.Enums.EXT_multisample pattern)
        {
            SamplePatternEXT(pattern);
        }
        
        public static unsafe void IglooInterfaceSGIX(GL.Enums.GLenum pname, void* @params)
        {
            return IglooInterfaceSGIX(pname, @params);
        }
        
        public static unsafe void DeleteFencesNV(GLsizei n, GLuint* fences)
        {
            return DeleteFencesNV(n, fences);
        }
        
        public static unsafe void GenFencesNV(GLsizei n, GLuint* fences)
        {
            return GenFencesNV(n, fences);
        }
        
        public static GLboolean IsFenceNV(GLuint fence)
        {
            return IsFenceNV(fence);
        }
        
        public static GLboolean TestFenceNV(GLuint fence)
        {
            return TestFenceNV(fence);
        }
        
        public static unsafe void GetFenceivNV(GLuint fence, GL.Enums.NV_fence pname, GLint* @params)
        {
            return GetFenceivNV(fence, pname, @params);
        }
        
        public static void FinishFenceNV(GLuint fence)
        {
            FinishFenceNV(fence);
        }
        
        public static void SetFenceNV(GLuint fence, GL.Enums.NV_fence condition)
        {
            SetFenceNV(fence, condition);
        }
        
        public static unsafe void MapControlPointsNV(GL.Enums.NV_evaluators target, GLuint index, GL.Enums.NV_evaluators type, GLsizei ustride, GLsizei vstride, GLint uorder, GLint vorder, GL.Enums.Boolean packed, void* points)
        {
            return MapControlPointsNV(target, index, type, ustride, vstride, uorder, vorder, packed, points);
        }
        
        public static unsafe void MapParameterivNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, GLint* @params)
        {
            return MapParameterivNV(target, pname, @params);
        }
        
        public static unsafe void MapParameterfvNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, GLfloat* @params)
        {
            return MapParameterfvNV(target, pname, @params);
        }
        
        public static unsafe void GetMapControlPointsNV(GL.Enums.NV_evaluators target, GLuint index, GL.Enums.NV_evaluators type, GLsizei ustride, GLsizei vstride, GL.Enums.Boolean packed, void* points)
        {
            return GetMapControlPointsNV(target, index, type, ustride, vstride, packed, points);
        }
        
        public static unsafe void GetMapParameterivNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, GLint* @params)
        {
            return GetMapParameterivNV(target, pname, @params);
        }
        
        public static unsafe void GetMapParameterfvNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, GLfloat* @params)
        {
            return GetMapParameterfvNV(target, pname, @params);
        }
        
        public static unsafe void GetMapAttribParameterivNV(GL.Enums.NV_evaluators target, GLuint index, GL.Enums.NV_evaluators pname, GLint* @params)
        {
            return GetMapAttribParameterivNV(target, index, pname, @params);
        }
        
        public static unsafe void GetMapAttribParameterfvNV(GL.Enums.NV_evaluators target, GLuint index, GL.Enums.NV_evaluators pname, GLfloat* @params)
        {
            return GetMapAttribParameterfvNV(target, index, pname, @params);
        }
        
        public static void EvalMapsNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators mode)
        {
            EvalMapsNV(target, mode);
        }
        
        public static unsafe void CombinerStageParameterfvNV(GL.Enums.NV_register_combiners2 stage, GL.Enums.NV_register_combiners2 pname, GLfloat* @params)
        {
            return CombinerStageParameterfvNV(stage, pname, @params);
        }
        
        public static unsafe void GetCombinerStageParameterfvNV(GL.Enums.NV_register_combiners2 stage, GL.Enums.NV_register_combiners2 pname, GLfloat* @params)
        {
            return GetCombinerStageParameterfvNV(stage, pname, @params);
        }
        
        public static unsafe GLboolean AreProgramsResidentNV(GLsizei n, GLuint* programs, GL.Enums.Boolean* residences)
        {
            AreProgramsResidentNV(n, programs, residences);
        }
        
        public static void BindProgramNV(GL.Enums.NV_vertex_program target, GLuint id)
        {
            BindProgramNV(target, id);
        }
        
        public static unsafe void DeleteProgramsNV(GLsizei n, GLuint* programs)
        {
            return DeleteProgramsNV(n, programs);
        }
        
        public static unsafe void ExecuteProgramNV(GL.Enums.NV_vertex_program target, GLuint id, GLfloat* @params)
        {
            return ExecuteProgramNV(target, id, @params);
        }
        
        public static unsafe void GenProgramsNV(GLsizei n, GLuint* programs)
        {
            return GenProgramsNV(n, programs);
        }
        
        public static unsafe void GetProgramParameterdvNV(GL.Enums.NV_vertex_program target, GLuint index, GL.Enums.NV_vertex_program pname, GLdouble* @params)
        {
            return GetProgramParameterdvNV(target, index, pname, @params);
        }
        
        public static unsafe void GetProgramParameterfvNV(GL.Enums.NV_vertex_program target, GLuint index, GL.Enums.NV_vertex_program pname, GLfloat* @params)
        {
            return GetProgramParameterfvNV(target, index, pname, @params);
        }
        
        public static unsafe void GetProgramivNV(GLuint id, GL.Enums.NV_vertex_program pname, GLint* @params)
        {
            return GetProgramivNV(id, pname, @params);
        }
        
        public static unsafe void GetProgramStringNV(GLuint id, GL.Enums.NV_vertex_program pname, GLubyte* program)
        {
            return GetProgramStringNV(id, pname, program);
        }
        
        public static unsafe void GetTrackMatrixivNV(GL.Enums.NV_vertex_program target, GLuint address, GL.Enums.NV_vertex_program pname, GLint* @params)
        {
            return GetTrackMatrixivNV(target, address, pname, @params);
        }
        
        public static unsafe void GetVertexAttribdvNV(GLuint index, GL.Enums.NV_vertex_program pname, GLdouble* @params)
        {
            return GetVertexAttribdvNV(index, pname, @params);
        }
        
        public static unsafe void GetVertexAttribfvNV(GLuint index, GL.Enums.NV_vertex_program pname, GLfloat* @params)
        {
            return GetVertexAttribfvNV(index, pname, @params);
        }
        
        public static unsafe void GetVertexAttribivNV(GLuint index, GL.Enums.NV_vertex_program pname, GLint* @params)
        {
            return GetVertexAttribivNV(index, pname, @params);
        }
        
        public static unsafe void GetVertexAttribPointervNV(GLuint index, GL.Enums.NV_vertex_program pname, void* pointer)
        {
            return GetVertexAttribPointervNV(index, pname, pointer);
        }
        
        public static GLboolean IsProgramNV(GLuint id)
        {
            return IsProgramNV(id);
        }
        
        public static unsafe void LoadProgramNV(GL.Enums.NV_vertex_program target, GLuint id, GLsizei len, GLubyte* program)
        {
            return LoadProgramNV(target, id, len, program);
        }
        
        public static void ProgramParameter4dNV(GL.Enums.NV_vertex_program target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            ProgramParameter4dNV(target, index, x, y, z, w);
        }
        
        public static unsafe void ProgramParameter4dvNV(GL.Enums.NV_vertex_program target, GLuint index, GLdouble* v)
        {
            return ProgramParameter4dvNV(target, index, v);
        }
        
        public static void ProgramParameter4fNV(GL.Enums.NV_vertex_program target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            ProgramParameter4fNV(target, index, x, y, z, w);
        }
        
        public static unsafe void ProgramParameter4fvNV(GL.Enums.NV_vertex_program target, GLuint index, GLfloat* v)
        {
            return ProgramParameter4fvNV(target, index, v);
        }
        
        public static unsafe void ProgramParameters4dvNV(GL.Enums.NV_vertex_program target, GLuint index, GLuint count, GLdouble* v)
        {
            return ProgramParameters4dvNV(target, index, count, v);
        }
        
        public static unsafe void ProgramParameters4fvNV(GL.Enums.NV_vertex_program target, GLuint index, GLuint count, GLfloat* v)
        {
            return ProgramParameters4fvNV(target, index, count, v);
        }
        
        public static unsafe void RequestResidentProgramsNV(GLsizei n, GLuint* programs)
        {
            return RequestResidentProgramsNV(n, programs);
        }
        
        public static void TrackMatrixNV(GL.Enums.NV_vertex_program target, GLuint address, GL.Enums.NV_vertex_program matrix, GL.Enums.NV_vertex_program transform)
        {
            TrackMatrixNV(target, address, matrix, transform);
        }
        
        public static unsafe void VertexAttribPointerNV(GLuint index, GLint fsize, GL.Enums.NV_vertex_program type, GLsizei stride, void* pointer)
        {
            return VertexAttribPointerNV(index, fsize, type, stride, pointer);
        }
        
        public static void VertexAttrib1dNV(GLuint index, GLdouble x)
        {
            VertexAttrib1dNV(index, x);
        }
        
        public static unsafe void VertexAttrib1dvNV(GLuint index, GLdouble* v)
        {
            return VertexAttrib1dvNV(index, v);
        }
        
        public static void VertexAttrib1fNV(GLuint index, GLfloat x)
        {
            VertexAttrib1fNV(index, x);
        }
        
        public static unsafe void VertexAttrib1fvNV(GLuint index, GLfloat* v)
        {
            return VertexAttrib1fvNV(index, v);
        }
        
        public static void VertexAttrib1sNV(GLuint index, GLshort x)
        {
            VertexAttrib1sNV(index, x);
        }
        
        public static unsafe void VertexAttrib1svNV(GLuint index, GLshort* v)
        {
            return VertexAttrib1svNV(index, v);
        }
        
        public static void VertexAttrib2dNV(GLuint index, GLdouble x, GLdouble y)
        {
            VertexAttrib2dNV(index, x, y);
        }
        
        public static unsafe void VertexAttrib2dvNV(GLuint index, GLdouble* v)
        {
            return VertexAttrib2dvNV(index, v);
        }
        
        public static void VertexAttrib2fNV(GLuint index, GLfloat x, GLfloat y)
        {
            VertexAttrib2fNV(index, x, y);
        }
        
        public static unsafe void VertexAttrib2fvNV(GLuint index, GLfloat* v)
        {
            return VertexAttrib2fvNV(index, v);
        }
        
        public static void VertexAttrib2sNV(GLuint index, GLshort x, GLshort y)
        {
            VertexAttrib2sNV(index, x, y);
        }
        
        public static unsafe void VertexAttrib2svNV(GLuint index, GLshort* v)
        {
            return VertexAttrib2svNV(index, v);
        }
        
        public static void VertexAttrib3dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z)
        {
            VertexAttrib3dNV(index, x, y, z);
        }
        
        public static unsafe void VertexAttrib3dvNV(GLuint index, GLdouble* v)
        {
            return VertexAttrib3dvNV(index, v);
        }
        
        public static void VertexAttrib3fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z)
        {
            VertexAttrib3fNV(index, x, y, z);
        }
        
        public static unsafe void VertexAttrib3fvNV(GLuint index, GLfloat* v)
        {
            return VertexAttrib3fvNV(index, v);
        }
        
        public static void VertexAttrib3sNV(GLuint index, GLshort x, GLshort y, GLshort z)
        {
            VertexAttrib3sNV(index, x, y, z);
        }
        
        public static unsafe void VertexAttrib3svNV(GLuint index, GLshort* v)
        {
            return VertexAttrib3svNV(index, v);
        }
        
        public static void VertexAttrib4dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            VertexAttrib4dNV(index, x, y, z, w);
        }
        
        public static unsafe void VertexAttrib4dvNV(GLuint index, GLdouble* v)
        {
            return VertexAttrib4dvNV(index, v);
        }
        
        public static void VertexAttrib4fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            VertexAttrib4fNV(index, x, y, z, w);
        }
        
        public static unsafe void VertexAttrib4fvNV(GLuint index, GLfloat* v)
        {
            return VertexAttrib4fvNV(index, v);
        }
        
        public static void VertexAttrib4sNV(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)
        {
            VertexAttrib4sNV(index, x, y, z, w);
        }
        
        public static unsafe void VertexAttrib4svNV(GLuint index, GLshort* v)
        {
            return VertexAttrib4svNV(index, v);
        }
        
        public static void VertexAttrib4ubNV(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)
        {
            VertexAttrib4ubNV(index, x, y, z, w);
        }
        
        public static unsafe void VertexAttrib4ubvNV(GLuint index, GLubyte* v)
        {
            return VertexAttrib4ubvNV(index, v);
        }
        
        public static unsafe void VertexAttribs1dvNV(GLuint index, GLsizei count, GLdouble* v)
        {
            return VertexAttribs1dvNV(index, count, v);
        }
        
        public static unsafe void VertexAttribs1fvNV(GLuint index, GLsizei count, GLfloat* v)
        {
            return VertexAttribs1fvNV(index, count, v);
        }
        
        public static unsafe void VertexAttribs1svNV(GLuint index, GLsizei count, GLshort* v)
        {
            return VertexAttribs1svNV(index, count, v);
        }
        
        public static unsafe void VertexAttribs2dvNV(GLuint index, GLsizei count, GLdouble* v)
        {
            return VertexAttribs2dvNV(index, count, v);
        }
        
        public static unsafe void VertexAttribs2fvNV(GLuint index, GLsizei count, GLfloat* v)
        {
            return VertexAttribs2fvNV(index, count, v);
        }
        
        public static unsafe void VertexAttribs2svNV(GLuint index, GLsizei count, GLshort* v)
        {
            return VertexAttribs2svNV(index, count, v);
        }
        
        public static unsafe void VertexAttribs3dvNV(GLuint index, GLsizei count, GLdouble* v)
        {
            return VertexAttribs3dvNV(index, count, v);
        }
        
        public static unsafe void VertexAttribs3fvNV(GLuint index, GLsizei count, GLfloat* v)
        {
            return VertexAttribs3fvNV(index, count, v);
        }
        
        public static unsafe void VertexAttribs3svNV(GLuint index, GLsizei count, GLshort* v)
        {
            return VertexAttribs3svNV(index, count, v);
        }
        
        public static unsafe void VertexAttribs4dvNV(GLuint index, GLsizei count, GLdouble* v)
        {
            return VertexAttribs4dvNV(index, count, v);
        }
        
        public static unsafe void VertexAttribs4fvNV(GLuint index, GLsizei count, GLfloat* v)
        {
            return VertexAttribs4fvNV(index, count, v);
        }
        
        public static unsafe void VertexAttribs4svNV(GLuint index, GLsizei count, GLshort* v)
        {
            return VertexAttribs4svNV(index, count, v);
        }
        
        public static unsafe void VertexAttribs4ubvNV(GLuint index, GLsizei count, GLubyte* v)
        {
            return VertexAttribs4ubvNV(index, count, v);
        }
        
        public static unsafe void TexBumpParameterivATI(GL.Enums.ATI_envmap_bumpmap pname, GLint* param)
        {
            return TexBumpParameterivATI(pname, param);
        }
        
        public static unsafe void TexBumpParameterfvATI(GL.Enums.ATI_envmap_bumpmap pname, GLfloat* param)
        {
            return TexBumpParameterfvATI(pname, param);
        }
        
        public static unsafe void GetTexBumpParameterivATI(GL.Enums.ATI_envmap_bumpmap pname, GLint* param)
        {
            return GetTexBumpParameterivATI(pname, param);
        }
        
        public static unsafe void GetTexBumpParameterfvATI(GL.Enums.ATI_envmap_bumpmap pname, GLfloat* param)
        {
            return GetTexBumpParameterfvATI(pname, param);
        }
        
        public static GLuint GenFragmentShadersATI(GLuint range)
        {
            return GenFragmentShadersATI(range);
        }
        
        public static void BindFragmentShaderATI(GLuint id)
        {
            BindFragmentShaderATI(id);
        }
        
        public static void DeleteFragmentShaderATI(GLuint id)
        {
            DeleteFragmentShaderATI(id);
        }
        
        public static void BeginFragmentShaderATI()
        {
            BeginFragmentShaderATI();
        }
        
        public static void EndFragmentShaderATI()
        {
            EndFragmentShaderATI();
        }
        
        public static void PassTexCoordATI(GLuint dst, GLuint coord, GL.Enums.ATI_fragment_shader swizzle)
        {
            PassTexCoordATI(dst, coord, swizzle);
        }
        
        public static void SampleMapATI(GLuint dst, GLuint interp, GL.Enums.ATI_fragment_shader swizzle)
        {
            SampleMapATI(dst, interp, swizzle);
        }
        
        public static void ColorFragmentOp1ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod)
        {
            ColorFragmentOp1ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod);
        }
        
        public static void ColorFragmentOp2ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod)
        {
            ColorFragmentOp2ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
        }
        
        public static void ColorFragmentOp3ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod)
        {
            ColorFragmentOp3ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
        }
        
        public static void AlphaFragmentOp1ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod)
        {
            AlphaFragmentOp1ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod);
        }
        
        public static void AlphaFragmentOp2ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod)
        {
            AlphaFragmentOp2ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
        }
        
        public static void AlphaFragmentOp3ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod)
        {
            AlphaFragmentOp3ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
        }
        
        public static unsafe void SetFragmentShaderConstantATI(GLuint dst, GLfloat* value)
        {
            return SetFragmentShaderConstantATI(dst, value);
        }
        
        public static void PNTrianglesiATI(GL.Enums.ATI_pn_triangles pname, GLint param)
        {
            PNTrianglesiATI(pname, param);
        }
        
        public static void PNTrianglesfATI(GL.Enums.ATI_pn_triangles pname, GLfloat param)
        {
            PNTrianglesfATI(pname, param);
        }
        
        public static unsafe GLuint NewObjectBufferATI(GLsizei size, void* pointer, GL.Enums.ATI_vertex_array_object usage)
        {
            NewObjectBufferATI(size, pointer, usage);
        }
        
        public static GLboolean IsObjectBufferATI(GLuint buffer)
        {
            return IsObjectBufferATI(buffer);
        }
        
        public static unsafe void UpdateObjectBufferATI(GLuint buffer, GLuint offset, GLsizei size, void* pointer, GL.Enums.ATI_vertex_array_object preserve)
        {
            return UpdateObjectBufferATI(buffer, offset, size, pointer, preserve);
        }
        
        public static unsafe void GetObjectBufferfvATI(GLuint buffer, GL.Enums.ATI_vertex_array_object pname, GLfloat* @params)
        {
            return GetObjectBufferfvATI(buffer, pname, @params);
        }
        
        public static unsafe void GetObjectBufferivATI(GLuint buffer, GL.Enums.ATI_vertex_array_object pname, GLint* @params)
        {
            return GetObjectBufferivATI(buffer, pname, @params);
        }
        
        public static void FreeObjectBufferATI(GLuint buffer)
        {
            FreeObjectBufferATI(buffer);
        }
        
        public static void ArrayObjectATI(GL.Enums.EnableCap array, GLint size, GL.Enums.ATI_vertex_array_object type, GLsizei stride, GLuint buffer, GLuint offset)
        {
            ArrayObjectATI(array, size, type, stride, buffer, offset);
        }
        
        public static unsafe void GetArrayObjectfvATI(GL.Enums.EnableCap array, GL.Enums.ATI_vertex_array_object pname, GLfloat* @params)
        {
            return GetArrayObjectfvATI(array, pname, @params);
        }
        
        public static unsafe void GetArrayObjectivATI(GL.Enums.EnableCap array, GL.Enums.ATI_vertex_array_object pname, GLint* @params)
        {
            return GetArrayObjectivATI(array, pname, @params);
        }
        
        public static void VariantArrayObjectATI(GLuint id, GL.Enums.ATI_vertex_array_object type, GLsizei stride, GLuint buffer, GLuint offset)
        {
            VariantArrayObjectATI(id, type, stride, buffer, offset);
        }
        
        public static unsafe void GetVariantArrayObjectfvATI(GLuint id, GL.Enums.ATI_vertex_array_object pname, GLfloat* @params)
        {
            return GetVariantArrayObjectfvATI(id, pname, @params);
        }
        
        public static unsafe void GetVariantArrayObjectivATI(GLuint id, GL.Enums.ATI_vertex_array_object pname, GLint* @params)
        {
            return GetVariantArrayObjectivATI(id, pname, @params);
        }
        
        public static void BeginVertexShaderEXT()
        {
            BeginVertexShaderEXT();
        }
        
        public static void EndVertexShaderEXT()
        {
            EndVertexShaderEXT();
        }
        
        public static void BindVertexShaderEXT(GLuint id)
        {
            BindVertexShaderEXT(id);
        }
        
        public static GLuint GenVertexShadersEXT(GLuint range)
        {
            return GenVertexShadersEXT(range);
        }
        
        public static void DeleteVertexShaderEXT(GLuint id)
        {
            DeleteVertexShaderEXT(id);
        }
        
        public static void ShaderOp1EXT(GL.Enums.EXT_vertex_shader op, GLuint res, GLuint arg1)
        {
            ShaderOp1EXT(op, res, arg1);
        }
        
        public static void ShaderOp2EXT(GL.Enums.EXT_vertex_shader op, GLuint res, GLuint arg1, GLuint arg2)
        {
            ShaderOp2EXT(op, res, arg1, arg2);
        }
        
        public static void ShaderOp3EXT(GL.Enums.EXT_vertex_shader op, GLuint res, GLuint arg1, GLuint arg2, GLuint arg3)
        {
            ShaderOp3EXT(op, res, arg1, arg2, arg3);
        }
        
        public static void SwizzleEXT(GLuint res, GLuint @in, GL.Enums.EXT_vertex_shader outX, GL.Enums.EXT_vertex_shader outY, GL.Enums.EXT_vertex_shader outZ, GL.Enums.EXT_vertex_shader outW)
        {
            SwizzleEXT(res, @in, outX, outY, outZ, outW);
        }
        
        public static void WriteMaskEXT(GLuint res, GLuint @in, GL.Enums.EXT_vertex_shader outX, GL.Enums.EXT_vertex_shader outY, GL.Enums.EXT_vertex_shader outZ, GL.Enums.EXT_vertex_shader outW)
        {
            WriteMaskEXT(res, @in, outX, outY, outZ, outW);
        }
        
        public static void InsertComponentEXT(GLuint res, GLuint src, GLuint num)
        {
            InsertComponentEXT(res, src, num);
        }
        
        public static void ExtractComponentEXT(GLuint res, GLuint src, GLuint num)
        {
            ExtractComponentEXT(res, src, num);
        }
        
        public static GLuint GenSymbolsEXT(GL.Enums.EXT_vertex_shader datatype, GL.Enums.EXT_vertex_shader storagetype, GL.Enums.EXT_vertex_shader range, GLuint components)
        {
            return GenSymbolsEXT(datatype, storagetype, range, components);
        }
        
        public static unsafe void SetInvariantEXT(GLuint id, GL.Enums.EXT_vertex_shader type, void* addr)
        {
            return SetInvariantEXT(id, type, addr);
        }
        
        public static unsafe void SetLocalConstantEXT(GLuint id, GL.Enums.EXT_vertex_shader type, void* addr)
        {
            return SetLocalConstantEXT(id, type, addr);
        }
        
        public static unsafe void VariantbvEXT(GLuint id, GLbyte* addr)
        {
            return VariantbvEXT(id, addr);
        }
        
        public static unsafe void VariantsvEXT(GLuint id, GLshort* addr)
        {
            return VariantsvEXT(id, addr);
        }
        
        public static unsafe void VariantivEXT(GLuint id, GLint* addr)
        {
            return VariantivEXT(id, addr);
        }
        
        public static unsafe void VariantfvEXT(GLuint id, GLfloat* addr)
        {
            return VariantfvEXT(id, addr);
        }
        
        public static unsafe void VariantdvEXT(GLuint id, GLdouble* addr)
        {
            return VariantdvEXT(id, addr);
        }
        
        public static unsafe void VariantubvEXT(GLuint id, GLubyte* addr)
        {
            return VariantubvEXT(id, addr);
        }
        
        public static unsafe void VariantusvEXT(GLuint id, GLushort* addr)
        {
            return VariantusvEXT(id, addr);
        }
        
        public static unsafe void VariantuivEXT(GLuint id, GLuint* addr)
        {
            return VariantuivEXT(id, addr);
        }
        
        public static unsafe void VariantPointerEXT(GLuint id, GL.Enums.EXT_vertex_shader type, GLuint stride, void* addr)
        {
            return VariantPointerEXT(id, type, stride, addr);
        }
        
        public static void EnableVariantClientStateEXT(GLuint id)
        {
            EnableVariantClientStateEXT(id);
        }
        
        public static void DisableVariantClientStateEXT(GLuint id)
        {
            DisableVariantClientStateEXT(id);
        }
        
        public static GLuint BindLightParameterEXT(GL.Enums.LightName light, GL.Enums.LightParameter value)
        {
            return BindLightParameterEXT(light, value);
        }
        
        public static GLuint BindMaterialParameterEXT(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter value)
        {
            return BindMaterialParameterEXT(face, value);
        }
        
        public static GLuint BindTexGenParameterEXT(GL.Enums.EXT_vertex_shader unit, GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter value)
        {
            return BindTexGenParameterEXT(unit, coord, value);
        }
        
        public static GLuint BindTextureUnitParameterEXT(GL.Enums.EXT_vertex_shader unit, GL.Enums.EXT_vertex_shader value)
        {
            return BindTextureUnitParameterEXT(unit, value);
        }
        
        public static GLuint BindParameterEXT(GL.Enums.EXT_vertex_shader value)
        {
            return BindParameterEXT(value);
        }
        
        public static GLboolean IsVariantEnabledEXT(GLuint id, GL.Enums.EXT_vertex_shader cap)
        {
            return IsVariantEnabledEXT(id, cap);
        }
        
        public static unsafe void GetVariantBooleanvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GL.Enums.Boolean* data)
        {
            return GetVariantBooleanvEXT(id, value, data);
        }
        
        public static unsafe void GetVariantIntegervEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLint* data)
        {
            return GetVariantIntegervEXT(id, value, data);
        }
        
        public static unsafe void GetVariantFloatvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLfloat* data)
        {
            return GetVariantFloatvEXT(id, value, data);
        }
        
        public static unsafe void GetVariantPointervEXT(GLuint id, GL.Enums.EXT_vertex_shader value, void* data)
        {
            return GetVariantPointervEXT(id, value, data);
        }
        
        public static unsafe void GetInvariantBooleanvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GL.Enums.Boolean* data)
        {
            return GetInvariantBooleanvEXT(id, value, data);
        }
        
        public static unsafe void GetInvariantIntegervEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLint* data)
        {
            return GetInvariantIntegervEXT(id, value, data);
        }
        
        public static unsafe void GetInvariantFloatvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLfloat* data)
        {
            return GetInvariantFloatvEXT(id, value, data);
        }
        
        public static unsafe void GetLocalConstantBooleanvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GL.Enums.Boolean* data)
        {
            return GetLocalConstantBooleanvEXT(id, value, data);
        }
        
        public static unsafe void GetLocalConstantIntegervEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLint* data)
        {
            return GetLocalConstantIntegervEXT(id, value, data);
        }
        
        public static unsafe void GetLocalConstantFloatvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLfloat* data)
        {
            return GetLocalConstantFloatvEXT(id, value, data);
        }
        
        public static void VertexStream1sATI(GL.Enums.ATI_vertex_streams stream, GLshort x)
        {
            VertexStream1sATI(stream, x);
        }
        
        public static unsafe void VertexStream1svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords)
        {
            return VertexStream1svATI(stream, coords);
        }
        
        public static void VertexStream1iATI(GL.Enums.ATI_vertex_streams stream, GLint x)
        {
            VertexStream1iATI(stream, x);
        }
        
        public static unsafe void VertexStream1ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords)
        {
            return VertexStream1ivATI(stream, coords);
        }
        
        public static void VertexStream1fATI(GL.Enums.ATI_vertex_streams stream, GLfloat x)
        {
            VertexStream1fATI(stream, x);
        }
        
        public static unsafe void VertexStream1fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords)
        {
            return VertexStream1fvATI(stream, coords);
        }
        
        public static void VertexStream1dATI(GL.Enums.ATI_vertex_streams stream, GLdouble x)
        {
            VertexStream1dATI(stream, x);
        }
        
        public static unsafe void VertexStream1dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords)
        {
            return VertexStream1dvATI(stream, coords);
        }
        
        public static void VertexStream2sATI(GL.Enums.ATI_vertex_streams stream, GLshort x, GLshort y)
        {
            VertexStream2sATI(stream, x, y);
        }
        
        public static unsafe void VertexStream2svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords)
        {
            return VertexStream2svATI(stream, coords);
        }
        
        public static void VertexStream2iATI(GL.Enums.ATI_vertex_streams stream, GLint x, GLint y)
        {
            VertexStream2iATI(stream, x, y);
        }
        
        public static unsafe void VertexStream2ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords)
        {
            return VertexStream2ivATI(stream, coords);
        }
        
        public static void VertexStream2fATI(GL.Enums.ATI_vertex_streams stream, GLfloat x, GLfloat y)
        {
            VertexStream2fATI(stream, x, y);
        }
        
        public static unsafe void VertexStream2fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords)
        {
            return VertexStream2fvATI(stream, coords);
        }
        
        public static void VertexStream2dATI(GL.Enums.ATI_vertex_streams stream, GLdouble x, GLdouble y)
        {
            VertexStream2dATI(stream, x, y);
        }
        
        public static unsafe void VertexStream2dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords)
        {
            return VertexStream2dvATI(stream, coords);
        }
        
        public static void VertexStream3sATI(GL.Enums.ATI_vertex_streams stream, GLshort x, GLshort y, GLshort z)
        {
            VertexStream3sATI(stream, x, y, z);
        }
        
        public static unsafe void VertexStream3svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords)
        {
            return VertexStream3svATI(stream, coords);
        }
        
        public static void VertexStream3iATI(GL.Enums.ATI_vertex_streams stream, GLint x, GLint y, GLint z)
        {
            VertexStream3iATI(stream, x, y, z);
        }
        
        public static unsafe void VertexStream3ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords)
        {
            return VertexStream3ivATI(stream, coords);
        }
        
        public static void VertexStream3fATI(GL.Enums.ATI_vertex_streams stream, GLfloat x, GLfloat y, GLfloat z)
        {
            VertexStream3fATI(stream, x, y, z);
        }
        
        public static unsafe void VertexStream3fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords)
        {
            return VertexStream3fvATI(stream, coords);
        }
        
        public static void VertexStream3dATI(GL.Enums.ATI_vertex_streams stream, GLdouble x, GLdouble y, GLdouble z)
        {
            VertexStream3dATI(stream, x, y, z);
        }
        
        public static unsafe void VertexStream3dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords)
        {
            return VertexStream3dvATI(stream, coords);
        }
        
        public static void VertexStream4sATI(GL.Enums.ATI_vertex_streams stream, GLshort x, GLshort y, GLshort z, GLshort w)
        {
            VertexStream4sATI(stream, x, y, z, w);
        }
        
        public static unsafe void VertexStream4svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords)
        {
            return VertexStream4svATI(stream, coords);
        }
        
        public static void VertexStream4iATI(GL.Enums.ATI_vertex_streams stream, GLint x, GLint y, GLint z, GLint w)
        {
            VertexStream4iATI(stream, x, y, z, w);
        }
        
        public static unsafe void VertexStream4ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords)
        {
            return VertexStream4ivATI(stream, coords);
        }
        
        public static void VertexStream4fATI(GL.Enums.ATI_vertex_streams stream, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            VertexStream4fATI(stream, x, y, z, w);
        }
        
        public static unsafe void VertexStream4fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords)
        {
            return VertexStream4fvATI(stream, coords);
        }
        
        public static void VertexStream4dATI(GL.Enums.ATI_vertex_streams stream, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            VertexStream4dATI(stream, x, y, z, w);
        }
        
        public static unsafe void VertexStream4dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords)
        {
            return VertexStream4dvATI(stream, coords);
        }
        
        public static void NormalStream3bATI(GL.Enums.ATI_vertex_streams stream, GLbyte nx, GLbyte ny, GLbyte nz)
        {
            NormalStream3bATI(stream, nx, ny, nz);
        }
        
        public static unsafe void NormalStream3bvATI(GL.Enums.ATI_vertex_streams stream, GLbyte* coords)
        {
            return NormalStream3bvATI(stream, coords);
        }
        
        public static void NormalStream3sATI(GL.Enums.ATI_vertex_streams stream, GLshort nx, GLshort ny, GLshort nz)
        {
            NormalStream3sATI(stream, nx, ny, nz);
        }
        
        public static unsafe void NormalStream3svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords)
        {
            return NormalStream3svATI(stream, coords);
        }
        
        public static void NormalStream3iATI(GL.Enums.ATI_vertex_streams stream, GLint nx, GLint ny, GLint nz)
        {
            NormalStream3iATI(stream, nx, ny, nz);
        }
        
        public static unsafe void NormalStream3ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords)
        {
            return NormalStream3ivATI(stream, coords);
        }
        
        public static void NormalStream3fATI(GL.Enums.ATI_vertex_streams stream, GLfloat nx, GLfloat ny, GLfloat nz)
        {
            NormalStream3fATI(stream, nx, ny, nz);
        }
        
        public static unsafe void NormalStream3fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords)
        {
            return NormalStream3fvATI(stream, coords);
        }
        
        public static void NormalStream3dATI(GL.Enums.ATI_vertex_streams stream, GLdouble nx, GLdouble ny, GLdouble nz)
        {
            NormalStream3dATI(stream, nx, ny, nz);
        }
        
        public static unsafe void NormalStream3dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords)
        {
            return NormalStream3dvATI(stream, coords);
        }
        
        public static void ClientActiveVertexStreamATI(GL.Enums.ATI_vertex_streams stream)
        {
            ClientActiveVertexStreamATI(stream);
        }
        
        public static void VertexBlendEnviATI(GL.Enums.ATI_vertex_streams pname, GLint param)
        {
            VertexBlendEnviATI(pname, param);
        }
        
        public static void VertexBlendEnvfATI(GL.Enums.ATI_vertex_streams pname, GLfloat param)
        {
            VertexBlendEnvfATI(pname, param);
        }
        
        public static unsafe void ElementPointerATI(GL.Enums.ATI_element_array type, void* pointer)
        {
            return ElementPointerATI(type, pointer);
        }
        
        public static void DrawElementArrayATI(GL.Enums.BeginMode mode, GLsizei count)
        {
            DrawElementArrayATI(mode, count);
        }
        
        public static void DrawRangeElementArrayATI(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count)
        {
            DrawRangeElementArrayATI(mode, start, end, count);
        }
        
        public static void DrawMeshArraysSUN(GL.Enums.BeginMode mode, GLint first, GLsizei count, GLsizei width)
        {
            DrawMeshArraysSUN(mode, first, count, width);
        }
        
        public static unsafe void GenOcclusionQueriesNV(GLsizei n, GLuint* ids)
        {
            return GenOcclusionQueriesNV(n, ids);
        }
        
        public static unsafe void DeleteOcclusionQueriesNV(GLsizei n, GLuint* ids)
        {
            return DeleteOcclusionQueriesNV(n, ids);
        }
        
        public static GLboolean IsOcclusionQueryNV(GLuint id)
        {
            return IsOcclusionQueryNV(id);
        }
        
        public static void BeginOcclusionQueryNV(GLuint id)
        {
            BeginOcclusionQueryNV(id);
        }
        
        public static void EndOcclusionQueryNV()
        {
            EndOcclusionQueryNV();
        }
        
        public static unsafe void GetOcclusionQueryivNV(GLuint id, GL.Enums.NV_occlusion_query pname, GLint* @params)
        {
            return GetOcclusionQueryivNV(id, pname, @params);
        }
        
        public static unsafe void GetOcclusionQueryuivNV(GLuint id, GL.Enums.NV_occlusion_query pname, GLuint* @params)
        {
            return GetOcclusionQueryuivNV(id, pname, @params);
        }
        
        public static void PointParameteriNV(GL.Enums.NV_point_sprite pname, GLint param)
        {
            PointParameteriNV(pname, param);
        }
        
        public static unsafe void PointParameterivNV(GL.Enums.NV_point_sprite pname, GLint* @params)
        {
            return PointParameterivNV(pname, @params);
        }
        
        public static void ActiveStencilFaceEXT(GL.Enums.EXT_stencil_two_side face)
        {
            ActiveStencilFaceEXT(face);
        }
        
        public static unsafe void ElementPointerAPPLE(GL.Enums.APPLE_element_array type, void* pointer)
        {
            return ElementPointerAPPLE(type, pointer);
        }
        
        public static void DrawElementArrayAPPLE(GL.Enums.BeginMode mode, GLint first, GLsizei count)
        {
            DrawElementArrayAPPLE(mode, first, count);
        }
        
        public static void DrawRangeElementArrayAPPLE(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLint first, GLsizei count)
        {
            DrawRangeElementArrayAPPLE(mode, start, end, first, count);
        }
        
        public static unsafe void MultiDrawElementArrayAPPLE(GL.Enums.BeginMode mode, GLint* first, GLsizei* count, GLsizei primcount)
        {
            return MultiDrawElementArrayAPPLE(mode, first, count, primcount);
        }
        
        public static unsafe void MultiDrawRangeElementArrayAPPLE(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLint* first, GLsizei* count, GLsizei primcount)
        {
            return MultiDrawRangeElementArrayAPPLE(mode, start, end, first, count, primcount);
        }
        
        public static unsafe void GenFencesAPPLE(GLsizei n, GLuint* fences)
        {
            return GenFencesAPPLE(n, fences);
        }
        
        public static unsafe void DeleteFencesAPPLE(GLsizei n, GLuint* fences)
        {
            return DeleteFencesAPPLE(n, fences);
        }
        
        public static void SetFenceAPPLE(GLuint fence)
        {
            SetFenceAPPLE(fence);
        }
        
        public static GLboolean IsFenceAPPLE(GLuint fence)
        {
            return IsFenceAPPLE(fence);
        }
        
        public static GLboolean TestFenceAPPLE(GLuint fence)
        {
            return TestFenceAPPLE(fence);
        }
        
        public static void FinishFenceAPPLE(GLuint fence)
        {
            FinishFenceAPPLE(fence);
        }
        
        public static GLboolean TestObjectAPPLE(GL.Enums.APPLE_fence @object, GLuint name)
        {
            return TestObjectAPPLE(@object, name);
        }
        
        public static void FinishObjectAPPLE(GL.Enums.APPLE_fence @object, GLint name)
        {
            FinishObjectAPPLE(@object, name);
        }
        
        public static void BindVertexArrayAPPLE(GLuint array)
        {
            BindVertexArrayAPPLE(array);
        }
        
        public static unsafe void DeleteVertexArraysAPPLE(GLsizei n, GLuint* arrays)
        {
            return DeleteVertexArraysAPPLE(n, arrays);
        }
        
        public static unsafe void GenVertexArraysAPPLE(GLsizei n, GLuint* arrays)
        {
            return GenVertexArraysAPPLE(n, arrays);
        }
        
        public static GLboolean IsVertexArrayAPPLE(GLuint array)
        {
            return IsVertexArrayAPPLE(array);
        }
        
        public static unsafe void VertexArrayRangeAPPLE(GLsizei length, void* pointer)
        {
            return VertexArrayRangeAPPLE(length, pointer);
        }
        
        public static unsafe void FlushVertexArrayRangeAPPLE(GLsizei length, void* pointer)
        {
            return FlushVertexArrayRangeAPPLE(length, pointer);
        }
        
        public static void VertexArrayParameteriAPPLE(GL.Enums.APPLE_vertex_array_range pname, GLint param)
        {
            VertexArrayParameteriAPPLE(pname, param);
        }
        
        public static unsafe void DrawBuffersATI(GLsizei n, GL.Enums.ATI_draw_buffers* bufs)
        {
            return DrawBuffersATI(n, bufs);
        }
        
        public static unsafe void ProgramNamedParameter4fNV(GLuint id, GLsizei len, GLubyte* name, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            return ProgramNamedParameter4fNV(id, len, name, x, y, z, w);
        }
        
        public static unsafe void ProgramNamedParameter4dNV(GLuint id, GLsizei len, GLubyte* name, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            return ProgramNamedParameter4dNV(id, len, name, x, y, z, w);
        }
        
        public static unsafe void ProgramNamedParameter4fvNV(GLuint id, GLsizei len, GLubyte* name, GLfloat* v)
        {
            return ProgramNamedParameter4fvNV(id, len, name, v);
        }
        
        public static unsafe void ProgramNamedParameter4dvNV(GLuint id, GLsizei len, GLubyte* name, GLdouble* v)
        {
            return ProgramNamedParameter4dvNV(id, len, name, v);
        }
        
        public static unsafe void GetProgramNamedParameterfvNV(GLuint id, GLsizei len, GLubyte* name, GLfloat* @params)
        {
            return GetProgramNamedParameterfvNV(id, len, name, @params);
        }
        
        public static unsafe void GetProgramNamedParameterdvNV(GLuint id, GLsizei len, GLubyte* name, GLdouble* @params)
        {
            return GetProgramNamedParameterdvNV(id, len, name, @params);
        }
        
        public static void Vertex2hNV(GLhalfNV x, GLhalfNV y)
        {
            Vertex2hNV(x, y);
        }
        
        public static unsafe void Vertex2hvNV(GLhalfNV* v)
        {
            return Vertex2hvNV(v);
        }
        
        public static unsafe void Vertex2hvNV(GLhalfNV[] v)
        {
            fixed (GLhalfNV v_ptr = v)
            {
                Vertex2hvNV(v_ptr);
            }
        }
        
        public static unsafe void Vertex2hvNV(ref GLhalfNV v)
        {
            fixed (GLhalfNV v_ptr = &v)
            {
                Vertex2hvNV(v_ptr);
            }
        }
        
        public static void Vertex3hNV(GLhalfNV x, GLhalfNV y, GLhalfNV z)
        {
            Vertex3hNV(x, y, z);
        }
        
        public static unsafe void Vertex3hvNV(GLhalfNV* v)
        {
            return Vertex3hvNV(v);
        }
        
        public static unsafe void Vertex3hvNV(GLhalfNV[] v)
        {
            fixed (GLhalfNV v_ptr = v)
            {
                Vertex3hvNV(v_ptr);
            }
        }
        
        public static unsafe void Vertex3hvNV(ref GLhalfNV v)
        {
            fixed (GLhalfNV v_ptr = &v)
            {
                Vertex3hvNV(v_ptr);
            }
        }
        
        public static void Vertex4hNV(GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w)
        {
            Vertex4hNV(x, y, z, w);
        }
        
        public static unsafe void Vertex4hvNV(GLhalfNV* v)
        {
            return Vertex4hvNV(v);
        }
        
        public static unsafe void Vertex4hvNV(GLhalfNV[] v)
        {
            fixed (GLhalfNV v_ptr = v)
            {
                Vertex4hvNV(v_ptr);
            }
        }
        
        public static unsafe void Vertex4hvNV(ref GLhalfNV v)
        {
            fixed (GLhalfNV v_ptr = &v)
            {
                Vertex4hvNV(v_ptr);
            }
        }
        
        public static void Normal3hNV(GLhalfNV nx, GLhalfNV ny, GLhalfNV nz)
        {
            Normal3hNV(nx, ny, nz);
        }
        
        public static unsafe void Normal3hvNV(GLhalfNV* v)
        {
            return Normal3hvNV(v);
        }
        
        public static unsafe void Normal3hvNV(GLhalfNV[] v)
        {
            fixed (GLhalfNV v_ptr = v)
            {
                Normal3hvNV(v_ptr);
            }
        }
        
        public static unsafe void Normal3hvNV(ref GLhalfNV v)
        {
            fixed (GLhalfNV v_ptr = &v)
            {
                Normal3hvNV(v_ptr);
            }
        }
        
        public static void Color3hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue)
        {
            Color3hNV(red, green, blue);
        }
        
        public static unsafe void Color3hvNV(GLhalfNV* v)
        {
            return Color3hvNV(v);
        }
        
        public static unsafe void Color3hvNV(GLhalfNV[] v)
        {
            fixed (GLhalfNV v_ptr = v)
            {
                Color3hvNV(v_ptr);
            }
        }
        
        public static unsafe void Color3hvNV(ref GLhalfNV v)
        {
            fixed (GLhalfNV v_ptr = &v)
            {
                Color3hvNV(v_ptr);
            }
        }
        
        public static void Color4hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue, GLhalfNV alpha)
        {
            Color4hNV(red, green, blue, alpha);
        }
        
        public static unsafe void Color4hvNV(GLhalfNV* v)
        {
            return Color4hvNV(v);
        }
        
        public static unsafe void Color4hvNV(GLhalfNV[] v)
        {
            fixed (GLhalfNV v_ptr = v)
            {
                Color4hvNV(v_ptr);
            }
        }
        
        public static unsafe void Color4hvNV(ref GLhalfNV v)
        {
            fixed (GLhalfNV v_ptr = &v)
            {
                Color4hvNV(v_ptr);
            }
        }
        
        public static void TexCoord1hNV(GLhalfNV s)
        {
            TexCoord1hNV(s);
        }
        
        public static unsafe void TexCoord1hvNV(GLhalfNV* v)
        {
            return TexCoord1hvNV(v);
        }
        
        public static unsafe void TexCoord1hvNV(GLhalfNV[] v)
        {
            fixed (GLhalfNV v_ptr = v)
            {
                TexCoord1hvNV(v_ptr);
            }
        }
        
        public static unsafe void TexCoord1hvNV(ref GLhalfNV v)
        {
            fixed (GLhalfNV v_ptr = &v)
            {
                TexCoord1hvNV(v_ptr);
            }
        }
        
        public static void TexCoord2hNV(GLhalfNV s, GLhalfNV t)
        {
            TexCoord2hNV(s, t);
        }
        
        public static unsafe void TexCoord2hvNV(GLhalfNV* v)
        {
            return TexCoord2hvNV(v);
        }
        
        public static unsafe void TexCoord2hvNV(GLhalfNV[] v)
        {
            fixed (GLhalfNV v_ptr = v)
            {
                TexCoord2hvNV(v_ptr);
            }
        }
        
        public static unsafe void TexCoord2hvNV(ref GLhalfNV v)
        {
            fixed (GLhalfNV v_ptr = &v)
            {
                TexCoord2hvNV(v_ptr);
            }
        }
        
        public static void TexCoord3hNV(GLhalfNV s, GLhalfNV t, GLhalfNV r)
        {
            TexCoord3hNV(s, t, r);
        }
        
        public static unsafe void TexCoord3hvNV(GLhalfNV* v)
        {
            return TexCoord3hvNV(v);
        }
        
        public static unsafe void TexCoord3hvNV(GLhalfNV[] v)
        {
            fixed (GLhalfNV v_ptr = v)
            {
                TexCoord3hvNV(v_ptr);
            }
        }
        
        public static unsafe void TexCoord3hvNV(ref GLhalfNV v)
        {
            fixed (GLhalfNV v_ptr = &v)
            {
                TexCoord3hvNV(v_ptr);
            }
        }
        
        public static void TexCoord4hNV(GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q)
        {
            TexCoord4hNV(s, t, r, q);
        }
        
        public static unsafe void TexCoord4hvNV(GLhalfNV* v)
        {
            return TexCoord4hvNV(v);
        }
        
        public static unsafe void TexCoord4hvNV(GLhalfNV[] v)
        {
            fixed (GLhalfNV v_ptr = v)
            {
                TexCoord4hvNV(v_ptr);
            }
        }
        
        public static unsafe void TexCoord4hvNV(ref GLhalfNV v)
        {
            fixed (GLhalfNV v_ptr = &v)
            {
                TexCoord4hvNV(v_ptr);
            }
        }
        
        public static void MultiTexCoord1hNV(GL.Enums.NV_half_float target, GLhalfNV s)
        {
            MultiTexCoord1hNV(target, s);
        }
        
        public static unsafe void MultiTexCoord1hvNV(GL.Enums.NV_half_float target, GLhalfNV* v)
        {
            return MultiTexCoord1hvNV(target, v);
        }
        
        public static void MultiTexCoord2hNV(GL.Enums.NV_half_float target, GLhalfNV s, GLhalfNV t)
        {
            MultiTexCoord2hNV(target, s, t);
        }
        
        public static unsafe void MultiTexCoord2hvNV(GL.Enums.NV_half_float target, GLhalfNV* v)
        {
            return MultiTexCoord2hvNV(target, v);
        }
        
        public static void MultiTexCoord3hNV(GL.Enums.NV_half_float target, GLhalfNV s, GLhalfNV t, GLhalfNV r)
        {
            MultiTexCoord3hNV(target, s, t, r);
        }
        
        public static unsafe void MultiTexCoord3hvNV(GL.Enums.NV_half_float target, GLhalfNV* v)
        {
            return MultiTexCoord3hvNV(target, v);
        }
        
        public static void MultiTexCoord4hNV(GL.Enums.NV_half_float target, GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q)
        {
            MultiTexCoord4hNV(target, s, t, r, q);
        }
        
        public static unsafe void MultiTexCoord4hvNV(GL.Enums.NV_half_float target, GLhalfNV* v)
        {
            return MultiTexCoord4hvNV(target, v);
        }
        
        public static void FogCoordhNV(GLhalfNV fog)
        {
            FogCoordhNV(fog);
        }
        
        public static unsafe void FogCoordhvNV(GLhalfNV* fog)
        {
            return FogCoordhvNV(fog);
        }
        
        public static unsafe void FogCoordhvNV(GLhalfNV[] fog)
        {
            fixed (GLhalfNV fog_ptr = fog)
            {
                FogCoordhvNV(fog_ptr);
            }
        }
        
        public static unsafe void FogCoordhvNV(ref GLhalfNV fog)
        {
            fixed (GLhalfNV fog_ptr = &fog)
            {
                FogCoordhvNV(fog_ptr);
            }
        }
        
        public static void SecondaryColor3hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue)
        {
            SecondaryColor3hNV(red, green, blue);
        }
        
        public static unsafe void SecondaryColor3hvNV(GLhalfNV* v)
        {
            return SecondaryColor3hvNV(v);
        }
        
        public static unsafe void SecondaryColor3hvNV(GLhalfNV[] v)
        {
            fixed (GLhalfNV v_ptr = v)
            {
                SecondaryColor3hvNV(v_ptr);
            }
        }
        
        public static unsafe void SecondaryColor3hvNV(ref GLhalfNV v)
        {
            fixed (GLhalfNV v_ptr = &v)
            {
                SecondaryColor3hvNV(v_ptr);
            }
        }
        
        public static void VertexWeighthNV(GLhalfNV weight)
        {
            VertexWeighthNV(weight);
        }
        
        public static unsafe void VertexWeighthvNV(GLhalfNV* weight)
        {
            return VertexWeighthvNV(weight);
        }
        
        public static unsafe void VertexWeighthvNV(GLhalfNV[] weight)
        {
            fixed (GLhalfNV weight_ptr = weight)
            {
                VertexWeighthvNV(weight_ptr);
            }
        }
        
        public static unsafe void VertexWeighthvNV(ref GLhalfNV weight)
        {
            fixed (GLhalfNV weight_ptr = &weight)
            {
                VertexWeighthvNV(weight_ptr);
            }
        }
        
        public static void VertexAttrib1hNV(GLuint index, GLhalfNV x)
        {
            VertexAttrib1hNV(index, x);
        }
        
        public static unsafe void VertexAttrib1hvNV(GLuint index, GLhalfNV* v)
        {
            return VertexAttrib1hvNV(index, v);
        }
        
        public static void VertexAttrib2hNV(GLuint index, GLhalfNV x, GLhalfNV y)
        {
            VertexAttrib2hNV(index, x, y);
        }
        
        public static unsafe void VertexAttrib2hvNV(GLuint index, GLhalfNV* v)
        {
            return VertexAttrib2hvNV(index, v);
        }
        
        public static void VertexAttrib3hNV(GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z)
        {
            VertexAttrib3hNV(index, x, y, z);
        }
        
        public static unsafe void VertexAttrib3hvNV(GLuint index, GLhalfNV* v)
        {
            return VertexAttrib3hvNV(index, v);
        }
        
        public static void VertexAttrib4hNV(GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w)
        {
            VertexAttrib4hNV(index, x, y, z, w);
        }
        
        public static unsafe void VertexAttrib4hvNV(GLuint index, GLhalfNV* v)
        {
            return VertexAttrib4hvNV(index, v);
        }
        
        public static unsafe void VertexAttribs1hvNV(GLuint index, GLsizei n, GLhalfNV* v)
        {
            return VertexAttribs1hvNV(index, n, v);
        }
        
        public static unsafe void VertexAttribs2hvNV(GLuint index, GLsizei n, GLhalfNV* v)
        {
            return VertexAttribs2hvNV(index, n, v);
        }
        
        public static unsafe void VertexAttribs3hvNV(GLuint index, GLsizei n, GLhalfNV* v)
        {
            return VertexAttribs3hvNV(index, n, v);
        }
        
        public static unsafe void VertexAttribs4hvNV(GLuint index, GLsizei n, GLhalfNV* v)
        {
            return VertexAttribs4hvNV(index, n, v);
        }
        
        public static unsafe void PixelDataRangeNV(GL.Enums.NV_pixel_data_range target, GLsizei length, void* pointer)
        {
            return PixelDataRangeNV(target, length, pointer);
        }
        
        public static void FlushPixelDataRangeNV(GL.Enums.NV_pixel_data_range target)
        {
            FlushPixelDataRangeNV(target);
        }
        
        public static void PrimitiveRestartNV()
        {
            PrimitiveRestartNV();
        }
        
        public static void PrimitiveRestartIndexNV(GLuint index)
        {
            PrimitiveRestartIndexNV(index);
        }
        
        public static void MapObjectBufferATI(GLuint buffer)
        {
            MapObjectBufferATI(buffer);
        }
        
        public static void UnmapObjectBufferATI(GLuint buffer)
        {
            UnmapObjectBufferATI(buffer);
        }
        
        public static void StencilOpSeparateATI(GL.Enums.ATI_separate_stencil face, GL.Enums.StencilOp sfail, GL.Enums.StencilOp dpfail, GL.Enums.StencilOp dppass)
        {
            StencilOpSeparateATI(face, sfail, dpfail, dppass);
        }
        
        public static void StencilFuncSeparateATI(GL.Enums.StencilFunction frontfunc, GL.Enums.StencilFunction backfunc, GLint @ref, GLuint mask)
        {
            StencilFuncSeparateATI(frontfunc, backfunc, @ref, mask);
        }
        
        public static unsafe void GetVertexAttribArrayObjectfvATI(GLuint index, GL.Enums.ATI_vertex_attrib_array_object pname, GLfloat* @params)
        {
            return GetVertexAttribArrayObjectfvATI(index, pname, @params);
        }
        
        public static unsafe void GetVertexAttribArrayObjectivATI(GLuint index, GL.Enums.ATI_vertex_attrib_array_object pname, GLint* @params)
        {
            return GetVertexAttribArrayObjectivATI(index, pname, @params);
        }
        
        public static void DepthBoundsEXT(GLclampd zmin, GLclampd zmax)
        {
            DepthBoundsEXT(zmin, zmax);
        }
        
        public static void BlendEquationSeparateEXT(GL.Enums.BlendEquationModeEXT modeRGB, GL.Enums.BlendEquationModeEXT modeAlpha)
        {
            BlendEquationSeparateEXT(modeRGB, modeAlpha);
        }
        
        public static GLboolean IsRenderbufferEXT(GLuint renderbuffer)
        {
            return IsRenderbufferEXT(renderbuffer);
        }
        
        public static void BindRenderbufferEXT(GL.Enums.EXT_framebuffer_object target, GLuint renderbuffer)
        {
            BindRenderbufferEXT(target, renderbuffer);
        }
        
        public static unsafe void DeleteRenderbuffersEXT(GLsizei n, GLuint* renderbuffers)
        {
            return DeleteRenderbuffersEXT(n, renderbuffers);
        }
        
        public static unsafe void GenRenderbuffersEXT(GLsizei n, GLuint* renderbuffers)
        {
            return GenRenderbuffersEXT(n, renderbuffers);
        }
        
        public static void RenderbufferStorageEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.GLenum internalformat, GLsizei width, GLsizei height)
        {
            RenderbufferStorageEXT(target, internalformat, width, height);
        }
        
        public static unsafe void GetRenderbufferParameterivEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.GLenum pname, GLint* @params)
        {
            return GetRenderbufferParameterivEXT(target, pname, @params);
        }
        
        public static GLboolean IsFramebufferEXT(GLuint framebuffer)
        {
            return IsFramebufferEXT(framebuffer);
        }
        
        public static void BindFramebufferEXT(GL.Enums.EXT_framebuffer_object target, GLuint framebuffer)
        {
            BindFramebufferEXT(target, framebuffer);
        }
        
        public static unsafe void DeleteFramebuffersEXT(GLsizei n, GLuint* framebuffers)
        {
            return DeleteFramebuffersEXT(n, framebuffers);
        }
        
        public static unsafe void GenFramebuffersEXT(GLsizei n, GLuint* framebuffers)
        {
            return GenFramebuffersEXT(n, framebuffers);
        }
        
        public static GL.Enums.GLenum CheckFramebufferStatusEXT(GL.Enums.EXT_framebuffer_object target)
        {
            return CheckFramebufferStatusEXT(target);
        }
        
        public static void FramebufferTexture1DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.GLenum textarget, GLuint texture, GLint level)
        {
            FramebufferTexture1DEXT(target, attachment, textarget, texture, level);
        }
        
        public static void FramebufferTexture2DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.GLenum textarget, GLuint texture, GLint level)
        {
            FramebufferTexture2DEXT(target, attachment, textarget, texture, level);
        }
        
        public static void FramebufferTexture3DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.GLenum textarget, GLuint texture, GLint level, GLint zoffset)
        {
            FramebufferTexture3DEXT(target, attachment, textarget, texture, level, zoffset);
        }
        
        public static void FramebufferRenderbufferEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.EXT_framebuffer_object renderbuffertarget, GLuint renderbuffer)
        {
            FramebufferRenderbufferEXT(target, attachment, renderbuffertarget, renderbuffer);
        }
        
        public static unsafe void GetFramebufferAttachmentParameterivEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.GLenum pname, GLint* @params)
        {
            return GetFramebufferAttachmentParameterivEXT(target, attachment, pname, @params);
        }
        
        public static void GenerateMipmapEXT(GL.Enums.GLenum target)
        {
            GenerateMipmapEXT(target);
        }
        
        public static unsafe void StringMarkerGREMEDY(GLsizei len, void* @string)
        {
            return StringMarkerGREMEDY(len, @string);
        }
        
        public static void StencilClearTagEXT(GLsizei stencilTagBits, GLuint stencilClearTag)
        {
            StencilClearTagEXT(stencilTagBits, stencilClearTag);
        }
        
        public static void BlitFramebufferEXT(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GL.Enums.ClearBufferMask mask, GL.Enums.GLenum filter)
        {
            BlitFramebufferEXT(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }
        
        public static void RenderbufferStorageMultisampleEXT(GL.Enums.GLenum target, GLsizei samples, GL.Enums.GLenum internalformat, GLsizei width, GLsizei height)
        {
            RenderbufferStorageMultisampleEXT(target, samples, internalformat, width, height);
        }
        
        public static unsafe void GetQueryObjecti64vEXT(GLuint id, GL.Enums.GLenum pname, GLint64EXT* @params)
        {
            return GetQueryObjecti64vEXT(id, pname, @params);
        }
        
        public static unsafe void GetQueryObjectui64vEXT(GLuint id, GL.Enums.GLenum pname, GLuint64EXT* @params)
        {
            return GetQueryObjectui64vEXT(id, pname, @params);
        }
        
        public static unsafe void ProgramEnvParameters4fvEXT(GL.Enums.EXT_gpu_program_parameters target, GLuint index, GLsizei count, GLfloat* @params)
        {
            return ProgramEnvParameters4fvEXT(target, index, count, @params);
        }
        
        public static unsafe void ProgramLocalParameters4fvEXT(GL.Enums.EXT_gpu_program_parameters target, GLuint index, GLsizei count, GLfloat* @params)
        {
            return ProgramLocalParameters4fvEXT(target, index, count, @params);
        }
        
        public static void BufferParameteriAPPLE(GL.Enums.GLenum target, GL.Enums.GLenum pname, GLint param)
        {
            BufferParameteriAPPLE(target, pname, param);
        }
        
        public static void FlushMappedBufferRangeAPPLE(GL.Enums.GLenum target, GLintptr offset, GLsizeiptr size)
        {
            FlushMappedBufferRangeAPPLE(target, offset, size);
        }
        
        public static void ProgramLocalParameterI4iNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint x, GLint y, GLint z, GLint w)
        {
            ProgramLocalParameterI4iNV(target, index, x, y, z, w);
        }
        
        public static unsafe void ProgramLocalParameterI4ivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint* @params)
        {
            return ProgramLocalParameterI4ivNV(target, index, @params);
        }
        
        public static unsafe void ProgramLocalParametersI4ivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLsizei count, GLint* @params)
        {
            return ProgramLocalParametersI4ivNV(target, index, count, @params);
        }
        
        public static void ProgramLocalParameterI4uiNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
        {
            ProgramLocalParameterI4uiNV(target, index, x, y, z, w);
        }
        
        public static unsafe void ProgramLocalParameterI4uivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint* @params)
        {
            return ProgramLocalParameterI4uivNV(target, index, @params);
        }
        
        public static unsafe void ProgramLocalParametersI4uivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLsizei count, GLuint* @params)
        {
            return ProgramLocalParametersI4uivNV(target, index, count, @params);
        }
        
        public static void ProgramEnvParameterI4iNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint x, GLint y, GLint z, GLint w)
        {
            ProgramEnvParameterI4iNV(target, index, x, y, z, w);
        }
        
        public static unsafe void ProgramEnvParameterI4ivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint* @params)
        {
            return ProgramEnvParameterI4ivNV(target, index, @params);
        }
        
        public static unsafe void ProgramEnvParametersI4ivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLsizei count, GLint* @params)
        {
            return ProgramEnvParametersI4ivNV(target, index, count, @params);
        }
        
        public static void ProgramEnvParameterI4uiNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
        {
            ProgramEnvParameterI4uiNV(target, index, x, y, z, w);
        }
        
        public static unsafe void ProgramEnvParameterI4uivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint* @params)
        {
            return ProgramEnvParameterI4uivNV(target, index, @params);
        }
        
        public static unsafe void ProgramEnvParametersI4uivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLsizei count, GLuint* @params)
        {
            return ProgramEnvParametersI4uivNV(target, index, count, @params);
        }
        
        public static unsafe void GetProgramLocalParameterIivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint* @params)
        {
            return GetProgramLocalParameterIivNV(target, index, @params);
        }
        
        public static unsafe void GetProgramLocalParameterIuivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint* @params)
        {
            return GetProgramLocalParameterIuivNV(target, index, @params);
        }
        
        public static unsafe void GetProgramEnvParameterIivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint* @params)
        {
            return GetProgramEnvParameterIivNV(target, index, @params);
        }
        
        public static unsafe void GetProgramEnvParameterIuivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint* @params)
        {
            return GetProgramEnvParameterIuivNV(target, index, @params);
        }
        
        public static void ProgramVertexLimitNV(GL.Enums.NV_geometry_program4 target, GLint limit)
        {
            ProgramVertexLimitNV(target, limit);
        }
        
        public static void FramebufferTextureEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, GLuint texture, GLint level)
        {
            FramebufferTextureEXT(target, attachment, texture, level);
        }
        
        public static void FramebufferTextureLayerEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, GLuint texture, GLint level, GLint layer)
        {
            FramebufferTextureLayerEXT(target, attachment, texture, level, layer);
        }
        
        public static void FramebufferTextureFaceEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, GLuint texture, GLint level, GL.Enums.TextureTarget face)
        {
            FramebufferTextureFaceEXT(target, attachment, texture, level, face);
        }
        
        public static void ProgramParameteriEXT(GLuint program, GL.Enums.EXT_geometry_shader4 pname, GLint value)
        {
            ProgramParameteriEXT(program, pname, value);
        }
        
        public static void VertexAttribI1iEXT(GLuint index, GLint x)
        {
            VertexAttribI1iEXT(index, x);
        }
        
        public static void VertexAttribI2iEXT(GLuint index, GLint x, GLint y)
        {
            VertexAttribI2iEXT(index, x, y);
        }
        
        public static void VertexAttribI3iEXT(GLuint index, GLint x, GLint y, GLint z)
        {
            VertexAttribI3iEXT(index, x, y, z);
        }
        
        public static void VertexAttribI4iEXT(GLuint index, GLint x, GLint y, GLint z, GLint w)
        {
            VertexAttribI4iEXT(index, x, y, z, w);
        }
        
        public static void VertexAttribI1uiEXT(GLuint index, GLuint x)
        {
            VertexAttribI1uiEXT(index, x);
        }
        
        public static void VertexAttribI2uiEXT(GLuint index, GLuint x, GLuint y)
        {
            VertexAttribI2uiEXT(index, x, y);
        }
        
        public static void VertexAttribI3uiEXT(GLuint index, GLuint x, GLuint y, GLuint z)
        {
            VertexAttribI3uiEXT(index, x, y, z);
        }
        
        public static void VertexAttribI4uiEXT(GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
        {
            VertexAttribI4uiEXT(index, x, y, z, w);
        }
        
        public static unsafe void VertexAttribI1ivEXT(GLuint index, GLint* v)
        {
            return VertexAttribI1ivEXT(index, v);
        }
        
        public static unsafe void VertexAttribI2ivEXT(GLuint index, GLint* v)
        {
            return VertexAttribI2ivEXT(index, v);
        }
        
        public static unsafe void VertexAttribI3ivEXT(GLuint index, GLint* v)
        {
            return VertexAttribI3ivEXT(index, v);
        }
        
        public static unsafe void VertexAttribI4ivEXT(GLuint index, GLint* v)
        {
            return VertexAttribI4ivEXT(index, v);
        }
        
        public static unsafe void VertexAttribI1uivEXT(GLuint index, GLuint* v)
        {
            return VertexAttribI1uivEXT(index, v);
        }
        
        public static unsafe void VertexAttribI2uivEXT(GLuint index, GLuint* v)
        {
            return VertexAttribI2uivEXT(index, v);
        }
        
        public static unsafe void VertexAttribI3uivEXT(GLuint index, GLuint* v)
        {
            return VertexAttribI3uivEXT(index, v);
        }
        
        public static unsafe void VertexAttribI4uivEXT(GLuint index, GLuint* v)
        {
            return VertexAttribI4uivEXT(index, v);
        }
        
        public static unsafe void VertexAttribI4bvEXT(GLuint index, GLbyte* v)
        {
            return VertexAttribI4bvEXT(index, v);
        }
        
        public static unsafe void VertexAttribI4svEXT(GLuint index, GLshort* v)
        {
            return VertexAttribI4svEXT(index, v);
        }
        
        public static unsafe void VertexAttribI4ubvEXT(GLuint index, GLubyte* v)
        {
            return VertexAttribI4ubvEXT(index, v);
        }
        
        public static unsafe void VertexAttribI4usvEXT(GLuint index, GLushort* v)
        {
            return VertexAttribI4usvEXT(index, v);
        }
        
        public static unsafe void VertexAttribIPointerEXT(GLuint index, GLint size, GL.Enums.NV_vertex_program4 type, GLsizei stride, void* pointer)
        {
            return VertexAttribIPointerEXT(index, size, type, stride, pointer);
        }
        
        public static unsafe void GetVertexAttribIivEXT(GLuint index, GL.Enums.NV_vertex_program4 pname, GLint* @params)
        {
            return GetVertexAttribIivEXT(index, pname, @params);
        }
        
        public static unsafe void GetVertexAttribIuivEXT(GLuint index, GL.Enums.NV_vertex_program4 pname, GLuint* @params)
        {
            return GetVertexAttribIuivEXT(index, pname, @params);
        }
        
        public static unsafe void GetUniformuivEXT(GLuint program, GLint location, GLuint* @params)
        {
            return GetUniformuivEXT(program, location, @params);
        }
        
        public static void Uniform1uiEXT(GLint location, GLuint v0)
        {
            Uniform1uiEXT(location, v0);
        }
        
        public static void Uniform2uiEXT(GLint location, GLuint v0, GLuint v1)
        {
            Uniform2uiEXT(location, v0, v1);
        }
        
        public static void Uniform3uiEXT(GLint location, GLuint v0, GLuint v1, GLuint v2)
        {
            Uniform3uiEXT(location, v0, v1, v2);
        }
        
        public static void Uniform4uiEXT(GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)
        {
            Uniform4uiEXT(location, v0, v1, v2, v3);
        }
        
        public static unsafe void Uniform1uivEXT(GLint location, GLsizei count, GLuint* value)
        {
            return Uniform1uivEXT(location, count, value);
        }
        
        public static unsafe void Uniform2uivEXT(GLint location, GLsizei count, GLuint* value)
        {
            return Uniform2uivEXT(location, count, value);
        }
        
        public static unsafe void Uniform3uivEXT(GLint location, GLsizei count, GLuint* value)
        {
            return Uniform3uivEXT(location, count, value);
        }
        
        public static unsafe void Uniform4uivEXT(GLint location, GLsizei count, GLuint* value)
        {
            return Uniform4uivEXT(location, count, value);
        }
        
        public static void DrawArraysInstancedEXT(GL.Enums.BeginMode mode, GLint start, GLsizei count, GLsizei primcount)
        {
            DrawArraysInstancedEXT(mode, start, count, primcount);
        }
        
        public static unsafe void DrawElementsInstancedEXT(GL.Enums.BeginMode mode, GLsizei count, GL.Enums.EXT_draw_instanced type, void* indices, GLsizei primcount)
        {
            return DrawElementsInstancedEXT(mode, count, type, indices, primcount);
        }
        
        public static void TexBufferEXT(GL.Enums.TextureTarget target, GL.Enums.GLenum internalformat, GLuint buffer)
        {
            TexBufferEXT(target, internalformat, buffer);
        }
        
        public static void DepthRangedNV(GLdouble zNear, GLdouble zFar)
        {
            DepthRangedNV(zNear, zFar);
        }
        
        public static void ClearDepthdNV(GLdouble depth)
        {
            ClearDepthdNV(depth);
        }
        
        public static void DepthBoundsdNV(GLdouble zmin, GLdouble zmax)
        {
            DepthBoundsdNV(zmin, zmax);
        }
        
        public static void RenderbufferStorageMultisampleCoverageNV(GL.Enums.NV_framebuffer_multisample_coverage target, GLsizei coverageSamples, GLsizei colorSamples, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height)
        {
            RenderbufferStorageMultisampleCoverageNV(target, coverageSamples, colorSamples, internalformat, width, height);
        }
        
        public static unsafe void ProgramBufferParametersfvNV(GL.Enums.NV_parameter_buffer_object target, GLuint buffer, GLuint index, GLsizei count, GLfloat* @params)
        {
            return ProgramBufferParametersfvNV(target, buffer, index, count, @params);
        }
        
        public static unsafe void ProgramBufferParametersIivNV(GL.Enums.NV_parameter_buffer_object target, GLuint buffer, GLuint index, GLsizei count, GLint* @params)
        {
            return ProgramBufferParametersIivNV(target, buffer, index, count, @params);
        }
        
        public static unsafe void ProgramBufferParametersIuivNV(GL.Enums.NV_parameter_buffer_object target, GLuint buffer, GLuint index, GLsizei count, GLuint* @params)
        {
            return ProgramBufferParametersIuivNV(target, buffer, index, count, @params);
        }
        
        public static unsafe void GetBooleanIndexedvEXT(GL.Enums.GLenum target, GLuint index, GL.Enums.Boolean* data)
        {
            return GetBooleanIndexedvEXT(target, index, data);
        }
        
        public static unsafe void GetIntegerIndexedvEXT(GL.Enums.GLenum target, GLuint index, GLint* data)
        {
            return GetIntegerIndexedvEXT(target, index, data);
        }
        
        public static void EnableIndexedEXT(GL.Enums.GLenum target, GLuint index)
        {
            EnableIndexedEXT(target, index);
        }
        
        public static void DisableIndexedEXT(GL.Enums.GLenum target, GLuint index)
        {
            DisableIndexedEXT(target, index);
        }
        
        public static GLboolean IsEnabledIndexedEXT(GL.Enums.GLenum target, GLuint index)
        {
            return IsEnabledIndexedEXT(target, index);
        }
        
        public static void BeginTransformFeedbackNV(GL.Enums.GLenum primitiveMode)
        {
            BeginTransformFeedbackNV(primitiveMode);
        }
        
        public static void EndTransformFeedbackNV()
        {
            EndTransformFeedbackNV();
        }
        
        public static unsafe void TransformFeedbackAttribsNV(GLuint count, GLint* attribs, GL.Enums.GLenum bufferMode)
        {
            return TransformFeedbackAttribsNV(count, attribs, bufferMode);
        }
        
        public static void BindBufferRangeNV(GL.Enums.GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)
        {
            BindBufferRangeNV(target, index, buffer, offset, size);
        }
        
        public static void BindBufferOffsetNV(GL.Enums.GLenum target, GLuint index, GLuint buffer, GLintptr offset)
        {
            BindBufferOffsetNV(target, index, buffer, offset);
        }
        
        public static void BindBufferBaseNV(GL.Enums.GLenum target, GLuint index, GLuint buffer)
        {
            BindBufferBaseNV(target, index, buffer);
        }
        
        public static unsafe void TransformFeedbackVaryingsNV(GLuint program, GLsizei count, GLint* locations, GL.Enums.GLenum bufferMode)
        {
            return TransformFeedbackVaryingsNV(program, count, locations, bufferMode);
        }
        
        public static unsafe void GetActiveVaryingNV(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GL.Enums.GLenum* type, System.Text.StringBuilder name)
        {
            return GetActiveVaryingNV(program, index, bufSize, length, size, type, name);
        }
        
        public static unsafe void GetTransformFeedbackVaryingNV(GLuint program, GLuint index, GLint* location)
        {
            return GetTransformFeedbackVaryingNV(program, index, location);
        }
        
        public static void UniformBufferEXT(GLuint program, GLint location, GLuint buffer)
        {
            UniformBufferEXT(program, location, buffer);
        }
        
        public static GLint GetUniformBufferSizeEXT(GLuint program, GLint location)
        {
            return GetUniformBufferSizeEXT(program, location);
        }
        
        public static GLintptr GetUniformOffsetEXT(GLuint program, GLint location)
        {
            return GetUniformOffsetEXT(program, location);
        }
        
        public static unsafe void TexParameterIivEXT(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLint* @params)
        {
            return TexParameterIivEXT(target, pname, @params);
        }
        
        public static unsafe void TexParameterIuivEXT(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLuint* @params)
        {
            return TexParameterIuivEXT(target, pname, @params);
        }
        
        public static unsafe void GetTexParameterIivEXT(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, GLint* @params)
        {
            return GetTexParameterIivEXT(target, pname, @params);
        }
        
        public static unsafe void GetTexParameterIuivEXT(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, GLuint* @params)
        {
            return GetTexParameterIuivEXT(target, pname, @params);
        }
        
        public static void ClearColorIiEXT(GLint red, GLint green, GLint blue, GLint alpha)
        {
            ClearColorIiEXT(red, green, blue, alpha);
        }
        
        public static void ClearColorIuiEXT(GLuint red, GLuint green, GLuint blue, GLuint alpha)
        {
            ClearColorIuiEXT(red, green, blue, alpha);
        }
        
    }
}
