using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_283_Anagram_Detector
{
    class Program
    {

        /// <summary>
        /// https://www.reddit.com/r/dailyprogrammer/comments/52enht/20160912_challenge_283_easy_anagram_detector/
        /// </summary>
        /// <param name="args"></param>
        /// 
        public static void IsAnagram(string input1, string input2)
        {
            var input1Sorted = input1.ToLower().Replace(" ", "").Replace("'", "").Trim().ToCharArray().OrderBy(x => x);
            var input2Sorted = input2.ToLower().Replace(" ", "").Replace("'", "").Trim().ToCharArray().OrderBy(x => x);

            if (input1Sorted.SequenceEqual(input2Sorted))
            {
                Console.WriteLine("{0} is an anagram of {1}", input1, input2);
            }
            else
            {
                Console.WriteLine("{0} is NOT an anagram of {1}", input1, input2);
            }


        }


        static void Main(string[] args)
        {
            IsAnagram("Clint Eastwood", "Old West Action");
            IsAnagram("parliament", "partial man");
            IsAnagram("wisdom", "mid sow");
            IsAnagram("Seth Rogan", "Gathers No");
            IsAnagram("Reddit", "Eat Dirt");
            IsAnagram("Eat Dirt", "Old West Action");
            IsAnagram("Schoolmaster", "The classroom");
            IsAnagram("Astronomers", "Moon starer");
            IsAnagram("Vacation Times", "I'm Not as Active");
            IsAnagram("Clint Eastwood", "Old West Action");
            IsAnagram("Dormitory", "Dirty Rooms");
            Console.Read();
        }
    }
}
