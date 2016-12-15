using System;
using System.Collections.Generic;
using System.Linq;

namespace BiggerAndSmallerNumberFromDigits
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string max = "";
            string min = "";
            int veci = 0;
            int manji = 0;
           
            var digits = new List<int>();
            Console.WriteLine("Please enter a number from 100-10000");
            int number;
            bool result = Int32.TryParse(Console.ReadLine(), out number);
            int number1 = number;
            if (!result) Console.WriteLine("You didn't enter a number");
            else
            {
                if (number < 100 || number > 10000)
                {
                    Console.WriteLine("You didn't enter a number in the correct range");
                }
                else
                {
                    while (number > 0)
                    {
                        digits.Add(number % 10);
                        number /= 10;
                    }

                    digits.Sort((a, b) => (a.ToString()[0].CompareTo(b.ToString()[0])));
                    foreach (var item in digits)
                    {
                        max += item.ToString();
                    }
                    digits.Sort((a, b) => (b.ToString()[0].CompareTo(a.ToString()[0])));
                    foreach (var item in digits)
                    {
                        min += item.ToString();
                    }
                    manji = Convert.ToInt32(max.ToString());
                    veci = Convert.ToInt32(min.ToString());
                    for (int i = number1 + 1; i <= veci; i++)
                    {
                        if (cointainsNumbers(i, digits))
                        {
                            Console.WriteLine("Veci broj je{0}", i);
                            
                            break;
                        }
                        
                    }
                    for (int i = number1 - 1; i >= manji; i--)
                    {
                        if (cointainsNumbers(i, digits))
                        {
                            Console.WriteLine("Manji broj je{0}", i);
                            
                            break;
                        }
                        
                    }
                }
            }
           
            //Console.WriteLine(min);
            //Console.WriteLine(max);
            Console.Read();
        }

        private static bool cointainsNumbers(int number, List<int> numbers)
        {
            var digitsInNumber = new List<int>();
            var interstectionList = new List<int>();
            while (number > 0)
            {
                digitsInNumber.Add(number % 10);
                number /= 10;
            }


            interstectionList = numbers.Intersect(digitsInNumber).ToList();
            if (interstectionList.Count == numbers.Count) return true;
            else
                return false;
        }
    }
}