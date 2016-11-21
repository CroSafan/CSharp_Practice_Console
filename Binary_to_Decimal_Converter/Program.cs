using System;

namespace Binary_to_Decimal_Converter
{
    /// <summary>
    /// Binary to Decimal and Back Converter -
    /// Develop a converter to convert a decimal number
    /// to binary or a binary number to its decimal equivalent.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            //for testing purpouses
            /*  for (int i = 0; i < 100; i++)
              {
              Console.WriteLine(DecimalToBinary(i));
              }*/
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine(DecimalToBinary(number));
            Console.WriteLine(BinaryToDecimal("0101111101"));
            Console.Read();

            //TODO: Exception handling
        }

        public static string DecimalToBinary(int number)
        {
            string binary = String.Empty;
            while (number != 0)
            {
                binary += (number % 2).ToString();
                number = number / 2;
            }
            //reversing the result
            binary = Reverse(binary);
            return binary;
        }

        public static int BinaryToDecimal(string number)
        {
            int result = 0;
            //reversing the number for easy handling
            number = Reverse(number);

            for (int i = 0; i < number.Length; i++)
            {
                //had to do this because if i didn't it
                //would treat number[i] as a char and convert its value to ASCII
                int currNum = int.Parse(number[i].ToString());

                result += currNum * (int)Math.Pow(2, i);
            }
            return result;
        }

        //method copied from SO
        public static string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new String(chars);
        }
    }
}