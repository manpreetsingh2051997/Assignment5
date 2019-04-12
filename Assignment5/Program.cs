using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Program mango= new Program();
            Console.WriteLine("the longest word is : ");
            Console.WriteLine(mango.MyFunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));
        }

        public int  MyFunctionA (string input)
        {
            //Write a C# program to find the longes word in a string.
            string[] words = input.Split(' ');
            int wordArrayLength = words.Length;

            foreach (var word in words)
            {
                //TODO
            }
            // loop post condition: we now jave array wordsLength which contains the lengths of each word

            string currentWord = words[0];
            string nextWord;

            for (int y = 0; y < words.Length - 1; y++)
            {
                currentWord = words[y];
                nextWord = words[y + 1];
                // TODO :Use an IF Statementr to make sure thet variable longestWord is always set to the Longest Word in the input string
            }

        }
    }
}
