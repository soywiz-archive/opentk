namespace OpenTK.Platform.X11
{
    using System;
    using System.Runtime.InteropServices;

    partial class Glx
    {

        internal static class Delegates
        {
            static Delegates()
            {
            }

            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Render();
            internal static Render glXRender = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderLarge();
            internal static RenderLarge glXRenderLarge = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CreateContext(Int32 gc_id, Int32 screen, Int32 visual, Int32 share_list);
            internal static CreateContext glXCreateContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DestroyContext(Int32 context);
            internal static DestroyContext glXDestroyContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MakeCurrent(Int32 drawable, Int32 context);
            internal static MakeCurrent glXMakeCurrent = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void IsDirect(Int32 dpy, Int32 context);
            internal static IsDirect glXIsDirect = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void QueryVersion([Out] Int32* major, [Out] Int32* minor);
            internal unsafe static QueryVersion glXQueryVersion = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WaitGL(Int32 context);
            internal static WaitGL glXWaitGL = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void WaitX();
            internal static WaitX glXWaitX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyContext(Int32 source, Int32 dest, Int32 mask);
            internal static CopyContext glXCopyContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SwapBuffers(Int32 drawable);
            internal static SwapBuffers glXSwapBuffers = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseXFont(Int32 font, Int32 first, Int32 count, Int32 list_base);
            internal static UseXFont glXUseXFont = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CreateGLXPixmap(Int32 visual, Int32 pixmap, Int32 glxpixmap);
            internal static CreateGLXPixmap glXCreateGLXPixmap = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVisualConfigs();
            internal static GetVisualConfigs glXGetVisualConfigs = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DestroyGLXPixmap(Int32 pixmap);
            internal static DestroyGLXPixmap glXDestroyGLXPixmap = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VendorPrivate();
            internal static VendorPrivate glXVendorPrivate = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VendorPrivateWithReply();
            internal static VendorPrivateWithReply glXVendorPrivateWithReply = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QueryExtensionsString(Int32 screen);
            internal static QueryExtensionsString glXQueryExtensionsString = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QueryServerString(Int32 screen, Int32 name);
            internal static QueryServerString glXQueryServerString = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientInfo();
            internal static ClientInfo glXClientInfo = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetFBConfigs();
            internal static GetFBConfigs glXGetFBConfigs = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CreatePixmap(Int32 config, Int32 pixmap, Int32 glxpixmap);
            internal static CreatePixmap glXCreatePixmap = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DestroyPixmap(Int32 glxpixmap);
            internal static DestroyPixmap glXDestroyPixmap = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CreateNewContext(Int32 config, Int32 render_type, Int32 share_list, Int32 direct);
            internal static CreateNewContext glXCreateNewContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QueryContext();
            internal static QueryContext glXQueryContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MakeContextCurrent(Int32 drawable, Int32 readdrawable, Int32 context);
            internal static MakeContextCurrent glXMakeContextCurrent = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CreatePbuffer(Int32 config, Int32 pbuffer);
            internal static CreatePbuffer glXCreatePbuffer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DestroyPbuffer(Int32 pbuffer);
            internal static DestroyPbuffer glXDestroyPbuffer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetDrawableAttributes(Int32 drawable);
            internal static GetDrawableAttributes glXGetDrawableAttributes = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ChangeDrawableAttributes(Int32 drawable);
            internal static ChangeDrawableAttributes glXChangeDrawableAttributes = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CreateWindow(Int32 config, Int32 window, Int32 glxwindow);
            internal static CreateWindow glXCreateWindow = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DestroyWindow(Int32 glxwindow);
            internal static DestroyWindow glXDestroyWindow = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SwapIntervalSGI();
            internal static SwapIntervalSGI glXSwapIntervalSGI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void MakeCurrentReadSGI(Int32 drawable, Int32 readdrawable, Int32 context);
            internal static MakeCurrentReadSGI glXMakeCurrentReadSGI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CreateGLXVideoSourceSGIX(Int32 dpy, Int32 screen, Int32 server, Int32 path, Int32 @class, Int32 node);
            internal static CreateGLXVideoSourceSGIX glXCreateGLXVideoSourceSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DestroyGLXVideoSourceSGIX(Int32 dpy, Int32 glxvideosource);
            internal static DestroyGLXVideoSourceSGIX glXDestroyGLXVideoSourceSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QueryContextInfoEXT();
            internal static QueryContextInfoEXT glXQueryContextInfoEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetFBConfigsSGIX();
            internal static GetFBConfigsSGIX glXGetFBConfigsSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CreateContextWithConfigSGIX(Int32 gc_id, Int32 screen, Int32 config, Int32 share_list);
            internal static CreateContextWithConfigSGIX glXCreateContextWithConfigSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CreateGLXPixmapWithConfigSGIX(Int32 config, Int32 pixmap, Int32 glxpixmap);
            internal static CreateGLXPixmapWithConfigSGIX glXCreateGLXPixmapWithConfigSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CreateGLXPbufferSGIX(Int32 config, Int32 pbuffer);
            internal static CreateGLXPbufferSGIX glXCreateGLXPbufferSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DestroyGLXPbufferSGIX(Int32 pbuffer);
            internal static DestroyGLXPbufferSGIX glXDestroyGLXPbufferSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ChangeDrawableAttributesSGIX(Int32 drawable);
            internal static ChangeDrawableAttributesSGIX glXChangeDrawableAttributesSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetDrawableAttributesSGIX(Int32 drawable);
            internal static GetDrawableAttributesSGIX glXGetDrawableAttributesSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void JoinSwapGroupSGIX(Int32 window, Int32 group);
            internal static JoinSwapGroupSGIX glXJoinSwapGroupSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindSwapBarrierSGIX(Int32 window, Int32 barrier);
            internal static BindSwapBarrierSGIX glXBindSwapBarrierSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QueryMaxSwapBarriersSGIX();
            internal static QueryMaxSwapBarriersSGIX glXQueryMaxSwapBarriersSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate GLXHyperpipeNetworkPointer QueryHyperpipeNetworkSGIX([Out] IntPtr dpy, [Out] int* npipes);
            internal unsafe static QueryHyperpipeNetworkSGIX glXQueryHyperpipeNetworkSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int HyperpipeConfigSGIX([Out] IntPtr dpy, int networkId, int npipes, GLXHyperpipeConfig* cfg, [Out] int* hpId);
            internal unsafe static HyperpipeConfigSGIX glXHyperpipeConfigSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate GLXHyperpipeConfigPointer QueryHyperpipeConfigSGIX([Out] IntPtr dpy, int hpId, [Out] int* npipes);
            internal unsafe static QueryHyperpipeConfigSGIX glXQueryHyperpipeConfigSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int DestroyHyperpipeConfigSGIX([Out] IntPtr dpy, int hpId);
            internal static DestroyHyperpipeConfigSGIX glXDestroyHyperpipeConfigSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int BindHyperpipeSGIX([Out] IntPtr dpy, int hpId);
            internal static BindHyperpipeSGIX glXBindHyperpipeSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int QueryHyperpipeBestAttribSGIX([Out] IntPtr dpy, int timeSlice, int attrib, int size, void* attribList, [Out] void* returnAttribList);
            internal unsafe static QueryHyperpipeBestAttribSGIX glXQueryHyperpipeBestAttribSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int HyperpipeAttribSGIX([Out] IntPtr dpy, int timeSlice, int attrib, int size, void* attribList);
            internal unsafe static HyperpipeAttribSGIX glXHyperpipeAttribSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int QueryHyperpipeAttribSGIX([Out] IntPtr dpy, int timeSlice, int attrib, int size, [Out] void* returnAttribList);
            internal unsafe static QueryHyperpipeAttribSGIX glXQueryHyperpipeAttribSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate GLXFBConfig ChooseFBConfig([Out] IntPtr dpy, int screen, int* attrib_list, [Out] int* nelements);
            internal unsafe static ChooseFBConfig glXChooseFBConfig = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int GetFBConfigAttrib([Out] IntPtr dpy, GLXFBConfig config, int attribute, [Out] int* value);
            internal unsafe static GetFBConfigAttrib glXGetFBConfigAttrib = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate XVisualInfo GetVisualFromFBConfig([Out] IntPtr dpy, GLXFBConfig config);
            internal static GetVisualFromFBConfig glXGetVisualFromFBConfig = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void QueryDrawable([Out] IntPtr dpy, IntPtr draw, int attribute, [Out] uint* value);
            internal unsafe static QueryDrawable glXQueryDrawable = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentReadDrawable();
            internal static GetCurrentReadDrawable glXGetCurrentReadDrawable = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentDisplay();
            internal static GetCurrentDisplay glXGetCurrentDisplay = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SelectEvent([Out] IntPtr dpy, IntPtr draw, ulong event_mask);
            internal static SelectEvent glXSelectEvent = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSelectedEvent([Out] IntPtr dpy, IntPtr draw, [Out] ulong* event_mask);
            internal unsafe static GetSelectedEvent glXGetSelectedEvent = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr GetProcAddress(Byte* procName);
            internal unsafe static GetProcAddress glXGetProcAddress = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr GetProcAddressARB(Byte* procName);
            internal unsafe static GetProcAddressARB glXGetProcAddressARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int GetVideoSyncSGI([Out] uint* count);
            internal unsafe static GetVideoSyncSGI glXGetVideoSyncSGI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int WaitVideoSyncSGI(int divisor, int remainder, [Out] uint* count);
            internal unsafe static WaitVideoSyncSGI glXWaitVideoSyncSGI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentReadDrawableSGI();
            internal static GetCurrentReadDrawableSGI glXGetCurrentReadDrawableSGI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentDisplayEXT();
            internal static GetCurrentDisplayEXT glXGetCurrentDisplayEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate GLXContextID GetContextIDEXT(IntPtr context);
            internal static GetContextIDEXT glXGetContextIDEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr ImportContextEXT([Out] IntPtr dpy, GLXContextID contextID);
            internal static ImportContextEXT glXImportContextEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FreeContextEXT([Out] IntPtr dpy, IntPtr context);
            internal static FreeContextEXT glXFreeContextEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int GetFBConfigAttribSGIX([Out] IntPtr dpy, GLXFBConfigSGIX config, int attribute, [Out] int* value);
            internal unsafe static GetFBConfigAttribSGIX glXGetFBConfigAttribSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate GLXFBConfigSGIX ChooseFBConfigSGIX([Out] IntPtr dpy, int screen, [Out] int* attrib_list, [Out] int* nelements);
            internal unsafe static ChooseFBConfigSGIX glXChooseFBConfigSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate XVisualInfo GetVisualFromFBConfigSGIX([Out] IntPtr dpy, GLXFBConfigSGIX config);
            internal static GetVisualFromFBConfigSGIX glXGetVisualFromFBConfigSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate GLXFBConfigSGIX GetFBConfigFromVisualSGIX([Out] IntPtr dpy, [Out] XVisualInfo* vis);
            internal unsafe static GetFBConfigFromVisualSGIX glXGetFBConfigFromVisualSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int QueryGLXPbufferSGIX([Out] IntPtr dpy, GLXPbufferSGIX pbuf, int attribute, [Out] uint* value);
            internal unsafe static QueryGLXPbufferSGIX glXQueryGLXPbufferSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SelectEventSGIX([Out] IntPtr dpy, IntPtr drawable, ulong mask);
            internal static SelectEventSGIX glXSelectEventSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSelectedEventSGIX([Out] IntPtr dpy, IntPtr drawable, [Out] ulong* mask);
            internal unsafe static GetSelectedEventSGIX glXGetSelectedEventSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CushionSGI([Out] IntPtr dpy, IntPtr window, float cushion);
            internal static CushionSGI glXCushionSGI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int BindChannelToWindowSGIX([Out] IntPtr display, int screen, int channel, IntPtr window);
            internal static BindChannelToWindowSGIX glXBindChannelToWindowSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int ChannelRectSGIX([Out] IntPtr display, int screen, int channel, int x, int y, int w, int h);
            internal static ChannelRectSGIX glXChannelRectSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int QueryChannelRectSGIX([Out] IntPtr display, int screen, int channel, [Out] int* dx, [Out] int* dy, [Out] int* dw, [Out] int* dh);
            internal unsafe static QueryChannelRectSGIX glXQueryChannelRectSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int QueryChannelDeltasSGIX([Out] IntPtr display, int screen, int channel, [Out] int* x, [Out] int* y, [Out] int* w, [Out] int* h);
            internal unsafe static QueryChannelDeltasSGIX glXQueryChannelDeltasSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int ChannelRectSyncSGIX([Out] IntPtr display, int screen, int channel, Glx.Enums.SGIX_video_resize synctype);
            internal static ChannelRectSyncSGIX glXChannelRectSyncSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate bool AssociateDMPbufferSGIX([Out] IntPtr dpy, GLXPbufferSGIX pbuffer, [Out] DMparams* @params, DMbuffer dmbuffer);
            internal unsafe static AssociateDMPbufferSGIX glXAssociateDMPbufferSGIX = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Status GetTransparentIndexSUN([Out] IntPtr dpy, IntPtr overlay, IntPtr underlay, [Out] long* pTransparentIndex);
            internal unsafe static GetTransparentIndexSUN glXGetTransparentIndexSUN = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopySubBufferMESA([Out] IntPtr dpy, IntPtr drawable, int x, int y, int width, int height);
            internal static CopySubBufferMESA glXCopySubBufferMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr CreateGLXPixmapMESA([Out] IntPtr dpy, [Out] XVisualInfo* visual, IntPtr pixmap, IntPtr cmap);
            internal unsafe static CreateGLXPixmapMESA glXCreateGLXPixmapMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool ReleaseBuffersMESA([Out] IntPtr dpy, IntPtr drawable);
            internal static ReleaseBuffersMESA glXReleaseBuffersMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool Set3DfxModeMESA(int mode);
            internal static Set3DfxModeMESA glXSet3DfxModeMESA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate bool GetSyncValuesOML([Out] IntPtr dpy, IntPtr drawable, [Out] long* ust, [Out] long* msc, [Out] long* sbc);
            internal unsafe static GetSyncValuesOML glXGetSyncValuesOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate bool GetMscRateOML([Out] IntPtr dpy, IntPtr drawable, [Out] int* numerator, [Out] int* denominator);
            internal unsafe static GetMscRateOML glXGetMscRateOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate long SwapBuffersMscOML([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder);
            internal static SwapBuffersMscOML glXSwapBuffersMscOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate bool WaitForMscOML([Out] IntPtr dpy, IntPtr drawable, long target_msc, long divisor, long remainder, [Out] long* ust, [Out] long* msc, [Out] long* sbc);
            internal unsafe static WaitForMscOML glXWaitForMscOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate bool WaitForSbcOML([Out] IntPtr dpy, IntPtr drawable, long target_sbc, [Out] long* ust, [Out] long* msc, [Out] long* sbc);
            internal unsafe static WaitForSbcOML glXWaitForSbcOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate uint GetAGPOffsetMESA(void* pointer);
            internal unsafe static GetAGPOffsetMESA glXGetAGPOffsetMESA = null;
        }
    }
}
