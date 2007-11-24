#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Examples
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ExampleAttribute : System.Attribute
    {
        public readonly string Title;
        public readonly ExampleCategory Category;
        public readonly int Difficulty;
        public readonly string Documentation;


        [Obsolete]
        public ExampleAttribute(string title, ExampleCategory category, int difficulty, string documentation, bool visible)
        {
            throw new NotSupportedException();
        }

        public ExampleAttribute(string title, ExampleCategory category, int difficulty, string documentation)
        {
            this.Title = title;
            this.Category = category;
            this.Difficulty = difficulty;
            this.Documentation = documentation;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}: {2}", Category, Difficulty, Title);
        }
    }

    public enum ExampleCategory
    {
        OpenGL,
        OpenAL,
        Tutorial,
        GLSL,
        WinForms,
        Test,
    }
}
