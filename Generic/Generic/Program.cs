using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] int_arr = { 1, 2, 3, 4, 5 };
            double[] double_arr = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] char_arr = { 'a', 'b', 'c', 'd', 'e' };

            DeleteArray<int> int_utils = new DeleteArray<int>();
            int_utils.Delete(int_arr, 2);

            DeleteArray<double> double_utils = new DeleteArray<double>();
            double_utils.Delete(double_arr, 4);

            DeleteArray<char> char_utils = new DeleteArray<char>();
            char_utils.Delete(char_arr, 1);

            Console.ReadKey();
        }
    }
}
