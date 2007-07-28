using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Bind.Structures;

namespace Bind.GL2
{
    class Generator : IBind
    {
        private SpecReader specReader = new SpecReader();
        private SpecWriter specWriter = new SpecWriter();
        List<Bind.Structures.Delegate> delegates = new List<Bind.Structures.Delegate>();
        List<Bind.Structures.Function> functions = new List<Bind.Structures.Function>();
        List<Bind.Structures.Enum> enums = new List<Bind.Structures.Enum>();

        Dictionary<string, string> CSTypes = new Dictionary<string, string>();

        string specFolder;

        public Generator(string folder)
        {
            specFolder = folder;
        }

        #region IBind Members

        /*
        public ISpecReader SpecReader
        {
            get { return specReader; }
        }
        */

        public void Process()
        {
            // Read
            using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, "gl2\\gl.tm"))
            {
                specReader.ReadGLTypeMap(sr);
            }
            using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, "gl2\\csharp.tm"))
            {
                CSTypes = specReader.ReadCSTypeMap(sr);
            }
            using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, "gl2\\gl.spec"))
            {
                delegates = specReader.ReadFunctions(sr);
            }
            using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, "gl2\\enum.spec"))
            {
                enums = specReader.ReadEnums(sr);
            }

            // Process


            // Write
            using (StreamWriter sw = new StreamWriter(Path.Combine(Settings.OutputPath, "GLEnums.cs")))
            {
                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");
                sw.WriteLine("    public static partial class {0}", Settings.GLClass);
                sw.WriteLine("    {");
                specWriter.WriteEnums(sw, enums);
                sw.WriteLine("    }");
                sw.WriteLine("}");
            }
            using (StreamWriter sw = new StreamWriter(Path.Combine(Settings.OutputPath, "GLDelegates.cs")))
            {
                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");

                specWriter.WriteDelegates(sw, delegates, CSTypes);

                sw.WriteLine("}");
            }
            using (StreamWriter sw = new StreamWriter(Path.Combine(Settings.OutputPath, "GL.cs")))
            {
                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");

                specWriter.WriteWrappers(sw, functions, CSTypes);
                
                sw.WriteLine("}");
            }
        }

        #endregion

        #region private string GetParameterTranslation(string originalType, out string type, out WrapperTypes wrapper)

        private void GetParameterTranslation(string originalType, out string type, out WrapperTypes wrapper)
        {
            wrapper = WrapperTypes.None;
            type = "";

            /*
            if (Search(enums, originalType) && p.Type.BaseType != "GLenum")
            {
                // If there is a specific enumerant entry for this parameter, then take this.
                p.Type.BaseType = "Enums." + p.Type.BaseType;
            }
            else if (GLTypes.TryGetValue(p.Type.BaseType, out s))
            {
                if (s.BaseType == "GLenum" && d.UserData.Contains("Category"))
                {
                    // If there isn't, try to see if any of the generic enumerants
                    // (category: VERSION_1_1 etc) match the needed name.
                    bool found = false;
                    foreach (CodeTypeDeclaration enumerant in enums)
                    {
                        if (enumerant.Name == (string)d.UserData["Category"])
                        {
                            p.Type.BaseType = "Enums." + (string)d.UserData["Category"];
                            found = true;
                            break;
                        }
                    }

                    // If none match, then fall back to the global enum list.
                    if (!found)
                    {
                        p.Type.BaseType = "Enums.GLenum";
                    }
                }
                else
                {
                    p.Type.BaseType = s.BaseType;
                }
            }
            
            if (p.Type.ArrayRank == 0 && p.Type.BaseType.ToLower().Contains("enums."))
            {
                // Do nothing
            }
            else if (p.Type.ArrayRank > 0 && p.Type.BaseType.Contains("char") ||
                    p.Type.ArrayRank == 0 && p.Type.BaseType.ToLower().Contains("string"))
            {
                // GLchar[] parameters should become (in) string or (out) StringBuilder
                if (p.Direction == FieldDirection.Out || p.Direction == FieldDirection.Ref)
                    p.Type = new CodeTypeReference("System.Text.StringBuilder");
                else
                    p.Type = new CodeTypeReference("System.String");
            }
            else if (p.Type.ArrayRank > 0 && p.Type.BaseType.ToLower().Contains("string"))
            {
                // string parameters do not need special wrappers. We add this here
                // to simplify the next if-statements.
                // p.Type.ArrayRank = 0;
            }
            else if (p.Type.ArrayRank > 0)
            {
                // All other array parameters need wrappers (around IntPtr).
                if (p.Type.BaseType.Contains("void") || p.Type.BaseType.Contains("Void"))
                {
                    p.UserData.Add("Wrapper", WrapperTypes.GenericParameter);
                }
                else if (p.Type.BaseType.Contains("IntPtr"))
                {
                    //p.UserData.Add("Wrapper", WrapperTypes.PointerParameter);
                }
                else
                {
                    p.UserData.Add("Wrapper", WrapperTypes.ArrayParameter);
                    p.UserData.Add("OriginalType", new string(p.Type.BaseType.ToCharArray()));
                }

                // We do not want an array of IntPtrs (IntPtr[]) - it is the IntPtr that points to the array.
                p.Type = new CodeTypeReference();
                p.Type.BaseType = "System.IntPtr";
                p.Type.ArrayRank = 0;
                p.UserData.Add("Flow", p.Direction);
                // The same wrapper works for either in or out parameters.
                //p.CustomAttributes.Add(new CodeAttributeDeclaration("In, Out"));
            }
            else if (p.Type.BaseType.Contains("ushort") && d.Name.Contains("LineStipple"))
            {
                // glLineStipple needs wrapper to allow large unsigned mask values.
                p.UserData.Add("Wrapper", WrapperTypes.UncheckedParameter);
            }


            if (p.Type.BaseType.ToLower().Contains("boolean"))
            {
                p.Type.BaseType = "System.Boolean";
                //p.UserData.Add("Wrapper", WrapperTypes.BoolParameter);
                p.CustomAttributes.Add(
                    new CodeAttributeDeclaration(
                    "MarshalAs",
                    new CodeAttributeArgument(new CodeSnippetExpression("UnmanagedType.Bool"))
                    )
                );
            }

            if (p.UserData.Contains("Wrapper") && !d.UserData.Contains("Wrapper"))
            {
                // If there is at least 1 parameter that needs wrappers, mark the funcction for wrapping.
                d.UserData.Add("Wrapper", null);
            }

            //p.Direction = FieldDirection.In;
            */
        }

        #endregion
    }
}
