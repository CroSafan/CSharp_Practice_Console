using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {100,123,55,999, 5,3,2,234,324,4234,1,2,1 };
            array = BubbleSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }
            Console.Read();

        }
        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    }
                    
                }
            }
            return array;
        }
    }
}
