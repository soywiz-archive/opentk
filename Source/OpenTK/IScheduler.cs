using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK
{
    interface IScheduler
    {
        void Start();
        void Stop();
        bool Poll(out double elapsed);
        void Sleep();
        double UpdateFrequency { get; set; }
        double UpdatePeriod { get; set; }
    }
}
