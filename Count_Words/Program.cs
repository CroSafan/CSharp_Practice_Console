using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Count_Words
{
    class Program
    {
        /// <summary>
        /// Count Words in a String - 
        /// Counts the number of individual words in a string. 
        /// For added complexity read these strings
        /// in from a text file and generate a summary.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)

        {
            //Username of Windows
            string name = Environment.UserName;
            //absolute path
            string path = @"C:\\Users\"+name+@"\Desktop\file.txt";
            string readText = File.ReadAllText(path); 
            Console.WriteLine(WordCountForOneLine(readText));
            Console.Read();
        }


        public static int WordCountForOneLine(string sentence)
        {
            //regular expression for a word, only Matches(true) if it is a word, no need to check for whitespaces
            return Regex.Matches(sentence, @"[A-Za-z0-9]+").Count;
        }
    }
}
