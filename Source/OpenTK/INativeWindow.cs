using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using OpenTK.Platform;
using System.ComponentModel;

namespace OpenTK
{
    public interface INativeWindow : IDisposable
    {
        Icon Icon { get; set; }
        string Title { get; set; }
        bool Focused { get; set; }
        bool Visible { get; set; }
        bool Exists { get; }
        IWindowInfo WindowInfo { get; }
        WindowState WindowState { get; set; }
        WindowBorder WindowBorder { get; set; }

        Rectangle Bounds { get; set; }
        Point Location { get; set; }
        Size Size { get; set; }
        int X { get; set; }
        int Y { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        Rectangle ClientRectangle { get; set; }
        Size ClientSize { get; set; }

        void Close();
        void ProcessEvents();
        Point PointToClient(Point point);
        Point PointToScreen(Point point);

        event EventHandler<EventArgs> Idle; 
        event EventHandler<EventArgs> Load;
        event EventHandler<EventArgs> Unload;
        event EventHandler<EventArgs> Move;
        event EventHandler<EventArgs> Resize;
        event EventHandler<CancelEventArgs> Closing;
        event EventHandler<EventArgs> Closed;
        event EventHandler<EventArgs> Disposed;

        event EventHandler<EventArgs> IconChanged;
        event EventHandler<EventArgs> TitleChanged;
        event EventHandler<EventArgs> ClientSizeChanged;
        event EventHandler<EventArgs> VisibleChanged;

        event EventHandler<EventArgs> WindowInfoChanged;

        //event EventHandler<EventArgs> MouseEnter;
        //event EventHandler<MouseEventArgs> MouseMove;
        //event EventHandler<MouseEventArgs> MouseWheel; 
        //event EventHandler<MouseEventArgs> MouseDown;
        //event EventHandler<MouseEventArgs> MouseUp;
        //event EventHandler<MouseEventArgs> MouseClick;
        //event EventHandler<MouseEventArgs> MouseDoubleClick;

        //event EventHandler<KeyEventArgs> KeyDown;
        //event EventHandler<KeyEventArgs> KeyUp;
        //event EventHandler<KeyEventArgs> KeyPress;

        //event EventHandler<DragEventArgs> DrawDrop;
        //event EventHandler<DragEventArgs> DrawEnter;
        //event EventHandler<DragEventArgs> DrawOver;
        //event EventHandler<EventArgs> DrawLeave;
    }
}
