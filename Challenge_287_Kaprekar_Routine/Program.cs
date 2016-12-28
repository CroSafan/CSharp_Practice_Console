using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_287_Kaprekar_Routine
{
    class Program
    {
        public static int Largest_Digit(int input)
        {
            int max = 0;
            while (input != 0)
            {
                if (max < input % 10) max = input % 10;
                input /= 10;
            }
            return max;
        }

        static void Main(string[] args)
        {
            /*int broj = 0232;
            int nekaj = Convert.ToInt32(broj.ToString("D4"));
            while (nekaj != 0)
            {
                Console.WriteLine(nekaj % 10);
                nekaj /= 10;
            }*/
            Console.WriteLine(Largest_Digit(1234));
            Console.WriteLine(Largest_Digit(3253));
            Console.WriteLine(Largest_Digit(9800));
            Console.WriteLine(Largest_Digit(3333));
            Console.WriteLine(Largest_Digit(120));
            Console.Read();
        }
    }
}
