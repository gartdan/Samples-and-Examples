using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimesCalculator
{
    public static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            if (enumerable == null)
                throw new ArgumentException("enumerable");
            if (action == null)
                throw new ArgumentException("action");
            foreach (T item in enumerable)
                action(item);
        }
    }
}
