namespace Examples
{
    partial class ExampleLauncher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.exampleLauncherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exampleLauncherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.exampleLauncherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleLauncherBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 264);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // exampleLauncherBindingSource
            // 
            this.exampleLauncherBindingSource.DataSource = typeof(Examples.ExampleLauncher);
            // 
            // exampleLauncherBindingSource1
            // 
            this.exampleLauncherBindingSource1.DataSource = typeof(Examples.ExampleLauncher);
            // 
            // ExampleLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.listBox1);
            this.Name = "ExampleLauncher";
            this.Text = "OpenTK Example Launcher";
            this.Load += new System.EventHandler(this.ExampleLauncher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exampleLauncherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleLauncherBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource exampleLauncherBindingSource;
        private System.Windows.Forms.BindingSource exampleLauncherBindingSource1;
    }
}