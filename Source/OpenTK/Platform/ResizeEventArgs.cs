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
using System.Drawing;
using System.Text;

namespace OpenTK.Platform
{
    public class ResizeEventArgs : EventArgs
    {
        Point location;
        Size size;
        Rectangle viewport;

        public ResizeEventArgs()
        {
        }

        public ResizeEventArgs(int Width, int Height)
            : this(Point.Empty, new Size(Width, Height), Rectangle.Empty)
        {
        }

        public ResizeEventArgs(Point location, Size size, Rectangle viewport)
        {
            Location = location;
            Size = size;
            Viewport = viewport;
        }

        public Point Location { get { return location; } set { location = value; } }

        public Size Size { get { return size; } set { size = value; } }

        public Rectangle Viewport { get { return viewport; } set { viewport = value; } }

        public int X { get { return Location.X; } }

        public int Y { get { return Location.Y; } }

        public int Width { get { return Size.Width; } }

        public int Height { get { return Size.Height; } }

        public ResizeEventArgs Clone()
        {
            return new ResizeEventArgs(Location, Size, Viewport);
        }
    }
}
