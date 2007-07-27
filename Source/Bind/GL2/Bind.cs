using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Bind.Structures;

namespace Bind.GL2
{
    class Generator : IBind
    {
        private SpecReader specReader = new SpecReader();
        List<Bind.Structures.Delegate> delegates = new List<Bind.Structures.Delegate>();
        List<Function> functions = new List<Function>();
        string specFolder;

        public Generator(string folder)
        {
            specFolder = folder;
        }

        #region IBind Members

        /*
        public ISpecReader SpecReader
        {
            get { return specReader; }
        }
        */

        public void Process()
        {
            using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, "gl2\\gl.spec"))
            {
                delegates = specReader.ReadFunctions(sr);
            }
            using (StreamReader sr = Utilities.OpenSpecFile(Settings.InputPath, "gl2\\enum.spec"))
            {

            }

        }

        #endregion
    }
}
