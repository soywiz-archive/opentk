using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK.Audio;
using System.Runtime.InteropServices;
using System.Threading;

namespace Parrot
{
    public partial class Parrot : Form
    {
        public Parrot()
        {
            InitializeComponent();

            this.Text = "OpenAL Parrot (" + (IntPtr.Size == 4 ? "x86" : "x64") + ")";

            #region Fill the combobox

            IList<string> recorders = AudioCapture.AvailableDevices;
            for (int i = 0; i < recorders.Count; i++)
            {
                if (!String.IsNullOrEmpty(recorders[i]))
                    comboBox_RecorderSelection.Items.Add(recorders[i]);
            }
            comboBox_RecorderSelection.SelectedIndex = 0;

            #endregion Fill the combobox
        }

        #region Forms related

        private void button_Start_Click(object sender, EventArgs e)
        {
            button_Start.Enabled = false;
            button_Stop.Enabled = true;

            groupBox_RecorderParameters.Enabled = false;

            this.StartRecording();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            button_Start.Enabled = true;
            button_Stop.Enabled = false;

            groupBox_RecorderParameters.Enabled = true;

            this.StopRecording();
        }

        private void timer_GetSamples_Tick(object sender, EventArgs e)
        {
            this.GetSamples();
        }

        private void Parrot_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.StopRecording();
        }

        #endregion Forms related

        #region OpenAL related

        private AudioContext AC;
        private int src;
        private AudioCapture rec;
        private int Frequency;
        private IntPtr BufferPtr;
        private GCHandle BufferHandle;
        private byte[] BufferArray;
        private const byte SampleToByte = 2;

        private void StartRecording()
        {
            try
            {
                AC = new AudioContext();
            }
            catch (AudioException ae)
            {
                MessageBox.Show("Fatal: Cannot continue without a playback device.\nException caught when opening playback device.\n" + ae.Message);
                Application.Exit();
            }

            AL.Listener(ALListenerf.Gain, 64.0f);
            src = AL.GenSource();

            try
            {
                /*
                MessageBox.Show("Using recorder:" +
                                "\nName: " + (string)comboBox_RecorderSelection.SelectedItem +
                                "\nFrequency: " + (uint)numericUpDown_Frequency.Value +
                                "\nSamples: " + (int)numericUpDown_SamplesRingbuffer.Value);
                */
                rec = new AudioCapture((string)comboBox_RecorderSelection.SelectedItem, (uint)numericUpDown_Frequency.Value, ALFormat.Mono16, (int)numericUpDown_SamplesRingbuffer.Value);
            }
            catch (AudioDeviceException ade)
            {
                MessageBox.Show("Exception caught when opening recording device.\n" + ade.Message);
                rec = null;
            }

            if (rec == null)
                return;

            Frequency = (int)numericUpDown_Frequency.Value;

            BufferArray = new byte[(int)numericUpDown_SamplesRingbuffer.Value * SampleToByte];
            BufferHandle = GCHandle.Alloc(BufferArray, GCHandleType.Pinned);
            BufferPtr = BufferHandle.AddrOfPinnedObject();

            rec.Start();

            timer_GetSamples.Start();
            timer_GetSamples.Interval = 1000 / 20; // tick every 50ms
        }

        private void StopRecording()
        {
            if (rec == null)
                return;

            timer_GetSamples.Stop();

            rec.Stop();
            rec.Dispose();
            rec = null;

            int r;
            AL.GetSource(src, ALGetSourcei.BuffersQueued, out r);
            ClearBuffers(r);

            AL.DeleteSource(src);

            Frequency = 1;

            BufferHandle.Free();
            BufferPtr = IntPtr.Zero;
            BufferArray = null;
        }

        private void GetSamples()
        {
            if (rec == null)
                return;

            int SamplesBefore = rec.AvailableSamples;
            if (SamplesBefore == 0)
                return;

            rec.GetSamples(BufferPtr, SamplesBefore);
            int SamplesConsumed = SamplesBefore - rec.AvailableSamples;
            label_SamplesConsumed.Text = "Samples consumed: " + SamplesConsumed;

            int buf = AL.GenBuffer();
            AL.BufferData(buf, ALFormat.Mono16, BufferPtr, (int)(SamplesConsumed * SampleToByte), Frequency);
            AL.SourceQueueBuffer(src, buf);
            if (AL.GetSourceState(src) != ALSourceState.Playing)
                AL.SourcePlay(src);

            ClearBuffers(0);
        }

        public void ClearBuffers(int input)
        {
            int[] freedbuffers;
            if (input == 0)
            {
                int BuffersProcessed;
                AL.GetSource(src, ALGetSourcei.BuffersProcessed, out BuffersProcessed);
                if (BuffersProcessed == 0)
                    return;
                freedbuffers = AL.SourceUnqueueBuffers(src, BuffersProcessed);
            }
            else
            {
                freedbuffers = AL.SourceUnqueueBuffers(src, input);
            }
            AL.DeleteBuffers(freedbuffers);
        }

        #endregion OpenAL related
    }
}
