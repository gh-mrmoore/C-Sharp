using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bonus03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the character you wish to find: ");
            char searchChar = char.Parse(Console.ReadLine());

            string sampleString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut " +
                "ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat " +
                "volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac " +
                "suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Dictionary<string, int> countLowerChars = new Dictionary<string, int>();

            foreach (char x in sampleString)
            {
                if (x.Equals(searchChar))
                {
                    string xString = x.ToString();
                    string lowerString = xString.ToLower();

                    if (countLowerChars.ContainsKey(lowerString))
                    {
                        int currentCount = countLowerChars[lowerString];
                        currentCount += 1;
                        countLowerChars[lowerString] = currentCount;
                    }
                    else
                    {
                        countLowerChars.Add(lowerString, 1);
                    }
                }
            }

            foreach (KeyValuePair<string, int> character in countLowerChars)
            {
                Console.WriteLine("Key = {0} || Value = {1}", character.Key, character.Value);
            }
        }
    }
}