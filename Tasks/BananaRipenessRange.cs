using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
       internal class BananaRipenessRange<T> where T : System.Numerics.INumber<T>
        {
            public T Minimum { get; set; }
            public T Maximum { get; set; }

            public BananaRipenessRange(T minimum, T maximum)
            {
                if (minimum <= maximum)
                {
                    Maximum = maximum;
                    Minimum = minimum;
                }
            }

            public bool IsPerfectBanana(T ripeness)
            {
                return ripeness >= Minimum && ripeness <= Maximum;
            }
        }
}