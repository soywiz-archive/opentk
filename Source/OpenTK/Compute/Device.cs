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
using System.Text;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenTK.Compute
{
    using cl_device_id = Handle<Device>;

    public sealed class Device
    {
        public readonly Handle<Device> Handle;

        static Dictionary<DeviceType, cl_device_id[]> type_to_device_id = new Dictionary<DeviceType, cl_device_id[]>();

        public static IEnumerable<cl_device_id> Getcl_device_ids(DeviceType deviceType)
        {
            // Check whether we have already queried this type.
            if (type_to_device_id.ContainsKey(deviceType))
                return type_to_device_id[deviceType];

            // Ensure size of the devices array.
            int num_devices;
            Helper.CheckErrorCode(CL.Getcl_device_ids(deviceType, 0, null, out num_devices));
            if (num_devices == 0)
                return new cl_device_id[0];
            cl_device_id[] ids = new cl_device_id[num_devices];

            // Get the actual matching devices and cache the result.
            Helper.CheckErrorCode(CL.Getcl_device_ids(deviceType, ids.Length, ids, out num_devices));
            type_to_device_id[deviceType] = ids;

            return ids;
        }
    }

    #region Flat API

    partial class CL
    {
        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clGetDeviceIDs"), SuppressUnmanagedCodeSecurity]
        public static extern ErrorCode Getcl_device_ids(DeviceType deviceType,
            int numEntries,
            [Out] cl_device_id[] devices,
            out int numDevices);

        // OpenCL 1.0
        [DllImport(Configuration.Library, EntryPoint = "clGetDeviceInfo"), SuppressUnmanagedCodeSecurity]
        public static extern int GetDeviceInfo(cl_device_id device,
            DeviceInfo param_name,
            IntPtr param_value_size,
            IntPtr param_value,
            out IntPtr param_value_size_ret);
    }

    #endregion
}
