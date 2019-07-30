using System;
using System.Collections.Generic;

namespace Unit02_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Studio 2!");

            string sampleString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut " +
                "ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat " +
                "volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac " +
                "suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Dictionary<char, int> countingChars = new Dictionary<char, int>();
            foreach (char x in sampleString)
            {
                if (countingChars.ContainsKey(x)) {
                    int currentValue = countingChars[x];
                    currentValue += 1;
                    countingChars[x] = currentValue;
                } else
                {
                    countingChars.Add(x, 1);
                }
            }

            foreach (KeyValuePair<char, int> character in countingChars)
            {
                Console.WriteLine("Key = {0} || Value = {1}", character.Key, character.Value);
            }
        }
    }
}
