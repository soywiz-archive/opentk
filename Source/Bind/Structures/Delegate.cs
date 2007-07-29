#region License
//Copyright (c) 2006 Stefanos Apostolopoulos
//See license.txt for license info
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Bind.Structures
{
    /// <summary>
    /// Represents an opengl function.
    /// The return value, function name, function parameters and opengl version can be retrieved or set.
    /// </summary>
    public class Delegate
    {
        #region --- Constructors ---

        public Delegate()
        {
            Parameters = new ParameterCollection();
        }

        public Delegate(Delegate d)
        {
            this.Category = new string(d.Category.ToCharArray());
            this.Extension = d.Extension;
            this.Name = new string(d.Name.ToCharArray());
            this.NeedsWrapper = d.NeedsWrapper;
            this.Parameters = new ParameterCollection(d.Parameters);
            this.ReturnType = new Parameter(d.ReturnType);
            this.Version = !String.IsNullOrEmpty(d.Version) ? new string(d.Version.ToCharArray()) : "";
            this.Unsafe = d.Unsafe;
        }

        #endregion

        #region --- Properties ---

        #region Category property

        private string _category;

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        #endregion

        #region Needs wrapper property

        bool _needs_wrapper;

        /// <summary>
        /// Indicates whether this function needs to be wrapped with a Marshaling function.
        /// This flag is set if a function contains an Array parameter, or returns
        /// an Array or string.
        /// </summary>
        public bool NeedsWrapper
        {
            get { return _needs_wrapper; }
            set { _needs_wrapper = value; }
        }

        #endregion

        #region public bool Unsafe

        bool @unsafe;

        /// <summary>
        /// True if the delegate must be declared as 'unsafe'.
        /// </summary>
        public bool Unsafe
        {
            get { return @unsafe; }
            set { @unsafe = value; }
        }

        #endregion

        #region public Parameter ReturnType

        Parameter _return_type = new Parameter();
        /// <summary>
        /// Gets or sets the return value of the opengl function.
        /// </summary>
        public Parameter ReturnType
        {
            get { return _return_type; }
            set { _return_type = value; }
        }

        #endregion

        #region public string Name

        string _name;
        /// <summary>
        /// Gets or sets the name of the opengl function.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    _name = value.Trim();
            }
        }

        #endregion

        #region public ParameterCollection Parameters

        ParameterCollection _parameters;

        public ParameterCollection Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }

        #endregion

        #region public string Version

        string _version;

        /// <summary>
        /// Defines the opengl version that introduced this function.
        /// </summary>
        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }

        #endregion

        #region public bool Extension

        bool _extension = false;

        public bool Extension
        {
            get { return _extension; }
            set { _extension = value; }
        }

        #endregion

        #endregion

        #region --- Strings ---

        #region public string CallString()

        public string CallString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Settings.DelegatesClass);
            sb.Append(".gl");
            sb.Append(Name);
            sb.Append("(");
            if (Parameters.Count > 0)
            {
                foreach (Parameter p in Parameters)
                {
                    if (p.Unchecked)
                        sb.Append("unchecked((" + p.Type + ")");

                    sb.Append(
                        Utilities.Keywords.Contains(p.Name) ? "@" + p.Name : p.Name
                    );

                    if (p.Unchecked)
                        sb.Append(")");

                    sb.Append(", ");
                }
                sb.Replace(", ", ")", sb.Length - 2, 2);
            }
            else
            {
                sb.Append(")");
            }

            return sb.ToString();
        }

        #endregion

        #region public string DeclarationString()

        public string DeclarationString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@unsafe ? "unsafe " : "");
            sb.Append(ReturnType);
            sb.Append(" ");
            sb.Append(Name);
            sb.Append(Parameters.ToString());

            return sb.ToString();
        }

        #endregion

        #region override public string ToString()

        /// <summary>
        /// Gets the string representing the full function declaration without decorations
        /// (ie "void glClearColor(float red, float green, float blue, float alpha)"
        /// </summary>
        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@unsafe ? "unsafe " : "");
            sb.Append("delegate ");
            sb.Append(ReturnType);
            sb.Append(" ");
            sb.Append(Name);
            sb.Append(Parameters.ToString());

            return sb.ToString();
        }

        #endregion

        #endregion

        #region --- Wrapper Creation ---

        #region public List<Function> CreateWrappers()

        public List<Function> CreateWrappers()
        {
            if (this.Name == "Color3bv")
            {
            }

            List<Function> wrappers = new List<Function>();
            if (!NeedsWrapper)
            {
                // No special wrapper needed - just call this delegate:
                Function f = new Function(this);

                if (f.ReturnType.Type.ToLower().Contains("void"))
                    f.Body.Add(String.Format("{0};", f.CallString()));
                else
                    f.Body.Add(String.Format("return {0};", f.CallString()));

                wrappers.Add(f);
            }
            else
            {
                // We have to add wrappers for all possible WrapperTypes.
                Function f;

                // First, check if the return type needs wrapping:
                switch (this.ReturnType.WrapperType)
                {
                    // If the function returns a string (glGetString) we must manually marshal it
                    // using Marshal.PtrToStringXXX. Otherwise, the GC will try to free the memory
                    // used by the string, resulting in corruption (the memory belongs to the
                    // unmanaged boundary).
                    case WrapperTypes.StringReturnValue:
                        f = new Function(this);
                        f.ReturnType.Type = "System.String";

                        f.Body.Add(
                            String.Format(
                                "return System.Runtime.InteropServices.Marshal.PtrToStringAnsi({0});",
                                this.CallString()
                            )
                        );

                        wrappers.Add(f);
                        break;

                    // If the function returns a void* (GenericReturnValue), we'll have to return an IntPtr.
                    // The user will unfortunately need to marshal this IntPtr to a data type manually.
                    case WrapperTypes.GenericReturnValue:
                        throw new NotImplementedException();
                        f = new Function(this);

                        if (f.ReturnType.Type.ToLower().Contains("void"))
                            f.Body.Add(String.Format("{0};", f.CallString()));
                        else
                            f.Body.Add(String.Format("return {0};", f.CallString()));

                        wrappers.Add(f);
                        break;

                    case WrapperTypes.None:
                    default:
                        // No return wrapper needed
                        break;
                }

                // Then, create wrappers for each parameter:
                WrapParameters(new Function(this), wrappers);
            }

            return wrappers;
        }

        #endregion

        #region private void WrapParameters(Function function, List<Function> wrappers)

        private static int index = 0;

        /// <summary>
        /// This function needs some heavy refactoring. I'm ashamed I ever wrote it, but it works...
        /// What it does is this: it adds to the wrapper list all possible wrapper permutations
        /// for functions that have more than one IntPtr parameter. Example:
        /// "void Delegates.f(IntPtr p, IntPtr q)" where p and q are pointers to void arrays needs the following wrappers:
        /// "void f(IntPtr p, IntPtr q)"
        /// "void f(IntPtr p, object q)"
        /// "void f(object p, IntPtr q)"
        /// "void f(object p, object q)"
        /// </summary>
        private static void WrapParameters(Function function, List<Function> wrappers)
        {
            if (function.Name == "CallLists")
            {
            }

            if (index == 0)
            {
                bool containsPointerParameters = false;
                // Check if there are any IntPtr parameters (we may have come here from a ReturnType wrapper
                // such as glGetString, which contains no IntPtr parameters)
                foreach (Parameter p in function.Parameters)
                {
                    if (p.IsPointer)
                    {
                        containsPointerParameters = true;
                        break;
                    }
                }

                if (containsPointerParameters)
                {
                    wrappers.Add(DefaultWrapper(function));
                }
                else
                {
                    return;
                }
            }

            if (index >= 0 && index < function.Parameters.Count)
            {
                Function f;

                if (!function.Parameters[index].NeedsWrapper)
                {
                    // No wrapper needed, visit the next parameter
                    ++index;
                    WrapParameters(function, wrappers);
                    --index;
                }
                else
                {
                    switch (function.Parameters[index].WrapperType)
                    {
                        case WrapperTypes.ArrayParameter:
                            // Recurse to the last parameter
                            ++index;
                            WrapParameters(function, wrappers);
                            --index;

                            // On stack rewind, create array wrappers
                            f = ArrayWrapper(new Function(function), index);
                            wrappers.Add(f);

                            // Recurse to the last parameter again, keeping the Array wrappers
                            ++index;
                            WrapParameters(f, wrappers);
                            --index;

                            // On stack rewind, create Ref wrappers.
                            f = ReferenceWrapper(new Function(function), index);
                            wrappers.Add(f);

                            // Keeping the current Ref wrapper, visit all other parameters once more
                            ++index;
                            WrapParameters(f, wrappers);
                            --index;

                            break;

                        case WrapperTypes.GenericParameter:
                            // Recurse to the last parameter
                            ++index;
                            WrapParameters(function, wrappers);
                            --index;

                            // On stack rewind, create array wrappers
                            f = GenericWrapper(new Function(function), index);
                            wrappers.Add(f);

                            // Keeping the current Object wrapper, visit all other parameters once more
                            ++index;
                            WrapParameters(f, wrappers);
                            --index;

                            break;
                    }
                }
            }
        }

        #endregion

        #region private static Function GenericWrapper(Function function, int index)

        private static Function GenericWrapper(Function function, int index)
        {
            // Search and replace IntPtr parameters with the known parameter types:
            function.Parameters[index].Reference = false;
            function.Parameters[index].Array = 0;
            function.Parameters[index].IsPointer = false;
            function.Parameters[index].Type = "object";

            // In the function body we should pin all objects in memory before calling the
            // low-level function.
            function.Body.Clear();
            function.Body.AddRange(AddCallWithPins(function));

            return function;
        }

        #endregion

        #region private static Function ReferenceWrapper(Function function, int index)

        private static Function ReferenceWrapper(Function function, int index)
        {
            // Search and replace IntPtr parameters with the known parameter types:
            function.Parameters[index].Reference = true;
            function.Parameters[index].Array = 0;
            function.Parameters[index].IsPointer = false;

            // In the function body we should pin all objects in memory before calling the
            // low-level function.
            function.Body.Clear();
            function.Body.AddRange(AddCallWithPins(function));

            return function;
        }

        #endregion

        #region private static Function ArrayWrapper(Function function, int index)

        private static Function ArrayWrapper(Function function, int index)
        {
            // Search and replace IntPtr parameters with the known parameter types:
            function.Parameters[index].Array = 1;
            function.Parameters[index].IsPointer = false;

            // In the function body we should pin all objects in memory before calling the
            // low-level function.
            function.Body.Clear();
            function.Body.AddRange(AddCallWithPins(function));

            return function;
        }

        #endregion

        #region private static Function DefaultWrapper(Function f)

        private static Function DefaultWrapper(Function f)
        {
            if (f.ReturnType.Type.ToLower().Contains("void"))
                f.Body.Add(String.Format("{0};", f.CallString()));
            else
                f.Body.Add(String.Format("return {0};", f.CallString()));

            return f;
        }

        #endregion

        #region private static FunctionBody AddCallWithPins(Function function)

        /// <summary>
        /// Generates a body which calls the specified function, pinning all needed parameters.
        /// </summary>
        /// <param name="function"></param>
        private static FunctionBody AddCallWithPins(Function function)
        {
            // We'll make changes, but we want the original intact.
            Function f = new Function(function);
            f.Body.Clear();

            // Add default initliazers for out parameters:
            foreach (Parameter p in function.Parameters)
            {
                if (p.Flow == Parameter.FlowDirection.Out)
                {
                    f.Body.Add(
                        String.Format(
                            "{0} = default({1});",
                            p.Name,
                            p.GetFullType()
                        )
                    );
                }
            }

            // Obtain pointers using 'fixed' notation
            foreach (Parameter p in f.Parameters)
            {
                if (p.NeedsPin)
                {
                    f.Body.Add(
                        String.Format(
                            "fixed ({0}* {1} = {2})",
                            p.Type,
                            p.Name + "_ptr",
                            p.Array > 0 ? p.Name : "&" + p.Name
                        )
                    );
                    p.Name = p.Name + "_ptr";
                }
            }

            f.Body.Add("{");
            // Add delegate call:
            if (f.ReturnType.Type.ToLower().Contains("void"))
                f.Body.Add(String.Format("    {0};", f.CallString()));
            else
                f.Body.Add(String.Format("    {0} {1} = {2};", f.ReturnType.Type, "retval", f.CallString()));

            /*
            // Assign out parameters:
            foreach (Parameter p in function.Parameters)
            {
                if (p.Flow == Parameter.FlowDirection.Out)
                {
                    function.Body.Add(
                        String.Format(
                            "{0} = {1};",
                            p.Name,
                            p.Type
                        )
                    );
                }
            }
            */

            // Return:
            if (!f.ReturnType.Type.ToLower().Contains("void"))
            {
                f.Body.Add("return retval;");
            }

            f.Body.Add("}");

            return f.Body;
        }

        #endregion

        #endregion
    }
}
