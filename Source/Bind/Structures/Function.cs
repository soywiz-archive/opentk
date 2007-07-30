using System;
using System.Collections.Generic;
using System.Text;

namespace Bind.Structures
{
    public class Function : Delegate
    {
        #region --- Constructors ---

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

        #endregion

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

        public Function GetCLSCompliantFunction(Dictionary<string, string> CSTypes)
        {
            Function f = new Function(this);

            for (int i = 0; i < f.Parameters.Count; i++)
            {
                f.Parameters[i].Type = f.Parameters[i].GetCLSCompliantType(CSTypes);
            }

            f.Body.Clear();
            if (!f.NeedsWrapper)
            {
                f.Body.Add((f.ReturnType.Type != "void" ? "return " + this.CallString() : this.CallString()) + ";");
            }
            else
            {
                f.Body.AddRange(Function.GetBodyWithPins(this, CSTypes, true));
            }

            // The type system cannot differentiate between functions with the same parameters
            // but different return types. Tough, only CLS-Compliant function in that case.
            //f.ReturnType.Type = f.ReturnType.GetCLSCompliantType(CSTypes);

            return f;
        }
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

    class FunctionCollection : Dictionary<string, List<Function>>
    {
        public void Add(Function f)
        {
            if (!this.ContainsKey(f.Extension))
            {
                this.Add(f.Extension, new List<Function>());
                this[f.Extension].Add(f);
            }
            else
            {
                this[f.Extension].Add(f);
            }
        }

        public void AddRange(IEnumerable<Function> functions)
        {
            foreach (Function f in functions)
            {
                this.Add(f);
            }
        }
    }
}
