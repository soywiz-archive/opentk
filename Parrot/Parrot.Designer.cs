namespace Parrot
{
    partial class Parrot
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
            this.comboBox_RecorderSelection = new System.Windows.Forms.ComboBox();
            this.groupBox_RecorderParameters = new System.Windows.Forms.GroupBox();
            this.label_MONO16BIT = new System.Windows.Forms.Label();
            this.label_RINGBUFFER = new System.Windows.Forms.Label();
            this.label_FREQUENCY = new System.Windows.Forms.Label();
            this.numericUpDown_SamplesRingbuffer = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Frequency = new System.Windows.Forms.NumericUpDown();
            this.groupBox_RecordingControls = new System.Windows.Forms.GroupBox();
            this.label_SamplesConsumed = new System.Windows.Forms.Label();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.timer_GetSamples = new System.Windows.Forms.Timer(this.components);
            this.groupBox_RecorderParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SamplesRingbuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Frequency)).BeginInit();
            this.groupBox_RecordingControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_RecorderSelection
            // 
            this.comboBox_RecorderSelection.FormattingEnabled = true;
            this.comboBox_RecorderSelection.Location = new System.Drawing.Point(6, 19);
            this.comboBox_RecorderSelection.Name = "comboBox_RecorderSelection";
            this.comboBox_RecorderSelection.Size = new System.Drawing.Size(229, 21);
            this.comboBox_RecorderSelection.TabIndex = 0;
            // 
            // groupBox_RecorderParameters
            // 
            this.groupBox_RecorderParameters.Controls.Add(this.label_MONO16BIT);
            this.groupBox_RecorderParameters.Controls.Add(this.label_RINGBUFFER);
            this.groupBox_RecorderParameters.Controls.Add(this.label_FREQUENCY);
            this.groupBox_RecorderParameters.Controls.Add(this.numericUpDown_SamplesRingbuffer);
            this.groupBox_RecorderParameters.Controls.Add(this.numericUpDown_Frequency);
            this.groupBox_RecorderParameters.Controls.Add(this.comboBox_RecorderSelection);
            this.groupBox_RecorderParameters.Location = new System.Drawing.Point(12, 12);
            this.groupBox_RecorderParameters.Name = "groupBox_RecorderParameters";
            this.groupBox_RecorderParameters.Size = new System.Drawing.Size(245, 103);
            this.groupBox_RecorderParameters.TabIndex = 2;
            this.groupBox_RecorderParameters.TabStop = false;
            this.groupBox_RecorderParameters.Text = "Recording Device Setup";
            // 
            // label_MONO16BIT
            // 
            this.label_MONO16BIT.AutoSize = true;
            this.label_MONO16BIT.Location = new System.Drawing.Point(176, 50);
            this.label_MONO16BIT.Name = "label_MONO16BIT";
            this.label_MONO16BIT.Size = new System.Drawing.Size(64, 13);
            this.label_MONO16BIT.TabIndex = 102;
            this.label_MONO16BIT.Text = "Mono 16 Bit";
            // 
            // label_RINGBUFFER
            // 
            this.label_RINGBUFFER.AutoSize = true;
            this.label_RINGBUFFER.Location = new System.Drawing.Point(6, 76);
            this.label_RINGBUFFER.Name = "label_RINGBUFFER";
            this.label_RINGBUFFER.Size = new System.Drawing.Size(158, 13);
            this.label_RINGBUFFER.TabIndex = 101;
            this.label_RINGBUFFER.Text = "Samples in AL internal ringbuffer";
            // 
            // label_FREQUENCY
            // 
            this.label_FREQUENCY.AutoSize = true;
            this.label_FREQUENCY.Location = new System.Drawing.Point(6, 50);
            this.label_FREQUENCY.Name = "label_FREQUENCY";
            this.label_FREQUENCY.Size = new System.Drawing.Size(84, 13);
            this.label_FREQUENCY.TabIndex = 100;
            this.label_FREQUENCY.Text = "Frequency in Hz";
            // 
            // numericUpDown_SamplesRingbuffer
            // 
            this.numericUpDown_SamplesRingbuffer.Location = new System.Drawing.Point(165, 72);
            this.numericUpDown_SamplesRingbuffer.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_SamplesRingbuffer.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDown_SamplesRingbuffer.Name = "numericUpDown_SamplesRingbuffer";
            this.numericUpDown_SamplesRingbuffer.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown_SamplesRingbuffer.TabIndex = 2;
            this.numericUpDown_SamplesRingbuffer.ThousandsSeparator = true;
            this.numericUpDown_SamplesRingbuffer.Value = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            // 
            // numericUpDown_Frequency
            // 
            this.numericUpDown_Frequency.Location = new System.Drawing.Point(94, 46);
            this.numericUpDown_Frequency.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Frequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Frequency.Name = "numericUpDown_Frequency";
            this.numericUpDown_Frequency.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown_Frequency.TabIndex = 1;
            this.numericUpDown_Frequency.ThousandsSeparator = true;
            this.numericUpDown_Frequency.Value = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox_RecordingControls.Controls.Add(this.label_SamplesConsumed);
            this.groupBox_RecordingControls.Controls.Add(this.button_Stop);
            this.groupBox_RecordingControls.Controls.Add(this.button_Start);
            this.groupBox_RecordingControls.Location = new System.Drawing.Point(12, 121);
            this.groupBox_RecordingControls.Name = "groupBox2";
            this.groupBox_RecordingControls.Size = new System.Drawing.Size(245, 78);
            this.groupBox_RecordingControls.TabIndex = 3;
            this.groupBox_RecordingControls.TabStop = false;
            this.groupBox_RecordingControls.Text = "Talk to the parrot";
            // 
            // label_SamplesConsumed
            // 
            this.label_SamplesConsumed.AutoSize = true;
            this.label_SamplesConsumed.Location = new System.Drawing.Point(6, 52);
            this.label_SamplesConsumed.Name = "label_SamplesConsumed";
            this.label_SamplesConsumed.Size = new System.Drawing.Size(108, 13);
            this.label_SamplesConsumed.TabIndex = 103;
            this.label_SamplesConsumed.Text = "Samples consumed: -";
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(129, 19);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(110, 24);
            this.button_Stop.TabIndex = 4;
            this.button_Stop.Text = "Stop recording";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(6, 19);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(110, 24);
            this.button_Start.TabIndex = 3;
            this.button_Start.Text = "Start recording";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // timer_GetSamples
            // 
            this.timer_GetSamples.Tick += new System.EventHandler(this.timer_GetSamples_Tick);
            // 
            // Parrot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 211);
            this.Controls.Add(this.groupBox_RecordingControls);
            this.Controls.Add(this.groupBox_RecorderParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Parrot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenAL Parrot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Parrot_FormClosing);
            this.groupBox_RecorderParameters.ResumeLayout(false);
            this.groupBox_RecorderParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SamplesRingbuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Frequency)).EndInit();
            this.groupBox_RecordingControls.ResumeLayout(false);
            this.groupBox_RecordingControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_RecorderSelection;
        private System.Windows.Forms.GroupBox groupBox_RecorderParameters;
        private System.Windows.Forms.Label label_RINGBUFFER;
        private System.Windows.Forms.Label label_FREQUENCY;
        private System.Windows.Forms.NumericUpDown numericUpDown_SamplesRingbuffer;
        private System.Windows.Forms.NumericUpDown numericUpDown_Frequency;
        private System.Windows.Forms.GroupBox groupBox_RecordingControls;
        private System.Windows.Forms.Label label_SamplesConsumed;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_MONO16BIT;
        private System.Windows.Forms.Timer timer_GetSamples;

    }
}

