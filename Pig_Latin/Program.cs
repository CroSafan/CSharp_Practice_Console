using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pig_Latin
{
    class Program
    {
        /// <summary>
        /// Pig Latin -
        /// Pig Latin is a game of alterations played on the English language game. 
        /// To create the Pig Latin form of an English word the initial consonant sound is
        /// transposed to the end of the word and an ay is affixed 
        /// (Ex.: "banana" would yield anana-bay). Read Wikipedia for more information on rules.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(PigLatin("banana"));
            Console.Read();
        }


        public static string PigLatin(string inputString)
        {
            string memString = "";
    
            
          if(inputString.ToLower()[0]=='o' ||(inputString.ToLower()[0] == 'a') ||(inputString.ToLower()[0] == 'e') ||(inputString.ToLower()[0] == 'i') ||(inputString.ToLower()[0] == 'o'))
            {
                return inputString + "way";
            }else
            {
                for(int i = 0; i < inputString.Length; i++)
                {
                    if (inputString.ToLower()[i] != 'a' && inputString.ToLower()[i] != 'e' && inputString.ToLower()[i] != 'i' && inputString.ToLower()[i] != 'o' && inputString.ToLower()[i] != 'u')
                    {
                        memString += inputString[i];
                        inputString = inputString.Substring(i, inputString.Length);
                        
                    }
                    else break;
                }
                return  inputString+memString + "ay";
            }
        }
    }
}
