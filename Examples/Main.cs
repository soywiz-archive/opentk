using System;
using System.Collections.Generic;
using System.Text;

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
            new Cube().Run();
        }
    }
}
