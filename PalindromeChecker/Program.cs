using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
           string stringToCheck = Console.ReadLine();
            if (IsPalindrome(stringToCheck)) Console.WriteLine("It is a palindrome");
            else Console.WriteLine("Is not a palindrome");

            Console.Read();
        }

        public static bool IsPalindrome(string toCheck)
        {
            string reverse = new string(toCheck.Reverse().ToArray());
            if (toCheck == reverse) return true;
            else return false;
        }
    }
}
