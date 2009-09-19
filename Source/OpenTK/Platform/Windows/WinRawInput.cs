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
using Microsoft.Win32;
using OpenTK.Input;

namespace OpenTK.Platform.Windows
{
    // Todo: see if this is necessary with the new keyboard API.
    sealed class WinRawInput : WinGLNative, IInputDriver
    {
        #region Fields

        RawInput data = new RawInput(); // Input event data.
        int device_count; // The total number of input devices connected to this system.
        
        List<KeyboardDevice> keyboards;
        List<MouseDevice> mice;

        IList<KeyboardDevice> keyboards_readonly;
        IList<MouseDevice> mice_readonly;

        #endregion

        #region Constructors

        internal WinRawInput()
            : base(0, 0, 1, 1, "", GameWindowFlags.Default, DisplayDevice.Default, true)
        {
            Debug.WriteLine("Initalizing windows raw input driver.");
            Debug.Indent();

            keyboards = UpdateKeyboardList();
            mice = UpdateMouseList();

            keyboards_readonly = keyboards.AsReadOnly();
            mice_readonly = mice.AsReadOnly();

            Debug.Unindent();

            MessageReceived += MessageReceivedHandler;
        }

        #endregion

        #region Private Members

        #region DeviceCount

        int DeviceCount
        {
            get
            {
                Functions.GetRawInputDeviceList(null, ref device_count, API.RawInputDeviceListSize);
                return device_count;
            }
        }

        #endregion

        #region WindowProcedure

        // Processes the input Windows Message, routing the buffer to the correct Keyboard, Mouse or HID.
        void MessageReceivedHandler(object sender, ref MessageArgs e)
        {
            switch (e.Message.Message)
            {
                case WindowMessage.INPUT:
                    int size = 0;
                    // Get the size of the input buffer
                    Functions.GetRawInputData(e.Message.LParam, GetRawInputDataEnum.INPUT,
                        IntPtr.Zero, ref size, API.RawInputHeaderSize);

                    if (Functions.GetRawInputData(e.Message.LParam, GetRawInputDataEnum.INPUT,
                        out data, ref size, API.RawInputHeaderSize) == size)
                    {
                        switch (data.Header.Type)
                        {
                            case RawInputDeviceType.KEYBOARD:
                                if (!ProcessKeyboardEvent(data))
                                    Functions.DefRawInputProc(ref data, 1, (uint)API.RawInputHeaderSize);
                                e.ReturnValue = IntPtr.Zero;
                                break;

                            case RawInputDeviceType.MOUSE:
                                if (!ProcessMouseEvent(data))
                                    Functions.DefRawInputProc(ref data, 1, (uint)API.RawInputHeaderSize);
                                e.ReturnValue = IntPtr.Zero;
                                break;

                            case RawInputDeviceType.HID:
                                Functions.DefRawInputProc(ref data, 1, (uint)API.RawInputHeaderSize);
                                e.ReturnValue = IntPtr.Zero;
                                break;

                            default:
                                break;
                        }
                    }
                    else
                    {
                        throw new ApplicationException(String.Format(
                            "GetRawInputData returned invalid buffer. Windows error {0}. Please file a bug at http://opentk.sourceforge.net",
                            Marshal.GetLastWin32Error()));
                    }
                    break;

                case WindowMessage.DESTROY:
                    //Debug.Print("Input window detached from parent {0}.", Handle);
                    //ReleaseHandle();
                    break;

                case WindowMessage.QUIT:
                    Debug.WriteLine("Input window quit.");
                    this.Dispose();
                    break;
            }

            //base.WndProc(ref msg);
            //e.ReturnValue = base.WindowProcedure(handle, message, wParam, lParam);
        }

        #endregion

        #region UpdateMouseList

