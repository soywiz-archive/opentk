using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using OpenTK.Platform;
using System.ComponentModel;

namespace OpenTK
{
    /// <summary>
    /// Defines the interface for a native window. 
    /// </summary>
    public interface INativeWindow : IDisposable
    {
        /// <summary>Gets or sets the <see cref="System.Drawing.Icon"/> of the window.</summary>
        Icon Icon { get; set; }
        /// <summary>Gets or sets the title of the window.</summary>
        string Title { get; set; }
        /// <summary>Gets a System.Boolean that indicates whether this window has input focus.</summary>
        bool Focused { get; }
        /// <summary>Gets or sets a System.Boolean that indicates whether the window is visible.</summary>
        bool Visible { get; set; }
        /// <summary>Gets a System.Boolean that indicates whether the window has been created and has not been destroyed.</summary>
        bool Exists { get; }
        /// <summary>Gets the <see cref="OpenTK.Platform.IWindowInfo"/> for this window.</summary>
        IWindowInfo WindowInfo { get; }
        /// <summary>Gets or sets the <see cref="OpenTK.WindowState"> for this window.</summary>
        WindowState WindowState { get; set; }
        /// <summary>Gets or sets the <see cref="OpenTK.WindowBorder"> for this window.</summary>
        WindowBorder WindowBorder { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="System.Drawing.Rectangle"/> structure the contains the external bounds of this window, in screen coordinates.
        /// External bounds include the title bar, borders and drawing area of the window.
        /// </summary>
        Rectangle Bounds { get; set; }
        /// <summary>Gets or sets a <see cref="System.Drawing.Point"> structure that contains the location of this window on the desktop.</summary>
        Point Location { get; set; }
        /// <summary>Gets or sets a <see cref="System.Drawing.Size"> structure that contains the external size of this window.</summary>
        Size Size { get; set; }
        /// <summary>Gets or sets the horizontal location of this window on the desktop.</summary>
        int X { get; set; }
        /// <summary>Gets or sets the vertical location of this window on the desktop.</summary>
        int Y { get; set; }
        /// <summary>Gets or sets the external width of this window.</summary>
        int Width { get; set; }
        /// <summary>Gets or sets the external height of this window.</summary>
        int Height { get; set; }
        /// <summary>Gets or sets a <see cref="System.Drawing.Rectangle"/> structure that contains the internal bounds of this window, in client coordinates.
        /// The internal bounds include the drawing area of the window, but exclude the titlebar and window borders.</summary>
        Rectangle ClientRectangle { get; set; }
        /// <summary>Gets or sets a <see cref="System.Drawing.Size"/> structure that contains the internal size this window.</summary>
        Size ClientSize { get; set; }

        [Obsolete]
        OpenTK.Input.IInputDriver InputDriver { get; }

        /// <summary>Closes this window. Equivalent to <see cref="INativeWindow.Dispose()"/>.</summary>
        void Close();
        /// <summary>Processes pending window events.</summary>
        void ProcessEvents();
        /// <summary>
        /// Transforms the specified point from screen to client coordinates. 
        /// </summary>
        /// <param name="point">
        /// A <see cref="System.Drawing.Point"/> to transform.
        /// </param>
        /// <returns>
        /// The transformed point.
        /// </returns>
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
