using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Minimum
    {
        public void Min()
        {
            Console.WriteLine("Enter three float-point numbers:");
            float num_one = float.Parse(Console.ReadLine());
            float num_two = float.Parse(Console.ReadLine());
            float num_three = float.Parse(Console.ReadLine());

            float min = num_one;
            if (num_two < min)
            {
                min = num_two;
            }
            if (num_three < min)
            {
                min = num_three;
            }

            Console.WriteLine("Minimum value is: " + min);
        }
    }
}
