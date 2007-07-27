using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bind
{
    interface ISpecWriter
    {
        void WriteDelegates(StreamWriter sw);
        void WriteWrappers(StreamWriter sw);
        void WriteEnums(StreamWriter sw);
    }
}
