using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bind
{
    interface ISpecReader
    {
        List<Bind.Structures.Delegate> ReadFunctions(StreamReader specFile);
        Bind.Structures.EnumCollection ReadEnums(StreamReader specFile);
    }
}
