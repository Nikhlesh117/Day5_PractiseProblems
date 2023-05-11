using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Minimum
    {
        public T Min<T>(T value_one, T value_two, T value_three) where T : IComparable<T>
        {
            T minimum = value_one;
            if (value_two.CompareTo(minimum) < 0)
            {
                minimum = value_two;
            }
            if (value_three.CompareTo(minimum) < 0)
            {
                minimum = value_three;
            }
            return minimum;
        }
    }
}
