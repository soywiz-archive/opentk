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
using System.ComponentModel;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;

namespace OpenTK.Platform
{
    public interface INativeWindow : IDisposable
    {
        event EventHandler<EventArgs> Load;
        event EventHandler<EventArgs> Unload;
        event EventHandler<ResizeEventArgs> Resize;
        event EventHandler<CancelEventArgs> Closing;
        event EventHandler<EventArgs> Closed;
        event EventHandler<EventArgs> Idle;

        Point Location { get; set; }
        Size Size { get; set; }
        Rectangle Viewport { get; set; }

        int X { get; }
        int Y { get; }
        int Width { get; }
        int Height { get; }

        string Title { get; set; }
        Icon Icon { get; set; }
        WindowBorder WindowBorder { get; set; }
        WindowState WindowState { get; set; }
        bool Visible { get; set; }

        // Todo: Separate the IGraphicsContext from the INativeWindow.
        IGraphicsContext Context { get; }
        
        void Run();
        void Close();
    }
}
