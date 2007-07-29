using System;
using System.Collections.Generic;
using System.Text;
using Bind.Structures;

namespace Bind.GL2
{
    class SpecWriter : ISpecWriter
    {
        #region ISpecWriter Members

        #region void WriteDelegates

        public void WriteDelegates(
            BindStreamWriter sw,
            List<Bind.Structures.Delegate> delegates)
        {
            sw.WriteLine();
            sw.WriteLine("internal static class {0}", Settings.DelegatesClass);
            sw.WriteLine("{");

            sw.Indent();
            // Disable BeforeFieldInit and load delegates
            sw.WriteLine("static {0}()", Settings.DelegatesClass);
            sw.WriteLine("{");
            sw.Indent();
            sw.WriteLine("{0}.ReloadFunctions();", Settings.GLClass);
            sw.Unindent();
            sw.WriteLine("}");
            sw.WriteLine();
            foreach (Bind.Structures.Delegate d in delegates)
            {
                sw.WriteLine("[System.Security.SuppressUnmanagedCodeSecurity()]");
                sw.WriteLine("internal {0};", d.ToString());
                sw.WriteLine("internal static {0} gl{0};", d.Name);
            }
            sw.Unindent();

            sw.WriteLine("}");
        }

        #endregion

        #region void WriteImports

        public void WriteImports(
            BindStreamWriter sw,
            List<Bind.Structures.Delegate> delegates)
        {
            sw.WriteLine();
            sw.WriteLine("internal static class {0}", Settings.ImportsClass);
            sw.WriteLine("{");

            sw.Indent();
            sw.WriteLine("static {0}() {1} {2}", Settings.ImportsClass, "{", "}");    // Disable BeforeFieldInit
            sw.WriteLine();
            foreach (Bind.Structures.Delegate d in delegates)
            {
                sw.WriteLine("[System.Security.SuppressUnmanagedCodeSecurity()]");
                sw.WriteLine(
                    "[System.Runtime.InteropServices.DllImport({0}.Library, EntryPoint = \"gl{1}\", ExactSpelling = true)]",
                    Settings.GLClass,
                    d.Name
                );
                sw.WriteLine("internal extern static {0};", d.DeclarationString());
            }
            sw.Unindent();

            sw.WriteLine("}");
        }

        #endregion

        #region void WriteWrappers

        public void WriteWrappers(
            BindStreamWriter sw,
            List<Bind.Structures.Function> wrappers)
        {
            sw.WriteLine();
            sw.WriteLine("public static partial class {0}", Settings.GLClass);
            sw.WriteLine("{");

            sw.Indent();
            sw.WriteLine("static {0}() {1} {2}", Settings.GLClass, "{", "}");    // Disable BeforeFieldInit
            sw.WriteLine();
            foreach (Bind.Structures.Function f in wrappers)
            {
                sw.WriteLine("public static ");
                sw.Write(f);
                sw.WriteLine();
            }
            sw.Unindent();
            
            sw.WriteLine("}");
        }

        #endregion

        #region void WriteTypes

        public void WriteTypes(BindStreamWriter sw, Dictionary<string, string> CSTypes)
        {
            foreach (string s in CSTypes.Keys)
            {
                sw.WriteLine("using {0} = System.{1};", s, CSTypes[s]);
            }
        }

        #endregion

        #region void WriteEnums

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

        #endregion

        #endregion
    }
}
