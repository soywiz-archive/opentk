#region --- License ---
/* Copyright (c) 2006, 2007 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.OpenGL;

namespace OpenTK.Platform
{
    public interface IGLWindow : IResizable<IGLWindow>, IDisposable
    {
        void ProcessEvents();

        bool IsIdle { get; }
        bool Quit { get; set; }
        bool Fullscreen { get; set; }
        IGLContext Context { get; }
    }
}
