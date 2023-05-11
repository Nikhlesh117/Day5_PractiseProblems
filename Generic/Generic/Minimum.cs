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
            Console.WriteLine("Enter three String-point numbers:");
            string str_one = Console.ReadLine();
            string str_two = Console.ReadLine();
            string str_three = Console.ReadLine();

            string min = str_one;
            if (str_two.CompareTo(min) < 0)
            {
                min = str_two;
            }
            if (str_three.CompareTo(min) < 0)
            {
                min = str_three;
            }

            Console.WriteLine("Minimum value is: " + min);
        }
    }
}
