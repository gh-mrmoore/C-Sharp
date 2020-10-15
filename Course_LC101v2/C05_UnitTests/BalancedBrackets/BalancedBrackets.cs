using System;
using System.Collections.Generic;
using System.Text;

namespace BalancedBrackets
{
    public class BalancedBrackets
    {
        /**
         * The function BalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */
        public static bool HasBalancedBrackets(String str)
        {
            int brackets = 0;
            int lastOpenIndex = 0;
            int lastCloseIndex = 0;

            char[] stringToChar = str.ToCharArray();
            foreach (char ch in stringToChar)
            {
                if (ch == '[')
                {
                    brackets++;
                    //re-write the index value at each iteration
                    lastOpenIndex = Array.LastIndexOf(stringToChar, '[');
                }
                else if (ch == ']')
                {
                    brackets--;
                    lastCloseIndex = Array.LastIndexOf(stringToChar, ']');
                }
            }
            if (brackets == 0 && lastCloseIndex > lastOpenIndex)
            {
                return true;
            } else
            {
                return false;
            }
            //return brackets == 0;
        }
    }
}
