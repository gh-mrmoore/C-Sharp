using System;

namespace Unit01_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            //Copied over from C# for Absolute Beginners
            
            //escaping using the back-slash
            string oneString = "Return text over \n two lines";

            // @ symbol tells C# to use a back-slash as a literal character
            string twoString = @"It is on your C:\ Drive";

            //replacements and formatting - C for currency, P for percentage, N for number
            string threeString = String.Format("{0} = {1}, {2:C}, {3:N}, {4:P}", "First", "Second", 123.45, 1234567890, .123);

            //custom formatting for numeric values
            string fourString = String.Format("{0:(###) ###-####}", 1234567890);

            Console.WriteLine(oneString);
            Console.WriteLine(twoString);
            Console.WriteLine(threeString);
            Console.WriteLine(fourString);

            string fiveString = " Always remember where you come from   ";

            //string functions - substring, remove, to-upper, trim, replace, remove, etc
            fiveString = fiveString.Substring(6);
            string sixString = fiveString.ToUpper();

            Console.WriteLine(fiveString);
            Console.WriteLine(sixString);

            //inefficient concatentation
            string myString = "";
            for (int i = 0; i < 8; i++)
            {
                myString += "--" + i.ToString();
            }
            Console.WriteLine(myString);

            //more efficient string concatenation/manipulation
            System.Text.StringBuilder newString = new System.Text.StringBuilder();

            for (int i = 0; i < 8; i++)
            {
                newString.Append(i);
                newString.Append("--");
            }
            Console.WriteLine(newString);
        }
    }
}
