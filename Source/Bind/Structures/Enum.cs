#region License
//Copyright (c) 2006 Stefanos Apostolopoulos
//See license.txt for license info
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Bind.Structures
{
    #region class Enum

    public class Enum
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        System.Collections.Hashtable _constant_collection = new System.Collections.Hashtable();

        public System.Collections.Hashtable ConstantCollection
        {
            get { return _constant_collection; }
            set { _constant_collection = value; }
        }

        public override string ToString()
        {
            return this.ToString("");
        }

        public string ToString(string indentation)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(indentation + "public enum " + Name + " : uint");
            sb.AppendLine(indentation + "{");
            foreach (Constant c in ConstantCollection.Values)
            {
                sb.AppendLine(indentation + "    " + c.Name + " = " + c.Value + ",");
            }
            sb.AppendLine(indentation + "}");

            return sb.ToString();
        }
    }

    #endregion
}
