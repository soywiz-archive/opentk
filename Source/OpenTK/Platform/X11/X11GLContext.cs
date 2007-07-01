using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.X11
{
    class X11GLContext : IGLContext
    {

        #region IGLContext Members

        public void SwapBuffers()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void MakeCurrent()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public IntPtr GetAddress(string function)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
