using System;

namespace FibbonachiSeq
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //enter a number and have the program generate the
            //Fibonacci sequence to that number or to the Nth number.

            Console.WriteLine("Enter a number");
            int n = Convert.ToInt16(Console.ReadLine());
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int spremnik = a;
                a = b;
                b = spremnik + b;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}