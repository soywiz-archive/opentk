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
    using Window = System.UIntPtr;
    using Drawable = System.UIntPtr;
    using Font = System.UIntPtr;
    using Pixmap = System.UIntPtr;
    using Cursor = System.UIntPtr;
    using Colormap = System.UIntPtr;
    using GContext = System.UIntPtr;
    using KeySym = System.UIntPtr;
    using Mask = System.UIntPtr;
    using Atom = System.UIntPtr;
    using VisualID = System.UIntPtr;
    using Time = System.UIntPtr;
    using KeyCode = System.UIntPtr;  /* In order to use IME, the Macintosh needs
                                   * to pack 3 bytes into the keyCode field in
                                   * the XEvent.  In the real X.h, a KeyCode is
                                   * defined as a short, which wouldn't be big
                                   * enough. */

    #endregion

    internal static class X11Api
    {
        private const string _dll_name = "libX11";
        private const string _dll_name_vid = "libXxf86vm";

        #region libX11 Functions

        // Window management
        [DllImport(_dll_name, EntryPoint="XRootWindow")]
        internal static extern Window RootWindow(IntPtr display, int screen);

        // Display management
        [DllImport(_dll_name, EntryPoint = "XOpenDisplay")]
        extern internal static IntPtr OpenDisplay([MarshalAs(UnmanagedType.LPTStr)] string display_name);

        [DllImport(_dll_name, EntryPoint = "XCloseDisplay")]
        extern internal static void CloseDisplay(IntPtr display);


        [DllImport(_dll_name, EntryPoint = "XResizeWindow")]
        extern internal static int XResizeWindow(IntPtr display, Window window, int width, int height);

        [DllImport(_dll_name, EntryPoint = "XCreateColormap")]
        extern internal static UIntPtr CreateColormap(IntPtr display, Window window, IntPtr visual, int alloc);

        #region XCreateWindow, XCreateSimpleWindow

        [DllImport(_dll_name, EntryPoint = "XCreateWindow")]
        extern internal static Window CreateWindow(
            IntPtr display,
            Window parent,
            int x, int y,
            uint width, uint height,
            uint border_width,
            int depth,
            uint @class,
            IntPtr visual,
            [MarshalAs(UnmanagedType.SysUInt)] CreateWindowMask valuemask,
            SetWindowAttributes attributes
        );

        [DllImport(_dll_name, EntryPoint = "XCreateSimpleWindow")]
        extern internal static Window CreateSimpleWindow(
            IntPtr display,
            Window parent,
            int x, int y,
            int width, int height,
            int border_width,
            long border,
            long background
        );

        #endregion

        [DllImport(_dll_name, EntryPoint = "XDefaultScreen")]
        extern internal static int DefaultScreen(IntPtr display);

        [DllImport(_dll_name, EntryPoint = "XDefaultVisual")]
        extern internal static IntPtr DefaultVisual(IntPtr display, int screen_number);


        [DllImport(_dll_name, EntryPoint = "XMapWindow")]
        extern internal static void XMapWindow(IntPtr display, IntPtr window);

        [DllImport(_dll_name, EntryPoint = "XMapRaised")]
        extern internal static void XMapRaised(IntPtr display, IntPtr window);


        #region XFree

        [DllImport(_dll_name, EntryPoint = "XFree")]
        extern internal static void Free(IntPtr data);

        internal static void Free<T>(T data)
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
        extern internal static int EventsQueued(IntPtr Display, int mode);

        [DllImport(_dll_name, EntryPoint = "XPending")]
        extern internal static int Pending(IntPtr Display);

        #endregion

        [DllImport(_dll_name, EntryPoint = "XGrabPointer")]
        extern internal static ErrorCodes XGrabPointer(
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
        extern internal static ErrorCodes XUngrabPointer(IntPtr display, int time);

        [DllImport(_dll_name, EntryPoint = "XGrabKeyboard")]
        extern internal static ErrorCodes XGrabKeyboard(IntPtr display, IntPtr grab_window,
            bool owner_events, GrabMode pointer_mode, GrabMode keyboard_mode, int time);

        [DllImport(_dll_name, EntryPoint = "XUngrabKeyboard")]
        extern internal static void XUngrabKeyboard(IntPtr display, int time);

        #endregion

        #region Xf86VidMode internal structures

        [StructLayout(LayoutKind.Sequential)]
        internal struct XF86VidModeModeLine
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
        internal struct XF86VidModeModeInfo
        {
            /// <summary>
            /// Pixel clock.
            /// </summary>
            internal int dotclock;

            /// <summary>
            /// Number of display pixels horizontally
            /// </summary>
            internal short hdisplay;

            /// <summary>
            /// Horizontal sync start
            /// </summary>
            internal short hsyncstart;

            /// <summary>
            /// Horizontal sync end
            /// </summary>
            internal short hsyncend;

            /// <summary>
            /// Total horizontal pixel
            /// </summary>
            internal short htotal;

            /// <summary>
            /// 
            /// </summary>
            internal short hskew;

            /// <summary>
            /// Number of display pixels vertically
            /// </summary>
            internal short vdisplay;

            /// <summary>
            /// Vertical sync start
            /// </summary>
            internal short vsyncstart;

            /// <summary>
            /// Vertical sync end
            /// </summary>
            internal short vsyncend;

            /// <summary>
            /// Total vertical pixels
            /// </summary>
            internal short vtotal;

            /// <summary>
            /// 
            /// </summary>
            internal short vskew;

            /// <summary>
            /// Mode flags
            /// </summary>
            internal int flags;

            int privsize;   /* Size of private */
            IntPtr _private;   /* Server privates */
        }

        //Monitor information:
        [StructLayout(LayoutKind.Sequential)]
        internal struct XF86VidModeMonitor
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
        internal struct XF86VidModeSyncRange
        {
            float hi;         /* Top of range */
            float lo;         /* Bottom of range */
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct XF86VidModeNotifyEvent
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
        internal struct XF86VidModeGamma
        {
            float red;                     /* Red Gamma value */
            float green;                   /* Green Gamma value */
            float blue;                    /* Blue Gamma value */
        }
        #endregion

        #region libXxf86vm Functions

        [DllImport(_dll_name_vid)]
        extern internal static bool XF86VidModeQueryExtension(
            IntPtr display,
            out int event_base_return,
            out int error_base_return);
        /*
        [DllImport(_dll_name_vid)]
        extern internal static bool XF86VidModeSwitchMode(
            IntPtr display,
            int screen,
            int zoom);
        */

        [DllImport(_dll_name_vid)]
        extern internal static bool XF86VidModeSwitchToMode(
            IntPtr display,
            int screen,
            IntPtr
            /*XF86VidModeModeInfo* */ modeline);


        [DllImport(_dll_name_vid)]
        extern internal static bool XF86VidModeQueryVersion(
            IntPtr display,
            out int major_version_return,
            out int minor_version_return);

        [DllImport(_dll_name_vid)]
        extern internal static bool XF86VidModeGetAllModeLines(
            IntPtr display,
            int screen,
            out int modecount_return,
            /*XF86VidModeModeInfo***  <-- yes, that's three *'s. */
            out IntPtr modesinfo);

        [DllImport(_dll_name_vid)]
        extern internal static bool XF86VidModeSetViewPort(
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

    #region internal class VisualInfo

    [StructLayout(LayoutKind.Sequential)]
    internal class VisualInfo
    {
        internal IntPtr visual;
        internal int visualid;
        internal int screen;
        internal int depth;
        internal int @class;
        internal long redMask;
        internal long greenMask;
        internal long blueMask;
        internal int colormap_size;
        internal int bits_per_rgb;

        public override string ToString()
        {
 	         return base.ToString();
        }
    }

    #endregion

    #region internal class SetWindowAttributes

    [StructLayout(LayoutKind.Sequential)]
    internal class SetWindowAttributes
    {
        /// <summary>
        /// background, None, or ParentRelative
        /// </summary>
        internal Pixmap background_pixmap;
        /// <summary>
        /// background pixel
        /// </summary>
        internal long background_pixel;
        /// <summary>
        /// border of the window or CopyFromParent
        /// </summary>
        internal Pixmap border_pixmap;
        /// <summary>
        /// border pixel value
        /// </summary>
        internal long border_pixel;
        /// <summary>
        /// one of bit gravity values
        /// </summary>
        internal int bit_gravity;
        /// <summary>
        /// one of the window gravity values
        /// </summary>
        internal int win_gravity;
        /// <summary>
        /// NotUseful, WhenMapped, Always
        /// </summary>
        internal int backing_store;
        /// <summary>
        /// planes to be preserved if possible
        /// </summary>
        internal long backing_planes;
        /// <summary>
        /// value to use in restoring planes
        /// </summary>
        internal long backing_pixel;
        /// <summary>
        /// should bits under be saved? (popups)
        /// </summary>
        internal bool save_under;
        /// <summary>
        /// set of events that should be saved
        /// </summary>
        internal EventMask event_mask;
        /// <summary>
        /// set of events that should not propagate
        /// </summary>
        internal long do_not_propagate_mask;
        /// <summary>
        /// boolean value for override_redirect
        /// </summary>
        internal bool override_redirect;
        /// <summary>
        /// color map to be associated with window
        /// </summary>
        internal Colormap colormap;
        /// <summary>
        /// cursor to be displayed (or None)
        /// </summary>
        internal Cursor cursor;
    }

    #endregion

    #region internal struct SizeHints

    [StructLayout(LayoutKind.Sequential)]
    internal struct SizeHints
    {
        internal long flags;         /* marks which fields in this structure are defined */
        internal int x, y;           /* Obsolete */
        internal int width, height;  /* Obsolete */
        internal int min_width, min_height;
        internal int max_width, max_height;
        internal int width_inc, height_inc;
        internal struct min_aspect
        {
            internal int x;       /* numerator */
            internal int y;       /* denominator */
        }
        internal struct max_aspect
        {
            internal int x;       /* numerator */
            internal int y;       /* denominator */
        }
        internal int base_width, base_height;
        internal int win_gravity;
        /* this structure may be extended in the future */
    }

    #endregion

    #endregion

    #region X11 Constants and Enums

    internal struct Constants
    {
        internal const int QueuedAlready = 0;
        internal const int QueuedAfterReading = 1;
        internal const int QueuedAfterFlush = 2;

        internal const int CopyFromParent	= 0;
        internal const int CWX = 1;
        internal const int InputOutput = 1;
        internal const int InputOnly = 2;
    }

    internal enum ErrorCodes : int
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

    internal enum GrabMode : int
    {
        Sync = 0,
        Async = 1,
    }

    [Flags]
    internal enum EventMask : ulong
    {
        NoEventMask	= 0,
        KeyPressMask	= (1L<<0),
        KeyReeaseMask	= (1L<<1),
        Button3MotionMask	= (1L<<10),
        Button4MotionMask	= (1L<<11),
        Button5MotionMask	= (1L<<12),
        ButtonMotionMask	= (1L<<13),
        KeymapStateMask	= (1L<<14),
        ExposureMask	= (1L<<15),
        VisibiityChangeMask	= (1L<<16),
        StructureNotifyMask	= (1L<<17),
        ResizeRedirectMask	= (1L<<18),
        SubstructureNotifyMask	= (1L<<19),
        ButtonPressMask	= (1L<<2),
        SubstructureRedirectMask	= (1L<<20),
        FocusChangeMask	= (1L<<21),
        PropertyChangeMask	= (1L<<22),
        CoormapChangeMask	= (1L<<23),
        ButtonReeaseMask	= (1L<<3),
        EnterWindowMask	= (1L<<4),
        eaveWindowMask	= (1L<<5),
        PointerMotionMask	= (1L<<6),
        PointerMotionHintMask	= (1L<<7),
        Button1MotionMask	= (1L<<8),
        Button2MotionMask	= (1L<<9),
    }

    [Flags]
    internal enum CreateWindowMask : ulong
    {
        CWBackPixmap	= (1L<<0),
        CWBackPixel     = (1L<<1),
        CWSaveUnder	    = (1L<<10),
        CWEventMask	    = (1L<<11),
        CWDontPropagate	= (1L<<12),
        CWColormap  	= (1L<<13),
        CWCursor	    = (1L<<14),
        CWBorderPixmap	= (1L<<2),
        CWBorderPixel	= (1L<<3),
        CWBitGravity	= (1L<<4),
        CWWinGravity	= (1L<<5),
        CWBackingStore	= (1L<<6),
        CWBackingPlanes	= (1L<<7),
        CWBackingPixel 	= (1L<<8),
        CWOverrideRedirect	= (1L<<9),

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
