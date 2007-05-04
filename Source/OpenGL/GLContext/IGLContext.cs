using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.OpenGL
{
    public interface IGLContext
    {
        void SwapBuffers();
        void MakeCurrent();
        IntPtr GetAddress(string function_string);
        List<DisplayMode> GetDisplayModes();
    }
}
