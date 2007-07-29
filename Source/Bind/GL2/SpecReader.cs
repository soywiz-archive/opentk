using System;
using System.Collections.Generic;
using System.Text;
using Bind.Structures;
using System.Diagnostics;

namespace Bind.GL2
{
    class SpecReader : ISpecReader
    {
        #region private string NextValidLine(StreamReader sr)

        private string NextValidLine(System.IO.StreamReader sr)
        {
            string line;

            do
            {
                if (sr.EndOfStream)
                    return null;

                line = sr.ReadLine().Trim();

                if (String.IsNullOrEmpty(line) ||
                    line.StartsWith("#") ||                 // Disregard comments.
                    line.StartsWith("passthru") ||          // Disregard passthru statements.
                    line.StartsWith("required-props:") ||
                    line.StartsWith("param:") ||
                    line.StartsWith("dlflags:") ||
                    line.StartsWith("glxflags:") ||
                    line.StartsWith("vectorequiv:") ||
                    //line.StartsWith("category:") ||
                    line.StartsWith("version:") ||
                    line.StartsWith("glxsingle:") ||
                    line.StartsWith("glxropcode:") ||
                    line.StartsWith("glxvendorpriv:") ||
                    line.StartsWith("glsflags:") ||
                    line.StartsWith("glsopcode:") ||
                    line.StartsWith("glsalias:") ||
                    line.StartsWith("wglflags:") ||
                    line.StartsWith("extension:") ||
                    line.StartsWith("alias:") ||
                    line.StartsWith("offset:"))
                    continue;

                return line;
            }
            while (true);
        }

        #endregion

        #region private static bool IsExtension(string function)

        private static bool IsExtension(string function)
        {
            return (function.EndsWith("ARB") ||
                    function.EndsWith("EXT") ||
                    function.EndsWith("ATI") ||
                    function.EndsWith("NV") ||
                    function.EndsWith("SUN") ||
                    function.EndsWith("SUNX") ||
                    function.EndsWith("SGI") ||
                    function.EndsWith("SGIS") ||
                    function.EndsWith("SGIX") ||
                    function.EndsWith("MESA") ||
                    function.EndsWith("3DFX") ||
                    function.EndsWith("IBM") ||
                    function.EndsWith("GREMEDY") ||
                    function.EndsWith("HP") ||
                    function.EndsWith("INTEL") ||
                    function.EndsWith("PGI") ||
                    function.EndsWith("INGR") ||
                    function.EndsWith("APPLE") ||
                    function.EndsWith("OML") ||
                    function.EndsWith("I3D"));
        }

        #endregion

        #region --- ISpecReader Members ---

        #region public List<Function> ReadFunctions(System.IO.StreamReader specFile)

        public List<Bind.Structures.Delegate> ReadFunctions(System.IO.StreamReader specFile)
        {
            Console.WriteLine("Reading function specs.");

            List<Bind.Structures.Delegate> delegates = new List<Bind.Structures.Delegate>();

            do
            {
                string line = NextValidLine(specFile);
                if (String.IsNullOrEmpty(line))
                    break;

                while (line.Contains("(") && !specFile.EndOfStream)
                {
                    // Get next OpenGL function

                    Bind.Structures.Delegate d = new Bind.Structures.Delegate();

                    // Get function name:
                    d.Name = line.Split(Utilities.Separators, StringSplitOptions.RemoveEmptyEntries)[0];
                    d.Extension = IsExtension(d.Name);

                    do
                    {
                        // Get function parameters and return value

                        line = specFile.ReadLine();
                        List<string> words = new List<string>(
                            line.Replace('\t', ' ').Split(Utilities.Separators, StringSplitOptions.RemoveEmptyEntries)
                        );

                        if (words.Count == 0)
                            break;

                        // Identify line:
                        switch (words[0])
                        {
                            case "return":  // Line denotes return value
                                d.ReturnType.Type = words[1];
                                break;

                            case "param":   // Line denotes parameter
                                Parameter p = new Parameter();
                                WrapperTypes wrapper;
                                string type;

                                p.Name = words[1];
                                p.Type = words[2];
                                p.IsPointer = words[4] == "array" ? true : false;
                                p.Flow = words[3] == "in" ? Parameter.FlowDirection.In : Parameter.FlowDirection.Out;

                                d.Parameters.Add(p);
                                break;

                            // Version directive is not used. GetTexParameterIivEXT and GetTexParameterIuivEXT define two(!) versions (why?)
                            //case "version": // Line denotes function version (i.e. 1.0, 1.2, 1.5)
                            //    d.UserData.Add("version", words[1]);
                            //    break;

                            case "category":
                                d.Category = words[1];
                                break;
                        }
                    }
                    while (!specFile.EndOfStream);

                    delegates.Add(d);
                }
            }
            while (!specFile.EndOfStream);

            return delegates;
        }

