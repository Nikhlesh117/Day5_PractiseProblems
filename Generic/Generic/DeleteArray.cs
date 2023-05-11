using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class DeleteArray<T>
    {
        public void Delete(T[] arr, int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            T[] new_arr = new T[arr.Length - 1];
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
