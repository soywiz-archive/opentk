#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Input;
using OpenTK.Platform;

namespace OpenTK
{
    class InputDriver : IInputDriver
    {
        IInputDriver implementation;

        #region --- Constructors ---
        
        public InputDriver()
        {
            implementation = Platform.Factory.Default.CreateInputDriver();
        }
        
        #endregion

        #region --- IInputDriver Members ---

        public void Poll()
        {
            implementation.Poll();
        }

        #endregion

        #region --- IKeyboardDriver Members ---

        public IList<KeyboardDevice> Keyboard
        {
            get { return implementation.Keyboard; }
        }

        #endregion

        #region --- IMouseDriver Members ---

        public IList<MouseDevice> Mouse
        {
            get { return implementation.Mouse; }
        }

        #endregion

        #region --- IJoystickDriver Members ---

        public IList<JoystickDevice> Joysticks
        {
            get { return implementation.Joysticks; }
        }

        #endregion

        #region --- IDisposable Members ---

        private bool disposed;

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                    implementation.Dispose();
                }

                disposed = true;
            }
        }

        ~InputDriver()
        {
            this.Dispose(false);
        }

        #endregion
    }
}
