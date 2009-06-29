using System;

namespace OpenTK.Audio
{
    public class AudioCapture : IDisposable
    {
        private bool IsDisposed;

        /// <summary>This must stay private info so the end-user cannot call any Alc commands for the recording device.</summary>
        private IntPtr Handle;

        /// <summary>Alc.CaptureStop should be called prior to device shutdown, this keeps track of Alc.CaptureStart/Stop calls.</summary>
        private bool _isrecording = false;

        /* // not reliable info for end-user, Alc.CaptureStart might have failed and generated AlcError
           public bool IsRecording
           {
               get
               {
                   return IsRecording;
               }
           }*/

        #region Constructor & Destructor

        [CLSCompliant(true)]
        public AudioCapture(string devicename, int frequency, ALFormat bufferformat, int buffersize)
            : this(devicename, (uint)frequency, bufferformat, buffersize) { }

        [CLSCompliant(false)]
        public AudioCapture(string devicename, uint frequency, ALFormat bufferformat, int buffersize)
        {
            Handle = Alc.CaptureOpenDevice(devicename, frequency, bufferformat, buffersize);
            if (Handle == IntPtr.Zero)
                throw new AudioDeviceException("The handle returned by Alc.CaptureOpenDevice is null. Alc Error: " + Alc.GetError(IntPtr.Zero).ToString() +
                                               "\nDevice Name: " + devicename +
                                               "\nFrequency: " + frequency +
                                               "\nBuffer format: " + bufferformat +
                                               "\nBuffer Size: " + buffersize);
            // handle is not null, check for some Alc Error
            AlcError err = Alc.GetError(Handle);
            if (err != AlcError.NoError)
                throw new AudioDeviceException("Alc.CaptureOpenDevice (Handle: " + Handle + ") reports Alc Error: " + err.ToString());
        }

        ~AudioCapture()
        {
            Dispose();
        }

        /// <summary>Disposes the instance.</summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool manual)
        {
            if (!this.IsDisposed)
            {
                if (this.Handle != IntPtr.Zero)
                {
                    if (this._isrecording)
                        this.Stop();

                    Alc.CaptureCloseDevice(this.Handle);
                }
                this.IsDisposed = true;
            }
        }

        #endregion Constructor & Destructor

        #region Error Checking

        /// <summary>Returns the first encountered Alc Error.</summary>
        public AlcError GetError
        {
            get
            {
                return Alc.GetError(Handle);
            }
        }

        #endregion Error Checking

        #region Start & Stop Capture

        /// <summary>
        /// Start recording samples.
        /// The number of available samples can be obtained through the AvailableSamples property.
        /// The data can be queried with any GetSamples() method.
        /// </summary>
        public void Start()
        {
            Alc.CaptureStart(Handle);
            _isrecording = true;
        }

        /// <summary>Stop recording samples. This will not clear previously recorded samples.</summary>
        public void Stop()
        {
            Alc.CaptureStop(Handle);
            _isrecording = false;
        }

        #endregion Start & Stop Capture

        /// <summary>Returns the number of available samples for capture.</summary>
        public int AvailableSamples
        {
            get
            {
                // TODO: Investigate inconsistency between documentation and actual usage.
                // Doc claims the 3rd param is Number-of-Bytes, but it appears to be Number-of-Int32s
                int result;
                Alc.GetInteger(Handle, AlcGetInteger.CaptureSamples, 1, out result);

                return result;
            }
        }

        public void GetSamples(IntPtr buffer, int samplecount)
        {
            Alc.CaptureSamples(Handle, buffer, samplecount);
        }
    }
}
