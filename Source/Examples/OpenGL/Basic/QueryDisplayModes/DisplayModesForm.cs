using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK;
using OpenTK.Platform;

namespace Examples.Windowing
{
    public partial class W01_DisplayModesForm : Form
    {
        OpenTK.Platform.IGLControl glWindow;

        public W01_DisplayModesForm()
        {
            InitializeComponent();

            glWindow = new OpenTK.Platform.GLControl();

            DisplayMode[] modes = glWindow.Context.GetDisplayModes();

            for (int i = 0; i < modes.Length; i++)
                listBox1.Items.Add(modes[i]);
        }
    }
}