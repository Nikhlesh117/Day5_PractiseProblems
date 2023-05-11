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

            int[] int_arr = new int[] { 1, 2, 3, 4, 5 };
            deleteArray.DeleteElement<int>(int_arr, 2); 

            double[] double_arr = new double[] { 1.0, 2.0, 3.0, 4.0, 5.0 };
            deleteArray.DeleteElement<double>(double_arr, 4); 

            char[] char_arr = new char[] { 'a', 'b', 'c', 'd', 'e' };
            deleteArray.DeleteElement<char>(char_arr, 1);

            Console.ReadKey();
        }
    }
}
