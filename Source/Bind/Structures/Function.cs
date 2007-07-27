using System;
using System.Collections.Generic;
using System.Text;

namespace Bind.Structures
{
    class Function : Delegate
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

        #region Function body

        FunctionBody _body;

        public FunctionBody Body
        {
            get { return _body; }
            set { _body = value; }
        }

        #endregion

        #region public override string ToString(string indentation)

        public override string ToString(string indentation)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(indentation + ReturnType + " " + Name + Parameters.ToString());
            if (Body.Count > 0)
            {
                sb.AppendLine();
                sb.Append(Body.ToString(indentation));
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
            return ToString("");
        }

        public string ToString(string indentation)
        {
            if (this.Count == 0)
                return String.Empty;

            StringBuilder sb = new StringBuilder(this.Count);

            sb.AppendLine(indentation + "{");
            foreach (string s in this)
            {
                sb.AppendLine(indentation + "    " + s);
            }
            sb.AppendLine(indentation + "}");

            return sb.ToString();
        }
    }

    #endregion
}
