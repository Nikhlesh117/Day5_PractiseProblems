using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Minimum<T> where T : IComparable<T>
    {
        private T a;
        private T b;
        private T c;

        public Minimum(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public T Min()
        {
            T min = a;
            if (b.CompareTo(min) < 0)
            {
                min = b;
            }
            if (c.CompareTo(min) < 0)
            {
                min = c;
            }
            return min;
        }

        public void TestMinimum()
        {
            T min = Min();
            Console.WriteLine($"The minimum of {a}, {b}, and {c} is {min}");
        }
    }
}
