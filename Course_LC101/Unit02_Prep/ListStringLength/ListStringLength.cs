using System;
using System.Collections.Generic;

namespace ListStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello List String Length!");

            List<string> someWords = new List<string>();

            someWords.Add("Test");
            someWords.Add("Length");
            someWords.Add("Short");
            someWords.Add("Long");
            someWords.Add("Pills");

            CheckLength(someWords);

        }

        private static void CheckLength(List<string> wordList)
        {
            string returnWord = "";
            foreach (string word in wordList)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
