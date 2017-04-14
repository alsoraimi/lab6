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
            Console.WriteLine("Enter a sentence to convert to PigLatin:");
            string sentence = Console.ReadLine();
            var pigLatin = GetSentenceInPigLatin(sentence);
            Console.WriteLine(pigLatin);
            Console.ReadLine();


        }


       public static string GetSentenceInPigLatin(string sentence)
        {
            const string vowels = "AEIOUaeio";
            List<string> newWords = new List<string>();

            foreach (string word in sentence.Split(' '))
            {
                string firstLetter = word.Substring(0, 1);
                string restOfWord = word.Substring(1, word.Length - 1);
                int currentLetter = vowels.IndexOf(firstLetter);

                if (currentLetter == -1)
                {
                    newWords.Add(restOfWord + firstLetter + "ay");
                }
                else
                {
                    newWords.Add(word + "way");
                }
            }
            return string.Join(" ", newWords);
        }
    }

}
