#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.X11
{
    using Graphics;

    class X11Factory : IPlatformFactory 
    {
        #region IPlatformFactory Members

        public INativeGLWindow CreateGLNative()
        {
            return new X11GLNative();
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

        public OpenTK.Input.IInputDriver CreateInputDriver()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
