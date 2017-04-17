using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <author>
/// Abe Alsoraimi 04/17/2017
/// </author>
namespace lab6b
{
    class Program
    {
        static void Main(string[] args)
        {

            bool AskToContinue = false;     //loop if user wants to continue using application
            do
            {
                Console.WriteLine("Welcome to the Pig Latin Translator");
                Console.WriteLine();
                Console.WriteLine("Enter a word to convert to PigLatin:");
                string sentence = Console.ReadLine().ToLower().Trim();            //gets user input of word
                Console.WriteLine(ToPigLatin(sentence));

                Console.WriteLine("Translate another word, ?" + " " + "(Y/N)"); // add user input if they want to try again
                if (Console.ReadLine().ToUpper() == "Y")
                    AskToContinue = true;
                else
                {
                    Console.WriteLine("thanks for trying!");
                    break;
                }
            } while (AskToContinue);
        }

        public static string ToPigLatin(string sentence)

        {
            if (sentence[0] == 'a' || sentence[0] == 'e' || sentence[0] == 'i' || sentence[0] == 'o' || sentence[0] == 'u')
            {
                sentence = sentence += "way";
            }
            else
            {

                string startingConsonants;      //changed temp to startingConsonants for meaningful name
                for (int i = 1; i < sentence.Length; i++)
                {
                    if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
                    {

                        startingConsonants = sentence.Substring(0, i);   //identifies begin of string before consonants
                        sentence = sentence.Remove(0, i);  //removes starting consonants from string
                        sentence += startingConsonants;     // adds starting consonats to end of sentence
                    }

                }
                sentence += "ay";     //adds ay at the end of string
            }
            return sentence;

        }



    }

}
