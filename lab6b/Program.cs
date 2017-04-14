using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to convert to PigLatin:");
            string sentence = Console.ReadLine();
            string pigLatin = ToPigLatin(sentence);
            Console.WriteLine(pigLatin);




        }

        public static string ToPigLatin(string sentence)

        {
            string FirstLetter;
            string RestofWord;
            string vowels = "aeiouAEIOU";
            int currentLetter;


           
            foreach (string word in sentence.Split())
                {
                FirstLetter = sentence.Substring(0, 1);
                RestofWord = sentence.Substring(1, sentence.Length - 1);
                currentLetter = vowels.IndexOf(FirstLetter);

                if (FirstLetter == vowels)

                {
                    sentence = sentence += "way";

                }

                else
                {

                    sentence = RestofWord + "ay";
                }

            }return sentence;


        }


       
    }

}
