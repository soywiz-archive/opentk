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

    internal static class Delegates
    {
        static Delegates()
        {
            GL.ReloadFunctions();
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NewList(GLuint list, GL.Enums.ListMode mode);
        internal static NewList glNewList;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndList();
        internal static EndList glEndList;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CallList(GLuint list);
        internal static CallList glCallList;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CallLists(GLsizei n, GL.Enums.ListNameType type, void* lists);
        internal static CallLists glCallLists;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteLists(GLuint list, GLsizei range);
        internal static DeleteLists glDeleteLists;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLuint GenLists(GLsizei range);
        internal static GenLists glGenLists;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ListBase(GLuint @base);
        internal static ListBase glListBase;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Begin(GL.Enums.BeginMode mode);
        internal static Begin glBegin;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Bitmap(GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, GLubyte* bitmap);
        internal static Bitmap glBitmap;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3b(GLbyte red, GLbyte green, GLbyte blue);
        internal static Color3b glColor3b;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3bv(GLbyte* v);
        internal static Color3bv glColor3bv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3d(GLdouble red, GLdouble green, GLdouble blue);
        internal static Color3d glColor3d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3dv(GLdouble* v);
        internal static Color3dv glColor3dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3f(GLfloat red, GLfloat green, GLfloat blue);
        internal static Color3f glColor3f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3fv(GLfloat* v);
        internal static Color3fv glColor3fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3i(GLint red, GLint green, GLint blue);
        internal static Color3i glColor3i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3iv(GLint* v);
        internal static Color3iv glColor3iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3s(GLshort red, GLshort green, GLshort blue);
        internal static Color3s glColor3s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3sv(GLshort* v);
        internal static Color3sv glColor3sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3ub(GLubyte red, GLubyte green, GLubyte blue);
        internal static Color3ub glColor3ub;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3ubv(GLubyte* v);
        internal static Color3ubv glColor3ubv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3ui(GLuint red, GLuint green, GLuint blue);
        internal static Color3ui glColor3ui;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3uiv(GLuint* v);
        internal static Color3uiv glColor3uiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3us(GLushort red, GLushort green, GLushort blue);
        internal static Color3us glColor3us;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3usv(GLushort* v);
        internal static Color3usv glColor3usv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4b(GLbyte red, GLbyte green, GLbyte blue, GLbyte alpha);
        internal static Color4b glColor4b;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4bv(GLbyte* v);
        internal static Color4bv glColor4bv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4d(GLdouble red, GLdouble green, GLdouble blue, GLdouble alpha);
        internal static Color4d glColor4d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4dv(GLdouble* v);
        internal static Color4dv glColor4dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4f(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
        internal static Color4f glColor4f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4fv(GLfloat* v);
        internal static Color4fv glColor4fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4i(GLint red, GLint green, GLint blue, GLint alpha);
        internal static Color4i glColor4i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4iv(GLint* v);
        internal static Color4iv glColor4iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4s(GLshort red, GLshort green, GLshort blue, GLshort alpha);
        internal static Color4s glColor4s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4sv(GLshort* v);
        internal static Color4sv glColor4sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4ub(GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha);
        internal static Color4ub glColor4ub;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4ubv(GLubyte* v);
        internal static Color4ubv glColor4ubv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4ui(GLuint red, GLuint green, GLuint blue, GLuint alpha);
        internal static Color4ui glColor4ui;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4uiv(GLuint* v);
        internal static Color4uiv glColor4uiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4us(GLushort red, GLushort green, GLushort blue, GLushort alpha);
        internal static Color4us glColor4us;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4usv(GLushort* v);
        internal static Color4usv glColor4usv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EdgeFlag(GL.Enums.Boolean flag);
        internal static EdgeFlag glEdgeFlag;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EdgeFlagv(GL.Enums.Boolean* flag);
        internal static EdgeFlagv glEdgeFlagv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void End();
        internal static End glEnd;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Indexd(GLdouble c);
        internal static Indexd glIndexd;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Indexdv(GLdouble* c);
        internal static Indexdv glIndexdv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Indexf(GLfloat c);
        internal static Indexf glIndexf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Indexfv(GLfloat* c);
        internal static Indexfv glIndexfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Indexi(GLint c);
        internal static Indexi glIndexi;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Indexiv(GLint* c);
        internal static Indexiv glIndexiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Indexs(GLshort c);
        internal static Indexs glIndexs;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Indexsv(GLshort* c);
        internal static Indexsv glIndexsv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3b(GLbyte nx, GLbyte ny, GLbyte nz);
        internal static Normal3b glNormal3b;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3bv(GLbyte* v);
        internal static Normal3bv glNormal3bv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3d(GLdouble nx, GLdouble ny, GLdouble nz);
        internal static Normal3d glNormal3d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3dv(GLdouble* v);
        internal static Normal3dv glNormal3dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3f(GLfloat nx, GLfloat ny, GLfloat nz);
        internal static Normal3f glNormal3f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3fv(GLfloat* v);
        internal static Normal3fv glNormal3fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3i(GLint nx, GLint ny, GLint nz);
        internal static Normal3i glNormal3i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3iv(GLint* v);
        internal static Normal3iv glNormal3iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3s(GLshort nx, GLshort ny, GLshort nz);
        internal static Normal3s glNormal3s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3sv(GLshort* v);
        internal static Normal3sv glNormal3sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos2d(GLdouble x, GLdouble y);
        internal static RasterPos2d glRasterPos2d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos2dv(GLdouble* v);
        internal static RasterPos2dv glRasterPos2dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos2f(GLfloat x, GLfloat y);
        internal static RasterPos2f glRasterPos2f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos2fv(GLfloat* v);
        internal static RasterPos2fv glRasterPos2fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos2i(GLint x, GLint y);
        internal static RasterPos2i glRasterPos2i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos2iv(GLint* v);
        internal static RasterPos2iv glRasterPos2iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos2s(GLshort x, GLshort y);
        internal static RasterPos2s glRasterPos2s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos2sv(GLshort* v);
        internal static RasterPos2sv glRasterPos2sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos3d(GLdouble x, GLdouble y, GLdouble z);
        internal static RasterPos3d glRasterPos3d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos3dv(GLdouble* v);
        internal static RasterPos3dv glRasterPos3dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos3f(GLfloat x, GLfloat y, GLfloat z);
        internal static RasterPos3f glRasterPos3f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos3fv(GLfloat* v);
        internal static RasterPos3fv glRasterPos3fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos3i(GLint x, GLint y, GLint z);
        internal static RasterPos3i glRasterPos3i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos3iv(GLint* v);
        internal static RasterPos3iv glRasterPos3iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos3s(GLshort x, GLshort y, GLshort z);
        internal static RasterPos3s glRasterPos3s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos3sv(GLshort* v);
        internal static RasterPos3sv glRasterPos3sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        internal static RasterPos4d glRasterPos4d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos4dv(GLdouble* v);
        internal static RasterPos4dv glRasterPos4dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        internal static RasterPos4f glRasterPos4f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos4fv(GLfloat* v);
        internal static RasterPos4fv glRasterPos4fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos4i(GLint x, GLint y, GLint z, GLint w);
        internal static RasterPos4i glRasterPos4i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos4iv(GLint* v);
        internal static RasterPos4iv glRasterPos4iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RasterPos4s(GLshort x, GLshort y, GLshort z, GLshort w);
        internal static RasterPos4s glRasterPos4s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RasterPos4sv(GLshort* v);
        internal static RasterPos4sv glRasterPos4sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Rectd(GLdouble x1, GLdouble y1, GLdouble x2, GLdouble y2);
        internal static Rectd glRectd;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Rectdv(GLdouble* v1, GLdouble* v2);
        internal static Rectdv glRectdv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Rectf(GLfloat x1, GLfloat y1, GLfloat x2, GLfloat y2);
        internal static Rectf glRectf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Rectfv(GLfloat* v1, GLfloat* v2);
        internal static Rectfv glRectfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Recti(GLint x1, GLint y1, GLint x2, GLint y2);
        internal static Recti glRecti;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Rectiv(GLint* v1, GLint* v2);
        internal static Rectiv glRectiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Rects(GLshort x1, GLshort y1, GLshort x2, GLshort y2);
        internal static Rects glRects;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Rectsv(GLshort* v1, GLshort* v2);
        internal static Rectsv glRectsv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord1d(GLdouble s);
        internal static TexCoord1d glTexCoord1d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord1dv(GLdouble* v);
        internal static TexCoord1dv glTexCoord1dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord1f(GLfloat s);
        internal static TexCoord1f glTexCoord1f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord1fv(GLfloat* v);
        internal static TexCoord1fv glTexCoord1fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord1i(GLint s);
        internal static TexCoord1i glTexCoord1i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord1iv(GLint* v);
        internal static TexCoord1iv glTexCoord1iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord1s(GLshort s);
        internal static TexCoord1s glTexCoord1s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord1sv(GLshort* v);
        internal static TexCoord1sv glTexCoord1sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2d(GLdouble s, GLdouble t);
        internal static TexCoord2d glTexCoord2d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2dv(GLdouble* v);
        internal static TexCoord2dv glTexCoord2dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2f(GLfloat s, GLfloat t);
        internal static TexCoord2f glTexCoord2f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fv(GLfloat* v);
        internal static TexCoord2fv glTexCoord2fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2i(GLint s, GLint t);
        internal static TexCoord2i glTexCoord2i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2iv(GLint* v);
        internal static TexCoord2iv glTexCoord2iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2s(GLshort s, GLshort t);
        internal static TexCoord2s glTexCoord2s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2sv(GLshort* v);
        internal static TexCoord2sv glTexCoord2sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord3d(GLdouble s, GLdouble t, GLdouble r);
        internal static TexCoord3d glTexCoord3d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord3dv(GLdouble* v);
        internal static TexCoord3dv glTexCoord3dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord3f(GLfloat s, GLfloat t, GLfloat r);
        internal static TexCoord3f glTexCoord3f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord3fv(GLfloat* v);
        internal static TexCoord3fv glTexCoord3fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord3i(GLint s, GLint t, GLint r);
        internal static TexCoord3i glTexCoord3i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord3iv(GLint* v);
        internal static TexCoord3iv glTexCoord3iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord3s(GLshort s, GLshort t, GLshort r);
        internal static TexCoord3s glTexCoord3s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord3sv(GLshort* v);
        internal static TexCoord3sv glTexCoord3sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4d(GLdouble s, GLdouble t, GLdouble r, GLdouble q);
        internal static TexCoord4d glTexCoord4d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4dv(GLdouble* v);
        internal static TexCoord4dv glTexCoord4dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4f(GLfloat s, GLfloat t, GLfloat r, GLfloat q);
        internal static TexCoord4f glTexCoord4f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4fv(GLfloat* v);
        internal static TexCoord4fv glTexCoord4fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4i(GLint s, GLint t, GLint r, GLint q);
        internal static TexCoord4i glTexCoord4i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4iv(GLint* v);
        internal static TexCoord4iv glTexCoord4iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4s(GLshort s, GLshort t, GLshort r, GLshort q);
        internal static TexCoord4s glTexCoord4s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4sv(GLshort* v);
        internal static TexCoord4sv glTexCoord4sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex2d(GLdouble x, GLdouble y);
        internal static Vertex2d glVertex2d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex2dv(GLdouble* v);
        internal static Vertex2dv glVertex2dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex2f(GLfloat x, GLfloat y);
        internal static Vertex2f glVertex2f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex2fv(GLfloat* v);
        internal static Vertex2fv glVertex2fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex2i(GLint x, GLint y);
        internal static Vertex2i glVertex2i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex2iv(GLint* v);
        internal static Vertex2iv glVertex2iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex2s(GLshort x, GLshort y);
        internal static Vertex2s glVertex2s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex2sv(GLshort* v);
        internal static Vertex2sv glVertex2sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex3d(GLdouble x, GLdouble y, GLdouble z);
        internal static Vertex3d glVertex3d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex3dv(GLdouble* v);
        internal static Vertex3dv glVertex3dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex3f(GLfloat x, GLfloat y, GLfloat z);
        internal static Vertex3f glVertex3f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex3fv(GLfloat* v);
        internal static Vertex3fv glVertex3fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex3i(GLint x, GLint y, GLint z);
        internal static Vertex3i glVertex3i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex3iv(GLint* v);
        internal static Vertex3iv glVertex3iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex3s(GLshort x, GLshort y, GLshort z);
        internal static Vertex3s glVertex3s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex3sv(GLshort* v);
        internal static Vertex3sv glVertex3sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        internal static Vertex4d glVertex4d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex4dv(GLdouble* v);
        internal static Vertex4dv glVertex4dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        internal static Vertex4f glVertex4f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex4fv(GLfloat* v);
        internal static Vertex4fv glVertex4fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex4i(GLint x, GLint y, GLint z, GLint w);
        internal static Vertex4i glVertex4i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex4iv(GLint* v);
        internal static Vertex4iv glVertex4iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex4s(GLshort x, GLshort y, GLshort z, GLshort w);
        internal static Vertex4s glVertex4s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex4sv(GLshort* v);
        internal static Vertex4sv glVertex4sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ClipPlane(GL.Enums.ClipPlaneName plane, GLdouble* equation);
        internal static ClipPlane glClipPlane;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorMaterial(GL.Enums.MaterialFace face, GL.Enums.ColorMaterialParameter mode);
        internal static ColorMaterial glColorMaterial;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CullFace(GL.Enums.CullFaceMode mode);
        internal static CullFace glCullFace;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Fogf(GL.Enums.FogParameter pname, GLfloat param);
        internal static Fogf glFogf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Fogfv(GL.Enums.FogParameter pname, GLfloat* @params);
        internal static Fogfv glFogfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Fogi(GL.Enums.FogParameter pname, GLint param);
        internal static Fogi glFogi;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Fogiv(GL.Enums.FogParameter pname, GLint* @params);
        internal static Fogiv glFogiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FrontFace(GL.Enums.FrontFaceDirection mode);
        internal static FrontFace glFrontFace;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Hint(GL.Enums.HintTarget target, GL.Enums.HintMode mode);
        internal static Hint glHint;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Lightf(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLfloat param);
        internal static Lightf glLightf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Lightfv(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLfloat* @params);
        internal static Lightfv glLightfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Lighti(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLint param);
        internal static Lighti glLighti;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Lightiv(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLint* @params);
        internal static Lightiv glLightiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LightModelf(GL.Enums.LightModelParameter pname, GLfloat param);
        internal static LightModelf glLightModelf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LightModelfv(GL.Enums.LightModelParameter pname, GLfloat* @params);
        internal static LightModelfv glLightModelfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LightModeli(GL.Enums.LightModelParameter pname, GLint param);
        internal static LightModeli glLightModeli;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LightModeliv(GL.Enums.LightModelParameter pname, GLint* @params);
        internal static LightModeliv glLightModeliv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LineStipple(GLint factor, GLushort pattern);
        internal static LineStipple glLineStipple;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LineWidth(GLfloat width);
        internal static LineWidth glLineWidth;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Materialf(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat param);
        internal static Materialf glMaterialf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Materialfv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat* @params);
        internal static Materialfv glMaterialfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Materiali(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint param);
        internal static Materiali glMateriali;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Materialiv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint* @params);
        internal static Materialiv glMaterialiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointSize(GLfloat size);
        internal static PointSize glPointSize;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PolygonMode(GL.Enums.MaterialFace face, GL.Enums.PolygonMode mode);
        internal static PolygonMode glPolygonMode;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PolygonStipple(GLubyte* mask);
        internal static PolygonStipple glPolygonStipple;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Scissor(GLint x, GLint y, GLsizei width, GLsizei height);
        internal static Scissor glScissor;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ShadeModel(GL.Enums.ShadingModel mode);
        internal static ShadeModel glShadeModel;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexParameterf(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLfloat param);
        internal static TexParameterf glTexParameterf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexParameterfv(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLfloat* @params);
        internal static TexParameterfv glTexParameterfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexParameteri(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLint param);
        internal static TexParameteri glTexParameteri;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexParameteriv(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLint* @params);
        internal static TexParameteriv glTexParameteriv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexImage1D(GL.Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal static TexImage1D glTexImage1D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexImage2D(GL.Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal static TexImage2D glTexImage2D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexEnvf(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLfloat param);
        internal static TexEnvf glTexEnvf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexEnvfv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLfloat* @params);
        internal static TexEnvfv glTexEnvfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexEnvi(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLint param);
        internal static TexEnvi glTexEnvi;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexEnviv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLint* @params);
        internal static TexEnviv glTexEnviv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexGend(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLdouble param);
        internal static TexGend glTexGend;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexGendv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLdouble* @params);
        internal static TexGendv glTexGendv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexGenf(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLfloat param);
        internal static TexGenf glTexGenf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexGenfv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLfloat* @params);
        internal static TexGenfv glTexGenfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexGeni(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLint param);
        internal static TexGeni glTexGeni;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexGeniv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLint* @params);
        internal static TexGeniv glTexGeniv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FeedbackBuffer(GLsizei size, GL.Enums.FeedbackType type, GLfloat* buffer);
        internal static FeedbackBuffer glFeedbackBuffer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SelectBuffer(GLsizei size, GLuint* buffer);
        internal static SelectBuffer glSelectBuffer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLint RenderMode(GL.Enums.RenderingMode mode);
        internal static RenderMode glRenderMode;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void InitNames();
        internal static InitNames glInitNames;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LoadName(GLuint name);
        internal static LoadName glLoadName;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PassThrough(GLfloat token);
        internal static PassThrough glPassThrough;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PopName();
        internal static PopName glPopName;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PushName(GLuint name);
        internal static PushName glPushName;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawBuffer(GL.Enums.DrawBufferMode mode);
        internal static DrawBuffer glDrawBuffer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Clear(GL.Enums.ClearBufferMask mask);
        internal static Clear glClear;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearAccum(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
        internal static ClearAccum glClearAccum;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearIndex(GLfloat c);
        internal static ClearIndex glClearIndex;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
        internal static ClearColor glClearColor;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearStencil(GLint s);
        internal static ClearStencil glClearStencil;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearDepth(GLclampd depth);
        internal static ClearDepth glClearDepth;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilMask(GLuint mask);
        internal static StencilMask glStencilMask;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorMask(GL.Enums.Boolean red, GL.Enums.Boolean green, GL.Enums.Boolean blue, GL.Enums.Boolean alpha);
        internal static ColorMask glColorMask;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthMask(GL.Enums.Boolean flag);
        internal static DepthMask glDepthMask;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void IndexMask(GLuint mask);
        internal static IndexMask glIndexMask;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Accum(GL.Enums.AccumOp op, GLfloat value);
        internal static Accum glAccum;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Disable(GL.Enums.EnableCap cap);
        internal static Disable glDisable;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Enable(GL.Enums.EnableCap cap);
        internal static Enable glEnable;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Finish();
        internal static Finish glFinish;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Flush();
        internal static Flush glFlush;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PopAttrib();
        internal static PopAttrib glPopAttrib;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PushAttrib(GL.Enums.AttribMask mask);
        internal static PushAttrib glPushAttrib;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Map1d(GL.Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint stride, GLint order, GLdouble* points);
        internal static Map1d glMap1d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Map1f(GL.Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint stride, GLint order, GLfloat* points);
        internal static Map1f glMap1f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Map2d(GL.Enums.MapTarget target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble* points);
        internal static Map2d glMap2d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Map2f(GL.Enums.MapTarget target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat* points);
        internal static Map2f glMap2f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MapGrid1d(GLint un, GLdouble u1, GLdouble u2);
        internal static MapGrid1d glMapGrid1d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MapGrid1f(GLint un, GLfloat u1, GLfloat u2);
        internal static MapGrid1f glMapGrid1f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MapGrid2d(GLint un, GLdouble u1, GLdouble u2, GLint vn, GLdouble v1, GLdouble v2);
        internal static MapGrid2d glMapGrid2d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MapGrid2f(GLint un, GLfloat u1, GLfloat u2, GLint vn, GLfloat v1, GLfloat v2);
        internal static MapGrid2f glMapGrid2f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalCoord1d(GLdouble u);
        internal static EvalCoord1d glEvalCoord1d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EvalCoord1dv(GLdouble* u);
        internal static EvalCoord1dv glEvalCoord1dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalCoord1f(GLfloat u);
        internal static EvalCoord1f glEvalCoord1f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EvalCoord1fv(GLfloat* u);
        internal static EvalCoord1fv glEvalCoord1fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalCoord2d(GLdouble u, GLdouble v);
        internal static EvalCoord2d glEvalCoord2d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EvalCoord2dv(GLdouble* u);
        internal static EvalCoord2dv glEvalCoord2dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalCoord2f(GLfloat u, GLfloat v);
        internal static EvalCoord2f glEvalCoord2f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EvalCoord2fv(GLfloat* u);
        internal static EvalCoord2fv glEvalCoord2fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalMesh1(GL.Enums.MeshMode1 mode, GLint i1, GLint i2);
        internal static EvalMesh1 glEvalMesh1;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalPoint1(GLint i);
        internal static EvalPoint1 glEvalPoint1;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalMesh2(GL.Enums.MeshMode2 mode, GLint i1, GLint i2, GLint j1, GLint j2);
        internal static EvalMesh2 glEvalMesh2;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalPoint2(GLint i, GLint j);
        internal static EvalPoint2 glEvalPoint2;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AlphaFunc(GL.Enums.AlphaFunction func, GLclampf @ref);
        internal static AlphaFunc glAlphaFunc;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendFunc(GL.Enums.BlendingFactorSrc sfactor, GL.Enums.BlendingFactorDest dfactor);
        internal static BlendFunc glBlendFunc;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LogicOp(GL.Enums.LogicOp opcode);
        internal static LogicOp glLogicOp;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilFunc(GL.Enums.StencilFunction func, GLint @ref, GLuint mask);
        internal static StencilFunc glStencilFunc;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilOp(GL.Enums.StencilOp fail, GL.Enums.StencilOp zfail, GL.Enums.StencilOp zpass);
        internal static StencilOp glStencilOp;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthFunc(GL.Enums.DepthFunction func);
        internal static DepthFunc glDepthFunc;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelZoom(GLfloat xfactor, GLfloat yfactor);
        internal static PixelZoom glPixelZoom;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTransferf(GL.Enums.PixelTransferParameter pname, GLfloat param);
        internal static PixelTransferf glPixelTransferf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTransferi(GL.Enums.PixelTransferParameter pname, GLint param);
        internal static PixelTransferi glPixelTransferi;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelStoref(GL.Enums.PixelStoreParameter pname, GLfloat param);
        internal static PixelStoref glPixelStoref;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelStorei(GL.Enums.PixelStoreParameter pname, GLint param);
        internal static PixelStorei glPixelStorei;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelMapfv(GL.Enums.PixelMap map, GLint mapsize, GLfloat* values);
        internal static PixelMapfv glPixelMapfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelMapuiv(GL.Enums.PixelMap map, GLint mapsize, GLuint* values);
        internal static PixelMapuiv glPixelMapuiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelMapusv(GL.Enums.PixelMap map, GLint mapsize, GLushort* values);
        internal static PixelMapusv glPixelMapusv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReadBuffer(GL.Enums.ReadBufferMode mode);
        internal static ReadBuffer glReadBuffer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyPixels(GLint x, GLint y, GLsizei width, GLsizei height, GL.Enums.PixelCopyType type);
        internal static CopyPixels glCopyPixels;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal static ReadPixels glReadPixels;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawPixels(GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal static DrawPixels glDrawPixels;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBooleanv(GL.Enums.GetPName pname, GL.Enums.Boolean* @params);
        internal static GetBooleanv glGetBooleanv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetClipPlane(GL.Enums.ClipPlaneName plane, GLdouble* equation);
        internal static GetClipPlane glGetClipPlane;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetDoublev(GL.Enums.GetPName pname, GLdouble* @params);
        internal static GetDoublev glGetDoublev;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GL.Enums.GLenum GetError();
        internal static GetError glGetError;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFloatv(GL.Enums.GetPName pname, GLfloat* @params);
        internal static GetFloatv glGetFloatv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetIntegerv(GL.Enums.GetPName pname, GLint* @params);
        internal static GetIntegerv glGetIntegerv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetLightfv(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLfloat* @params);
        internal static GetLightfv glGetLightfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetLightiv(GL.Enums.LightName light, GL.Enums.LightParameter pname, GLint* @params);
        internal static GetLightiv glGetLightiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapdv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, GLdouble* v);
        internal static GetMapdv glGetMapdv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapfv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, GLfloat* v);
        internal static GetMapfv glGetMapfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapiv(GL.Enums.MapTarget target, GL.Enums.GetMapQuery query, GLint* v);
        internal static GetMapiv glGetMapiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMaterialfv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat* @params);
        internal static GetMaterialfv glGetMaterialfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMaterialiv(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint* @params);
        internal static GetMaterialiv glGetMaterialiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPixelMapfv(GL.Enums.PixelMap map, GLfloat* values);
        internal static GetPixelMapfv glGetPixelMapfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPixelMapuiv(GL.Enums.PixelMap map, GLuint* values);
        internal static GetPixelMapuiv glGetPixelMapuiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPixelMapusv(GL.Enums.PixelMap map, GLushort* values);
        internal static GetPixelMapusv glGetPixelMapusv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPolygonStipple(GLubyte* mask);
        internal static GetPolygonStipple glGetPolygonStipple;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate System.IntPtr GetString(GL.Enums.StringName name);
        internal static GetString glGetString;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexEnvfv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLfloat* @params);
        internal static GetTexEnvfv glGetTexEnvfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexEnviv(GL.Enums.TextureEnvTarget target, GL.Enums.TextureEnvParameter pname, GLint* @params);
        internal static GetTexEnviv glGetTexEnviv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexGendv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLdouble* @params);
        internal static GetTexGendv glGetTexGendv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexGenfv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLfloat* @params);
        internal static GetTexGenfv glGetTexGenfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexGeniv(GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter pname, GLint* @params);
        internal static GetTexGeniv glGetTexGeniv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexImage(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal static GetTexImage glGetTexImage;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexParameterfv(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, GLfloat* @params);
        internal static GetTexParameterfv glGetTexParameterfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexParameteriv(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, GLint* @params);
        internal static GetTexParameteriv glGetTexParameteriv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexLevelParameterfv(GL.Enums.TextureTarget target, GLint level, GL.Enums.GetTextureParameter pname, GLfloat* @params);
        internal static GetTexLevelParameterfv glGetTexLevelParameterfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexLevelParameteriv(GL.Enums.TextureTarget target, GLint level, GL.Enums.GetTextureParameter pname, GLint* @params);
        internal static GetTexLevelParameteriv glGetTexLevelParameteriv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsEnabled(GL.Enums.EnableCap cap);
        internal static IsEnabled glIsEnabled;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsList(GLuint list);
        internal static IsList glIsList;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthRange(GLclampd near, GLclampd far);
        internal static DepthRange glDepthRange;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Frustum(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
        internal static Frustum glFrustum;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LoadIdentity();
        internal static LoadIdentity glLoadIdentity;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadMatrixf(GLfloat* m);
        internal static LoadMatrixf glLoadMatrixf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadMatrixd(GLdouble* m);
        internal static LoadMatrixd glLoadMatrixd;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MatrixMode(GL.Enums.MatrixMode mode);
        internal static MatrixMode glMatrixMode;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultMatrixf(GLfloat* m);
        internal static MultMatrixf glMultMatrixf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultMatrixd(GLdouble* m);
        internal static MultMatrixd glMultMatrixd;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Ortho(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
        internal static Ortho glOrtho;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PopMatrix();
        internal static PopMatrix glPopMatrix;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PushMatrix();
        internal static PushMatrix glPushMatrix;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Rotated(GLdouble angle, GLdouble x, GLdouble y, GLdouble z);
        internal static Rotated glRotated;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Rotatef(GLfloat angle, GLfloat x, GLfloat y, GLfloat z);
        internal static Rotatef glRotatef;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Scaled(GLdouble x, GLdouble y, GLdouble z);
        internal static Scaled glScaled;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Scalef(GLfloat x, GLfloat y, GLfloat z);
        internal static Scalef glScalef;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Translated(GLdouble x, GLdouble y, GLdouble z);
        internal static Translated glTranslated;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Translatef(GLfloat x, GLfloat y, GLfloat z);
        internal static Translatef glTranslatef;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Viewport(GLint x, GLint y, GLsizei width, GLsizei height);
        internal static Viewport glViewport;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ArrayElement(GLint i);
        internal static ArrayElement glArrayElement;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorPointer(GLint size, GL.Enums.ColorPointerType type, GLsizei stride, void* pointer);
        internal static ColorPointer glColorPointer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableClientState(GL.Enums.EnableCap array);
        internal static DisableClientState glDisableClientState;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawArrays(GL.Enums.BeginMode mode, GLint first, GLsizei count);
        internal static DrawArrays glDrawArrays;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawElements(GL.Enums.BeginMode mode, GLsizei count, GL.Enums.GLenum type, void* indices);
        internal static DrawElements glDrawElements;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EdgeFlagPointer(GLsizei stride, void* pointer);
        internal static EdgeFlagPointer glEdgeFlagPointer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableClientState(GL.Enums.EnableCap array);
        internal static EnableClientState glEnableClientState;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPointerv(GL.Enums.GetPointervPName pname, void* @params);
        internal static GetPointerv glGetPointerv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void IndexPointer(GL.Enums.IndexPointerType type, GLsizei stride, void* pointer);
        internal static IndexPointer glIndexPointer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void InterleavedArrays(GL.Enums.InterleavedArrayFormat format, GLsizei stride, void* pointer);
        internal static InterleavedArrays glInterleavedArrays;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalPointer(GL.Enums.NormalPointerType type, GLsizei stride, void* pointer);
        internal static NormalPointer glNormalPointer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoordPointer(GLint size, GL.Enums.TexCoordPointerType type, GLsizei stride, void* pointer);
        internal static TexCoordPointer glTexCoordPointer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexPointer(GLint size, GL.Enums.VertexPointerType type, GLsizei stride, void* pointer);
        internal static VertexPointer glVertexPointer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PolygonOffset(GLfloat factor, GLfloat units);
        internal static PolygonOffset glPolygonOffset;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexImage1D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLint border);
        internal static CopyTexImage1D glCopyTexImage1D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexImage2D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
        internal static CopyTexImage2D glCopyTexImage2D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage1D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        internal static CopyTexSubImage1D glCopyTexSubImage1D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage2D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        internal static CopyTexSubImage2D glCopyTexSubImage2D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage1D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal static TexSubImage1D glTexSubImage1D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage2D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal static TexSubImage2D glTexSubImage2D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate GLboolean AreTexturesResident(GLsizei n, GLuint* textures, GL.Enums.Boolean* residences);
        internal static AreTexturesResident glAreTexturesResident;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindTexture(GL.Enums.TextureTarget target, GLuint texture);
        internal static BindTexture glBindTexture;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteTextures(GLsizei n, GLuint* textures);
        internal static DeleteTextures glDeleteTextures;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenTextures(GLsizei n, GLuint* textures);
        internal static GenTextures glGenTextures;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsTexture(GLuint texture);
        internal static IsTexture glIsTexture;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PrioritizeTextures(GLsizei n, GLuint* textures, GLclampf* priorities);
        internal static PrioritizeTextures glPrioritizeTextures;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Indexub(GLubyte c);
        internal static Indexub glIndexub;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Indexubv(GLubyte* c);
        internal static Indexubv glIndexubv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PopClientAttrib();
        internal static PopClientAttrib glPopClientAttrib;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PushClientAttrib(GL.Enums.ClientAttribMask mask);
        internal static PushClientAttrib glPushClientAttrib;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
        internal static BlendColor glBlendColor;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendEquation(GL.Enums.VERSION_1_2 mode);
        internal static BlendEquation glBlendEquation;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawRangeElements(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count, GL.Enums.VERSION_1_2 type, void* indices);
        internal static DrawRangeElements glDrawRangeElements;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table);
        internal static ColorTable glColorTable;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params);
        internal static ColorTableParameterfv glColorTableParameterfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params);
        internal static ColorTableParameteriv glColorTableParameteriv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width);
        internal static CopyColorTable glCopyColorTable;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTable(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table);
        internal static GetColorTable glGetColorTable;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params);
        internal static GetColorTableParameterfv glGetColorTableParameterfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params);
        internal static GetColorTableParameteriv glGetColorTableParameteriv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorSubTable(GL.Enums.VERSION_1_2 target, GLsizei start, GLsizei count, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data);
        internal static ColorSubTable glColorSubTable;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyColorSubTable(GL.Enums.VERSION_1_2 target, GLsizei start, GLint x, GLint y, GLsizei width);
        internal static CopyColorSubTable glCopyColorSubTable;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionFilter1D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
        internal static ConvolutionFilter1D glConvolutionFilter1D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
        internal static ConvolutionFilter2D glConvolutionFilter2D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ConvolutionParameterf(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat @params);
        internal static ConvolutionParameterf glConvolutionParameterf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params);
        internal static ConvolutionParameterfv glConvolutionParameterfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ConvolutionParameteri(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint @params);
        internal static ConvolutionParameteri glConvolutionParameteri;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params);
        internal static ConvolutionParameteriv glConvolutionParameteriv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyConvolutionFilter1D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width);
        internal static CopyConvolutionFilter1D glCopyConvolutionFilter1D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyConvolutionFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height);
        internal static CopyConvolutionFilter2D glCopyConvolutionFilter2D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionFilter(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
        internal static GetConvolutionFilter glGetConvolutionFilter;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params);
        internal static GetConvolutionParameterfv glGetConvolutionParameterfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params);
        internal static GetConvolutionParameteriv glGetConvolutionParameteriv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetSeparableFilter(GL.Enums.VERSION_1_2 target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column, void* span);
        internal static GetSeparableFilter glGetSeparableFilter;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SeparableFilter2D(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column);
        internal static SeparableFilter2D glSeparableFilter2D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogram(GL.Enums.VERSION_1_2 target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* values);
        internal static GetHistogram glGetHistogram;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogramParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params);
        internal static GetHistogramParameterfv glGetHistogramParameterfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogramParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params);
        internal static GetHistogramParameteriv glGetHistogramParameteriv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmax(GL.Enums.VERSION_1_2 target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* values);
        internal static GetMinmax glGetMinmax;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmaxParameterfv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLfloat* @params);
        internal static GetMinmaxParameterfv glGetMinmaxParameterfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmaxParameteriv(GL.Enums.VERSION_1_2 target, GL.Enums.VERSION_1_2 pname, GLint* @params);
        internal static GetMinmaxParameteriv glGetMinmaxParameteriv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Histogram(GL.Enums.VERSION_1_2 target, GLsizei width, GL.Enums.PixelInternalFormat internalformat, GL.Enums.Boolean sink);
        internal static Histogram glHistogram;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Minmax(GL.Enums.VERSION_1_2 target, GL.Enums.PixelInternalFormat internalformat, GL.Enums.Boolean sink);
        internal static Minmax glMinmax;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ResetHistogram(GL.Enums.VERSION_1_2 target);
        internal static ResetHistogram glResetHistogram;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ResetMinmax(GL.Enums.VERSION_1_2 target);
        internal static ResetMinmax glResetMinmax;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexImage3D(GL.Enums.TextureTarget target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal static TexImage3D glTexImage3D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage3D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal static TexSubImage3D glTexSubImage3D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage3D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        internal static CopyTexSubImage3D glCopyTexSubImage3D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ActiveTexture(GL.Enums.VERSION_1_3 texture);
        internal static ActiveTexture glActiveTexture;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClientActiveTexture(GL.Enums.VERSION_1_3 texture);
        internal static ClientActiveTexture glClientActiveTexture;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1d(GL.Enums.VERSION_1_3 target, GLdouble s);
        internal static MultiTexCoord1d glMultiTexCoord1d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1dv(GL.Enums.VERSION_1_3 target, GLdouble* v);
        internal static MultiTexCoord1dv glMultiTexCoord1dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1f(GL.Enums.VERSION_1_3 target, GLfloat s);
        internal static MultiTexCoord1f glMultiTexCoord1f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1fv(GL.Enums.VERSION_1_3 target, GLfloat* v);
        internal static MultiTexCoord1fv glMultiTexCoord1fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1i(GL.Enums.VERSION_1_3 target, GLint s);
        internal static MultiTexCoord1i glMultiTexCoord1i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1iv(GL.Enums.VERSION_1_3 target, GLint* v);
        internal static MultiTexCoord1iv glMultiTexCoord1iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1s(GL.Enums.VERSION_1_3 target, GLshort s);
        internal static MultiTexCoord1s glMultiTexCoord1s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1sv(GL.Enums.VERSION_1_3 target, GLshort* v);
        internal static MultiTexCoord1sv glMultiTexCoord1sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2d(GL.Enums.VERSION_1_3 target, GLdouble s, GLdouble t);
        internal static MultiTexCoord2d glMultiTexCoord2d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2dv(GL.Enums.VERSION_1_3 target, GLdouble* v);
        internal static MultiTexCoord2dv glMultiTexCoord2dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2f(GL.Enums.VERSION_1_3 target, GLfloat s, GLfloat t);
        internal static MultiTexCoord2f glMultiTexCoord2f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2fv(GL.Enums.VERSION_1_3 target, GLfloat* v);
        internal static MultiTexCoord2fv glMultiTexCoord2fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2i(GL.Enums.VERSION_1_3 target, GLint s, GLint t);
        internal static MultiTexCoord2i glMultiTexCoord2i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2iv(GL.Enums.VERSION_1_3 target, GLint* v);
        internal static MultiTexCoord2iv glMultiTexCoord2iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2s(GL.Enums.VERSION_1_3 target, GLshort s, GLshort t);
        internal static MultiTexCoord2s glMultiTexCoord2s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2sv(GL.Enums.VERSION_1_3 target, GLshort* v);
        internal static MultiTexCoord2sv glMultiTexCoord2sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3d(GL.Enums.VERSION_1_3 target, GLdouble s, GLdouble t, GLdouble r);
        internal static MultiTexCoord3d glMultiTexCoord3d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3dv(GL.Enums.VERSION_1_3 target, GLdouble* v);
        internal static MultiTexCoord3dv glMultiTexCoord3dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3f(GL.Enums.VERSION_1_3 target, GLfloat s, GLfloat t, GLfloat r);
        internal static MultiTexCoord3f glMultiTexCoord3f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3fv(GL.Enums.VERSION_1_3 target, GLfloat* v);
        internal static MultiTexCoord3fv glMultiTexCoord3fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3i(GL.Enums.VERSION_1_3 target, GLint s, GLint t, GLint r);
        internal static MultiTexCoord3i glMultiTexCoord3i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3iv(GL.Enums.VERSION_1_3 target, GLint* v);
        internal static MultiTexCoord3iv glMultiTexCoord3iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3s(GL.Enums.VERSION_1_3 target, GLshort s, GLshort t, GLshort r);
        internal static MultiTexCoord3s glMultiTexCoord3s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3sv(GL.Enums.VERSION_1_3 target, GLshort* v);
        internal static MultiTexCoord3sv glMultiTexCoord3sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4d(GL.Enums.VERSION_1_3 target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);
        internal static MultiTexCoord4d glMultiTexCoord4d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4dv(GL.Enums.VERSION_1_3 target, GLdouble* v);
        internal static MultiTexCoord4dv glMultiTexCoord4dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4f(GL.Enums.VERSION_1_3 target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);
        internal static MultiTexCoord4f glMultiTexCoord4f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4fv(GL.Enums.VERSION_1_3 target, GLfloat* v);
        internal static MultiTexCoord4fv glMultiTexCoord4fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4i(GL.Enums.VERSION_1_3 target, GLint s, GLint t, GLint r, GLint q);
        internal static MultiTexCoord4i glMultiTexCoord4i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4iv(GL.Enums.VERSION_1_3 target, GLint* v);
        internal static MultiTexCoord4iv glMultiTexCoord4iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4s(GL.Enums.VERSION_1_3 target, GLshort s, GLshort t, GLshort r, GLshort q);
        internal static MultiTexCoord4s glMultiTexCoord4s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4sv(GL.Enums.VERSION_1_3 target, GLshort* v);
        internal static MultiTexCoord4sv glMultiTexCoord4sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadTransposeMatrixf(GLfloat* m);
        internal static LoadTransposeMatrixf glLoadTransposeMatrixf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadTransposeMatrixd(GLdouble* m);
        internal static LoadTransposeMatrixd glLoadTransposeMatrixd;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultTransposeMatrixf(GLfloat* m);
        internal static MultTransposeMatrixf glMultTransposeMatrixf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultTransposeMatrixd(GLdouble* m);
        internal static MultTransposeMatrixd glMultTransposeMatrixd;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleCoverage(GLclampf value, GL.Enums.Boolean invert);
        internal static SampleCoverage glSampleCoverage;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage3D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data);
        internal static CompressedTexImage3D glCompressedTexImage3D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage2D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data);
        internal static CompressedTexImage2D glCompressedTexImage2D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage1D(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data);
        internal static CompressedTexImage1D glCompressedTexImage1D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage3D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GL.Enums.PixelFormat format, GLsizei imageSize, void* data);
        internal static CompressedTexSubImage3D glCompressedTexSubImage3D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage2D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GLsizei imageSize, void* data);
        internal static CompressedTexSubImage2D glCompressedTexSubImage2D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage1D(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, GL.Enums.PixelFormat format, GLsizei imageSize, void* data);
        internal static CompressedTexSubImage1D glCompressedTexSubImage1D;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCompressedTexImage(GL.Enums.TextureTarget target, GLint level, void* img);
        internal static GetCompressedTexImage glGetCompressedTexImage;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendFuncSeparate(GL.Enums.VERSION_1_4 sfactorRGB, GL.Enums.VERSION_1_4 dfactorRGB, GL.Enums.VERSION_1_4 sfactorAlpha, GL.Enums.VERSION_1_4 dfactorAlpha);
        internal static BlendFuncSeparate glBlendFuncSeparate;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FogCoordf(GLfloat coord);
        internal static FogCoordf glFogCoordf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordfv(GLfloat* coord);
        internal static FogCoordfv glFogCoordfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FogCoordd(GLdouble coord);
        internal static FogCoordd glFogCoordd;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoorddv(GLdouble* coord);
        internal static FogCoorddv glFogCoorddv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordPointer(GL.Enums.VERSION_1_4 type, GLsizei stride, void* pointer);
        internal static FogCoordPointer glFogCoordPointer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawArrays(GL.Enums.BeginMode mode, GLint* first, GLsizei* count, GLsizei primcount);
        internal static MultiDrawArrays glMultiDrawArrays;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawElements(GL.Enums.BeginMode mode, GLsizei* count, GL.Enums.VERSION_1_4 type, void* indices, GLsizei primcount);
        internal static MultiDrawElements glMultiDrawElements;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameterf(GL.Enums.VERSION_1_4 pname, GLfloat param);
        internal static PointParameterf glPointParameterf;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterfv(GL.Enums.VERSION_1_4 pname, GLfloat* @params);
        internal static PointParameterfv glPointParameterfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameteri(GL.Enums.VERSION_1_4 pname, GLint param);
        internal static PointParameteri glPointParameteri;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameteriv(GL.Enums.VERSION_1_4 pname, GLint* @params);
        internal static PointParameteriv glPointParameteriv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3b(GLbyte red, GLbyte green, GLbyte blue);
        internal static SecondaryColor3b glSecondaryColor3b;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3bv(GLbyte* v);
        internal static SecondaryColor3bv glSecondaryColor3bv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3d(GLdouble red, GLdouble green, GLdouble blue);
        internal static SecondaryColor3d glSecondaryColor3d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3dv(GLdouble* v);
        internal static SecondaryColor3dv glSecondaryColor3dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3f(GLfloat red, GLfloat green, GLfloat blue);
        internal static SecondaryColor3f glSecondaryColor3f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3fv(GLfloat* v);
        internal static SecondaryColor3fv glSecondaryColor3fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3i(GLint red, GLint green, GLint blue);
        internal static SecondaryColor3i glSecondaryColor3i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3iv(GLint* v);
        internal static SecondaryColor3iv glSecondaryColor3iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3s(GLshort red, GLshort green, GLshort blue);
        internal static SecondaryColor3s glSecondaryColor3s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3sv(GLshort* v);
        internal static SecondaryColor3sv glSecondaryColor3sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3ub(GLubyte red, GLubyte green, GLubyte blue);
        internal static SecondaryColor3ub glSecondaryColor3ub;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3ubv(GLubyte* v);
        internal static SecondaryColor3ubv glSecondaryColor3ubv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3ui(GLuint red, GLuint green, GLuint blue);
        internal static SecondaryColor3ui glSecondaryColor3ui;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3uiv(GLuint* v);
        internal static SecondaryColor3uiv glSecondaryColor3uiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3us(GLushort red, GLushort green, GLushort blue);
        internal static SecondaryColor3us glSecondaryColor3us;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3usv(GLushort* v);
        internal static SecondaryColor3usv glSecondaryColor3usv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColorPointer(GLint size, GL.Enums.ColorPointerType type, GLsizei stride, void* pointer);
        internal static SecondaryColorPointer glSecondaryColorPointer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2d(GLdouble x, GLdouble y);
        internal static WindowPos2d glWindowPos2d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2dv(GLdouble* v);
        internal static WindowPos2dv glWindowPos2dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2f(GLfloat x, GLfloat y);
        internal static WindowPos2f glWindowPos2f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2fv(GLfloat* v);
        internal static WindowPos2fv glWindowPos2fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2i(GLint x, GLint y);
        internal static WindowPos2i glWindowPos2i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2iv(GLint* v);
        internal static WindowPos2iv glWindowPos2iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2s(GLshort x, GLshort y);
        internal static WindowPos2s glWindowPos2s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2sv(GLshort* v);
        internal static WindowPos2sv glWindowPos2sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3d(GLdouble x, GLdouble y, GLdouble z);
        internal static WindowPos3d glWindowPos3d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3dv(GLdouble* v);
        internal static WindowPos3dv glWindowPos3dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3f(GLfloat x, GLfloat y, GLfloat z);
        internal static WindowPos3f glWindowPos3f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3fv(GLfloat* v);
        internal static WindowPos3fv glWindowPos3fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3i(GLint x, GLint y, GLint z);
        internal static WindowPos3i glWindowPos3i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3iv(GLint* v);
        internal static WindowPos3iv glWindowPos3iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3s(GLshort x, GLshort y, GLshort z);
        internal static WindowPos3s glWindowPos3s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3sv(GLshort* v);
        internal static WindowPos3sv glWindowPos3sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenQueries(GLsizei n, GLuint* ids);
        internal static GenQueries glGenQueries;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteQueries(GLsizei n, GLuint* ids);
        internal static DeleteQueries glDeleteQueries;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsQuery(GLuint id);
        internal static IsQuery glIsQuery;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginQuery(GL.Enums.GLenum target, GLuint id);
        internal static BeginQuery glBeginQuery;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndQuery(GL.Enums.GLenum target);
        internal static EndQuery glEndQuery;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryiv(GL.Enums.GLenum target, GL.Enums.GLenum pname, GLint* @params);
        internal static GetQueryiv glGetQueryiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectiv(GLuint id, GL.Enums.GLenum pname, GLint* @params);
        internal static GetQueryObjectiv glGetQueryObjectiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectuiv(GLuint id, GL.Enums.GLenum pname, GLuint* @params);
        internal static GetQueryObjectuiv glGetQueryObjectuiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBuffer(GL.Enums.VERSION_1_5 target, GLuint buffer);
        internal static BindBuffer glBindBuffer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteBuffers(GLsizei n, GLuint* buffers);
        internal static DeleteBuffers glDeleteBuffers;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenBuffers(GLsizei n, GLuint* buffers);
        internal static GenBuffers glGenBuffers;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsBuffer(GLuint buffer);
        internal static IsBuffer glIsBuffer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BufferData(GL.Enums.VERSION_1_5 target, GLsizeiptr size, void* data, GL.Enums.VERSION_1_5 usage);
        internal static BufferData glBufferData;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BufferSubData(GL.Enums.VERSION_1_5 target, GLintptr offset, GLsizeiptr size, void* data);
        internal static BufferSubData glBufferSubData;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferSubData(GL.Enums.VERSION_1_5 target, GLintptr offset, GLsizeiptr size, void* data);
        internal static GetBufferSubData glGetBufferSubData;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MapBuffer(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 access);
        internal static MapBuffer glMapBuffer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean UnmapBuffer(GL.Enums.VERSION_1_5 target);
        internal static UnmapBuffer glUnmapBuffer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferParameteriv(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 pname, GLint* @params);
        internal static GetBufferParameteriv glGetBufferParameteriv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferPointerv(GL.Enums.VERSION_1_5 target, GL.Enums.VERSION_1_5 pname, void* @params);
        internal static GetBufferPointerv glGetBufferPointerv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendEquationSeparate(GL.Enums.BlendEquationModeEXT modeRGB, GL.Enums.BlendEquationModeEXT modeAlpha);
        internal static BlendEquationSeparate glBlendEquationSeparate;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawBuffers(GLsizei n, GL.Enums.VERSION_2_0* bufs);
        internal static DrawBuffers glDrawBuffers;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilOpSeparate(GL.Enums.VERSION_2_0 face, GL.Enums.StencilOp sfail, GL.Enums.StencilOp dpfail, GL.Enums.StencilOp dppass);
        internal static StencilOpSeparate glStencilOpSeparate;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilFuncSeparate(GL.Enums.StencilFunction frontfunc, GL.Enums.StencilFunction backfunc, GLint @ref, GLuint mask);
        internal static StencilFuncSeparate glStencilFuncSeparate;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilMaskSeparate(GL.Enums.VERSION_2_0 face, GLuint mask);
        internal static StencilMaskSeparate glStencilMaskSeparate;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AttachShader(GLuint program, GLuint shader);
        internal static AttachShader glAttachShader;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BindAttribLocation(GLuint program, GLuint index, System.String name);
        internal static BindAttribLocation glBindAttribLocation;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CompileShader(GLuint shader);
        internal static CompileShader glCompileShader;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLuint CreateProgram();
        internal static CreateProgram glCreateProgram;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLuint CreateShader(GL.Enums.GLenum type);
        internal static CreateShader glCreateShader;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteProgram(GLuint program);
        internal static DeleteProgram glDeleteProgram;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteShader(GLuint shader);
        internal static DeleteShader glDeleteShader;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DetachShader(GLuint program, GLuint shader);
        internal static DetachShader glDetachShader;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableVertexAttribArray(GLuint index);
        internal static DisableVertexAttribArray glDisableVertexAttribArray;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableVertexAttribArray(GLuint index);
        internal static EnableVertexAttribArray glEnableVertexAttribArray;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveAttrib(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GL.Enums.GLenum* type, System.Text.StringBuilder name);
        internal static GetActiveAttrib glGetActiveAttrib;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveUniform(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GL.Enums.GLenum* type, System.Text.StringBuilder name);
        internal static GetActiveUniform glGetActiveUniform;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetAttachedShaders(GLuint program, GLsizei maxCount, GLsizei* count, GLuint* obj);
        internal static GetAttachedShaders glGetAttachedShaders;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate GLint GetAttribLocation(GLuint program, System.String name);
        internal static GetAttribLocation glGetAttribLocation;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramiv(GLuint program, GL.Enums.GLenum pname, GLint* @params);
        internal static GetProgramiv glGetProgramiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramInfoLog(GLuint program, GLsizei bufSize, GLsizei* length, System.Text.StringBuilder infoLog);
        internal static GetProgramInfoLog glGetProgramInfoLog;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetShaderiv(GLuint shader, GL.Enums.GLenum pname, GLint* @params);
        internal static GetShaderiv glGetShaderiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetShaderInfoLog(GLuint shader, GLsizei bufSize, GLsizei* length, System.Text.StringBuilder infoLog);
        internal static GetShaderInfoLog glGetShaderInfoLog;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetShaderSource(GLuint shader, GLsizei bufSize, GLsizei* length, System.Text.StringBuilder source);
        internal static GetShaderSource glGetShaderSource;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate GLint GetUniformLocation(GLuint program, System.String name);
        internal static GetUniformLocation glGetUniformLocation;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformfv(GLuint program, GLint location, GLfloat* @params);
        internal static GetUniformfv glGetUniformfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformiv(GLuint program, GLint location, GLint* @params);
        internal static GetUniformiv glGetUniformiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribdv(GLuint index, GL.Enums.VERSION_2_0 pname, GLdouble* @params);
        internal static GetVertexAttribdv glGetVertexAttribdv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribfv(GLuint index, GL.Enums.VERSION_2_0 pname, GLfloat* @params);
        internal static GetVertexAttribfv glGetVertexAttribfv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribiv(GLuint index, GL.Enums.VERSION_2_0 pname, GLint* @params);
        internal static GetVertexAttribiv glGetVertexAttribiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribPointerv(GLuint index, GL.Enums.VERSION_2_0 pname, void* pointer);
        internal static GetVertexAttribPointerv glGetVertexAttribPointerv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsProgram(GLuint program);
        internal static IsProgram glIsProgram;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsShader(GLuint shader);
        internal static IsShader glIsShader;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LinkProgram(GLuint program);
        internal static LinkProgram glLinkProgram;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ShaderSource(GLuint shader, GLsizei count, System.String @string, GLint* length);
        internal static ShaderSource glShaderSource;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UseProgram(GLuint program);
        internal static UseProgram glUseProgram;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1f(GLint location, GLfloat v0);
        internal static Uniform1f glUniform1f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2f(GLint location, GLfloat v0, GLfloat v1);
        internal static Uniform2f glUniform2f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
        internal static Uniform3f glUniform3f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
        internal static Uniform4f glUniform4f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1i(GLint location, GLint v0);
        internal static Uniform1i glUniform1i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2i(GLint location, GLint v0, GLint v1);
        internal static Uniform2i glUniform2i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3i(GLint location, GLint v0, GLint v1, GLint v2);
        internal static Uniform3i glUniform3i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4i(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
        internal static Uniform4i glUniform4i;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1fv(GLint location, GLsizei count, GLfloat* value);
        internal static Uniform1fv glUniform1fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2fv(GLint location, GLsizei count, GLfloat* value);
        internal static Uniform2fv glUniform2fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3fv(GLint location, GLsizei count, GLfloat* value);
        internal static Uniform3fv glUniform3fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4fv(GLint location, GLsizei count, GLfloat* value);
        internal static Uniform4fv glUniform4fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1iv(GLint location, GLsizei count, GLint* value);
        internal static Uniform1iv glUniform1iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2iv(GLint location, GLsizei count, GLint* value);
        internal static Uniform2iv glUniform2iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3iv(GLint location, GLsizei count, GLint* value);
        internal static Uniform3iv glUniform3iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4iv(GLint location, GLsizei count, GLint* value);
        internal static Uniform4iv glUniform4iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        internal static UniformMatrix2fv glUniformMatrix2fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        internal static UniformMatrix3fv glUniformMatrix3fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        internal static UniformMatrix4fv glUniformMatrix4fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ValidateProgram(GLuint program);
        internal static ValidateProgram glValidateProgram;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1d(GLuint index, GLdouble x);
        internal static VertexAttrib1d glVertexAttrib1d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1dv(GLuint index, GLdouble* v);
        internal static VertexAttrib1dv glVertexAttrib1dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1f(GLuint index, GLfloat x);
        internal static VertexAttrib1f glVertexAttrib1f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1fv(GLuint index, GLfloat* v);
        internal static VertexAttrib1fv glVertexAttrib1fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1s(GLuint index, GLshort x);
        internal static VertexAttrib1s glVertexAttrib1s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1sv(GLuint index, GLshort* v);
        internal static VertexAttrib1sv glVertexAttrib1sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2d(GLuint index, GLdouble x, GLdouble y);
        internal static VertexAttrib2d glVertexAttrib2d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2dv(GLuint index, GLdouble* v);
        internal static VertexAttrib2dv glVertexAttrib2dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2f(GLuint index, GLfloat x, GLfloat y);
        internal static VertexAttrib2f glVertexAttrib2f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2fv(GLuint index, GLfloat* v);
        internal static VertexAttrib2fv glVertexAttrib2fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2s(GLuint index, GLshort x, GLshort y);
        internal static VertexAttrib2s glVertexAttrib2s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2sv(GLuint index, GLshort* v);
        internal static VertexAttrib2sv glVertexAttrib2sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3d(GLuint index, GLdouble x, GLdouble y, GLdouble z);
        internal static VertexAttrib3d glVertexAttrib3d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3dv(GLuint index, GLdouble* v);
        internal static VertexAttrib3dv glVertexAttrib3dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3f(GLuint index, GLfloat x, GLfloat y, GLfloat z);
        internal static VertexAttrib3f glVertexAttrib3f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3fv(GLuint index, GLfloat* v);
        internal static VertexAttrib3fv glVertexAttrib3fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3s(GLuint index, GLshort x, GLshort y, GLshort z);
        internal static VertexAttrib3s glVertexAttrib3s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3sv(GLuint index, GLshort* v);
        internal static VertexAttrib3sv glVertexAttrib3sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nbv(GLuint index, GLbyte* v);
        internal static VertexAttrib4Nbv glVertexAttrib4Nbv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Niv(GLuint index, GLint* v);
        internal static VertexAttrib4Niv glVertexAttrib4Niv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nsv(GLuint index, GLshort* v);
        internal static VertexAttrib4Nsv glVertexAttrib4Nsv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4Nub(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
        internal static VertexAttrib4Nub glVertexAttrib4Nub;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nubv(GLuint index, GLubyte* v);
        internal static VertexAttrib4Nubv glVertexAttrib4Nubv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nuiv(GLuint index, GLuint* v);
        internal static VertexAttrib4Nuiv glVertexAttrib4Nuiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4Nusv(GLuint index, GLushort* v);
        internal static VertexAttrib4Nusv glVertexAttrib4Nusv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4bv(GLuint index, GLbyte* v);
        internal static VertexAttrib4bv glVertexAttrib4bv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4d(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        internal static VertexAttrib4d glVertexAttrib4d;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4dv(GLuint index, GLdouble* v);
        internal static VertexAttrib4dv glVertexAttrib4dv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4f(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        internal static VertexAttrib4f glVertexAttrib4f;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4fv(GLuint index, GLfloat* v);
        internal static VertexAttrib4fv glVertexAttrib4fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4iv(GLuint index, GLint* v);
        internal static VertexAttrib4iv glVertexAttrib4iv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4s(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
        internal static VertexAttrib4s glVertexAttrib4s;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4sv(GLuint index, GLshort* v);
        internal static VertexAttrib4sv glVertexAttrib4sv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4ubv(GLuint index, GLubyte* v);
        internal static VertexAttrib4ubv glVertexAttrib4ubv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4uiv(GLuint index, GLuint* v);
        internal static VertexAttrib4uiv glVertexAttrib4uiv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4usv(GLuint index, GLushort* v);
        internal static VertexAttrib4usv glVertexAttrib4usv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribPointer(GLuint index, GLint size, GL.Enums.VERSION_2_0 type, GL.Enums.Boolean normalized, GLsizei stride, void* pointer);
        internal static VertexAttribPointer glVertexAttribPointer;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2x3fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        internal static UniformMatrix2x3fv glUniformMatrix2x3fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3x2fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        internal static UniformMatrix3x2fv glUniformMatrix3x2fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2x4fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        internal static UniformMatrix2x4fv glUniformMatrix2x4fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4x2fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        internal static UniformMatrix4x2fv glUniformMatrix4x2fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3x4fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        internal static UniformMatrix3x4fv glUniformMatrix3x4fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4x3fv(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        internal static UniformMatrix4x3fv glUniformMatrix4x3fv;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ActiveTextureARB(GL.Enums.ARB_multitexture texture);
        internal static ActiveTextureARB glActiveTextureARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClientActiveTextureARB(GL.Enums.ARB_multitexture texture);
        internal static ClientActiveTextureARB glClientActiveTextureARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1dARB(GL.Enums.ARB_multitexture target, GLdouble s);
        internal static MultiTexCoord1dARB glMultiTexCoord1dARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1dvARB(GL.Enums.ARB_multitexture target, GLdouble* v);
        internal static MultiTexCoord1dvARB glMultiTexCoord1dvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1fARB(GL.Enums.ARB_multitexture target, GLfloat s);
        internal static MultiTexCoord1fARB glMultiTexCoord1fARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1fvARB(GL.Enums.ARB_multitexture target, GLfloat* v);
        internal static MultiTexCoord1fvARB glMultiTexCoord1fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1iARB(GL.Enums.ARB_multitexture target, GLint s);
        internal static MultiTexCoord1iARB glMultiTexCoord1iARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1ivARB(GL.Enums.ARB_multitexture target, GLint* v);
        internal static MultiTexCoord1ivARB glMultiTexCoord1ivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1sARB(GL.Enums.ARB_multitexture target, GLshort s);
        internal static MultiTexCoord1sARB glMultiTexCoord1sARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1svARB(GL.Enums.ARB_multitexture target, GLshort* v);
        internal static MultiTexCoord1svARB glMultiTexCoord1svARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2dARB(GL.Enums.ARB_multitexture target, GLdouble s, GLdouble t);
        internal static MultiTexCoord2dARB glMultiTexCoord2dARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2dvARB(GL.Enums.ARB_multitexture target, GLdouble* v);
        internal static MultiTexCoord2dvARB glMultiTexCoord2dvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2fARB(GL.Enums.ARB_multitexture target, GLfloat s, GLfloat t);
        internal static MultiTexCoord2fARB glMultiTexCoord2fARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2fvARB(GL.Enums.ARB_multitexture target, GLfloat* v);
        internal static MultiTexCoord2fvARB glMultiTexCoord2fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2iARB(GL.Enums.ARB_multitexture target, GLint s, GLint t);
        internal static MultiTexCoord2iARB glMultiTexCoord2iARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2ivARB(GL.Enums.ARB_multitexture target, GLint* v);
        internal static MultiTexCoord2ivARB glMultiTexCoord2ivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2sARB(GL.Enums.ARB_multitexture target, GLshort s, GLshort t);
        internal static MultiTexCoord2sARB glMultiTexCoord2sARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2svARB(GL.Enums.ARB_multitexture target, GLshort* v);
        internal static MultiTexCoord2svARB glMultiTexCoord2svARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3dARB(GL.Enums.ARB_multitexture target, GLdouble s, GLdouble t, GLdouble r);
        internal static MultiTexCoord3dARB glMultiTexCoord3dARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3dvARB(GL.Enums.ARB_multitexture target, GLdouble* v);
        internal static MultiTexCoord3dvARB glMultiTexCoord3dvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3fARB(GL.Enums.ARB_multitexture target, GLfloat s, GLfloat t, GLfloat r);
        internal static MultiTexCoord3fARB glMultiTexCoord3fARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3fvARB(GL.Enums.ARB_multitexture target, GLfloat* v);
        internal static MultiTexCoord3fvARB glMultiTexCoord3fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3iARB(GL.Enums.ARB_multitexture target, GLint s, GLint t, GLint r);
        internal static MultiTexCoord3iARB glMultiTexCoord3iARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3ivARB(GL.Enums.ARB_multitexture target, GLint* v);
        internal static MultiTexCoord3ivARB glMultiTexCoord3ivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3sARB(GL.Enums.ARB_multitexture target, GLshort s, GLshort t, GLshort r);
        internal static MultiTexCoord3sARB glMultiTexCoord3sARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3svARB(GL.Enums.ARB_multitexture target, GLshort* v);
        internal static MultiTexCoord3svARB glMultiTexCoord3svARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4dARB(GL.Enums.ARB_multitexture target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);
        internal static MultiTexCoord4dARB glMultiTexCoord4dARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4dvARB(GL.Enums.ARB_multitexture target, GLdouble* v);
        internal static MultiTexCoord4dvARB glMultiTexCoord4dvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4fARB(GL.Enums.ARB_multitexture target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);
        internal static MultiTexCoord4fARB glMultiTexCoord4fARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4fvARB(GL.Enums.ARB_multitexture target, GLfloat* v);
        internal static MultiTexCoord4fvARB glMultiTexCoord4fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4iARB(GL.Enums.ARB_multitexture target, GLint s, GLint t, GLint r, GLint q);
        internal static MultiTexCoord4iARB glMultiTexCoord4iARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4ivARB(GL.Enums.ARB_multitexture target, GLint* v);
        internal static MultiTexCoord4ivARB glMultiTexCoord4ivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4sARB(GL.Enums.ARB_multitexture target, GLshort s, GLshort t, GLshort r, GLshort q);
        internal static MultiTexCoord4sARB glMultiTexCoord4sARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4svARB(GL.Enums.ARB_multitexture target, GLshort* v);
        internal static MultiTexCoord4svARB glMultiTexCoord4svARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadTransposeMatrixfARB(GLfloat* m);
        internal static LoadTransposeMatrixfARB glLoadTransposeMatrixfARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadTransposeMatrixdARB(GLdouble* m);
        internal static LoadTransposeMatrixdARB glLoadTransposeMatrixdARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultTransposeMatrixfARB(GLfloat* m);
        internal static MultTransposeMatrixfARB glMultTransposeMatrixfARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultTransposeMatrixdARB(GLdouble* m);
        internal static MultTransposeMatrixdARB glMultTransposeMatrixdARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleCoverageARB(GLclampf value, GL.Enums.Boolean invert);
        internal static SampleCoverageARB glSampleCoverageARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage3DARB(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data);
        internal static CompressedTexImage3DARB glCompressedTexImage3DARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage2DARB(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data);
        internal static CompressedTexImage2DARB glCompressedTexImage2DARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexImage1DARB(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data);
        internal static CompressedTexImage1DARB glCompressedTexImage1DARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage3DARB(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GL.Enums.PixelFormat format, GLsizei imageSize, void* data);
        internal static CompressedTexSubImage3DARB glCompressedTexSubImage3DARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage2DARB(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GLsizei imageSize, void* data);
        internal static CompressedTexSubImage2DARB glCompressedTexSubImage2DARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CompressedTexSubImage1DARB(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, GL.Enums.PixelFormat format, GLsizei imageSize, void* data);
        internal static CompressedTexSubImage1DARB glCompressedTexSubImage1DARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCompressedTexImageARB(GL.Enums.TextureTarget target, GLint level, void* img);
        internal static GetCompressedTexImageARB glGetCompressedTexImageARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameterfARB(GL.Enums.ARB_point_parameters pname, GLfloat param);
        internal static PointParameterfARB glPointParameterfARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterfvARB(GL.Enums.ARB_point_parameters pname, GLfloat* @params);
        internal static PointParameterfvARB glPointParameterfvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightbvARB(GLint size, GLbyte* weights);
        internal static WeightbvARB glWeightbvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightsvARB(GLint size, GLshort* weights);
        internal static WeightsvARB glWeightsvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightivARB(GLint size, GLint* weights);
        internal static WeightivARB glWeightivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightfvARB(GLint size, GLfloat* weights);
        internal static WeightfvARB glWeightfvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightdvARB(GLint size, GLdouble* weights);
        internal static WeightdvARB glWeightdvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightubvARB(GLint size, GLubyte* weights);
        internal static WeightubvARB glWeightubvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightusvARB(GLint size, GLushort* weights);
        internal static WeightusvARB glWeightusvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightuivARB(GLint size, GLuint* weights);
        internal static WeightuivARB glWeightuivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WeightPointerARB(GLint size, GL.Enums.ARB_vertex_blend type, GLsizei stride, void* pointer);
        internal static WeightPointerARB glWeightPointerARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexBlendARB(GLint count);
        internal static VertexBlendARB glVertexBlendARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CurrentPaletteMatrixARB(GLint index);
        internal static CurrentPaletteMatrixARB glCurrentPaletteMatrixARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MatrixIndexubvARB(GLint size, GLubyte* indices);
        internal static MatrixIndexubvARB glMatrixIndexubvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MatrixIndexusvARB(GLint size, GLushort* indices);
        internal static MatrixIndexusvARB glMatrixIndexusvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MatrixIndexuivARB(GLint size, GLuint* indices);
        internal static MatrixIndexuivARB glMatrixIndexuivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MatrixIndexPointerARB(GLint size, GL.Enums.ARB_matrix_palette type, GLsizei stride, void* pointer);
        internal static MatrixIndexPointerARB glMatrixIndexPointerARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2dARB(GLdouble x, GLdouble y);
        internal static WindowPos2dARB glWindowPos2dARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2dvARB(GLdouble* v);
        internal static WindowPos2dvARB glWindowPos2dvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2fARB(GLfloat x, GLfloat y);
        internal static WindowPos2fARB glWindowPos2fARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2fvARB(GLfloat* v);
        internal static WindowPos2fvARB glWindowPos2fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2iARB(GLint x, GLint y);
        internal static WindowPos2iARB glWindowPos2iARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2ivARB(GLint* v);
        internal static WindowPos2ivARB glWindowPos2ivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2sARB(GLshort x, GLshort y);
        internal static WindowPos2sARB glWindowPos2sARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2svARB(GLshort* v);
        internal static WindowPos2svARB glWindowPos2svARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3dARB(GLdouble x, GLdouble y, GLdouble z);
        internal static WindowPos3dARB glWindowPos3dARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3dvARB(GLdouble* v);
        internal static WindowPos3dvARB glWindowPos3dvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3fARB(GLfloat x, GLfloat y, GLfloat z);
        internal static WindowPos3fARB glWindowPos3fARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3fvARB(GLfloat* v);
        internal static WindowPos3fvARB glWindowPos3fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3iARB(GLint x, GLint y, GLint z);
        internal static WindowPos3iARB glWindowPos3iARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3ivARB(GLint* v);
        internal static WindowPos3ivARB glWindowPos3ivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3sARB(GLshort x, GLshort y, GLshort z);
        internal static WindowPos3sARB glWindowPos3sARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3svARB(GLshort* v);
        internal static WindowPos3svARB glWindowPos3svARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1dARB(GLuint index, GLdouble x);
        internal static VertexAttrib1dARB glVertexAttrib1dARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1dvARB(GLuint index, GLdouble* v);
        internal static VertexAttrib1dvARB glVertexAttrib1dvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1fARB(GLuint index, GLfloat x);
        internal static VertexAttrib1fARB glVertexAttrib1fARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1fvARB(GLuint index, GLfloat* v);
        internal static VertexAttrib1fvARB glVertexAttrib1fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1sARB(GLuint index, GLshort x);
        internal static VertexAttrib1sARB glVertexAttrib1sARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1svARB(GLuint index, GLshort* v);
        internal static VertexAttrib1svARB glVertexAttrib1svARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2dARB(GLuint index, GLdouble x, GLdouble y);
        internal static VertexAttrib2dARB glVertexAttrib2dARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2dvARB(GLuint index, GLdouble* v);
        internal static VertexAttrib2dvARB glVertexAttrib2dvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2fARB(GLuint index, GLfloat x, GLfloat y);
        internal static VertexAttrib2fARB glVertexAttrib2fARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2fvARB(GLuint index, GLfloat* v);
        internal static VertexAttrib2fvARB glVertexAttrib2fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2sARB(GLuint index, GLshort x, GLshort y);
        internal static VertexAttrib2sARB glVertexAttrib2sARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2svARB(GLuint index, GLshort* v);
        internal static VertexAttrib2svARB glVertexAttrib2svARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z);
        internal static VertexAttrib3dARB glVertexAttrib3dARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3dvARB(GLuint index, GLdouble* v);
        internal static VertexAttrib3dvARB glVertexAttrib3dvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z);
        internal static VertexAttrib3fARB glVertexAttrib3fARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3fvARB(GLuint index, GLfloat* v);
        internal static VertexAttrib3fvARB glVertexAttrib3fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3sARB(GLuint index, GLshort x, GLshort y, GLshort z);
        internal static VertexAttrib3sARB glVertexAttrib3sARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3svARB(GLuint index, GLshort* v);
        internal static VertexAttrib3svARB glVertexAttrib3svARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NbvARB(GLuint index, GLbyte* v);
        internal static VertexAttrib4NbvARB glVertexAttrib4NbvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NivARB(GLuint index, GLint* v);
        internal static VertexAttrib4NivARB glVertexAttrib4NivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NsvARB(GLuint index, GLshort* v);
        internal static VertexAttrib4NsvARB glVertexAttrib4NsvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4NubARB(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
        internal static VertexAttrib4NubARB glVertexAttrib4NubARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NubvARB(GLuint index, GLubyte* v);
        internal static VertexAttrib4NubvARB glVertexAttrib4NubvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NuivARB(GLuint index, GLuint* v);
        internal static VertexAttrib4NuivARB glVertexAttrib4NuivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4NusvARB(GLuint index, GLushort* v);
        internal static VertexAttrib4NusvARB glVertexAttrib4NusvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4bvARB(GLuint index, GLbyte* v);
        internal static VertexAttrib4bvARB glVertexAttrib4bvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        internal static VertexAttrib4dARB glVertexAttrib4dARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4dvARB(GLuint index, GLdouble* v);
        internal static VertexAttrib4dvARB glVertexAttrib4dvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        internal static VertexAttrib4fARB glVertexAttrib4fARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4fvARB(GLuint index, GLfloat* v);
        internal static VertexAttrib4fvARB glVertexAttrib4fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4ivARB(GLuint index, GLint* v);
        internal static VertexAttrib4ivARB glVertexAttrib4ivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4sARB(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
        internal static VertexAttrib4sARB glVertexAttrib4sARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4svARB(GLuint index, GLshort* v);
        internal static VertexAttrib4svARB glVertexAttrib4svARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4ubvARB(GLuint index, GLubyte* v);
        internal static VertexAttrib4ubvARB glVertexAttrib4ubvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4uivARB(GLuint index, GLuint* v);
        internal static VertexAttrib4uivARB glVertexAttrib4uivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4usvARB(GLuint index, GLushort* v);
        internal static VertexAttrib4usvARB glVertexAttrib4usvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribPointerARB(GLuint index, GLint size, GL.Enums.ARB_vertex_program type, GL.Enums.Boolean normalized, GLsizei stride, void* pointer);
        internal static VertexAttribPointerARB glVertexAttribPointerARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableVertexAttribArrayARB(GLuint index);
        internal static EnableVertexAttribArrayARB glEnableVertexAttribArrayARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableVertexAttribArrayARB(GLuint index);
        internal static DisableVertexAttribArrayARB glDisableVertexAttribArrayARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramStringARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program format, GLsizei len, void* @string);
        internal static ProgramStringARB glProgramStringARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindProgramARB(GL.Enums.ARB_vertex_program target, GLuint program);
        internal static BindProgramARB glBindProgramARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteProgramsARB(GLsizei n, GLuint* programs);
        internal static DeleteProgramsARB glDeleteProgramsARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenProgramsARB(GLsizei n, GLuint* programs);
        internal static GenProgramsARB glGenProgramsARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramEnvParameter4dARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        internal static ProgramEnvParameter4dARB glProgramEnvParameter4dARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParameter4dvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble* @params);
        internal static ProgramEnvParameter4dvARB glProgramEnvParameter4dvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramEnvParameter4fARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        internal static ProgramEnvParameter4fARB glProgramEnvParameter4fARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParameter4fvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat* @params);
        internal static ProgramEnvParameter4fvARB glProgramEnvParameter4fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramLocalParameter4dARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        internal static ProgramLocalParameter4dARB glProgramLocalParameter4dARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParameter4dvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble* @params);
        internal static ProgramLocalParameter4dvARB glProgramLocalParameter4dvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramLocalParameter4fARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        internal static ProgramLocalParameter4fARB glProgramLocalParameter4fARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParameter4fvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat* @params);
        internal static ProgramLocalParameter4fvARB glProgramLocalParameter4fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramEnvParameterdvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble* @params);
        internal static GetProgramEnvParameterdvARB glGetProgramEnvParameterdvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramEnvParameterfvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat* @params);
        internal static GetProgramEnvParameterfvARB glGetProgramEnvParameterfvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramLocalParameterdvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLdouble* @params);
        internal static GetProgramLocalParameterdvARB glGetProgramLocalParameterdvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramLocalParameterfvARB(GL.Enums.ARB_vertex_program target, GLuint index, GLfloat* @params);
        internal static GetProgramLocalParameterfvARB glGetProgramLocalParameterfvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramivARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program pname, GLint* @params);
        internal static GetProgramivARB glGetProgramivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramStringARB(GL.Enums.ARB_vertex_program target, GL.Enums.ARB_vertex_program pname, void* @string);
        internal static GetProgramStringARB glGetProgramStringARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribdvARB(GLuint index, GL.Enums.ARB_vertex_program pname, GLdouble* @params);
        internal static GetVertexAttribdvARB glGetVertexAttribdvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribfvARB(GLuint index, GL.Enums.ARB_vertex_program pname, GLfloat* @params);
        internal static GetVertexAttribfvARB glGetVertexAttribfvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribivARB(GLuint index, GL.Enums.ARB_vertex_program pname, GLint* @params);
        internal static GetVertexAttribivARB glGetVertexAttribivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribPointervARB(GLuint index, GL.Enums.ARB_vertex_program pname, void* pointer);
        internal static GetVertexAttribPointervARB glGetVertexAttribPointervARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsProgramARB(GLuint program);
        internal static IsProgramARB glIsProgramARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBufferARB(GL.Enums.ARB_vertex_buffer_object target, GLuint buffer);
        internal static BindBufferARB glBindBufferARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteBuffersARB(GLsizei n, GLuint* buffers);
        internal static DeleteBuffersARB glDeleteBuffersARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenBuffersARB(GLsizei n, GLuint* buffers);
        internal static GenBuffersARB glGenBuffersARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsBufferARB(GLuint buffer);
        internal static IsBufferARB glIsBufferARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BufferDataARB(GL.Enums.ARB_vertex_buffer_object target, GLsizeiptrARB size, void* data, GL.Enums.ARB_vertex_buffer_object usage);
        internal static BufferDataARB glBufferDataARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BufferSubDataARB(GL.Enums.ARB_vertex_buffer_object target, GLintptrARB offset, GLsizeiptrARB size, void* data);
        internal static BufferSubDataARB glBufferSubDataARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferSubDataARB(GL.Enums.ARB_vertex_buffer_object target, GLintptrARB offset, GLsizeiptrARB size, void* data);
        internal static GetBufferSubDataARB glGetBufferSubDataARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MapBufferARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object access);
        internal static MapBufferARB glMapBufferARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean UnmapBufferARB(GL.Enums.ARB_vertex_buffer_object target);
        internal static UnmapBufferARB glUnmapBufferARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferParameterivARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object pname, GLint* @params);
        internal static GetBufferParameterivARB glGetBufferParameterivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBufferPointervARB(GL.Enums.ARB_vertex_buffer_object target, GL.Enums.ARB_vertex_buffer_object pname, void* @params);
        internal static GetBufferPointervARB glGetBufferPointervARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenQueriesARB(GLsizei n, GLuint* ids);
        internal static GenQueriesARB glGenQueriesARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteQueriesARB(GLsizei n, GLuint* ids);
        internal static DeleteQueriesARB glDeleteQueriesARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsQueryARB(GLuint id);
        internal static IsQueryARB glIsQueryARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginQueryARB(GL.Enums.GLenum target, GLuint id);
        internal static BeginQueryARB glBeginQueryARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndQueryARB(GL.Enums.GLenum target);
        internal static EndQueryARB glEndQueryARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryivARB(GL.Enums.GLenum target, GL.Enums.GLenum pname, GLint* @params);
        internal static GetQueryivARB glGetQueryivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectivARB(GLuint id, GL.Enums.GLenum pname, GLint* @params);
        internal static GetQueryObjectivARB glGetQueryObjectivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectuivARB(GLuint id, GL.Enums.GLenum pname, GLuint* @params);
        internal static GetQueryObjectuivARB glGetQueryObjectuivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteObjectARB(GLhandleARB obj);
        internal static DeleteObjectARB glDeleteObjectARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLhandleARB GetHandleARB(GL.Enums.GLenum pname);
        internal static GetHandleARB glGetHandleARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DetachObjectARB(GLhandleARB containerObj, GLhandleARB attachedObj);
        internal static DetachObjectARB glDetachObjectARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLhandleARB CreateShaderObjectARB(GL.Enums.GLenum shaderType);
        internal static CreateShaderObjectARB glCreateShaderObjectARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ShaderSourceARB(GLhandleARB shaderObj, GLsizei count, System.String @string, GLint* length);
        internal static ShaderSourceARB glShaderSourceARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CompileShaderARB(GLhandleARB shaderObj);
        internal static CompileShaderARB glCompileShaderARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLhandleARB CreateProgramObjectARB();
        internal static CreateProgramObjectARB glCreateProgramObjectARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AttachObjectARB(GLhandleARB containerObj, GLhandleARB obj);
        internal static AttachObjectARB glAttachObjectARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LinkProgramARB(GLhandleARB programObj);
        internal static LinkProgramARB glLinkProgramARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UseProgramObjectARB(GLhandleARB programObj);
        internal static UseProgramObjectARB glUseProgramObjectARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ValidateProgramARB(GLhandleARB programObj);
        internal static ValidateProgramARB glValidateProgramARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1fARB(GLint location, GLfloat v0);
        internal static Uniform1fARB glUniform1fARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2fARB(GLint location, GLfloat v0, GLfloat v1);
        internal static Uniform2fARB glUniform2fARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
        internal static Uniform3fARB glUniform3fARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
        internal static Uniform4fARB glUniform4fARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1iARB(GLint location, GLint v0);
        internal static Uniform1iARB glUniform1iARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2iARB(GLint location, GLint v0, GLint v1);
        internal static Uniform2iARB glUniform2iARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3iARB(GLint location, GLint v0, GLint v1, GLint v2);
        internal static Uniform3iARB glUniform3iARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4iARB(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
        internal static Uniform4iARB glUniform4iARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1fvARB(GLint location, GLsizei count, GLfloat* value);
        internal static Uniform1fvARB glUniform1fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2fvARB(GLint location, GLsizei count, GLfloat* value);
        internal static Uniform2fvARB glUniform2fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3fvARB(GLint location, GLsizei count, GLfloat* value);
        internal static Uniform3fvARB glUniform3fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4fvARB(GLint location, GLsizei count, GLfloat* value);
        internal static Uniform4fvARB glUniform4fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1ivARB(GLint location, GLsizei count, GLint* value);
        internal static Uniform1ivARB glUniform1ivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2ivARB(GLint location, GLsizei count, GLint* value);
        internal static Uniform2ivARB glUniform2ivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3ivARB(GLint location, GLsizei count, GLint* value);
        internal static Uniform3ivARB glUniform3ivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4ivARB(GLint location, GLsizei count, GLint* value);
        internal static Uniform4ivARB glUniform4ivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix2fvARB(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        internal static UniformMatrix2fvARB glUniformMatrix2fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix3fvARB(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        internal static UniformMatrix3fvARB glUniformMatrix3fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UniformMatrix4fvARB(GLint location, GLsizei count, GL.Enums.Boolean transpose, GLfloat* value);
        internal static UniformMatrix4fvARB glUniformMatrix4fvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetObjectParameterfvARB(GLhandleARB obj, GL.Enums.GLenum pname, GLfloat* @params);
        internal static GetObjectParameterfvARB glGetObjectParameterfvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetObjectParameterivARB(GLhandleARB obj, GL.Enums.GLenum pname, GLint* @params);
        internal static GetObjectParameterivARB glGetObjectParameterivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetInfoLogARB(GLhandleARB obj, GLsizei maxLength, GLsizei* length, System.Text.StringBuilder infoLog);
        internal static GetInfoLogARB glGetInfoLogARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetAttachedObjectsARB(GLhandleARB containerObj, GLsizei maxCount, GLsizei* count, GLhandleARB* obj);
        internal static GetAttachedObjectsARB glGetAttachedObjectsARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate GLint GetUniformLocationARB(GLhandleARB programObj, System.String name);
        internal static GetUniformLocationARB glGetUniformLocationARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveUniformARB(GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GL.Enums.GLenum* type, System.Text.StringBuilder name);
        internal static GetActiveUniformARB glGetActiveUniformARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformfvARB(GLhandleARB programObj, GLint location, GLfloat* @params);
        internal static GetUniformfvARB glGetUniformfvARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformivARB(GLhandleARB programObj, GLint location, GLint* @params);
        internal static GetUniformivARB glGetUniformivARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetShaderSourceARB(GLhandleARB obj, GLsizei maxLength, GLsizei* length, System.Text.StringBuilder source);
        internal static GetShaderSourceARB glGetShaderSourceARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BindAttribLocationARB(GLhandleARB programObj, GLuint index, System.String name);
        internal static BindAttribLocationARB glBindAttribLocationARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveAttribARB(GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GL.Enums.GLenum* type, System.Text.StringBuilder name);
        internal static GetActiveAttribARB glGetActiveAttribARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate GLint GetAttribLocationARB(GLhandleARB programObj, System.String name);
        internal static GetAttribLocationARB glGetAttribLocationARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawBuffersARB(GLsizei n, GL.Enums.ARB_draw_buffers* bufs);
        internal static DrawBuffersARB glDrawBuffersARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClampColorARB(GL.Enums.ARB_color_buffer_float target, GL.Enums.ARB_color_buffer_float clamp);
        internal static ClampColorARB glClampColorARB;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendColorEXT(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
        internal static BlendColorEXT glBlendColorEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PolygonOffsetEXT(GLfloat factor, GLfloat bias);
        internal static PolygonOffsetEXT glPolygonOffsetEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexImage3DEXT(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal static TexImage3DEXT glTexImage3DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage3DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal static TexSubImage3DEXT glTexSubImage3DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexFilterFuncSGIS(GL.Enums.TextureTarget target, GL.Enums.SGIS_texture_filter4 filter, GLfloat* weights);
        internal static GetTexFilterFuncSGIS glGetTexFilterFuncSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexFilterFuncSGIS(GL.Enums.TextureTarget target, GL.Enums.SGIS_texture_filter4 filter, GLsizei n, GLfloat* weights);
        internal static TexFilterFuncSGIS glTexFilterFuncSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage1DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal static TexSubImage1DEXT glTexSubImage1DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage2DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal static TexSubImage2DEXT glTexSubImage2DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexImage1DEXT(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLint border);
        internal static CopyTexImage1DEXT glCopyTexImage1DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexImage2DEXT(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
        internal static CopyTexImage2DEXT glCopyTexImage2DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage1DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        internal static CopyTexSubImage1DEXT glCopyTexSubImage1DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage2DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        internal static CopyTexSubImage2DEXT glCopyTexSubImage2DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyTexSubImage3DEXT(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        internal static CopyTexSubImage3DEXT glCopyTexSubImage3DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogramEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* values);
        internal static GetHistogramEXT glGetHistogramEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogramParameterfvEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.GetHistogramParameterPNameEXT pname, GLfloat* @params);
        internal static GetHistogramParameterfvEXT glGetHistogramParameterfvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetHistogramParameterivEXT(GL.Enums.HistogramTargetEXT target, GL.Enums.GetHistogramParameterPNameEXT pname, GLint* @params);
        internal static GetHistogramParameterivEXT glGetHistogramParameterivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmaxEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.Boolean reset, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* values);
        internal static GetMinmaxEXT glGetMinmaxEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmaxParameterfvEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.GetMinmaxParameterPNameEXT pname, GLfloat* @params);
        internal static GetMinmaxParameterfvEXT glGetMinmaxParameterfvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMinmaxParameterivEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.GetMinmaxParameterPNameEXT pname, GLint* @params);
        internal static GetMinmaxParameterivEXT glGetMinmaxParameterivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void HistogramEXT(GL.Enums.HistogramTargetEXT target, GLsizei width, GL.Enums.PixelInternalFormat internalformat, GL.Enums.Boolean sink);
        internal static HistogramEXT glHistogramEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MinmaxEXT(GL.Enums.MinmaxTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GL.Enums.Boolean sink);
        internal static MinmaxEXT glMinmaxEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ResetHistogramEXT(GL.Enums.HistogramTargetEXT target);
        internal static ResetHistogramEXT glResetHistogramEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ResetMinmaxEXT(GL.Enums.MinmaxTargetEXT target);
        internal static ResetMinmaxEXT glResetMinmaxEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionFilter1DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
        internal static ConvolutionFilter1DEXT glConvolutionFilter1DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionFilter2DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
        internal static ConvolutionFilter2DEXT glConvolutionFilter2DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ConvolutionParameterfEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLfloat @params);
        internal static ConvolutionParameterfEXT glConvolutionParameterfEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionParameterfvEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLfloat* @params);
        internal static ConvolutionParameterfvEXT glConvolutionParameterfvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ConvolutionParameteriEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLint @params);
        internal static ConvolutionParameteriEXT glConvolutionParameteriEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ConvolutionParameterivEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLint* @params);
        internal static ConvolutionParameterivEXT glConvolutionParameterivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyConvolutionFilter1DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width);
        internal static CopyConvolutionFilter1DEXT glCopyConvolutionFilter1DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyConvolutionFilter2DEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width, GLsizei height);
        internal static CopyConvolutionFilter2DEXT glCopyConvolutionFilter2DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionFilterEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* image);
        internal static GetConvolutionFilterEXT glGetConvolutionFilterEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionParameterfvEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLfloat* @params);
        internal static GetConvolutionParameterfvEXT glGetConvolutionParameterfvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetConvolutionParameterivEXT(GL.Enums.ConvolutionTargetEXT target, GL.Enums.ConvolutionParameterEXT pname, GLint* @params);
        internal static GetConvolutionParameterivEXT glGetConvolutionParameterivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetSeparableFilterEXT(GL.Enums.SeparableTargetEXT target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column, void* span);
        internal static GetSeparableFilterEXT glGetSeparableFilterEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SeparableFilter2DEXT(GL.Enums.SeparableTargetEXT target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* row, void* column);
        internal static SeparableFilter2DEXT glSeparableFilter2DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table);
        internal static ColorTableSGI glColorTableSGI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableParameterfvSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.ColorTableParameterPNameSGI pname, GLfloat* @params);
        internal static ColorTableParameterfvSGI glColorTableParameterfvSGI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableParameterivSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.ColorTableParameterPNameSGI pname, GLint* @params);
        internal static ColorTableParameterivSGI glColorTableParameterivSGI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelInternalFormat internalformat, GLint x, GLint y, GLsizei width);
        internal static CopyColorTableSGI glCopyColorTableSGI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table);
        internal static GetColorTableSGI glGetColorTableSGI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameterfvSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.GetColorTableParameterPNameSGI pname, GLfloat* @params);
        internal static GetColorTableParameterfvSGI glGetColorTableParameterfvSGI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameterivSGI(GL.Enums.ColorTableTargetSGI target, GL.Enums.GetColorTableParameterPNameSGI pname, GLint* @params);
        internal static GetColorTableParameterivSGI glGetColorTableParameterivSGI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTexGenSGIX(GL.Enums.SGIX_pixel_texture mode);
        internal static PixelTexGenSGIX glPixelTexGenSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTexGenParameteriSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLint param);
        internal static PixelTexGenParameteriSGIS glPixelTexGenParameteriSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelTexGenParameterivSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLint* @params);
        internal static PixelTexGenParameterivSGIS glPixelTexGenParameterivSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTexGenParameterfSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLfloat param);
        internal static PixelTexGenParameterfSGIS glPixelTexGenParameterfSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelTexGenParameterfvSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLfloat* @params);
        internal static PixelTexGenParameterfvSGIS glPixelTexGenParameterfvSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPixelTexGenParameterivSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLint* @params);
        internal static GetPixelTexGenParameterivSGIS glGetPixelTexGenParameterivSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPixelTexGenParameterfvSGIS(GL.Enums.PixelTexGenParameterNameSGIS pname, GLfloat* @params);
        internal static GetPixelTexGenParameterfvSGIS glGetPixelTexGenParameterfvSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexImage4DSGIS(GL.Enums.TextureTarget target, GLint level, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLint border, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal static TexImage4DSGIS glTexImage4DSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexSubImage4DSGIS(GL.Enums.TextureTarget target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint woffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* pixels);
        internal static TexSubImage4DSGIS glTexSubImage4DSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate GLboolean AreTexturesResidentEXT(GLsizei n, GLuint* textures, GL.Enums.Boolean* residences);
        internal static AreTexturesResidentEXT glAreTexturesResidentEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindTextureEXT(GL.Enums.TextureTarget target, GLuint texture);
        internal static BindTextureEXT glBindTextureEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteTexturesEXT(GLsizei n, GLuint* textures);
        internal static DeleteTexturesEXT glDeleteTexturesEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenTexturesEXT(GLsizei n, GLuint* textures);
        internal static GenTexturesEXT glGenTexturesEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsTextureEXT(GLuint texture);
        internal static IsTextureEXT glIsTextureEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PrioritizeTexturesEXT(GLsizei n, GLuint* textures, GLclampf* priorities);
        internal static PrioritizeTexturesEXT glPrioritizeTexturesEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DetailTexFuncSGIS(GL.Enums.TextureTarget target, GLsizei n, GLfloat* points);
        internal static DetailTexFuncSGIS glDetailTexFuncSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetDetailTexFuncSGIS(GL.Enums.TextureTarget target, GLfloat* points);
        internal static GetDetailTexFuncSGIS glGetDetailTexFuncSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SharpenTexFuncSGIS(GL.Enums.TextureTarget target, GLsizei n, GLfloat* points);
        internal static SharpenTexFuncSGIS glSharpenTexFuncSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetSharpenTexFuncSGIS(GL.Enums.TextureTarget target, GLfloat* points);
        internal static GetSharpenTexFuncSGIS glGetSharpenTexFuncSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleMaskSGIS(GLclampf value, GL.Enums.Boolean invert);
        internal static SampleMaskSGIS glSampleMaskSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SamplePatternSGIS(GL.Enums.SamplePatternSGIS pattern);
        internal static SamplePatternSGIS glSamplePatternSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ArrayElementEXT(GLint i);
        internal static ArrayElementEXT glArrayElementEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorPointerEXT(GLint size, GL.Enums.ColorPointerType type, GLsizei stride, GLsizei count, void* pointer);
        internal static ColorPointerEXT glColorPointerEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawArraysEXT(GL.Enums.BeginMode mode, GLint first, GLsizei count);
        internal static DrawArraysEXT glDrawArraysEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EdgeFlagPointerEXT(GLsizei stride, GLsizei count, GL.Enums.Boolean* pointer);
        internal static EdgeFlagPointerEXT glEdgeFlagPointerEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetPointervEXT(GL.Enums.GetPointervPName pname, void* @params);
        internal static GetPointervEXT glGetPointervEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void IndexPointerEXT(GL.Enums.IndexPointerType type, GLsizei stride, GLsizei count, void* pointer);
        internal static IndexPointerEXT glIndexPointerEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalPointerEXT(GL.Enums.NormalPointerType type, GLsizei stride, GLsizei count, void* pointer);
        internal static NormalPointerEXT glNormalPointerEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoordPointerEXT(GLint size, GL.Enums.TexCoordPointerType type, GLsizei stride, GLsizei count, void* pointer);
        internal static TexCoordPointerEXT glTexCoordPointerEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexPointerEXT(GLint size, GL.Enums.VertexPointerType type, GLsizei stride, GLsizei count, void* pointer);
        internal static VertexPointerEXT glVertexPointerEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendEquationEXT(GL.Enums.BlendEquationModeEXT mode);
        internal static BlendEquationEXT glBlendEquationEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SpriteParameterfSGIX(GL.Enums.SGIX_sprite pname, GLfloat param);
        internal static SpriteParameterfSGIX glSpriteParameterfSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SpriteParameterfvSGIX(GL.Enums.SGIX_sprite pname, GLfloat* @params);
        internal static SpriteParameterfvSGIX glSpriteParameterfvSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SpriteParameteriSGIX(GL.Enums.SGIX_sprite pname, GLint param);
        internal static SpriteParameteriSGIX glSpriteParameteriSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SpriteParameterivSGIX(GL.Enums.SGIX_sprite pname, GLint* @params);
        internal static SpriteParameterivSGIX glSpriteParameterivSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameterfEXT(GL.Enums.EXT_point_parameters pname, GLfloat param);
        internal static PointParameterfEXT glPointParameterfEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterfvEXT(GL.Enums.EXT_point_parameters pname, GLfloat* @params);
        internal static PointParameterfvEXT glPointParameterfvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameterfSGIS(GL.Enums.SGIS_point_parameters pname, GLfloat param);
        internal static PointParameterfSGIS glPointParameterfSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterfvSGIS(GL.Enums.SGIS_point_parameters pname, GLfloat* @params);
        internal static PointParameterfvSGIS glPointParameterfvSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLint GetInstrumentsSGIX();
        internal static GetInstrumentsSGIX glGetInstrumentsSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void InstrumentsBufferSGIX(GLsizei size, GLint* buffer);
        internal static InstrumentsBufferSGIX glInstrumentsBufferSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate GLint PollInstrumentsSGIX(GLint* marker_p);
        internal static PollInstrumentsSGIX glPollInstrumentsSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReadInstrumentsSGIX(GLint marker);
        internal static ReadInstrumentsSGIX glReadInstrumentsSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StartInstrumentsSGIX();
        internal static StartInstrumentsSGIX glStartInstrumentsSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StopInstrumentsSGIX(GLint marker);
        internal static StopInstrumentsSGIX glStopInstrumentsSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FrameZoomSGIX(GLint factor);
        internal static FrameZoomSGIX glFrameZoomSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TagSampleBufferSGIX();
        internal static TagSampleBufferSGIX glTagSampleBufferSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeformationMap3dSGIX(GL.Enums.FfdTargetSGIX target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble w1, GLdouble w2, GLint wstride, GLint worder, GLdouble* points);
        internal static DeformationMap3dSGIX glDeformationMap3dSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeformationMap3fSGIX(GL.Enums.FfdTargetSGIX target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat w1, GLfloat w2, GLint wstride, GLint worder, GLfloat* points);
        internal static DeformationMap3fSGIX glDeformationMap3fSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeformSGIX(GL.Enums.FfdMaskSGIX mask);
        internal static DeformSGIX glDeformSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LoadIdentityDeformationMapSGIX(GL.Enums.FfdMaskSGIX mask);
        internal static LoadIdentityDeformationMapSGIX glLoadIdentityDeformationMapSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReferencePlaneSGIX(GLdouble* equation);
        internal static ReferencePlaneSGIX glReferencePlaneSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FlushRasterSGIX();
        internal static FlushRasterSGIX glFlushRasterSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogFuncSGIS(GLsizei n, GLfloat* points);
        internal static FogFuncSGIS glFogFuncSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFogFuncSGIS(GLfloat* points);
        internal static GetFogFuncSGIS glGetFogFuncSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ImageTransformParameteriHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLint param);
        internal static ImageTransformParameteriHP glImageTransformParameteriHP;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ImageTransformParameterfHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLfloat param);
        internal static ImageTransformParameterfHP glImageTransformParameterfHP;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ImageTransformParameterivHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLint* @params);
        internal static ImageTransformParameterivHP glImageTransformParameterivHP;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ImageTransformParameterfvHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLfloat* @params);
        internal static ImageTransformParameterfvHP glImageTransformParameterfvHP;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetImageTransformParameterivHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLint* @params);
        internal static GetImageTransformParameterivHP glGetImageTransformParameterivHP;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetImageTransformParameterfvHP(GL.Enums.HP_image_transform target, GL.Enums.HP_image_transform pname, GLfloat* @params);
        internal static GetImageTransformParameterfvHP glGetImageTransformParameterfvHP;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorSubTableEXT(GL.Enums.EXT_color_subtable target, GLsizei start, GLsizei count, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data);
        internal static ColorSubTableEXT glColorSubTableEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CopyColorSubTableEXT(GL.Enums.EXT_color_subtable target, GLsizei start, GLint x, GLint y, GLsizei width);
        internal static CopyColorSubTableEXT glCopyColorSubTableEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void HintPGI(GL.Enums.PGI_misc_hints target, GLint mode);
        internal static HintPGI glHintPGI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorTableEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.PixelInternalFormat internalFormat, GLsizei width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* table);
        internal static ColorTableEXT glColorTableEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data);
        internal static GetColorTableEXT glGetColorTableEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameterivEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.EXT_paletted_texture pname, GLint* @params);
        internal static GetColorTableParameterivEXT glGetColorTableParameterivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetColorTableParameterfvEXT(GL.Enums.EXT_paletted_texture target, GL.Enums.EXT_paletted_texture pname, GLfloat* @params);
        internal static GetColorTableParameterfvEXT glGetColorTableParameterfvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetListParameterfvSGIX(GLuint list, GL.Enums.ListParameterName pname, GLfloat* @params);
        internal static GetListParameterfvSGIX glGetListParameterfvSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetListParameterivSGIX(GLuint list, GL.Enums.ListParameterName pname, GLint* @params);
        internal static GetListParameterivSGIX glGetListParameterivSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ListParameterfSGIX(GLuint list, GL.Enums.ListParameterName pname, GLfloat param);
        internal static ListParameterfSGIX glListParameterfSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ListParameterfvSGIX(GLuint list, GL.Enums.ListParameterName pname, GLfloat* @params);
        internal static ListParameterfvSGIX glListParameterfvSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ListParameteriSGIX(GLuint list, GL.Enums.ListParameterName pname, GLint param);
        internal static ListParameteriSGIX glListParameteriSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ListParameterivSGIX(GLuint list, GL.Enums.ListParameterName pname, GLint* @params);
        internal static ListParameterivSGIX glListParameterivSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void IndexMaterialEXT(GL.Enums.MaterialFace face, GL.Enums.EXT_index_material mode);
        internal static IndexMaterialEXT glIndexMaterialEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void IndexFuncEXT(GL.Enums.EXT_index_func func, GLclampf @ref);
        internal static IndexFuncEXT glIndexFuncEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LockArraysEXT(GLint first, GLsizei count);
        internal static LockArraysEXT glLockArraysEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UnlockArraysEXT();
        internal static UnlockArraysEXT glUnlockArraysEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CullParameterdvEXT(GL.Enums.EXT_cull_vertex pname, GLdouble* @params);
        internal static CullParameterdvEXT glCullParameterdvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CullParameterfvEXT(GL.Enums.EXT_cull_vertex pname, GLfloat* @params);
        internal static CullParameterfvEXT glCullParameterfvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentColorMaterialSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter mode);
        internal static FragmentColorMaterialSGIX glFragmentColorMaterialSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentLightfSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLfloat param);
        internal static FragmentLightfSGIX glFragmentLightfSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentLightfvSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLfloat* @params);
        internal static FragmentLightfvSGIX glFragmentLightfvSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentLightiSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLint param);
        internal static FragmentLightiSGIX glFragmentLightiSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentLightivSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLint* @params);
        internal static FragmentLightivSGIX glFragmentLightivSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentLightModelfSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, GLfloat param);
        internal static FragmentLightModelfSGIX glFragmentLightModelfSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentLightModelfvSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, GLfloat* @params);
        internal static FragmentLightModelfvSGIX glFragmentLightModelfvSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentLightModeliSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, GLint param);
        internal static FragmentLightModeliSGIX glFragmentLightModeliSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentLightModelivSGIX(GL.Enums.FragmentLightModelParameterSGIX pname, GLint* @params);
        internal static FragmentLightModelivSGIX glFragmentLightModelivSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentMaterialfSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat param);
        internal static FragmentMaterialfSGIX glFragmentMaterialfSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentMaterialfvSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat* @params);
        internal static FragmentMaterialfvSGIX glFragmentMaterialfvSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FragmentMaterialiSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint param);
        internal static FragmentMaterialiSGIX glFragmentMaterialiSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FragmentMaterialivSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint* @params);
        internal static FragmentMaterialivSGIX glFragmentMaterialivSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFragmentLightfvSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLfloat* @params);
        internal static GetFragmentLightfvSGIX glGetFragmentLightfvSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFragmentLightivSGIX(GL.Enums.SGIX_fragment_lighting light, GL.Enums.SGIX_fragment_lighting pname, GLint* @params);
        internal static GetFragmentLightivSGIX glGetFragmentLightivSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFragmentMaterialfvSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLfloat* @params);
        internal static GetFragmentMaterialfvSGIX glGetFragmentMaterialfvSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFragmentMaterialivSGIX(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter pname, GLint* @params);
        internal static GetFragmentMaterialivSGIX glGetFragmentMaterialivSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void LightEnviSGIX(GL.Enums.LightEnvParameterSGIX pname, GLint param);
        internal static LightEnviSGIX glLightEnviSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawRangeElementsEXT(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count, GL.Enums.EXT_draw_range_elements type, void* indices);
        internal static DrawRangeElementsEXT glDrawRangeElementsEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ApplyTextureEXT(GL.Enums.EXT_light_texture mode);
        internal static ApplyTextureEXT glApplyTextureEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TextureLightEXT(GL.Enums.EXT_light_texture pname);
        internal static TextureLightEXT glTextureLightEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TextureMaterialEXT(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter mode);
        internal static TextureMaterialEXT glTextureMaterialEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AsyncMarkerSGIX(GLuint marker);
        internal static AsyncMarkerSGIX glAsyncMarkerSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate GLint FinishAsyncSGIX(GLuint* markerp);
        internal static FinishAsyncSGIX glFinishAsyncSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate GLint PollAsyncSGIX(GLuint* markerp);
        internal static PollAsyncSGIX glPollAsyncSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLuint GenAsyncMarkersSGIX(GLsizei range);
        internal static GenAsyncMarkersSGIX glGenAsyncMarkersSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteAsyncMarkersSGIX(GLuint marker, GLsizei range);
        internal static DeleteAsyncMarkersSGIX glDeleteAsyncMarkersSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsAsyncMarkerSGIX(GLuint marker);
        internal static IsAsyncMarkerSGIX glIsAsyncMarkerSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexPointervINTEL(GLint size, GL.Enums.VertexPointerType type, void* pointer);
        internal static VertexPointervINTEL glVertexPointervINTEL;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalPointervINTEL(GL.Enums.NormalPointerType type, void* pointer);
        internal static NormalPointervINTEL glNormalPointervINTEL;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorPointervINTEL(GLint size, GL.Enums.VertexPointerType type, void* pointer);
        internal static ColorPointervINTEL glColorPointervINTEL;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoordPointervINTEL(GLint size, GL.Enums.VertexPointerType type, void* pointer);
        internal static TexCoordPointervINTEL glTexCoordPointervINTEL;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTransformParameteriEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, GLint param);
        internal static PixelTransformParameteriEXT glPixelTransformParameteriEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PixelTransformParameterfEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, GLfloat param);
        internal static PixelTransformParameterfEXT glPixelTransformParameterfEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelTransformParameterivEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, GLint* @params);
        internal static PixelTransformParameterivEXT glPixelTransformParameterivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelTransformParameterfvEXT(GL.Enums.EXT_pixel_transform target, GL.Enums.EXT_pixel_transform pname, GLfloat* @params);
        internal static PixelTransformParameterfvEXT glPixelTransformParameterfvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3bEXT(GLbyte red, GLbyte green, GLbyte blue);
        internal static SecondaryColor3bEXT glSecondaryColor3bEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3bvEXT(GLbyte* v);
        internal static SecondaryColor3bvEXT glSecondaryColor3bvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3dEXT(GLdouble red, GLdouble green, GLdouble blue);
        internal static SecondaryColor3dEXT glSecondaryColor3dEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3dvEXT(GLdouble* v);
        internal static SecondaryColor3dvEXT glSecondaryColor3dvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3fEXT(GLfloat red, GLfloat green, GLfloat blue);
        internal static SecondaryColor3fEXT glSecondaryColor3fEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3fvEXT(GLfloat* v);
        internal static SecondaryColor3fvEXT glSecondaryColor3fvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3iEXT(GLint red, GLint green, GLint blue);
        internal static SecondaryColor3iEXT glSecondaryColor3iEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3ivEXT(GLint* v);
        internal static SecondaryColor3ivEXT glSecondaryColor3ivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3sEXT(GLshort red, GLshort green, GLshort blue);
        internal static SecondaryColor3sEXT glSecondaryColor3sEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3svEXT(GLshort* v);
        internal static SecondaryColor3svEXT glSecondaryColor3svEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3ubEXT(GLubyte red, GLubyte green, GLubyte blue);
        internal static SecondaryColor3ubEXT glSecondaryColor3ubEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3ubvEXT(GLubyte* v);
        internal static SecondaryColor3ubvEXT glSecondaryColor3ubvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3uiEXT(GLuint red, GLuint green, GLuint blue);
        internal static SecondaryColor3uiEXT glSecondaryColor3uiEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3uivEXT(GLuint* v);
        internal static SecondaryColor3uivEXT glSecondaryColor3uivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3usEXT(GLushort red, GLushort green, GLushort blue);
        internal static SecondaryColor3usEXT glSecondaryColor3usEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3usvEXT(GLushort* v);
        internal static SecondaryColor3usvEXT glSecondaryColor3usvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColorPointerEXT(GLint size, GL.Enums.ColorPointerType type, GLsizei stride, void* pointer);
        internal static SecondaryColorPointerEXT glSecondaryColorPointerEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TextureNormalEXT(GL.Enums.EXT_texture_perturb_normal mode);
        internal static TextureNormalEXT glTextureNormalEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawArraysEXT(GL.Enums.BeginMode mode, GLint* first, GLsizei* count, GLsizei primcount);
        internal static MultiDrawArraysEXT glMultiDrawArraysEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawElementsEXT(GL.Enums.BeginMode mode, GLsizei* count, GL.Enums.EXT_multi_draw_arrays type, void* indices, GLsizei primcount);
        internal static MultiDrawElementsEXT glMultiDrawElementsEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FogCoordfEXT(GLfloat coord);
        internal static FogCoordfEXT glFogCoordfEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordfvEXT(GLfloat* coord);
        internal static FogCoordfvEXT glFogCoordfvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FogCoorddEXT(GLdouble coord);
        internal static FogCoorddEXT glFogCoorddEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoorddvEXT(GLdouble* coord);
        internal static FogCoorddvEXT glFogCoorddvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordPointerEXT(GL.Enums.EXT_fog_coord type, GLsizei stride, void* pointer);
        internal static FogCoordPointerEXT glFogCoordPointerEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Tangent3bEXT(GLbyte tx, GLbyte ty, GLbyte tz);
        internal static Tangent3bEXT glTangent3bEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Tangent3bvEXT(GLbyte* v);
        internal static Tangent3bvEXT glTangent3bvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Tangent3dEXT(GLdouble tx, GLdouble ty, GLdouble tz);
        internal static Tangent3dEXT glTangent3dEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Tangent3dvEXT(GLdouble* v);
        internal static Tangent3dvEXT glTangent3dvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Tangent3fEXT(GLfloat tx, GLfloat ty, GLfloat tz);
        internal static Tangent3fEXT glTangent3fEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Tangent3fvEXT(GLfloat* v);
        internal static Tangent3fvEXT glTangent3fvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Tangent3iEXT(GLint tx, GLint ty, GLint tz);
        internal static Tangent3iEXT glTangent3iEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Tangent3ivEXT(GLint* v);
        internal static Tangent3ivEXT glTangent3ivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Tangent3sEXT(GLshort tx, GLshort ty, GLshort tz);
        internal static Tangent3sEXT glTangent3sEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Tangent3svEXT(GLshort* v);
        internal static Tangent3svEXT glTangent3svEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Binormal3bEXT(GLbyte bx, GLbyte by, GLbyte bz);
        internal static Binormal3bEXT glBinormal3bEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Binormal3bvEXT(GLbyte* v);
        internal static Binormal3bvEXT glBinormal3bvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Binormal3dEXT(GLdouble bx, GLdouble by, GLdouble bz);
        internal static Binormal3dEXT glBinormal3dEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Binormal3dvEXT(GLdouble* v);
        internal static Binormal3dvEXT glBinormal3dvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Binormal3fEXT(GLfloat bx, GLfloat by, GLfloat bz);
        internal static Binormal3fEXT glBinormal3fEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Binormal3fvEXT(GLfloat* v);
        internal static Binormal3fvEXT glBinormal3fvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Binormal3iEXT(GLint bx, GLint by, GLint bz);
        internal static Binormal3iEXT glBinormal3iEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Binormal3ivEXT(GLint* v);
        internal static Binormal3ivEXT glBinormal3ivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Binormal3sEXT(GLshort bx, GLshort by, GLshort bz);
        internal static Binormal3sEXT glBinormal3sEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Binormal3svEXT(GLshort* v);
        internal static Binormal3svEXT glBinormal3svEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TangentPointerEXT(GL.Enums.EXT_coordinate_frame type, GLsizei stride, void* pointer);
        internal static TangentPointerEXT glTangentPointerEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BinormalPointerEXT(GL.Enums.EXT_coordinate_frame type, GLsizei stride, void* pointer);
        internal static BinormalPointerEXT glBinormalPointerEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FinishTextureSUNX();
        internal static FinishTextureSUNX glFinishTextureSUNX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactorbSUN(GLbyte factor);
        internal static GlobalAlphaFactorbSUN glGlobalAlphaFactorbSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactorsSUN(GLshort factor);
        internal static GlobalAlphaFactorsSUN glGlobalAlphaFactorsSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactoriSUN(GLint factor);
        internal static GlobalAlphaFactoriSUN glGlobalAlphaFactoriSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactorfSUN(GLfloat factor);
        internal static GlobalAlphaFactorfSUN glGlobalAlphaFactorfSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactordSUN(GLdouble factor);
        internal static GlobalAlphaFactordSUN glGlobalAlphaFactordSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactorubSUN(GLubyte factor);
        internal static GlobalAlphaFactorubSUN glGlobalAlphaFactorubSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactorusSUN(GLushort factor);
        internal static GlobalAlphaFactorusSUN glGlobalAlphaFactorusSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GlobalAlphaFactoruiSUN(GLuint factor);
        internal static GlobalAlphaFactoruiSUN glGlobalAlphaFactoruiSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiSUN(GLuint code);
        internal static ReplacementCodeuiSUN glReplacementCodeuiSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeusSUN(GLushort code);
        internal static ReplacementCodeusSUN glReplacementCodeusSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeubSUN(GLubyte code);
        internal static ReplacementCodeubSUN glReplacementCodeubSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuivSUN(GLuint* code);
        internal static ReplacementCodeuivSUN glReplacementCodeuivSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeusvSUN(GLushort* code);
        internal static ReplacementCodeusvSUN glReplacementCodeusvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeubvSUN(GLubyte* code);
        internal static ReplacementCodeubvSUN glReplacementCodeubvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodePointerSUN(GL.Enums.SUN_triangle_list type, GLsizei stride, void* pointer);
        internal static ReplacementCodePointerSUN glReplacementCodePointerSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4ubVertex2fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y);
        internal static Color4ubVertex2fSUN glColor4ubVertex2fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4ubVertex2fvSUN(GLubyte* c, GLfloat* v);
        internal static Color4ubVertex2fvSUN glColor4ubVertex2fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4ubVertex3fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
        internal static Color4ubVertex3fSUN glColor4ubVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4ubVertex3fvSUN(GLubyte* c, GLfloat* v);
        internal static Color4ubVertex3fvSUN glColor4ubVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
        internal static Color3fVertex3fSUN glColor3fVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3fVertex3fvSUN(GLfloat* c, GLfloat* v);
        internal static Color3fVertex3fvSUN glColor3fVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3fVertex3fSUN(GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        internal static Normal3fVertex3fSUN glNormal3fVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3fVertex3fvSUN(GLfloat* n, GLfloat* v);
        internal static Normal3fVertex3fvSUN glNormal3fVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4fNormal3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        internal static Color4fNormal3fVertex3fSUN glColor4fNormal3fVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4fNormal3fVertex3fvSUN(GLfloat* c, GLfloat* n, GLfloat* v);
        internal static Color4fNormal3fVertex3fvSUN glColor4fNormal3fVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2fVertex3fSUN(GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z);
        internal static TexCoord2fVertex3fSUN glTexCoord2fVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fVertex3fvSUN(GLfloat* tc, GLfloat* v);
        internal static TexCoord2fVertex3fvSUN glTexCoord2fVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        internal static TexCoord4fVertex4fSUN glTexCoord4fVertex4fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4fVertex4fvSUN(GLfloat* tc, GLfloat* v);
        internal static TexCoord4fVertex4fvSUN glTexCoord4fVertex4fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2fColor4ubVertex3fSUN(GLfloat s, GLfloat t, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
        internal static TexCoord2fColor4ubVertex3fSUN glTexCoord2fColor4ubVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fColor4ubVertex3fvSUN(GLfloat* tc, GLubyte* c, GLfloat* v);
        internal static TexCoord2fColor4ubVertex3fvSUN glTexCoord2fColor4ubVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2fColor3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
        internal static TexCoord2fColor3fVertex3fSUN glTexCoord2fColor3fVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fColor3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat* v);
        internal static TexCoord2fColor3fVertex3fvSUN glTexCoord2fColor3fVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        internal static TexCoord2fNormal3fVertex3fSUN glTexCoord2fNormal3fVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* n, GLfloat* v);
        internal static TexCoord2fNormal3fVertex3fvSUN glTexCoord2fNormal3fVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2fColor4fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        internal static TexCoord2fColor4fNormal3fVertex3fSUN glTexCoord2fColor4fNormal3fVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v);
        internal static TexCoord2fColor4fNormal3fVertex3fvSUN glTexCoord2fColor4fNormal3fVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4fColor4fNormal3fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        internal static TexCoord4fColor4fNormal3fVertex4fSUN glTexCoord4fColor4fNormal3fVertex4fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v);
        internal static TexCoord4fColor4fNormal3fVertex4fvSUN glTexCoord4fColor4fNormal3fVertex4fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiVertex3fSUN(GLuint rc, GLfloat x, GLfloat y, GLfloat z);
        internal static ReplacementCodeuiVertex3fSUN glReplacementCodeuiVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiVertex3fvSUN(GLuint* rc, GLfloat* v);
        internal static ReplacementCodeuiVertex3fvSUN glReplacementCodeuiVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiColor4ubVertex3fSUN(GLuint rc, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
        internal static ReplacementCodeuiColor4ubVertex3fSUN glReplacementCodeuiColor4ubVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint* rc, GLubyte* c, GLfloat* v);
        internal static ReplacementCodeuiColor4ubVertex3fvSUN glReplacementCodeuiColor4ubVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiColor3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
        internal static ReplacementCodeuiColor3fVertex3fSUN glReplacementCodeuiColor3fVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiColor3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat* v);
        internal static ReplacementCodeuiColor3fVertex3fvSUN glReplacementCodeuiColor3fVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiNormal3fVertex3fSUN(GLuint rc, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        internal static ReplacementCodeuiNormal3fVertex3fSUN glReplacementCodeuiNormal3fVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint* rc, GLfloat* n, GLfloat* v);
        internal static ReplacementCodeuiNormal3fVertex3fvSUN glReplacementCodeuiNormal3fVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        internal static ReplacementCodeuiColor4fNormal3fVertex3fSUN glReplacementCodeuiColor4fNormal3fVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat* n, GLfloat* v);
        internal static ReplacementCodeuiColor4fNormal3fVertex3fvSUN glReplacementCodeuiColor4fNormal3fVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiTexCoord2fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z);
        internal static ReplacementCodeuiTexCoord2fVertex3fSUN glReplacementCodeuiTexCoord2fVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* v);
        internal static ReplacementCodeuiTexCoord2fVertex3fvSUN glReplacementCodeuiTexCoord2fVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        internal static ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* n, GLfloat* v);
        internal static ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        internal static ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v);
        internal static ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendFuncSeparateEXT(GL.Enums.EXT_blend_func_separate sfactorRGB, GL.Enums.EXT_blend_func_separate dfactorRGB, GL.Enums.EXT_blend_func_separate sfactorAlpha, GL.Enums.EXT_blend_func_separate dfactorAlpha);
        internal static BlendFuncSeparateEXT glBlendFuncSeparateEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendFuncSeparateINGR(GL.Enums.GLenum sfactorRGB, GL.Enums.GLenum dfactorRGB, GL.Enums.GLenum sfactorAlpha, GL.Enums.GLenum dfactorAlpha);
        internal static BlendFuncSeparateINGR glBlendFuncSeparateINGR;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexWeightfEXT(GLfloat weight);
        internal static VertexWeightfEXT glVertexWeightfEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexWeightfvEXT(GLfloat* weight);
        internal static VertexWeightfvEXT glVertexWeightfvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexWeightPointerEXT(GLsizei size, GL.Enums.EXT_vertex_weighting type, GLsizei stride, void* pointer);
        internal static VertexWeightPointerEXT glVertexWeightPointerEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FlushVertexArrayRangeNV();
        internal static FlushVertexArrayRangeNV glFlushVertexArrayRangeNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexArrayRangeNV(GLsizei length, void* pointer);
        internal static VertexArrayRangeNV glVertexArrayRangeNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CombinerParameterfvNV(GL.Enums.NV_register_combiners pname, GLfloat* @params);
        internal static CombinerParameterfvNV glCombinerParameterfvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CombinerParameterfNV(GL.Enums.NV_register_combiners pname, GLfloat param);
        internal static CombinerParameterfNV glCombinerParameterfNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CombinerParameterivNV(GL.Enums.NV_register_combiners pname, GLint* @params);
        internal static CombinerParameterivNV glCombinerParameterivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CombinerParameteriNV(GL.Enums.NV_register_combiners pname, GLint param);
        internal static CombinerParameteriNV glCombinerParameteriNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CombinerInputNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners input, GL.Enums.NV_register_combiners mapping, GL.Enums.NV_register_combiners componentUsage);
        internal static CombinerInputNV glCombinerInputNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void CombinerOutputNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners abOutput, GL.Enums.NV_register_combiners cdOutput, GL.Enums.NV_register_combiners sumOutput, GL.Enums.NV_register_combiners scale, GL.Enums.NV_register_combiners bias, GL.Enums.Boolean abDotProduct, GL.Enums.Boolean cdDotProduct, GL.Enums.Boolean muxSum);
        internal static CombinerOutputNV glCombinerOutputNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FinalCombinerInputNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners input, GL.Enums.NV_register_combiners mapping, GL.Enums.NV_register_combiners componentUsage);
        internal static FinalCombinerInputNV glFinalCombinerInputNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCombinerInputParameterfvNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, GLfloat* @params);
        internal static GetCombinerInputParameterfvNV glGetCombinerInputParameterfvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCombinerInputParameterivNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, GLint* @params);
        internal static GetCombinerInputParameterivNV glGetCombinerInputParameterivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCombinerOutputParameterfvNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners pname, GLfloat* @params);
        internal static GetCombinerOutputParameterfvNV glGetCombinerOutputParameterfvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCombinerOutputParameterivNV(GL.Enums.NV_register_combiners stage, GL.Enums.NV_register_combiners portion, GL.Enums.NV_register_combiners pname, GLint* @params);
        internal static GetCombinerOutputParameterivNV glGetCombinerOutputParameterivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFinalCombinerInputParameterfvNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, GLfloat* @params);
        internal static GetFinalCombinerInputParameterfvNV glGetFinalCombinerInputParameterfvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFinalCombinerInputParameterivNV(GL.Enums.NV_register_combiners variable, GL.Enums.NV_register_combiners pname, GLint* @params);
        internal static GetFinalCombinerInputParameterivNV glGetFinalCombinerInputParameterivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ResizeBuffersMESA();
        internal static ResizeBuffersMESA glResizeBuffersMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2dMESA(GLdouble x, GLdouble y);
        internal static WindowPos2dMESA glWindowPos2dMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2dvMESA(GLdouble* v);
        internal static WindowPos2dvMESA glWindowPos2dvMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2fMESA(GLfloat x, GLfloat y);
        internal static WindowPos2fMESA glWindowPos2fMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2fvMESA(GLfloat* v);
        internal static WindowPos2fvMESA glWindowPos2fvMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2iMESA(GLint x, GLint y);
        internal static WindowPos2iMESA glWindowPos2iMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2ivMESA(GLint* v);
        internal static WindowPos2ivMESA glWindowPos2ivMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos2sMESA(GLshort x, GLshort y);
        internal static WindowPos2sMESA glWindowPos2sMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos2svMESA(GLshort* v);
        internal static WindowPos2svMESA glWindowPos2svMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3dMESA(GLdouble x, GLdouble y, GLdouble z);
        internal static WindowPos3dMESA glWindowPos3dMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3dvMESA(GLdouble* v);
        internal static WindowPos3dvMESA glWindowPos3dvMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3fMESA(GLfloat x, GLfloat y, GLfloat z);
        internal static WindowPos3fMESA glWindowPos3fMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3fvMESA(GLfloat* v);
        internal static WindowPos3fvMESA glWindowPos3fvMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3iMESA(GLint x, GLint y, GLint z);
        internal static WindowPos3iMESA glWindowPos3iMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3ivMESA(GLint* v);
        internal static WindowPos3ivMESA glWindowPos3ivMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos3sMESA(GLshort x, GLshort y, GLshort z);
        internal static WindowPos3sMESA glWindowPos3sMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos3svMESA(GLshort* v);
        internal static WindowPos3svMESA glWindowPos3svMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos4dMESA(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        internal static WindowPos4dMESA glWindowPos4dMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos4dvMESA(GLdouble* v);
        internal static WindowPos4dvMESA glWindowPos4dvMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos4fMESA(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        internal static WindowPos4fMESA glWindowPos4fMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos4fvMESA(GLfloat* v);
        internal static WindowPos4fvMESA glWindowPos4fvMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos4iMESA(GLint x, GLint y, GLint z, GLint w);
        internal static WindowPos4iMESA glWindowPos4iMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos4ivMESA(GLint* v);
        internal static WindowPos4ivMESA glWindowPos4ivMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WindowPos4sMESA(GLshort x, GLshort y, GLshort z, GLshort w);
        internal static WindowPos4sMESA glWindowPos4sMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void WindowPos4svMESA(GLshort* v);
        internal static WindowPos4svMESA glWindowPos4svMESA;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiModeDrawArraysIBM(GL.Enums.BeginMode* mode, GLint* first, GLsizei* count, GLsizei primcount, GLint modestride);
        internal static MultiModeDrawArraysIBM glMultiModeDrawArraysIBM;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiModeDrawElementsIBM(GL.Enums.BeginMode* mode, GLsizei* count, GL.Enums.IBM_multimode_draw_arrays type, void* indices, GLsizei primcount, GLint modestride);
        internal static MultiModeDrawElementsIBM glMultiModeDrawElementsIBM;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ColorPointerListIBM(GLint size, GL.Enums.ColorPointerType type, GLint stride, void* pointer, GLint ptrstride);
        internal static ColorPointerListIBM glColorPointerListIBM;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColorPointerListIBM(GLint size, GL.Enums.IBM_vertex_array_lists type, GLint stride, void* pointer, GLint ptrstride);
        internal static SecondaryColorPointerListIBM glSecondaryColorPointerListIBM;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EdgeFlagPointerListIBM(GLint stride, GLboolean* pointer, GLint ptrstride);
        internal static EdgeFlagPointerListIBM glEdgeFlagPointerListIBM;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordPointerListIBM(GL.Enums.IBM_vertex_array_lists type, GLint stride, void* pointer, GLint ptrstride);
        internal static FogCoordPointerListIBM glFogCoordPointerListIBM;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void IndexPointerListIBM(GL.Enums.IndexPointerType type, GLint stride, void* pointer, GLint ptrstride);
        internal static IndexPointerListIBM glIndexPointerListIBM;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalPointerListIBM(GL.Enums.NormalPointerType type, GLint stride, void* pointer, GLint ptrstride);
        internal static NormalPointerListIBM glNormalPointerListIBM;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoordPointerListIBM(GLint size, GL.Enums.TexCoordPointerType type, GLint stride, void* pointer, GLint ptrstride);
        internal static TexCoordPointerListIBM glTexCoordPointerListIBM;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexPointerListIBM(GLint size, GL.Enums.VertexPointerType type, GLint stride, void* pointer, GLint ptrstride);
        internal static VertexPointerListIBM glVertexPointerListIBM;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TbufferMask3DFX(GLuint mask);
        internal static TbufferMask3DFX glTbufferMask3DFX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleMaskEXT(GLclampf value, GL.Enums.Boolean invert);
        internal static SampleMaskEXT glSampleMaskEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SamplePatternEXT(GL.Enums.EXT_multisample pattern);
        internal static SamplePatternEXT glSamplePatternEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TextureColorMaskSGIS(GL.Enums.Boolean red, GL.Enums.Boolean green, GL.Enums.Boolean blue, GL.Enums.Boolean alpha);
        internal static TextureColorMaskSGIS glTextureColorMaskSGIS;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void IglooInterfaceSGIX(GL.Enums.GLenum pname, void* @params);
        internal static IglooInterfaceSGIX glIglooInterfaceSGIX;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteFencesNV(GLsizei n, GLuint* fences);
        internal static DeleteFencesNV glDeleteFencesNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenFencesNV(GLsizei n, GLuint* fences);
        internal static GenFencesNV glGenFencesNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsFenceNV(GLuint fence);
        internal static IsFenceNV glIsFenceNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean TestFenceNV(GLuint fence);
        internal static TestFenceNV glTestFenceNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFenceivNV(GLuint fence, GL.Enums.NV_fence pname, GLint* @params);
        internal static GetFenceivNV glGetFenceivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FinishFenceNV(GLuint fence);
        internal static FinishFenceNV glFinishFenceNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SetFenceNV(GLuint fence, GL.Enums.NV_fence condition);
        internal static SetFenceNV glSetFenceNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MapControlPointsNV(GL.Enums.NV_evaluators target, GLuint index, GL.Enums.NV_evaluators type, GLsizei ustride, GLsizei vstride, GLint uorder, GLint vorder, GL.Enums.Boolean packed, void* points);
        internal static MapControlPointsNV glMapControlPointsNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MapParameterivNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, GLint* @params);
        internal static MapParameterivNV glMapParameterivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MapParameterfvNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, GLfloat* @params);
        internal static MapParameterfvNV glMapParameterfvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapControlPointsNV(GL.Enums.NV_evaluators target, GLuint index, GL.Enums.NV_evaluators type, GLsizei ustride, GLsizei vstride, GL.Enums.Boolean packed, void* points);
        internal static GetMapControlPointsNV glGetMapControlPointsNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapParameterivNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, GLint* @params);
        internal static GetMapParameterivNV glGetMapParameterivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapParameterfvNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators pname, GLfloat* @params);
        internal static GetMapParameterfvNV glGetMapParameterfvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapAttribParameterivNV(GL.Enums.NV_evaluators target, GLuint index, GL.Enums.NV_evaluators pname, GLint* @params);
        internal static GetMapAttribParameterivNV glGetMapAttribParameterivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetMapAttribParameterfvNV(GL.Enums.NV_evaluators target, GLuint index, GL.Enums.NV_evaluators pname, GLfloat* @params);
        internal static GetMapAttribParameterfvNV glGetMapAttribParameterfvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EvalMapsNV(GL.Enums.NV_evaluators target, GL.Enums.NV_evaluators mode);
        internal static EvalMapsNV glEvalMapsNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void CombinerStageParameterfvNV(GL.Enums.NV_register_combiners2 stage, GL.Enums.NV_register_combiners2 pname, GLfloat* @params);
        internal static CombinerStageParameterfvNV glCombinerStageParameterfvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetCombinerStageParameterfvNV(GL.Enums.NV_register_combiners2 stage, GL.Enums.NV_register_combiners2 pname, GLfloat* @params);
        internal static GetCombinerStageParameterfvNV glGetCombinerStageParameterfvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate GLboolean AreProgramsResidentNV(GLsizei n, GLuint* programs, GL.Enums.Boolean* residences);
        internal static AreProgramsResidentNV glAreProgramsResidentNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindProgramNV(GL.Enums.NV_vertex_program target, GLuint id);
        internal static BindProgramNV glBindProgramNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteProgramsNV(GLsizei n, GLuint* programs);
        internal static DeleteProgramsNV glDeleteProgramsNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ExecuteProgramNV(GL.Enums.NV_vertex_program target, GLuint id, GLfloat* @params);
        internal static ExecuteProgramNV glExecuteProgramNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenProgramsNV(GLsizei n, GLuint* programs);
        internal static GenProgramsNV glGenProgramsNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramParameterdvNV(GL.Enums.NV_vertex_program target, GLuint index, GL.Enums.NV_vertex_program pname, GLdouble* @params);
        internal static GetProgramParameterdvNV glGetProgramParameterdvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramParameterfvNV(GL.Enums.NV_vertex_program target, GLuint index, GL.Enums.NV_vertex_program pname, GLfloat* @params);
        internal static GetProgramParameterfvNV glGetProgramParameterfvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramivNV(GLuint id, GL.Enums.NV_vertex_program pname, GLint* @params);
        internal static GetProgramivNV glGetProgramivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramStringNV(GLuint id, GL.Enums.NV_vertex_program pname, GLubyte* program);
        internal static GetProgramStringNV glGetProgramStringNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTrackMatrixivNV(GL.Enums.NV_vertex_program target, GLuint address, GL.Enums.NV_vertex_program pname, GLint* @params);
        internal static GetTrackMatrixivNV glGetTrackMatrixivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribdvNV(GLuint index, GL.Enums.NV_vertex_program pname, GLdouble* @params);
        internal static GetVertexAttribdvNV glGetVertexAttribdvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribfvNV(GLuint index, GL.Enums.NV_vertex_program pname, GLfloat* @params);
        internal static GetVertexAttribfvNV glGetVertexAttribfvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribivNV(GLuint index, GL.Enums.NV_vertex_program pname, GLint* @params);
        internal static GetVertexAttribivNV glGetVertexAttribivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribPointervNV(GLuint index, GL.Enums.NV_vertex_program pname, void* pointer);
        internal static GetVertexAttribPointervNV glGetVertexAttribPointervNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsProgramNV(GLuint id);
        internal static IsProgramNV glIsProgramNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void LoadProgramNV(GL.Enums.NV_vertex_program target, GLuint id, GLsizei len, GLubyte* program);
        internal static LoadProgramNV glLoadProgramNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramParameter4dNV(GL.Enums.NV_vertex_program target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        internal static ProgramParameter4dNV glProgramParameter4dNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramParameter4dvNV(GL.Enums.NV_vertex_program target, GLuint index, GLdouble* v);
        internal static ProgramParameter4dvNV glProgramParameter4dvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramParameter4fNV(GL.Enums.NV_vertex_program target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        internal static ProgramParameter4fNV glProgramParameter4fNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramParameter4fvNV(GL.Enums.NV_vertex_program target, GLuint index, GLfloat* v);
        internal static ProgramParameter4fvNV glProgramParameter4fvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramParameters4dvNV(GL.Enums.NV_vertex_program target, GLuint index, GLuint count, GLdouble* v);
        internal static ProgramParameters4dvNV glProgramParameters4dvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramParameters4fvNV(GL.Enums.NV_vertex_program target, GLuint index, GLuint count, GLfloat* v);
        internal static ProgramParameters4fvNV glProgramParameters4fvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void RequestResidentProgramsNV(GLsizei n, GLuint* programs);
        internal static RequestResidentProgramsNV glRequestResidentProgramsNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TrackMatrixNV(GL.Enums.NV_vertex_program target, GLuint address, GL.Enums.NV_vertex_program matrix, GL.Enums.NV_vertex_program transform);
        internal static TrackMatrixNV glTrackMatrixNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribPointerNV(GLuint index, GLint fsize, GL.Enums.NV_vertex_program type, GLsizei stride, void* pointer);
        internal static VertexAttribPointerNV glVertexAttribPointerNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1dNV(GLuint index, GLdouble x);
        internal static VertexAttrib1dNV glVertexAttrib1dNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1dvNV(GLuint index, GLdouble* v);
        internal static VertexAttrib1dvNV glVertexAttrib1dvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1fNV(GLuint index, GLfloat x);
        internal static VertexAttrib1fNV glVertexAttrib1fNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1fvNV(GLuint index, GLfloat* v);
        internal static VertexAttrib1fvNV glVertexAttrib1fvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1sNV(GLuint index, GLshort x);
        internal static VertexAttrib1sNV glVertexAttrib1sNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1svNV(GLuint index, GLshort* v);
        internal static VertexAttrib1svNV glVertexAttrib1svNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2dNV(GLuint index, GLdouble x, GLdouble y);
        internal static VertexAttrib2dNV glVertexAttrib2dNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2dvNV(GLuint index, GLdouble* v);
        internal static VertexAttrib2dvNV glVertexAttrib2dvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2fNV(GLuint index, GLfloat x, GLfloat y);
        internal static VertexAttrib2fNV glVertexAttrib2fNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2fvNV(GLuint index, GLfloat* v);
        internal static VertexAttrib2fvNV glVertexAttrib2fvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2sNV(GLuint index, GLshort x, GLshort y);
        internal static VertexAttrib2sNV glVertexAttrib2sNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2svNV(GLuint index, GLshort* v);
        internal static VertexAttrib2svNV glVertexAttrib2svNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z);
        internal static VertexAttrib3dNV glVertexAttrib3dNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3dvNV(GLuint index, GLdouble* v);
        internal static VertexAttrib3dvNV glVertexAttrib3dvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z);
        internal static VertexAttrib3fNV glVertexAttrib3fNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3fvNV(GLuint index, GLfloat* v);
        internal static VertexAttrib3fvNV glVertexAttrib3fvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3sNV(GLuint index, GLshort x, GLshort y, GLshort z);
        internal static VertexAttrib3sNV glVertexAttrib3sNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3svNV(GLuint index, GLshort* v);
        internal static VertexAttrib3svNV glVertexAttrib3svNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        internal static VertexAttrib4dNV glVertexAttrib4dNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4dvNV(GLuint index, GLdouble* v);
        internal static VertexAttrib4dvNV glVertexAttrib4dvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        internal static VertexAttrib4fNV glVertexAttrib4fNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4fvNV(GLuint index, GLfloat* v);
        internal static VertexAttrib4fvNV glVertexAttrib4fvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4sNV(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
        internal static VertexAttrib4sNV glVertexAttrib4sNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4svNV(GLuint index, GLshort* v);
        internal static VertexAttrib4svNV glVertexAttrib4svNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4ubNV(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
        internal static VertexAttrib4ubNV glVertexAttrib4ubNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4ubvNV(GLuint index, GLubyte* v);
        internal static VertexAttrib4ubvNV glVertexAttrib4ubvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs1dvNV(GLuint index, GLsizei count, GLdouble* v);
        internal static VertexAttribs1dvNV glVertexAttribs1dvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs1fvNV(GLuint index, GLsizei count, GLfloat* v);
        internal static VertexAttribs1fvNV glVertexAttribs1fvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs1svNV(GLuint index, GLsizei count, GLshort* v);
        internal static VertexAttribs1svNV glVertexAttribs1svNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs2dvNV(GLuint index, GLsizei count, GLdouble* v);
        internal static VertexAttribs2dvNV glVertexAttribs2dvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs2fvNV(GLuint index, GLsizei count, GLfloat* v);
        internal static VertexAttribs2fvNV glVertexAttribs2fvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs2svNV(GLuint index, GLsizei count, GLshort* v);
        internal static VertexAttribs2svNV glVertexAttribs2svNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs3dvNV(GLuint index, GLsizei count, GLdouble* v);
        internal static VertexAttribs3dvNV glVertexAttribs3dvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs3fvNV(GLuint index, GLsizei count, GLfloat* v);
        internal static VertexAttribs3fvNV glVertexAttribs3fvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs3svNV(GLuint index, GLsizei count, GLshort* v);
        internal static VertexAttribs3svNV glVertexAttribs3svNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs4dvNV(GLuint index, GLsizei count, GLdouble* v);
        internal static VertexAttribs4dvNV glVertexAttribs4dvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs4fvNV(GLuint index, GLsizei count, GLfloat* v);
        internal static VertexAttribs4fvNV glVertexAttribs4fvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs4svNV(GLuint index, GLsizei count, GLshort* v);
        internal static VertexAttribs4svNV glVertexAttribs4svNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs4ubvNV(GLuint index, GLsizei count, GLubyte* v);
        internal static VertexAttribs4ubvNV glVertexAttribs4ubvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexBumpParameterivATI(GL.Enums.ATI_envmap_bumpmap pname, GLint* param);
        internal static TexBumpParameterivATI glTexBumpParameterivATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexBumpParameterfvATI(GL.Enums.ATI_envmap_bumpmap pname, GLfloat* param);
        internal static TexBumpParameterfvATI glTexBumpParameterfvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexBumpParameterivATI(GL.Enums.ATI_envmap_bumpmap pname, GLint* param);
        internal static GetTexBumpParameterivATI glGetTexBumpParameterivATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexBumpParameterfvATI(GL.Enums.ATI_envmap_bumpmap pname, GLfloat* param);
        internal static GetTexBumpParameterfvATI glGetTexBumpParameterfvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLuint GenFragmentShadersATI(GLuint range);
        internal static GenFragmentShadersATI glGenFragmentShadersATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindFragmentShaderATI(GLuint id);
        internal static BindFragmentShaderATI glBindFragmentShaderATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteFragmentShaderATI(GLuint id);
        internal static DeleteFragmentShaderATI glDeleteFragmentShaderATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginFragmentShaderATI();
        internal static BeginFragmentShaderATI glBeginFragmentShaderATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndFragmentShaderATI();
        internal static EndFragmentShaderATI glEndFragmentShaderATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PassTexCoordATI(GLuint dst, GLuint coord, GL.Enums.ATI_fragment_shader swizzle);
        internal static PassTexCoordATI glPassTexCoordATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SampleMapATI(GLuint dst, GLuint interp, GL.Enums.ATI_fragment_shader swizzle);
        internal static SampleMapATI glSampleMapATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorFragmentOp1ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod);
        internal static ColorFragmentOp1ATI glColorFragmentOp1ATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorFragmentOp2ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod);
        internal static ColorFragmentOp2ATI glColorFragmentOp2ATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorFragmentOp3ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod);
        internal static ColorFragmentOp3ATI glColorFragmentOp3ATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AlphaFragmentOp1ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod);
        internal static AlphaFragmentOp1ATI glAlphaFragmentOp1ATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AlphaFragmentOp2ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod);
        internal static AlphaFragmentOp2ATI glAlphaFragmentOp2ATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void AlphaFragmentOp3ATI(GL.Enums.ATI_fragment_shader op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod);
        internal static AlphaFragmentOp3ATI glAlphaFragmentOp3ATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SetFragmentShaderConstantATI(GLuint dst, GLfloat* value);
        internal static SetFragmentShaderConstantATI glSetFragmentShaderConstantATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PNTrianglesiATI(GL.Enums.ATI_pn_triangles pname, GLint param);
        internal static PNTrianglesiATI glPNTrianglesiATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PNTrianglesfATI(GL.Enums.ATI_pn_triangles pname, GLfloat param);
        internal static PNTrianglesfATI glPNTrianglesfATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate GLuint NewObjectBufferATI(GLsizei size, void* pointer, GL.Enums.ATI_vertex_array_object usage);
        internal static NewObjectBufferATI glNewObjectBufferATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsObjectBufferATI(GLuint buffer);
        internal static IsObjectBufferATI glIsObjectBufferATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void UpdateObjectBufferATI(GLuint buffer, GLuint offset, GLsizei size, void* pointer, GL.Enums.ATI_vertex_array_object preserve);
        internal static UpdateObjectBufferATI glUpdateObjectBufferATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetObjectBufferfvATI(GLuint buffer, GL.Enums.ATI_vertex_array_object pname, GLfloat* @params);
        internal static GetObjectBufferfvATI glGetObjectBufferfvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetObjectBufferivATI(GLuint buffer, GL.Enums.ATI_vertex_array_object pname, GLint* @params);
        internal static GetObjectBufferivATI glGetObjectBufferivATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FreeObjectBufferATI(GLuint buffer);
        internal static FreeObjectBufferATI glFreeObjectBufferATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ArrayObjectATI(GL.Enums.EnableCap array, GLint size, GL.Enums.ATI_vertex_array_object type, GLsizei stride, GLuint buffer, GLuint offset);
        internal static ArrayObjectATI glArrayObjectATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetArrayObjectfvATI(GL.Enums.EnableCap array, GL.Enums.ATI_vertex_array_object pname, GLfloat* @params);
        internal static GetArrayObjectfvATI glGetArrayObjectfvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetArrayObjectivATI(GL.Enums.EnableCap array, GL.Enums.ATI_vertex_array_object pname, GLint* @params);
        internal static GetArrayObjectivATI glGetArrayObjectivATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VariantArrayObjectATI(GLuint id, GL.Enums.ATI_vertex_array_object type, GLsizei stride, GLuint buffer, GLuint offset);
        internal static VariantArrayObjectATI glVariantArrayObjectATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantArrayObjectfvATI(GLuint id, GL.Enums.ATI_vertex_array_object pname, GLfloat* @params);
        internal static GetVariantArrayObjectfvATI glGetVariantArrayObjectfvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantArrayObjectivATI(GLuint id, GL.Enums.ATI_vertex_array_object pname, GLint* @params);
        internal static GetVariantArrayObjectivATI glGetVariantArrayObjectivATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginVertexShaderEXT();
        internal static BeginVertexShaderEXT glBeginVertexShaderEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndVertexShaderEXT();
        internal static EndVertexShaderEXT glEndVertexShaderEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindVertexShaderEXT(GLuint id);
        internal static BindVertexShaderEXT glBindVertexShaderEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLuint GenVertexShadersEXT(GLuint range);
        internal static GenVertexShadersEXT glGenVertexShadersEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DeleteVertexShaderEXT(GLuint id);
        internal static DeleteVertexShaderEXT glDeleteVertexShaderEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ShaderOp1EXT(GL.Enums.EXT_vertex_shader op, GLuint res, GLuint arg1);
        internal static ShaderOp1EXT glShaderOp1EXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ShaderOp2EXT(GL.Enums.EXT_vertex_shader op, GLuint res, GLuint arg1, GLuint arg2);
        internal static ShaderOp2EXT glShaderOp2EXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ShaderOp3EXT(GL.Enums.EXT_vertex_shader op, GLuint res, GLuint arg1, GLuint arg2, GLuint arg3);
        internal static ShaderOp3EXT glShaderOp3EXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SwizzleEXT(GLuint res, GLuint @in, GL.Enums.EXT_vertex_shader outX, GL.Enums.EXT_vertex_shader outY, GL.Enums.EXT_vertex_shader outZ, GL.Enums.EXT_vertex_shader outW);
        internal static SwizzleEXT glSwizzleEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void WriteMaskEXT(GLuint res, GLuint @in, GL.Enums.EXT_vertex_shader outX, GL.Enums.EXT_vertex_shader outY, GL.Enums.EXT_vertex_shader outZ, GL.Enums.EXT_vertex_shader outW);
        internal static WriteMaskEXT glWriteMaskEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void InsertComponentEXT(GLuint res, GLuint src, GLuint num);
        internal static InsertComponentEXT glInsertComponentEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ExtractComponentEXT(GLuint res, GLuint src, GLuint num);
        internal static ExtractComponentEXT glExtractComponentEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLuint GenSymbolsEXT(GL.Enums.EXT_vertex_shader datatype, GL.Enums.EXT_vertex_shader storagetype, GL.Enums.EXT_vertex_shader range, GLuint components);
        internal static GenSymbolsEXT glGenSymbolsEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SetInvariantEXT(GLuint id, GL.Enums.EXT_vertex_shader type, void* addr);
        internal static SetInvariantEXT glSetInvariantEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SetLocalConstantEXT(GLuint id, GL.Enums.EXT_vertex_shader type, void* addr);
        internal static SetLocalConstantEXT glSetLocalConstantEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantbvEXT(GLuint id, GLbyte* addr);
        internal static VariantbvEXT glVariantbvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantsvEXT(GLuint id, GLshort* addr);
        internal static VariantsvEXT glVariantsvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantivEXT(GLuint id, GLint* addr);
        internal static VariantivEXT glVariantivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantfvEXT(GLuint id, GLfloat* addr);
        internal static VariantfvEXT glVariantfvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantdvEXT(GLuint id, GLdouble* addr);
        internal static VariantdvEXT glVariantdvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantubvEXT(GLuint id, GLubyte* addr);
        internal static VariantubvEXT glVariantubvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantusvEXT(GLuint id, GLushort* addr);
        internal static VariantusvEXT glVariantusvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantuivEXT(GLuint id, GLuint* addr);
        internal static VariantuivEXT glVariantuivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VariantPointerEXT(GLuint id, GL.Enums.EXT_vertex_shader type, GLuint stride, void* addr);
        internal static VariantPointerEXT glVariantPointerEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableVariantClientStateEXT(GLuint id);
        internal static EnableVariantClientStateEXT glEnableVariantClientStateEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableVariantClientStateEXT(GLuint id);
        internal static DisableVariantClientStateEXT glDisableVariantClientStateEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLuint BindLightParameterEXT(GL.Enums.LightName light, GL.Enums.LightParameter value);
        internal static BindLightParameterEXT glBindLightParameterEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLuint BindMaterialParameterEXT(GL.Enums.MaterialFace face, GL.Enums.MaterialParameter value);
        internal static BindMaterialParameterEXT glBindMaterialParameterEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLuint BindTexGenParameterEXT(GL.Enums.EXT_vertex_shader unit, GL.Enums.TextureCoordName coord, GL.Enums.TextureGenParameter value);
        internal static BindTexGenParameterEXT glBindTexGenParameterEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLuint BindTextureUnitParameterEXT(GL.Enums.EXT_vertex_shader unit, GL.Enums.EXT_vertex_shader value);
        internal static BindTextureUnitParameterEXT glBindTextureUnitParameterEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLuint BindParameterEXT(GL.Enums.EXT_vertex_shader value);
        internal static BindParameterEXT glBindParameterEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsVariantEnabledEXT(GLuint id, GL.Enums.EXT_vertex_shader cap);
        internal static IsVariantEnabledEXT glIsVariantEnabledEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantBooleanvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GL.Enums.Boolean* data);
        internal static GetVariantBooleanvEXT glGetVariantBooleanvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantIntegervEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLint* data);
        internal static GetVariantIntegervEXT glGetVariantIntegervEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantFloatvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLfloat* data);
        internal static GetVariantFloatvEXT glGetVariantFloatvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVariantPointervEXT(GLuint id, GL.Enums.EXT_vertex_shader value, void* data);
        internal static GetVariantPointervEXT glGetVariantPointervEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetInvariantBooleanvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GL.Enums.Boolean* data);
        internal static GetInvariantBooleanvEXT glGetInvariantBooleanvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetInvariantIntegervEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLint* data);
        internal static GetInvariantIntegervEXT glGetInvariantIntegervEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetInvariantFloatvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLfloat* data);
        internal static GetInvariantFloatvEXT glGetInvariantFloatvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetLocalConstantBooleanvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GL.Enums.Boolean* data);
        internal static GetLocalConstantBooleanvEXT glGetLocalConstantBooleanvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetLocalConstantIntegervEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLint* data);
        internal static GetLocalConstantIntegervEXT glGetLocalConstantIntegervEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetLocalConstantFloatvEXT(GLuint id, GL.Enums.EXT_vertex_shader value, GLfloat* data);
        internal static GetLocalConstantFloatvEXT glGetLocalConstantFloatvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream1sATI(GL.Enums.ATI_vertex_streams stream, GLshort x);
        internal static VertexStream1sATI glVertexStream1sATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream1svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords);
        internal static VertexStream1svATI glVertexStream1svATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream1iATI(GL.Enums.ATI_vertex_streams stream, GLint x);
        internal static VertexStream1iATI glVertexStream1iATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream1ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords);
        internal static VertexStream1ivATI glVertexStream1ivATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream1fATI(GL.Enums.ATI_vertex_streams stream, GLfloat x);
        internal static VertexStream1fATI glVertexStream1fATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream1fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords);
        internal static VertexStream1fvATI glVertexStream1fvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream1dATI(GL.Enums.ATI_vertex_streams stream, GLdouble x);
        internal static VertexStream1dATI glVertexStream1dATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream1dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords);
        internal static VertexStream1dvATI glVertexStream1dvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream2sATI(GL.Enums.ATI_vertex_streams stream, GLshort x, GLshort y);
        internal static VertexStream2sATI glVertexStream2sATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream2svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords);
        internal static VertexStream2svATI glVertexStream2svATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream2iATI(GL.Enums.ATI_vertex_streams stream, GLint x, GLint y);
        internal static VertexStream2iATI glVertexStream2iATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream2ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords);
        internal static VertexStream2ivATI glVertexStream2ivATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream2fATI(GL.Enums.ATI_vertex_streams stream, GLfloat x, GLfloat y);
        internal static VertexStream2fATI glVertexStream2fATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream2fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords);
        internal static VertexStream2fvATI glVertexStream2fvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream2dATI(GL.Enums.ATI_vertex_streams stream, GLdouble x, GLdouble y);
        internal static VertexStream2dATI glVertexStream2dATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream2dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords);
        internal static VertexStream2dvATI glVertexStream2dvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream3sATI(GL.Enums.ATI_vertex_streams stream, GLshort x, GLshort y, GLshort z);
        internal static VertexStream3sATI glVertexStream3sATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream3svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords);
        internal static VertexStream3svATI glVertexStream3svATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream3iATI(GL.Enums.ATI_vertex_streams stream, GLint x, GLint y, GLint z);
        internal static VertexStream3iATI glVertexStream3iATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream3ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords);
        internal static VertexStream3ivATI glVertexStream3ivATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream3fATI(GL.Enums.ATI_vertex_streams stream, GLfloat x, GLfloat y, GLfloat z);
        internal static VertexStream3fATI glVertexStream3fATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream3fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords);
        internal static VertexStream3fvATI glVertexStream3fvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream3dATI(GL.Enums.ATI_vertex_streams stream, GLdouble x, GLdouble y, GLdouble z);
        internal static VertexStream3dATI glVertexStream3dATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream3dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords);
        internal static VertexStream3dvATI glVertexStream3dvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream4sATI(GL.Enums.ATI_vertex_streams stream, GLshort x, GLshort y, GLshort z, GLshort w);
        internal static VertexStream4sATI glVertexStream4sATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream4svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords);
        internal static VertexStream4svATI glVertexStream4svATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream4iATI(GL.Enums.ATI_vertex_streams stream, GLint x, GLint y, GLint z, GLint w);
        internal static VertexStream4iATI glVertexStream4iATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream4ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords);
        internal static VertexStream4ivATI glVertexStream4ivATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream4fATI(GL.Enums.ATI_vertex_streams stream, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        internal static VertexStream4fATI glVertexStream4fATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream4fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords);
        internal static VertexStream4fvATI glVertexStream4fvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexStream4dATI(GL.Enums.ATI_vertex_streams stream, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        internal static VertexStream4dATI glVertexStream4dATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexStream4dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords);
        internal static VertexStream4dvATI glVertexStream4dvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NormalStream3bATI(GL.Enums.ATI_vertex_streams stream, GLbyte nx, GLbyte ny, GLbyte nz);
        internal static NormalStream3bATI glNormalStream3bATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalStream3bvATI(GL.Enums.ATI_vertex_streams stream, GLbyte* coords);
        internal static NormalStream3bvATI glNormalStream3bvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NormalStream3sATI(GL.Enums.ATI_vertex_streams stream, GLshort nx, GLshort ny, GLshort nz);
        internal static NormalStream3sATI glNormalStream3sATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalStream3svATI(GL.Enums.ATI_vertex_streams stream, GLshort* coords);
        internal static NormalStream3svATI glNormalStream3svATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NormalStream3iATI(GL.Enums.ATI_vertex_streams stream, GLint nx, GLint ny, GLint nz);
        internal static NormalStream3iATI glNormalStream3iATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalStream3ivATI(GL.Enums.ATI_vertex_streams stream, GLint* coords);
        internal static NormalStream3ivATI glNormalStream3ivATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NormalStream3fATI(GL.Enums.ATI_vertex_streams stream, GLfloat nx, GLfloat ny, GLfloat nz);
        internal static NormalStream3fATI glNormalStream3fATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalStream3fvATI(GL.Enums.ATI_vertex_streams stream, GLfloat* coords);
        internal static NormalStream3fvATI glNormalStream3fvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void NormalStream3dATI(GL.Enums.ATI_vertex_streams stream, GLdouble nx, GLdouble ny, GLdouble nz);
        internal static NormalStream3dATI glNormalStream3dATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void NormalStream3dvATI(GL.Enums.ATI_vertex_streams stream, GLdouble* coords);
        internal static NormalStream3dvATI glNormalStream3dvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClientActiveVertexStreamATI(GL.Enums.ATI_vertex_streams stream);
        internal static ClientActiveVertexStreamATI glClientActiveVertexStreamATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexBlendEnviATI(GL.Enums.ATI_vertex_streams pname, GLint param);
        internal static VertexBlendEnviATI glVertexBlendEnviATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexBlendEnvfATI(GL.Enums.ATI_vertex_streams pname, GLfloat param);
        internal static VertexBlendEnvfATI glVertexBlendEnvfATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ElementPointerATI(GL.Enums.ATI_element_array type, void* pointer);
        internal static ElementPointerATI glElementPointerATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawElementArrayATI(GL.Enums.BeginMode mode, GLsizei count);
        internal static DrawElementArrayATI glDrawElementArrayATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawRangeElementArrayATI(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLsizei count);
        internal static DrawRangeElementArrayATI glDrawRangeElementArrayATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawMeshArraysSUN(GL.Enums.BeginMode mode, GLint first, GLsizei count, GLsizei width);
        internal static DrawMeshArraysSUN glDrawMeshArraysSUN;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenOcclusionQueriesNV(GLsizei n, GLuint* ids);
        internal static GenOcclusionQueriesNV glGenOcclusionQueriesNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteOcclusionQueriesNV(GLsizei n, GLuint* ids);
        internal static DeleteOcclusionQueriesNV glDeleteOcclusionQueriesNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsOcclusionQueryNV(GLuint id);
        internal static IsOcclusionQueryNV glIsOcclusionQueryNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginOcclusionQueryNV(GLuint id);
        internal static BeginOcclusionQueryNV glBeginOcclusionQueryNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndOcclusionQueryNV();
        internal static EndOcclusionQueryNV glEndOcclusionQueryNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetOcclusionQueryivNV(GLuint id, GL.Enums.NV_occlusion_query pname, GLint* @params);
        internal static GetOcclusionQueryivNV glGetOcclusionQueryivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetOcclusionQueryuivNV(GLuint id, GL.Enums.NV_occlusion_query pname, GLuint* @params);
        internal static GetOcclusionQueryuivNV glGetOcclusionQueryuivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PointParameteriNV(GL.Enums.NV_point_sprite pname, GLint param);
        internal static PointParameteriNV glPointParameteriNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PointParameterivNV(GL.Enums.NV_point_sprite pname, GLint* @params);
        internal static PointParameterivNV glPointParameterivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ActiveStencilFaceEXT(GL.Enums.EXT_stencil_two_side face);
        internal static ActiveStencilFaceEXT glActiveStencilFaceEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ElementPointerAPPLE(GL.Enums.APPLE_element_array type, void* pointer);
        internal static ElementPointerAPPLE glElementPointerAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawElementArrayAPPLE(GL.Enums.BeginMode mode, GLint first, GLsizei count);
        internal static DrawElementArrayAPPLE glDrawElementArrayAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawRangeElementArrayAPPLE(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLint first, GLsizei count);
        internal static DrawRangeElementArrayAPPLE glDrawRangeElementArrayAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawElementArrayAPPLE(GL.Enums.BeginMode mode, GLint* first, GLsizei* count, GLsizei primcount);
        internal static MultiDrawElementArrayAPPLE glMultiDrawElementArrayAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiDrawRangeElementArrayAPPLE(GL.Enums.BeginMode mode, GLuint start, GLuint end, GLint* first, GLsizei* count, GLsizei primcount);
        internal static MultiDrawRangeElementArrayAPPLE glMultiDrawRangeElementArrayAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenFencesAPPLE(GLsizei n, GLuint* fences);
        internal static GenFencesAPPLE glGenFencesAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteFencesAPPLE(GLsizei n, GLuint* fences);
        internal static DeleteFencesAPPLE glDeleteFencesAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SetFenceAPPLE(GLuint fence);
        internal static SetFenceAPPLE glSetFenceAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsFenceAPPLE(GLuint fence);
        internal static IsFenceAPPLE glIsFenceAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean TestFenceAPPLE(GLuint fence);
        internal static TestFenceAPPLE glTestFenceAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FinishFenceAPPLE(GLuint fence);
        internal static FinishFenceAPPLE glFinishFenceAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean TestObjectAPPLE(GL.Enums.APPLE_fence @object, GLuint name);
        internal static TestObjectAPPLE glTestObjectAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FinishObjectAPPLE(GL.Enums.APPLE_fence @object, GLint name);
        internal static FinishObjectAPPLE glFinishObjectAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindVertexArrayAPPLE(GLuint array);
        internal static BindVertexArrayAPPLE glBindVertexArrayAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteVertexArraysAPPLE(GLsizei n, GLuint* arrays);
        internal static DeleteVertexArraysAPPLE glDeleteVertexArraysAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenVertexArraysAPPLE(GLsizei n, GLuint* arrays);
        internal static GenVertexArraysAPPLE glGenVertexArraysAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsVertexArrayAPPLE(GLuint array);
        internal static IsVertexArrayAPPLE glIsVertexArrayAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexArrayRangeAPPLE(GLsizei length, void* pointer);
        internal static VertexArrayRangeAPPLE glVertexArrayRangeAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FlushVertexArrayRangeAPPLE(GLsizei length, void* pointer);
        internal static FlushVertexArrayRangeAPPLE glFlushVertexArrayRangeAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexArrayParameteriAPPLE(GL.Enums.APPLE_vertex_array_range pname, GLint param);
        internal static VertexArrayParameteriAPPLE glVertexArrayParameteriAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawBuffersATI(GLsizei n, GL.Enums.ATI_draw_buffers* bufs);
        internal static DrawBuffersATI glDrawBuffersATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramNamedParameter4fNV(GLuint id, GLsizei len, GLubyte* name, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        internal static ProgramNamedParameter4fNV glProgramNamedParameter4fNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramNamedParameter4dNV(GLuint id, GLsizei len, GLubyte* name, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        internal static ProgramNamedParameter4dNV glProgramNamedParameter4dNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramNamedParameter4fvNV(GLuint id, GLsizei len, GLubyte* name, GLfloat* v);
        internal static ProgramNamedParameter4fvNV glProgramNamedParameter4fvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramNamedParameter4dvNV(GLuint id, GLsizei len, GLubyte* name, GLdouble* v);
        internal static ProgramNamedParameter4dvNV glProgramNamedParameter4dvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramNamedParameterfvNV(GLuint id, GLsizei len, GLubyte* name, GLfloat* @params);
        internal static GetProgramNamedParameterfvNV glGetProgramNamedParameterfvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramNamedParameterdvNV(GLuint id, GLsizei len, GLubyte* name, GLdouble* @params);
        internal static GetProgramNamedParameterdvNV glGetProgramNamedParameterdvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex2hNV(GLhalfNV x, GLhalfNV y);
        internal static Vertex2hNV glVertex2hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex2hvNV(GLhalfNV* v);
        internal static Vertex2hvNV glVertex2hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex3hNV(GLhalfNV x, GLhalfNV y, GLhalfNV z);
        internal static Vertex3hNV glVertex3hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex3hvNV(GLhalfNV* v);
        internal static Vertex3hvNV glVertex3hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Vertex4hNV(GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w);
        internal static Vertex4hNV glVertex4hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Vertex4hvNV(GLhalfNV* v);
        internal static Vertex4hvNV glVertex4hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Normal3hNV(GLhalfNV nx, GLhalfNV ny, GLhalfNV nz);
        internal static Normal3hNV glNormal3hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Normal3hvNV(GLhalfNV* v);
        internal static Normal3hvNV glNormal3hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color3hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue);
        internal static Color3hNV glColor3hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color3hvNV(GLhalfNV* v);
        internal static Color3hvNV glColor3hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Color4hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue, GLhalfNV alpha);
        internal static Color4hNV glColor4hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Color4hvNV(GLhalfNV* v);
        internal static Color4hvNV glColor4hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord1hNV(GLhalfNV s);
        internal static TexCoord1hNV glTexCoord1hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord1hvNV(GLhalfNV* v);
        internal static TexCoord1hvNV glTexCoord1hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord2hNV(GLhalfNV s, GLhalfNV t);
        internal static TexCoord2hNV glTexCoord2hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord2hvNV(GLhalfNV* v);
        internal static TexCoord2hvNV glTexCoord2hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord3hNV(GLhalfNV s, GLhalfNV t, GLhalfNV r);
        internal static TexCoord3hNV glTexCoord3hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord3hvNV(GLhalfNV* v);
        internal static TexCoord3hvNV glTexCoord3hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexCoord4hNV(GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q);
        internal static TexCoord4hNV glTexCoord4hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexCoord4hvNV(GLhalfNV* v);
        internal static TexCoord4hvNV glTexCoord4hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord1hNV(GL.Enums.NV_half_float target, GLhalfNV s);
        internal static MultiTexCoord1hNV glMultiTexCoord1hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord1hvNV(GL.Enums.NV_half_float target, GLhalfNV* v);
        internal static MultiTexCoord1hvNV glMultiTexCoord1hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord2hNV(GL.Enums.NV_half_float target, GLhalfNV s, GLhalfNV t);
        internal static MultiTexCoord2hNV glMultiTexCoord2hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord2hvNV(GL.Enums.NV_half_float target, GLhalfNV* v);
        internal static MultiTexCoord2hvNV glMultiTexCoord2hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord3hNV(GL.Enums.NV_half_float target, GLhalfNV s, GLhalfNV t, GLhalfNV r);
        internal static MultiTexCoord3hNV glMultiTexCoord3hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord3hvNV(GL.Enums.NV_half_float target, GLhalfNV* v);
        internal static MultiTexCoord3hvNV glMultiTexCoord3hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MultiTexCoord4hNV(GL.Enums.NV_half_float target, GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q);
        internal static MultiTexCoord4hNV glMultiTexCoord4hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void MultiTexCoord4hvNV(GL.Enums.NV_half_float target, GLhalfNV* v);
        internal static MultiTexCoord4hvNV glMultiTexCoord4hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FogCoordhNV(GLhalfNV fog);
        internal static FogCoordhNV glFogCoordhNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void FogCoordhvNV(GLhalfNV* fog);
        internal static FogCoordhvNV glFogCoordhvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void SecondaryColor3hNV(GLhalfNV red, GLhalfNV green, GLhalfNV blue);
        internal static SecondaryColor3hNV glSecondaryColor3hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void SecondaryColor3hvNV(GLhalfNV* v);
        internal static SecondaryColor3hvNV glSecondaryColor3hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexWeighthNV(GLhalfNV weight);
        internal static VertexWeighthNV glVertexWeighthNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexWeighthvNV(GLhalfNV* weight);
        internal static VertexWeighthvNV glVertexWeighthvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib1hNV(GLuint index, GLhalfNV x);
        internal static VertexAttrib1hNV glVertexAttrib1hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib1hvNV(GLuint index, GLhalfNV* v);
        internal static VertexAttrib1hvNV glVertexAttrib1hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib2hNV(GLuint index, GLhalfNV x, GLhalfNV y);
        internal static VertexAttrib2hNV glVertexAttrib2hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib2hvNV(GLuint index, GLhalfNV* v);
        internal static VertexAttrib2hvNV glVertexAttrib2hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib3hNV(GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z);
        internal static VertexAttrib3hNV glVertexAttrib3hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib3hvNV(GLuint index, GLhalfNV* v);
        internal static VertexAttrib3hvNV glVertexAttrib3hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttrib4hNV(GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w);
        internal static VertexAttrib4hNV glVertexAttrib4hNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttrib4hvNV(GLuint index, GLhalfNV* v);
        internal static VertexAttrib4hvNV glVertexAttrib4hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs1hvNV(GLuint index, GLsizei n, GLhalfNV* v);
        internal static VertexAttribs1hvNV glVertexAttribs1hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs2hvNV(GLuint index, GLsizei n, GLhalfNV* v);
        internal static VertexAttribs2hvNV glVertexAttribs2hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs3hvNV(GLuint index, GLsizei n, GLhalfNV* v);
        internal static VertexAttribs3hvNV glVertexAttribs3hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribs4hvNV(GLuint index, GLsizei n, GLhalfNV* v);
        internal static VertexAttribs4hvNV glVertexAttribs4hvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void PixelDataRangeNV(GL.Enums.NV_pixel_data_range target, GLsizei length, void* pointer);
        internal static PixelDataRangeNV glPixelDataRangeNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FlushPixelDataRangeNV(GL.Enums.NV_pixel_data_range target);
        internal static FlushPixelDataRangeNV glFlushPixelDataRangeNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PrimitiveRestartNV();
        internal static PrimitiveRestartNV glPrimitiveRestartNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void PrimitiveRestartIndexNV(GLuint index);
        internal static PrimitiveRestartIndexNV glPrimitiveRestartIndexNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void MapObjectBufferATI(GLuint buffer);
        internal static MapObjectBufferATI glMapObjectBufferATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UnmapObjectBufferATI(GLuint buffer);
        internal static UnmapObjectBufferATI glUnmapObjectBufferATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilOpSeparateATI(GL.Enums.ATI_separate_stencil face, GL.Enums.StencilOp sfail, GL.Enums.StencilOp dpfail, GL.Enums.StencilOp dppass);
        internal static StencilOpSeparateATI glStencilOpSeparateATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilFuncSeparateATI(GL.Enums.StencilFunction frontfunc, GL.Enums.StencilFunction backfunc, GLint @ref, GLuint mask);
        internal static StencilFuncSeparateATI glStencilFuncSeparateATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribArrayObjectATI(GLuint index, GLint size, GL.Enums.ATI_vertex_attrib_array_object type, GL.Enums.Boolean normalized, GLsizei stride, GLuint buffer, GLuint offset);
        internal static VertexAttribArrayObjectATI glVertexAttribArrayObjectATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribArrayObjectfvATI(GLuint index, GL.Enums.ATI_vertex_attrib_array_object pname, GLfloat* @params);
        internal static GetVertexAttribArrayObjectfvATI glGetVertexAttribArrayObjectfvATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribArrayObjectivATI(GLuint index, GL.Enums.ATI_vertex_attrib_array_object pname, GLint* @params);
        internal static GetVertexAttribArrayObjectivATI glGetVertexAttribArrayObjectivATI;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthBoundsEXT(GLclampd zmin, GLclampd zmax);
        internal static DepthBoundsEXT glDepthBoundsEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlendEquationSeparateEXT(GL.Enums.BlendEquationModeEXT modeRGB, GL.Enums.BlendEquationModeEXT modeAlpha);
        internal static BlendEquationSeparateEXT glBlendEquationSeparateEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsRenderbufferEXT(GLuint renderbuffer);
        internal static IsRenderbufferEXT glIsRenderbufferEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindRenderbufferEXT(GL.Enums.EXT_framebuffer_object target, GLuint renderbuffer);
        internal static BindRenderbufferEXT glBindRenderbufferEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteRenderbuffersEXT(GLsizei n, GLuint* renderbuffers);
        internal static DeleteRenderbuffersEXT glDeleteRenderbuffersEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenRenderbuffersEXT(GLsizei n, GLuint* renderbuffers);
        internal static GenRenderbuffersEXT glGenRenderbuffersEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RenderbufferStorageEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.GLenum internalformat, GLsizei width, GLsizei height);
        internal static RenderbufferStorageEXT glRenderbufferStorageEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetRenderbufferParameterivEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.GLenum pname, GLint* @params);
        internal static GetRenderbufferParameterivEXT glGetRenderbufferParameterivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsFramebufferEXT(GLuint framebuffer);
        internal static IsFramebufferEXT glIsFramebufferEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindFramebufferEXT(GL.Enums.EXT_framebuffer_object target, GLuint framebuffer);
        internal static BindFramebufferEXT glBindFramebufferEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DeleteFramebuffersEXT(GLsizei n, GLuint* framebuffers);
        internal static DeleteFramebuffersEXT glDeleteFramebuffersEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GenFramebuffersEXT(GLsizei n, GLuint* framebuffers);
        internal static GenFramebuffersEXT glGenFramebuffersEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GL.Enums.GLenum CheckFramebufferStatusEXT(GL.Enums.EXT_framebuffer_object target);
        internal static CheckFramebufferStatusEXT glCheckFramebufferStatusEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTexture1DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.GLenum textarget, GLuint texture, GLint level);
        internal static FramebufferTexture1DEXT glFramebufferTexture1DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTexture2DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.GLenum textarget, GLuint texture, GLint level);
        internal static FramebufferTexture2DEXT glFramebufferTexture2DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTexture3DEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.GLenum textarget, GLuint texture, GLint level, GLint zoffset);
        internal static FramebufferTexture3DEXT glFramebufferTexture3DEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferRenderbufferEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.EXT_framebuffer_object renderbuffertarget, GLuint renderbuffer);
        internal static FramebufferRenderbufferEXT glFramebufferRenderbufferEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetFramebufferAttachmentParameterivEXT(GL.Enums.EXT_framebuffer_object target, GL.Enums.EXT_framebuffer_object attachment, GL.Enums.GLenum pname, GLint* @params);
        internal static GetFramebufferAttachmentParameterivEXT glGetFramebufferAttachmentParameterivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void GenerateMipmapEXT(GL.Enums.GLenum target);
        internal static GenerateMipmapEXT glGenerateMipmapEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void StringMarkerGREMEDY(GLsizei len, void* @string);
        internal static StringMarkerGREMEDY glStringMarkerGREMEDY;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void StencilClearTagEXT(GLsizei stencilTagBits, GLuint stencilClearTag);
        internal static StencilClearTagEXT glStencilClearTagEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BlitFramebufferEXT(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GL.Enums.ClearBufferMask mask, GL.Enums.GLenum filter);
        internal static BlitFramebufferEXT glBlitFramebufferEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RenderbufferStorageMultisampleEXT(GL.Enums.GLenum target, GLsizei samples, GL.Enums.GLenum internalformat, GLsizei width, GLsizei height);
        internal static RenderbufferStorageMultisampleEXT glRenderbufferStorageMultisampleEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjecti64vEXT(GLuint id, GL.Enums.GLenum pname, GLint64EXT* @params);
        internal static GetQueryObjecti64vEXT glGetQueryObjecti64vEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetQueryObjectui64vEXT(GLuint id, GL.Enums.GLenum pname, GLuint64EXT* @params);
        internal static GetQueryObjectui64vEXT glGetQueryObjectui64vEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParameters4fvEXT(GL.Enums.EXT_gpu_program_parameters target, GLuint index, GLsizei count, GLfloat* @params);
        internal static ProgramEnvParameters4fvEXT glProgramEnvParameters4fvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParameters4fvEXT(GL.Enums.EXT_gpu_program_parameters target, GLuint index, GLsizei count, GLfloat* @params);
        internal static ProgramLocalParameters4fvEXT glProgramLocalParameters4fvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BufferParameteriAPPLE(GL.Enums.GLenum target, GL.Enums.GLenum pname, GLint param);
        internal static BufferParameteriAPPLE glBufferParameteriAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FlushMappedBufferRangeAPPLE(GL.Enums.GLenum target, GLintptr offset, GLsizeiptr size);
        internal static FlushMappedBufferRangeAPPLE glFlushMappedBufferRangeAPPLE;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramLocalParameterI4iNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint x, GLint y, GLint z, GLint w);
        internal static ProgramLocalParameterI4iNV glProgramLocalParameterI4iNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParameterI4ivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint* @params);
        internal static ProgramLocalParameterI4ivNV glProgramLocalParameterI4ivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParametersI4ivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLsizei count, GLint* @params);
        internal static ProgramLocalParametersI4ivNV glProgramLocalParametersI4ivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramLocalParameterI4uiNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        internal static ProgramLocalParameterI4uiNV glProgramLocalParameterI4uiNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParameterI4uivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint* @params);
        internal static ProgramLocalParameterI4uivNV glProgramLocalParameterI4uivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramLocalParametersI4uivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLsizei count, GLuint* @params);
        internal static ProgramLocalParametersI4uivNV glProgramLocalParametersI4uivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramEnvParameterI4iNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint x, GLint y, GLint z, GLint w);
        internal static ProgramEnvParameterI4iNV glProgramEnvParameterI4iNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParameterI4ivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint* @params);
        internal static ProgramEnvParameterI4ivNV glProgramEnvParameterI4ivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParametersI4ivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLsizei count, GLint* @params);
        internal static ProgramEnvParametersI4ivNV glProgramEnvParametersI4ivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramEnvParameterI4uiNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        internal static ProgramEnvParameterI4uiNV glProgramEnvParameterI4uiNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParameterI4uivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint* @params);
        internal static ProgramEnvParameterI4uivNV glProgramEnvParameterI4uivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramEnvParametersI4uivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLsizei count, GLuint* @params);
        internal static ProgramEnvParametersI4uivNV glProgramEnvParametersI4uivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramLocalParameterIivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint* @params);
        internal static GetProgramLocalParameterIivNV glGetProgramLocalParameterIivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramLocalParameterIuivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint* @params);
        internal static GetProgramLocalParameterIuivNV glGetProgramLocalParameterIuivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramEnvParameterIivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLint* @params);
        internal static GetProgramEnvParameterIivNV glGetProgramEnvParameterIivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetProgramEnvParameterIuivNV(GL.Enums.NV_gpu_program4 target, GLuint index, GLuint* @params);
        internal static GetProgramEnvParameterIuivNV glGetProgramEnvParameterIuivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramVertexLimitNV(GL.Enums.NV_geometry_program4 target, GLint limit);
        internal static ProgramVertexLimitNV glProgramVertexLimitNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTextureEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, GLuint texture, GLint level);
        internal static FramebufferTextureEXT glFramebufferTextureEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTextureLayerEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, GLuint texture, GLint level, GLint layer);
        internal static FramebufferTextureLayerEXT glFramebufferTextureLayerEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void FramebufferTextureFaceEXT(GL.Enums.NV_geometry_program4 target, GL.Enums.NV_geometry_program4 attachment, GLuint texture, GLint level, GL.Enums.TextureTarget face);
        internal static FramebufferTextureFaceEXT glFramebufferTextureFaceEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ProgramParameteriEXT(GLuint program, GL.Enums.EXT_geometry_shader4 pname, GLint value);
        internal static ProgramParameteriEXT glProgramParameteriEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI1iEXT(GLuint index, GLint x);
        internal static VertexAttribI1iEXT glVertexAttribI1iEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI2iEXT(GLuint index, GLint x, GLint y);
        internal static VertexAttribI2iEXT glVertexAttribI2iEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI3iEXT(GLuint index, GLint x, GLint y, GLint z);
        internal static VertexAttribI3iEXT glVertexAttribI3iEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI4iEXT(GLuint index, GLint x, GLint y, GLint z, GLint w);
        internal static VertexAttribI4iEXT glVertexAttribI4iEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI1uiEXT(GLuint index, GLuint x);
        internal static VertexAttribI1uiEXT glVertexAttribI1uiEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI2uiEXT(GLuint index, GLuint x, GLuint y);
        internal static VertexAttribI2uiEXT glVertexAttribI2uiEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI3uiEXT(GLuint index, GLuint x, GLuint y, GLuint z);
        internal static VertexAttribI3uiEXT glVertexAttribI3uiEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void VertexAttribI4uiEXT(GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        internal static VertexAttribI4uiEXT glVertexAttribI4uiEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI1ivEXT(GLuint index, GLint* v);
        internal static VertexAttribI1ivEXT glVertexAttribI1ivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI2ivEXT(GLuint index, GLint* v);
        internal static VertexAttribI2ivEXT glVertexAttribI2ivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI3ivEXT(GLuint index, GLint* v);
        internal static VertexAttribI3ivEXT glVertexAttribI3ivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4ivEXT(GLuint index, GLint* v);
        internal static VertexAttribI4ivEXT glVertexAttribI4ivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI1uivEXT(GLuint index, GLuint* v);
        internal static VertexAttribI1uivEXT glVertexAttribI1uivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI2uivEXT(GLuint index, GLuint* v);
        internal static VertexAttribI2uivEXT glVertexAttribI2uivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI3uivEXT(GLuint index, GLuint* v);
        internal static VertexAttribI3uivEXT glVertexAttribI3uivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4uivEXT(GLuint index, GLuint* v);
        internal static VertexAttribI4uivEXT glVertexAttribI4uivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4bvEXT(GLuint index, GLbyte* v);
        internal static VertexAttribI4bvEXT glVertexAttribI4bvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4svEXT(GLuint index, GLshort* v);
        internal static VertexAttribI4svEXT glVertexAttribI4svEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4ubvEXT(GLuint index, GLubyte* v);
        internal static VertexAttribI4ubvEXT glVertexAttribI4ubvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribI4usvEXT(GLuint index, GLushort* v);
        internal static VertexAttribI4usvEXT glVertexAttribI4usvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void VertexAttribIPointerEXT(GLuint index, GLint size, GL.Enums.NV_vertex_program4 type, GLsizei stride, void* pointer);
        internal static VertexAttribIPointerEXT glVertexAttribIPointerEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribIivEXT(GLuint index, GL.Enums.NV_vertex_program4 pname, GLint* @params);
        internal static GetVertexAttribIivEXT glGetVertexAttribIivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetVertexAttribIuivEXT(GLuint index, GL.Enums.NV_vertex_program4 pname, GLuint* @params);
        internal static GetVertexAttribIuivEXT glGetVertexAttribIuivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetUniformuivEXT(GLuint program, GLint location, GLuint* @params);
        internal static GetUniformuivEXT glGetUniformuivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void BindFragDataLocationEXT(GLuint program, GLuint color, System.String name);
        internal static BindFragDataLocationEXT glBindFragDataLocationEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate GLint GetFragDataLocationEXT(GLuint program, System.String name);
        internal static GetFragDataLocationEXT glGetFragDataLocationEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform1uiEXT(GLint location, GLuint v0);
        internal static Uniform1uiEXT glUniform1uiEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform2uiEXT(GLint location, GLuint v0, GLuint v1);
        internal static Uniform2uiEXT glUniform2uiEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform3uiEXT(GLint location, GLuint v0, GLuint v1, GLuint v2);
        internal static Uniform3uiEXT glUniform3uiEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void Uniform4uiEXT(GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);
        internal static Uniform4uiEXT glUniform4uiEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform1uivEXT(GLint location, GLsizei count, GLuint* value);
        internal static Uniform1uivEXT glUniform1uivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform2uivEXT(GLint location, GLsizei count, GLuint* value);
        internal static Uniform2uivEXT glUniform2uivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform3uivEXT(GLint location, GLsizei count, GLuint* value);
        internal static Uniform3uivEXT glUniform3uivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void Uniform4uivEXT(GLint location, GLsizei count, GLuint* value);
        internal static Uniform4uivEXT glUniform4uivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DrawArraysInstancedEXT(GL.Enums.BeginMode mode, GLint start, GLsizei count, GLsizei primcount);
        internal static DrawArraysInstancedEXT glDrawArraysInstancedEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void DrawElementsInstancedEXT(GL.Enums.BeginMode mode, GLsizei count, GL.Enums.EXT_draw_instanced type, void* indices, GLsizei primcount);
        internal static DrawElementsInstancedEXT glDrawElementsInstancedEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void TexBufferEXT(GL.Enums.TextureTarget target, GL.Enums.GLenum internalformat, GLuint buffer);
        internal static TexBufferEXT glTexBufferEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthRangedNV(GLdouble zNear, GLdouble zFar);
        internal static DepthRangedNV glDepthRangedNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearDepthdNV(GLdouble depth);
        internal static ClearDepthdNV glClearDepthdNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DepthBoundsdNV(GLdouble zmin, GLdouble zmax);
        internal static DepthBoundsdNV glDepthBoundsdNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void RenderbufferStorageMultisampleCoverageNV(GL.Enums.NV_framebuffer_multisample_coverage target, GLsizei coverageSamples, GLsizei colorSamples, GL.Enums.PixelInternalFormat internalformat, GLsizei width, GLsizei height);
        internal static RenderbufferStorageMultisampleCoverageNV glRenderbufferStorageMultisampleCoverageNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramBufferParametersfvNV(GL.Enums.NV_parameter_buffer_object target, GLuint buffer, GLuint index, GLsizei count, GLfloat* @params);
        internal static ProgramBufferParametersfvNV glProgramBufferParametersfvNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramBufferParametersIivNV(GL.Enums.NV_parameter_buffer_object target, GLuint buffer, GLuint index, GLsizei count, GLint* @params);
        internal static ProgramBufferParametersIivNV glProgramBufferParametersIivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ProgramBufferParametersIuivNV(GL.Enums.NV_parameter_buffer_object target, GLuint buffer, GLuint index, GLsizei count, GLuint* @params);
        internal static ProgramBufferParametersIuivNV glProgramBufferParametersIuivNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ColorMaskIndexedEXT(GLuint index, GL.Enums.Boolean r, GL.Enums.Boolean g, GL.Enums.Boolean b, GL.Enums.Boolean a);
        internal static ColorMaskIndexedEXT glColorMaskIndexedEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetBooleanIndexedvEXT(GL.Enums.GLenum target, GLuint index, GL.Enums.Boolean* data);
        internal static GetBooleanIndexedvEXT glGetBooleanIndexedvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetIntegerIndexedvEXT(GL.Enums.GLenum target, GLuint index, GLint* data);
        internal static GetIntegerIndexedvEXT glGetIntegerIndexedvEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EnableIndexedEXT(GL.Enums.GLenum target, GLuint index);
        internal static EnableIndexedEXT glEnableIndexedEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void DisableIndexedEXT(GL.Enums.GLenum target, GLuint index);
        internal static DisableIndexedEXT glDisableIndexedEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLboolean IsEnabledIndexedEXT(GL.Enums.GLenum target, GLuint index);
        internal static IsEnabledIndexedEXT glIsEnabledIndexedEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BeginTransformFeedbackNV(GL.Enums.GLenum primitiveMode);
        internal static BeginTransformFeedbackNV glBeginTransformFeedbackNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void EndTransformFeedbackNV();
        internal static EndTransformFeedbackNV glEndTransformFeedbackNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TransformFeedbackAttribsNV(GLuint count, GLint* attribs, GL.Enums.GLenum bufferMode);
        internal static TransformFeedbackAttribsNV glTransformFeedbackAttribsNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBufferRangeNV(GL.Enums.GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);
        internal static BindBufferRangeNV glBindBufferRangeNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBufferOffsetNV(GL.Enums.GLenum target, GLuint index, GLuint buffer, GLintptr offset);
        internal static BindBufferOffsetNV glBindBufferOffsetNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void BindBufferBaseNV(GL.Enums.GLenum target, GLuint index, GLuint buffer);
        internal static BindBufferBaseNV glBindBufferBaseNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TransformFeedbackVaryingsNV(GLuint program, GLsizei count, GLint* locations, GL.Enums.GLenum bufferMode);
        internal static TransformFeedbackVaryingsNV glTransformFeedbackVaryingsNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void ActiveVaryingNV(GLuint program, System.String name);
        internal static ActiveVaryingNV glActiveVaryingNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate GLint GetVaryingLocationNV(GLuint program, System.String name);
        internal static GetVaryingLocationNV glGetVaryingLocationNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetActiveVaryingNV(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GL.Enums.GLenum* type, System.Text.StringBuilder name);
        internal static GetActiveVaryingNV glGetActiveVaryingNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTransformFeedbackVaryingNV(GLuint program, GLuint index, GLint* location);
        internal static GetTransformFeedbackVaryingNV glGetTransformFeedbackVaryingNV;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void UniformBufferEXT(GLuint program, GLint location, GLuint buffer);
        internal static UniformBufferEXT glUniformBufferEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLint GetUniformBufferSizeEXT(GLuint program, GLint location);
        internal static GetUniformBufferSizeEXT glGetUniformBufferSizeEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate GLintptr GetUniformOffsetEXT(GLuint program, GLint location);
        internal static GetUniformOffsetEXT glGetUniformOffsetEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexParameterIivEXT(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLint* @params);
        internal static TexParameterIivEXT glTexParameterIivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void TexParameterIuivEXT(GL.Enums.TextureTarget target, GL.Enums.TextureParameterName pname, GLuint* @params);
        internal static TexParameterIuivEXT glTexParameterIuivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexParameterIivEXT(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, GLint* @params);
        internal static GetTexParameterIivEXT glGetTexParameterIivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void GetTexParameterIuivEXT(GL.Enums.TextureTarget target, GL.Enums.GetTextureParameter pname, GLuint* @params);
        internal static GetTexParameterIuivEXT glGetTexParameterIuivEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearColorIiEXT(GLint red, GLint green, GLint blue, GLint alpha);
        internal static ClearColorIiEXT glClearColorIiEXT;
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void ClearColorIuiEXT(GLuint red, GLuint green, GLuint blue, GLuint alpha);
        internal static ClearColorIuiEXT glClearColorIuiEXT;
    }
}
