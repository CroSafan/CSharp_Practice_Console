using System;

namespace Fizz_Buzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else if (i % 5 == 0 && i % 3 == 0) Console.WriteLine("Fizz Buzz");
                else Console.WriteLine(" {0}", i);
            }
            Console.Read();
        }
    }
}