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

            bool loop = true;     //loop if user wants to continue using application
            do
            {
                Console.WriteLine("Welcome to the Pig Latin Translator");
                Console.WriteLine();
                string sentence = GetValidInput();            //gets user input of word
                string[] words = SplitIntoWords(sentence);
                ToPigLatin(words);

           if (!ContinueLoop())
                {
                    loop = false;
                }

            } while (loop);
        }

        public static void ToPigLatin(string[] words)

        {
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            foreach (string item in words)
            {
                if (item.IndexOfAny(vowels) == 0)
                {
                    Console.Write(item + "way ");
                }
                else if (item.IndexOfAny(vowels) == -1)
                {
                    Console.Write(item + "ay ");
                }
                else
                {
                    //Creates a substring starting at index 0 to the length of the index of the first vowel
                    string starting = item.Substring(0, item.IndexOfAny(vowels));

                    //Creates a substring at index of the first vowel to the end of the word
                    string ending = item.Substring(item.IndexOfAny(vowels));
                    Console.Write(ending + starting + "ay ");
                }
            }
            Console.WriteLine("\n");


        }

        public static string GetValidInput()

        {
            while (true)
            {
                Console.WriteLine("Enter a word to convert to PigLatin:");
                string sentence = Console.ReadLine().ToLower().Trim();

                if (sentence.All(c => Char.IsLetter(c) || c == ' ') && !string.IsNullOrWhiteSpace(sentence))
                {
                    return sentence;
                }
                else
                {
                    Console.WriteLine("ERROR, ENTER A VALID SENTENCE");

                }
            }
        }

        public static string[] SplitIntoWords(string input)
        {
            //Splits sentence into words array
            string[] wordList = input.Split(' ');
            return wordList;
        }

        public static bool ContinueLoop()
        {
            while (true)
            {
                Console.WriteLine("Translate another word, ? (Y/N)"); // add user input if they want to try again
                string input = Console.ReadLine().ToUpper();
                if (input == "Y")
                {
                    Console.WriteLine();
                    return true;
                }

                else if (input == "N")
                {
                    Console.WriteLine("thanks for trying!");
                    return false;
                }
                else
                {
                    Console.WriteLine("ERROR, ENTER Y OR N");

                }
            }




        }
    }
}
