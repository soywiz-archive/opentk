using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Compute
{
    public class InvalidDeviceTypeException : Exception
    {
        public InvalidDeviceTypeException()
            : base("The specified DeviceType is not valid.")
        { }
    }
}
