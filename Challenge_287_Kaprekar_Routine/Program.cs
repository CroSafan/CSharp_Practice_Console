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

        public static int Desc_Digits(int input)
        {
            List<int> digits = new List<int>();
            if (input <= 999) digits.Add(0);
            while (input != 0)
            {
                digits.Add(input % 10);
                input /= 10;
            }
            digits = digits.OrderByDescending(number => number).ToList();
            return Convert.ToInt32(String.Concat(digits.ToArray()));
        }
        public static int Asc_Digits(int input)
        {
            List<int> digits = new List<int>();
            if (input <= 999) digits.Add(0);
            while (input != 0)
            {
                digits.Add(input % 10);
                input /= 10;
            }
            digits = digits.OrderBy(number => number).ToList();
            return Convert.ToInt32(String.Concat(digits.ToArray()));
        }

        public static int Kaprekar(int input)
        {
            int steps = 0;
            int result = input;
            if (input.ToString().Distinct().Count() < 2) return 0;
            else
            {
                while (result != 6174)
                {
                    result = Desc_Digits(result) - Asc_Digits(result);
                    steps++;
                }
                return steps;
            }




         
        }

        static void Main(string[] args)
        {

            Console.WriteLine(Largest_Digit(1234));
            Console.WriteLine(Largest_Digit(3253));
            Console.WriteLine(Largest_Digit(9800));
            Console.WriteLine(Largest_Digit(3333));
            Console.WriteLine(Largest_Digit(120));
            Console.WriteLine("------------------");
            Console.WriteLine(Desc_Digits(1234));
            Console.WriteLine(Desc_Digits(3253));
            Console.WriteLine(Desc_Digits(9800));
            Console.WriteLine(Desc_Digits(3333));
            Console.WriteLine(Desc_Digits(120));

            Console.WriteLine("---------------------");
            Console.WriteLine(Kaprekar(6589));
            Console.WriteLine(Kaprekar(5455));
            Console.WriteLine(Kaprekar(6174));
            Console.Read();
        }
    }
}
