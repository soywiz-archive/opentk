#define TRACE

#region --- License ---
/* Copyright (c) 2007 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

//using OpenTK.OpenGL;

namespace OpenTK.Platform.X11
{
    sealed class X11GLNative : OpenTK.Platform.IGLWindow, IDisposable
    {
        #region --- Private Fields ---

        private X11GLContext glContext;

        private IntPtr display;
        private int screen;
        private IntPtr rootWindow;
        private IntPtr window;

        private DisplayMode mode = new DisplayMode();

        // C# ResizeEventArgs
        private ResizeEventArgs resizeEventArgs = new ResizeEventArgs();
        // Low level X11 resize request
        private X11.Event xresize = new Event();
        // Event used for event loop.
        private Event e; // = new Event();
        int pending = 0; // Number of pending events.

        //private int width, height;

        #endregion

        #region --- Public Constructors ---

        /// <summary>
        /// Constructs a new X11GLNative window, with its associated context.
        /// Safe defaults for visual, colormap, etc.
        /// </summary>
        public X11GLNative()
        {
            mode.Width = 640;
            mode.Height = 480;
        
            display = API.OpenDisplay(null); // null == default display
            if (display == IntPtr.Zero)
            {
                throw new Exception("Could not open connection to X");
            }
            screen = API.DefaultScreen(display);
            rootWindow = API.RootWindow(display, screen);
            
            ColorDepth color = new ColorDepth(24);
            int depthBits = 16;

            // Create the Visual
            List<int> visualAttributes = new List<int>();
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.RGBA);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.RED_SIZE);
            visualAttributes.Add((int)color.Red);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.GREEN_SIZE);
            visualAttributes.Add((int)color.Green);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.BLUE_SIZE);
            visualAttributes.Add((int)color.Blue);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.ALPHA_SIZE);
            visualAttributes.Add((int)color.Alpha);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.DEPTH_SIZE);
            visualAttributes.Add((int)depthBits);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.DOUBLEBUFFER);
            visualAttributes.Add((int)Glx.Enums.GLXAttribute.NONE);

#if TRACE
            Console.Write(
                "Requesting visual: {0} (RGBA: {1}{2}{3}{4})... ",
                color.ToString(),
                color.Red,
                color.Green,
                color.Blue,
                color.Alpha);
            Console.Out.Flush();
#endif
            
            IntPtr low_level_glxVisualInfo =
                Glx.ChooseVisual(display, screen, visualAttributes.ToArray());
            if (low_level_glxVisualInfo == IntPtr.Zero)
            {
                throw new Exception("Requested visual not available.");
            }
            VisualInfo glxVisualInfo =
                (VisualInfo)Marshal.PtrToStructure(low_level_glxVisualInfo, typeof(VisualInfo));

#if TRACE
            Console.WriteLine("ok!");
            Console.Out.Flush();
#endif

            // Create a window on this display using the visual above
            SetWindowAttributes wnd_attributes = new SetWindowAttributes();

            wnd_attributes.background_pixel = 0;
            wnd_attributes.border_pixel = 0;
            wnd_attributes.colormap =
                API.CreateColormap(display, rootWindow, glxVisualInfo.visual, 0/*AllocNone*/);
            wnd_attributes.event_mask =
                EventMask.StructureNotifyMask |
                EventMask.ExposureMask |
                EventMask.KeyPressMask;

            CreateWindowMask cw_mask =
                CreateWindowMask.CWBackPixel |
                CreateWindowMask.CWBorderPixel |
                CreateWindowMask.CWColormap |
                CreateWindowMask.CWEventMask;

#if TRACE
            Console.Write("Creating window... ");
#endif

            window = API.CreateWindow(
                display,
                rootWindow,
                0, 0,
                640, 480,
                0,
                glxVisualInfo.depth,
                Constants.InputOutput,
                glxVisualInfo.visual,
                cw_mask,
                wnd_attributes
            );

            if (window == IntPtr.Zero)
            {
                throw new Exception("Could not create window.");
            }

#if TRACE
            Console.WriteLine("ok! (id: {0})", window);
            Console.Out.Flush();
#endif

            // Set the window hints
            /*
            SizeHints hints = new SizeHints();
            hints.x = 0;
            hints.y = 0;
            hints.width = 640;
            hints.height = 480;
            hints.flags = USSize | USPosition;
            X11Api.SetNormalHints(display, window, hints);
            X11Api.SetStandardProperties(
                display,
                window,
                name,
                name,
                0,  // None
                null,
                0,
                hints
            );
            */

#if TRACE
            Console.Write("Creating OpenGL context... ");
#endif
            // Create the GLX context with the specified parameters
            glContext = new X11GLContext();
            glContext.handle = window;
            glContext.display = display;
            glContext.x11context = Glx.CreateContext(
                display,
                glxVisualInfo,
                IntPtr.Zero,
                true
            );
            if (glContext.x11context == IntPtr.Zero)
            {
                // If we couldn't get a context, retry with indirect rendering.
                glContext.x11context = Glx.CreateContext(
                    display,
                    glxVisualInfo,
                    IntPtr.Zero,
                    false
                );
            }
            if (glContext.x11context == IntPtr.Zero)
            {
                // If we failed again, stop trying.
                // TODO: Create a specific exception!
                throw new Exception("Could not create GLX Context");
            }

#if TRACE
            Console.WriteLine("ok! (id: {0})", glContext.x11context);
            Console.Out.Flush();
