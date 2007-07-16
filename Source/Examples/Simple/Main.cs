#region --- License ---
/* Copyright (c) 2006, 2007 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Examples
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            using (Form exampleLauncher = new ExampleLauncher())
            {
                Application.Run(exampleLauncher);
            }
            */
            Application.Run(new ExampleLauncher());
        }
    }
}
