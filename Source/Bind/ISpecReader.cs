using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bind
{
    interface ISpecReader
    {
        List<Bind.Structures.Delegate> ReadFunctions(StreamReader specFile);
        List<Bind.Structures.Enum> ReadEnums(StreamReader specFile);
    }
}
