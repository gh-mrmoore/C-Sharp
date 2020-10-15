using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BalancedBrackets.HasBalancedBrackets("[]"));

            Console.WriteLine(BalancedBrackets.HasBalancedBrackets("eduritga[egi][][]][][][][][]]]][[[[]][["));

            string testString = "Launch]Code[";
            char[] stringToChar = testString.ToCharArray();
            foreach (char someChar in stringToChar)
            {
                Console.WriteLine(someChar + " " + Array.LastIndexOf(stringToChar, someChar));
            }

            string testString2 = "eduritga[egi][][]][][][][][]]]][[[[]][[";
            char[] stringToChar2 = testString2.ToCharArray();
            foreach (char someChar2 in stringToChar2)
            {
                Console.WriteLine(someChar2 + " " + Array.LastIndexOf(stringToChar2, someChar2));
            }


            //char searchString = ']';
            //int searchIndex = Array.IndexOf(stringToChar, searchString);
            //Console.WriteLine(searchIndex);
        }
    }
}
