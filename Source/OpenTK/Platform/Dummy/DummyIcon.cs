using System;
using System.Drawing;
using System.IO;

namespace OpenTK.Platform.Dummy
{
    class DummyIcon : IIcon
    {
        #region IIcon Members

        public IntPtr Handle
        {
            get { return IntPtr.Zero; }
        }

        public Size Size
        {
            get { return Size.Empty; }
        }

        public int Width
        {
            get { return 0; }
        }

        public int Height
        {
            get { return 0; }
        }

        public void Save(System.IO.Stream outputStream)
        {
        }

        public byte[] GetData()
        {
            return new byte[0];
        }

        #endregion

        #region ISerializable Members

        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Save(ms);
                info.AddValue("IconSize", this.Size, typeof(Size));
                info.AddValue("IconData", ms.ToArray());
                ms.Close();
            }
        }

        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return new DummyIcon();
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
        }

        #endregion
    }
}
