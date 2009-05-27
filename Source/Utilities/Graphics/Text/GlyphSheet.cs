#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2008 the Open Toolkit library, except where noted.
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
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Graphics.Text
{
    class GlyphSheet<T> : IDisposable where T : Texture2D
    {
        #region Fields

        readonly T texture;
        readonly GlyphPacker packer;

        bool disposed;

        #endregion

        #region Constructors

        public GlyphSheet(int width, int height)
        {
            texture = (T)typeof(T).GetConstructor(new Type[] { typeof(int), typeof(int) }).Invoke(new object[] { width, height });
            //texture.MagnificationFilter = TextureMagFilter.Nearest;
            //texture.MinificationFilter = TextureMinFilter.Nearest;
            packer = new GlyphPacker(width, height);
        }

        #endregion

        #region Public Members

        public T Texture
        {
            get { return texture; }
        }

        public GlyphPacker Packer
        {
            get { return packer; }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            if (!disposed)
            {
                texture.Dispose();
                disposed = true;
            }
        }

        #endregion
    }
}