        List<MouseDevice> UpdateMouseList()
        {
            List<MouseDevice> mice = new List<MouseDevice>();
            int count = DeviceCount;
            RawInputDeviceList[] ridl = new RawInputDeviceList[count];
            for (int i = 0; i < count; i++)
                ridl[i] = new RawInputDeviceList();
            Functions.GetRawInputDeviceList(ridl, ref count, API.RawInputDeviceListSize);

            // Discover mouse devices:
            for (int i = 0; i < count; i++)
            {
                uint size = 0;
                Functions.GetRawInputDeviceInfo(ridl[i].Device, RawInputDeviceInfoEnum.DEVICENAME, IntPtr.Zero, ref size);
                IntPtr name_ptr = Marshal.AllocHGlobal((IntPtr)size);
                Functions.GetRawInputDeviceInfo(ridl[i].Device, RawInputDeviceInfoEnum.DEVICENAME, name_ptr, ref size);
                string name = Marshal.PtrToStringAnsi(name_ptr);
                Marshal.FreeHGlobal(name_ptr);

                if (name.ToLower().Contains("root"))
                {
                    // This is a terminal services device, skip it.
                    continue;
                }
                else if (ridl[i].Type == RawInputDeviceType.MOUSE || ridl[i].Type == RawInputDeviceType.HID)
                {
                    // This is a mouse or a USB mouse device. In the latter case, discover if it really is a
                    // mouse device by qeurying the registry.

                    // remove the \??\
                    name = name.Substring(4);

                    string[] split = name.Split('#');

                    string id_01 = split[0];    // ACPI (Class code)
                    string id_02 = split[1];    // PNP0303 (SubClass code)
                    string id_03 = split[2];    // 3&13c0b0c5&0 (Protocol code)
                    // The final part is the class GUID and is not needed here

                    string findme = string.Format(
                        @"System\CurrentControlSet\Enum\{0}\{1}\{2}",
                        id_01, id_02, id_03);

                    RegistryKey regkey = Registry.LocalMachine.OpenSubKey(findme);

                    string deviceDesc = (string)regkey.GetValue("DeviceDesc");
                    deviceDesc = deviceDesc.Substring(deviceDesc.LastIndexOf(';') + 1);
                    string deviceClass = (string)regkey.GetValue("Class");

                    if (!String.IsNullOrEmpty(deviceClass) && deviceClass.ToLower().Equals("mouse"))
                    {
                        OpenTK.Input.MouseDevice mouse = new OpenTK.Input.MouseDevice();
                        mouse.Description = deviceDesc;

                        // Register the keyboard:
                        RawInputDeviceInfo info = new RawInputDeviceInfo();
                        int devInfoSize = API.RawInputDeviceInfoSize;
                        Functions.GetRawInputDeviceInfo(ridl[i].Device, RawInputDeviceInfoEnum.DEVICEINFO,
                                info, ref devInfoSize);

                        mouse.NumberOfButtons = info.Device.Mouse.NumberOfButtons;
                        mouse.NumberOfWheels = info.Device.Mouse.HasHorizontalWheel ? 1 : 0;

                        mouse.DeviceID = ridl[i].Device;//(IntPtr)info.Device.Mouse.Id;

                        RegisterMouseDevice(mouse);
                        mice.Add(mouse);
                    }
                }
            }

            return mice;
        }

        #endregion

        #region RegisterMouseDevice

        void RegisterMouseDevice(OpenTK.Input.MouseDevice mouse)
        {
            RawInputDevice[] rid = new RawInputDevice[1];
            // Mouse is 1/2 (page/id). See http://www.microsoft.com/whdc/device/input/HID_HWID.mspx
            rid[0] = new RawInputDevice();
            rid[0].UsagePage = 1;
            rid[0].Usage = 2;
            rid[0].Flags = RawInputDeviceFlags.INPUTSINK;
            rid[0].Target = (WindowInfo as WinWindowInfo).WindowHandle;

            if (!Functions.RegisterRawInputDevices(rid, 1, API.RawInputDeviceSize))
            {
                throw new ApplicationException(
                    String.Format(
                        "Raw input registration failed with error: {0}. Device: {1}",
                        Marshal.GetLastWin32Error(),
                        rid[0].ToString())
                );
            }
            else
            {
                Debug.Print("Registered mouse {0}", mouse.ToString());
                System.Drawing.Point p = new System.Drawing.Point();
                if (Functions.GetCursorPos(ref p))
                    mouse.Position = p;
            }
        }

