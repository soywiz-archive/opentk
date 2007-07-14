using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    public interface IResizable<T>
    {
        int Height { get; set; }
        int Width { get; set; }

        void Resize(ResizeEventArgs e);
        event ResizeEvent<T> ResizeNotify;
    }

    public delegate void ResizeEvent<T>(T sender, ResizeEventArgs e);
    
    public class ResizeEventArgs : EventArgs
    {
        public int Width, Height;

        public ResizeEventArgs()
        {
        }

        public ResizeEventArgs(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
