#region License
/* Copyright (c) 2006 Stephen Apostolopoulos
 * Contributions from Erik Ylvisaker
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.X11
{
    #region Types

    // using XID = System.Int32;
    using Window = System.IntPtr;
    using Drawable = System.IntPtr;
    using Font = System.IntPtr;
    using Pixmap = System.IntPtr;
    using Cursor = System.IntPtr;
    using Colormap = System.IntPtr;
    using GContext = System.IntPtr;
    using KeySym = System.IntPtr;
    using Mask = System.IntPtr;
    using Atom = System.IntPtr;
    using VisualID = System.IntPtr;
    using Time = System.IntPtr;
    using KeyCode = System.IntPtr;  /* In order to use IME, the Macintosh needs
                                   * to pack 3 bytes into the keyCode field in
                                   * the XEvent.  In the real X.h, a KeyCode is
                                   * defined as a short, which wouldn't be big
                                   * enough. */

    #endregion

    public static class X11Api
    {
        private const string _dll_name = "libX11";
        private const string _dll_name_vid = "libXxf86vm";

        #region libX11 Functions

        // Window management
        [DllImport(_dll_name, EntryPoint="RootWindow")]
        public static extern Window RootWindow(IntPtr display, int screen);

        // Display management
        [DllImport(_dll_name, EntryPoint = "XOpenDisplay")]
        extern public static IntPtr OpenDisplay([MarshalAs(UnmanagedType.LPTStr)] string display_name);

        [DllImport(_dll_name, EntryPoint = "XCloseDisplay")]
        extern public static void CloseDisplay(IntPtr display);


        [DllImport(_dll_name, EntryPoint = "XCreateColormap")]
        extern public static int XResizeWindow(IntPtr display, IntPtr window, int width, int height);

        [DllImport(_dll_name, EntryPoint = "XCreateColormap")]
        extern public static IntPtr CreateColormap(IntPtr display, IntPtr window, IntPtr visual, int alloc);

        #region XCreateWindow

        [DllImport(_dll_name, EntryPoint = "XCreateWindow")]
        extern public static Window CreateWindow(
            IntPtr display,
            Window parent,
            int x, int y,
            int width, int height,
            int border_width,
            int depth,
            int @class,
            IntPtr visual,
            CreateWindowMask valuemask,
            SetWindowAttributes attributes
        );

        #endregion

        [DllImport(_dll_name, EntryPoint = "XDefaultScreen")]
        extern public static int DefaultScreen(IntPtr display);

        [DllImport(_dll_name, EntryPoint = "XDefaultVisual")]
        extern public static IntPtr DefaultVisual(IntPtr display, int screen_number);

        #region XFree

        [DllImport(_dll_name, EntryPoint = "XFree")]
        extern public static void Free(IntPtr data);

        public static void Free<T>(T data)
        {
            GCHandle h0 = GCHandle.Alloc(data, GCHandleType.Pinned);

            try
            {
                Free(data);
            }
            finally
            {
                h0.Free();
            }
        }

        #endregion

        #region Event queue management

        [DllImport(_dll_name, EntryPoint = "XEventsQueued")]
        extern public static int EventsQueued(IntPtr Display, int mode);

        [DllImport(_dll_name, EntryPoint = "XPending")]
        extern public static int Pending(IntPtr Display);

        #endregion

        [DllImport(_dll_name, EntryPoint = "XGrabPointer")]
        extern public static ErrorCodes XGrabPointer(
            IntPtr display,
            IntPtr grab_window,
            bool owner_events, int event_mask,
            GrabMode pointer_mode,
            GrabMode keyboard_mode,
            IntPtr confine_to,
            IntPtr cursor,
            int time
        );

        [DllImport(_dll_name, EntryPoint = "XUngrabPointer")]
        extern public static ErrorCodes XUngrabPointer(IntPtr display, int time);

        [DllImport(_dll_name, EntryPoint = "XGrabKeyboard")]
        extern public static ErrorCodes XGrabKeyboard(IntPtr display, IntPtr grab_window,
            bool owner_events, GrabMode pointer_mode, GrabMode keyboard_mode, int time);

        [DllImport(_dll_name, EntryPoint = "XUngrabKeyboard")]
        extern public static void XUngrabKeyboard(IntPtr display, int time);

        [DllImport(_dll_name, EntryPoint = "XMapWindow")]
        extern public static void XMapWindow(IntPtr display, IntPtr window);

        [DllImport(_dll_name, EntryPoint = "XMapRaised")]
        extern public static void XMapRaised(IntPtr display, IntPtr window);



        #endregion

        #region Xf86VidMode public structures

        [StructLayout(LayoutKind.Sequential)]
        public struct XF86VidModeModeLine
        {
            short hdisplay;   /* Number of display pixels horizontally */
            short hsyncstart; /* Horizontal sync start */
            short hsyncend;   /* Horizontal sync end */
            short htotal;     /* Total horizontal pixels */
            short vdisplay;   /* Number of display pixels vertically */
            short vsyncstart; /* Vertical sync start */
            short vsyncend;   /* Vertical sync start */
            short vtotal;     /* Total vertical pixels */
            int flags;      /* Mode flags */
            int privsize;   /* Size of private */
            IntPtr _private;   /* Server privates */
        }

        /// <summary>
        /// Specifies an XF86 display mode.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct XF86VidModeModeInfo
        {
            /// <summary>
            /// Pixel clock.
            /// </summary>
            public int dotclock;

            /// <summary>
            /// Number of display pixels horizontally
            /// </summary>
            public short hdisplay;

            /// <summary>
            /// Horizontal sync start
            /// </summary>
            public short hsyncstart;

            /// <summary>
            /// Horizontal sync end
            /// </summary>
            public short hsyncend;

            /// <summary>
            /// Total horizontal pixel
            /// </summary>
            public short htotal;

            /// <summary>
            /// 
            /// </summary>
            public short hskew;

            /// <summary>
            /// Number of display pixels vertically
            /// </summary>
            public short vdisplay;

            /// <summary>
            /// Vertical sync start
            /// </summary>
            public short vsyncstart;

            /// <summary>
            /// Vertical sync end
            /// </summary>
            public short vsyncend;

            /// <summary>
            /// Total vertical pixels
            /// </summary>
            public short vtotal;

            /// <summary>
            /// 
            /// </summary>
            public short vskew;

            /// <summary>
            /// Mode flags
            /// </summary>
            public int flags;

            int privsize;   /* Size of private */
            IntPtr _private;   /* Server privates */
        }

        //Monitor information:
        [StructLayout(LayoutKind.Sequential)]
        public struct XF86VidModeMonitor
        {
            [MarshalAs(UnmanagedType.LPStr)]
            string vendor;     /* Name of manufacturer */
            [MarshalAs(UnmanagedType.LPStr)]
            string model;      /* Model name */
            float EMPTY;      /* unused, for backward compatibility */
            byte nhsync;     /* Number of horiz sync ranges */
            /*XF86VidModeSyncRange* */
            IntPtr hsync;/* Horizontal sync ranges */
            byte nvsync;     /* Number of vert sync ranges */
            /*XF86VidModeSyncRange* */
            IntPtr vsync;/* Vertical sync ranges */
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct XF86VidModeSyncRange
        {
            float hi;         /* Top of range */
            float lo;         /* Bottom of range */
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct XF86VidModeNotifyEvent
        {
            int type;                      /* of event */
            ulong serial;          /* # of last request processed by server */
            bool send_event;               /* true if this came from a SendEvent req */
            IntPtr display;              /* Display the event was read from */
            IntPtr root;                   /* root window of event screen */
            int state;                     /* What happened */
            int kind;                      /* What happened */
            bool forced;                   /* extents of new region */
            /* Time */
            IntPtr time;                     /* event timestamp */
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct XF86VidModeGamma
        {
            float red;                     /* Red Gamma value */
            float green;                   /* Green Gamma value */
            float blue;                    /* Blue Gamma value */
        }
        #endregion

        #region libXxf86vm Functions

        [DllImport(_dll_name_vid)]
        extern public static bool XF86VidModeQueryExtension(
            IntPtr display,
            out int event_base_return,
            out int error_base_return);
        /*
        [DllImport(_dll_name_vid)]
        extern public static bool XF86VidModeSwitchMode(
            IntPtr display,
            int screen,
            int zoom);
        */

        [DllImport(_dll_name_vid)]
        extern public static bool XF86VidModeSwitchToMode(
            IntPtr display,
            int screen,
            IntPtr
            /*XF86VidModeModeInfo* */ modeline);


        [DllImport(_dll_name_vid)]
        extern public static bool XF86VidModeQueryVersion(
            IntPtr display,
            out int major_version_return,
            out int minor_version_return);

        [DllImport(_dll_name_vid)]
        extern public static bool XF86VidModeGetAllModeLines(
            IntPtr display,
            int screen,
            out int modecount_return,
            /*XF86VidModeModeInfo***  <-- yes, that's three *'s. */
            out IntPtr modesinfo);

        [DllImport(_dll_name_vid)]
        extern public static bool XF86VidModeSetViewPort(
            IntPtr display,
            int screen,
            int x,
            int y);

        /*
Bool XF86VidModeSetClientVersion(
    Display *display);

Bool XF86VidModeGetModeLine(
    Display *display,
    int screen,
    int *dotclock_return,
    XF86VidModeModeLine *modeline);

Bool XF86VidModeDeleteModeLine(
    Display *display,
    int screen,
    XF86VidModeModeInfo *modeline);

Bool XF86VidModeModModeLine(
    Display *display,
    int screen,
    XF86VidModeModeLine *modeline);

Status XF86VidModeValidateModeLine(
    Display *display,
    int screen,
    XF86VidModeModeLine *modeline);


Bool XF86VidModeLockModeSwitch(
    Display *display,
    int screen,
    int lock);

Bool XF86VidModeGetMonitor(
    Display *display,
    int screen,
    XF86VidModeMonitor *monitor);

Bool XF86VidModeGetViewPort(
    Display *display,
    int screen,
    int *x_return,
    int *y_return);


XF86VidModeGetDotClocks(
    Display *display,
    int screen,
    int *flags return,
    int *number of clocks return,
    int *max dot clock return,
    int **clocks return);

XF86VidModeGetGamma(
    Display *display,
    int screen,
    XF86VidModeGamma *Gamma);

XF86VidModeSetGamma(
    Display *display,
    int screen,
    XF86VidModeGamma *Gamma);

XF86VidModeGetGammaRamp(
    Display *display,
    int screen,
    int size,
    unsigned short *red array,
    unsigned short *green array,
    unsigned short *blue array);

XF86VidModeSetGammaRamp(
    Display *display,
    int screen,
    int size,
    unsigned short *red array,
    unsigned short *green array,
    unsigned short *blue array);

XF86VidModeGetGammaRampSize(
    Display *display,
    int screen,
    int *size);
         * */

        #endregion
    }

    #region X11 Structures

    #region public class VisualInfo

    [StructLayout(LayoutKind.Sequential)]
    public class VisualInfo
    {
        public IntPtr visual;
        public int visualid;
        public int screen;
        public int depth;
        public int @class;
        public long redMask;
        public long greenMask;
        public long blueMask;
        public int colormap_size;
        public int bits_per_rgb;
    }

    #endregion

    #region public struct SetWindowAttributes

    [StructLayout(LayoutKind.Sequential)]
    public struct SetWindowAttributes
    {
        /// <summary>
        /// background, None, or ParentRelative
        /// </summary>
        public Pixmap background_pixmap;
        /// <summary>
        /// background pixel
        /// </summary>
        public long background_pixel;
        /// <summary>
        /// border of the window or CopyFromParent
        /// </summary>
        public Pixmap border_pixmap;
        /// <summary>
        /// border pixel value
        /// </summary>
        public long border_pixel;
        /// <summary>
        /// one of bit gravity values
        /// </summary>
        public int bit_gravity;
        /// <summary>
        /// one of the window gravity values
        /// </summary>
        public int win_gravity;
        /// <summary>
        /// NotUseful, WhenMapped, Always
        /// </summary>
        public int backing_store;
        /// <summary>
        /// planes to be preserved if possible
        /// </summary>
        public long backing_planes;
        /// <summary>
        /// value to use in restoring planes
        /// </summary>
        public long backing_pixel;
        /// <summary>
        /// should bits under be saved? (popups)
        /// </summary>
        public bool save_under;
        /// <summary>
        /// set of events that should be saved
        /// </summary>
        public EventMask event_mask;
        /// <summary>
        /// set of events that should not propagate
        /// </summary>
        public long do_not_propagate_mask;
        /// <summary>
        /// boolean value for override_redirect
        /// </summary>
        public bool override_redirect;
        /// <summary>
        /// color map to be associated with window
        /// </summary>
        public Colormap colormap;
        /// <summary>
        /// cursor to be displayed (or None)
        /// </summary>
        public Cursor cursor;
    }

    #endregion

    #region public struct SizeHints

    [StructLayout(LayoutKind.Sequential)]
    public struct SizeHints
    {
        public long flags;         /* marks which fields in this structure are defined */
        public int x, y;           /* Obsolete */
        public int width, height;  /* Obsolete */
        public int min_width, min_height;
        public int max_width, max_height;
        public int width_inc, height_inc;
        public struct min_aspect
        {
            public int x;       /* numerator */
            public int y;       /* denominator */
        }
        public struct max_aspect
        {
            public int x;       /* numerator */
            public int y;       /* denominator */
        }
        public int base_width, base_height;
        public int win_gravity;
        /* this structure may be extended in the future */
    }

    #endregion

    #endregion

    #region X11 Constants and Enums

    public struct Constants
    {
        public const int QueuedAlready = 0;
        public const int QueuedAfterReading = 1;
        public const int QueuedAfterFlush = 2;

        public const int CopyFromParent	= 0;
        public const int CWX = (1<<0);
        public const int InputOutput = 1;
        public const int InputOnly = 2;
    }

    public enum ErrorCodes : int
    {
        Success = 0,
        BadRequest = 1,
        BadValue = 2,
        BadWindow = 3,
        BadPixmap = 4,
        BadAtom = 5,
        BadCursor = 6,
        BadFont = 7,
        BadMatch = 8,
        BadDrawable = 9,
        BadAccess = 10,
        BadAlloc = 11,
        BadColor = 12,
        BadGC = 13,
        BadIDChoice = 14,
        BadName = 15,
        BadLength = 16,
        BadImplementation = 17,
    }

    public enum GrabMode : int
    {
        Sync = 0,
        Async = 1,
    }

    [Flags]
    public enum EventMask
    {
        NoEventMask	= 0,
        KeyPressMask	= (1<<0),
        KeyReeaseMask	= (1<<1),
        Button3MotionMask	= (1<<10),
        Button4MotionMask	= (1<<11),
        Button5MotionMask	= (1<<12),
        ButtonMotionMask	= (1<<13),
        KeymapStateMask	= (1<<14),
        ExposureMask	= (1<<15),
        VisibiityChangeMask	= (1<<16),
        StructureNotifyMask	= (1<<17),
        ResizeRedirectMask	= (1<<18),
        SubstructureNotifyMask	= (1<<19),
        ButtonPressMask	= (1<<2),
        SubstructureRedirectMask	= (1<<20),
        FocusChangeMask	= (1<<21),
        PropertyChangeMask	= (1<<22),
        CoormapChangeMask	= (1<<23),
        ButtonReeaseMask	= (1<<3),
        EnterWindowMask	= (1<<4),
        eaveWindowMask	= (1<<5),
        PointerMotionMask	= (1<<6),
        PointerMotionHintMask	= (1<<7),
        Button1MotionMask	= (1<<8),
        Button2MotionMask	= (1<<9),
    }

    [Flags]
    public enum CreateWindowMask
    {
        CWBackPixmap	= (1<<0),
        CWBackPixel     = (1<<1),
        CWSaveUnder	    = (1<<10),
        CWEventMask	    = (1<<11),
        CWDontPropagate	= (1<<12),
        CWColormap  	= (1<<13),
        CWCursor	    = (1<<14),
        CWBorderPixmap	= (1<<2),
        CWBorderPixel	= (1<<3),
        CWBitGravity	= (1<<4),
        CWWinGravity	= (1<<5),
        CWBackingStore	= (1<<6),
        CWBackingPlanes	= (1<<7),
        CWBackingPixel 	= (1<<8),
        CWOverrideRedirect	= (1<<9),

        /*
        CWY	= (1<<1),
        CWWidth	= (1<<2),
        CWHeight	= (1<<3),
        CWBorderWidth	= (1<<4),
        CWSibling	= (1<<5),
        CWStackMode	= (1<<6),
        */
    }

    #endregion
}
