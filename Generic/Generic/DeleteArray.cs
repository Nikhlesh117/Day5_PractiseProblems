using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class DeleteArray
    {
        public void DeleteInt(int[] arr, int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            int[] new_arr = new int[arr.Length - 1];
            int new_index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != index)
                {
                    new_arr[new_index] = arr[i];
                    new_index++;
                }
            }
            Console.WriteLine($"Element at index {index} deleted successfully.");
            for (int i = 0; i < new_arr.Length; i++)
            {
                Console.Write($"{new_arr[i]} ");
            }
        }

        public void DeleteDouble(double[] arr, int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            double[] new_arr = new double[arr.Length - 1];
            int new_index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != index)
                {
                    new_arr[new_index] = arr[i];
                    new_index++;
                }
            }
            Console.WriteLine($"\nElement at index {index} deleted successfully.");
            for (int i = 0; i < new_arr.Length; i++)
            {
                Console.Write($"{new_arr[i]} ");
            }
        }

        public void DeleteChar(char[] arr, int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            char[] new_arr = new char[arr.Length - 1];
            int new_index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != index)
                {
                    new_arr[new_index] = arr[i];
                    new_index++;
                }
            }
            Console.WriteLine($"\nElement at index {index} deleted successfully.");
            for (int i = 0; i < new_arr.Length; i++)
            {
                Console.Write($"{new_arr[i]} ");
            }
        }

    }
}
