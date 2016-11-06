using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_to_Decimal_Converter
{
    /// <summary>
    /// Binary to Decimal and Back Converter - 
    /// Develop a converter to convert a decimal number 
    /// to binary or a binary number to its decimal equivalent.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(DecimalToBinary(number));

            Console.Read();
        }



        public static string DecimalToBinary(int number)
        {
            string binary="";
            while (number != 0)
            {
                binary += (number % 2).ToString();
                number = number / 2;
            }

            binary.Reverse();
            return binary;
        }
    }
}
