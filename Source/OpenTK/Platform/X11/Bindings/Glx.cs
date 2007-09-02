namespace OpenTK.Platform.X11
{
    using System;
    using System.Runtime.InteropServices;

    public static partial class Glx
    {

        public static 
        void Render()
        {
            Delegates.glXRender();
        }
        
        public static 
        void RenderLarge()
        {
            Delegates.glXRenderLarge();
        }
        
        public static 
        void CreateContext(Int32 gc_id, Int32 screen, Int32 visual, Int32 share_list)
        {
            Delegates.glXCreateContext((Int32)gc_id, (Int32)screen, (Int32)visual, (Int32)share_list);
        }
        
        public static 
        void DestroyContext(Int32 context)
        {
            Delegates.glXDestroyContext((Int32)context);
        }
        
        public static 
        void MakeCurrent(Int32 drawable, Int32 context)
        {
            Delegates.glXMakeCurrent((Int32)drawable, (Int32)context);
        }
        
        public static 
        void IsDirect(Int32 dpy, Int32 context)
        {
            Delegates.glXIsDirect((Int32)dpy, (Int32)context);
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe void QueryVersion([Out] Int32* major, [Out] Int32* minor)
        {
            unsafe { Delegates.glXQueryVersion((Int32*)major, (Int32*)minor); }
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe void QueryVersion([Out] Int32* major, [Out] Int32[] minor)
        {
            unsafe
            {
                fixed (Int32* minor_ptr = minor)
                {
                    Delegates.glXQueryVersion((Int32*)major, (Int32*)minor_ptr);
                }
            }
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe void QueryVersion([Out] Int32* major, [Out] out Int32 minor)
        {
            unsafe
            {
                fixed (Int32* minor_ptr = &minor)
                {
                    Delegates.glXQueryVersion((Int32*)major, (Int32*)minor_ptr);
                            minor = *minor_ptr;
                }
            }
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe void QueryVersion([Out] Int32[] major, [Out] Int32* minor)
        {
            unsafe
            {
                fixed (Int32* major_ptr = major)
                {
                    Delegates.glXQueryVersion((Int32*)major_ptr, (Int32*)minor);
                }
            }
        }
        
        public static 
        void QueryVersion([Out] Int32[] major, [Out] Int32[] minor)
        {
            unsafe
            {
                fixed (Int32* major_ptr = major)
                fixed (Int32* minor_ptr = minor)
                {
                    Delegates.glXQueryVersion((Int32*)major_ptr, (Int32*)minor_ptr);
                }
            }
        }
        
        public static 
        void QueryVersion([Out] Int32[] major, [Out] out Int32 minor)
        {
            unsafe
            {
                fixed (Int32* major_ptr = major)
                fixed (Int32* minor_ptr = &minor)
                {
                    Delegates.glXQueryVersion((Int32*)major_ptr, (Int32*)minor_ptr);
                            minor = *minor_ptr;
                }
            }
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe void QueryVersion([Out] out Int32 major, [Out] Int32* minor)
        {
            unsafe
            {
                fixed (Int32* major_ptr = &major)
                {
                    Delegates.glXQueryVersion((Int32*)major_ptr, (Int32*)minor);
                            major = *major_ptr;
                }
            }
        }
        
        public static 
        void QueryVersion([Out] out Int32 major, [Out] Int32[] minor)
        {
            unsafe
            {
                fixed (Int32* major_ptr = &major)
                fixed (Int32* minor_ptr = minor)
                {
                    Delegates.glXQueryVersion((Int32*)major_ptr, (Int32*)minor_ptr);
                            major = *major_ptr;
                }
            }
        }
        
        public static 
        void QueryVersion([Out] out Int32 major, [Out] out Int32 minor)
        {
            unsafe
            {
                fixed (Int32* major_ptr = &major)
                fixed (Int32* minor_ptr = &minor)
                {
                    Delegates.glXQueryVersion((Int32*)major_ptr, (Int32*)minor_ptr);
                            major = *major_ptr;
                            minor = *minor_ptr;
                }
            }
        }
        
        public static 
        void WaitGL(Int32 context)
        {
            Delegates.glXWaitGL((Int32)context);
        }
        
        public static 
        void WaitX()
        {
            Delegates.glXWaitX();
        }
        
        public static 
        void CopyContext(Int32 source, Int32 dest, Int32 mask)
        {
            Delegates.glXCopyContext((Int32)source, (Int32)dest, (Int32)mask);
        }
        
        public static 
        void SwapBuffers(Int32 drawable)
        {
            Delegates.glXSwapBuffers((Int32)drawable);
        }
        
        public static 
        void UseXFont(Int32 font, Int32 first, Int32 count, Int32 list_base)
        {
            Delegates.glXUseXFont((Int32)font, (Int32)first, (Int32)count, (Int32)list_base);
        }
        
        public static 
        void CreateGLXPixmap(Int32 visual, Int32 pixmap, Int32 glxpixmap)
        {
            Delegates.glXCreateGLXPixmap((Int32)visual, (Int32)pixmap, (Int32)glxpixmap);
        }
        
        public static 
        void GetVisualConfig()
        {
            Delegates.glXGetVisualConfigs();
        }
        
        public static 
        void DestroyGLXPixmap(Int32 pixmap)
        {
            Delegates.glXDestroyGLXPixmap((Int32)pixmap);
        }
        
        public static 
        void VendorPrivate()
        {
            Delegates.glXVendorPrivate();
        }
        
        public static 
        void VendorPrivateWithReply()
        {
            Delegates.glXVendorPrivateWithReply();
        }
        
        public static 
        void QueryExtensionsString(Int32 screen)
        {
            Delegates.glXQueryExtensionsString((Int32)screen);
        }
        
        public static 
        void QueryServerString(Int32 screen, Int32 name)
        {
            Delegates.glXQueryServerString((Int32)screen, (Int32)name);
        }
        
        public static 
        void ClientInfo()
        {
            Delegates.glXClientInfo();
        }
        
        public static 
        void GetFBConfig()
        {
            Delegates.glXGetFBConfigs();
        }
        
        public static 
        void CreatePixmap(Int32 config, Int32 pixmap, Int32 glxpixmap)
        {
            Delegates.glXCreatePixmap((Int32)config, (Int32)pixmap, (Int32)glxpixmap);
        }
        
        public static 
        void DestroyPixmap(Int32 glxpixmap)
        {
            Delegates.glXDestroyPixmap((Int32)glxpixmap);
        }
        
        public static 
        void CreateNewContext(Int32 config, Int32 render_type, Int32 share_list, Int32 direct)
        {
            Delegates.glXCreateNewContext((Int32)config, (Int32)render_type, (Int32)share_list, (Int32)direct);
        }
        
        public static 
        void QueryContext()
        {
            Delegates.glXQueryContext();
        }
        
        public static 
        void MakeContextCurrent(Int32 drawable, Int32 readdrawable, Int32 context)
        {
            Delegates.glXMakeContextCurrent((Int32)drawable, (Int32)readdrawable, (Int32)context);
        }
        
        public static 
        void CreatePbuffer(Int32 config, Int32 pbuffer)
        {
            Delegates.glXCreatePbuffer((Int32)config, (Int32)pbuffer);
        }
        
        public static 
        void DestroyPbuffer(Int32 pbuffer)
        {
            Delegates.glXDestroyPbuffer((Int32)pbuffer);
        }
        
        public static 
        void GetDrawableAttributes(Int32 drawable)
        {
            Delegates.glXGetDrawableAttributes((Int32)drawable);
        }
        
        public static 
        void ChangeDrawableAttributes(Int32 drawable)
        {
            Delegates.glXChangeDrawableAttributes((Int32)drawable);
        }
        
        public static 
        void CreateWindow(Int32 config, Int32 window, Int32 glxwindow)
        {
            Delegates.glXCreateWindow((Int32)config, (Int32)window, (Int32)glxwindow);
        }
        
        public static 
        void DestroyWindow(Int32 glxwindow)
        {
            Delegates.glXDestroyWindow((Int32)glxwindow);
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe GLXFBConfig GetFBConfig([Out] IntPtr dpy, int screen, [Out] int* nelements)
        {
            unsafe { return Delegates.glXGetFBConfigs((IntPtr)dpy, (int)screen, (int*)nelements); }
        }
        
        public static 
        GLXFBConfig GetFBConfig([Out] IntPtr dpy, int screen, [Out] int[] nelements)
        {
            unsafe
            {
                fixed (int* nelements_ptr = nelements)
                {
                    GLXFBConfig retval = Delegates.glXGetFBConfigs((IntPtr)dpy, (int)screen, (int*)nelements_ptr);
                    return retval;
                }
            }
        }
        
        public static 
        GLXFBConfig GetFBConfig([Out] IntPtr dpy, int screen, [Out] out int nelements)
        {
            unsafe
            {
                fixed (int* nelements_ptr = &nelements)
                {
                    GLXFBConfig retval = Delegates.glXGetFBConfigs((IntPtr)dpy, (int)screen, (int*)nelements_ptr);
                            nelements = *nelements_ptr;
                    return retval;
                }
            }
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe GLXFBConfig ChooseFBConfig([Out] IntPtr dpy, int screen, int* attrib_list, [Out] int* nelements)
        {
            unsafe { return Delegates.glXChooseFBConfig((IntPtr)dpy, (int)screen, (int*)attrib_list, (int*)nelements); }
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe GLXFBConfig ChooseFBConfig([Out] IntPtr dpy, int screen, int* attrib_list, [Out] int[] nelements)
        {
            unsafe
            {
                fixed (int* nelements_ptr = nelements)
                {
                    GLXFBConfig retval = Delegates.glXChooseFBConfig((IntPtr)dpy, (int)screen, (int*)attrib_list, (int*)nelements_ptr);
                    return retval;
                }
            }
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe GLXFBConfig ChooseFBConfig([Out] IntPtr dpy, int screen, int* attrib_list, [Out] out int nelements)
        {
            unsafe
            {
                fixed (int* nelements_ptr = &nelements)
                {
                    GLXFBConfig retval = Delegates.glXChooseFBConfig((IntPtr)dpy, (int)screen, (int*)attrib_list, (int*)nelements_ptr);
                            nelements = *nelements_ptr;
                    return retval;
                }
            }
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe GLXFBConfig ChooseFBConfig([Out] IntPtr dpy, int screen, int[] attrib_list, [Out] int* nelements)
        {
            unsafe
            {
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    GLXFBConfig retval = Delegates.glXChooseFBConfig((IntPtr)dpy, (int)screen, (int*)attrib_list_ptr, (int*)nelements);
                    return retval;
                }
            }
        }
        
        public static 
        GLXFBConfig ChooseFBConfig([Out] IntPtr dpy, int screen, int[] attrib_list, [Out] int[] nelements)
        {
            unsafe
            {
                fixed (int* attrib_list_ptr = attrib_list)
                fixed (int* nelements_ptr = nelements)
                {
                    GLXFBConfig retval = Delegates.glXChooseFBConfig((IntPtr)dpy, (int)screen, (int*)attrib_list_ptr, (int*)nelements_ptr);
                    return retval;
                }
            }
        }
        
        public static 
        GLXFBConfig ChooseFBConfig([Out] IntPtr dpy, int screen, int[] attrib_list, [Out] out int nelements)
        {
            unsafe
            {
                fixed (int* attrib_list_ptr = attrib_list)
                fixed (int* nelements_ptr = &nelements)
                {
                    GLXFBConfig retval = Delegates.glXChooseFBConfig((IntPtr)dpy, (int)screen, (int*)attrib_list_ptr, (int*)nelements_ptr);
                            nelements = *nelements_ptr;
                    return retval;
                }
            }
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe GLXFBConfig ChooseFBConfig([Out] IntPtr dpy, int screen, ref int attrib_list, [Out] int* nelements)
        {
            unsafe
            {
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    GLXFBConfig retval = Delegates.glXChooseFBConfig((IntPtr)dpy, (int)screen, (int*)attrib_list_ptr, (int*)nelements);
                    return retval;
                }
            }
        }
        
        public static 
        GLXFBConfig ChooseFBConfig([Out] IntPtr dpy, int screen, ref int attrib_list, [Out] int[] nelements)
        {
            unsafe
            {
                fixed (int* attrib_list_ptr = &attrib_list)
                fixed (int* nelements_ptr = nelements)
                {
                    GLXFBConfig retval = Delegates.glXChooseFBConfig((IntPtr)dpy, (int)screen, (int*)attrib_list_ptr, (int*)nelements_ptr);
                    return retval;
                }
            }
        }
        
        public static 
        GLXFBConfig ChooseFBConfig([Out] IntPtr dpy, int screen, ref int attrib_list, [Out] out int nelements)
        {
            unsafe
            {
                fixed (int* attrib_list_ptr = &attrib_list)
                fixed (int* nelements_ptr = &nelements)
                {
                    GLXFBConfig retval = Delegates.glXChooseFBConfig((IntPtr)dpy, (int)screen, (int*)attrib_list_ptr, (int*)nelements_ptr);
                            nelements = *nelements_ptr;
                    return retval;
                }
            }
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe int GetFBConfigAttrib([Out] IntPtr dpy, GLXFBConfig config, int attribute, [Out] int* value)
        {
            unsafe { return Delegates.glXGetFBConfigAttrib((IntPtr)dpy, (GLXFBConfig)config, (int)attribute, (int*)value); }
        }
        
        public static 
        int GetFBConfigAttrib([Out] IntPtr dpy, GLXFBConfig config, int attribute, [Out] int[] value)
        {
            unsafe
            {
                fixed (int* value_ptr = value)
                {
                    int retval = Delegates.glXGetFBConfigAttrib((IntPtr)dpy, (GLXFBConfig)config, (int)attribute, (int*)value_ptr);
                    return retval;
                }
            }
        }
        
        public static 
        int GetFBConfigAttrib([Out] IntPtr dpy, GLXFBConfig config, int attribute, [Out] out int value)
        {
            unsafe
            {
                fixed (int* value_ptr = &value)
                {
                    int retval = Delegates.glXGetFBConfigAttrib((IntPtr)dpy, (GLXFBConfig)config, (int)attribute, (int*)value_ptr);
                            value = *value_ptr;
                    return retval;
                }
            }
        }
        
        public static 
        XVisualInfo GetVisualFromFBConfig([Out] IntPtr dpy, GLXFBConfig config)
        {
            return Delegates.glXGetVisualFromFBConfig((IntPtr)dpy, (GLXFBConfig)config);
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe IntPtr CreateWindow([Out] IntPtr dpy, GLXFBConfig config, IntPtr win, int* attrib_list)
        {
            unsafe { return Delegates.glXCreateWindow((IntPtr)dpy, (GLXFBConfig)config, (IntPtr)win, (int*)attrib_list); }
        }
        
        public static 
        IntPtr CreateWindow([Out] IntPtr dpy, GLXFBConfig config, IntPtr win, int[] attrib_list)
        {
            unsafe
            {
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    IntPtr retval = Delegates.glXCreateWindow((IntPtr)dpy, (GLXFBConfig)config, (IntPtr)win, (int*)attrib_list_ptr);
                    return retval;
                }
            }
        }
        
        public static 
        IntPtr CreateWindow([Out] IntPtr dpy, GLXFBConfig config, IntPtr win, ref int attrib_list)
        {
            unsafe
            {
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    IntPtr retval = Delegates.glXCreateWindow((IntPtr)dpy, (GLXFBConfig)config, (IntPtr)win, (int*)attrib_list_ptr);
                    return retval;
                }
            }
        }
        
        public static 
        void DestroyWindow([Out] IntPtr dpy, IntPtr win)
        {
            Delegates.glXDestroyWindow((IntPtr)dpy, (IntPtr)win);
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe IntPtr CreatePixmap([Out] IntPtr dpy, GLXFBConfig config, IntPtr pixmap, int* attrib_list)
        {
            unsafe { return Delegates.glXCreatePixmap((IntPtr)dpy, (GLXFBConfig)config, (IntPtr)pixmap, (int*)attrib_list); }
        }
        
        public static 
        IntPtr CreatePixmap([Out] IntPtr dpy, GLXFBConfig config, IntPtr pixmap, int[] attrib_list)
        {
            unsafe
            {
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    IntPtr retval = Delegates.glXCreatePixmap((IntPtr)dpy, (GLXFBConfig)config, (IntPtr)pixmap, (int*)attrib_list_ptr);
                    return retval;
                }
            }
        }
        
        public static 
        IntPtr CreatePixmap([Out] IntPtr dpy, GLXFBConfig config, IntPtr pixmap, ref int attrib_list)
        {
            unsafe
            {
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    IntPtr retval = Delegates.glXCreatePixmap((IntPtr)dpy, (GLXFBConfig)config, (IntPtr)pixmap, (int*)attrib_list_ptr);
                    return retval;
                }
            }
        }
        
        public static 
        void DestroyPixmap([Out] IntPtr dpy, IntPtr pixmap)
        {
            Delegates.glXDestroyPixmap((IntPtr)dpy, (IntPtr)pixmap);
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe GLXPbuffer CreatePbuffer([Out] IntPtr dpy, GLXFBConfig config, int* attrib_list)
        {
            unsafe { return Delegates.glXCreatePbuffer((IntPtr)dpy, (GLXFBConfig)config, (int*)attrib_list); }
        }
        
        public static 
        GLXPbuffer CreatePbuffer([Out] IntPtr dpy, GLXFBConfig config, int[] attrib_list)
        {
            unsafe
            {
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    GLXPbuffer retval = Delegates.glXCreatePbuffer((IntPtr)dpy, (GLXFBConfig)config, (int*)attrib_list_ptr);
                    return retval;
                }
            }
        }
        
        public static 
        GLXPbuffer CreatePbuffer([Out] IntPtr dpy, GLXFBConfig config, ref int attrib_list)
        {
            unsafe
            {
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    GLXPbuffer retval = Delegates.glXCreatePbuffer((IntPtr)dpy, (GLXFBConfig)config, (int*)attrib_list_ptr);
                    return retval;
                }
            }
        }
        
        public static 
        void DestroyPbuffer([Out] IntPtr dpy, GLXPbuffer pbuf)
        {
            Delegates.glXDestroyPbuffer((IntPtr)dpy, (GLXPbuffer)pbuf);
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe void QueryDrawable([Out] IntPtr dpy, IntPtr draw, int attribute, [Out] uint* value)
        {
            unsafe { Delegates.glXQueryDrawable((IntPtr)dpy, (IntPtr)draw, (int)attribute, (uint*)value); }
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe void QueryDrawable([Out] IntPtr dpy, IntPtr draw, int attribute, [Out] Int32* value)
        {
            unsafe
            {
                Delegates.glXQueryDrawable((IntPtr)dpy, (IntPtr)draw, (int)attribute, (uint*)value);
            }
        }
        
        public static 
        void QueryDrawable([Out] IntPtr dpy, IntPtr draw, int attribute, [Out] uint[] value)
        {
            unsafe
            {
                fixed (uint* value_ptr = value)
                {
                    Delegates.glXQueryDrawable((IntPtr)dpy, (IntPtr)draw, (int)attribute, (uint*)value_ptr);
                }
            }
        }
        
        public static 
        void QueryDrawable([Out] IntPtr dpy, IntPtr draw, int attribute, [Out] out uint value)
        {
            unsafe
            {
                fixed (uint* value_ptr = &value)
                {
                    Delegates.glXQueryDrawable((IntPtr)dpy, (IntPtr)draw, (int)attribute, (uint*)value_ptr);
                            value = *value_ptr;
                }
            }
        }
        
        public static 
        IntPtr CreateNewContext([Out] IntPtr dpy, GLXFBConfig config, int render_type, IntPtr share_list, bool direct)
        {
             return Delegates.glXCreateNewContext((IntPtr)dpy, (GLXFBConfig)config, (int)render_type, (IntPtr)share_list, (bool)direct); 
        }
        
        public static 
        bool MakeContextCurrent([Out] IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx)
        {
            return Delegates.glXMakeContextCurrent((IntPtr)dpy, (IntPtr)draw, (IntPtr)read, (IntPtr)ctx);
        }
        
        public static 
        IntPtr GetCurrentReadDrawable()
        {
            return Delegates.glXGetCurrentReadDrawable();
        }
        
        public static 
        IntPtr GetCurrentDisplay()
        {
            return Delegates.glXGetCurrentDisplay();
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe int QueryContext([Out] IntPtr dpy, IntPtr ctx, int attribute, [Out] int* value)
        {
            unsafe { return Delegates.glXQueryContext((IntPtr)dpy, (IntPtr)ctx, (int)attribute, (int*)value); }
        }
        
        public static 
        int QueryContext([Out] IntPtr dpy, IntPtr ctx, int attribute, [Out] int[] value)
        {
            unsafe
            {
                fixed (int* value_ptr = value)
                {
                    int retval = Delegates.glXQueryContext((IntPtr)dpy, (IntPtr)ctx, (int)attribute, (int*)value_ptr);
                    return retval;
                }
            }
        }
        
        public static 
        int QueryContext([Out] IntPtr dpy, IntPtr ctx, int attribute, [Out] out int value)
        {
            unsafe
            {
                fixed (int* value_ptr = &value)
                {
                    int retval = Delegates.glXQueryContext((IntPtr)dpy, (IntPtr)ctx, (int)attribute, (int*)value_ptr);
                            value = *value_ptr;
                    return retval;
                }
            }
        }
        
        public static 
        void SelectEvent([Out] IntPtr dpy, IntPtr draw, ulong event_mask)
        {
            Delegates.glXSelectEvent((IntPtr)dpy, (IntPtr)draw, (ulong)event_mask);
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetSelectedEvent([Out] IntPtr dpy, IntPtr draw, [Out] ulong* event_mask)
        {
            unsafe { Delegates.glXGetSelectedEvent((IntPtr)dpy, (IntPtr)draw, (ulong*)event_mask); }
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetSelectedEvent([Out] IntPtr dpy, IntPtr draw, [Out] Int64* event_mask)
        {
            unsafe
            {
                Delegates.glXGetSelectedEvent((IntPtr)dpy, (IntPtr)draw, (ulong*)event_mask);
            }
        }
        
        public static 
        void GetSelectedEvent([Out] IntPtr dpy, IntPtr draw, [Out] ulong[] event_mask)
        {
            unsafe
            {
                fixed (ulong* event_mask_ptr = event_mask)
                {
                    Delegates.glXGetSelectedEvent((IntPtr)dpy, (IntPtr)draw, (ulong*)event_mask_ptr);
                }
            }
        }
        
        public static 
        void GetSelectedEvent([Out] IntPtr dpy, IntPtr draw, [Out] out ulong event_mask)
        {
            unsafe
            {
                fixed (ulong* event_mask_ptr = &event_mask)
                {
                    Delegates.glXGetSelectedEvent((IntPtr)dpy, (IntPtr)draw, (ulong*)event_mask_ptr);
                            event_mask = *event_mask_ptr;
                }
            }
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe IntPtr GetProcAddres(Byte* procName)
        {
            unsafe { return Delegates.glXGetProcAddress((Byte*)procName); }
        }
        
        public static 
        IntPtr GetProcAddres(Byte[] procName)
        {
            unsafe
            {
                fixed (Byte* procName_ptr = procName)
                {
                    IntPtr retval = Delegates.glXGetProcAddress((Byte*)procName_ptr);
                    return retval;
                }
            }
        }
        
        public static 
        IntPtr GetProcAddres(ref Byte procName)
        {
            unsafe
            {
                fixed (Byte* procName_ptr = &procName)
                {
                    IntPtr retval = Delegates.glXGetProcAddress((Byte*)procName_ptr);
                    return retval;
                }
            }
        }
        
        public static class SGI
        {
            public static 
            void SwapInterval()
            {
                Delegates.glXSwapIntervalSGI();
            }
            
            public static 
            void MakeCurrentRea(Int32 drawable, Int32 readdrawable, Int32 context)
            {
                Delegates.glXMakeCurrentReadSGI((Int32)drawable, (Int32)readdrawable, (Int32)context);
            }
            
            public static 
            int SwapInterval(int interval)
            {
                return Delegates.glXSwapIntervalSGI((int)interval);
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int GetVideoSync([Out] uint* count)
            {
                unsafe { return Delegates.glXGetVideoSyncSGI((uint*)count); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int GetVideoSync([Out] Int32* count)
            {
                unsafe
                {
                    int retval = Delegates.glXGetVideoSyncSGI((uint*)count);
                    return retval;
                }
            }
            
            public static 
            int GetVideoSync([Out] uint[] count)
            {
                unsafe
                {
                    fixed (uint* count_ptr = count)
                    {
                        int retval = Delegates.glXGetVideoSyncSGI((uint*)count_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            int GetVideoSync([Out] out uint count)
            {
                unsafe
                {
                    fixed (uint* count_ptr = &count)
                    {
                        int retval = Delegates.glXGetVideoSyncSGI((uint*)count_ptr);
                                count = *count_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int WaitVideoSync(int divisor, int remainder, [Out] uint* count)
            {
                unsafe { return Delegates.glXWaitVideoSyncSGI((int)divisor, (int)remainder, (uint*)count); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int WaitVideoSync(int divisor, int remainder, [Out] Int32* count)
            {
                unsafe
                {
                    int retval = Delegates.glXWaitVideoSyncSGI((int)divisor, (int)remainder, (uint*)count);
                    return retval;
                }
            }
            
            public static 
            int WaitVideoSync(int divisor, int remainder, [Out] uint[] count)
            {
                unsafe
                {
                    fixed (uint* count_ptr = count)
                    {
                        int retval = Delegates.glXWaitVideoSyncSGI((int)divisor, (int)remainder, (uint*)count_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            int WaitVideoSync(int divisor, int remainder, [Out] out uint count)
            {
                unsafe
                {
                    fixed (uint* count_ptr = &count)
                    {
                        int retval = Delegates.glXWaitVideoSyncSGI((int)divisor, (int)remainder, (uint*)count_ptr);
                                count = *count_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool MakeCurrentRea([Out] IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx)
            {
                return Delegates.glXMakeCurrentReadSGI((IntPtr)dpy, (IntPtr)draw, (IntPtr)read, (IntPtr)ctx);
            }
            
            public static 
            IntPtr GetCurrentReadDrawable()
            {
                return Delegates.glXGetCurrentReadDrawableSGI();
            }
            
            public static 
            void Cushion([Out] IntPtr dpy, IntPtr window, float cushion)
            {
                Delegates.glXCushionSGI((IntPtr)dpy, (IntPtr)window, (float)cushion);
            }
            
        }

        public static class SGIX
        {
            public static 
            void CreateGLXVideoSource(Int32 dpy, Int32 screen, Int32 server, Int32 path, Int32 @class, Int32 node)
            {
                Delegates.glXCreateGLXVideoSourceSGIX((Int32)dpy, (Int32)screen, (Int32)server, (Int32)path, (Int32)@class, (Int32)node);
            }
            
            public static 
            void DestroyGLXVideoSource(Int32 dpy, Int32 glxvideosource)
            {
                Delegates.glXDestroyGLXVideoSourceSGIX((Int32)dpy, (Int32)glxvideosource);
            }
            
            public static 
            void GetFBConfig()
            {
                Delegates.glXGetFBConfigsSGIX();
            }
            
            public static 
            void CreateContextWithConfig(Int32 gc_id, Int32 screen, Int32 config, Int32 share_list)
            {
                Delegates.glXCreateContextWithConfigSGIX((Int32)gc_id, (Int32)screen, (Int32)config, (Int32)share_list);
            }
            
            public static 
            void CreateGLXPixmapWithConfig(Int32 config, Int32 pixmap, Int32 glxpixmap)
            {
                Delegates.glXCreateGLXPixmapWithConfigSGIX((Int32)config, (Int32)pixmap, (Int32)glxpixmap);
            }
            
            public static 
            void CreateGLXPbuffer(Int32 config, Int32 pbuffer)
            {
                Delegates.glXCreateGLXPbufferSGIX((Int32)config, (Int32)pbuffer);
            }
            
            public static 
            void DestroyGLXPbuffer(Int32 pbuffer)
            {
                Delegates.glXDestroyGLXPbufferSGIX((Int32)pbuffer);
            }
            
            public static 
            void ChangeDrawableAttributes(Int32 drawable)
            {
                Delegates.glXChangeDrawableAttributesSGIX((Int32)drawable);
            }
            
            public static 
            void GetDrawableAttributes(Int32 drawable)
            {
                Delegates.glXGetDrawableAttributesSGIX((Int32)drawable);
            }
            
            public static 
            void JoinSwapGroup(Int32 window, Int32 group)
            {
                Delegates.glXJoinSwapGroupSGIX((Int32)window, (Int32)group);
            }
            
            public static 
            void BindSwapBarrier(Int32 window, Int32 barrier)
            {
                Delegates.glXBindSwapBarrierSGIX((Int32)window, (Int32)barrier);
            }
            
            public static 
            void QueryMaxSwapBarriers()
            {
                Delegates.glXQueryMaxSwapBarriersSGIX();
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe GLXHyperpipeNetworkPointer QueryHyperpipeNetwork([Out] IntPtr dpy, [Out] int* npipes)
            {
                unsafe { return Delegates.glXQueryHyperpipeNetworkSGIX((IntPtr)dpy, (int*)npipes); }
            }
            
            public static 
            GLXHyperpipeNetworkPointer QueryHyperpipeNetwork([Out] IntPtr dpy, [Out] int[] npipes)
            {
                unsafe
                {
                    fixed (int* npipes_ptr = npipes)
                    {
                        GLXHyperpipeNetworkPointer retval = Delegates.glXQueryHyperpipeNetworkSGIX((IntPtr)dpy, (int*)npipes_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            GLXHyperpipeNetworkPointer QueryHyperpipeNetwork([Out] IntPtr dpy, [Out] out int npipes)
            {
                unsafe
                {
                    fixed (int* npipes_ptr = &npipes)
                    {
                        GLXHyperpipeNetworkPointer retval = Delegates.glXQueryHyperpipeNetworkSGIX((IntPtr)dpy, (int*)npipes_ptr);
                                npipes = *npipes_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, GLXHyperpipeConfig* cfg, [Out] int* hpId)
            {
                unsafe { return Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfig*)cfg, (int*)hpId); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, GLXHyperpipeConfig* cfg, [Out] int[] hpId)
            {
                unsafe
                {
                    fixed (int* hpId_ptr = hpId)
                    {
                        int retval = Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfig*)cfg, (int*)hpId_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, GLXHyperpipeConfig* cfg, [Out] out int hpId)
            {
                unsafe
                {
                    fixed (int* hpId_ptr = &hpId)
                    {
                        int retval = Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfig*)cfg, (int*)hpId_ptr);
                                hpId = *hpId_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, GLXHyperpipeConfig[] cfg, [Out] int* hpId)
            {
                unsafe
                {
                    fixed (GLXHyperpipeConfig* cfg_ptr = cfg)
                    {
                        int retval = Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfig*)cfg_ptr, (int*)hpId);
                        return retval;
                    }
                }
            }
            
            public static 
            int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, GLXHyperpipeConfig[] cfg, [Out] int[] hpId)
            {
                unsafe
                {
                    fixed (GLXHyperpipeConfig* cfg_ptr = cfg)
                    fixed (int* hpId_ptr = hpId)
                    {
                        int retval = Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfig*)cfg_ptr, (int*)hpId_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, GLXHyperpipeConfig[] cfg, [Out] out int hpId)
            {
                unsafe
                {
                    fixed (GLXHyperpipeConfig* cfg_ptr = cfg)
                    fixed (int* hpId_ptr = &hpId)
                    {
                        int retval = Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfig*)cfg_ptr, (int*)hpId_ptr);
                                hpId = *hpId_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, ref GLXHyperpipeConfig cfg, [Out] int* hpId)
            {
                unsafe
                {
                    fixed (GLXHyperpipeConfig* cfg_ptr = &cfg)
                    {
                        int retval = Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfig*)cfg_ptr, (int*)hpId);
                        return retval;
                    }
                }
            }
            
            public static 
            int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, ref GLXHyperpipeConfig cfg, [Out] int[] hpId)
            {
                unsafe
                {
                    fixed (GLXHyperpipeConfig* cfg_ptr = &cfg)
                    fixed (int* hpId_ptr = hpId)
                    {
                        int retval = Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfig*)cfg_ptr, (int*)hpId_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, ref GLXHyperpipeConfig cfg, [Out] out int hpId)
            {
                unsafe
                {
                    fixed (GLXHyperpipeConfig* cfg_ptr = &cfg)
                    fixed (int* hpId_ptr = &hpId)
                    {
                        int retval = Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfig*)cfg_ptr, (int*)hpId_ptr);
                                hpId = *hpId_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe GLXHyperpipeConfigPointer QueryHyperpipeConfig([Out] IntPtr dpy, int hpId, [Out] int* npipes)
            {
                unsafe { return Delegates.glXQueryHyperpipeConfigSGIX((IntPtr)dpy, (int)hpId, (int*)npipes); }
            }
            
            public static 
            GLXHyperpipeConfigPointer QueryHyperpipeConfig([Out] IntPtr dpy, int hpId, [Out] int[] npipes)
            {
                unsafe
                {
                    fixed (int* npipes_ptr = npipes)
                    {
                        GLXHyperpipeConfigPointer retval = Delegates.glXQueryHyperpipeConfigSGIX((IntPtr)dpy, (int)hpId, (int*)npipes_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            GLXHyperpipeConfigPointer QueryHyperpipeConfig([Out] IntPtr dpy, int hpId, [Out] out int npipes)
            {
                unsafe
                {
                    fixed (int* npipes_ptr = &npipes)
                    {
                        GLXHyperpipeConfigPointer retval = Delegates.glXQueryHyperpipeConfigSGIX((IntPtr)dpy, (int)hpId, (int*)npipes_ptr);
                                npipes = *npipes_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int DestroyHyperpipeConfig([Out] IntPtr dpy, int hpId)
            {
                return Delegates.glXDestroyHyperpipeConfigSGIX((IntPtr)dpy, (int)hpId);
            }
            
            public static 
            int BindHyperpipe([Out] IntPtr dpy, int hpId)
            {
                return Delegates.glXBindHyperpipeSGIX((IntPtr)dpy, (int)hpId);
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryHyperpipeBestAttrib([Out] IntPtr dpy, int timeSlice, int attrib, int size, void* attribList, [Out] void* returnAttribList)
            {
                unsafe { return Delegates.glXQueryHyperpipeBestAttribSGIX((IntPtr)dpy, (int)timeSlice, (int)attrib, (int)size, (void*)attribList, (void*)returnAttribList); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryHyperpipeBestAttrib([Out] IntPtr dpy, int timeSlice, int attrib, int size, void* attribList, [In, Out] object returnAttribList)
            {
                unsafe
                {
                    System.Runtime.InteropServices.GCHandle returnAttribList_ptr = System.Runtime.InteropServices.GCHandle.Alloc(returnAttribList, System.Runtime.InteropServices.GCHandleType.Pinned);
                    try
                    {
                        int retval = Delegates.glXQueryHyperpipeBestAttribSGIX((IntPtr)dpy, (int)timeSlice, (int)attrib, (int)size, (void*)attribList, (void*)returnAttribList_ptr.AddrOfPinnedObject());
                        return retval;
                    }
                    finally
                    {
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryHyperpipeBestAttrib([Out] IntPtr dpy, int timeSlice, int attrib, int size, [In, Out] object attribList, [Out] void* returnAttribList)
            {
                unsafe
                {
                    System.Runtime.InteropServices.GCHandle attribList_ptr = System.Runtime.InteropServices.GCHandle.Alloc(attribList, System.Runtime.InteropServices.GCHandleType.Pinned);
                    try
                    {
                        int retval = Delegates.glXQueryHyperpipeBestAttribSGIX((IntPtr)dpy, (int)timeSlice, (int)attrib, (int)size, (void*)attribList_ptr.AddrOfPinnedObject(), (void*)returnAttribList);
                        return retval;
                    }
                    finally
                    {
                    }
                }
            }
            
            public static 
            int QueryHyperpipeBestAttrib([Out] IntPtr dpy, int timeSlice, int attrib, int size, [In, Out] object attribList, [In, Out] object returnAttribList)
            {
                unsafe
                {
                    System.Runtime.InteropServices.GCHandle attribList_ptr = System.Runtime.InteropServices.GCHandle.Alloc(attribList, System.Runtime.InteropServices.GCHandleType.Pinned);
                    System.Runtime.InteropServices.GCHandle returnAttribList_ptr = System.Runtime.InteropServices.GCHandle.Alloc(returnAttribList, System.Runtime.InteropServices.GCHandleType.Pinned);
                    try
                    {
                        int retval = Delegates.glXQueryHyperpipeBestAttribSGIX((IntPtr)dpy, (int)timeSlice, (int)attrib, (int)size, (void*)attribList_ptr.AddrOfPinnedObject(), (void*)returnAttribList_ptr.AddrOfPinnedObject());
                        return retval;
                    }
                    finally
                    {
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int HyperpipeAttrib([Out] IntPtr dpy, int timeSlice, int attrib, int size, void* attribList)
            {
                unsafe { return Delegates.glXHyperpipeAttribSGIX((IntPtr)dpy, (int)timeSlice, (int)attrib, (int)size, (void*)attribList); }
            }
            
            public static 
            int HyperpipeAttrib([Out] IntPtr dpy, int timeSlice, int attrib, int size, [In, Out] object attribList)
            {
                unsafe
                {
                    System.Runtime.InteropServices.GCHandle attribList_ptr = System.Runtime.InteropServices.GCHandle.Alloc(attribList, System.Runtime.InteropServices.GCHandleType.Pinned);
                    try
                    {
                        int retval = Delegates.glXHyperpipeAttribSGIX((IntPtr)dpy, (int)timeSlice, (int)attrib, (int)size, (void*)attribList_ptr.AddrOfPinnedObject());
                        return retval;
                    }
                    finally
                    {
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryHyperpipeAttrib([Out] IntPtr dpy, int timeSlice, int attrib, int size, [Out] void* returnAttribList)
            {
                unsafe { return Delegates.glXQueryHyperpipeAttribSGIX((IntPtr)dpy, (int)timeSlice, (int)attrib, (int)size, (void*)returnAttribList); }
            }
            
            public static 
            int QueryHyperpipeAttrib([Out] IntPtr dpy, int timeSlice, int attrib, int size, [In, Out] object returnAttribList)
            {
                unsafe
                {
                    System.Runtime.InteropServices.GCHandle returnAttribList_ptr = System.Runtime.InteropServices.GCHandle.Alloc(returnAttribList, System.Runtime.InteropServices.GCHandleType.Pinned);
                    try
                    {
                        int retval = Delegates.glXQueryHyperpipeAttribSGIX((IntPtr)dpy, (int)timeSlice, (int)attrib, (int)size, (void*)returnAttribList_ptr.AddrOfPinnedObject());
                        return retval;
                    }
                    finally
                    {
                    }
                }
            }
            
            public static 
            GLXVideoSourceSGIX CreateGLXVideoSource([Out] IntPtr display, int screen, IntPtr server, IntPtr path, int nodeClass, IntPtr drainNode)
            {
                return Delegates.glXCreateGLXVideoSourceSGIX((IntPtr)display, (int)screen, (IntPtr)server, (IntPtr)path, (int)nodeClass, (IntPtr)drainNode);
            }
            
            public static 
            void DestroyGLXVideoSource([Out] IntPtr dpy, GLXVideoSourceSGIX glxvideosource)
            {
                Delegates.glXDestroyGLXVideoSourceSGIX((IntPtr)dpy, (GLXVideoSourceSGIX)glxvideosource);
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int GetFBConfigAttrib([Out] IntPtr dpy, GLXFBConfigSGIX config, int attribute, [Out] int* value)
            {
                unsafe { return Delegates.glXGetFBConfigAttribSGIX((IntPtr)dpy, (GLXFBConfigSGIX)config, (int)attribute, (int*)value); }
            }
            
            public static 
            int GetFBConfigAttrib([Out] IntPtr dpy, GLXFBConfigSGIX config, int attribute, [Out] int[] value)
            {
                unsafe
                {
                    fixed (int* value_ptr = value)
                    {
                        int retval = Delegates.glXGetFBConfigAttribSGIX((IntPtr)dpy, (GLXFBConfigSGIX)config, (int)attribute, (int*)value_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            int GetFBConfigAttrib([Out] IntPtr dpy, GLXFBConfigSGIX config, int attribute, [Out] out int value)
            {
                unsafe
                {
                    fixed (int* value_ptr = &value)
                    {
                        int retval = Delegates.glXGetFBConfigAttribSGIX((IntPtr)dpy, (GLXFBConfigSGIX)config, (int)attribute, (int*)value_ptr);
                                value = *value_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe GLXFBConfigSGIX ChooseFBConfig([Out] IntPtr dpy, int screen, [Out] int* attrib_list, [Out] int* nelements)
            {
                unsafe { return Delegates.glXChooseFBConfigSGIX((IntPtr)dpy, (int)screen, (int*)attrib_list, (int*)nelements); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe GLXFBConfigSGIX ChooseFBConfig([Out] IntPtr dpy, int screen, [Out] int* attrib_list, [Out] int[] nelements)
            {
                unsafe
                {
                    fixed (int* nelements_ptr = nelements)
                    {
                        GLXFBConfigSGIX retval = Delegates.glXChooseFBConfigSGIX((IntPtr)dpy, (int)screen, (int*)attrib_list, (int*)nelements_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe GLXFBConfigSGIX ChooseFBConfig([Out] IntPtr dpy, int screen, [Out] int* attrib_list, [Out] out int nelements)
            {
                unsafe
                {
                    fixed (int* nelements_ptr = &nelements)
                    {
                        GLXFBConfigSGIX retval = Delegates.glXChooseFBConfigSGIX((IntPtr)dpy, (int)screen, (int*)attrib_list, (int*)nelements_ptr);
                                nelements = *nelements_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe GLXFBConfigSGIX ChooseFBConfig([Out] IntPtr dpy, int screen, [Out] int[] attrib_list, [Out] int* nelements)
            {
                unsafe
                {
                    fixed (int* attrib_list_ptr = attrib_list)
                    {
                        GLXFBConfigSGIX retval = Delegates.glXChooseFBConfigSGIX((IntPtr)dpy, (int)screen, (int*)attrib_list_ptr, (int*)nelements);
                        return retval;
                    }
                }
            }
            
            public static 
            GLXFBConfigSGIX ChooseFBConfig([Out] IntPtr dpy, int screen, [Out] int[] attrib_list, [Out] int[] nelements)
            {
                unsafe
                {
                    fixed (int* attrib_list_ptr = attrib_list)
                    fixed (int* nelements_ptr = nelements)
                    {
                        GLXFBConfigSGIX retval = Delegates.glXChooseFBConfigSGIX((IntPtr)dpy, (int)screen, (int*)attrib_list_ptr, (int*)nelements_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            GLXFBConfigSGIX ChooseFBConfig([Out] IntPtr dpy, int screen, [Out] int[] attrib_list, [Out] out int nelements)
            {
                unsafe
                {
                    fixed (int* attrib_list_ptr = attrib_list)
                    fixed (int* nelements_ptr = &nelements)
                    {
                        GLXFBConfigSGIX retval = Delegates.glXChooseFBConfigSGIX((IntPtr)dpy, (int)screen, (int*)attrib_list_ptr, (int*)nelements_ptr);
                                nelements = *nelements_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe GLXFBConfigSGIX ChooseFBConfig([Out] IntPtr dpy, int screen, [Out] out int attrib_list, [Out] int* nelements)
            {
                unsafe
                {
                    fixed (int* attrib_list_ptr = &attrib_list)
                    {
                        GLXFBConfigSGIX retval = Delegates.glXChooseFBConfigSGIX((IntPtr)dpy, (int)screen, (int*)attrib_list_ptr, (int*)nelements);
                                attrib_list = *attrib_list_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            GLXFBConfigSGIX ChooseFBConfig([Out] IntPtr dpy, int screen, [Out] out int attrib_list, [Out] int[] nelements)
            {
                unsafe
                {
                    fixed (int* attrib_list_ptr = &attrib_list)
                    fixed (int* nelements_ptr = nelements)
                    {
                        GLXFBConfigSGIX retval = Delegates.glXChooseFBConfigSGIX((IntPtr)dpy, (int)screen, (int*)attrib_list_ptr, (int*)nelements_ptr);
                                attrib_list = *attrib_list_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            GLXFBConfigSGIX ChooseFBConfig([Out] IntPtr dpy, int screen, [Out] out int attrib_list, [Out] out int nelements)
            {
                unsafe
                {
                    fixed (int* attrib_list_ptr = &attrib_list)
                    fixed (int* nelements_ptr = &nelements)
                    {
                        GLXFBConfigSGIX retval = Delegates.glXChooseFBConfigSGIX((IntPtr)dpy, (int)screen, (int*)attrib_list_ptr, (int*)nelements_ptr);
                                attrib_list = *attrib_list_ptr;
                                nelements = *nelements_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            IntPtr CreateGLXPixmapWithConfig([Out] IntPtr dpy, GLXFBConfigSGIX config, IntPtr pixmap)
            {
                return Delegates.glXCreateGLXPixmapWithConfigSGIX((IntPtr)dpy, (GLXFBConfigSGIX)config, (IntPtr)pixmap);
            }
            
            public static 
            IntPtr CreateContextWithConfig([Out] IntPtr dpy, GLXFBConfigSGIX config, int render_type, IntPtr share_list, bool direct)
            {
                 return Delegates.glXCreateContextWithConfigSGIX((IntPtr)dpy, (GLXFBConfigSGIX)config, (int)render_type, (IntPtr)share_list, (bool)direct); 
            }
            
            public static 
            XVisualInfo GetVisualFromFBConfig([Out] IntPtr dpy, GLXFBConfigSGIX config)
            {
                return Delegates.glXGetVisualFromFBConfigSGIX((IntPtr)dpy, (GLXFBConfigSGIX)config);
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe GLXFBConfigSGIX GetFBConfigFromVisual([Out] IntPtr dpy, [Out] XVisualInfo* vis)
            {
                unsafe { return Delegates.glXGetFBConfigFromVisualSGIX((IntPtr)dpy, (XVisualInfo*)vis); }
            }
            
            public static 
            GLXFBConfigSGIX GetFBConfigFromVisual([Out] IntPtr dpy, [Out] XVisualInfo[] vis)
            {
                unsafe
                {
                    fixed (XVisualInfo* vis_ptr = vis)
                    {
                        GLXFBConfigSGIX retval = Delegates.glXGetFBConfigFromVisualSGIX((IntPtr)dpy, (XVisualInfo*)vis_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            GLXFBConfigSGIX GetFBConfigFromVisual([Out] IntPtr dpy, [Out] out XVisualInfo vis)
            {
                unsafe
                {
                    fixed (XVisualInfo* vis_ptr = &vis)
                    {
                        GLXFBConfigSGIX retval = Delegates.glXGetFBConfigFromVisualSGIX((IntPtr)dpy, (XVisualInfo*)vis_ptr);
                                vis = *vis_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe GLXPbufferSGIX CreateGLXPbuffer([Out] IntPtr dpy, GLXFBConfigSGIX config, uint width, uint height, [Out] int* attrib_list)
            {
                unsafe { return Delegates.glXCreateGLXPbufferSGIX((IntPtr)dpy, (GLXFBConfigSGIX)config, (uint)width, (uint)height, (int*)attrib_list); }
            }
            
            public static 
            GLXPbufferSGIX CreateGLXPbuffer([Out] IntPtr dpy, GLXFBConfigSGIX config, uint width, uint height, [Out] int[] attrib_list)
            {
                unsafe
                {
                    fixed (int* attrib_list_ptr = attrib_list)
                    {
                        GLXPbufferSGIX retval = Delegates.glXCreateGLXPbufferSGIX((IntPtr)dpy, (GLXFBConfigSGIX)config, (uint)width, (uint)height, (int*)attrib_list_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            GLXPbufferSGIX CreateGLXPbuffer([Out] IntPtr dpy, GLXFBConfigSGIX config, uint width, uint height, [Out] out int attrib_list)
            {
                unsafe
                {
                    fixed (int* attrib_list_ptr = &attrib_list)
                    {
                        GLXPbufferSGIX retval = Delegates.glXCreateGLXPbufferSGIX((IntPtr)dpy, (GLXFBConfigSGIX)config, (uint)width, (uint)height, (int*)attrib_list_ptr);
                                attrib_list = *attrib_list_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            void DestroyGLXPbuffer([Out] IntPtr dpy, GLXPbufferSGIX pbuf)
            {
                Delegates.glXDestroyGLXPbufferSGIX((IntPtr)dpy, (GLXPbufferSGIX)pbuf);
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryGLXPbuffer([Out] IntPtr dpy, GLXPbufferSGIX pbuf, int attribute, [Out] uint* value)
            {
                unsafe { return Delegates.glXQueryGLXPbufferSGIX((IntPtr)dpy, (GLXPbufferSGIX)pbuf, (int)attribute, (uint*)value); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryGLXPbuffer([Out] IntPtr dpy, GLXPbufferSGIX pbuf, int attribute, [Out] Int32* value)
            {
                unsafe
                {
                    int retval = Delegates.glXQueryGLXPbufferSGIX((IntPtr)dpy, (GLXPbufferSGIX)pbuf, (int)attribute, (uint*)value);
                    return retval;
                }
            }
            
            public static 
            int QueryGLXPbuffer([Out] IntPtr dpy, GLXPbufferSGIX pbuf, int attribute, [Out] uint[] value)
            {
                unsafe
                {
                    fixed (uint* value_ptr = value)
                    {
                        int retval = Delegates.glXQueryGLXPbufferSGIX((IntPtr)dpy, (GLXPbufferSGIX)pbuf, (int)attribute, (uint*)value_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryGLXPbuffer([Out] IntPtr dpy, GLXPbufferSGIX pbuf, int attribute, [Out] out uint value)
            {
                unsafe
                {
                    fixed (uint* value_ptr = &value)
                    {
                        int retval = Delegates.glXQueryGLXPbufferSGIX((IntPtr)dpy, (GLXPbufferSGIX)pbuf, (int)attribute, (uint*)value_ptr);
                                value = *value_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            void SelectEvent([Out] IntPtr dpy, IntPtr drawable, ulong mask)
            {
                Delegates.glXSelectEventSGIX((IntPtr)dpy, (IntPtr)drawable, (ulong)mask);
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetSelectedEvent([Out] IntPtr dpy, IntPtr drawable, [Out] ulong* mask)
            {
                unsafe { Delegates.glXGetSelectedEventSGIX((IntPtr)dpy, (IntPtr)drawable, (ulong*)mask); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetSelectedEvent([Out] IntPtr dpy, IntPtr drawable, [Out] Int64* mask)
            {
                unsafe
                {
                    Delegates.glXGetSelectedEventSGIX((IntPtr)dpy, (IntPtr)drawable, (ulong*)mask);
                }
            }
            
            public static 
            void GetSelectedEvent([Out] IntPtr dpy, IntPtr drawable, [Out] ulong[] mask)
            {
                unsafe
                {
                    fixed (ulong* mask_ptr = mask)
                    {
                        Delegates.glXGetSelectedEventSGIX((IntPtr)dpy, (IntPtr)drawable, (ulong*)mask_ptr);
                    }
                }
            }
            
            public static 
            void GetSelectedEvent([Out] IntPtr dpy, IntPtr drawable, [Out] out ulong mask)
            {
                unsafe
                {
                    fixed (ulong* mask_ptr = &mask)
                    {
                        Delegates.glXGetSelectedEventSGIX((IntPtr)dpy, (IntPtr)drawable, (ulong*)mask_ptr);
                                mask = *mask_ptr;
                    }
                }
            }
            
            public static 
            int BindChannelToWindow([Out] IntPtr display, int screen, int channel, IntPtr window)
            {
                return Delegates.glXBindChannelToWindowSGIX((IntPtr)display, (int)screen, (int)channel, (IntPtr)window);
            }
            
            public static 
            int ChannelRect([Out] IntPtr display, int screen, int channel, int x, int y, int w, int h)
            {
                return Delegates.glXChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int)x, (int)y, (int)w, (int)h);
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int* dy, [Out] int* dw, [Out] int* dh)
            {
                unsafe { return Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy, (int*)dw, (int*)dh); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int* dy, [Out] int* dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy, (int*)dw, (int*)dh_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int* dy, [Out] int* dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy, (int*)dw, (int*)dh_ptr);
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int* dy, [Out] int[] dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dw_ptr = dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy, (int*)dw_ptr, (int*)dh);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int* dy, [Out] int[] dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy, (int*)dw_ptr, (int*)dh_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int* dy, [Out] int[] dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy, (int*)dw_ptr, (int*)dh_ptr);
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int* dy, [Out] out int dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dw_ptr = &dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy, (int*)dw_ptr, (int*)dh);
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int* dy, [Out] out int dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy, (int*)dw_ptr, (int*)dh_ptr);
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int* dy, [Out] out int dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy, (int*)dw_ptr, (int*)dh_ptr);
                                dw = *dw_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int[] dy, [Out] int* dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = dy)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw, (int*)dh);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int[] dy, [Out] int* dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = dy)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw, (int*)dh_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int[] dy, [Out] int* dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = dy)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw, (int*)dh_ptr);
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int[] dy, [Out] int[] dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw_ptr, (int*)dh);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int[] dy, [Out] int[] dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int[] dy, [Out] int[] dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int[] dy, [Out] out int dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = &dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw_ptr, (int*)dh);
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int[] dy, [Out] out int dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int[] dy, [Out] out int dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dw = *dw_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] out int dy, [Out] int* dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = &dy)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw, (int*)dh);
                                dy = *dy_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] out int dy, [Out] int* dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw, (int*)dh_ptr);
                                dy = *dy_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] out int dy, [Out] int* dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw, (int*)dh_ptr);
                                dy = *dy_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] out int dy, [Out] int[] dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw_ptr, (int*)dh);
                                dy = *dy_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] out int dy, [Out] int[] dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dy = *dy_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] out int dy, [Out] int[] dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dy = *dy_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] out int dy, [Out] out int dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = &dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw_ptr, (int*)dh);
                                dy = *dy_ptr;
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] out int dy, [Out] out int dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dy = *dy_ptr;
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] out int dy, [Out] out int dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dy = *dy_ptr;
                                dw = *dw_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int* dy, [Out] int* dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw, (int*)dh);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int* dy, [Out] int* dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw, (int*)dh_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int* dy, [Out] int* dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw, (int*)dh_ptr);
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int* dy, [Out] int[] dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dw_ptr = dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw_ptr, (int*)dh);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int* dy, [Out] int[] dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw_ptr, (int*)dh_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int* dy, [Out] int[] dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw_ptr, (int*)dh_ptr);
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int* dy, [Out] out int dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dw_ptr = &dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw_ptr, (int*)dh);
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int* dy, [Out] out int dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw_ptr, (int*)dh_ptr);
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int* dy, [Out] out int dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw_ptr, (int*)dh_ptr);
                                dw = *dw_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int[] dy, [Out] int* dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = dy)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw, (int*)dh);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int[] dy, [Out] int* dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = dy)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw, (int*)dh_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int[] dy, [Out] int* dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = dy)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw, (int*)dh_ptr);
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int[] dy, [Out] int[] dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh);
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int[] dy, [Out] int[] dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int[] dy, [Out] int[] dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int[] dy, [Out] out int dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = &dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh);
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int[] dy, [Out] out int dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] int[] dy, [Out] out int dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dw = *dw_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] out int dy, [Out] int* dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = &dy)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw, (int*)dh);
                                dy = *dy_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] out int dy, [Out] int* dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw, (int*)dh_ptr);
                                dy = *dy_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] out int dy, [Out] int* dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw, (int*)dh_ptr);
                                dy = *dy_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] out int dy, [Out] int[] dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh);
                                dy = *dy_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] out int dy, [Out] int[] dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dy = *dy_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] out int dy, [Out] int[] dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dy = *dy_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] out int dy, [Out] out int dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = &dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh);
                                dy = *dy_ptr;
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] out int dy, [Out] out int dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dy = *dy_ptr;
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] int[] dx, [Out] out int dy, [Out] out int dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = dx)
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dy = *dy_ptr;
                                dw = *dw_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int* dy, [Out] int* dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw, (int*)dh);
                                dx = *dx_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int* dy, [Out] int* dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw, (int*)dh_ptr);
                                dx = *dx_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int* dy, [Out] int* dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw, (int*)dh_ptr);
                                dx = *dx_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int* dy, [Out] int[] dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dw_ptr = dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw_ptr, (int*)dh);
                                dx = *dx_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int* dy, [Out] int[] dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw_ptr, (int*)dh_ptr);
                                dx = *dx_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int* dy, [Out] int[] dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw_ptr, (int*)dh_ptr);
                                dx = *dx_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int* dy, [Out] out int dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dw_ptr = &dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw_ptr, (int*)dh);
                                dx = *dx_ptr;
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int* dy, [Out] out int dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw_ptr, (int*)dh_ptr);
                                dx = *dx_ptr;
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int* dy, [Out] out int dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy, (int*)dw_ptr, (int*)dh_ptr);
                                dx = *dx_ptr;
                                dw = *dw_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int[] dy, [Out] int* dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = dy)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw, (int*)dh);
                                dx = *dx_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int[] dy, [Out] int* dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = dy)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw, (int*)dh_ptr);
                                dx = *dx_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int[] dy, [Out] int* dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = dy)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw, (int*)dh_ptr);
                                dx = *dx_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int[] dy, [Out] int[] dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh);
                                dx = *dx_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int[] dy, [Out] int[] dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dx = *dx_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int[] dy, [Out] int[] dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dx = *dx_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int[] dy, [Out] out int dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = &dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh);
                                dx = *dx_ptr;
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int[] dy, [Out] out int dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dx = *dx_ptr;
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] int[] dy, [Out] out int dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = dy)
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dx = *dx_ptr;
                                dw = *dw_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] out int dy, [Out] int* dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = &dy)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw, (int*)dh);
                                dx = *dx_ptr;
                                dy = *dy_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] out int dy, [Out] int* dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw, (int*)dh_ptr);
                                dx = *dx_ptr;
                                dy = *dy_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] out int dy, [Out] int* dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw, (int*)dh_ptr);
                                dx = *dx_ptr;
                                dy = *dy_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] out int dy, [Out] int[] dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh);
                                dx = *dx_ptr;
                                dy = *dy_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] out int dy, [Out] int[] dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dx = *dx_ptr;
                                dy = *dy_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] out int dy, [Out] int[] dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dx = *dx_ptr;
                                dy = *dy_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] out int dy, [Out] out int dw, [Out] int* dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = &dw)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh);
                                dx = *dx_ptr;
                                dy = *dy_ptr;
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] out int dy, [Out] out int dw, [Out] int[] dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dx = *dx_ptr;
                                dy = *dy_ptr;
                                dw = *dw_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelRect([Out] IntPtr display, int screen, int channel, [Out] out int dx, [Out] out int dy, [Out] out int dw, [Out] out int dh)
            {
                unsafe
                {
                    fixed (int* dx_ptr = &dx)
                    fixed (int* dy_ptr = &dy)
                    fixed (int* dw_ptr = &dw)
                    fixed (int* dh_ptr = &dh)
                    {
                        int retval = Delegates.glXQueryChannelRectSGIX((IntPtr)display, (int)screen, (int)channel, (int*)dx_ptr, (int*)dy_ptr, (int*)dw_ptr, (int*)dh_ptr);
                                dx = *dx_ptr;
                                dy = *dy_ptr;
                                dw = *dw_ptr;
                                dh = *dh_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int* y, [Out] int* w, [Out] int* h)
            {
                unsafe { return Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y, (int*)w, (int*)h); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int* y, [Out] int* w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y, (int*)w, (int*)h_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int* y, [Out] int* w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y, (int*)w, (int*)h_ptr);
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int* y, [Out] int[] w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* w_ptr = w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y, (int*)w_ptr, (int*)h);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int* y, [Out] int[] w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y, (int*)w_ptr, (int*)h_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int* y, [Out] int[] w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y, (int*)w_ptr, (int*)h_ptr);
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int* y, [Out] out int w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* w_ptr = &w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y, (int*)w_ptr, (int*)h);
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int* y, [Out] out int w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y, (int*)w_ptr, (int*)h_ptr);
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int* y, [Out] out int w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y, (int*)w_ptr, (int*)h_ptr);
                                w = *w_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int[] y, [Out] int* w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* y_ptr = y)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w, (int*)h);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int[] y, [Out] int* w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* y_ptr = y)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w, (int*)h_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int[] y, [Out] int* w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* y_ptr = y)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w, (int*)h_ptr);
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int[] y, [Out] int[] w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w_ptr, (int*)h);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int[] y, [Out] int[] w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int[] y, [Out] int[] w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int[] y, [Out] out int w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = &w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w_ptr, (int*)h);
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int[] y, [Out] out int w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int[] y, [Out] out int w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                w = *w_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] out int y, [Out] int* w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* y_ptr = &y)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w, (int*)h);
                                y = *y_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] out int y, [Out] int* w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* y_ptr = &y)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w, (int*)h_ptr);
                                y = *y_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] out int y, [Out] int* w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* y_ptr = &y)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w, (int*)h_ptr);
                                y = *y_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] out int y, [Out] int[] w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w_ptr, (int*)h);
                                y = *y_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] out int y, [Out] int[] w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                y = *y_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] out int y, [Out] int[] w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                y = *y_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] out int y, [Out] out int w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = &w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w_ptr, (int*)h);
                                y = *y_ptr;
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] out int y, [Out] out int w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                y = *y_ptr;
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] out int y, [Out] out int w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                y = *y_ptr;
                                w = *w_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int* y, [Out] int* w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w, (int*)h);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int* y, [Out] int* w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w, (int*)h_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int* y, [Out] int* w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w, (int*)h_ptr);
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int* y, [Out] int[] w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* w_ptr = w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w_ptr, (int*)h);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int* y, [Out] int[] w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w_ptr, (int*)h_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int* y, [Out] int[] w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w_ptr, (int*)h_ptr);
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int* y, [Out] out int w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* w_ptr = &w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w_ptr, (int*)h);
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int* y, [Out] out int w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w_ptr, (int*)h_ptr);
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int* y, [Out] out int w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w_ptr, (int*)h_ptr);
                                w = *w_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int[] y, [Out] int* w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = y)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w, (int*)h);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int[] y, [Out] int* w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = y)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w, (int*)h_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int[] y, [Out] int* w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = y)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w, (int*)h_ptr);
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int[] y, [Out] int[] w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h);
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int[] y, [Out] int[] w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int[] y, [Out] int[] w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int[] y, [Out] out int w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = &w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h);
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int[] y, [Out] out int w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] int[] y, [Out] out int w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                w = *w_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] out int y, [Out] int* w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = &y)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w, (int*)h);
                                y = *y_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] out int y, [Out] int* w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = &y)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w, (int*)h_ptr);
                                y = *y_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] out int y, [Out] int* w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = &y)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w, (int*)h_ptr);
                                y = *y_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] out int y, [Out] int[] w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h);
                                y = *y_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] out int y, [Out] int[] w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                y = *y_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] out int y, [Out] int[] w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                y = *y_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] out int y, [Out] out int w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = &w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h);
                                y = *y_ptr;
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] out int y, [Out] out int w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                y = *y_ptr;
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int[] x, [Out] out int y, [Out] out int w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = x)
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                y = *y_ptr;
                                w = *w_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int* y, [Out] int* w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w, (int*)h);
                                x = *x_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int* y, [Out] int* w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w, (int*)h_ptr);
                                x = *x_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int* y, [Out] int* w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w, (int*)h_ptr);
                                x = *x_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int* y, [Out] int[] w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* w_ptr = w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w_ptr, (int*)h);
                                x = *x_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int* y, [Out] int[] w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w_ptr, (int*)h_ptr);
                                x = *x_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int* y, [Out] int[] w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w_ptr, (int*)h_ptr);
                                x = *x_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int* y, [Out] out int w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* w_ptr = &w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w_ptr, (int*)h);
                                x = *x_ptr;
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int* y, [Out] out int w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w_ptr, (int*)h_ptr);
                                x = *x_ptr;
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int* y, [Out] out int w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y, (int*)w_ptr, (int*)h_ptr);
                                x = *x_ptr;
                                w = *w_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int[] y, [Out] int* w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = y)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w, (int*)h);
                                x = *x_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int[] y, [Out] int* w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = y)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w, (int*)h_ptr);
                                x = *x_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int[] y, [Out] int* w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = y)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w, (int*)h_ptr);
                                x = *x_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int[] y, [Out] int[] w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h);
                                x = *x_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int[] y, [Out] int[] w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                x = *x_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int[] y, [Out] int[] w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                x = *x_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int[] y, [Out] out int w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = &w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h);
                                x = *x_ptr;
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int[] y, [Out] out int w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                x = *x_ptr;
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] int[] y, [Out] out int w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = y)
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                x = *x_ptr;
                                w = *w_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] out int y, [Out] int* w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = &y)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w, (int*)h);
                                x = *x_ptr;
                                y = *y_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] out int y, [Out] int* w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = &y)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w, (int*)h_ptr);
                                x = *x_ptr;
                                y = *y_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] out int y, [Out] int* w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = &y)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w, (int*)h_ptr);
                                x = *x_ptr;
                                y = *y_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] out int y, [Out] int[] w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h);
                                x = *x_ptr;
                                y = *y_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] out int y, [Out] int[] w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                x = *x_ptr;
                                y = *y_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] out int y, [Out] int[] w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                x = *x_ptr;
                                y = *y_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] out int y, [Out] out int w, [Out] int* h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = &w)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h);
                                x = *x_ptr;
                                y = *y_ptr;
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] out int y, [Out] out int w, [Out] int[] h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                x = *x_ptr;
                                y = *y_ptr;
                                w = *w_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] out int x, [Out] out int y, [Out] out int w, [Out] out int h)
            {
                unsafe
                {
                    fixed (int* x_ptr = &x)
                    fixed (int* y_ptr = &y)
                    fixed (int* w_ptr = &w)
                    fixed (int* h_ptr = &h)
                    {
                        int retval = Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x_ptr, (int*)y_ptr, (int*)w_ptr, (int*)h_ptr);
                                x = *x_ptr;
                                y = *y_ptr;
                                w = *w_ptr;
                                h = *h_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int ChannelRectSync([Out] IntPtr display, int screen, int channel, Glx.Enums.SGIX_video_resize synctype)
            {
                return Delegates.glXChannelRectSyncSGIX((IntPtr)display, (int)screen, (int)channel, (Glx.Enums.SGIX_video_resize)synctype);
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool AssociateDMPbuffer([Out] IntPtr dpy, GLXPbufferSGIX pbuffer, [Out] DMparams* @params, DMbuffer dmbuffer)
            {
                unsafe { return Delegates.glXAssociateDMPbufferSGIX((IntPtr)dpy, (GLXPbufferSGIX)pbuffer, (DMparams*)@params, (DMbuffer)dmbuffer); }
            }
            
            public static 
            bool AssociateDMPbuffer([Out] IntPtr dpy, GLXPbufferSGIX pbuffer, [Out] DMparams[] @params, DMbuffer dmbuffer)
            {
                unsafe
                {
                    fixed (DMparams* @params_ptr = @params)
                    {
                        bool retval = Delegates.glXAssociateDMPbufferSGIX((IntPtr)dpy, (GLXPbufferSGIX)pbuffer, (DMparams*)@params_ptr, (DMbuffer)dmbuffer);
                        return retval;
                    }
                }
            }
            
            public static 
            bool AssociateDMPbuffer([Out] IntPtr dpy, GLXPbufferSGIX pbuffer, [Out] out DMparams @params, DMbuffer dmbuffer)
            {
                unsafe
                {
                    fixed (DMparams* @params_ptr = &@params)
                    {
                        bool retval = Delegates.glXAssociateDMPbufferSGIX((IntPtr)dpy, (GLXPbufferSGIX)pbuffer, (DMparams*)@params_ptr, (DMbuffer)dmbuffer);
                                @params = *@params_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            void JoinSwapGroup([Out] IntPtr dpy, IntPtr drawable, IntPtr member)
            {
                Delegates.glXJoinSwapGroupSGIX((IntPtr)dpy, (IntPtr)drawable, (IntPtr)member);
            }
            
            public static 
            void BindSwapBarrier([Out] IntPtr dpy, IntPtr drawable, int barrier)
            {
                Delegates.glXBindSwapBarrierSGIX((IntPtr)dpy, (IntPtr)drawable, (int)barrier);
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool QueryMaxSwapBarriers([Out] IntPtr dpy, int screen, [Out] int* max)
            {
                unsafe { return Delegates.glXQueryMaxSwapBarriersSGIX((IntPtr)dpy, (int)screen, (int*)max); }
            }
            
            public static 
            bool QueryMaxSwapBarriers([Out] IntPtr dpy, int screen, [Out] int[] max)
            {
                unsafe
                {
                    fixed (int* max_ptr = max)
                    {
                        bool retval = Delegates.glXQueryMaxSwapBarriersSGIX((IntPtr)dpy, (int)screen, (int*)max_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            bool QueryMaxSwapBarriers([Out] IntPtr dpy, int screen, [Out] out int max)
            {
                unsafe
                {
                    fixed (int* max_ptr = &max)
                    {
                        bool retval = Delegates.glXQueryMaxSwapBarriersSGIX((IntPtr)dpy, (int)screen, (int*)max_ptr);
                                max = *max_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, [Out] GLXHyperpipeConfigSGIX* cfg, [Out] int* hpId)
            {
                unsafe { return Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfigSGIX*)cfg, (int*)hpId); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, [Out] GLXHyperpipeConfigSGIX* cfg, [Out] int[] hpId)
            {
                unsafe
                {
                    fixed (int* hpId_ptr = hpId)
                    {
                        int retval = Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfigSGIX*)cfg, (int*)hpId_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, [Out] GLXHyperpipeConfigSGIX* cfg, [Out] out int hpId)
            {
                unsafe
                {
                    fixed (int* hpId_ptr = &hpId)
                    {
                        int retval = Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfigSGIX*)cfg, (int*)hpId_ptr);
                                hpId = *hpId_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, [Out] GLXHyperpipeConfigSGIX[] cfg, [Out] int* hpId)
            {
                unsafe
                {
                    fixed (GLXHyperpipeConfigSGIX* cfg_ptr = cfg)
                    {
                        int retval = Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfigSGIX*)cfg_ptr, (int*)hpId);
                        return retval;
                    }
                }
            }
            
            public static 
            int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, [Out] GLXHyperpipeConfigSGIX[] cfg, [Out] int[] hpId)
            {
                unsafe
                {
                    fixed (GLXHyperpipeConfigSGIX* cfg_ptr = cfg)
                    fixed (int* hpId_ptr = hpId)
                    {
                        int retval = Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfigSGIX*)cfg_ptr, (int*)hpId_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, [Out] GLXHyperpipeConfigSGIX[] cfg, [Out] out int hpId)
            {
                unsafe
                {
                    fixed (GLXHyperpipeConfigSGIX* cfg_ptr = cfg)
                    fixed (int* hpId_ptr = &hpId)
                    {
                        int retval = Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfigSGIX*)cfg_ptr, (int*)hpId_ptr);
                                hpId = *hpId_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, [Out] out GLXHyperpipeConfigSGIX cfg, [Out] int* hpId)
            {
                unsafe
                {
                    fixed (GLXHyperpipeConfigSGIX* cfg_ptr = &cfg)
                    {
                        int retval = Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfigSGIX*)cfg_ptr, (int*)hpId);
                                cfg = *cfg_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, [Out] out GLXHyperpipeConfigSGIX cfg, [Out] int[] hpId)
            {
                unsafe
                {
                    fixed (GLXHyperpipeConfigSGIX* cfg_ptr = &cfg)
                    fixed (int* hpId_ptr = hpId)
                    {
                        int retval = Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfigSGIX*)cfg_ptr, (int*)hpId_ptr);
                                cfg = *cfg_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, [Out] out GLXHyperpipeConfigSGIX cfg, [Out] out int hpId)
            {
                unsafe
                {
                    fixed (GLXHyperpipeConfigSGIX* cfg_ptr = &cfg)
                    fixed (int* hpId_ptr = &hpId)
                    {
                        int retval = Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfigSGIX*)cfg_ptr, (int*)hpId_ptr);
                                cfg = *cfg_ptr;
                                hpId = *hpId_ptr;
                        return retval;
                    }
                }
            }
            
        }

        public static class EXT
        {
            public static 
            void QueryContextInfo()
            {
                Delegates.glXQueryContextInfoEXT();
            }
            
            public static 
            IntPtr GetCurrentDisplay()
            {
                return Delegates.glXGetCurrentDisplayEXT();
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryContextInfo([Out] IntPtr dpy, IntPtr context, int attribute, [Out] int* value)
            {
                unsafe { return Delegates.glXQueryContextInfoEXT((IntPtr)dpy, (IntPtr)context, (int)attribute, (int*)value); }
            }
            
            public static 
            int QueryContextInfo([Out] IntPtr dpy, IntPtr context, int attribute, [Out] int[] value)
            {
                unsafe
                {
                    fixed (int* value_ptr = value)
                    {
                        int retval = Delegates.glXQueryContextInfoEXT((IntPtr)dpy, (IntPtr)context, (int)attribute, (int*)value_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            int QueryContextInfo([Out] IntPtr dpy, IntPtr context, int attribute, [Out] out int value)
            {
                unsafe
                {
                    fixed (int* value_ptr = &value)
                    {
                        int retval = Delegates.glXQueryContextInfoEXT((IntPtr)dpy, (IntPtr)context, (int)attribute, (int*)value_ptr);
                                value = *value_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            GLXContextID GetContextID(IntPtr context)
            {
                return Delegates.glXGetContextIDEXT((IntPtr)context);
            }
            
            public static 
            IntPtr ImportContext([Out] IntPtr dpy, GLXContextID contextID)
            {
                return Delegates.glXImportContextEXT((IntPtr)dpy, (GLXContextID)contextID);
            }
            
            public static 
            void FreeContext([Out] IntPtr dpy, IntPtr context)
            {
                Delegates.glXFreeContextEXT((IntPtr)dpy, (IntPtr)context);
            }
            
        }

        public static class ARB
        {
            [System.CLSCompliant(false)]
            public static 
            unsafe IntPtr GetProcAddres(Byte* procName)
            {
                unsafe { return Delegates.glXGetProcAddressARB((Byte*)procName); }
            }
            
            public static 
            IntPtr GetProcAddres(Byte[] procName)
            {
                unsafe
                {
                    fixed (Byte* procName_ptr = procName)
                    {
                        IntPtr retval = Delegates.glXGetProcAddressARB((Byte*)procName_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            IntPtr GetProcAddres(ref Byte procName)
            {
                unsafe
                {
                    fixed (Byte* procName_ptr = &procName)
                    {
                        IntPtr retval = Delegates.glXGetProcAddressARB((Byte*)procName_ptr);
                        return retval;
                    }
                }
            }
            
        }

        public static class SUN
        {
            [System.CLSCompliant(false)]
            public static 
            unsafe Status GetTransparentIndex([Out] IntPtr dpy, IntPtr overlay, IntPtr underlay, [Out] long* pTransparentIndex)
            {
                unsafe { return Delegates.glXGetTransparentIndexSUN((IntPtr)dpy, (IntPtr)overlay, (IntPtr)underlay, (long*)pTransparentIndex); }
            }
            
            public static 
            Status GetTransparentIndex([Out] IntPtr dpy, IntPtr overlay, IntPtr underlay, [Out] long[] pTransparentIndex)
            {
                unsafe
                {
                    fixed (long* pTransparentIndex_ptr = pTransparentIndex)
                    {
                        Status retval = Delegates.glXGetTransparentIndexSUN((IntPtr)dpy, (IntPtr)overlay, (IntPtr)underlay, (long*)pTransparentIndex_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            Status GetTransparentIndex([Out] IntPtr dpy, IntPtr overlay, IntPtr underlay, [Out] out long pTransparentIndex)
            {
                unsafe
                {
                    fixed (long* pTransparentIndex_ptr = &pTransparentIndex)
                    {
                        Status retval = Delegates.glXGetTransparentIndexSUN((IntPtr)dpy, (IntPtr)overlay, (IntPtr)underlay, (long*)pTransparentIndex_ptr);
                                pTransparentIndex = *pTransparentIndex_ptr;
                        return retval;
                    }
                }
            }
            
        }

        public static class MESA
        {
            public static 
            void CopySubBuffer([Out] IntPtr dpy, IntPtr drawable, int x, int y, int width, int height)
            {
                Delegates.glXCopySubBufferMESA((IntPtr)dpy, (IntPtr)drawable, (int)x, (int)y, (int)width, (int)height);
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe IntPtr CreateGLXPixmap([Out] IntPtr dpy, [Out] XVisualInfo* visual, IntPtr pixmap, IntPtr cmap)
            {
                unsafe { return Delegates.glXCreateGLXPixmapMESA((IntPtr)dpy, (XVisualInfo*)visual, (IntPtr)pixmap, (IntPtr)cmap); }
            }
            
            public static 
            IntPtr CreateGLXPixmap([Out] IntPtr dpy, [Out] XVisualInfo[] visual, IntPtr pixmap, IntPtr cmap)
            {
                unsafe
                {
                    fixed (XVisualInfo* visual_ptr = visual)
                    {
                        IntPtr retval = Delegates.glXCreateGLXPixmapMESA((IntPtr)dpy, (XVisualInfo*)visual_ptr, (IntPtr)pixmap, (IntPtr)cmap);
                        return retval;
                    }
                }
            }
            
            public static 
            IntPtr CreateGLXPixmap([Out] IntPtr dpy, [Out] out XVisualInfo visual, IntPtr pixmap, IntPtr cmap)
            {
                unsafe
                {
                    fixed (XVisualInfo* visual_ptr = &visual)
                    {
                        IntPtr retval = Delegates.glXCreateGLXPixmapMESA((IntPtr)dpy, (XVisualInfo*)visual_ptr, (IntPtr)pixmap, (IntPtr)cmap);
                                visual = *visual_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool ReleaseBuffers([Out] IntPtr dpy, IntPtr drawable)
            {
                return Delegates.glXReleaseBuffersMESA((IntPtr)dpy, (IntPtr)drawable);
            }
            
            public static 
            bool Set3DfxMode(int mode)
            {
                return Delegates.glXSet3DfxModeMESA((int)mode);
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe uint GetAGPOffset(void* pointer)
            {
                unsafe { return Delegates.glXGetAGPOffsetMESA((void*)pointer); }
            }
            
            public static 
            uint GetAGPOffset([In, Out] object pointer)
            {
                unsafe
                {
                    System.Runtime.InteropServices.GCHandle pointer_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pointer, System.Runtime.InteropServices.GCHandleType.Pinned);
                    try
                    {
                        uint retval = Delegates.glXGetAGPOffsetMESA((void*)pointer_ptr.AddrOfPinnedObject());
                        return retval;
                    }
                    finally
                    {
                    }
                }
            }
            
        }

        public static class OML
        {
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long* ust, [Out] long* msc, [Out] long* sbc)
            {
                unsafe { return Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust, (long*)msc, (long*)sbc); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long* ust, [Out] long* msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust, (long*)msc, (long*)sbc_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long* ust, [Out] long* msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust, (long*)msc, (long*)sbc_ptr);
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long* ust, [Out] long[] msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = msc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust, (long*)msc_ptr, (long*)sbc);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long* ust, [Out] long[] msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust, (long*)msc_ptr, (long*)sbc_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long* ust, [Out] long[] msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust, (long*)msc_ptr, (long*)sbc_ptr);
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long* ust, [Out] out long msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = &msc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust, (long*)msc_ptr, (long*)sbc);
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long* ust, [Out] out long msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust, (long*)msc_ptr, (long*)sbc_ptr);
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long* ust, [Out] out long msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust, (long*)msc_ptr, (long*)sbc_ptr);
                                msc = *msc_ptr;
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long[] ust, [Out] long* msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc, (long*)sbc);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long[] ust, [Out] long* msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc, (long*)sbc_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long[] ust, [Out] long* msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc, (long*)sbc_ptr);
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long[] ust, [Out] long[] msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = msc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc);
                        return retval;
                    }
                }
            }
            
            public static 
            bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long[] ust, [Out] long[] msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long[] ust, [Out] long[] msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long[] ust, [Out] out long msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = &msc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc);
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long[] ust, [Out] out long msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] long[] ust, [Out] out long msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                msc = *msc_ptr;
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] out long ust, [Out] long* msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc, (long*)sbc);
                                ust = *ust_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] out long ust, [Out] long* msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc, (long*)sbc_ptr);
                                ust = *ust_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] out long ust, [Out] long* msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc, (long*)sbc_ptr);
                                ust = *ust_ptr;
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] out long ust, [Out] long[] msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = msc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc);
                                ust = *ust_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] out long ust, [Out] long[] msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                ust = *ust_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] out long ust, [Out] long[] msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                ust = *ust_ptr;
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] out long ust, [Out] out long msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = &msc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc);
                                ust = *ust_ptr;
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] out long ust, [Out] out long msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                ust = *ust_ptr;
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool GetSyncValue([Out] IntPtr dpy, IntPtr drawable, [Out] out long ust, [Out] out long msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXGetSyncValuesOML((IntPtr)dpy, (IntPtr)drawable, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                ust = *ust_ptr;
                                msc = *msc_ptr;
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetMscRate([Out] IntPtr dpy, IntPtr drawable, [Out] int* numerator, [Out] int* denominator)
            {
                unsafe { return Delegates.glXGetMscRateOML((IntPtr)dpy, (IntPtr)drawable, (int*)numerator, (int*)denominator); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetMscRate([Out] IntPtr dpy, IntPtr drawable, [Out] int* numerator, [Out] int[] denominator)
            {
                unsafe
                {
                    fixed (int* denominator_ptr = denominator)
                    {
                        bool retval = Delegates.glXGetMscRateOML((IntPtr)dpy, (IntPtr)drawable, (int*)numerator, (int*)denominator_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetMscRate([Out] IntPtr dpy, IntPtr drawable, [Out] int* numerator, [Out] out int denominator)
            {
                unsafe
                {
                    fixed (int* denominator_ptr = &denominator)
                    {
                        bool retval = Delegates.glXGetMscRateOML((IntPtr)dpy, (IntPtr)drawable, (int*)numerator, (int*)denominator_ptr);
                                denominator = *denominator_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetMscRate([Out] IntPtr dpy, IntPtr drawable, [Out] int[] numerator, [Out] int* denominator)
            {
                unsafe
                {
                    fixed (int* numerator_ptr = numerator)
                    {
                        bool retval = Delegates.glXGetMscRateOML((IntPtr)dpy, (IntPtr)drawable, (int*)numerator_ptr, (int*)denominator);
                        return retval;
                    }
                }
            }
            
            public static 
            bool GetMscRate([Out] IntPtr dpy, IntPtr drawable, [Out] int[] numerator, [Out] int[] denominator)
            {
                unsafe
                {
                    fixed (int* numerator_ptr = numerator)
                    fixed (int* denominator_ptr = denominator)
                    {
                        bool retval = Delegates.glXGetMscRateOML((IntPtr)dpy, (IntPtr)drawable, (int*)numerator_ptr, (int*)denominator_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            bool GetMscRate([Out] IntPtr dpy, IntPtr drawable, [Out] int[] numerator, [Out] out int denominator)
            {
                unsafe
                {
                    fixed (int* numerator_ptr = numerator)
                    fixed (int* denominator_ptr = &denominator)
                    {
                        bool retval = Delegates.glXGetMscRateOML((IntPtr)dpy, (IntPtr)drawable, (int*)numerator_ptr, (int*)denominator_ptr);
                                denominator = *denominator_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool GetMscRate([Out] IntPtr dpy, IntPtr drawable, [Out] out int numerator, [Out] int* denominator)
            {
                unsafe
                {
                    fixed (int* numerator_ptr = &numerator)
                    {
                        bool retval = Delegates.glXGetMscRateOML((IntPtr)dpy, (IntPtr)drawable, (int*)numerator_ptr, (int*)denominator);
                                numerator = *numerator_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool GetMscRate([Out] IntPtr dpy, IntPtr drawable, [Out] out int numerator, [Out] int[] denominator)
            {
                unsafe
                {
                    fixed (int* numerator_ptr = &numerator)
                    fixed (int* denominator_ptr = denominator)
                    {
                        bool retval = Delegates.glXGetMscRateOML((IntPtr)dpy, (IntPtr)drawable, (int*)numerator_ptr, (int*)denominator_ptr);
                                numerator = *numerator_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool GetMscRate([Out] IntPtr dpy, IntPtr drawable, [Out] out int numerator, [Out] out int denominator)
            {
                unsafe
                {
                    fixed (int* numerator_ptr = &numerator)
                    fixed (int* denominator_ptr = &denominator)
                    {
                        bool retval = Delegates.glXGetMscRateOML((IntPtr)dpy, (IntPtr)drawable, (int*)numerator_ptr, (int*)denominator_ptr);
                                numerator = *numerator_ptr;
                                denominator = *denominator_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            long SwapBuffersMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder)
            {
                return Delegates.glXSwapBuffersMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder);
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long* ust, [Out] long* msc, [Out] long* sbc)
            {
                unsafe { return Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust, (long*)msc, (long*)sbc); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long* ust, [Out] long* msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust, (long*)msc, (long*)sbc_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long* ust, [Out] long* msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust, (long*)msc, (long*)sbc_ptr);
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long* ust, [Out] long[] msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = msc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust, (long*)msc_ptr, (long*)sbc);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long* ust, [Out] long[] msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust, (long*)msc_ptr, (long*)sbc_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long* ust, [Out] long[] msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust, (long*)msc_ptr, (long*)sbc_ptr);
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long* ust, [Out] out long msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = &msc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust, (long*)msc_ptr, (long*)sbc);
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long* ust, [Out] out long msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust, (long*)msc_ptr, (long*)sbc_ptr);
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long* ust, [Out] out long msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust, (long*)msc_ptr, (long*)sbc_ptr);
                                msc = *msc_ptr;
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long[] ust, [Out] long* msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc, (long*)sbc);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long[] ust, [Out] long* msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc, (long*)sbc_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long[] ust, [Out] long* msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc, (long*)sbc_ptr);
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long[] ust, [Out] long[] msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = msc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc);
                        return retval;
                    }
                }
            }
            
            public static 
            bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long[] ust, [Out] long[] msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long[] ust, [Out] long[] msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long[] ust, [Out] out long msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = &msc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc);
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long[] ust, [Out] out long msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long[] ust, [Out] out long msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                msc = *msc_ptr;
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] out long ust, [Out] long* msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc, (long*)sbc);
                                ust = *ust_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] out long ust, [Out] long* msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc, (long*)sbc_ptr);
                                ust = *ust_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] out long ust, [Out] long* msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc, (long*)sbc_ptr);
                                ust = *ust_ptr;
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] out long ust, [Out] long[] msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = msc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc);
                                ust = *ust_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] out long ust, [Out] long[] msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                ust = *ust_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] out long ust, [Out] long[] msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                ust = *ust_ptr;
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] out long ust, [Out] out long msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = &msc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc);
                                ust = *ust_ptr;
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] out long ust, [Out] out long msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                ust = *ust_ptr;
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool WaitForMsc([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] out long ust, [Out] out long msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForMscOML((IntPtr)dpy, (IntPtr)drawable, (long)target_msc, (long)divisor, (long)remainder, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                ust = *ust_ptr;
                                msc = *msc_ptr;
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long* ust, [Out] long* msc, [Out] long* sbc)
            {
                unsafe { return Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust, (long*)msc, (long*)sbc); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long* ust, [Out] long* msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust, (long*)msc, (long*)sbc_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long* ust, [Out] long* msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust, (long*)msc, (long*)sbc_ptr);
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long* ust, [Out] long[] msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = msc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust, (long*)msc_ptr, (long*)sbc);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long* ust, [Out] long[] msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust, (long*)msc_ptr, (long*)sbc_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long* ust, [Out] long[] msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust, (long*)msc_ptr, (long*)sbc_ptr);
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long* ust, [Out] out long msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = &msc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust, (long*)msc_ptr, (long*)sbc);
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long* ust, [Out] out long msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust, (long*)msc_ptr, (long*)sbc_ptr);
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long* ust, [Out] out long msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust, (long*)msc_ptr, (long*)sbc_ptr);
                                msc = *msc_ptr;
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long[] ust, [Out] long* msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc, (long*)sbc);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long[] ust, [Out] long* msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc, (long*)sbc_ptr);
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long[] ust, [Out] long* msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc, (long*)sbc_ptr);
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long[] ust, [Out] long[] msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = msc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc);
                        return retval;
                    }
                }
            }
            
            public static 
            bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long[] ust, [Out] long[] msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                        return retval;
                    }
                }
            }
            
            public static 
            bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long[] ust, [Out] long[] msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long[] ust, [Out] out long msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = &msc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc);
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long[] ust, [Out] out long msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long[] ust, [Out] out long msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = ust)
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                msc = *msc_ptr;
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] out long ust, [Out] long* msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc, (long*)sbc);
                                ust = *ust_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] out long ust, [Out] long* msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc, (long*)sbc_ptr);
                                ust = *ust_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] out long ust, [Out] long* msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc, (long*)sbc_ptr);
                                ust = *ust_ptr;
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] out long ust, [Out] long[] msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = msc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc);
                                ust = *ust_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] out long ust, [Out] long[] msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                ust = *ust_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] out long ust, [Out] long[] msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                ust = *ust_ptr;
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] out long ust, [Out] out long msc, [Out] long* sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = &msc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc);
                                ust = *ust_ptr;
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] out long ust, [Out] out long msc, [Out] long[] sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                ust = *ust_ptr;
                                msc = *msc_ptr;
                        return retval;
                    }
                }
            }
            
            public static 
            bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] out long ust, [Out] out long msc, [Out] out long sbc)
            {
                unsafe
                {
                    fixed (long* ust_ptr = &ust)
                    fixed (long* msc_ptr = &msc)
                    fixed (long* sbc_ptr = &sbc)
                    {
                        bool retval = Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust_ptr, (long*)msc_ptr, (long*)sbc_ptr);
                                ust = *ust_ptr;
                                msc = *msc_ptr;
                                sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }
            
        }

    }
}
