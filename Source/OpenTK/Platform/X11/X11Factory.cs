using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.X11
{
    using Graphics;

    class X11Factory : IPlatformFactory 
    {
        #region IPlatformFactory Members

        public INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device)
        {
            return new X11GLNative(x, y, width, height, title, mode, options, device);
        }

        public IGLControl CreateGLControl(GraphicsMode mode, GLControl owner)
        {
            return new X11GLControl(mode, owner);
        }

        public IDisplayDeviceDriver CreateDisplayDeviceDriver()
        {
            return new X11XrandrDisplayDevice();
        }

        public IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool DirectRendering, int major, int minor, GraphicsContextFlags flags)
        {
            return new X11GLContext(mode, window, shareContext, DirectRendering, major, minor, flags);
        }

        public IGraphicsMode CreateGraphicsMode()
        {
            return new X11GraphicsMode();
        }

        #endregion
    }
}
