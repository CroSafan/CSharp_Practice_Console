using System;

namespace Challenge_296_The_Twelve_Days_of
{
    internal class Program
    {
        /// <summary>
        /// https://www.reddit.com/r/dailyprogrammer/comments/5j6ggm/20161219_challenge_296_easy_the_twelve_days_of/
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            string[] days = new string[] {
                "first","second","third","fourth","fifth",
                "sixth","seventh","eight","ninth","tenth",
                "eleventh","twelfth"};
            string[] count = new string[] {
                "and a","two","three","four",
                "five","six","seven","eight",
                "nine","ten","eleven","twelve"};
            string[] gifts = new string[] {
                "Patridge in a Pear Tree","Turtle Doves","French Hens","Calling Birds",
                "Golden Rings","Geese a Laying","Swans a Swimming","Maids a Milking",
                "Ladies Dancing","Lords a Leaping","Pipers Piping","Drummers Drumming"};

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine("On the {0} day of Christmas \nmy true love sent to me:", days[i]);
                for (int j = i; j >= 0; j--)
                {
                    Console.WriteLine("{0} {1} ", (i == 0) ? "a" : count[j], gifts[j]);
                }
                Console.WriteLine("\n");
            }


            Console.Read();
        }
    }
}