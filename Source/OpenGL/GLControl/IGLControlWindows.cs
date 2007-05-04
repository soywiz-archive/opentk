using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.OpenGL
{
    class IGLControlWindows : IGLControl
    {
        /*
        public IGLControlWindows()
        {
        }
        */
        #region --- IGLControl Members ---

        #region public bool SetFullscreenResolution(int width, int height)

        public bool SetFullscreenResolution(int width, int height)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #endregion
    }
}
