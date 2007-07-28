using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Bind.Structures;

namespace Bind
{
    #region WrapperTypes enum

    public enum WrapperTypes
    {
        /// <summary>
        /// No wrapper needed.
        /// </summary>
        None,
        /// <summary>
        /// Function takes bool parameter - C uses Int for bools, so we have to marshal.
        /// </summary>
        BoolParameter,
        /// <summary>
        /// Function takes generic parameters - add ref/out generic and generic overloads.
        /// </summary>
        GenericParameter,
        /// <summary>
        /// Function takes arrays as parameters - add ref/out and ([Out]) array overloads.
        /// </summary>
        ArrayParameter,
        /// <summary>
        /// Function with bitmask parameters. Bitmask parameters map to UInt, but since we can only use signed
        /// types (for CLS compliance), we must add the unchecked keyword.
        /// Usually found in bitmasks
        /// </summary>
        UncheckedParameter,
        /// <summary>
        /// Function that takes (in/ref/out) a naked pointer as a parameter - we pass an IntPtr.
        /// </summary>
        PointerParameter,
        /// <summary>
        /// Function returns string - needs manual marshalling through IntPtr to prevent the managed GC
        /// from freeing memory allocated on the unmanaged side (e.g. glGetString).
        /// </summary>
        StringReturnValue,
        /// <summary>
        /// Function returns a void pointer - maps to IntPtr, and the user has to manually marshal the type.
        /// </summary>
        GenericReturnValue,
        /// <summary>
        /// Function returns a typed pointer - we have to copy the data to an array to protect it from the GC.
        /// </summary>
        ArrayReturnValue
    }

    #endregion

    public static class Utilities
    {
        #region private StreamReader OpenSpecFile(string file)

        internal static StreamReader OpenSpecFile(string folder, string file)
        {
            string path = Path.Combine(folder, file);
            return new StreamReader(path);
        }

        #endregion

        #region C# keywords

        public static readonly List<string> Keywords = new List<string>(
            new string[]
            {
                "abstract", "event", "new", "struct",
                "as", "explicit", "null", "switch",
                "base", "extern", "object", "this",
                "bool", "false", "operator", "throw",
                "break", "finally", "out", "true",
                "byte", "fixed", "override", "try",
                "case", "float", "params", "typeof",
                "catch", "for", "private", "uint",
                "char", "foreach", "protected", "ulong",
                "checked", "goto", "public", "unchecked",
                "class", "if", "readonly", "unsafe",
                "const", "implicit", "ref", "ushort",
                "continue", "in", "return", "using",
                "decimal", "int", "sbyte", "virtual",
                "default", "interface", "sealed", "volatile",
                "delegate", "internal", "short", "void",
                "do", "is", "sizeof", "while",
                "double", "lock", "stackalloc",
                "else", "long", "static",
                "enum", "namespace", "string"
            }
        );

        #endregion

        /// <summary>
        /// Merges the given enum into the enum list. If an enum of the same name exists,
        /// it merges their respective constants.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static List<Bind.Structures.Enum> Merge(List<Bind.Structures.Enum> s, Bind.Structures.Enum t)
        {
            bool already_exists = false;
            foreach (Bind.Structures.Enum e in s)
            {
                if (e.Name == t.Name)
                {
                    already_exists = true;

                    foreach (Bind.Structures.Constant c in t.ConstantCollection.Values)
                    {
                        Merge(e, c);
                    }

                    break;
                }
            }

            if (!already_exists)
            {
                s.Add(t);
            }

            return s;
        }

        /// <summary>
        /// Places a new constant in the specified enum, if it doesn't already exist.
        /// The existing constant is replaced iff the new has a numeric value and the old
        /// has a reference value (eg 0x5 is preferred over AttribMask.Foo)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Bind.Structures.Enum Merge(Bind.Structures.Enum s, Bind.Structures.Constant t)
        {
            if (!s.ConstantCollection.ContainsKey(t.Name))
            {
                s.ConstantCollection.Add(t.Name, t);
            }
            else
            {
                // Tried to add a constant that already exists. If one constant
                // is like: 'Foo = 0x5' and the other like: 'Foo = Bar.Foo', then 
                // keep the first one.
                if (!Char.IsDigit(((Constant)s.ConstantCollection[t.Name]).Value[0]))
                {
                    s.ConstantCollection.Remove(t.Name);
                    s.ConstantCollection.Add(t.Name, t);
                }
            }

            return s;
        }
    }
}
