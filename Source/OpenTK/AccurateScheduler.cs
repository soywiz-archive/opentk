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
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace OpenTK
{
    sealed class AccurateScheduler : IScheduler
    {
        #region Fields

        Stopwatch watch = new Stopwatch();
        double update_period, next_update;

        #endregion

        #region Constructors

        public AccurateScheduler(double updateFrequency)
        {
            if (updateFrequency < 0)
                throw new ArgumentOutOfRangeException("updateFrequency");
            UpdateFrequency = updateFrequency;
        }

        #endregion

        #region IScheduler Members

        public bool Poll(out double elapsed)
        {
            elapsed = watch.Elapsed.TotalSeconds;

            next_update -= elapsed;
            if (next_update <= 0)
            {
                next_update += update_period;
                Start();
                return true;
            }

            return false;
        }

        public void Start()
        {
            watch.Reset();
            watch.Start();
        }

        public void Stop()
        {
            next_update = 0;
            watch.Stop();
        }

        public void Sleep()
        {
        }

        public double UpdateFrequency
        {
            get { return 1.0 / update_period; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                if (value != 0)
                    update_period = 1 / value;
                else
                    update_period = Double.PositiveInfinity;
            }
        }

        public double UpdatePeriod
        {
            get { return update_period; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                update_period = value;
            }
        }

        #endregion
    }
}
