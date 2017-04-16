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
            //string pigLatin = ToPigLatin(sentence);
            Console.WriteLine(ToPigLatin(sentence));




        }

        public static string ToPigLatin(string sentence)

        {

           

                if (sentence[0] == 'a' || sentence[0] == 'e' || sentence[0] == 'i' || sentence[0] == 'o' || sentence[0] == 'u')
                {
                    sentence = sentence += "way";
                
                }
            else { 

            string temp;
                
                for (int i = 1; i < sentence.Length; i++)
                {
                    if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
                    {
                        temp = sentence.Substring(0, i);
                        sentence = sentence.Remove(0, i);
                        sentence = sentence += temp + "ay";
                        

                    }

                }
            }return sentence;




        }


       
    }

}
