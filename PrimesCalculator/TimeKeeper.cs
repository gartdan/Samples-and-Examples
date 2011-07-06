using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PrimesCalculator
{
    static class TimeKeeper
    {
        public static long Time(Action action)
        {
            var sw = new Stopwatch();
            sw.Start();
            action();
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
    }
}
