#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
using System.Diagnostics;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.IO;
using System.CodeDom;
using System.CodeDom.Compiler;

using OpenTK;

#endregion

namespace Examples
{
    public partial class ExampleLauncher : Form
    {
        CodeDomProvider compiler = Microsoft.CSharp.CSharpCodeProvider.CreateProvider("CSharp");
        CompilerParameters options = new CompilerParameters();
        string docsPath = Path.Combine(Environment.CurrentDirectory, "Docs");
        string sourcePath = Path.Combine(Environment.CurrentDirectory, "Source");
        string outputPath = Path.Combine(Environment.CurrentDirectory, "Compiled");
        string propertiesPath = Path.Combine(Environment.CurrentDirectory, "Properties");

        #region class ExampleInfo

        /// <summary>
        /// Contains the information necessary to display and launch an example thorugh the ExampleLauncer.
        /// </summary>
        class ExampleInfo
        {
            public ExampleAttribute MetaData;
            public string Source;
            public CompilerResults Result;

            public string Executable
            {
                get
                {
                    return Result != null ? Result.PathToAssembly : null;
                }
            }

            public ExampleInfo()
            {
            }

            public override string ToString()
            {
                return String.Format("{0} ({1})", MetaData.ToString(), Source);
            }
        }

        #endregion

        #region --- Constructor ---

        public ExampleLauncher()
        {
            InitializeComponent();

            options.GenerateExecutable = true;
            options.ReferencedAssemblies.Add("OpenTK.dll");
            options.ReferencedAssemblies.Add("System.Drawing.dll");
            options.ReferencedAssemblies.Add(Path.Combine(outputPath, "Examples.dll"));

            if (!Directory.Exists(outputPath))
                Directory.CreateDirectory(outputPath);
            File.Copy("OpenTK.dll", Path.Combine(outputPath, "OpenTK.dll"), true);
            File.Copy("OpenTK.dll.config", Path.Combine(outputPath, "OpenTK.dll.config"), true);
            File.Copy("Examples.exe", Path.Combine(outputPath, "Examples.dll"), true);
        }

        #endregion

        #region public void ExampleLauncher_Load(object sender, EventArgs e)

