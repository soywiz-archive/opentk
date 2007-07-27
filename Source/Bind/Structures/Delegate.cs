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
        #region Constructors

        public Delegate()
        {
            Parameters = new ParameterCollection();
        }

        public Delegate(Delegate f)
        {
            this.Category = new string(f.Category.ToCharArray());
            this.Extension = f.Extension;
            this.Name = new string(f.Name.ToCharArray());
            this.NeedsWrapper = f.NeedsWrapper;
            this.Parameters = new ParameterCollection(f.Parameters);
            this.ReturnType = new string(f.ReturnType.ToCharArray());
            this.Version = new string(f.Version.ToCharArray());
            this.WrapperType = f.WrapperType;
        }

        #endregion

        #region IsDelegate

        bool _delegate;
        public bool IsDelegate
        {
            get { return _delegate; }
            set { _delegate = value; }
        }

        #endregion

        #region Category property

        private string _category;

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        #endregion

        #region Wrapper type property

        private WrapperTypes _wrapper_type = WrapperTypes.None;

        public WrapperTypes WrapperType
        {
            get { return _wrapper_type; }
            set { _wrapper_type = value; }
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

        #region public string ReturnType

        string _return_type;
        /// <summary>
        /// Gets or sets the return value of the opengl function.
        /// </summary>
        public string ReturnType
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
                else
                    _name = value;
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

        #region public string CallString()

        public string CallString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append("(");
            foreach (Parameter p in Parameters)
            {
                //if (p.Unchecked)
                //    sb.Append("unchecked((" + p.Type + ")");

                sb.Append(p.Name);

                //if (p.Unchecked)
                //    sb.Append(")");

                sb.Append(", ");
            }
            sb.Replace(", ", ")", sb.Length - 2, 2);

            return sb.ToString();
        }

        #endregion

        #region ToString function

        /// <summary>
        /// Gets the string representing the full function declaration without decorations
        /// (ie "void glClearColor(float red, float green, float blue, float alpha)"
        /// </summary>
        override public string ToString()
        {
            return ToString("");
        }

        public virtual string ToString(string indentation)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(indentation + ReturnType + " " + Name + Parameters.ToString());

            return sb.ToString();
        }

        #endregion
    }

    
}
