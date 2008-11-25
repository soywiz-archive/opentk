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
    // Uniquely identifies a block of text. This structure can be used to identify text blocks for caching.
    struct TextBlock : IEquatable<TextBlock>
    {
        #region Fields

        public readonly string Text;

        public readonly Font Font;

        public readonly RectangleF LayoutRectangle;

        public readonly TextPrinterOptions Options;

        public int UsageCount;     // Used to identify old and unused blocks of text.

        #endregion

        #region Constructors

        public TextBlock(string text, Font font, TextPrinterOptions options, RectangleF layoutRectangle)
        {
            Text = text;
            Font = font;
            LayoutRectangle = layoutRectangle;
            Options = options;
            UsageCount = 0;
        }

        #endregion

        #region Public Members

        public override bool Equals(object obj)
        {
            if (!(obj is TextBlock))
                return false;

            return Equals((TextBlock)obj);
        }

        public override int GetHashCode()
        {
            return Text.GetHashCode() ^ Font.GetHashCode() ^ LayoutRectangle.GetHashCode() ^ Options.GetHashCode();
        }

        #endregion

        #region IEquatable<TextBlock> Members

        public bool Equals(TextBlock other)
        {
            return
                Text == other.Text &&
                Font == other.Font &&
                LayoutRectangle == other.LayoutRectangle &&
                Options == other.Options;
        }

        #endregion
    }
}