        public void ExampleLauncher_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("debug.log"))
                    File.Delete("debug.log");
            }
            catch (Exception expt)
            {
                MessageBox.Show("Could not access debug.log", expt.ToString());
            }

            //Debug.Listeners.Clear();
            Debug.Listeners.Add(new TextWriterTraceListener("debug.log"));
            Debug.Listeners.Add(new ConsoleTraceListener());
            Debug.AutoFlush = true;

            Dictionary<string, TreeNode> categories = new Dictionary<string, TreeNode>();

            foreach (string path in Directory.GetFiles(sourcePath))
            {
                string filename = Path.GetFileName(path);
                // Skip helper source files. We only want to display genuine examples.
                if (filename.Contains("ExampleAttribute") || filename.Contains("Utilities"))
                    continue;

                string[] name = filename.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < name.Length; i++)
                    name[i] = name[i].Trim();

                ExampleInfo info = new ExampleInfo();
                info.Source = filename;
                CompileExample(ref info, true);
                TreeNode node = new TreeNode(info.MetaData.Title);
                node.Tag = info;

                TreeNode category;
                if (!categories.TryGetValue(name[0], out category))
                {
                    category = new TreeNode(name[0]);
                    category.Name = name[0];
                    categories.Add(name[0], category);
                }

                // Insert sorted by difficulty. This algorithm is very slow,
                // but we are unlikely to have more than ~30 examples, so it's
                // not an issue.
                //category.Nodes.Add(node);
                if (category.Nodes.Count > 0)
                {
                    int i = 0;
                    while ((category.Nodes[i].Tag as ExampleInfo).MetaData.Difficulty <
                           (node.Tag as ExampleInfo).MetaData.Difficulty)
                        ++i;
                    category.Nodes.Insert(i, node);
                }
                else
                    category.Nodes.Add(node);
            }

            foreach (TreeNode t in categories.Values)
                exampleTreeView.Nodes.Add(t);
        }

        #endregion

        #region private void viewCode_Click(object sender, EventArgs e)

        /// <summary>
        /// "Executes" the source file (which opens the default code editor).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (exampleTreeView.SelectedNode != null && exampleTreeView.SelectedNode.Tag is ExampleInfo)
                {
                    string source = Path.Combine(sourcePath, (exampleTreeView.SelectedNode.Tag as ExampleInfo).Source);
                    Process.Start(source);
                }
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        #region private void run_Click(object sender, EventArgs e)

        private void run_Click(object sender, EventArgs e)
        {
            if (exampleTreeView.SelectedNode != null && exampleTreeView.SelectedNode.Tag is ExampleInfo)
                LaunchExample(exampleTreeView.SelectedNode.Tag as ExampleInfo);
        }

        #endregion

        #region private void exampleTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)

        private void exampleTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is ExampleInfo)
                LaunchExample(e.Node.Tag as ExampleInfo);
        }

        #endregion

        #region private void ExampleLauncher_FormClosing(object sender, FormClosingEventArgs e)

        private void ExampleLauncher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.Flush();
            Debug.Close();
            Trace.Flush();
            Trace.Close();
        }

        #endregion

        #region static void Main()

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Form exampleLauncher = new ExampleLauncher())
            {
                Application.EnableVisualStyles();
                Application.Run(exampleLauncher);
            }
        }

        #endregion

        #region private void exampleTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)

        /// <summary>
        /// Displays the documentation for the selected example.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exampleTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != null && e.Node.Tag is ExampleInfo)
            {
                ExampleInfo info = (ExampleInfo)e.Node.Tag;
                string doc;
                if (!String.IsNullOrEmpty(info.MetaData.Documentation))
                    doc = Path.Combine(docsPath, info.MetaData.Documentation);
                else
                    doc = Path.Combine(docsPath, "Missing doc.html");
                docBrowser.Navigate(doc);
            }
        }

        #endregion

        #region private ExampleInfo CompileExample(string filename)

        /// <summary>
        /// Compiles the given example and returns an ExampleInfo struct that describes
        /// this example.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private bool CompileExample(ref ExampleInfo info, bool generateInMemory)
        {
            string source = Path.Combine(sourcePath, info.Source);
            options.OutputAssembly = Path.Combine(outputPath, Path.ChangeExtension(info.Source, "exe"));
            options.GenerateInMemory = generateInMemory;

            info.Result = compiler.CompileAssemblyFromFile(options, source);

            if (generateInMemory)
            {
                //info.MetaData = ExampleAttribute.GetCustomAttribute(result.CompiledAssembly, typeof(ExampleAttribute))
                //                as ExampleAttribute;

                Type[] types = info.Result.CompiledAssembly.GetTypes();
                object[] attributes = types[0].GetCustomAttributes(false);
                foreach (object attr in attributes)
                    if (attr.GetType() == typeof(ExampleAttribute))
                        info.MetaData = (ExampleAttribute)attr;
            }
            return info.Result.Errors.Count == 0;
        }

        #endregion

        #region private void LaunchExample(ExampleInfo info)

        /// <summary>
        /// Launches the selected example.
        /// </summary>
        /// <param name="info"></param>
        private void LaunchExample(ExampleInfo info)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            // Check if we need to recompile the example.
            if (String.IsNullOrEmpty(info.Executable) ||
                (File.Exists(info.Executable)) &&
                File.GetLastWriteTime(Path.Combine(sourcePath, info.Source)).CompareTo(File.GetLastWriteTime(info.Executable)) > 0)
                CompileExample(ref info, false);

            if (!String.IsNullOrEmpty(info.Executable))
            {
                ProcessStartInfo p = new ProcessStartInfo(info.Executable);
                p.CreateNoWindow = true;
                p.UseShellExecute = false;
                System.Diagnostics.Process.Start(p);
            }
            else
                MessageBox.Show(info.Result.Errors.ToString(), "Compilation failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #endregion
    }
}
