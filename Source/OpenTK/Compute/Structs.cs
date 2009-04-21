using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Compute
{
    public struct DeviceId : IEquatable<DeviceId>
    {
        readonly IntPtr Handle;

        internal DeviceId(IntPtr handle)
        {
            Handle = handle;
        }

        #region IEquatable<DeviceId> Members

        public bool Equals(DeviceId instance)
        {
            return Handle == instance.Handle;
        }
        
        #endregion
    }

    public struct Context
    {
        IntPtr handle;
    }

    public struct CommandQueue
    {
        IntPtr handle;
    }

    public struct Memory
    {
        IntPtr handle;
    }

    public struct Program
    {
        IntPtr handle;
    }

    public struct Kernel
    {
        IntPtr handle;
    }

    public struct Event
    {
        IntPtr handle;
    }

    public struct Sampler
    {
        IntPtr handle;
    }
}
