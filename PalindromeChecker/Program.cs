using System;
using System.Linq;

namespace PalindromeChecker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string stringToCheck = Console.ReadLine();
            if (IsPalindrome(stringToCheck)) Console.WriteLine("It is a palindrome");
            else Console.WriteLine("Is not a palindrome");

            Console.Read();
        }

        public static bool IsPalindrome(string toCheck)
        {
            //it is important to have the new string part, otherwise it is a Char array
            string reverse = new string(toCheck.Reverse().ToArray());
            if (toCheck == reverse) return true;
            else return false;
        }
    }
}