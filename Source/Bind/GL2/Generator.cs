using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Bind.Structures;
using System.Diagnostics;

namespace Bind.GL2
{
    class Generator : IBind
    {
        private SpecReader specReader = new SpecReader();
        private SpecWriter specWriter = new SpecWriter();
        DelegateCollection delegates = new DelegateCollection();
        FunctionCollection wrappers = new FunctionCollection();
        //List<Bind.Structures.Enum> enums = new List<Bind.Structures.Enum>();
        EnumCollection enums = new EnumCollection();
        EnumCollection extEnums = new EnumCollection();
        Dictionary<string, string> GLTypes = new Dictionary<string, string>();
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

        #region public void Process()

        public void Process()
        {
            // Read
            using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, "gl2\\gl.tm"))
            {
                GLTypes = specReader.ReadTypeMap(sr);
            }
            using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, "gl2\\csharp.tm"))
            {
                CSTypes = specReader.ReadCSTypeMap(sr);
            }
            using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, "gl2\\gl.spec"))
            {
                delegates = specReader.ReadDelegates(sr);
            }
            using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, "gl2\\enum.spec"))
            {
                enums = specReader.ReadEnums(sr);
            }
            using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, "gl2\\enumext.spec"))
            {
                extEnums = specReader.ReadEnums(sr);
            }

            // Merge all opengl enumerants in enums
            foreach (Bind.Structures.Enum e in extEnums.Values)
            {
                //enums.Add(e.Name, e);
                Utilities.Merge(enums, e);
            }

            // Process enums and delegates - create wrappers.
            this.Translate();


            // Write
            using (BindStreamWriter sw = new BindStreamWriter(Path.Combine(Settings.OutputPath, "GLEnums.cs")))
            {
                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");
                
                sw.Indent();
                sw.WriteLine("public static partial class {0}", Settings.GLClass);
                sw.WriteLine("{");
                
                sw.Indent();
                specWriter.WriteEnums(sw, enums);
                sw.Unindent();

                sw.WriteLine("}");
                sw.Unindent();

                sw.WriteLine("}");
            }
            using (BindStreamWriter sw = new BindStreamWriter(Path.Combine(Settings.OutputPath, "GLDelegates.cs")))
            {
                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");

                sw.Indent();
                specWriter.WriteTypes(sw, CSTypes);
                specWriter.WriteDelegates(sw, delegates);
                sw.Unindent();

                sw.WriteLine("}");
            }
            using (BindStreamWriter sw = new BindStreamWriter(Path.Combine(Settings.OutputPath, "GLCore.cs")))
            {
                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");

                sw.Indent();
                specWriter.WriteTypes(sw, CSTypes);
                specWriter.WriteImports(sw, delegates);
                sw.Unindent();

                sw.WriteLine("}");
            }
            using (BindStreamWriter sw = new BindStreamWriter(Path.Combine(Settings.OutputPath, "GL.cs")))
            {
                sw.WriteLine("namespace {0}", Settings.OutputNamespace);
                sw.WriteLine("{");

                sw.Indent();
                specWriter.WriteTypes(sw, CSTypes);
                specWriter.WriteWrappers(sw, wrappers, CSTypes);
                sw.Unindent();

                sw.WriteLine("}");
            }
        }

        #endregion

        #endregion

        #region private void Translate()

        private void Translate()
        {
            // Add missing enum
            {
                Trace.WriteLine("Spec error: SGIX_icc_texture enum missing, adding by hand.");
                Bind.Structures.Enum e = new Bind.Structures.Enum("SGIX_icc_texture");
                e.ConstantCollection.Add("RGB_ICC_SGIX", new Constant("RGB_ICC_SGIX", "0x8460"));
                e.ConstantCollection.Add("RGBA_ICC_SGIX", new Constant("RGBA_ICC_SGIX", "0x8461"));
                e.ConstantCollection.Add("ALPHA_ICC_SGIX", new Constant("ALPHA_ICC_SGIX", "0x8462"));
                e.ConstantCollection.Add("LUMINANCE_ICC_SGIX", new Constant("LUMINANCE_ICC_SGIX", "0x8463"));
                e.ConstantCollection.Add("INTENSITY_ICC_SGIX", new Constant("INTENSITY_ICC_SGIX", "0x8464"));
                e.ConstantCollection.Add("LUMINANCE_ALPHA_ICC_SGIX", new Constant("LUMINANCE_ALPHA_ICC_SGIX", "0x8465"));
                e.ConstantCollection.Add("R5_G6_B5_ICC_SGIX", new Constant("R5_G6_B5_ICC_SGIX", "0x8466"));
                e.ConstantCollection.Add("R5_G6_B5_A8_ICC_SGIX", new Constant("R5_G6_B5_A8_ICC_SGIX", "0x8467"));
                e.ConstantCollection.Add("ALPHA16_ICC_SGIX", new Constant("ALPHA16_ICC_SGIX", "0x8468"));
                e.ConstantCollection.Add("LUMINANCE16_ICC_SGIX", new Constant("LUMINANCE16_ICC_SGIX", "0x8469"));
                e.ConstantCollection.Add("INTENSITY16_ICC_SGIX", new Constant("INTENSITY16_ICC_SGIX", "0x846A"));
                e.ConstantCollection.Add("LUMINANCE16_ALPHA8_ICC_SGIX", new Constant("LUMINANCE16_ALPHA8_ICC_SGIX", "0x846B"));

                enums.Add(e.Name, e);
            }

            foreach (Bind.Structures.Enum e in enums.Values)
            {
                TranslateEnum(e);
            }

            foreach (Bind.Structures.Delegate d in delegates.Values)
            {
                TranslateReturnType(d);
                TranslateParameters(d);
                //wrappers.AddRange(d.CreateWrappers());
                foreach (Function f in d.CreateWrappers(CSTypes))
                {
                    if (!f.CLSCompliant)
                    {
                        Function clsFunction = f.GetCLSCompliantFunction(CSTypes);
                        if (clsFunction.Parameters.ToString() != f.Parameters.ToString())
                            wrappers.Add(clsFunction);
                    }
                    wrappers.Add(f);
                }
            }
        }

        #endregion

        #region private void TranslateReturnType(Bind.Structures.Delegate d)

        private void TranslateReturnType(Bind.Structures.Delegate d)
        {
            if (GLTypes.ContainsKey(d.ReturnType.Type))
            {
                d.ReturnType.Type = GLTypes[d.ReturnType.Type];
            }

            if (d.ReturnType.Type == "GLstring")
            {
                d.ReturnType.Type = "System.IntPtr";
                d.ReturnType.WrapperType = WrapperTypes.StringReturnValue;
            }

            if (d.ReturnType.Type.ToLower().Contains("object"))
            {
                d.ReturnType.Type = "System.IntPtr";
                d.ReturnType.WrapperType |= WrapperTypes.GenericReturnValue;
            }

            if (d.ReturnType.Type == "GLenum")
            {
                d.ReturnType.Type = Settings.GLClass + ".Enums.GLenum";
            }

            if (d.ReturnType.Type.Contains("*"))
            {
                //d.Unsafe = true;
            }

            if (d.ReturnType.WrapperType != WrapperTypes.None)
            {
                d.NeedsWrapper = true;
            }

            d.ReturnType.Type = d.ReturnType.GetCLSCompliantType(CSTypes);
        }

        #endregion

        #region private void TranslateParameters(Bind.Structures.Delegate d)

        private void TranslateParameters(Bind.Structures.Delegate d)
        {
            string s;
            Bind.Structures.Enum @enum;

            foreach (Parameter p in d.Parameters)
            {
                if (enums.TryGetValue(p.Type, out @enum) && @enum.Name != "GLenum")
                {
                    // First, check if the type is an enum:
                    p.Type = p.Type.Insert(0, Settings.GLClass + ".Enums.");
                }
                else if (GLTypes.TryGetValue(p.Type, out s))
                {
                    // Check if the parameter is a generic GLenum. If yes,
                    // check if a better match exists:
                    if (s.Contains("GLenum") && !String.IsNullOrEmpty(d.Category))
                    {
                        // Check if an enum with Name equal to the category exists
                        // (e.g. GL_VERSION_1_1 etc)
                        if (enums.ContainsKey(d.Category))
                        {
                            p.Type = Settings.GLClass + ".Enums." + d.Category;
                        }
                        else
                        {
                            p.Type = Settings.GLClass + ".Enums.GLenum";
                        }
                    }
                    else
                    {
                        // This is not enum, default translation:
                        p.Type = s;
                    }
                }

                //if (p.Pointer)
                    //d.Unsafe = true;

                if (d.Name == "CallLists")
                {
                }

                // Translate pointer parameters
                if (p.Pointer)
                {
                    p.WrapperType = WrapperTypes.ArrayParameter;

                    if (p.Type.ToLower().Contains("char") || p.Type.ToLower().Contains("string"))
                    {
                        // char* or string -> [In] String or [Out] StringBuilder
                        p.Type =
                            p.Flow == Parameter.FlowDirection.Out ?
                            "System.Text.StringBuilder" :
                            "System.String";

                        if (d.Name.Contains("ShaderSource"))
                        {
                            // Special case: these functions take a string[]
                            //p.IsPointer = true;
                            p.Array = 1;
                        }

                        p.Pointer = false;
                        p.WrapperType = WrapperTypes.None;
                    }
                    else if (p.Type.ToLower().Contains("void"))
                    {
                        p.WrapperType = WrapperTypes.GenericParameter;
                    }
                }

                // Check for LineStipple (should be unchecked)
                if (p.Type.ToLower().Contains("ushort") && d.Name.Contains("LineStipple"))
                {
                    p.WrapperType = WrapperTypes.UncheckedParameter;
                }

                if (p.Type.ToLower().Contains("bool"))
                {
                    p.WrapperType = WrapperTypes.BoolParameter;
                }

                if (p.WrapperType != WrapperTypes.None)
                {
                    d.NeedsWrapper = true;
                }
            }
        }

        #endregion

        #region private void TranslateEnum(Bind.Structures.Enum e)

        private void TranslateEnum(Bind.Structures.Enum e)
        {
            
            foreach (Constant c in e.ConstantCollection.Values)
            {
                // There are cases when a value is an aliased constant, with no enum specified.
                // (e.g. FOG_COORD_ARRAY_TYPE = GL_FOG_COORDINATE_ARRAY_TYPE)
                // In this case try searching all enums for the correct constant to alias (stupid opengl specs).
                if (String.IsNullOrEmpty(c.Reference) && !Char.IsDigit(c.Value[0]))
                {
                    foreach (Bind.Structures.Enum @enum in enums.Values)
                    {
                        // Skip generic GLenum
                        if (@enum.Name == "GLenum")
                            continue;

                        if (@enum.ConstantCollection.ContainsKey(c.Value))
                        {
                            c.Reference = @enum.Name;
                        }
                    }
                }
            }
        }

        #endregion
    }
}