        #endregion

        #region public EnumCollection ReadEnums(System.IO.StreamReader specFile)

        public EnumCollection ReadEnums(System.IO.StreamReader specfile)
        {
            EnumCollection enums = new EnumCollection();

            // complete_enum contains all opengl enumerants.
            Bind.Structures.Enum complete_enum = new Bind.Structures.Enum();
            complete_enum.Name = "GLenum";

            Trace.WriteLine(String.Format("Reading opengl enumerant specs"));
            Trace.Indent();

            do
            {
                string line = NextValidLine(specfile);
                if (String.IsNullOrEmpty(line))
                    break;

                line = line.Replace('\t', ' ');

                // We just encountered the start of a new enumerant:
                while (!String.IsNullOrEmpty(line) && line.Contains("enum"))
                {
                    string[] words = line.Split(Utilities.Separators, StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length == 0)
                        continue;

                    // Declare a new enumerant
                    Bind.Structures.Enum e = new Bind.Structures.Enum();
                    e.Name = Char.IsDigit(words[0][0]) ? "GL_" + words[0] : words[0];

                    // And fill in the values for this enumerant
                    do
                    {
                        line = NextValidLine(specfile);

                        if (String.IsNullOrEmpty(line) || line.StartsWith("#"))
                            continue;

                        if (line.Contains("enum:") || specfile.EndOfStream)
                            break;

                        line = line.Replace('\t', ' ');
                        words = line.Split(Utilities.Separators, StringSplitOptions.RemoveEmptyEntries);

                        if (words.Length == 0)
                            continue;

                        // If we reach this point, we have found a new value for the current enumerant
                        Constant c = new Constant();
                        if (line.Contains("="))
                        {
                            // Trim the "GL_" from the start of the string.
                            if (words[0].StartsWith("GL_"))
                                words[0] = words[0].Substring(3);

                            if (Char.IsDigit(words[0][0]))
                                words[0] = "GL_" + words[0];

                            c.Name = words[0];

                            uint number;
                            if (UInt32.TryParse(words[2].Replace("0x", String.Empty), System.Globalization.NumberStyles.AllowHexSpecifier, null, out number))
                            {
                                // The value is a number, check if it should be unchecked.
                                if (number > 0x7FFFFFFF)
                                {
                                    c.Unchecked = true;
                                }
                            }
                            else
                            {
                                // The value is not a number.
                                // Strip the "GL_" from the start of the string.
                                if (words[2].StartsWith("GL_"))
                                    words[2] = words[2].Substring(3);

                                // If the name now starts with a digit (doesn't matter whether we
                                // stripped "GL_" above), add a "GL_" prefix.
                                // (e.g. GL_4_BYTES).
                                if (Char.IsDigit(words[2][0]))
                                    words[2] = "GL_" + words[2];
                            }

                            c.Value = words[2];
                        }
                        else if (words[0] == "use")
                        {
                            // Trim the "GL_" from the start of the string.
                            if (words[2].StartsWith("GL_"))
                                words[2] = words[2].Substring(3);

                            // If the remaining string starts with a digit, we were wrong above.
                            // Re-add the "GL_"
                            if (Char.IsDigit(words[2][0]))
                                words[2] = "GL_" + words[2];

                            c.Name = words[2];

                            if (words[1] == "LightProperty")
                            {
                                Trace.WriteLine(
                                    String.Format(
                                        "Spec error: Enum LightProperty.{0} does no exist, changing to LightParameter.{0}",
                                        words[2]
                                    )
                                );
                                words[1] = "LightParameter";
                            }
                            c.Reference = words[1];
                            c.Value = words[2];
                        }

                        //if (!String.IsNullOrEmpty(c.Name) && !e.Members.Contains.Contains(c))
                        //SpecTranslator.Merge(e.Members, c);
                        if (!e.ConstantCollection.ContainsKey(c.Name))
                        {
                            e.ConstantCollection.Add(c.Name, c);
                        }
                        else
                        {
                            Trace.WriteLine(
                                String.Format(
                                    "Spec error: Constant {0} defined twice in enum {1}, discarding last definition.",
                                    c.Name,
                                    e.Name
                                )
                            );
                        }

                        // Insert the current constant in the list of all constants.
                        //SpecTranslator.Merge(complete_enum.Members, c);
                        complete_enum = Utilities.Merge(complete_enum, c);
                    }
                    while (!specfile.EndOfStream);

                    // At this point, the complete value list for the current enumerant has been read, so add this
                    // enumerant to the list.
                    //e.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, "public enum " + e.Name));
                    //e.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, "public enum " + e.Name));

                    // (disabled) Hack - discard Boolean enum, it fsucks up the fragile translation code ahead.
                    //if (!e.Name.Contains("Bool"))
                    //Utilities.Merge(enums, e);

                    if (!enums.ContainsKey(e.Name))
                    {
                        enums.Add(e.Name, e);
                    }
                    else
                    {
                        // The enum already exists, merge constants.
                        Trace.WriteLine(String.Format("Conflict: Enum {0} already exists, merging constants.", e.Name));
                        foreach (Constant t in e.ConstantCollection.Values)
                        {
                            Utilities.Merge(enums[e.Name], t);
                        }
                    }

                    //enums.Add(e);
                }
                //SpecTranslator.Merge(enums, complete_enum);
            }
            while (!specfile.EndOfStream);

            enums.Add(complete_enum.Name, complete_enum);

            Trace.Unindent();

            return enums;
        }

