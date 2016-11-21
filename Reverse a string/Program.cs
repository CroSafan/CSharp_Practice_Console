using System;
using System.Linq;

namespace Reverse_a_string
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            // reversing a string, the String class doesn't actually have the Reverse() method, it just implements it from IEnumerable<char>
            Console.WriteLine(word.Reverse().ToArray());
            Console.Read();
        }
    }
}