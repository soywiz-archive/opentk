#region License
//Copyright (c) 2006 Stefanos Apostolopoulos
//See license.txt for license info
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Bind
{
    static class Settings
    {
        public static string InputPath = "..\\..\\..\\Source\\Bind\\Specifications";
        public static string OutputPath = "..\\..\\..\\Source\\OpenTK\\OpenGL\\Bindings";
        public static string OutputNamespace = "OpenTK.OpenGL";
        public static string GLClass = "GL";
        public static string DelegatesClass = "Delegates";
        public static string ImportsClass = "Imports";
        public static string WglClass = "Wgl";
        public static string GlxClass = "Glx";
        public static string GluClass = "Glu";
        public static Legacy Compat = Legacy.None;

        public enum Legacy
        {
            None,
            Tao,
        }
    }
}
