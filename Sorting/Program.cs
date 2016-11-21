using System;
using System.Diagnostics;

namespace Sorting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            int[] array1 = { 100, 123, 55, 999, 0, 55, 5454, 12, 55, 5, 3, 2, 234, 324, 4234, 1, 2, 1, 1, 342, 234, 234, 12, 12312, 23, 4334, 4534534, 32, 1, 12, 3, 4, 5, 6, 3, 666, 43, 453, 234, 12, 4566, 456 };
            int[] array = { 100, 123, 55, 999, 0, 55, 5454, 12, 55, 5, 3, 2, 234, 324, 4234, 1, 2, 1, 1, 342, 234, 234, 12, 12312, 23, 4334, 4534534, 32, 1, 12, 3, 4, 5, 6, 3, 666, 43, 453, 234, 12, 4566, 456 };
            sw.Start();
            array1 = BubbleSort(array);
            sw.Stop();

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine(sw.Elapsed);
            int[] nekaj = new int[25];
            sw.Start();
            MergeSort(array, nekaj, 0, array.Length - 1);
            sw.Stop();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine(sw.Elapsed);
            Console.Read();
        }

        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
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

        public static void MergeSort(int[] array, int[] pomPolje, int lijevo, int desno)
        {
            int sredina;
            if (lijevo < desno)
            {
                sredina = lijevo + (desno - lijevo) / 2;
                MergeSort(array, pomPolje, lijevo, sredina);
                MergeSort(array, pomPolje, sredina + 1, desno);
                Merge(array, pomPolje, lijevo, sredina + 1, desno);
            }
        }

        private static void Merge(int[] array, int[] pomPolje, int lijevo, int sredina, int desno)
        {
            int[] temp = new int[45];
            int i, eol, num, pos;

            eol = (sredina - 1);
            pos = lijevo;
            num = (desno - lijevo + 1);

            while ((lijevo <= eol) && (sredina <= desno))
            {
                if (array[lijevo] <= array[sredina])
                    temp[pos++] = array[lijevo++];
                else
                    temp[pos++] = array[sredina++];
            }

            while (lijevo <= eol)
                temp[pos++] = array[lijevo++];

            while (sredina <= desno)
                temp[pos++] = array[sredina++];

            for (i = 0; i < num; i++)
            {
                array[desno] = temp[desno];
                desno--;
            }
        }
    }
}