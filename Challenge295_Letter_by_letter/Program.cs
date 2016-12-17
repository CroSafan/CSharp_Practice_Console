using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge295_Letter_by_letter
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input1 = new string[] { "floor", "brake" };
            string[] input2 = new string[] { "wood", "book" };
            string[] input3 = new string[] { "a fall to the floor", "braking the door in" };
            LetterByLetter(input1);
            LetterByLetter(input2);
            LetterByLetter(input3);
            Console.Read();
        }


        public static void LetterByLetter(string[] input)
        {
            char[] charrArray1 = input[0].ToCharArray();
            char[] charrArray2 = input[1].ToCharArray();
            Console.WriteLine(charrArray1);
            for (int i = 0; i < charrArray1.Length; i++)
            {
                if (charrArray1[i] != charrArray2[i])
                {
                    charrArray1[i] = charrArray2[i];
                    Console.WriteLine(charrArray1);
                }



            }
        }

    }





}
