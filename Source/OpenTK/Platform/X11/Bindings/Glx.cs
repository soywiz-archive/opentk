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
        
        [System.CLSCompliant(false)]
        public static 
        unsafe GLXFBConfig ChooseFBConfig([Out] IntPtr dpy, int screen, int* attrib_list, [Out] int* nelements)
        {
            unsafe { return Delegates.glXChooseFBConfig((IntPtr)dpy, (int)screen, (int*)attrib_list, (int*)nelements); }
        }
        
        [System.CLSCompliant(false)]
        public static 
        unsafe int GetFBConfigAttrib([Out] IntPtr dpy, GLXFBConfig config, int attribute, [Out] int* value)
        {
            unsafe { return Delegates.glXGetFBConfigAttrib((IntPtr)dpy, (GLXFBConfig)config, (int)attribute, (int*)value); }
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
        
        [System.CLSCompliant(false)]
        public static 
        unsafe IntPtr GetProcAddres(Byte* procName)
        {
            unsafe { return Delegates.glXGetProcAddress((Byte*)procName); }
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
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, GLXHyperpipeConfig* cfg, [Out] int* hpId)
            {
                unsafe { return Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfig*)cfg, (int*)hpId); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe GLXHyperpipeConfigPointer QueryHyperpipeConfig([Out] IntPtr dpy, int hpId, [Out] int* npipes)
            {
                unsafe { return Delegates.glXQueryHyperpipeConfigSGIX((IntPtr)dpy, (int)hpId, (int*)npipes); }
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
            unsafe int HyperpipeAttrib([Out] IntPtr dpy, int timeSlice, int attrib, int size, void* attribList)
            {
                unsafe { return Delegates.glXHyperpipeAttribSGIX((IntPtr)dpy, (int)timeSlice, (int)attrib, (int)size, (void*)attribList); }
            }
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int QueryHyperpipeAttrib([Out] IntPtr dpy, int timeSlice, int attrib, int size, [Out] void* returnAttribList)
            {
                unsafe { return Delegates.glXQueryHyperpipeAttribSGIX((IntPtr)dpy, (int)timeSlice, (int)attrib, (int)size, (void*)returnAttribList); }
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
            
            [System.CLSCompliant(false)]
            public static 
            unsafe GLXFBConfigSGIX ChooseFBConfig([Out] IntPtr dpy, int screen, [Out] int* attrib_list, [Out] int* nelements)
            {
                unsafe { return Delegates.glXChooseFBConfigSGIX((IntPtr)dpy, (int)screen, (int*)attrib_list, (int*)nelements); }
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
            
            [System.CLSCompliant(false)]
            public static 
            unsafe GLXPbufferSGIX CreateGLXPbuffer([Out] IntPtr dpy, GLXFBConfigSGIX config, uint width, uint height, [Out] int* attrib_list)
            {
                unsafe { return Delegates.glXCreateGLXPbufferSGIX((IntPtr)dpy, (GLXFBConfigSGIX)config, (uint)width, (uint)height, (int*)attrib_list); }
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
            unsafe int QueryChannelDelta([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int* y, [Out] int* w, [Out] int* h)
            {
                unsafe { return Delegates.glXQueryChannelDeltasSGIX((IntPtr)display, (int)screen, (int)channel, (int*)x, (int*)y, (int*)w, (int*)h); }
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
            
            [System.CLSCompliant(false)]
            public static 
            unsafe int HyperpipeConfig([Out] IntPtr dpy, int networkId, int npipes, [Out] GLXHyperpipeConfigSGIX* cfg, [Out] int* hpId)
            {
                unsafe { return Delegates.glXHyperpipeConfigSGIX((IntPtr)dpy, (int)networkId, (int)npipes, (GLXHyperpipeConfigSGIX*)cfg, (int*)hpId); }
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
            
        }

        public static class SUN
        {
            [System.CLSCompliant(false)]
            public static 
            unsafe Status GetTransparentIndex([Out] IntPtr dpy, IntPtr overlay, IntPtr underlay, [Out] long* pTransparentIndex)
            {
                unsafe { return Delegates.glXGetTransparentIndexSUN((IntPtr)dpy, (IntPtr)overlay, (IntPtr)underlay, (long*)pTransparentIndex); }
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
            unsafe bool GetMscRate([Out] IntPtr dpy, IntPtr drawable, [Out] int* numerator, [Out] int* denominator)
            {
                unsafe { return Delegates.glXGetMscRateOML((IntPtr)dpy, (IntPtr)drawable, (int*)numerator, (int*)denominator); }
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
            unsafe bool WaitForSbc([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long* ust, [Out] long* msc, [Out] long* sbc)
            {
                unsafe { return Delegates.glXWaitForSbcOML((IntPtr)dpy, (IntPtr)drawable, (long)target_sbc, (long*)ust, (long*)msc, (long*)sbc); }
            }
            
        }

    }
}
