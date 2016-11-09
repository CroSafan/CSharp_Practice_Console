using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
           // reversing a string, the String class doesn't actually have the Reverse() method, it just implements it from IEnumerable<char>
            Console.WriteLine (word.Reverse().ToArray());
            Console.Read();
        }
    }
}
