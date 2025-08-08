using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }



        public int CompareTo(Point? other)
        {
            if (other is not null)
            {
                if (X == other.X)
                    return Y.CompareTo(other.Y);

                else
                    return X.CompareTo(other.X);
            }

            return 1;
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }
    }
}
