using System;
using System.Collections.Generic;
using System.Text;
using Bind.Structures;

namespace Bind.GL2
{
    class SpecWriter : ISpecWriter
    {
        #region ISpecWriter Members

        public void WriteDelegates(
            BindStreamWriter sw,
            List<Bind.Structures.Delegate> delegates)
        {
            sw.WriteLine();
            sw.WriteLine("internal static class {0}", Settings.DelegatesClass);
            sw.WriteLine("{");

            sw.Indent();
            foreach (Bind.Structures.Delegate d in delegates)
            {
                sw.WriteLine("internal {0};", d.ToString());
            }
            sw.Unindent();

            sw.WriteLine("}");
        }

        public void WriteWrappers(
            BindStreamWriter sw,
            List<Bind.Structures.Function> wrappers)
        {
            sw.WriteLine("public static partial class {0}", Settings.GLClass);
            sw.WriteLine("{");

            sw.Indent();
            foreach (Bind.Structures.Function f in wrappers)
            {
                sw.WriteLine("public static ");
                sw.Write(f);
                sw.WriteLine();
            }
            sw.Unindent();
            
            sw.WriteLine("}");
        }

        public void WriteEnums(BindStreamWriter sw, EnumCollection enums)
        {
            sw.WriteLine("public class Enums");
            sw.WriteLine("{");

            sw.Indent();
            foreach (Bind.Structures.Enum @enum in enums.Values)
            {
                sw.Write(@enum);
                sw.WriteLine();
            }
            sw.Unindent();

            sw.WriteLine("}");
        }

        public void WriteImports(
            BindStreamWriter sw,
            List<Bind.Structures.Delegate> delegates)
        {
            sw.WriteLine();
            sw.WriteLine("internal static class {0}", Settings.ImportsClass);
            sw.WriteLine("{");

            sw.Indent();
            foreach (Bind.Structures.Delegate d in delegates)
            {
                sw.WriteLine("{0};", d.ToString());
                sw.WriteLine("internal static {0} gl{0};", d.Name);
            }
            sw.Unindent();

            sw.WriteLine("}");
        }

        public void WriteTypes(BindStreamWriter sw, Dictionary<string, string> CSTypes)
        {
            foreach (string s in CSTypes.Keys)
            {
                sw.WriteLine("using {0} = System.{1};", s, CSTypes[s]);
            }
        }

        #endregion
    }
}
