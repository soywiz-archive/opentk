using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;

namespace Examples
{
    public partial class ExampleLauncher : Form
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

        public ExampleLauncher()
        {
            InitializeComponent();
        }

        Dictionary<string, Thread> executingExamples = new Dictionary<string, Thread>();

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Type example =
                    Assembly.GetExecutingAssembly().GetType(
                        "Examples." + listBox1.SelectedItem.ToString().Replace(": ", ".").Replace(' ', '_'),
                        true,
                        true
                    );
                example.InvokeMember("Launch", BindingFlags.InvokeMethod, null, null, null);
                /*
                if (!executingExamples.ContainsKey(listBox1.SelectedItem.ToString()))
                {
                    Thread newExample = new Thread(
                        new ParameterizedThreadStart(
                            this.Invoke
                        )
                    );
                    executingExamples.Add(listBox1.SelectedItem.ToString(), newExample);
                    newExample.Start();
                }*/
            }
        }

        public void ExampleLauncher_Load(object sender, EventArgs e)
        {
            SortedList<string, string> sl = new SortedList<string, string>();

            // Get all examples
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in types)
            {
                if (type.IsPublic)
                {
                    MemberInfo[] runMethods = type.GetMember("Launch");
                    foreach (MemberInfo run in runMethods)
                    {
                        // Trim the 'Examples.' namespace, and add the item into a sorted list.
                        // This is an ugly hack to keep the listBox items sorted.
                        sl.Add(
                            (type.Namespace.Replace("Examples.", String.Empty) + ": " + type.Name).Replace('_', ' '),
                            null
                        );
                        //listBox1.Items.Add(
                        //    type.Namespace.Replace("Examples.", String.Empty) + ": " + type.Name
                        //);
                    }
                }
            }

            foreach (string s in sl.Keys)
                listBox1.Items.Add(s);

            // Select first item
            if (listBox1.Items.Count > 0)
            {
                this.listBox1.SelectedIndex = 0;
            }
        }
    }
}