using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bind
{
    static class Utilities
    {
        #region private StreamReader OpenSpecFile(string file)

        internal static StreamReader OpenSpecFile(string folder, string file)
        {
            string path = Path.Combine(folder, file);
            return new StreamReader(path);
        }

        #endregion
    }
}
