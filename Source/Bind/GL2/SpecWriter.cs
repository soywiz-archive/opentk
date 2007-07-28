using System;
using System.Collections.Generic;
using System.Text;

namespace Bind.GL2
{
    class SpecWriter : ISpecWriter
    {
        #region ISpecWriter Members

        public void WriteDelegates(System.IO.StreamWriter sw,
            List<Bind.Structures.Delegate> delegates,
            Dictionary<string, string> CSTypes)
        {
            foreach (string s in CSTypes.Keys)
            {
                sw.WriteLine("    using {0} = System.{1};", s, CSTypes[s]);
            }
            sw.WriteLine();
            sw.WriteLine("    internal static class {0}", Settings.DelegatesClass);
            sw.WriteLine("    {");
            foreach (Bind.Structures.Delegate d in delegates)
            {
                sw.WriteLine("{0};", d.ToString("        "));
            }
            sw.WriteLine("    }");
        }

        public void WriteWrappers(
            System.IO.StreamWriter sw,
            List<Bind.Structures.Function> functions,
            Dictionary<string, string> CSTypes)
        {
            foreach (string s in CSTypes.Keys)
            {
                sw.WriteLine("    using {0} = System.{1};", s, CSTypes[s]);
            }
            sw.WriteLine();
            sw.WriteLine("    public static partial class {0}", Settings.GLClass);
            sw.WriteLine("    {");

            sw.WriteLine("    }");
        }

        public void WriteEnums(System.IO.StreamWriter sw, List<Bind.Structures.Enum> enums)
        {
            sw.WriteLine("        public class Enums");
            sw.WriteLine("        {");
            foreach (Bind.Structures.Enum e in enums)
            {
                sw.WriteLine("{0};", e.ToString("            "));
            }
            sw.WriteLine("        }");
        }

        #endregion
    }
}