        #endregion

        #region ProcessMouseEvent

        internal bool ProcessMouseEvent(RawInput rin)
        {
            MouseDevice mouse;
            if (Mouse.Count > 0) mouse = Mouse[0];
            else return false;

            switch (rin.Header.Type)
            {
                case RawInputDeviceType.MOUSE:
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.LEFT_BUTTON_DOWN) != 0) mouse[MouseButton.Left] = true;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.LEFT_BUTTON_UP) != 0) mouse[MouseButton.Left] = false;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.RIGHT_BUTTON_DOWN) != 0) mouse[MouseButton.Right] = true;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.RIGHT_BUTTON_UP) != 0) mouse[MouseButton.Right] = false;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.MIDDLE_BUTTON_DOWN) != 0) mouse[MouseButton.Middle] = true;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.MIDDLE_BUTTON_UP) != 0) mouse[MouseButton.Middle] = false;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.BUTTON_4_DOWN) != 0) mouse[MouseButton.Button1] = true;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.BUTTON_4_UP) != 0) mouse[MouseButton.Button1] = false;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.BUTTON_5_DOWN) != 0) mouse[MouseButton.Button2] = true;
                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.BUTTON_5_UP) != 0) mouse[MouseButton.Button2] = false;

                    if ((rin.Data.Mouse.ButtonFlags & RawInputMouseState.WHEEL) != 0)
                        mouse.Wheel += (short)rin.Data.Mouse.ButtonData / 120;

                    if ((rin.Data.Mouse.Flags & RawMouseFlags.MOUSE_MOVE_ABSOLUTE) != 0)
                    {
                        mouse.Position = new System.Drawing.Point(rin.Data.Mouse.LastX, rin.Data.Mouse.LastY);
                    }
                    else
                    {   // Seems like MOUSE_MOVE_RELATIVE is the default, unless otherwise noted.
                        mouse.Position = new System.Drawing.Point(mouse.X + rin.Data.Mouse.LastX,
                                                                  mouse.Y + rin.Data.Mouse.LastY);
                    }

                    if ((rin.Data.Mouse.Flags & RawMouseFlags.MOUSE_VIRTUAL_DESKTOP) != 0)
                        Debug.WriteLine(String.Format("Mouse {0} defines MOUSE_VIRTUAL_DESKTOP flag, please report at http://www.opentk.com", mouse.ToString()));

                    return true;

                default:
                    throw new ApplicationException("WinRawMouse driver received invalid data.");
            }
        }

        #endregion

        #region UpdateKeyboardList

        List<KeyboardDevice> UpdateKeyboardList()
        {
            List<KeyboardDevice> keyboards = new List<KeyboardDevice>();
            int count = DeviceCount;
            RawInputDeviceList[] ridl = new RawInputDeviceList[count];
            for (int i = 0; i < count; i++)
                ridl[i] = new RawInputDeviceList();
            Functions.GetRawInputDeviceList(ridl, ref count, API.RawInputDeviceListSize);

            // Discover keyboard devices:
            for (int i = 0; i < count; i++)
            {
                uint size = 0;
                Functions.GetRawInputDeviceInfo(ridl[i].Device, RawInputDeviceInfoEnum.DEVICENAME, IntPtr.Zero, ref size);
                IntPtr name_ptr = Marshal.AllocHGlobal((IntPtr)size);
                Functions.GetRawInputDeviceInfo(ridl[i].Device, RawInputDeviceInfoEnum.DEVICENAME, name_ptr, ref size);
                string name = Marshal.PtrToStringAnsi(name_ptr);
                Marshal.FreeHGlobal(name_ptr);
                if (name.ToLower().Contains("root"))
                {
                    // This is a terminal services device, skip it.
                    continue;
                }
                else if (ridl[i].Type == RawInputDeviceType.KEYBOARD || ridl[i].Type == RawInputDeviceType.HID)
                {
                    // This is a keyboard or USB keyboard device. In the latter case, discover if it really is a
                    // keyboard device by qeurying the registry.

                    // remove the \??\
                    name = name.Substring(4);

                    string[] split = name.Split('#');

                    string id_01 = split[0];    // ACPI (Class code)
                    string id_02 = split[1];    // PNP0303 (SubClass code)
                    string id_03 = split[2];    // 3&13c0b0c5&0 (Protocol code)
                    // The final part is the class GUID and is not needed here

                    string findme = string.Format(
                        @"System\CurrentControlSet\Enum\{0}\{1}\{2}",
                        id_01, id_02, id_03);

                    RegistryKey regkey = Registry.LocalMachine.OpenSubKey(findme);

                    string deviceDesc =
                        (string)regkey.GetValue("DeviceDesc");
                    string deviceClass =
                        (string)regkey.GetValue("Class");
                    if (!String.IsNullOrEmpty(deviceClass) && deviceClass.ToLower().Equals("keyboard"))
                    {
                        KeyboardDevice kb = new KeyboardDevice();
                        kb.Description = deviceDesc;

                        // Register the keyboard:
                        RawInputDeviceInfo info = new RawInputDeviceInfo();
                        int devInfoSize = API.RawInputDeviceInfoSize;
                        Functions.GetRawInputDeviceInfo(ridl[i].Device, RawInputDeviceInfoEnum.DEVICEINFO,
                                info, ref devInfoSize);

                        kb.NumberOfLeds = info.Device.Keyboard.NumberOfIndicators;
                        kb.NumberOfFunctionKeys = info.Device.Keyboard.NumberOfFunctionKeys;
                        kb.NumberOfKeys = info.Device.Keyboard.NumberOfKeysTotal;
                        //kb.DeviceID = (info.Device.Keyboard.Type << 32) + info.Device.Keyboard.SubType;
                        kb.DeviceID = ridl[i].Device;

                        //if (!keyboards.Contains(kb))
                        //{
                        this.RegisterKeyboardDevice(kb);
                        keyboards.Add(kb);
                        //}
                    }
                }
            }

            return keyboards;
        }

        #endregion

        #region RegisterKeyboardDevice

        void RegisterKeyboardDevice(KeyboardDevice kb)
        {
            RawInputDevice[] rid = new RawInputDevice[1];
            // Keyboard is 1/6 (page/id). See http://www.microsoft.com/whdc/device/input/HID_HWID.mspx
            rid[0] = new RawInputDevice();
            rid[0].UsagePage = 1;
            rid[0].Usage = 6;
            rid[0].Flags = RawInputDeviceFlags.INPUTSINK;
            rid[0].Target = (WindowInfo as WinWindowInfo).WindowHandle;

            if (!Functions.RegisterRawInputDevices(rid, 1, API.RawInputDeviceSize))
            {
                throw new ApplicationException(
                    String.Format(
                        "Raw input registration failed with error: {0}. Device: {1}",
                        Marshal.GetLastWin32Error(),
                        rid[0].ToString())
                );
            }
            else
            {
                Debug.Print("Registered keyboard {0}", kb.ToString());
            }
        }

        #endregion

        #region ProcessKeyboardEvent

        /// <summary>
        /// Processes raw input events.
        /// </summary>
        /// <param name="rin"></param>
        /// <returns></returns>
        internal bool ProcessKeyboardEvent(RawInput rin)
        {
            //Keyboard key = keyboards[0];
            //rin.Header.Device;
            switch (rin.Header.Type)
            {
                case RawInputDeviceType.KEYBOARD:
                    bool pressed =
                        rin.Data.Keyboard.Message == (int)WindowMessage.KEYDOWN ||
                        rin.Data.Keyboard.Message == (int)WindowMessage.SYSKEYDOWN;

                    // Find the device where the button was pressed. It can be that the input notification
                    // came not from a physical keyboard device but from a code-generated input message - in
                    // that case, the event goes to the default (first) keyboard.
                    // TODO: Send the event to all keyboards instead of the default one.
                    // TODO: Optimize this! The predicate allocates way to much memory.
                    //int index = keyboards.FindIndex(delegate(KeyboardDevice kb)
                    //{
                    //    return kb.DeviceID == rin.Header.Device;
                    //});
                    //if (index == -1) index = 0;
                    int index;
                    if (Keyboard.Count > 0) index = 0;
                    else return false;

                    // Generic control, shift, alt keys may be sent instead of left/right.
                    // It seems you have to explicitly register left/right events.
                    switch (rin.Data.Keyboard.VKey)
                    {
                        case VirtualKeys.SHIFT:
                            Keyboard[index][Input.Key.ShiftLeft] = Keyboard[index][Input.Key.ShiftRight] = pressed;
                            return true;

                        case VirtualKeys.CONTROL:
                            Keyboard[index][Input.Key.ControlLeft] = Keyboard[index][Input.Key.ControlRight] = pressed;
                            return true;

                        case VirtualKeys.MENU:
                            Keyboard[index][Input.Key.AltLeft] = Keyboard[index][Input.Key.AltRight] = pressed;
                            return true;

                        default:
                            if (!WMInput.KeyMap.ContainsKey(rin.Data.Keyboard.VKey))
                            {
                                Debug.Print("Virtual key {0} ({1}) not mapped.",
                                            rin.Data.Keyboard.VKey, (int)rin.Data.Keyboard.VKey);
                            }
                            else
                            {
                                Key key = WMInput.KeyMap[rin.Data.Keyboard.VKey];
                                Keyboard[index][key] = pressed;
                            }

                            return false;
                    }

                default:
                    throw new ApplicationException("Windows raw keyboard driver received invalid data.");
            }
        }

        #endregion

        #endregion

        #region IInputDriver Members

        public override void Poll()
        {
            ProcessEvents();
            base.Poll();

            return;
#if false
            // We will do a buffered read for all input devices and route the RawInput structures
            // to the correct 'ProcessData' handlers. First, we need to find out the size of the
            // buffer to allocate for the structures. Then we allocate the buffer and read the
            // structures, calling the correct handler for each one. Last, we free the allocated
            // buffer.
            int size = 0;
            Functions.GetRawInputBuffer(IntPtr.Zero, ref size, API.RawInputHeaderSize);
            size *= 256;
            IntPtr rin_data = Marshal.AllocHGlobal(size);

            while (true)
            {
                // Iterate reading all available RawInput structures and routing them to their respective
                // handlers.
                int num = Functions.GetRawInputBuffer(rin_data, ref size, API.RawInputHeaderSize);
                if (num == 0)
                    break;
                else if (num < 0)
                {
                    /*int error = Marshal.GetLastWin32Error();
                    if (error == 122)
                    {
                        // Enlarge the buffer, it was too small.
                        AllocateBuffer();
                    }
                    else
                    {
                        throw new ApplicationException(String.Format(
                            "GetRawInputBuffer failed with code: {0}", error));
                    }*/
                    Debug.Print("GetRawInputBuffer failed with code: {0}", Marshal.GetLastWin32Error());
                    //AllocateBuffer();
                    break;
                }

                RawInput[] rin_structs = new RawInput[num];
                IntPtr next_rin = rin_data;
                for (int i = 0; i < num; i++)
                {
                    rin_structs[i] = (RawInput)Marshal.PtrToStructure(next_rin, typeof(RawInput));

                    switch (rin_structs[i].Header.Type)
                    {
                        case RawInputDeviceType.KEYBOARD:
                            keyboardDriver.ProcessKeyboardEvent(rin_structs[i]);
                            break;

                        case RawInputDeviceType.MOUSE:
                            mouseDriver.ProcessEvent(rin_structs[i]);
                            break;
                    }

                    next_rin = Functions.NextRawInputStructure(next_rin);
                }
                Functions.DefRawInputProc(rin_structs, num, (uint)API.RawInputHeaderSize);
            }

            Marshal.FreeHGlobal(rin_data);
#endif
        }

        public override IList<KeyboardDevice> Keyboard
        {
            get { return keyboards_readonly; }
        }

        public override IList<MouseDevice> Mouse
        {
            get { return mice_readonly; }
        }

        public override IList<JoystickDevice> Joysticks
        {
            get
            {
                return base.Joysticks;
            }
        }

        #endregion
    }
}