        #endregion

        #endregion

        #region internal void ReadGLTypeMap(System.IO.StreamReader sr)

        internal Dictionary<string, string> ReadGLTypeMap(System.IO.StreamReader sr)
        {
            Console.WriteLine("Reading opengl types.");
            Dictionary<string, string> GLTypes = new Dictionary<string, string>();

            do
            {
                string line = sr.ReadLine();

                if (String.IsNullOrEmpty(line) || line.StartsWith("#"))
                    continue;

                string[] words = line.Split(new char[] { ' ', ',', '*', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (words[0].ToLower() == "void")
                {
                    // Special case for "void" -> "". We make it "void" -> "void"
                    GLTypes.Add(words[0], "void");
                }
                else if (words[0] == "VoidPointer" || words[0] == "ConstVoidPointer")
                { 
                    // "(Const)VoidPointer" -> "void*"
                    GLTypes.Add(words[0], "void");
                }
                /*else if (words[0] == "CharPointer" || words[0] == "charPointerARB")
                {
                    GLTypes.Add(words[0], "System.String");
                }
                else if (words[0].Contains("Pointer"))
                {
                    GLTypes.Add(words[0], words[1].Replace("Pointer", "*"));
                }*/
                else if (words[1].Contains("GLvoid"))
                {
                    GLTypes.Add(words[0], "void");
                }
                else
                {
                    GLTypes.Add(words[0], words[1]);
                }
            }
            while (!sr.EndOfStream);

            return GLTypes;
        }

        #endregion

        #region internal Dictionary<string, string> ReadCSTypeMap(System.IO.StreamReader sr)

        internal Dictionary<string, string> ReadCSTypeMap(System.IO.StreamReader sr)
        {
            Dictionary<string, string> CSTypes = new Dictionary<string, string>();
            Console.WriteLine("Reading C# types.");

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (String.IsNullOrEmpty(line) || line.StartsWith("#"))
                    continue;

                string[] words = line.Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (words.Length < 2)
                    continue;

                CSTypes.Add(words[0], words[1]);
            }

            return CSTypes;
        }

        #endregion
    }
}
