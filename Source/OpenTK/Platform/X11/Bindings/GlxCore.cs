namespace OpenTK.Platform.X11
{
    using System;
    using System.Runtime.InteropServices;

    partial class Glx
    {

        internal static class Imports
        {
            static Imports() { }

            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXRender", ExactSpelling = true)]
            internal extern static void Render();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXRenderLarge", ExactSpelling = true)]
            internal extern static void RenderLarge();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXCreateContext", ExactSpelling = true)]
            internal extern static void CreateContext(Int32 gc_id, Int32 screen, Int32 visual, Int32 share_list);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXDestroyContext", ExactSpelling = true)]
            internal extern static void DestroyContext(Int32 context);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXMakeCurrent", ExactSpelling = true)]
            internal extern static void MakeCurrent(Int32 drawable, Int32 context);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXIsDirect", ExactSpelling = true)]
            internal extern static void IsDirect(Int32 dpy, Int32 context);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXQueryVersion", ExactSpelling = true)]
            internal extern static unsafe void QueryVersion([Out] Int32* major, [Out] Int32* minor);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXWaitGL", ExactSpelling = true)]
            internal extern static void WaitGL(Int32 context);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXWaitX", ExactSpelling = true)]
            internal extern static void WaitX();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXCopyContext", ExactSpelling = true)]
            internal extern static void CopyContext(Int32 source, Int32 dest, Int32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXSwapBuffers", ExactSpelling = true)]
            internal extern static void SwapBuffers(Int32 drawable);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXUseXFont", ExactSpelling = true)]
            internal extern static void UseXFont(Int32 font, Int32 first, Int32 count, Int32 list_base);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXCreateGLXPixmap", ExactSpelling = true)]
            internal extern static void CreateGLXPixmap(Int32 visual, Int32 pixmap, Int32 glxpixmap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXGetVisualConfigs", ExactSpelling = true)]
            internal extern static void GetVisualConfigs();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXDestroyGLXPixmap", ExactSpelling = true)]
            internal extern static void DestroyGLXPixmap(Int32 pixmap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXVendorPrivate", ExactSpelling = true)]
            internal extern static void VendorPrivate();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXVendorPrivateWithReply", ExactSpelling = true)]
            internal extern static void VendorPrivateWithReply();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXQueryExtensionsString", ExactSpelling = true)]
            internal extern static void QueryExtensionsString(Int32 screen);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXQueryServerString", ExactSpelling = true)]
            internal extern static void QueryServerString(Int32 screen, Int32 name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXClientInfo", ExactSpelling = true)]
            internal extern static void ClientInfo();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXGetFBConfigs", ExactSpelling = true)]
            internal extern static void GetFBConfigs();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXCreatePixmap", ExactSpelling = true)]
            internal extern static void CreatePixmap(Int32 config, Int32 pixmap, Int32 glxpixmap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXDestroyPixmap", ExactSpelling = true)]
            internal extern static void DestroyPixmap(Int32 glxpixmap);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXCreateNewContext", ExactSpelling = true)]
            internal extern static void CreateNewContext(Int32 config, Int32 render_type, Int32 share_list, Int32 direct);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXQueryContext", ExactSpelling = true)]
            internal extern static void QueryContext();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXMakeContextCurrent", ExactSpelling = true)]
            internal extern static void MakeContextCurrent(Int32 drawable, Int32 readdrawable, Int32 context);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXCreatePbuffer", ExactSpelling = true)]
            internal extern static void CreatePbuffer(Int32 config, Int32 pbuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXDestroyPbuffer", ExactSpelling = true)]
            internal extern static void DestroyPbuffer(Int32 pbuffer);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXGetDrawableAttributes", ExactSpelling = true)]
            internal extern static void GetDrawableAttributes(Int32 drawable);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXChangeDrawableAttributes", ExactSpelling = true)]
            internal extern static void ChangeDrawableAttributes(Int32 drawable);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXCreateWindow", ExactSpelling = true)]
            internal extern static void CreateWindow(Int32 config, Int32 window, Int32 glxwindow);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXDestroyWindow", ExactSpelling = true)]
            internal extern static void DestroyWindow(Int32 glxwindow);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXChooseFBConfig", ExactSpelling = true)]
            internal extern static unsafe GLXFBConfig ChooseFBConfig([Out] IntPtr dpy, int screen, int* attrib_list, [Out] int* nelements);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXGetFBConfigAttrib", ExactSpelling = true)]
            internal extern static unsafe int GetFBConfigAttrib([Out] IntPtr dpy, GLXFBConfig config, int attribute, [Out] int* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXGetVisualFromFBConfig", ExactSpelling = true)]
            internal extern static XVisualInfo GetVisualFromFBConfig([Out] IntPtr dpy, GLXFBConfig config);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXQueryDrawable", ExactSpelling = true)]
            internal extern static unsafe void QueryDrawable([Out] IntPtr dpy, IntPtr draw, int attribute, [Out] uint* value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXGetCurrentReadDrawable", ExactSpelling = true)]
            internal extern static IntPtr GetCurrentReadDrawable();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXGetCurrentDisplay", ExactSpelling = true)]
            internal extern static IntPtr GetCurrentDisplay();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXSelectEvent", ExactSpelling = true)]
            internal extern static void SelectEvent([Out] IntPtr dpy, IntPtr draw, ulong event_mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXGetSelectedEvent", ExactSpelling = true)]
            internal extern static unsafe void GetSelectedEvent([Out] IntPtr dpy, IntPtr draw, [Out] ulong* event_mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glx.Library, EntryPoint = "glXGetProcAddress", ExactSpelling = true)]
            internal extern static unsafe IntPtr GetProcAddress(Byte* procName);
        }
    }
}
