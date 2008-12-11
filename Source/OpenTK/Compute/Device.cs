using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenTK.Compute
{
    public static class Device
    {
        static Dictionary<DeviceType, DeviceId[]> type_to_device_id = new Dictionary<DeviceType, DeviceId[]>();

        public static IEnumerable<DeviceId> GetDeviceIds(DeviceType deviceType)
        {
            // Check whether we have already queried this type.
            if (type_to_device_id.ContainsKey(deviceType))
                return type_to_device_id[deviceType];

            // Ensure size of the devices array.
            int num_devices;
            Helper.CheckErrorCode(GetDeviceIds(deviceType, 0, null, out num_devices));
            if (num_devices == 0)
                return new DeviceId[0];
            DeviceId[] ids = new DeviceId[num_devices];

            // Get the actual matching devices and cache the result.
            Helper.CheckErrorCode(GetDeviceIds(deviceType, ids.Length, ids, out num_devices));
            type_to_device_id[deviceType] = ids;

            return ids;
        }

        [DllImport("opencl.dll"), SuppressUnmanagedCodeSecurity]
        static extern ErrorCode GetDeviceIds(DeviceType deviceType, int numEntries, [Out] DeviceId[] devices, out int numDevices);
    }
}
