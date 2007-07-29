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

    internal static class Imports
    {
        static Imports() { }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void NewList(GLuint list, GL.Enums.ListMode mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EndList();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CallList(GLuint list);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CallLists(GLsizei n, GL.Enums.ListNameType type, void* lists);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DeleteLists(GLuint list, GLsizei range);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLuint GenLists(GLsizei range);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ListBase(GLuint @base);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Begin(GL.Enums.BeginMode mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Bitmap(GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, GLubyte* bitmap);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color3b(GLbyte red, GLbyte green, GLbyte blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color3bv(GLbyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color3d(GLdouble red, GLdouble green, GLdouble blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color3dv(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color3f(GLfloat red, GLfloat green, GLfloat blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color3fv(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color3i(GLint red, GLint green, GLint blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color3iv(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color3s(GLshort red, GLshort green, GLshort blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color3sv(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color3ub(GLubyte red, GLubyte green, GLubyte blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color3ubv(GLubyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color3ui(GLuint red, GLuint green, GLuint blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color3uiv(GLuint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color3us(GLushort red, GLushort green, GLushort blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color3usv(GLushort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color4b(GLbyte red, GLbyte green, GLbyte blue, GLbyte alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color4bv(GLbyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color4d(GLdouble red, GLdouble green, GLdouble blue, GLdouble alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color4dv(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color4f(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color4fv(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color4i(GLint red, GLint green, GLint blue, GLint alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color4iv(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color4s(GLshort red, GLshort green, GLshort blue, GLshort alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color4sv(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color4ub(GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color4ubv(GLubyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color4ui(GLuint red, GLuint green, GLuint blue, GLuint alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color4uiv(GLuint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color4us(GLushort red, GLushort green, GLushort blue, GLushort alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color4usv(GLushort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EdgeFlag(GL.Enums.Boolean flag);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void EdgeFlagv(GL.Enums.Boolean* flag);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void End();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Indexd(GLdouble c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Indexdv(GLdouble* c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Indexf(GLfloat c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Indexfv(GLfloat* c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Indexi(GLint c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Indexiv(GLint* c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Indexs(GLshort c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Indexsv(GLshort* c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Normal3b(GLbyte nx, GLbyte ny, GLbyte nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Normal3bv(GLbyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Normal3d(GLdouble nx, GLdouble ny, GLdouble nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Normal3dv(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Normal3f(GLfloat nx, GLfloat ny, GLfloat nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Normal3fv(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Normal3i(GLint nx, GLint ny, GLint nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Normal3iv(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Normal3s(GLshort nx, GLshort ny, GLshort nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Normal3sv(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void RasterPos2d(GLdouble x, GLdouble y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void RasterPos2dv(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void RasterPos2f(GLfloat x, GLfloat y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void RasterPos2fv(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void RasterPos2i(GLint x, GLint y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void RasterPos2iv(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void RasterPos2s(GLshort x, GLshort y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void RasterPos2sv(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void RasterPos3d(GLdouble x, GLdouble y, GLdouble z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void RasterPos3dv(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void RasterPos3f(GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void RasterPos3fv(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void RasterPos3i(GLint x, GLint y, GLint z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void RasterPos3iv(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void RasterPos3s(GLshort x, GLshort y, GLshort z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void RasterPos3sv(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void RasterPos4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void RasterPos4dv(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void RasterPos4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void RasterPos4fv(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void RasterPos4i(GLint x, GLint y, GLint z, GLint w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void RasterPos4iv(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void RasterPos4s(GLshort x, GLshort y, GLshort z, GLshort w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void RasterPos4sv(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Rectd(GLdouble x1, GLdouble y1, GLdouble x2, GLdouble y2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Rectdv(GLdouble* v1, GLdouble* v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Rectf(GLfloat x1, GLfloat y1, GLfloat x2, GLfloat y2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Rectfv(GLfloat* v1, GLfloat* v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Recti(GLint x1, GLint y1, GLint x2, GLint y2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Rectiv(GLint* v1, GLint* v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Rects(GLshort x1, GLshort y1, GLshort x2, GLshort y2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Rectsv(GLshort* v1, GLshort* v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord1d(GLdouble s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord1dv(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord1f(GLfloat s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord1fv(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord1i(GLint s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord1iv(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord1s(GLshort s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord1sv(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord2d(GLdouble s, GLdouble t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2dv(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord2f(GLfloat s, GLfloat t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2fv(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord2i(GLint s, GLint t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2iv(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord2s(GLshort s, GLshort t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2sv(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord3d(GLdouble s, GLdouble t, GLdouble r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord3dv(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord3f(GLfloat s, GLfloat t, GLfloat r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord3fv(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord3i(GLint s, GLint t, GLint r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord3iv(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord3s(GLshort s, GLshort t, GLshort r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord3sv(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord4d(GLdouble s, GLdouble t, GLdouble r, GLdouble q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord4dv(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord4f(GLfloat s, GLfloat t, GLfloat r, GLfloat q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord4fv(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord4i(GLint s, GLint t, GLint r, GLint q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord4iv(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord4s(GLshort s, GLshort t, GLshort r, GLshort q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord4sv(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Vertex2d(GLdouble x, GLdouble y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Vertex2dv(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Vertex2f(GLfloat x, GLfloat y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Vertex2fv(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Vertex2i(GLint x, GLint y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Vertex2iv(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Vertex2s(GLshort x, GLshort y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Vertex2sv(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Vertex3d(GLdouble x, GLdouble y, GLdouble z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Vertex3dv(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Vertex3f(GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Vertex3fv(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Vertex3i(GLint x, GLint y, GLint z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Vertex3iv(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Vertex3s(GLshort x, GLshort y, GLshort z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Vertex3sv(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Vertex4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Vertex4dv(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Vertex4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Vertex4fv(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Vertex4i(GLint x, GLint y, GLint z, GLint w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Vertex4iv(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Vertex4s(GLshort x, GLshort y, GLshort z, GLshort w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Vertex4sv(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ClipPlane(GL.Enums.ClipPlaneName plane, GLdouble* equation);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ColorMaterial(GL.Enums.MaterialFace face, GL.Enums.ColorMaterialParameter mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CullFace(GL.Enums.CullFaceMode mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Fogf(GL.Enums.FogParameter pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Fogfv(GL.Enums.FogParameter pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Fogi(GL.Enums.FogParameter pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Fogiv(GL.Enums.FogParameter pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FrontFace(GL.Enums.FrontFaceDirection mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Hint(GL.Enums.HintTarget target, GL.Enums.HintMode mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Lightf(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Lightfv(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Lighti(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Lightiv(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void LightModelf(GL.Enums.LightModelParameter pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void LightModelfv(GL.Enums.LightModelParameter pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void LightModeli(GL.Enums.LightModelParameter pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void LightModeliv(GL.Enums.LightModelParameter pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void LineStipple(GLint factor, GLushort pattern);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void LineWidth(GLfloat width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Materialf(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Materialfv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Materiali(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Materialiv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PointSize(GLfloat size);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PolygonMode(GL.Enums.MaterialFace face, GL.Enums.PolygonMode mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PolygonStipple(GLubyte* mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Scissor(GLint x, GLint y, GLsizei width, GLsizei height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ShadeModel(GL.Enums.ShadingModel mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexParameterf(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexParameterfv(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexParameteri(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexParameteriv(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexImage1D(GL.Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexImage2D(GL.Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexEnvf(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexEnvfv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexEnvi(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexEnviv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexGend(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLdouble param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexGendv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLdouble* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexGenf(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexGenfv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexGeni(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexGeniv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FeedbackBuffer(GLsizei size, GL.Enums.FeedbackType type, GLfloat* buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SelectBuffer(GLsizei size, GLuint* buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLint RenderMode(GL.Enums.RenderingMode mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void InitNames();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void LoadName(GLuint name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PassThrough(GLfloat token);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PopName();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PushName(GLuint name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DrawBuffer(GL.Enums.DrawBufferMode mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Clear(GL.Enums.ClearBufferMask mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ClearAccum(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ClearIndex(GLfloat c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ClearColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ClearStencil(GLint s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ClearDepth(GLclampd depth);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void StencilMask(GLuint mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ColorMask(GL.Enums.Boolean red, GL.Enums.Boolean green, GL.Enums.Boolean blue, GL.Enums.Boolean alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DepthMask(GL.Enums.Boolean flag);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void IndexMask(GLuint mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Accum(GL.Enums.AccumOp op, GLfloat value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Disable(GL.Enums.EnableCap cap);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Enable(GL.Enums.EnableCap cap);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Finish();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Flush();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PopAttrib();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PushAttrib(GL.Enums.AttribMask mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Map1d(GL.Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint stride, GLint order, GLdouble* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Map1f(GL.Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint stride, GLint order, GLfloat* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Map2d(GL.Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Map2f(GL.Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MapGrid1d(GLint un, GLdouble u1, GLdouble u2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MapGrid1f(GLint un, GLfloat u1, GLfloat u2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MapGrid2d(GLint un, GLdouble u1, GLdouble u2, GLint vn, GLdouble v1, GLdouble v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MapGrid2f(GLint un, GLfloat u1, GLfloat u2, GLint vn, GLfloat v1, GLfloat v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EvalCoord1d(GLdouble u);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void EvalCoord1dv(GLdouble* u);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EvalCoord1f(GLfloat u);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void EvalCoord1fv(GLfloat* u);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EvalCoord2d(GLdouble u, GLdouble v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void EvalCoord2dv(GLdouble* u);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EvalCoord2f(GLfloat u, GLfloat v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void EvalCoord2fv(GLfloat* u);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EvalMesh1(GL.Enums.MeshMode1 mode, GLint i1, GLint i2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EvalPoint1(GLint i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EvalMesh2(GL.Enums.MeshMode2 mode, GLint i1, GLint i2, GLint j1, GLint j2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EvalPoint2(GLint i, GLint j);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void AlphaFunc(GL.Enums.AlphaFunction func, GLclampf @ref);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BlendFunc(GL.Enums.BlendingFactorSrc sfactor, GL.Enums.BlendingFactorDest dfactor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void LogicOp(GL.Enums.LogicOp opcode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void StencilFunc(GL.Enums.StencilFunction func, GLint @ref, GLuint mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void StencilOp(GL.Enums.StencilOp fail, GL.Enums.StencilOp zfail, GL.Enums.StencilOp zpass);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DepthFunc(GL.Enums.DepthFunction func);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PixelZoom(GLfloat xfactor, GLfloat yfactor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PixelTransferf(GL.Enums.PixelTransferParameter pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PixelTransferi(GL.Enums.PixelTransferParameter pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PixelStoref(GL.Enums.PixelStoreParameter pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PixelStorei(GL.Enums.PixelStoreParameter pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PixelMapfv(GL.Enums.PixelMap map, GLint mapsize, GLfloat* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PixelMapuiv(GL.Enums.PixelMap map, GLint mapsize, GLuint* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PixelMapusv(GL.Enums.PixelMap map, GLint mapsize, GLushort* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ReadBuffer(GL.Enums.ReadBufferMode mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyPixels(GLint x, GLint y, GLsizei width, GLsizei height, GL.Enums.PixelCopyType type);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DrawPixels(GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetBooleanv(GL.Enums.GetPName pname, GL.Enums.Boolean* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetClipPlane(GL.Enums.ClipPlaneName plane, GLdouble* equation);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetDoublev(GL.Enums.GetPName pname, GLdouble* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GL.Enums.GLenum GetError();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetFloatv(GL.Enums.GetPName pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetIntegerv(GL.Enums.GetPName pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetLightfv(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetLightiv(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetMapdv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetMapfv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetMapiv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetMaterialfv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetMaterialiv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetPixelMapfv(GL.Enums.PixelMap map, GLfloat* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetPixelMapuiv(GL.Enums.PixelMap map, GLuint* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetPixelMapusv(GL.Enums.PixelMap map, GLushort* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetPolygonStipple(GLubyte* mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static System.IntPtr GetString(GL.Enums.StringName name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTexEnvfv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTexEnviv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTexGendv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLdouble* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTexGenfv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTexGeniv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTexImage(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTexParameterfv(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTexParameteriv(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTexLevelParameterfv(GL.Enums.TextureTarget target, GLint level, GL.Enums.GetTextureParameter pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTexLevelParameteriv(GL.Enums.TextureTarget target, GLint level, GL.Enums.GetTextureParameter pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsEnabled(GL.Enums.EnableCap cap);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsList(GLuint list);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DepthRange(GLclampd near, GLclampd far);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Frustum(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void LoadIdentity();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void LoadMatrixf(GLfloat* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void LoadMatrixd(GLdouble* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MatrixMode(GL.Enums.MatrixMode mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultMatrixf(GLfloat* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultMatrixd(GLdouble* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Ortho(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PopMatrix();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PushMatrix();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Rotated(GLdouble angle, GLdouble x, GLdouble y, GLdouble z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Rotatef(GLfloat angle, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Scaled(GLdouble x, GLdouble y, GLdouble z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Scalef(GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Translated(GLdouble x, GLdouble y, GLdouble z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Translatef(GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Viewport(GLint x, GLint y, GLsizei width, GLsizei height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ArrayElement(GLint i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ColorPointer(GLint size, GL.Enums.ColorPointerType type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DisableClientState(GL.Enums.EnableCap array);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DrawArrays(GL.Enums.BeginMode mode, GLint first, GLsizei count);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DrawElements(GL.Enums.BeginMode mode, GLsizei count, GL.Enums.GLenum type, void* indices);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void EdgeFlagPointer(GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EnableClientState(GL.Enums.EnableCap array);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetPointerv(GL.Enums.GetPointervPName pname, void* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void IndexPointer(GL.Enums.IndexPointerType type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void InterleavedArrays(GL.Enums.InterleavedArrayFormat format, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void NormalPointer(GL.Enums.NormalPointerType type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoordPointer(GLint size, GL.Enums.TexCoordPointerType type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexPointer(GLint size, GL.Enums.VertexPointerType type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PolygonOffset(GLfloat factor, GLfloat units);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyTexImage1D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLint border);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyTexImage2D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyTexSubImage1D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyTexSubImage2D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexSubImage1D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexSubImage2D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe GLboolean AreTexturesResident(GLsizei n, GLuint* textures, GL.Enums.Boolean* residences);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BindTexture(GL.Enums.TextureTarget target, GLuint texture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DeleteTextures(GLsizei n, GLuint* textures);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GenTextures(GLsizei n, GLuint* textures);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsTexture(GLuint texture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PrioritizeTextures(GLsizei n, GLuint* textures, GLclampf* priorities);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Indexub(GLubyte c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Indexubv(GLubyte* c);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PopClientAttrib();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PushClientAttrib(GL.Enums.ClientAttribMask mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BlendColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BlendEquation(GL.Enums.VERSION_1_2 mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DrawRangeElements(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count, GL.Enums.VERSION_1_2 type, void* indices);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ColorTableParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ColorTableParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetColorTableParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetColorTableParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ColorSubTable(GL.Enums.VERSION_1_2 target, GLsizei start, GLsizei count, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyColorSubTable(GL.Enums.VERSION_1_2 target, GLsizei start, GLint x, GLint y, GLsizei width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ConvolutionFilter1D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ConvolutionFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ConvolutionParameterf(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ConvolutionParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ConvolutionParameteri(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ConvolutionParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyConvolutionFilter1D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyConvolutionFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetConvolutionFilter(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetConvolutionParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetConvolutionParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetSeparableFilter(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column, void* span);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SeparableFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetHistogram(GL.Enums.VERSION_1_2 target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetHistogramParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetHistogramParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetMinmax(GL.Enums.VERSION_1_2 target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetMinmaxParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetMinmaxParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Histogram(GL.Enums.VERSION_1_2 target, GLsizei width, GL.Enums.PixelInternalFormat internalformat, GL.Enums.Boolean sink);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Minmax(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GL.Enums.Boolean sink);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ResetHistogram(GL.Enums.VERSION_1_2 target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ResetMinmax(GL.Enums.VERSION_1_2 target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexImage3D(GL.Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexSubImage3D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyTexSubImage3D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ActiveTexture(GL.Enums.VERSION_1_3 texture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ClientActiveTexture(GL.Enums.VERSION_1_3 texture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord1d(GL.Enums.VERSION_1_3 target, GLdouble s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1dv(GL.Enums.VERSION_1_3 target, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord1f(GL.Enums.VERSION_1_3 target, GLfloat s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1fv(GL.Enums.VERSION_1_3 target, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord1i(GL.Enums.VERSION_1_3 target, GLint s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1iv(GL.Enums.VERSION_1_3 target, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord1s(GL.Enums.VERSION_1_3 target, GLshort s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1sv(GL.Enums.VERSION_1_3 target, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord2d(GL.Enums.VERSION_1_3 target, GLdouble s, GLdouble t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2dv(GL.Enums.VERSION_1_3 target, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord2f(GL.Enums.VERSION_1_3 target, GLfloat s, GLfloat t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2fv(GL.Enums.VERSION_1_3 target, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord2i(GL.Enums.VERSION_1_3 target, GLint s, GLint t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2iv(GL.Enums.VERSION_1_3 target, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord2s(GL.Enums.VERSION_1_3 target, GLshort s, GLshort t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2sv(GL.Enums.VERSION_1_3 target, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord3d(GL.Enums.VERSION_1_3 target, GLdouble s, GLdouble t, GLdouble r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3dv(GL.Enums.VERSION_1_3 target, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord3f(GL.Enums.VERSION_1_3 target, GLfloat s, GLfloat t, GLfloat r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3fv(GL.Enums.VERSION_1_3 target, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord3i(GL.Enums.VERSION_1_3 target, GLint s, GLint t, GLint r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3iv(GL.Enums.VERSION_1_3 target, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord3s(GL.Enums.VERSION_1_3 target, GLshort s, GLshort t, GLshort r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3sv(GL.Enums.VERSION_1_3 target, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord4d(GL.Enums.VERSION_1_3 target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4dv(GL.Enums.VERSION_1_3 target, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord4f(GL.Enums.VERSION_1_3 target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4fv(GL.Enums.VERSION_1_3 target, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord4i(GL.Enums.VERSION_1_3 target, GLint s, GLint t, GLint r, GLint q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4iv(GL.Enums.VERSION_1_3 target, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord4s(GL.Enums.VERSION_1_3 target, GLshort s, GLshort t, GLshort r, GLshort q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4sv(GL.Enums.VERSION_1_3 target, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void LoadTransposeMatrixf(GLfloat* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void LoadTransposeMatrixd(GLdouble* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultTransposeMatrixf(GLfloat* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultTransposeMatrixd(GLdouble* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SampleCoverage(GLclampf value, GL.Enums.Boolean invert);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexImage3D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexImage2D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexImage1D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexSubImage3D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GL.Enums.PixelFormat format, GLsizei imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexSubImage2D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GLsizei imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexSubImage1D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, GL.Enums.PixelFormat format, GLsizei imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetCompressedTexImage(GL.Enums.TextureTarget target, GLint level, void* img);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BlendFuncSeparate(GL.Enums.VERSION_1_4 sfactorRGB, GL.Enums.VERSION_1_4 dfactorRGB, GL.Enums.VERSION_1_4 sfactorAlpha, GL.Enums.VERSION_1_4 dfactorAlpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FogCoordf(GLfloat coord);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FogCoordfv(GLfloat* coord);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FogCoordd(GLdouble coord);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FogCoorddv(GLdouble* coord);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FogCoordPointer(GL.Enums.VERSION_1_4 type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiDrawArrays(GL.Enums.BeginMode mode, GLint* first, GLsizei* count, GLsizei primcount);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiDrawElements(GL.Enums.BeginMode mode, GLsizei* count, GL.Enums.VERSION_1_4 type, void* indices, GLsizei primcount);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PointParameterf(GL.Enums.VERSION_1_4 pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PointParameterfv(GL.Enums.VERSION_1_4 pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PointParameteri(GL.Enums.VERSION_1_4 pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PointParameteriv(GL.Enums.VERSION_1_4 pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3b(GLbyte red, GLbyte green, GLbyte blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3bv(GLbyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3d(GLdouble red, GLdouble green, GLdouble blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3dv(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3f(GLfloat red, GLfloat green, GLfloat blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3fv(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3i(GLint red, GLint green, GLint blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3iv(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3s(GLshort red, GLshort green, GLshort blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3sv(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3ub(GLubyte red, GLubyte green, GLubyte blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3ubv(GLubyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3ui(GLuint red, GLuint green, GLuint blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3uiv(GLuint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3us(GLushort red, GLushort green, GLushort blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3usv(GLushort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColorPointer(GLint size, GL.Enums.ColorPointerType type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos2d(GLdouble x, GLdouble y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2dv(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos2f(GLfloat x, GLfloat y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2fv(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos2i(GLint x, GLint y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2iv(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos2s(GLshort x, GLshort y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2sv(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos3d(GLdouble x, GLdouble y, GLdouble z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3dv(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos3f(GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3fv(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos3i(GLint x, GLint y, GLint z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3iv(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos3s(GLshort x, GLshort y, GLshort z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3sv(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GenQueries(GLsizei n, GLuint* ids);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DeleteQueries(GLsizei n, GLuint* ids);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsQuery(GLuint id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BeginQuery(GL.Enums.GLenum target, GLuint id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EndQuery(GL.Enums.GLenum target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetQueryiv(GL.Enums.GLenum target, GL.Enums.GLenum pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetQueryObjectiv(GLuint id, GL.Enums.GLenum pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetQueryObjectuiv(GLuint id, GL.Enums.GLenum pname, GLuint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BindBuffer(GL.Enums.VERSION_1_5 target, GLuint buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DeleteBuffers(GLsizei n, GLuint* buffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GenBuffers(GLsizei n, GLuint* buffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsBuffer(GLuint buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void BufferData(GL.Enums.VERSION_1_5 target, GLsizeiptr size, void* data, GL.Enums.VERSION_1_5 usage);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void BufferSubData(GL.Enums.VERSION_1_5 target, GLintptr offset, GLsizeiptr size, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetBufferSubData(GL.Enums.VERSION_1_5 target, GLintptr offset, GLsizeiptr size, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MapBuffer(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 access);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean UnmapBuffer(GL.Enums.VERSION_1_5 target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetBufferParameteriv(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetBufferPointerv(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 pname, void* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BlendEquationSeparate(GL.Enums.BlendEquationModeEXT modeRGB, GL.Enums.BlendEquationModeEXT modeAlpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DrawBuffers(GLsizei n, GL.Enums.VERSION_2_0* bufs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void StencilOpSeparate(GL.Enums.VERSION_2_0 face, GL.Enums.StencilOp sfail, GL.Enums.StencilOp dpfail, GL.Enums.StencilOp dppass);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void StencilFuncSeparate(GL.Enums.StencilFunction frontfunc, GL.Enums.StencilFunction backfunc, GLint @ref, GLuint mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void StencilMaskSeparate(GL.Enums.VERSION_2_0 face, GLuint mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void AttachShader(GLuint program, GLuint shader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void BindAttribLocation(GLuint program, GLuint index, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CompileShader(GLuint shader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLuint CreateProgram();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLuint CreateShader(GL.Enums.GLenum type);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DeleteProgram(GLuint program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DeleteShader(GLuint shader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DetachShader(GLuint program, GLuint shader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DisableVertexAttribArray(GLuint index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EnableVertexAttribArray(GLuint index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetActiveAttrib(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GL.Enums.GLenum* type, System.Text.StringBuilder name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetActiveUniform(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GL.Enums.GLenum* type, System.Text.StringBuilder name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetAttachedShaders(GLuint program, GLsizei maxCount, GLsizei* count, GLuint* obj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe GLint GetAttribLocation(GLuint program, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramiv(GLuint program, GL.Enums.GLenum pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramInfoLog(GLuint program, GLsizei bufSize, GLsizei* length, System.Text.StringBuilder infoLog);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetShaderiv(GLuint shader, GL.Enums.GLenum pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetShaderInfoLog(GLuint shader, GLsizei bufSize, GLsizei* length, System.Text.StringBuilder infoLog);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetShaderSource(GLuint shader, GLsizei bufSize, GLsizei* length, System.Text.StringBuilder source);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe GLint GetUniformLocation(GLuint program, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetUniformfv(GLuint program, GLint location, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetUniformiv(GLuint program, GLint location, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribdv(GLuint index, GL.Enums.VERSION_2_0 pname, GLdouble* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribfv(GLuint index, GL.Enums.VERSION_2_0 pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribiv(GLuint index, GL.Enums.VERSION_2_0 pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribPointerv(GLuint index, GL.Enums.VERSION_2_0 pname, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsProgram(GLuint program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsShader(GLuint shader);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void LinkProgram(GLuint program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ShaderSource(GLuint shader, GLsizei count, System.String @string, GLint* length);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void UseProgram(GLuint program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform1f(GLint location, GLfloat v0);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform2f(GLint location, GLfloat v0, GLfloat v1);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform3f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform4f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform1i(GLint location, GLint v0);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform2i(GLint location, GLint v0, GLint v1);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform3i(GLint location, GLint v0, GLint v1, GLint v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform4i(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform1fv(GLint location, GLsizei count, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform2fv(GLint location, GLsizei count, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform3fv(GLint location, GLsizei count, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform4fv(GLint location, GLsizei count, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform1iv(GLint location, GLsizei count, GLint* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform2iv(GLint location, GLsizei count, GLint* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform3iv(GLint location, GLsizei count, GLint* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform4iv(GLint location, GLsizei count, GLint* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix2fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix3fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix4fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ValidateProgram(GLuint program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib1d(GLuint index, GLdouble x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1dv(GLuint index, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib1f(GLuint index, GLfloat x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1fv(GLuint index, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib1s(GLuint index, GLshort x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1sv(GLuint index, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib2d(GLuint index, GLdouble x, GLdouble y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2dv(GLuint index, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib2f(GLuint index, GLfloat x, GLfloat y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2fv(GLuint index, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib2s(GLuint index, GLshort x, GLshort y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2sv(GLuint index, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib3d(GLuint index, GLdouble x, GLdouble y, GLdouble z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3dv(GLuint index, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib3f(GLuint index, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3fv(GLuint index, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib3s(GLuint index, GLshort x, GLshort y, GLshort z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3sv(GLuint index, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4Nbv(GLuint index, GLbyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4Niv(GLuint index, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4Nsv(GLuint index, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib4Nub(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4Nubv(GLuint index, GLubyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4Nuiv(GLuint index, GLuint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4Nusv(GLuint index, GLushort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4bv(GLuint index, GLbyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib4d(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4dv(GLuint index, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib4f(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4fv(GLuint index, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4iv(GLuint index, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib4s(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4sv(GLuint index, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4ubv(GLuint index, GLubyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4uiv(GLuint index, GLuint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4usv(GLuint index, GLushort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribPointer(GLuint index, GLint size, GL.Enums.VERSION_2_0 type, GL.Enums.Boolean normalized, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix2x3fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix3x2fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix2x4fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix4x2fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix3x4fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix4x3fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ActiveTextureARB(GL.Enums.ARB_multitexture texture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ClientActiveTextureARB(GL.Enums.ARB_multitexture texture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord1dARB(GL.Enums.ARB_multitexture target, GLdouble s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1dvARB(GL.Enums.ARB_multitexture target, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord1fARB(GL.Enums.ARB_multitexture target, GLfloat s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1fvARB(GL.Enums.ARB_multitexture target, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord1iARB(GL.Enums.ARB_multitexture target, GLint s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1ivARB(GL.Enums.ARB_multitexture target, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord1sARB(GL.Enums.ARB_multitexture target, GLshort s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1svARB(GL.Enums.ARB_multitexture target, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord2dARB(GL.Enums.ARB_multitexture target, GLdouble s, GLdouble t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2dvARB(GL.Enums.ARB_multitexture target, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord2fARB(GL.Enums.ARB_multitexture target, GLfloat s, GLfloat t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2fvARB(GL.Enums.ARB_multitexture target, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord2iARB(GL.Enums.ARB_multitexture target, GLint s, GLint t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2ivARB(GL.Enums.ARB_multitexture target, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord2sARB(GL.Enums.ARB_multitexture target, GLshort s, GLshort t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2svARB(GL.Enums.ARB_multitexture target, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord3dARB(GL.Enums.ARB_multitexture target, GLdouble s, GLdouble t, GLdouble r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3dvARB(GL.Enums.ARB_multitexture target, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord3fARB(GL.Enums.ARB_multitexture target, GLfloat s, GLfloat t, GLfloat r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3fvARB(GL.Enums.ARB_multitexture target, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord3iARB(GL.Enums.ARB_multitexture target, GLint s, GLint t, GLint r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3ivARB(GL.Enums.ARB_multitexture target, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord3sARB(GL.Enums.ARB_multitexture target, GLshort s, GLshort t, GLshort r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3svARB(GL.Enums.ARB_multitexture target, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord4dARB(GL.Enums.ARB_multitexture target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4dvARB(GL.Enums.ARB_multitexture target, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord4fARB(GL.Enums.ARB_multitexture target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4fvARB(GL.Enums.ARB_multitexture target, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord4iARB(GL.Enums.ARB_multitexture target, GLint s, GLint t, GLint r, GLint q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4ivARB(GL.Enums.ARB_multitexture target, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord4sARB(GL.Enums.ARB_multitexture target, GLshort s, GLshort t, GLshort r, GLshort q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4svARB(GL.Enums.ARB_multitexture target, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void LoadTransposeMatrixfARB(GLfloat* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void LoadTransposeMatrixdARB(GLdouble* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultTransposeMatrixfARB(GLfloat* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultTransposeMatrixdARB(GLdouble* m);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SampleCoverageARB(GLclampf value, GL.Enums.Boolean invert);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexImage3DARB(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexImage2DARB(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexImage1DARB(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexSubImage3DARB(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GL.Enums.PixelFormat format, GLsizei imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexSubImage2DARB(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GLsizei imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CompressedTexSubImage1DARB(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, GL.Enums.PixelFormat format, GLsizei imageSize, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetCompressedTexImageARB(GL.Enums.TextureTarget target, GLint level, void* img);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PointParameterfARB(GL.Enums.ARB_point_parameters pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PointParameterfvARB(GL.Enums.ARB_point_parameters pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WeightbvARB(GLint size, GLbyte* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WeightsvARB(GLint size, GLshort* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WeightivARB(GLint size, GLint* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WeightfvARB(GLint size, GLfloat* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WeightdvARB(GLint size, GLdouble* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WeightubvARB(GLint size, GLubyte* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WeightusvARB(GLint size, GLushort* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WeightuivARB(GLint size, GLuint* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WeightPointerARB(GLint size, GL.Enums.ARB_vertex_blend type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexBlendARB(GLint count);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CurrentPaletteMatrixARB(GLint index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MatrixIndexubvARB(GLint size, GLubyte* indices);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MatrixIndexusvARB(GLint size, GLushort* indices);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MatrixIndexuivARB(GLint size, GLuint* indices);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MatrixIndexPointerARB(GLint size, GL.Enums.ARB_matrix_palette type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos2dARB(GLdouble x, GLdouble y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2dvARB(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos2fARB(GLfloat x, GLfloat y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2fvARB(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos2iARB(GLint x, GLint y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2ivARB(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos2sARB(GLshort x, GLshort y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2svARB(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos3dARB(GLdouble x, GLdouble y, GLdouble z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3dvARB(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos3fARB(GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3fvARB(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos3iARB(GLint x, GLint y, GLint z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3ivARB(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos3sARB(GLshort x, GLshort y, GLshort z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3svARB(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib1dARB(GLuint index, GLdouble x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1dvARB(GLuint index, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib1fARB(GLuint index, GLfloat x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1fvARB(GLuint index, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib1sARB(GLuint index, GLshort x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1svARB(GLuint index, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib2dARB(GLuint index, GLdouble x, GLdouble y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2dvARB(GLuint index, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib2fARB(GLuint index, GLfloat x, GLfloat y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2fvARB(GLuint index, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib2sARB(GLuint index, GLshort x, GLshort y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2svARB(GLuint index, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib3dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3dvARB(GLuint index, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib3fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3fvARB(GLuint index, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib3sARB(GLuint index, GLshort x, GLshort y, GLshort z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3svARB(GLuint index, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4NbvARB(GLuint index, GLbyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4NivARB(GLuint index, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4NsvARB(GLuint index, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib4NubARB(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4NubvARB(GLuint index, GLubyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4NuivARB(GLuint index, GLuint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4NusvARB(GLuint index, GLushort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4bvARB(GLuint index, GLbyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib4dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4dvARB(GLuint index, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib4fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4fvARB(GLuint index, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4ivARB(GLuint index, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib4sARB(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4svARB(GLuint index, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4ubvARB(GLuint index, GLubyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4uivARB(GLuint index, GLuint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4usvARB(GLuint index, GLushort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribPointerARB(GLuint index, GLint size, GL.Enums.ARB_vertex_program type, GL.Enums.Boolean normalized, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EnableVertexAttribArrayARB(GLuint index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DisableVertexAttribArrayARB(GLuint index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramStringARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program format, GLsizei len, void* @string);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BindProgramARB(GL.Enums.ARB_vertex_program target, GLuint program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DeleteProgramsARB(GLsizei n, GLuint* programs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GenProgramsARB(GLsizei n, GLuint* programs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ProgramEnvParameter4dARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramEnvParameter4dvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ProgramEnvParameter4fARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramEnvParameter4fvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ProgramLocalParameter4dARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramLocalParameter4dvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ProgramLocalParameter4fARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramLocalParameter4fvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramEnvParameterdvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramEnvParameterfvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramLocalParameterdvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramLocalParameterfvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramivARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramStringARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program pname, void* @string);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribdvARB(GLuint index, GL.Enums.ARB_vertex_program pname, GLdouble* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribfvARB(GLuint index, GL.Enums.ARB_vertex_program pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribivARB(GLuint index, GL.Enums.ARB_vertex_program pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribPointervARB(GLuint index, GL.Enums.ARB_vertex_program pname, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsProgramARB(GLuint program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BindBufferARB(GL.Enums.ARB_vertex_buffer_object target, GLuint buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DeleteBuffersARB(GLsizei n, GLuint* buffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GenBuffersARB(GLsizei n, GLuint* buffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsBufferARB(GLuint buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void BufferDataARB(GL.Enums.ARB_vertex_buffer_object target, GLsizeiptrARB size, void* data, GL.Enums.ARB_vertex_buffer_object usage);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void BufferSubDataARB(GL.Enums.ARB_vertex_buffer_object target, GLintptrARB offset, GLsizeiptrARB size, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetBufferSubDataARB(GL.Enums.ARB_vertex_buffer_object target, GLintptrARB offset, GLsizeiptrARB size, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MapBufferARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object access);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean UnmapBufferARB(GL.Enums.ARB_vertex_buffer_object target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetBufferParameterivARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetBufferPointervARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object pname, void* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GenQueriesARB(GLsizei n, GLuint* ids);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DeleteQueriesARB(GLsizei n, GLuint* ids);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsQueryARB(GLuint id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BeginQueryARB(GL.Enums.GLenum target, GLuint id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EndQueryARB(GL.Enums.GLenum target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetQueryivARB(GL.Enums.GLenum target, GL.Enums.GLenum pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetQueryObjectivARB(GLuint id, GL.Enums.GLenum pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetQueryObjectuivARB(GLuint id, GL.Enums.GLenum pname, GLuint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DeleteObjectARB(GLhandleARB obj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLhandleARB GetHandleARB(GL.Enums.GLenum pname);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DetachObjectARB(GLhandleARB containerObj, GLhandleARB attachedObj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLhandleARB CreateShaderObjectARB(GL.Enums.GLenum shaderType);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ShaderSourceARB(GLhandleARB shaderObj, GLsizei count, System.String @string, GLint* length);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CompileShaderARB(GLhandleARB shaderObj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLhandleARB CreateProgramObjectARB();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void AttachObjectARB(GLhandleARB containerObj, GLhandleARB obj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void LinkProgramARB(GLhandleARB programObj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void UseProgramObjectARB(GLhandleARB programObj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ValidateProgramARB(GLhandleARB programObj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform1fARB(GLint location, GLfloat v0);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform2fARB(GLint location, GLfloat v0, GLfloat v1);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform3fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform4fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform1iARB(GLint location, GLint v0);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform2iARB(GLint location, GLint v0, GLint v1);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform3iARB(GLint location, GLint v0, GLint v1, GLint v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform4iARB(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform1fvARB(GLint location, GLsizei count, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform2fvARB(GLint location, GLsizei count, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform3fvARB(GLint location, GLsizei count, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform4fvARB(GLint location, GLsizei count, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform1ivARB(GLint location, GLsizei count, GLint* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform2ivARB(GLint location, GLsizei count, GLint* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform3ivARB(GLint location, GLsizei count, GLint* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform4ivARB(GLint location, GLsizei count, GLint* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix2fvARB(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix3fvARB(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void UniformMatrix4fvARB(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetObjectParameterfvARB(GLhandleARB obj, GL.Enums.GLenum pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetObjectParameterivARB(GLhandleARB obj, GL.Enums.GLenum pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetInfoLogARB(GLhandleARB obj, GLsizei maxLength, GLsizei* length, System.Text.StringBuilder infoLog);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetAttachedObjectsARB(GLhandleARB containerObj, GLsizei maxCount, GLsizei* count, GLhandleARB* obj);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe GLint GetUniformLocationARB(GLhandleARB programObj, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetActiveUniformARB(GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GL.Enums.GLenum* type, System.Text.StringBuilder name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetUniformfvARB(GLhandleARB programObj, GLint location, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetUniformivARB(GLhandleARB programObj, GLint location, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetShaderSourceARB(GLhandleARB obj, GLsizei maxLength, GLsizei* length, System.Text.StringBuilder source);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void BindAttribLocationARB(GLhandleARB programObj, GLuint index, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetActiveAttribARB(GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GL.Enums.GLenum* type, System.Text.StringBuilder name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe GLint GetAttribLocationARB(GLhandleARB programObj, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DrawBuffersARB(GLsizei n, GL.Enums.ARB_draw_buffers* bufs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ClampColorARB(GL.Enums.ARB_color_buffer_float target, GL.Enums.ARB_color_buffer_float clamp);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BlendColorEXT(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PolygonOffsetEXT(GLfloat factor, GLfloat bias);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexImage3DEXT(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexSubImage3DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTexFilterFuncSGIS(GL.Enums.TextureTarget target, GL.Enums.SGIS_texture_filter4 filter, GLfloat* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexFilterFuncSGIS(GL.Enums.TextureTarget target, GL.Enums.SGIS_texture_filter4 filter, GLsizei n, GLfloat* weights);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexSubImage1DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexSubImage2DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyTexImage1DEXT(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLint border);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyTexImage2DEXT(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyTexSubImage1DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyTexSubImage2DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyTexSubImage3DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetHistogramEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetHistogramParameterfvEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.GetHistogramParameterPNameEXT pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetHistogramParameterivEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.GetHistogramParameterPNameEXT pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetMinmaxEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* values);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetMinmaxParameterfvEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.GetMinmaxParameterPNameEXT pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetMinmaxParameterivEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.GetMinmaxParameterPNameEXT pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void HistogramEXT(GL.Enums.HistogramTargetEXT target, GLsizei width, GL.Enums.PixelInternalFormat internalformat, GL.Enums.Boolean sink);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MinmaxEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GL.Enums.Boolean sink);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ResetHistogramEXT(GL.Enums.HistogramTargetEXT target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ResetMinmaxEXT(GL.Enums.MinmaxTargetEXT target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ConvolutionFilter1DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ConvolutionFilter2DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ConvolutionParameterfEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLfloat @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ConvolutionParameterfvEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ConvolutionParameteriEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLint @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ConvolutionParameterivEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyConvolutionFilter1DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyConvolutionFilter2DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetConvolutionFilterEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetConvolutionParameterfvEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetConvolutionParameterivEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetSeparableFilterEXT(GL.Enums.SeparableTargetEXT target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column, void* span);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SeparableFilter2DEXT(GL.Enums.SeparableTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ColorTableParameterfvSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.ColorTableParameterPNameSGI pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ColorTableParameterivSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.ColorTableParameterPNameSGI pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetColorTableParameterfvSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.GetColorTableParameterPNameSGI pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetColorTableParameterivSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.GetColorTableParameterPNameSGI pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PixelTexGenSGIX(GL.Enums.SGIX_pixel_texture mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PixelTexGenParameteriSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PixelTexGenParameterivSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PixelTexGenParameterfSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PixelTexGenParameterfvSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetPixelTexGenParameterivSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetPixelTexGenParameterfvSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexImage4DSGIS(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexSubImage4DSGIS(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint woffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe GLboolean AreTexturesResidentEXT(GLsizei n, GLuint* textures, GL.Enums.Boolean* residences);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BindTextureEXT(GL.Enums.TextureTarget target, GLuint texture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DeleteTexturesEXT(GLsizei n, GLuint* textures);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GenTexturesEXT(GLsizei n, GLuint* textures);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsTextureEXT(GLuint texture);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PrioritizeTexturesEXT(GLsizei n, GLuint* textures, GLclampf* priorities);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DetailTexFuncSGIS(GL.Enums.TextureTarget target, GLsizei n, GLfloat* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetDetailTexFuncSGIS(GL.Enums.TextureTarget target, GLfloat* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SharpenTexFuncSGIS(GL.Enums.TextureTarget target, GLsizei n, GLfloat* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetSharpenTexFuncSGIS(GL.Enums.TextureTarget target, GLfloat* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SampleMaskSGIS(GLclampf value, GL.Enums.Boolean invert);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SamplePatternSGIS(GL.Enums.SamplePatternSGIS pattern);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ArrayElementEXT(GLint i);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ColorPointerEXT(GLint size, GL.Enums.ColorPointerType type, GLsizei stride, GLsizei count, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DrawArraysEXT(GL.Enums.BeginMode mode, GLint first, GLsizei count);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void EdgeFlagPointerEXT(GLsizei stride, GLsizei count, GL.Enums.Boolean* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetPointervEXT(GL.Enums.GetPointervPName pname, void* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void IndexPointerEXT(GL.Enums.IndexPointerType type, GLsizei stride, GLsizei count, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void NormalPointerEXT(GL.Enums.NormalPointerType type, GLsizei stride, GLsizei count, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoordPointerEXT(GLint size, GL.Enums.TexCoordPointerType type, GLsizei stride, GLsizei count, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexPointerEXT(GLint size, GL.Enums.VertexPointerType type, GLsizei stride, GLsizei count, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BlendEquationEXT(GL.Enums.BlendEquationModeEXT mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SpriteParameterfSGIX(GL.Enums.SGIX_sprite pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SpriteParameterfvSGIX(GL.Enums.SGIX_sprite pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SpriteParameteriSGIX(GL.Enums.SGIX_sprite pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SpriteParameterivSGIX(GL.Enums.SGIX_sprite pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PointParameterfEXT(GL.Enums.EXT_point_parameters pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PointParameterfvEXT(GL.Enums.EXT_point_parameters pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PointParameterfSGIS(GL.Enums.SGIS_point_parameters pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PointParameterfvSGIS(GL.Enums.SGIS_point_parameters pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLint GetInstrumentsSGIX();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void InstrumentsBufferSGIX(GLsizei size, GLint* buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe GLint PollInstrumentsSGIX(GLint* marker_p);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ReadInstrumentsSGIX(GLint marker);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void StartInstrumentsSGIX();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void StopInstrumentsSGIX(GLint marker);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FrameZoomSGIX(GLint factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TagSampleBufferSGIX();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DeformationMap3dSGIX(GL.Enums.FfdTargetSGIX target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble w1, GLdouble w2, GLint wstride, GLint worder, GLdouble* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DeformationMap3fSGIX(GL.Enums.FfdTargetSGIX target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat w1, GLfloat w2, GLint wstride, GLint worder, GLfloat* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DeformSGIX(GL.Enums.FfdMaskSGIX mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void LoadIdentityDeformationMapSGIX(GL.Enums.FfdMaskSGIX mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ReferencePlaneSGIX(GLdouble* equation);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FlushRasterSGIX();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FogFuncSGIS(GLsizei n, GLfloat* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetFogFuncSGIS(GLfloat* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ImageTransformParameteriHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ImageTransformParameterfHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ImageTransformParameterivHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ImageTransformParameterfvHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetImageTransformParameterivHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetImageTransformParameterfvHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ColorSubTableEXT(GL.Enums.EXT_color_subtable target, GLsizei start, GLsizei count, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CopyColorSubTableEXT(GL.Enums.EXT_color_subtable target, GLsizei start, GLint x, GLint y, GLsizei width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void HintPGI(GL.Enums.PGI_misc_hints target, GLint mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ColorTableEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.PixelInternalFormat internalFormat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetColorTableEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetColorTableParameterivEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.EXT_paletted_texture pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetColorTableParameterfvEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.EXT_paletted_texture pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetListParameterfvSGIX(GLuint list, GL.Enums.ListParameterName pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetListParameterivSGIX(GLuint list, GL.Enums.ListParameterName pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ListParameterfSGIX(GLuint list, GL.Enums.ListParameterName pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ListParameterfvSGIX(GLuint list, GL.Enums.ListParameterName pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ListParameteriSGIX(GLuint list, GL.Enums.ListParameterName pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ListParameterivSGIX(GLuint list, GL.Enums.ListParameterName pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void IndexMaterialEXT(GL.Enums.MaterialFace face, GL.Enums.EXT_index_material mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void IndexFuncEXT(GL.Enums.EXT_index_func func, GLclampf @ref);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void LockArraysEXT(GLint first, GLsizei count);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void UnlockArraysEXT();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CullParameterdvEXT(GL.Enums.EXT_cull_vertex pname, GLdouble* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CullParameterfvEXT(GL.Enums.EXT_cull_vertex pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FragmentColorMaterialSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FragmentLightfSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FragmentLightfvSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FragmentLightiSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FragmentLightivSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FragmentLightModelfSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FragmentLightModelfvSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FragmentLightModeliSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FragmentLightModelivSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FragmentMaterialfSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FragmentMaterialfvSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FragmentMaterialiSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FragmentMaterialivSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetFragmentLightfvSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetFragmentLightivSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetFragmentMaterialfvSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetFragmentMaterialivSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void LightEnviSGIX(GL.Enums.LightEnvParameterSGIX pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DrawRangeElementsEXT(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count, GL.Enums.EXT_draw_range_elements type, void* indices);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ApplyTextureEXT(GL.Enums.EXT_light_texture mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TextureLightEXT(GL.Enums.EXT_light_texture pname);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TextureMaterialEXT(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void AsyncMarkerSGIX(GLuint marker);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe GLint FinishAsyncSGIX(GLuint* markerp);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe GLint PollAsyncSGIX(GLuint* markerp);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLuint GenAsyncMarkersSGIX(GLsizei range);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DeleteAsyncMarkersSGIX(GLuint marker, GLsizei range);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsAsyncMarkerSGIX(GLuint marker);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexPointervINTEL(GLint size, GL.Enums.VertexPointerType type, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void NormalPointervINTEL(GL.Enums.NormalPointerType type, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ColorPointervINTEL(GLint size, GL.Enums.VertexPointerType type, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoordPointervINTEL(GLint size, GL.Enums.VertexPointerType type, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PixelTransformParameteriEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PixelTransformParameterfEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PixelTransformParameterivEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PixelTransformParameterfvEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3bEXT(GLbyte red, GLbyte green, GLbyte blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3bvEXT(GLbyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3dEXT(GLdouble red, GLdouble green, GLdouble blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3dvEXT(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3fEXT(GLfloat red, GLfloat green, GLfloat blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3fvEXT(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3iEXT(GLint red, GLint green, GLint blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3ivEXT(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3sEXT(GLshort red, GLshort green, GLshort blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3svEXT(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3ubEXT(GLubyte red, GLubyte green, GLubyte blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3ubvEXT(GLubyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3uiEXT(GLuint red, GLuint green, GLuint blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3uivEXT(GLuint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3usEXT(GLushort red, GLushort green, GLushort blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3usvEXT(GLushort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColorPointerEXT(GLint size, GL.Enums.ColorPointerType type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TextureNormalEXT(GL.Enums.EXT_texture_perturb_normal mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiDrawArraysEXT(GL.Enums.BeginMode mode, GLint* first, GLsizei* count, GLsizei primcount);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiDrawElementsEXT(GL.Enums.BeginMode mode, GLsizei* count, GL.Enums.EXT_multi_draw_arrays type, void* indices, GLsizei primcount);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FogCoordfEXT(GLfloat coord);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FogCoordfvEXT(GLfloat* coord);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FogCoorddEXT(GLdouble coord);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FogCoorddvEXT(GLdouble* coord);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FogCoordPointerEXT(GL.Enums.EXT_fog_coord type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Tangent3bEXT(GLbyte tx, GLbyte ty, GLbyte tz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Tangent3bvEXT(GLbyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Tangent3dEXT(GLdouble tx, GLdouble ty, GLdouble tz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Tangent3dvEXT(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Tangent3fEXT(GLfloat tx, GLfloat ty, GLfloat tz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Tangent3fvEXT(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Tangent3iEXT(GLint tx, GLint ty, GLint tz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Tangent3ivEXT(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Tangent3sEXT(GLshort tx, GLshort ty, GLshort tz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Tangent3svEXT(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Binormal3bEXT(GLbyte bx, GLbyte by, GLbyte bz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Binormal3bvEXT(GLbyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Binormal3dEXT(GLdouble bx, GLdouble by, GLdouble bz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Binormal3dvEXT(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Binormal3fEXT(GLfloat bx, GLfloat by, GLfloat bz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Binormal3fvEXT(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Binormal3iEXT(GLint bx, GLint by, GLint bz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Binormal3ivEXT(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Binormal3sEXT(GLshort bx, GLshort by, GLshort bz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Binormal3svEXT(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TangentPointerEXT(GL.Enums.EXT_coordinate_frame type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void BinormalPointerEXT(GL.Enums.EXT_coordinate_frame type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FinishTextureSUNX();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void GlobalAlphaFactorbSUN(GLbyte factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void GlobalAlphaFactorsSUN(GLshort factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void GlobalAlphaFactoriSUN(GLint factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void GlobalAlphaFactorfSUN(GLfloat factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void GlobalAlphaFactordSUN(GLdouble factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void GlobalAlphaFactorubSUN(GLubyte factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void GlobalAlphaFactorusSUN(GLushort factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void GlobalAlphaFactoruiSUN(GLuint factor);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiSUN(GLuint code);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ReplacementCodeusSUN(GLushort code);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ReplacementCodeubSUN(GLubyte code);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuivSUN(GLuint* code);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeusvSUN(GLushort* code);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeubvSUN(GLubyte* code);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodePointerSUN(GL.Enums.SUN_triangle_list type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color4ubVertex2fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color4ubVertex2fvSUN(GLubyte* c, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color4ubVertex3fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color4ubVertex3fvSUN(GLubyte* c, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color3fVertex3fvSUN(GLfloat* c, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Normal3fVertex3fSUN(GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Normal3fVertex3fvSUN(GLfloat* n, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color4fNormal3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color4fNormal3fVertex3fvSUN(GLfloat* c, GLfloat* n, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord2fVertex3fSUN(GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2fVertex3fvSUN(GLfloat* tc, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord4fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord4fVertex4fvSUN(GLfloat* tc, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord2fColor4ubVertex3fSUN(GLfloat s, GLfloat t, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2fColor4ubVertex3fvSUN(GLfloat* tc, GLubyte* c, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord2fColor3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2fColor3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord2fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* n, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord2fColor4fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord4fColor4fNormal3fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiVertex3fSUN(GLuint rc, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuiVertex3fvSUN(GLuint* rc, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiColor4ubVertex3fSUN(GLuint rc, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint* rc, GLubyte* c, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiColor3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiNormal3fVertex3fSUN(GLuint rc, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint* rc, GLfloat* n, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat* n, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiTexCoord2fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* n, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BlendFuncSeparateEXT(GL.Enums.EXT_blend_func_separate sfactorRGB, GL.Enums.EXT_blend_func_separate dfactorRGB, GL.Enums.EXT_blend_func_separate sfactorAlpha, GL.Enums.EXT_blend_func_separate dfactorAlpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BlendFuncSeparateINGR(GL.Enums.GLenum sfactorRGB, GL.Enums.GLenum dfactorRGB, GL.Enums.GLenum sfactorAlpha, GL.Enums.GLenum dfactorAlpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexWeightfEXT(GLfloat weight);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexWeightfvEXT(GLfloat* weight);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexWeightPointerEXT(GLsizei size, GL.Enums.EXT_vertex_weighting type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FlushVertexArrayRangeNV();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexArrayRangeNV(GLsizei length, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CombinerParameterfvNV(GL.Enums.NV_register_combiners pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CombinerParameterfNV(GL.Enums.NV_register_combiners pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CombinerParameterivNV(GL.Enums.NV_register_combiners pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CombinerParameteriNV(GL.Enums.NV_register_combiners pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CombinerInputNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners input, GL.Enums.NV_register_combiners mapping, GL.Enums.NV_register_combiners componentUsage);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void CombinerOutputNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners abOutput, GL.Enums.NV_register_combiners cdOutput, GL.Enums.NV_register_combiners sumOutput, GL.Enums.NV_register_combiners scale, GL.Enums.NV_register_combiners bias, GL.Enums.Boolean abDotProduct, GL.Enums.Boolean cdDotProduct, GL.Enums.Boolean muxSum);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FinalCombinerInputNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners input, GL.Enums.NV_register_combiners mapping, GL.Enums.NV_register_combiners componentUsage);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetCombinerInputParameterfvNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetCombinerInputParameterivNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetCombinerOutputParameterfvNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetCombinerOutputParameterivNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetFinalCombinerInputParameterfvNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetFinalCombinerInputParameterivNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ResizeBuffersMESA();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos2dMESA(GLdouble x, GLdouble y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2dvMESA(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos2fMESA(GLfloat x, GLfloat y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2fvMESA(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos2iMESA(GLint x, GLint y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2ivMESA(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos2sMESA(GLshort x, GLshort y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos2svMESA(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos3dMESA(GLdouble x, GLdouble y, GLdouble z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3dvMESA(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos3fMESA(GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3fvMESA(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos3iMESA(GLint x, GLint y, GLint z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3ivMESA(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos3sMESA(GLshort x, GLshort y, GLshort z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos3svMESA(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos4dMESA(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos4dvMESA(GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos4fMESA(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos4fvMESA(GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos4iMESA(GLint x, GLint y, GLint z, GLint w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos4ivMESA(GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WindowPos4sMESA(GLshort x, GLshort y, GLshort z, GLshort w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void WindowPos4svMESA(GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiModeDrawArraysIBM(GL.Enums.BeginMode* mode, GLint* first, GLsizei* count, GLsizei primcount, GLint modestride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiModeDrawElementsIBM(GL.Enums.BeginMode* mode, GLsizei* count, GL.Enums.IBM_multimode_draw_arrays type, void* indices, GLsizei primcount, GLint modestride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ColorPointerListIBM(GLint size, GL.Enums.ColorPointerType type, GLint stride, void* pointer, GLint ptrstride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColorPointerListIBM(GLint size, GL.Enums.IBM_vertex_array_lists type, GLint stride, void* pointer, GLint ptrstride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void EdgeFlagPointerListIBM(GLint stride, GLboolean* pointer, GLint ptrstride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FogCoordPointerListIBM(GL.Enums.IBM_vertex_array_lists type, GLint stride, void* pointer, GLint ptrstride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void IndexPointerListIBM(GL.Enums.IndexPointerType type, GLint stride, void* pointer, GLint ptrstride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void NormalPointerListIBM(GL.Enums.NormalPointerType type, GLint stride, void* pointer, GLint ptrstride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoordPointerListIBM(GLint size, GL.Enums.TexCoordPointerType type, GLint stride, void* pointer, GLint ptrstride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexPointerListIBM(GLint size, GL.Enums.VertexPointerType type, GLint stride, void* pointer, GLint ptrstride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TbufferMask3DFX(GLuint mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SampleMaskEXT(GLclampf value, GL.Enums.Boolean invert);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SamplePatternEXT(GL.Enums.EXT_multisample pattern);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TextureColorMaskSGIS(GL.Enums.Boolean red, GL.Enums.Boolean green, GL.Enums.Boolean blue, GL.Enums.Boolean alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void IglooInterfaceSGIX(GL.Enums.GLenum pname, void* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DeleteFencesNV(GLsizei n, GLuint* fences);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GenFencesNV(GLsizei n, GLuint* fences);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsFenceNV(GLuint fence);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean TestFenceNV(GLuint fence);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetFenceivNV(GLuint fence, GL.Enums.NV_fence pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FinishFenceNV(GLuint fence);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SetFenceNV(GLuint fence, GL.Enums.NV_fence condition);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MapControlPointsNV(GL.Enums.NV_evaluators target, GLuint index, GL.Enums.NV_evaluators type, GLsizei ustride, GLsizei vstride, GLint uorder, GLint vorder, GL.Enums.Boolean packed, void* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MapParameterivNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MapParameterfvNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetMapControlPointsNV(GL.Enums.NV_evaluators target, GLuint index, GL.Enums.NV_evaluators type, GLsizei ustride, GLsizei vstride, GL.Enums.Boolean packed, void* points);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetMapParameterivNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetMapParameterfvNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetMapAttribParameterivNV(GL.Enums.NV_evaluators target, GLuint index, GL.Enums.NV_evaluators pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetMapAttribParameterfvNV(GL.Enums.NV_evaluators target, GLuint index, GL.Enums.NV_evaluators pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EvalMapsNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators mode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void CombinerStageParameterfvNV(GL.Enums.NV_register_combiners2 stage, GL.Enums.NV_register_combiners2 pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetCombinerStageParameterfvNV(GL.Enums.NV_register_combiners2 stage, GL.Enums.NV_register_combiners2 pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe GLboolean AreProgramsResidentNV(GLsizei n, GLuint* programs, GL.Enums.Boolean* residences);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BindProgramNV(GL.Enums.NV_vertex_program target, GLuint id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DeleteProgramsNV(GLsizei n, GLuint* programs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ExecuteProgramNV(GL.Enums.NV_vertex_program target, GLuint id, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GenProgramsNV(GLsizei n, GLuint* programs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramParameterdvNV(GL.Enums.NV_vertex_program target, GLuint index, GL.Enums.NV_vertex_program pname, GLdouble* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramParameterfvNV(GL.Enums.NV_vertex_program target, GLuint index, GL.Enums.NV_vertex_program pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramivNV(GLuint id, GL.Enums.NV_vertex_program pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramStringNV(GLuint id, GL.Enums.NV_vertex_program pname, GLubyte* program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTrackMatrixivNV(GL.Enums.NV_vertex_program target, GLuint address, GL.Enums.NV_vertex_program pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribdvNV(GLuint index, GL.Enums.NV_vertex_program pname, GLdouble* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribfvNV(GLuint index, GL.Enums.NV_vertex_program pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribivNV(GLuint index, GL.Enums.NV_vertex_program pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribPointervNV(GLuint index, GL.Enums.NV_vertex_program pname, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsProgramNV(GLuint id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void LoadProgramNV(GL.Enums.NV_vertex_program target, GLuint id, GLsizei len, GLubyte* program);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ProgramParameter4dNV(GL.Enums.NV_vertex_program target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramParameter4dvNV(GL.Enums.NV_vertex_program target, GLuint index, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ProgramParameter4fNV(GL.Enums.NV_vertex_program target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramParameter4fvNV(GL.Enums.NV_vertex_program target, GLuint index, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramParameters4dvNV(GL.Enums.NV_vertex_program target, GLuint index, GLuint count, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramParameters4fvNV(GL.Enums.NV_vertex_program target, GLuint index, GLuint count, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void RequestResidentProgramsNV(GLsizei n, GLuint* programs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TrackMatrixNV(GL.Enums.NV_vertex_program target, GLuint address, GL.Enums.NV_vertex_program matrix, GL.Enums.NV_vertex_program transform);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribPointerNV(GLuint index, GLint fsize, GL.Enums.NV_vertex_program type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib1dNV(GLuint index, GLdouble x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1dvNV(GLuint index, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib1fNV(GLuint index, GLfloat x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1fvNV(GLuint index, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib1sNV(GLuint index, GLshort x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1svNV(GLuint index, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib2dNV(GLuint index, GLdouble x, GLdouble y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2dvNV(GLuint index, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib2fNV(GLuint index, GLfloat x, GLfloat y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2fvNV(GLuint index, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib2sNV(GLuint index, GLshort x, GLshort y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2svNV(GLuint index, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib3dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3dvNV(GLuint index, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib3fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3fvNV(GLuint index, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib3sNV(GLuint index, GLshort x, GLshort y, GLshort z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3svNV(GLuint index, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib4dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4dvNV(GLuint index, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib4fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4fvNV(GLuint index, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib4sNV(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4svNV(GLuint index, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib4ubNV(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4ubvNV(GLuint index, GLubyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs1dvNV(GLuint index, GLsizei count, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs1fvNV(GLuint index, GLsizei count, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs1svNV(GLuint index, GLsizei count, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs2dvNV(GLuint index, GLsizei count, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs2fvNV(GLuint index, GLsizei count, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs2svNV(GLuint index, GLsizei count, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs3dvNV(GLuint index, GLsizei count, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs3fvNV(GLuint index, GLsizei count, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs3svNV(GLuint index, GLsizei count, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs4dvNV(GLuint index, GLsizei count, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs4fvNV(GLuint index, GLsizei count, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs4svNV(GLuint index, GLsizei count, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs4ubvNV(GLuint index, GLsizei count, GLubyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexBumpParameterivATI(GL.Enums.ATI_envmap_bumpmap pname, GLint* param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexBumpParameterfvATI(GL.Enums.ATI_envmap_bumpmap pname, GLfloat* param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTexBumpParameterivATI(GL.Enums.ATI_envmap_bumpmap pname, GLint* param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTexBumpParameterfvATI(GL.Enums.ATI_envmap_bumpmap pname, GLfloat* param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLuint GenFragmentShadersATI(GLuint range);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BindFragmentShaderATI(GLuint id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DeleteFragmentShaderATI(GLuint id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BeginFragmentShaderATI();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EndFragmentShaderATI();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PassTexCoordATI(GLuint dst, GLuint coord, GL.Enums.ATI_fragment_shader swizzle);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SampleMapATI(GLuint dst, GLuint interp, GL.Enums.ATI_fragment_shader swizzle);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ColorFragmentOp1ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ColorFragmentOp2ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ColorFragmentOp3ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void AlphaFragmentOp1ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void AlphaFragmentOp2ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void AlphaFragmentOp3ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SetFragmentShaderConstantATI(GLuint dst, GLfloat* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PNTrianglesiATI(GL.Enums.ATI_pn_triangles pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PNTrianglesfATI(GL.Enums.ATI_pn_triangles pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe GLuint NewObjectBufferATI(GLsizei size, void* pointer, GL.Enums.ATI_vertex_array_object usage);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsObjectBufferATI(GLuint buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void UpdateObjectBufferATI(GLuint buffer, GLuint offset, GLsizei size, void* pointer, GL.Enums.ATI_vertex_array_object preserve);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetObjectBufferfvATI(GLuint buffer, GL.Enums.ATI_vertex_array_object pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetObjectBufferivATI(GLuint buffer, GL.Enums.ATI_vertex_array_object pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FreeObjectBufferATI(GLuint buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ArrayObjectATI(GL.Enums.EnableCap array, GLint size, GL.Enums.ATI_vertex_array_object type, GLsizei stride, GLuint buffer, GLuint offset);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetArrayObjectfvATI(GL.Enums.EnableCap array, GL.Enums.ATI_vertex_array_object pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetArrayObjectivATI(GL.Enums.EnableCap array, GL.Enums.ATI_vertex_array_object pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VariantArrayObjectATI(GLuint id, GL.Enums.ATI_vertex_array_object type, GLsizei stride, GLuint buffer, GLuint offset);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVariantArrayObjectfvATI(GLuint id, GL.Enums.ATI_vertex_array_object pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVariantArrayObjectivATI(GLuint id, GL.Enums.ATI_vertex_array_object pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BeginVertexShaderEXT();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EndVertexShaderEXT();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BindVertexShaderEXT(GLuint id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLuint GenVertexShadersEXT(GLuint range);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DeleteVertexShaderEXT(GLuint id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ShaderOp1EXT(GL.Enums.EXT_vertex_shader op, GLuint res, GLuint arg1);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ShaderOp2EXT(GL.Enums.EXT_vertex_shader op, GLuint res, GLuint arg1, GLuint arg2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ShaderOp3EXT(GL.Enums.EXT_vertex_shader op, GLuint res, GLuint arg1, GLuint arg2, GLuint arg3);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SwizzleEXT(GLuint res, GLuint @in, GL.Enums.EXT_vertex_shader outX, GL.Enums.EXT_vertex_shader outY, GL.Enums.EXT_vertex_shader outZ, GL.Enums.EXT_vertex_shader outW);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void WriteMaskEXT(GLuint res, GLuint @in, GL.Enums.EXT_vertex_shader outX, GL.Enums.EXT_vertex_shader outY, GL.Enums.EXT_vertex_shader outZ, GL.Enums.EXT_vertex_shader outW);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void InsertComponentEXT(GLuint res, GLuint src, GLuint num);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ExtractComponentEXT(GLuint res, GLuint src, GLuint num);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLuint GenSymbolsEXT(GL.Enums.EXT_vertex_shader datatype, GL.Enums.EXT_vertex_shader storagetype, GL.Enums.EXT_vertex_shader range, GLuint components);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SetInvariantEXT(GLuint id, GL.Enums.EXT_vertex_shader type, void* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SetLocalConstantEXT(GLuint id, GL.Enums.EXT_vertex_shader type, void* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VariantbvEXT(GLuint id, GLbyte* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VariantsvEXT(GLuint id, GLshort* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VariantivEXT(GLuint id, GLint* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VariantfvEXT(GLuint id, GLfloat* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VariantdvEXT(GLuint id, GLdouble* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VariantubvEXT(GLuint id, GLubyte* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VariantusvEXT(GLuint id, GLushort* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VariantuivEXT(GLuint id, GLuint* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VariantPointerEXT(GLuint id, GL.Enums.EXT_vertex_shader type, GLuint stride, void* addr);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EnableVariantClientStateEXT(GLuint id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DisableVariantClientStateEXT(GLuint id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLuint BindLightParameterEXT(GL.Enums.LightName light, GL.Enums.LightParameter value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLuint BindMaterialParameterEXT(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLuint BindTexGenParameterEXT(GL.Enums.EXT_vertex_shader unit, GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLuint BindTextureUnitParameterEXT(GL.Enums.EXT_vertex_shader unit, GL.Enums.EXT_vertex_shader value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLuint BindParameterEXT(GL.Enums.EXT_vertex_shader value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsVariantEnabledEXT(GLuint id, GL.Enums.EXT_vertex_shader cap);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVariantBooleanvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GL.Enums.Boolean* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVariantIntegervEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLint* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVariantFloatvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLfloat* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVariantPointervEXT(GLuint id, GL.Enums.EXT_vertex_shader value, void* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetInvariantBooleanvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GL.Enums.Boolean* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetInvariantIntegervEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLint* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetInvariantFloatvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLfloat* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetLocalConstantBooleanvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GL.Enums.Boolean* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetLocalConstantIntegervEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLint* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetLocalConstantFloatvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLfloat* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexStream1sATI(GL.Enums.ATI_vertex_streams stream, GLshort x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexStream1svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexStream1iATI(GL.Enums.ATI_vertex_streams stream, GLint x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexStream1ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexStream1fATI(GL.Enums.ATI_vertex_streams stream, GLfloat x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexStream1fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexStream1dATI(GL.Enums.ATI_vertex_streams stream, GLdouble x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexStream1dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexStream2sATI(GL.Enums.ATI_vertex_streams stream, GLshort x, GLshort y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexStream2svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexStream2iATI(GL.Enums.ATI_vertex_streams stream, GLint x, GLint y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexStream2ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexStream2fATI(GL.Enums.ATI_vertex_streams stream, GLfloat x, GLfloat y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexStream2fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexStream2dATI(GL.Enums.ATI_vertex_streams stream, GLdouble x, GLdouble y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexStream2dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexStream3sATI(GL.Enums.ATI_vertex_streams stream, GLshort x, GLshort y, GLshort z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexStream3svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexStream3iATI(GL.Enums.ATI_vertex_streams stream, GLint x, GLint y, GLint z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexStream3ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexStream3fATI(GL.Enums.ATI_vertex_streams stream, GLfloat x, GLfloat y, GLfloat z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexStream3fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexStream3dATI(GL.Enums.ATI_vertex_streams stream, GLdouble x, GLdouble y, GLdouble z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexStream3dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexStream4sATI(GL.Enums.ATI_vertex_streams stream, GLshort x, GLshort y, GLshort z, GLshort w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexStream4svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexStream4iATI(GL.Enums.ATI_vertex_streams stream, GLint x, GLint y, GLint z, GLint w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexStream4ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexStream4fATI(GL.Enums.ATI_vertex_streams stream, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexStream4fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexStream4dATI(GL.Enums.ATI_vertex_streams stream, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexStream4dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void NormalStream3bATI(GL.Enums.ATI_vertex_streams stream, GLbyte nx, GLbyte ny, GLbyte nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void NormalStream3bvATI(GL.Enums.ATI_vertex_streams stream, GLbyte* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void NormalStream3sATI(GL.Enums.ATI_vertex_streams stream, GLshort nx, GLshort ny, GLshort nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void NormalStream3svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void NormalStream3iATI(GL.Enums.ATI_vertex_streams stream, GLint nx, GLint ny, GLint nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void NormalStream3ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void NormalStream3fATI(GL.Enums.ATI_vertex_streams stream, GLfloat nx, GLfloat ny, GLfloat nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void NormalStream3fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void NormalStream3dATI(GL.Enums.ATI_vertex_streams stream, GLdouble nx, GLdouble ny, GLdouble nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void NormalStream3dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ClientActiveVertexStreamATI(GL.Enums.ATI_vertex_streams stream);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexBlendEnviATI(GL.Enums.ATI_vertex_streams pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexBlendEnvfATI(GL.Enums.ATI_vertex_streams pname, GLfloat param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ElementPointerATI(GL.Enums.ATI_element_array type, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DrawElementArrayATI(GL.Enums.BeginMode mode, GLsizei count);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DrawRangeElementArrayATI(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DrawMeshArraysSUN(GL.Enums.BeginMode mode, GLint first, GLsizei count, GLsizei width);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GenOcclusionQueriesNV(GLsizei n, GLuint* ids);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DeleteOcclusionQueriesNV(GLsizei n, GLuint* ids);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsOcclusionQueryNV(GLuint id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BeginOcclusionQueryNV(GLuint id);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EndOcclusionQueryNV();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetOcclusionQueryivNV(GLuint id, GL.Enums.NV_occlusion_query pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetOcclusionQueryuivNV(GLuint id, GL.Enums.NV_occlusion_query pname, GLuint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PointParameteriNV(GL.Enums.NV_point_sprite pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PointParameterivNV(GL.Enums.NV_point_sprite pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ActiveStencilFaceEXT(GL.Enums.EXT_stencil_two_side face);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ElementPointerAPPLE(GL.Enums.APPLE_element_array type, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DrawElementArrayAPPLE(GL.Enums.BeginMode mode, GLint first, GLsizei count);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DrawRangeElementArrayAPPLE(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLint first, GLsizei count);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiDrawElementArrayAPPLE(GL.Enums.BeginMode mode, GLint* first, GLsizei* count, GLsizei primcount);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiDrawRangeElementArrayAPPLE(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLint* first, GLsizei* count, GLsizei primcount);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GenFencesAPPLE(GLsizei n, GLuint* fences);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DeleteFencesAPPLE(GLsizei n, GLuint* fences);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SetFenceAPPLE(GLuint fence);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsFenceAPPLE(GLuint fence);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean TestFenceAPPLE(GLuint fence);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FinishFenceAPPLE(GLuint fence);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean TestObjectAPPLE(GL.Enums.APPLE_fence @object, GLuint name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FinishObjectAPPLE(GL.Enums.APPLE_fence @object, GLint name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BindVertexArrayAPPLE(GLuint array);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DeleteVertexArraysAPPLE(GLsizei n, GLuint* arrays);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GenVertexArraysAPPLE(GLsizei n, GLuint* arrays);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsVertexArrayAPPLE(GLuint array);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexArrayRangeAPPLE(GLsizei length, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FlushVertexArrayRangeAPPLE(GLsizei length, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexArrayParameteriAPPLE(GL.Enums.APPLE_vertex_array_range pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DrawBuffersATI(GLsizei n, GL.Enums.ATI_draw_buffers* bufs);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramNamedParameter4fNV(GLuint id, GLsizei len, GLubyte* name, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramNamedParameter4dNV(GLuint id, GLsizei len, GLubyte* name, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramNamedParameter4fvNV(GLuint id, GLsizei len, GLubyte* name, GLfloat* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramNamedParameter4dvNV(GLuint id, GLsizei len, GLubyte* name, GLdouble* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramNamedParameterfvNV(GLuint id, GLsizei len, GLubyte* name, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramNamedParameterdvNV(GLuint id, GLsizei len, GLubyte* name, GLdouble* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Vertex2hNV(GLhalfNV x, GLhalfNV y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Vertex2hvNV(GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Vertex3hNV(GLhalfNV x, GLhalfNV y, GLhalfNV z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Vertex3hvNV(GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Vertex4hNV(GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Vertex4hvNV(GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Normal3hNV(GLhalfNV nx, GLhalfNV ny, GLhalfNV nz);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Normal3hvNV(GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color3hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color3hvNV(GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Color4hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue, GLhalfNV alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Color4hvNV(GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord1hNV(GLhalfNV s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord1hvNV(GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord2hNV(GLhalfNV s, GLhalfNV t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord2hvNV(GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord3hNV(GLhalfNV s, GLhalfNV t, GLhalfNV r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord3hvNV(GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexCoord4hNV(GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexCoord4hvNV(GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord1hNV(GL.Enums.NV_half_float target, GLhalfNV s);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord1hvNV(GL.Enums.NV_half_float target, GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord2hNV(GL.Enums.NV_half_float target, GLhalfNV s, GLhalfNV t);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord2hvNV(GL.Enums.NV_half_float target, GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord3hNV(GL.Enums.NV_half_float target, GLhalfNV s, GLhalfNV t, GLhalfNV r);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord3hvNV(GL.Enums.NV_half_float target, GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MultiTexCoord4hNV(GL.Enums.NV_half_float target, GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void MultiTexCoord4hvNV(GL.Enums.NV_half_float target, GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FogCoordhNV(GLhalfNV fog);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void FogCoordhvNV(GLhalfNV* fog);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void SecondaryColor3hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void SecondaryColor3hvNV(GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexWeighthNV(GLhalfNV weight);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexWeighthvNV(GLhalfNV* weight);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib1hNV(GLuint index, GLhalfNV x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib1hvNV(GLuint index, GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib2hNV(GLuint index, GLhalfNV x, GLhalfNV y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib2hvNV(GLuint index, GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib3hNV(GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib3hvNV(GLuint index, GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttrib4hNV(GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttrib4hvNV(GLuint index, GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs1hvNV(GLuint index, GLsizei n, GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs2hvNV(GLuint index, GLsizei n, GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs3hvNV(GLuint index, GLsizei n, GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribs4hvNV(GLuint index, GLsizei n, GLhalfNV* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void PixelDataRangeNV(GL.Enums.NV_pixel_data_range target, GLsizei length, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FlushPixelDataRangeNV(GL.Enums.NV_pixel_data_range target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PrimitiveRestartNV();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void PrimitiveRestartIndexNV(GLuint index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void MapObjectBufferATI(GLuint buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void UnmapObjectBufferATI(GLuint buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void StencilOpSeparateATI(GL.Enums.ATI_separate_stencil face, GL.Enums.StencilOp sfail, GL.Enums.StencilOp dpfail, GL.Enums.StencilOp dppass);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void StencilFuncSeparateATI(GL.Enums.StencilFunction frontfunc, GL.Enums.StencilFunction backfunc, GLint @ref, GLuint mask);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttribArrayObjectATI(GLuint index, GLint size, GL.Enums.ATI_vertex_attrib_array_object type, GL.Enums.Boolean normalized, GLsizei stride, GLuint buffer, GLuint offset);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribArrayObjectfvATI(GLuint index, GL.Enums.ATI_vertex_attrib_array_object pname, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribArrayObjectivATI(GLuint index, GL.Enums.ATI_vertex_attrib_array_object pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DepthBoundsEXT(GLclampd zmin, GLclampd zmax);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BlendEquationSeparateEXT(GL.Enums.BlendEquationModeEXT modeRGB, GL.Enums.BlendEquationModeEXT modeAlpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsRenderbufferEXT(GLuint renderbuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BindRenderbufferEXT(GL.Enums.EXT_framebuffer_object target, GLuint renderbuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DeleteRenderbuffersEXT(GLsizei n, GLuint* renderbuffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GenRenderbuffersEXT(GLsizei n, GLuint* renderbuffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void RenderbufferStorageEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.GLenum internalformat, GLsizei width, GLsizei height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetRenderbufferParameterivEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.GLenum pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsFramebufferEXT(GLuint framebuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BindFramebufferEXT(GL.Enums.EXT_framebuffer_object target, GLuint framebuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DeleteFramebuffersEXT(GLsizei n, GLuint* framebuffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GenFramebuffersEXT(GLsizei n, GLuint* framebuffers);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GL.Enums.GLenum CheckFramebufferStatusEXT(GL.Enums.EXT_framebuffer_object target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FramebufferTexture1DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.GLenum textarget, GLuint texture, GLint level);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FramebufferTexture2DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.GLenum textarget, GLuint texture, GLint level);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FramebufferTexture3DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.GLenum textarget, GLuint texture, GLint level, GLint zoffset);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FramebufferRenderbufferEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.EXT_framebuffer_object renderbuffertarget, GLuint renderbuffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetFramebufferAttachmentParameterivEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.GLenum pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void GenerateMipmapEXT(GL.Enums.GLenum target);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void StringMarkerGREMEDY(GLsizei len, void* @string);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void StencilClearTagEXT(GLsizei stencilTagBits, GLuint stencilClearTag);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BlitFramebufferEXT(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GL.Enums.ClearBufferMask mask, GL.Enums.GLenum filter);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void RenderbufferStorageMultisampleEXT(GL.Enums.GLenum target, GLsizei samples, GL.Enums.GLenum internalformat, GLsizei width, GLsizei height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetQueryObjecti64vEXT(GLuint id, GL.Enums.GLenum pname, GLint64EXT* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetQueryObjectui64vEXT(GLuint id, GL.Enums.GLenum pname, GLuint64EXT* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramEnvParameters4fvEXT(GL.Enums.EXT_gpu_program_parameters target, GLuint index, GLsizei count, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramLocalParameters4fvEXT(GL.Enums.EXT_gpu_program_parameters target, GLuint index, GLsizei count, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BufferParameteriAPPLE(GL.Enums.GLenum target, GL.Enums.GLenum pname, GLint param);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FlushMappedBufferRangeAPPLE(GL.Enums.GLenum target, GLintptr offset, GLsizeiptr size);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ProgramLocalParameterI4iNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint x, GLint y, GLint z, GLint w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramLocalParameterI4ivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramLocalParametersI4ivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLsizei count, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ProgramLocalParameterI4uiNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramLocalParameterI4uivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramLocalParametersI4uivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLsizei count, GLuint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ProgramEnvParameterI4iNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint x, GLint y, GLint z, GLint w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramEnvParameterI4ivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramEnvParametersI4ivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLsizei count, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ProgramEnvParameterI4uiNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramEnvParameterI4uivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramEnvParametersI4uivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLsizei count, GLuint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramLocalParameterIivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramLocalParameterIuivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramEnvParameterIivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetProgramEnvParameterIuivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ProgramVertexLimitNV(GL.Enums.NV_geometry_program4 target, GLint limit);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FramebufferTextureEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, GLuint texture, GLint level);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FramebufferTextureLayerEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, GLuint texture, GLint level, GLint layer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void FramebufferTextureFaceEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, GLuint texture, GLint level, GL.Enums.TextureTarget face);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ProgramParameteriEXT(GLuint program, GL.Enums.EXT_geometry_shader4 pname, GLint value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttribI1iEXT(GLuint index, GLint x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttribI2iEXT(GLuint index, GLint x, GLint y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttribI3iEXT(GLuint index, GLint x, GLint y, GLint z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttribI4iEXT(GLuint index, GLint x, GLint y, GLint z, GLint w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttribI1uiEXT(GLuint index, GLuint x);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttribI2uiEXT(GLuint index, GLuint x, GLuint y);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttribI3uiEXT(GLuint index, GLuint x, GLuint y, GLuint z);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void VertexAttribI4uiEXT(GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI1ivEXT(GLuint index, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI2ivEXT(GLuint index, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI3ivEXT(GLuint index, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI4ivEXT(GLuint index, GLint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI1uivEXT(GLuint index, GLuint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI2uivEXT(GLuint index, GLuint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI3uivEXT(GLuint index, GLuint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI4uivEXT(GLuint index, GLuint* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI4bvEXT(GLuint index, GLbyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI4svEXT(GLuint index, GLshort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI4ubvEXT(GLuint index, GLubyte* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribI4usvEXT(GLuint index, GLushort* v);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void VertexAttribIPointerEXT(GLuint index, GLint size, GL.Enums.NV_vertex_program4 type, GLsizei stride, void* pointer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribIivEXT(GLuint index, GL.Enums.NV_vertex_program4 pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetVertexAttribIuivEXT(GLuint index, GL.Enums.NV_vertex_program4 pname, GLuint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetUniformuivEXT(GLuint program, GLint location, GLuint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void BindFragDataLocationEXT(GLuint program, GLuint color, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe GLint GetFragDataLocationEXT(GLuint program, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform1uiEXT(GLint location, GLuint v0);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform2uiEXT(GLint location, GLuint v0, GLuint v1);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform3uiEXT(GLint location, GLuint v0, GLuint v1, GLuint v2);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void Uniform4uiEXT(GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform1uivEXT(GLint location, GLsizei count, GLuint* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform2uivEXT(GLint location, GLsizei count, GLuint* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform3uivEXT(GLint location, GLsizei count, GLuint* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void Uniform4uivEXT(GLint location, GLsizei count, GLuint* value);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DrawArraysInstancedEXT(GL.Enums.BeginMode mode, GLint start, GLsizei count, GLsizei primcount);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void DrawElementsInstancedEXT(GL.Enums.BeginMode mode, GLsizei count, GL.Enums.EXT_draw_instanced type, void* indices, GLsizei primcount);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void TexBufferEXT(GL.Enums.TextureTarget target, GL.Enums.GLenum internalformat, GLuint buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DepthRangedNV(GLdouble zNear, GLdouble zFar);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ClearDepthdNV(GLdouble depth);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DepthBoundsdNV(GLdouble zmin, GLdouble zmax);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void RenderbufferStorageMultisampleCoverageNV(GL.Enums.NV_framebuffer_multisample_coverage target, GLsizei coverageSamples, GLsizei colorSamples, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramBufferParametersfvNV(GL.Enums.NV_parameter_buffer_object target, GLuint buffer, GLuint index, GLsizei count, GLfloat* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramBufferParametersIivNV(GL.Enums.NV_parameter_buffer_object target, GLuint buffer, GLuint index, GLsizei count, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ProgramBufferParametersIuivNV(GL.Enums.NV_parameter_buffer_object target, GLuint buffer, GLuint index, GLsizei count, GLuint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ColorMaskIndexedEXT(GLuint index, GL.Enums.Boolean r, GL.Enums.Boolean g, GL.Enums.Boolean b, GL.Enums.Boolean a);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetBooleanIndexedvEXT(GL.Enums.GLenum target, GLuint index, GL.Enums.Boolean* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetIntegerIndexedvEXT(GL.Enums.GLenum target, GLuint index, GLint* data);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EnableIndexedEXT(GL.Enums.GLenum target, GLuint index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void DisableIndexedEXT(GL.Enums.GLenum target, GLuint index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLboolean IsEnabledIndexedEXT(GL.Enums.GLenum target, GLuint index);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BeginTransformFeedbackNV(GL.Enums.GLenum primitiveMode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void EndTransformFeedbackNV();
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TransformFeedbackAttribsNV(GLuint count, GLint* attribs, GL.Enums.GLenum bufferMode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BindBufferRangeNV(GL.Enums.GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BindBufferOffsetNV(GL.Enums.GLenum target, GLuint index, GLuint buffer, GLintptr offset);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void BindBufferBaseNV(GL.Enums.GLenum target, GLuint index, GLuint buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TransformFeedbackVaryingsNV(GLuint program, GLsizei count, GLint* locations, GL.Enums.GLenum bufferMode);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void ActiveVaryingNV(GLuint program, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe GLint GetVaryingLocationNV(GLuint program, System.String name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetActiveVaryingNV(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GL.Enums.GLenum* type, System.Text.StringBuilder name);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTransformFeedbackVaryingNV(GLuint program, GLuint index, GLint* location);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void UniformBufferEXT(GLuint program, GLint location, GLuint buffer);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLint GetUniformBufferSizeEXT(GLuint program, GLint location);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static GLintptr GetUniformOffsetEXT(GLuint program, GLint location);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexParameterIivEXT(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void TexParameterIuivEXT(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLuint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTexParameterIivEXT(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, GLint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static unsafe void GetTexParameterIuivEXT(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, GLuint* @params);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ClearColorIiEXT(GLint red, GLint green, GLint blue, GLint alpha);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGL", ExactSpelling = true)]
        internal extern static void ClearColorIuiEXT(GLuint red, GLuint green, GLuint blue, GLuint alpha);
    }
}
