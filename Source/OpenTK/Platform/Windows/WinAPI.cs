#region --- License ---
/* Copyright (c) 2006, 2007 Stephen Apostolopoulos
 * Contributions from Erik Ylvisaker
 * See license.txt for license info
 */
#endregion

#region --- Using Directives ---

using System;
using System.Runtime.InteropServices;
using System.Text;

#endregion

/* TODO: Update the description of TimeBeginPeriod and other native methods. Update Timer. */

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// For internal use by OpenTK only!
    /// Exposes useful native WINAPI methods and structures.
    /// </summary>
    internal static class WinApi
    {
        #region Constants

        internal struct Constants
        {
            // WM_ACTIVATE state values (found in winuser.h)
            internal const int WA_INACTIVE    = 0;
            internal const int WA_ACTIVE      = 1;
            internal const int WA_CLICKACTIVE = 2;

            // Window Messages (found in winuser.h)
            internal const int WM_NULL                        = 0x0000;
            internal const int WM_CREATE                      = 0x0001;
            internal const int WM_DESTROY                     = 0x0002;
            internal const int WM_MOVE                        = 0x0003;
            internal const int WM_SIZE                        = 0x0005;
            internal const int WM_ACTIVATE                    = 0x0006;
            internal const int WM_SETFOCUS                    = 0x0007;
            internal const int WM_KILLFOCUS                   = 0x0008;
            internal const int WM_ENABLE                      = 0x000A;
            internal const int WM_SETREDRAW                   = 0x000B;
            internal const int WM_SETTEXT                     = 0x000C;
            internal const int WM_GETTEXT                     = 0x000D;
            internal const int WM_GETTEXTLENGTH               = 0x000E;
            internal const int WM_PAINT                       = 0x000F;
            internal const int WM_CLOSE                       = 0x0010;
            // _WIN32_WCE
            internal const int WM_QUERYENDSESSION             = 0x0011;
            internal const int WM_QUERYOPEN                   = 0x0013;
            internal const int WM_ENDSESSION                  = 0x0016;
            internal const int WM_QUIT                        = 0x0012;
            internal const int WM_ERASEBKGND                  = 0x0014;
            internal const int WM_SYSCOLORCHANGE              = 0x0015;
            internal const int WM_SHOWWINDOW                  = 0x0018;
            internal const int WM_WININICHANGE                = 0x001A;
            // WINVER >= 0x400
            internal const int WM_SETTINGCHANGE               = WM_WININICHANGE;

            internal const int WM_DEVMODECHANGE               = 0x001B;
            internal const int WM_ACTIVATEAPP                 = 0x001C;
            internal const int WM_FONTCHANGE                  = 0x001D;
            internal const int WM_TIMECHANGE                  = 0x001E;
            internal const int WM_CANCELMODE                  = 0x001F;
            internal const int WM_SETCURSOR                   = 0x0020;
            internal const int WM_MOUSEACTIVATE               = 0x0021;
            internal const int WM_CHILDACTIVATE               = 0x0022;
            internal const int WM_QUEUESYNC                   = 0x0023;

            internal const int WM_GETMINMAXINFO               = 0x0024;

            // Keyboard events (found in winuser.h)
            internal const int WM_KEYDOWN = 0x0100;
            internal const int WM_KEYUP = 0x101;
            internal const int WM_SYSKEYDOWN = 0x0104;
            internal const int WM_SYSKEYUP = 0x0105;
            internal const int WM_COMMAND = 0x0111;
            internal const int WM_SYSCOMMAND = 0x0112;
            internal const int WM_ENTERIDLE = 0x121;

            // Pixel types (found in wingdi.h)
            internal const byte PFD_TYPE_RGBA = 0;
            internal const byte PFD_TYPE_COLORINDEX = 1;

            // Layer types (found in wingdi.h)
            internal const byte PFD_MAIN_PLANE = 0;
            internal const byte PFD_OVERLAY_PLANE = 1;
            internal const byte PFD_UNDERLAY_PLANE = unchecked((byte)-1);

            // Device mode types (found in wingdi.h)
            internal const int DM_BITSPERPEL = 0x00040000;
            internal const int DM_PELSWIDTH = 0x00080000;
            internal const int DM_PELSHEIGHT = 0x00100000;
            internal const int DM_DISPLAYFLAGS = 0x00200000;
            internal const int DM_DISPLAYFREQUENCY = 0x00400000;

            // ChangeDisplaySettings types (found in winuser.h)
            internal const int CDS_UPDATEREGISTRY = 0x00000001;
            internal const int CDS_TEST = 0x00000002;
            internal const int CDS_FULLSCREEN = 0x00000004;

            // ChangeDisplaySettings results (found in winuser.h)
            internal const int DISP_CHANGE_SUCCESSFUL = 0;
            internal const int DISP_CHANGE_RESTART = 1;
            internal const int DISP_CHANGE_FAILED = -1;

            // (found in winuser.h)
            internal const int ENUM_REGISTRY_SETTINGS = -2;
            internal const int ENUM_CURRENT_SETTINGS = -1;
        }

        #endregion

        #region WINAPI methods

        #region PeekMessage

        [StructLayout(LayoutKind.Sequential)]
        internal struct Message
        {
            internal IntPtr hWnd;
            internal int msg;
            internal IntPtr wParam;
            internal IntPtr lParam;
            internal int time;
            internal System.Drawing.Point p;
            //System.Drawing.
        }

        /// <summary>
        /// Low-level WINAPI function that checks the next message in the queue.
        /// </summary>
        /// <param name="msg">The pending message (if any) is stored here.</param>
        /// <param name="hWnd">Not used</param>
        /// <param name="messageFilterMin">Not used</param>
        /// <param name="messageFilterMax">Not used</param>
        /// <param name="flags">Not used</param>
        /// <returns>True if there is a message pending.</returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool PeekMessage(
            out Message msg,
            IntPtr hWnd,
            int messageFilterMin,
            int messageFilterMax,
            int flags
        );

        /// <summary>
        /// Low-level WINAPI function that checks the next message in the queue.
        /// </summary>
        /// <param name="msg">The pending message (if any) is stored here.</param>
        /// <param name="hWnd">Not used</param>
        /// <param name="messageFilterMin">Not used</param>
        /// <param name="messageFilterMax">Not used</param>
        /// <param name="flags">Not used</param>
        /// <returns>True if there is a message pending.</returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool PeekMessage(
            out System.Windows.Forms.Message msg,
            IntPtr hWnd,
            int messageFilterMin,
            int messageFilterMax,
            int flags
        );

        #endregion

        #region GetMessage

        /// <summary>
        /// Low-level WINAPI function that retriives the next message in the queue.
        /// </summary>
        /// <param name="msg">The pending message (if any) is stored here.</param>
        /// <param name="hWnd">Not used</param>
        /// <param name="messageFilterMin">Not used</param>
        /// <param name="messageFilterMax">Not used</param>
        /// <param name="flags">Not used</param>
        /// <returns>
        /// Nonzero indicates that the function retrieves a message other than WM_QUIT.
        /// Zero indicates that the function retrieves the WM_QUIT message, or that lpMsg is an invalid pointer.
        /// �1 indicates that an error occurred � for example, the function fails if hWnd is an invalid window handle.
        /// To get extended error information, call GetLastError.
        /// </returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetMessage(
            out System.Windows.Forms.Message msg,
            IntPtr windowHandle,
            int messageFilterMin,
            int messageFilterMax
        );

        #endregion

        #region PostQuitMessage

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        internal static extern void PostQuitMessage(int exitCode);

        #endregion

        #region TimeBeginPeriod

        /// <summary>
        /// Sets the timing resolution of the GetTime (?) method.
        /// </summary>
        /// <param name="period">Timing resolution in msec (?)</param>
        /// <returns>(?)</returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("winmm.dll")]
        internal static extern IntPtr TimeBeginPeriod(int period);

        #endregion

        #region QueryPerformanceFrequency

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PerformanceFrequency"></param>
        /// <returns></returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool QueryPerformanceFrequency(ref long PerformanceFrequency);

        #endregion

        #region QueryPerformanceCounter

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PerformanceCount"></param>
        /// <returns></returns>
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool QueryPerformanceCounter(ref long PerformanceCount);

        #endregion

        #region GetDC

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hwnd"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        internal static extern IntPtr GetDC(IntPtr hwnd);

        #endregion

        #region ReleaseDC

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="hDC"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool ReleaseDC(IntPtr hwnd, IntPtr DC);

        #endregion

        #region ChoosePixelFormat

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dc"></param>
        /// <param name="pfd"></param>
        /// <returns></returns>
        [DllImport("gdi32.dll")]
        internal static extern int ChoosePixelFormat(IntPtr dc, [In, MarshalAs(UnmanagedType.LPStruct)]PixelFormatDescriptor pfd);

        #endregion

        #region SetPixelFormat

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dc"></param>
        /// <param name="format"></param>
        /// <param name="pfd"></param>
        /// <returns></returns>
        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetPixelFormat(
            IntPtr dc,
            int format,
            [In, MarshalAs(UnmanagedType.LPStruct)]PixelFormatDescriptor pfd
        );


        #endregion

        #region SetWindowPos

        // WINUSERAPI BOOL WINAPI SetWindowPos(__in HWND hWnd, __in_opt HWND hWndInsertAfter,
        //                                     __in int X, __in int Y, __in int cx, __in int cy, __in UINT uFlags);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetWindowPos(
            IntPtr handle,
            WindowPlacementOptions placement,
            int x, int y, int cx, int cy,
            SetWindowPosFlags flags
        );

        #endregion

        #region SwapBuffers

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dc"></param>
        [DllImport("gdi32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SwapBuffers(IntPtr dc);

        #endregion

        #region GetProcAddress

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="funcname"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetProcAddress(IntPtr handle, string funcname);

        #endregion

        #region LoadLibrary

        /// <summary>
        /// 
        /// </summary>
        /// <param name="funcname"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr LoadLibrary(string dllName);

        #endregion

        #region FreeLibrary

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool FreeLibrary(IntPtr handle);

        #endregion

        #region CreateWindowEx

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern IntPtr CreateWindowEx(
            [In]ExtendedWindowStyle ExStyle,
            [In]string className,
            [In]string windowName,
            [In]WindowStyle Style,
            [In]int X, int Y,
            [In]int Width, int Height,
            [In]IntPtr HandleToParentWindow,
            [In]IntPtr Menu,
            [In]IntPtr Instance,
            [In]IntPtr Param);
        /*
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int CreateWindowEx(
            [In]ExtendedWindowStyle ExStyle,
            [In]IntPtr ClassName,
            [In]IntPtr WindowName,
            [In]WindowStyle Style,
            [In]int X, [In]int Y,
            [In]int Width, [In]int Height,
            [In]IntPtr HandleToParentWindow,
            [In]IntPtr Menu,
            [In]IntPtr Instance,
            [In]IntPtr Param);
        */
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern IntPtr CreateWindowEx(
            ExtendedWindowStyle ExStyle,
            IntPtr ClassName,
            IntPtr WindowName,
            WindowStyle Style,
            int X, int Y,
            int Width, int Height,
            IntPtr HandleToParentWindow,
            IntPtr Menu,
            IntPtr Instance,
            IntPtr Param);

        internal enum WindowStyle : int
        {
            Overlapped = 0x00000000,
            Popup = unchecked((int)0x80000000),
            Child = 0x40000000,
            Minimize = 0x20000000,
            Visible = 0x10000000,
            Disabled = 0x08000000,
            ClipSiblings = 0x04000000,
            ClipChildren = 0x02000000,
            Maximize = 0x01000000,
            Caption = 0x00C00000,    // Border | DialogFrame
            Border = 0x00800000,
            DialogFrame = 0x00400000,
            VScroll = 0x00200000,
            HScreen = 0x00100000,
            SystemMenu = 0x00080000,
            ThickFrame = 0x00040000,
            Group = 0x00020000,
            TabStop = 0x00010000,

            MinimizeBox = 0x00020000,
            MaximizeBox = 0x00010000,

            Tiled = Overlapped,
            Iconic = Minimize,
            SizeBox = ThickFrame,
            TiledWindow = OverlappedWindow,

            // Common window styles:
            OverlappedWindow = Overlapped | Caption | SystemMenu | ThickFrame | MinimizeBox | MaximizeBox,
            PopupWindow = Popup | Border | SystemMenu,
            ChildWindow = Child
        }

        [Flags]
        internal enum ExtendedWindowStyle : int
        {
            DialogModalFrame = 0x00000001,
            NoParentNotify = 0x00000004,
            Topmost = 0x00000008,
            AcceptFiles = 0x00000010,
            Transparent = 0x00000020,

            // #if(WINVER >= 0x0400)
            MdiChild = 0x00000040,
            ToolWindow = 0x00000080,
            WindowEdge = 0x00000100,
            ClientEdge = 0x00000200,
            ContextHelp = 0x00000400,
            // #endif

            // #if(WINVER >= 0x0400)
            Right = 0x00001000,
            Left = 0x00000000,
            RightToLeftReading = 0x00002000,
            LeftToRightReading = 0x00000000,
            LeftScrollbar = 0x00004000,
            RightScrollbar = 0x00000000,

            ControlParent = 0x00010000,
            StaticEdge = 0x00020000,
            ApplicationWindow = 0x00040000,

            OverlappedWindow = WindowEdge | ClientEdge,
            PaletteWindow = WindowEdge | ToolWindow | Topmost,
            // #endif

            // #if(_WIN32_WINNT >= 0x0500)
            Layered = 0x00080000,
            // #endif

            // #if(WINVER >= 0x0500)
            NoInheritLayout = 0x00100000, // Disable inheritence of mirroring by children
            RightToLeftLayout = 0x00400000, // Right to left mirroring
            // #endif /* WINVER >= 0x0500 */

            // #if(_WIN32_WINNT >= 0x0501)
            Composited = 0x02000000,
            // #endif /* _WIN32_WINNT >= 0x0501 */

            // #if(_WIN32_WINNT >= 0x0500)
            NoActivate = 0x08000000
            // #endif /* _WIN32_WINNT >= 0x0500 */
        }

        #endregion

        #region DestroyWindow

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DestroyWindow(IntPtr windowHandle);

        #endregion

        #region GetModuleHandle

        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetModuleHandle([MarshalAs(UnmanagedType.LPTStr)]string module_name);

        #endregion

        #region RegisterClass

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern short RegisterClass(WindowClass window_class);

        #endregion

        #region

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern short UnregisterClass(string className, IntPtr instance);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern short UnregisterClass(IntPtr className, IntPtr instance);

        #endregion

        #region int ChangeDisplaySettings(ref Gdi.DEVMODE devMode, int flags)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="device_mode"></param>
        /// <param name="flags"></param>
        /// <returns></returns>
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int ChangeDisplaySettings(DeviceMode device_mode, int flags);
        #endregion int ChangeDisplaySettings(ref Gdi.DEVMODE devMode, int flags)

        #region EnumDisplaySettings

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern int EnumDisplaySettings([MarshalAs(UnmanagedType.LPTStr)] string device_name,
            int graphics_mode, IntPtr device_mode);

        #endregion


        // *********** Never use GetLastError! ************

        //#region GetLastError

        //[DllImport("kernel32.dll")]
        //internal static extern int GetLastError();

        //#endregion

        //#region SetLastError

        //[DllImport("kernel32.dll")]
        //internal static extern void SetLastError(int error_code);

        //#endregion

        //#region FormatMessage

        //#endregion

        // ************************************************
        #endregion

        #region WINAPI structs

        #region PixelFormatDescriptor struct
        /// <summary>
        /// Describes a pixel format. It is used when interfacing with the WINAPI to create a new Context.
        /// Found in WinGDI.h
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        internal class PixelFormatDescriptor
        {
            short Size = 40;   // No need for the user to set the size, since it is predefined.
            internal short Version = 1;
            internal PixelFormatDescriptorFlags Flags =
                //PixelFormatDescriptorFlags.DOUBLEBUFFER |
                PixelFormatDescriptorFlags.DRAW_TO_WINDOW |
                PixelFormatDescriptorFlags.SUPPORT_OPENGL;
            internal byte PixelType = Constants.PFD_TYPE_RGBA;
            internal byte ColorBits = 0;
            internal byte RedBits = 0;
            internal byte RedShift = 0;
            internal byte GreenBits = 0;
            internal byte GreenShift = 0;
            internal byte BlueBits = 0;
            internal byte BlueShift = 0;
            internal byte AlphaBits = 8;
            internal byte AlphaShift = 0;
            internal byte AccumBits = 0;
            internal byte AccumRedBits = 0;
            internal byte AccumGreenBits = 0;
            internal byte AccumBlueBits = 0;
            internal byte AccumAlphaBits = 0;
            internal byte DepthBits = 0;
            internal byte StencilBits = 0;
            internal byte AuxBuffers = 0;
            internal byte LayerType = unchecked((byte)Constants.PFD_MAIN_PLANE);
            byte Reserved = 0;
            internal int LayerMask = 0;
            internal int VisibleMask = 0;
            internal int DamageMask = 0;
        }
        #endregion

        #region PixelFormatDescriptorFlags enum
        [Flags]
        internal enum PixelFormatDescriptorFlags : int
        {
            // PixelFormatDescriptor flags
            DOUBLEBUFFER,
            STEREO,
            DRAW_TO_WINDOW,
            DRAW_TO_BITMAP,
            SUPPORT_GDI,
            SUPPORT_OPENGL,
            GENERIC_FORMAT,
            NEED_PALETTE,
            NEED_SYSTEM_PALETTE,
            SWAP_EXCHANGE,
            SWAP_COPY,
            SWAP_LAYER_BUFFERS,
            GENERIC_ACCELERATED,
            SUPPORT_DIRECTDRAW,

            // PixelFormatDescriptor flags for use in ChoosePixelFormat only
            DEPTH_DONTCARE = unchecked((int)0x20000000),
            DOUBLEBUFFER_DONTCARE = unchecked((int)0x40000000),
            STEREO_DONTCARE = unchecked((int)0x80000000)
        }
        #endregion

        #region SetWindowPosFlags enum
        [Flags]
        internal enum SetWindowPosFlags
        {
            // SetWindowPos Flags
            NOSIZE,
            NOMOVE,
            NOZORDER,
            NOREDRAW,
            NOACTIVATE,
            FRAMECHANGED,       // The frame changed: send WM_NCCALCSIZE
            SHOWWINDOW,
            HIDEWINDOW,
            NOCOPYBITS,
            NOOWNERZORDER,      // Don't do owner Z ordering
            NOSENDCHANGING,     // Don't send WM_WINDOWPOSCHANGING

            DRAWFRAME = FRAMECHANGED,
            NOREPOSITION = NOOWNERZORDER

            //#if WINVER >= 0x0400
            //internal const int SWP_DEFERERASE     = 0x2000;
            //internal const int SWP_ASYNCWINDOWPOS = 0x4000;
            //#endif
        }
        #endregion

        #region WindowPlacementOptions enum

        internal enum WindowPlacementOptions
        {
            TOP = 0,
            BOTTOM = 1,
            TOPMOST = -1,
            NOTOPMOST = -2
        }

        #endregion

        #region WindowClass
        [StructLayout(LayoutKind.Sequential)]
        internal class WindowClass
        {
            internal WindowClassStyle style = WindowClassStyle.VRedraw | WindowClassStyle.HRedraw | WindowClassStyle.OwnDC;
            [MarshalAs(UnmanagedType.FunctionPtr)]
            internal WindowProcedureEventHandler WindowProcedure;
            internal int ClassExtraBytes;
            internal int WindowExtraBytes;
            //[MarshalAs(UnmanagedType.
            internal IntPtr Instance;
            internal IntPtr Icon;
            internal IntPtr Cursor;
            internal IntPtr BackgroundBrush;
            //[MarshalAs(UnmanagedType.LPStr)]
            internal IntPtr MenuName;
            //[MarshalAs(UnmanagedType.LPStr)]
            internal IntPtr ClassName;
            //internal string ClassName;
        }
        #endregion

        #region WindowClassStyle enum
        [Flags]
        internal enum WindowClassStyle
        {
            //None            = 0x0000,
            VRedraw = 0x0001,
            HRedraw = 0x0002,
            DoubleClicks = 0x0008,
            OwnDC = 0x0020,
            ClassDC = 0x0040,
            ParentDC = 0x0080,
            NoClose = 0x0200,
            SaveBits = 0x0800,
            ByteAlignClient = 0x1000,
            ByteAlignWindow = 0x2000,
            GlobalClass = 0x4000,

            Ime = 0x00010000,

            // #if(_WIN32_WINNT >= 0x0501)
            DropShadow = 0x00020000
            // #endif /* _WIN32_WINNT >= 0x0501 */
        }
        #endregion

        #region DeviceMode class
        /*
        typedef struct _devicemode { 
          BCHAR  dmDeviceName[CCHDEVICENAME]; 
          WORD   dmSpecVersion; 
          WORD   dmDriverVersion; 
          WORD   dmSize; 
          WORD   dmDriverExtra; 
          DWORD  dmFields; 
          union {
            struct {
              short dmOrientation;
              short dmPaperSize;
              short dmPaperLength;
              short dmPaperWidth;
              short dmScale; 
              short dmCopies; 
              short dmDefaultSource; 
              short dmPrintQuality; 
            };
            POINTL dmPosition;
            DWORD  dmDisplayOrientation;
            DWORD  dmDisplayFixedOutput;
          };

          short  dmColor; 
          short  dmDuplex; 
          short  dmYResolution; 
          short  dmTTOption; 
          short  dmCollate; 
          BYTE  dmFormName[CCHFORMNAME]; 
          WORD  dmLogPixels; 
          DWORD  dmBitsPerPel; 
          DWORD  dmPelsWidth; 
          DWORD  dmPelsHeight; 
          union {
            DWORD  dmDisplayFlags; 
            DWORD  dmNup;
          }
          DWORD  dmDisplayFrequency; 
        #if(WINVER >= 0x0400) 
          DWORD  dmICMMethod;
          DWORD  dmICMIntent;
          DWORD  dmMediaType;
          DWORD  dmDitherType;
          DWORD  dmReserved1;
          DWORD  dmReserved2;
        #if (WINVER >= 0x0500) || (_WIN32_WINNT >= 0x0400)
          DWORD  dmPanningWidth;
          DWORD  dmPanningHeight;
        #endif
        #endif 
        } DEVMODE; 
        */
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        internal class DeviceMode
        {
            internal DeviceMode()
            {
                Size = (short)Marshal.SizeOf(this);
            }

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            internal string DeviceName;
            internal short SpecVersion;
            internal short DriverVersion;
            private short Size;
            internal short DriverExtra;
            internal int Fields;

            internal short Orientation;
            internal short PaperSize;
            internal short PaperLength;
            internal short PaperWidth;
            internal short Scale;
            internal short Copies;
            internal short DefaultSource;
            internal short PrintQuality;

            internal short Color;
            internal short Duplex;
            internal short YResolution;
            internal short TTOption;
            internal short Collate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            internal string FormName;
            internal short LogPixels;
            internal int BitsPerPel;
            internal int PelsWidth;
            internal int PelsHeight;
            internal int DisplayFlags;
            internal int DisplayFrequency;
            internal int ICMMethod;
            internal int ICMIntent;
            internal int MediaType;
            internal int DitherType;
            internal int Reserved1;
            internal int Reserved2;
            internal int PanningWidth;
            internal int PanningHeight;
        }

        #endregion DeviceMode class

        #endregion

        #region Callbacks

        [UnmanagedFunctionPointerAttribute(CallingConvention.Winapi)]
        internal delegate void WindowProcedureEventHandler(object sender, WindowProcedureEventArgs e);

        internal class WindowProcedureEventArgs : EventArgs
        {
            internal Message Msg;
        }

        #endregion
    }
}
