using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK.OpenGL;

namespace QueryDisplayModes
{
    public partial class DisplayModesForm : Form
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DisplayModesForm());
        }

        GLContext context;

        public DisplayModesForm()
        {
            InitializeComponent();

            //context = GLContext.Create(this, new OpenTK.OpenGL.ColorDepth(8, 8, 8, 8), 0, 0);

            context = new GLContext(this, new OpenTK.OpenGL.ColorDepth(8, 8, 8, 8), 0, 0, 0, false);

            foreach (DisplayMode mode in context.GetDisplayModes())
            {
                listBox1.Items.Add(mode);
            }
        }
    }
}
