using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class Range<T> where T : System.Numerics.INumber<T>
    {
        public T Minimum { get; set; }
        public T Maximum { get; set; }

        public Range(T min, T max)
        {
            Minimum = min;
            Maximum = max >= min ? max : min;
        }

        public bool IsInRange(T value)
        {
            return value >= Minimum && value <= Maximum;
        }

        public T Length()
        {
            return Maximum - Minimum;
        }
    }
}
