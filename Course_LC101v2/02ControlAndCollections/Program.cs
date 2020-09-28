using System;
using System.Collections.Generic;

namespace ControlAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prep and examples
            Console.WriteLine("What is the number grade?");
            int StudentGrade = int.Parse(Console.ReadLine());

            if (StudentGrade < 60)
            {
                Console.Write("Letter grade is F");
            } else if (StudentGrade < 70)
            {
                Console.WriteLine("Letter grade is D");
            } else
            {
                Console.WriteLine("Letter grade is neither D nor F");
            }

            Console.WriteLine("Enter a number from 1 to 3");
            int DayNum = int.Parse(Console.ReadLine());
            string day;
            switch(DayNum)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                default:
                    day = "I'm sorry, your input did not match any of the given cases.";
                    break;
            }
            Console.WriteLine(day);

            for (int i = 100; i >= 0; i-=10)
            {
                Console.WriteLine(i);
            }

            //Studio
            string SampleString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin. " +
                "Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. " +
                "Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, " +
                "dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            //create an empty dictionary to hold each letter/count pairing
            Dictionary<char, int> LetterCount = new Dictionary<char, int>();

            //loop thru the string as an array of characters
            foreach (char c in SampleString.ToCharArray())
            {
                //see if the dictionary alrady contains the key
                if (LetterCount.ContainsKey(c))
                {
                    //if the key exists, get the current value
                    LetterCount.TryGetValue(c, out int result);

                    //add one to the current value
                    LetterCount[c] = result += 1;
                } else
                {
                    LetterCount.Add(c, 1);
                }
            }

            //iterate over the dictionary and display each key with its value
            foreach (KeyValuePair<char, int> abc in LetterCount)
            {
                Console.WriteLine("Key = {0}, Value = {1}", abc.Key, abc.Value);
            }
        }
    }
}
