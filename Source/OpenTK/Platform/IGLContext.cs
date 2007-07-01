using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform
{
    public interface IGLContext : IDisposable
    {
        void SwapBuffers();
        void MakeCurrent();
        IntPtr GetAddress(string function);
        // List<DisplayMode> GetDisplayModes();
    }
}
