using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Compute
{
    static class Helper
    {
        public static void CheckErrorCode(ErrorCode code)
        {
            switch (code)
            {
                case ErrorCode.Success: return;
                case ErrorCode.InvalidDeviceType: throw new InvalidDeviceTypeException();
            }
        }
    }
}
