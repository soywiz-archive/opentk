using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.OpenGL
{
    public interface IGLControl
    {
        bool SetFullscreenResolution(int width, int height);
    }
}
