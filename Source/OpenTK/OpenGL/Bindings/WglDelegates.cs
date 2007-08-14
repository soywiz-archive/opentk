namespace OpenTK.OpenGL
{
    using System;
    using System.Runtime.InteropServices;

    partial class Wgl
    {

        internal static class Delegates
        {
            static Delegates()
            {
                Wgl.LoadAll();
            }

            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr CreateContext(IntPtr hDc);
            internal static CreateContext glCreateContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DeleteContext(IntPtr oldContext);
            internal static DeleteContext glDeleteContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentContext();
            internal static GetCurrentContext glGetCurrentContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean MakeCurrent(IntPtr hDc, IntPtr newContext);
            internal static MakeCurrent glMakeCurrent = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean CopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, UInt32 mask);
            internal static CopyContext glCopyContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int ChoosePixelFormat(IntPtr hDc, OpenTK.Platform.Windows.API.PixelFormatDescriptor pPfd);
            internal static ChoosePixelFormat glChoosePixelFormat = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int DescribePixelFormat(IntPtr hdc, int ipfd, UInt32 cjpfd, OpenTK.Platform.Windows.API.PixelFormatDescriptor ppfd);
            internal static DescribePixelFormat glDescribePixelFormat = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentDC();
            internal static GetCurrentDC glGetCurrentDC = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetDefaultProcAddress(String lpszProc);
            internal static GetDefaultProcAddress glGetDefaultProcAddress = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetProcAddress(String lpszProc);
            internal static GetProcAddress glGetProcAddress = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int GetPixelFormat(IntPtr hdc);
            internal static GetPixelFormat glGetPixelFormat = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SetPixelFormat(IntPtr hdc, int ipfd, OpenTK.Platform.Windows.API.PixelFormatDescriptor ppfd);
            internal static SetPixelFormat glSetPixelFormat = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SwapBuffers(IntPtr hdc);
            internal static SwapBuffers glSwapBuffers = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);
            internal static ShareLists glShareLists = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr CreateLayerContext(IntPtr hDc, int level);
            internal static CreateLayerContext glCreateLayerContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, UInt32 nBytes, OpenTK.Platform.Windows.API.LayerPlaneDescriptor plpd);
            internal static DescribeLayerPlane glDescribeLayerPlane = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32 pcr);
            internal static SetLayerPaletteEntries glSetLayerPaletteEntries = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32 pcr);
            internal static GetLayerPaletteEntries glGetLayerPaletteEntries = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean RealizeLayerPalette(IntPtr hdc, int iLayerPlane, Boolean bRealize);
            internal static RealizeLayerPalette glRealizeLayerPalette = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SwapLayerBuffers(IntPtr hdc, UInt32 fuFlags);
            internal static SwapLayerBuffers glSwapLayerBuffers = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean UseFontBitmapsA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);
            internal static UseFontBitmapsA glUseFontBitmapsA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean UseFontBitmapsW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);
            internal static UseFontBitmapsW glUseFontBitmapsW = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr CreateBufferRegionARB(IntPtr hDC, int iLayerPlane, UInt32 uType);
            internal static CreateBufferRegionARB glCreateBufferRegionARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteBufferRegionARB(IntPtr hRegion);
            internal static DeleteBufferRegionARB glDeleteBufferRegionARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SaveBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height);
            internal static SaveBufferRegionARB glSaveBufferRegionARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean RestoreBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc);
            internal static RestoreBufferRegionARB glRestoreBufferRegionARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetExtensionsStringARB(IntPtr hdc);
            internal static GetExtensionsStringARB glGetExtensionsStringARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] int* piValues);
            internal unsafe static GetPixelFormatAttribivARB glGetPixelFormatAttribivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] Single* pfValues);
            internal unsafe static GetPixelFormatAttribfvARB glGetPixelFormatAttribfvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean ChoosePixelFormatARB(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats);
            internal unsafe static ChoosePixelFormatARB glChoosePixelFormatARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean MakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);
            internal static MakeContextCurrentARB glMakeContextCurrentARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentReadDCARB();
            internal static GetCurrentReadDCARB glGetCurrentReadDCARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr CreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);
            internal unsafe static CreatePbufferARB glCreatePbufferARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetPbufferDCARB(IntPtr hPbuffer);
            internal static GetPbufferDCARB glGetPbufferDCARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int ReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC);
            internal static ReleasePbufferDCARB glReleasePbufferDCARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DestroyPbufferARB(IntPtr hPbuffer);
            internal static DestroyPbufferARB glDestroyPbufferARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean QueryPbufferARB(IntPtr hPbuffer, int iAttribute, [Out] int piValue);
            internal static QueryPbufferARB glQueryPbufferARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean BindTexImageARB(IntPtr hPbuffer, int iBuffer);
            internal static BindTexImageARB glBindTexImageARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean ReleaseTexImageARB(IntPtr hPbuffer, int iBuffer);
            internal static ReleaseTexImageARB glReleaseTexImageARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetPbufferAttribARB(IntPtr hPbuffer, int* piAttribList);
            internal unsafe static SetPbufferAttribARB glSetPbufferAttribARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean CreateDisplayColorTableEXT(UInt16 id);
            internal static CreateDisplayColorTableEXT glCreateDisplayColorTableEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean LoadDisplayColorTableEXT(UInt16* table, UInt32 length);
            internal unsafe static LoadDisplayColorTableEXT glLoadDisplayColorTableEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean BindDisplayColorTableEXT(UInt16 id);
            internal static BindDisplayColorTableEXT glBindDisplayColorTableEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DestroyDisplayColorTableEXT(UInt16 id);
            internal static DestroyDisplayColorTableEXT glDestroyDisplayColorTableEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetExtensionsStringEXT();
            internal static GetExtensionsStringEXT glGetExtensionsStringEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean MakeContextCurrentEXT(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);
            internal static MakeContextCurrentEXT glMakeContextCurrentEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentReadDCEXT();
            internal static GetCurrentReadDCEXT glGetCurrentReadDCEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr CreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);
            internal unsafe static CreatePbufferEXT glCreatePbufferEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetPbufferDCEXT(IntPtr hPbuffer);
            internal static GetPbufferDCEXT glGetPbufferDCEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int ReleasePbufferDCEXT(IntPtr hPbuffer, IntPtr hDC);
            internal static ReleasePbufferDCEXT glReleasePbufferDCEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DestroyPbufferEXT(IntPtr hPbuffer);
            internal static DestroyPbufferEXT glDestroyPbufferEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean QueryPbufferEXT(IntPtr hPbuffer, int iAttribute, [Out] int piValue);
            internal static QueryPbufferEXT glQueryPbufferEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [Out] int* piValues);
            internal unsafe static GetPixelFormatAttribivEXT glGetPixelFormatAttribivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [Out] Single* pfValues);
            internal unsafe static GetPixelFormatAttribfvEXT glGetPixelFormatAttribfvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean ChoosePixelFormatEXT(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats);
            internal unsafe static ChoosePixelFormatEXT glChoosePixelFormatEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SwapIntervalEXT(int interval);
            internal static SwapIntervalEXT glSwapIntervalEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int GetSwapIntervalEXT();
            internal static GetSwapIntervalEXT glGetSwapIntervalEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr AllocateMemoryNV(Int32 size, Single readfreq, Single writefreq, Single priority);
            internal static AllocateMemoryNV glAllocateMemoryNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FreeMemoryNV([Out] void* pointer);
            internal unsafe static FreeMemoryNV glFreeMemoryNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetSyncValuesOML(IntPtr hdc, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc);
            internal unsafe static GetSyncValuesOML glGetSyncValuesOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetMscRateOML(IntPtr hdc, [Out] Int32* numerator, [Out] Int32* denominator);
            internal unsafe static GetMscRateOML glGetMscRateOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int64 SwapBuffersMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder);
            internal static SwapBuffersMscOML glSwapBuffersMscOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int64 SwapLayerBuffersMscOML(IntPtr hdc, int fuPlanes, Int64 target_msc, Int64 divisor, Int64 remainder);
            internal static SwapLayerBuffersMscOML glSwapLayerBuffersMscOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean WaitForMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc);
            internal unsafe static WaitForMscOML glWaitForMscOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean WaitForSbcOML(IntPtr hdc, Int64 target_sbc, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc);
            internal unsafe static WaitForSbcOML glWaitForSbcOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, [Out] int* piValue);
            internal unsafe static GetDigitalVideoParametersI3D glGetDigitalVideoParametersI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
            internal unsafe static SetDigitalVideoParametersI3D glSetDigitalVideoParametersI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetGammaTableParametersI3D(IntPtr hDC, int iAttribute, [Out] int* piValue);
            internal unsafe static GetGammaTableParametersI3D glGetGammaTableParametersI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
            internal unsafe static SetGammaTableParametersI3D glSetGammaTableParametersI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetGammaTableI3D(IntPtr hDC, int iEntries, [Out] UInt16* puRed, [Out] UInt16* puGreen, [Out] UInt16* puBlue);
            internal unsafe static GetGammaTableI3D glGetGammaTableI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetGammaTableI3D(IntPtr hDC, int iEntries, UInt16* puRed, UInt16* puGreen, UInt16* puBlue);
            internal unsafe static SetGammaTableI3D glSetGammaTableI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean EnableGenlockI3D(IntPtr hDC);
            internal static EnableGenlockI3D glEnableGenlockI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DisableGenlockI3D(IntPtr hDC);
            internal static DisableGenlockI3D glDisableGenlockI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsEnabledGenlockI3D(IntPtr hDC, [Out] Boolean pFlag);
            internal static IsEnabledGenlockI3D glIsEnabledGenlockI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GenlockSourceI3D(IntPtr hDC, UInt32 uSource);
            internal static GenlockSourceI3D glGenlockSourceI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GetGenlockSourceI3D(IntPtr hDC, [Out] UInt32 uSource);
            internal static GetGenlockSourceI3D glGetGenlockSourceI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GenlockSourceEdgeI3D(IntPtr hDC, UInt32 uEdge);
            internal static GenlockSourceEdgeI3D glGenlockSourceEdgeI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GetGenlockSourceEdgeI3D(IntPtr hDC, [Out] UInt32 uEdge);
            internal static GetGenlockSourceEdgeI3D glGetGenlockSourceEdgeI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GenlockSampleRateI3D(IntPtr hDC, UInt32 uRate);
            internal static GenlockSampleRateI3D glGenlockSampleRateI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GetGenlockSampleRateI3D(IntPtr hDC, [Out] UInt32 uRate);
            internal static GetGenlockSampleRateI3D glGetGenlockSampleRateI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GenlockSourceDelayI3D(IntPtr hDC, UInt32 uDelay);
            internal static GenlockSourceDelayI3D glGenlockSourceDelayI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GetGenlockSourceDelayI3D(IntPtr hDC, [Out] UInt32 uDelay);
            internal static GetGenlockSourceDelayI3D glGetGenlockSourceDelayI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean QueryGenlockMaxSourceDelayI3D(IntPtr hDC, [Out] UInt32 uMaxLineDelay, [Out] UInt32 uMaxPixelDelay);
            internal static QueryGenlockMaxSourceDelayI3D glQueryGenlockMaxSourceDelayI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr CreateImageBufferI3D(IntPtr hDC, Int32 dwSize, UInt32 uFlags);
            internal static CreateImageBufferI3D glCreateImageBufferI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean DestroyImageBufferI3D(IntPtr hDC, void* pAddress);
            internal unsafe static DestroyImageBufferI3D glDestroyImageBufferI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean AssociateImageBufferEventsI3D(IntPtr hDC, IntPtr* pEvent, void* pAddress, Int32* pSize, UInt32 count);
            internal unsafe static AssociateImageBufferEventsI3D glAssociateImageBufferEventsI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean ReleaseImageBufferEventsI3D(IntPtr hDC, void* pAddress, UInt32 count);
            internal unsafe static ReleaseImageBufferEventsI3D glReleaseImageBufferEventsI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean EnableFrameLockI3D();
            internal static EnableFrameLockI3D glEnableFrameLockI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DisableFrameLockI3D();
            internal static DisableFrameLockI3D glDisableFrameLockI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsEnabledFrameLockI3D([Out] Boolean pFlag);
            internal static IsEnabledFrameLockI3D glIsEnabledFrameLockI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean QueryFrameLockMasterI3D([Out] Boolean pFlag);
            internal static QueryFrameLockMasterI3D glQueryFrameLockMasterI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GetFrameUsageI3D([Out] float pUsage);
            internal static GetFrameUsageI3D glGetFrameUsageI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean BeginFrameTrackingI3D();
            internal static BeginFrameTrackingI3D glBeginFrameTrackingI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean EndFrameTrackingI3D();
            internal static EndFrameTrackingI3D glEndFrameTrackingI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean QueryFrameTrackingI3D([Out] Int32 pFrameCount, [Out] Int32 pMissedFrames, [Out] float pLastMissedUsage);
            internal static QueryFrameTrackingI3D glQueryFrameTrackingI3D = null;
        }
    }
}
