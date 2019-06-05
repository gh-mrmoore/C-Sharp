using System;

namespace Prep01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.ReadLine();

            //working with variables

            /*   Simple addition and assignment operators
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            //variables and user interaction

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            //string firstName;                        //use meaningful variable names
            //firstName = Console.ReadLine();
            string firstName = Console.ReadLine();   //consolidates the previous two lines of code

            string lastName;
            Console.Write("Type your last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Hello, " + firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
