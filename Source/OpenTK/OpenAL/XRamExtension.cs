using System;
using System.Runtime.InteropServices;

namespace OpenTK.OpenAL
{
    public sealed class XRam
    {
        private bool _valid = false;

        /// <summary>Returns True if the X-Ram Extension has been found and could be initialized.</summary>
        public bool IsInitialized
        {
            get { return _valid; }
        }

        // X-RAM Function pointer definitions
        unsafe delegate AL.Bool SetBufferMode( int n, ref uint buffers, int value );
        //typedef ALboolean (__cdecl *EAXSetBufferMode)(ALsizei n, ALuint *buffers, ALint value);

        delegate int GetBufferMode( uint buffer, out int value );
        //typedef ALenum    (__cdecl *EAXGetBufferMode)(ALuint buffer, ALint *value);

        private SetBufferMode EAXSetBufferMode;
        private GetBufferMode EAXGetBufferMode;

        private int AL_EAX_RAM_SIZE, AL_EAX_RAM_FREE,
                    AL_STORAGE_AUTOMATIC, AL_STORAGE_HARDWARE, AL_STORAGE_ACCESSIBLE;

        public XRam( )
        { // Query if Extension supported and retrieve Tokens/Pointers if it is.
            _valid = false;
            if ( AL.IsExtensionPresent( "EAX-RAM" ) == AL.Bool.False )
                return;

            AL_EAX_RAM_SIZE = AL.GetEnumValue( "AL_EAX_RAM_SIZE" );
            AL_EAX_RAM_FREE = AL.GetEnumValue( "AL_EAX_RAM_FREE" );
            AL_STORAGE_AUTOMATIC = AL.GetEnumValue( "AL_STORAGE_AUTOMATIC" );
            AL_STORAGE_HARDWARE = AL.GetEnumValue( "AL_STORAGE_HARDWARE" );
            AL_STORAGE_ACCESSIBLE = AL.GetEnumValue( "AL_STORAGE_ACCESSIBLE" );

            Console.WriteLine( "RamSize: {0} RamFree: {1} StorageAuto: {2} StorageHW: {3} StorageAccess: {4}", AL_EAX_RAM_SIZE, AL_EAX_RAM_FREE, AL_STORAGE_AUTOMATIC, AL_STORAGE_HARDWARE, AL_STORAGE_ACCESSIBLE );
            Console.WriteLine( "Free Ram: {0} / {1}", GetRamFree( ), GetRamSize( ) );

            EAXGetBufferMode = (GetBufferMode)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("EAXGetBufferMode"), typeof(GetBufferMode));
            EAXSetBufferMode = (SetBufferMode)Marshal.GetDelegateForFunctionPointer(AL.GetProcAddress("EAXSetBufferMode"), typeof(SetBufferMode));

            // Todo: add some error checking

            //////////////////////////////////////////////////////////////////////////////
            // Query X-RAM Function pointers
            // 
            // Use typedefs defined above to get the X-RAM function pointers using
            // alGetProcAddress
            //
            // EAXSetBufferMode eaxSetBufferMode;
            // EAXGetBufferMode eaxGetBufferMode;
            //
            // eaxSetBufferMode = (EAXSetBufferMode)alGetProcAddress("EAXSetBufferMode");
            // eaxGetBufferMode = (EAXGetBufferMode)alGetProcAddress("EAXGetBufferMode");

            _valid = true;
        }

        #region Public Methods

        /// <summary>Query total amount of X-RAM.</summary>
        public int GetRamSize( )
        {
            if ( _valid )
                return AL.GetInteger( (Enums.AlGlobalState) AL_EAX_RAM_SIZE );
            else
                return -1;
        }

        /// <summary>Query free X-RAM available.</summary>
        public int GetRamFree( )
        {
            if ( _valid )
                return AL.GetInteger( (Enums.AlGlobalState) AL_EAX_RAM_FREE );
            else
                return -1;
        }

        public enum XRamStorage : byte
        {
            /// <summary>Put an Open AL Buffer into X-RAM if memory is available, otherwise use host RAM.  This is the default mode.
            /// alGenBuffers(1, &uiBuffer);
            /// eaxSetBufferMode(1, &uiBuffer, alGetEnumValue("AL_STORAGE_AUTOMATIC"));
            /// alBufferData(...);
            /// </summary>
            Automatic,
            /// <summary>Force an Open AL Buffer into X-RAM (good for non-streaming buffers)
            // alGenBuffers(1, &uiBuffer);
            // eaxSetBufferMode(1, &uiBuffer, alGetEnumValue("AL_STORAGE_HARDWARE"));
            // alBufferData(...);
            /// </summary>
            Hardware = 1,
            /// <summary>Force an Open AL Buffer into 'accessible' (currently host) RAM (good for streaming buffers)
            /// alGenBuffers(1, &uiBuffer);
            /// eaxSetBufferMode(1, &uiBuffer, alGetEnumValue("AL_STORAGE_ACCESSIBLE"));
            /// alBufferData(...);
            /// </summary>
            Acessible = 2,

        }

        public void _SetBufferMode( ref uint buffer, XRamStorage mode )
        {
            if ( _valid == false )
                return;

            switch ( mode )
            {
            case XRamStorage.Acessible:
                EAXSetBufferMode( 1, ref buffer, AL_STORAGE_ACCESSIBLE );
                break;
            case XRamStorage.Hardware:
                EAXSetBufferMode( 1, ref buffer, AL_STORAGE_HARDWARE );
                break;
            default:
                EAXSetBufferMode( 1, ref buffer, AL_STORAGE_AUTOMATIC );
                break;
            }
        }

        #endregion Public Methods

    }
}
