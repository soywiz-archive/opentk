using System;
using System.Collections.Generic;
using System.Text;
using Bind.Structures;

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

                // Get next OpenGL function
                while (line.Contains("(") && !specFile.EndOfStream)
                {
                    Bind.Structures.Delegate d = new Bind.Structures.Delegate();
                    d.IsDelegate = true;

                    //d.Attributes = MemberAttributes.Static;
                    //d.CustomAttributes.Add(new CodeAttributeDeclaration("System.Security.SuppressUnmanagedCodeSecurity"));

                    // Get function name:
                    d.Name = line.Split(SpecTranslator.Separators, StringSplitOptions.RemoveEmptyEntries)[0];
                    if (IsExtension(d.Name))
                    {
                        //d.UserData.Add("Extension", true);
                        d.Extension = true;
                    }
                    else
                    {
                        d.Extension = false;
                    }

                    //d.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, d.Name));
                    //d.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, d.Name));

                    // Get function parameters and return value:
                    do
                    {
                        line = specFile.ReadLine();
                        List<string> words = new List<string>(
                            line.Replace('\t', ' ').Split(SpecTranslator.Separators, StringSplitOptions.RemoveEmptyEntries)
                        );

                        if (words.Count == 0)
                            break;

                        // Identify line:
                        switch (words[0])
                        {
                            case "return":  // Line denotes return value
                                d.ReturnType = words[1];
                                break;

                            case "param":   // Line denotes parameter
                                Parameter p = new Parameter();
                                p.Name = words[1];
                                p.Type = words[2];
                                p.Array = words[4] == "array" ? true : false;
                                p.Flow = words[3] == "in" ? Parameter.FlowDirection.In : Parameter.FlowDirection.Out;
                                /*
                                CodeParameterDeclarationExpression p =
                                    new CodeParameterDeclarationExpression();
                                p.Name = words[1];
                                p.Type = new CodeTypeReference(words[2]);
                                p.Direction = words[3] == "in" ? FieldDirection.In : FieldDirection.Out;
                                if (words[3] != "in")
                                    p.CustomAttributes.Add(new CodeAttributeDeclaration("In, Out"));
                                p.Type.ArrayRank = words[4] == "array" ? 1 : 0;

                                d.Parameters.Add(p);
                                */
                                break;

                            /* version directive is not used. GetTexParameterIivEXT and GetTexParameterIuivEXT define two(!) versions (why?)
                            case "version": // Line denotes function version (i.e. 1.0, 1.2, 1.5)
                                d.UserData.Add("version", words[1]);
                                break;
                            */

                            case "category":
                                //d.UserData.Add("Category", words[1]);
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

        #region public List<Enum> ReadEnums(System.IO.StreamReader specFile)

        public List<Bind.Structures.Enum> ReadEnums(System.IO.StreamReader specFile)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #endregion
    }
}
