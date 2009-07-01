using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenTK.Audio
{
    public class AudioCapture : IDisposable
    {


        /// <summary>This must stay private info so the end-user cannot call any Alc commands for the recording device.</summary>
        private IntPtr Handle;

        /// <summary>Alc.CaptureStop should be called prior to device shutdown, this keeps track of Alc.CaptureStart/Stop calls.</summary>
        private bool _isrecording = false;

        private string device_name;
        public string DeviceName
        {
            get
            {
                return device_name;
            }
        }

        #region Constructor

        static AudioCapture()
        {
            if (AudioDeviceEnumerator.IsOpenALSupported) // forces enumeration
            {
            }
        }

        private string ErrorMessage(string devicename, uint frequency, ALFormat bufferformat, int buffersize)
        {
            string alcerrmsg;
            AlcError alcerrcode = Alc.GetError(IntPtr.Zero);
            switch (alcerrcode)
            {
                case AlcError.OutOfMemory:
                    alcerrmsg = alcerrcode.ToString() + ": The specified device is invalid, or can not capture audio.";
                    break;
                case AlcError.InvalidValue:
                    alcerrmsg = alcerrcode.ToString() + ": One of the parameters has an invalid value.";
                    break;
                default:
                    alcerrmsg = alcerrcode.ToString();
                    break;
            }
            return "The handle returned by Alc.CaptureOpenDevice is null." +
                   "\nAlc Error: " + alcerrmsg +
                   "\nDevice Name: " + devicename +
                   "\nCapture frequency: " + frequency +
                   "\nBuffer format: " + bufferformat +
                   "\nBuffer Size: " + buffersize);
        }

        List<string> ErrorMessages = new List<string>();

        [CLSCompliant(true)]
        public AudioCapture(string devicename, int frequency, ALFormat bufferformat, int buffersize)
            : this(devicename, (uint)frequency, bufferformat, buffersize)
        {
        }

        /// <summary>Opens a device for audio recording.</summary>
        /// <param name="devicename">The device name.</param>
        /// <param name="frequency">The frequency that the data should be captured at.</param>
        /// <param name="bufferformat">The requested capture buffer format.</param>
        /// <param name="buffersize">The size of OpenAL's capture internal ring-buffer. This value expects number of samples, not bytes.</param>
        [CLSCompliant(false)]
        public AudioCapture(string devicename, uint frequency, ALFormat bufferformat, int buffersize)
        {
            if (!AudioDeviceEnumerator.IsOpenALSupported)
                throw new DllNotFoundException("openal32.dll");

            device_name = devicename;
            Handle = Alc.CaptureOpenDevice(devicename, frequency, bufferformat, buffersize);
            if (Handle == IntPtr.Zero)
            {
              ErrorMessages.Add(ErrorMessage(devicename, frequency, bufferformat, buffersize));
              device_name = "IntPtr.Zero";
              Handle = Alc.CaptureOpenDevice(null, frequency, bufferformat, buffersize); 
            }
            if (Handle == IntPtr.Zero)
            {
                ErrorMessages.Add(ErrorMessage("IntPtr.Zero", frequency, bufferformat, buffersize));
                device_name = AudioDeviceEnumerator.DefaultRecordingDevice;
                Handle = Alc.CaptureOpenDevice(AudioDeviceEnumerator.DefaultRecordingDevice, frequency, bufferformat, buffersize);
            }
            if (Handle == IntPtr.Zero)
            {
                ErrorMessages.Add(ErrorMessage(AudioDeviceEnumerator.DefaultRecordingDevice, frequency, bufferformat, buffersize));
                // try iterate through all known devices
                for (int i = 0; i < AudioDeviceEnumerator.AvailableRecordingDevices.Count; i++)
                {
                    device_name = AudioDeviceEnumerator.AvailableRecordingDevices[i];
                    Handle = Alc.CaptureOpenDevice(AudioDeviceEnumerator.AvailableRecordingDevices[i], frequency, bufferformat, buffersize);
                    if (Handle == IntPtr.Zero)
                        ErrorMessages.Add(ErrorMessage(AudioDeviceEnumerator.AvailableRecordingDevices[i], frequency, bufferformat, buffersize));
                    else
                        break; // success! found a valid device
                }
            }

            // everything failed 
            if (Handle == IntPtr.Zero)
            {
                device_name = "None";
                foreach (string s in ErrorMessages)
                    Debug.WriteLine(s);
                throw new AudioDeviceException("All attempts to open capture devices returned IntPtr.Zero. See debug log for verbose list.");
            }

            // handle is not null, check for some Alc Error
            AlcError err = this.CurrentAlcError;
            switch (err)
            {
                case AlcError.NoError:
                    // everything went fine, do nothing
                    break;
                case AlcError.OutOfMemory:
                    throw new AudioDeviceException("Alc.CaptureOpenDevice (Handle: " + Handle + ") reports Alc Error (" + err.ToString() + ") The specified device is invalid, or can not capture audio.");
                case AlcError.InvalidValue:
                    throw new AudioDeviceException("Alc.CaptureOpenDevice (Handle: " + Handle + ") reports Alc Error (" + err.ToString() + ") One of the parameters has an invalid value.");
                default:
                    throw new AudioDeviceException("Alc.CaptureOpenDevice (Handle: " + Handle + ") reports Alc Error: " + err.ToString());
            }

            device_name = devicename;
        }

        #endregion Constructor

        #region Destructor

        ~AudioCapture()
        {
            Dispose();
        }

        private bool IsDisposed;

        /// <summary>Closes the device and disposes the instance.</summary>
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

        #endregion Destructor

        #region Error Checking

        /// <summary>Returns the first encountered Alc Error by this device.</summary>
        public AlcError CurrentAlcError
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

        #region Available samples property

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

        #endregion Available samples property

        #region Capture previously recorded samples

        /// <summary>This function will write previously recorded samples to a location in memory. It does not block.</summary>
        /// <param name="buffer">A pointer to a previously initialized and pinned array.</param>
        /// <param name="samplecount">The number of samples to be written to the buffer.</param>
        public void GetSamples(IntPtr buffer, int samplecount)
        {
            Alc.CaptureSamples(Handle, buffer, samplecount);
        }

        #endregion Capture previously recorded samples
    }
}
