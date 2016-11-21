using System;

namespace Prime_Factorization
{
    internal class Program
    {
        public static bool isPrime(int x)
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //Prime Factorization - Have the user enter a number
        //and find all Prime Factors (if there are any) and display them.
        private static void Main(string[] args)
        {
            Console.WriteLine("Eneter a number!");
            int number = Convert.ToInt16(Console.ReadLine());
            //if (isPrime(number)) Console.WriteLine("Its a prime"); else Console.WriteLine("its not a prime");
            //works, but it is a incomplete solution, does not work on very large numbers
            if (!isPrime(number))
            {
                while (number != 0)
                {
                    if (number % 2 == 0)
                    {
                        Console.Write("2,");
                        number = number / 2;
                    }
                    else if (number % 3 == 0)
                    {
                        Console.Write("3,");
                        number = number / 3;
                    }
                    else if (number % 5 == 0)
                    {
                        Console.Write("5,");
                        number = number / 5;
                    }
                    else if (number % 7 == 0)
                    {
                        Console.Write("7,");
                        number = number / 7;
                    }
                    else if (number % 9 == 0)
                    {
                        Console.Write("9,");
                        number = number / 9;
                    }
                    else if (number % 11 == 0)
                    {
                        Console.Write("11,");
                        number = number / 11;
                    }
                    else
                    {
                        Console.Write(number);
                        number = 0;
                    }
                }
            }
            else
            {
                Console.WriteLine("Can not find prime factor, your entered number is  prime!");
            }
            Console.Read();
        }
    }
}