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
            DeleteArray deleteArray = new DeleteArray();
            // Delete an element from an array of integers
            int[] int_arr = { 1, 2, 3, 4, 5 };
            deleteArray.DeleteInt(int_arr, 2);

            // Delete an element from an array of doubles
            double[] double_arr = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            deleteArray.DeleteDouble(double_arr, 3);

            // Delete an element from an array of characters
            char[] char_arr = { 'a', 'b', 'c', 'd', 'e' };
            deleteArray.DeleteChar(char_arr, 5);

            Console.ReadKey();
        }
    }
}
