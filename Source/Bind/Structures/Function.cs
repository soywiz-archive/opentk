﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bind.Structures
{
    public class Function : Delegate
    {
        public Function()
            : base()
        {
            Body = new FunctionBody();
        }

        public Function(Function f)
            : base(f)
        {
            this.Body = new FunctionBody(f.Body);
        }

        public Function(Delegate d)
            : base(d)
        {
            this.Body = new FunctionBody();
        }

        #region Function body

        FunctionBody _body;

        public FunctionBody Body
        {
            get { return _body; }
            set { _body = value; }
        }

        #endregion

        #region public override string ToString()

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Unsafe ? "unsafe " : "");
            sb.Append(ReturnType);
            sb.Append(" ");
            sb.Append(Name);
            sb.Append(Parameters.ToString());
            if (Body.Count > 0)
            {
                sb.AppendLine();
                sb.Append(Body.ToString());
            }

            return sb.ToString();
        }

        #endregion
    }

    #region class FunctionBody : List<string>

    public class FunctionBody : List<string>
    {
        public FunctionBody()
        {
        }

        public FunctionBody(FunctionBody fb)
        {
            foreach (string s in fb)
            {
                this.Add(s);
            }
        }

        public override string ToString()
        {
            if (this.Count == 0)
                return String.Empty;

            StringBuilder sb = new StringBuilder(this.Count);

            sb.AppendLine("{");
            foreach (string s in this)
            {
                sb.AppendLine("    " + s);
            }
            sb.AppendLine("}");

            return sb.ToString();
        }
    }

    #endregion
}
