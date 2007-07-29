using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Bind.Structures;

namespace Bind
{
    interface ISpecWriter
    {
        void WriteDelegates(BindStreamWriter sw, List<Bind.Structures.Delegate> delegates);
        void WriteWrappers(BindStreamWriter sw, List<Function> functions);
        void WriteEnums(BindStreamWriter sw, EnumCollection enums);
        void WriteTypes(BindStreamWriter sw, Dictionary<string, string> CSTypes);
    }
}
