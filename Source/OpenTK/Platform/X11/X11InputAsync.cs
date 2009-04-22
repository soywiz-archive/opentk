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
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    sealed class X11InputAsync : IInputDriver
    {
        #region Fields

        readonly IList<KeyboardDevice> keyboard_list;
        readonly IList<MouseDevice> mouse_list;
        readonly X11Joystick joystick_driver = new X11Joystick();

        // Bitfield of key states (see http://tronche.com/gui/x/xlib/input/XQueryKeymap.html)
        readonly byte[] key_states = new byte[32];
        readonly X11KeyMap key_map = new X11KeyMap();

        readonly Dictionary<XKey, byte> symbol_map;
        readonly XKey[] reverse_symbol_map;

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

            GetKeyboardMap(out symbol_map, out reverse_symbol_map);
        }

        #endregion

        #region Private Members

        static void GetKeyboardMap(out Dictionary<XKey, byte> symbolMap, out XKey[] revSymbolMap)
        {
            int minkey, maxkey;
            API.DisplayKeycodes(API.DefaultDisplay, out minkey, out maxkey);
            
            int keysyms_per_keycode;
            int count = maxkey - minkey + 1;
            IntPtr kmap_ptr = API.GetKeyboardMapping(API.DefaultDisplay, (byte)minkey, count, out keysyms_per_keycode);
            int[] kmap = new int[keysyms_per_keycode * count];
            Marshal.Copy(kmap_ptr, kmap, 0, count * keysyms_per_keycode); 
            Functions.XFree(kmap_ptr);
            
            symbolMap = new Dictionary<XKey, byte>();
            revSymbolMap = new XKey[256];

            for (int i = 0; i < count * keysyms_per_keycode; i++)
            {
                byte keyCode = (byte)(i / keysyms_per_keycode + minkey);
                int keySym = kmap[i];
                if(keySym == 0)
                    continue;
                if ((System.Enum.IsDefined(typeof(XKey), keySym)))
                {
                    XKey symbol = (XKey)keySym;
                    if (!symbolMap.ContainsKey(symbol))
                        symbolMap[symbol] = keyCode;
                if (revSymbolMap[keyCode] == 0)
                   revSymbolMap[keyCode] = symbol;
                }
            }
            
            foreach(XKey sym in Enum.GetValues(typeof(XKey)))
                if (!symbolMap.ContainsKey(sym))
                    symbolMap[sym] = 0;
        }

                
        #endregion
        
        #region IInputDriver Members

        public void Poll()
        {
            joystick_driver.Poll();

            Functions.XQueryKeymap(API.DefaultDisplay, key_states);
            foreach (XKey key in Enum.GetValues(typeof(XKey)))
            {
                if (!key_map.ContainsKey(key))
                    continue;

                byte code = symbol_map[key];
                Key opentk_key = key_map[key];

                // Each key code is a *bit* offset in the key_states array.
                // First we take the byte that contains the desired bit (byte = key_states[code >> 3])
                // Then we isolated the desired bit by and-ing with the desired offset (byte & (1 << (code % 8))
                Keyboard[0][opentk_key] = (key_states[(code >> 3)] & (1 << (code % 8))) != 0;
            }
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
