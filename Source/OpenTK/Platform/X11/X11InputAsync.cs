#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    sealed class X11InputAsync : IInputDriver
    {
        #region Fields

        readonly IList<KeyboardDevice> keyboard_list;
        readonly IList<MouseDevice> mouse_list;
        readonly X11Joystick joystick_driver = new X11Joystick();

        readonly byte[] key_states = new byte[256];
        readonly X11KeyMap key_map = new X11KeyMap();

        bool disposed;

        #endregion

        #region Constructors

        public X11InputAsync()
        {
            KeyboardDevice keyboard = new KeyboardDevice();
            keyboard.Description = "Default X11 keyboard.";
            List<KeyboardDevice> klist = new List<KeyboardDevice>();
            klist.Add(keyboard);
            keyboard_list = klist.AsReadOnly();

            MouseDevice mouse = new MouseDevice();
            keyboard.Description = "Default X11 mouse.";
            List<MouseDevice> mlist = new List<MouseDevice>();
            mlist.Add(mouse);
            mouse_list = mlist.AsReadOnly();
        }

        #endregion
        
        #region IInputDriver Members

        public void Poll()
        {

        }

        #endregion

        #region IKeyboardDriver Members

        public IList<KeyboardDevice> Keyboard
        {
            get { return keyboard_list; }
        }

        #endregion

        #region IMouseDriver Members

        public IList<MouseDevice> Mouse
        {
            get { return mouse_list; }
        }

        #endregion

        #region IJoystickDriver Members

        public IList<JoystickDevice> Joysticks
        {
            get { return joystick_driver.Joysticks; }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                    joystick_driver.Dispose();
                }
                disposed = true;
            }
        }

        #endregion
    }
}
