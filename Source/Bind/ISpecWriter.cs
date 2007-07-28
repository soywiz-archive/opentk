using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Bind.Structures;

namespace Bind
{
    interface ISpecWriter
    {
        void WriteDelegates(
            StreamWriter sw,
            List<Bind.Structures.Delegate> delegates,
            Dictionary<string, string> CSTypes);
        void WriteWrappers(
            StreamWriter sw,
            List<Function> functions,
            Dictionary<string, string> CSTypes);
        void WriteEnums(StreamWriter sw, List<Bind.Structures.Enum> enums);
    }
}
