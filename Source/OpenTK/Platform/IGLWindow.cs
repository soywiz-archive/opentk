using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.OpenGL;

namespace OpenTK.Platform
{
    interface IGLWindow
    {
        DisplayMode SelectDisplayMode(DisplayMode mode);
        DisplayMode SelectDisplayMode(DisplayMode mode, DisplayModeMatchOptions options);
        void SetDisplayMode(DisplayMode mode);

        void DoEvents();

        bool IsIdle { get; }
        bool Quit { get; set; }
        bool Fullscreen { get; set; }
        IGLContext Context { get; }
    }
}
