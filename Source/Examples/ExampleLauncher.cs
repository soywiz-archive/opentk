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
            using (Form exampleLauncher = new ExampleLauncher())
            {
                Application.Run(exampleLauncher);
            }
        }

        public ExampleLauncher()
        {
            InitializeComponent();
        }

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
                // We want to do this on a thread, so that the launcher doesn't block:
                //example.InvokeMember("Launch", BindingFlags.InvokeMethod, null, null, null);

                // Mono 1.2.4 does not support this specific anonymous delegate
                //new Thread(delegate()
                //{
                //    example.InvokeMember("Launch", BindingFlags.InvokeMethod, null, null, null);
                //}).Start();

                new Thread(Launch).Start(example);
            }
        }

        void Launch(object example)
        {
            try
            {
                (example as Type).InvokeMember("Launch", BindingFlags.InvokeMethod, null, null, null);
            }
            catch (Exception e)
            {

                MessageBox.Show(
                    String.Format(
                        "Stacktrace:{0}{1}{0}{0}Inner exception:{0}{2}",
                        System.Environment.NewLine,
                        e.StackTrace,
                        e.InnerException
                    ),
                    e.Message
                );
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