#endif            
            API.Free(low_level_glxVisualInfo);
            glxVisualInfo = null;

            API.MapRaised(display, window);
#if TRACE
            Console.WriteLine("Mapped window.");
            Console.Out.Flush();
#endif
            glContext.MakeCurrent();
#if TRACE
            Console.WriteLine("Our shiny new context is now current - ready to rock 'n' roll!");
            Console.Out.Flush();
#endif
        }

        #endregion

        #region --- IGLWindow Members ---

        #region public void ProcessEvents()

        public void ProcessEvents()
        {
            // Process all pending events
            while (true)
            {
                pending = API.Pending(display);
                if (pending == 0)
                    return;
                API.NextEvent(display, out e);
                
                Console.WriteLine("Event: {0} ({1} pending)", e.Type, pending);
                Console.Out.Flush();

                // Respond to the event e
                switch (e.Type)
                {
                    case EventType.CreateNotify:
                        // Window creation event
                        mode.Width = e.CreateWindow.width;
                        mode.Height = e.CreateWindow.height;
                        this.OnCreate(EventArgs.Empty);
                        Console.WriteLine(
                                "OnCreate fired: {0}x{1}",
                                mode.Width,
                                mode.Height
                            );
                        Console.Out.Flush();
                        break;

                    case EventType.DestroyNotify:
                        // Window destruction event
                        quit = true;
                        Console.WriteLine("Window destroyed");
                        Console.Out.Flush();
                        break;
                        
                    /*
                    case EventType.ResizeRequest:
                        // If the window size changed, raise the C# Resize event.
                        if (e.ResizeRequest.width != mode.Width || e.ResizeRequest.height != mode.Height)
                        {
                            Console.WriteLine(
                                "New res: {0}x{1}",
                                e.xResizeRequest.width,
                                e.xResizeRequest.height
                            );
                            Console.Out.Flush();

                            resizeEventArgs.Width = e.ResizeRequest.width;
                            resizeEventArgs.Height = e.ResizeRequest.height;
                            this.OnResize(resizeEventArgs);
                        }
                        break;
                    */
                    
                    case EventType.ConfigureNotify:
                        // If the window size changed, raise the C# Resize event.
                        if (e.ConfigureNotify.width != mode.Width ||
                            e.ConfigureNotify.height != mode.Height)
                        {
                            Console.WriteLine(
                                "New res: {0}x{1}",
                                e.ConfigureNotify.width,
                                e.ConfigureNotify.height
                            );
                            Console.Out.Flush();

                            resizeEventArgs.Width = e.ConfigureNotify.width;
                            resizeEventArgs.Height = e.ConfigureNotify.height;
                            this.OnResize(resizeEventArgs);
                        }
                        break;
                        
                }
            }
        }

        #endregion

        #region public event CreateEvent Create;

        public event CreateEvent Create;

        private void OnCreate(EventArgs e)
        {
            if (this.Create != null)
            {
                this.Create(this, e);
            }
        }

        #endregion

        #region public bool Quit

        private bool quit;
        public bool Quit
        {
            get { return quit; }
            set
            {
                if (value)
                {
                    /*Event e = new Event();
                    X11Api.SendEvent(
                        display,
                        window,
                        false,
                        0,*/
                    //quit = true;
                }
            }
        }

        #endregion

        #region public bool IsIdle

        public bool IsIdle
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion

        #region public bool Fullscreen

        public bool Fullscreen
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        #endregion

        #region public IGLContext Context

        public OpenTK.Platform.IGLContext Context
        {
            get { return glContext; }
        }

        #endregion

        #endregion

        #region --- IResizable Members ---

        #region public int Width

        public int Width
        {
            get
            {
                return mode.Width;
            }
            set
            {
                // Clear event struct
                //Array.Clear(xresize.pad, 0, xresize.pad.Length);
                // Set requested parameters
                xresize.ResizeRequest.type = EventType.ResizeRequest;
                xresize.ResizeRequest.display = this.display;
                xresize.ResizeRequest.width = value;
                xresize.ResizeRequest.height = mode.Width;
                API.SendEvent(
                    this.display,
                    this.window,
                    false,
                    EventMask.StructureNotifyMask,
                    ref xresize
                );
            }
        }

        #endregion

        #region public int Height

        public int Height
        {
            get
            {
                return mode.Height;
            }
            set
            {
                // Clear event struct
                //Array.Clear(xresize.pad, 0, xresize.pad.Length);
                // Set requested parameters
                xresize.ResizeRequest.type = EventType.ResizeRequest;
                xresize.ResizeRequest.display = this.display;
                xresize.ResizeRequest.width = mode.Width;
                xresize.ResizeRequest.height = value;
                API.SendEvent(
                    this.display,
                    this.window,
                    false,
                    EventMask.StructureNotifyMask,
                    ref xresize
                );
            }
        }

        #endregion

        #region public event ResizeEvent Resize

        public event ResizeEvent Resize;

        private void OnResize(ResizeEventArgs e)
        {
            mode.Width = e.Width;
            mode.Height = e.Height;
            if (this.Resize != null)
            {
                this.Resize(this, e);
            }
        }

        #endregion

        #endregion

        #region --- IDisposable Members ---

        public void Dispose()
        {
            glContext.Destroy();
            API.DestroyWindow(display, window);
            API.CloseDisplay(display);
        }

        #endregion
    }
}
