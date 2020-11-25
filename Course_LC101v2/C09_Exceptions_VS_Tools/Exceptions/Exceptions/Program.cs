using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if(y == 0)
            {
                throw new ArgumentOutOfRangeException("Don't divide by zero!");
            } else
            {
                return x / y;
            }
        }

        static int CheckFileExtension(string fileName)
        {
            // is there a blank file name or a null value passed for file name?
            // if there is a file name and it doesn't end in .cs, 0 points
            // if there is a file name and it does end in .cs, 1 point
            if(fileName == "" || fileName == null)
            {
                   throw new ArgumentNullException("No file name recorded or submitted.");
            }
            else if(fileName.IndexOf(".cs") > 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }

        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Console.WriteLine(Divide(1, 0));
            }
            catch (ArgumentOutOfRangeException zeroError)
            {
                Console.WriteLine(zeroError.Message);
            }

            try
            {
                Console.WriteLine(Divide(2, 4));
            }
            catch (ArgumentOutOfRangeException wrongDivide)
            {
                Console.WriteLine(wrongDivide.Message);
            }


            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.xls");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach(KeyValuePair<string, string> studentFile in students)
            {
                try
                {
                    Console.WriteLine("Grade for " + studentFile.Key + " is " + CheckFileExtension(studentFile.Value));
                }
                catch (ArgumentNullException nullError)
                {
                    Console.WriteLine(nullError.Message);
                }
            }
        }
    }
}
