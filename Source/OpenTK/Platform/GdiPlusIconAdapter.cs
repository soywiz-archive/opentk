#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace OpenTK.Platform
{
    sealed class GdiPlusIconAdapter : IIcon
    {
        #region Fields

        readonly System.Drawing.Icon icon;

        #endregion

        #region Constructors

        public GdiPlusIconAdapter(System.Drawing.Icon icon)
        {
            if (icon == null)
                throw new ArgumentNullException("icon");
            this.icon = icon;
        }

        public GdiPlusIconAdapter(Stream stream, int width, int height)
        {
            if (stream == null)
                throw new ArgumentNullException("stream");

            if (width <= 0 || height <= 0)
                icon = new System.Drawing.Icon(stream);
            else
                icon = new System.Drawing.Icon(stream, width, height);
        }

        #endregion

        #region IIcon Members

        public IntPtr Handle
        {
            get { return icon.Handle; }
        }

        public Size Size
        {
            get { return new Size(icon.Width, icon.Height); }
        }

        public int Width
        {
            get { return icon.Width; }
        }

        public int Height
        {
            get { return icon.Height; }
        }

        public void Save(System.IO.Stream outputStream)
        {
            icon.Save(outputStream);
        }

        public byte[] GetData()
        {
            // Copy the pixel data of the icon to a byte[] array. To do this,
            // we first convert the icon to a System.Drawing.Bitmap and
            // use LockBits() to access its inner data pointer (Scan0).
            using (Bitmap bmp = icon.ToBitmap())
            {
                BitmapData bmp_data = bmp.LockBits(new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height),
                    System.Drawing.Imaging.ImageLockMode.ReadOnly,
                    System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                
                byte[] data = new byte[4 * bmp.Width * bmp.Height];
                Marshal.Copy(bmp_data.Scan0, data, 0, data.Length);

                bmp.UnlockBits(bmp_data);

                return data;
            }
        }

        #endregion

        #region ISerializable Members

        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            (icon as System.Runtime.Serialization.ISerializable).GetObjectData(info, context);
        }

        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return new GdiPlusIconAdapter((System.Drawing.Icon)icon.Clone());
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            icon.Dispose();
        }

        #endregion
    }
}
