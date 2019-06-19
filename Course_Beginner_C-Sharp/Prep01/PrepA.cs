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

            string newFirstName = "Matt";
            string newLastName = "Moore";

            string newFullName = newFirstName + newLastName;
            Console.WriteLine(newFullName);

            Console.WriteLine("Giveaway Game");
            Console.Write("Choose Door: 1, 2 or 3: ");
            string userChoice = Console.ReadLine();
            string message = "";

            //if-then-else statements

            if (userChoice == "1")
                {
                message = "You chose door 1";
                //Console.WriteLine(message);
            }
            else if (userChoice == "2")
            {
                message= "You chose door 2";
                //Console.WriteLine(message);
            }
            else if (userChoice == "3")      //braces can be removed if there's only one line of code in if/else statements
            {
                message = "You chose door 3";
            }
            else
            {
                //Console.Write("Your choice was not valid");
                message = "Your choice was not valid";
            }
            Console.WriteLine(message);


            Console.WriteLine("New Game");
            Console.Write("Choose Door: 1, 2 or 3: ");
            string newUserChoice = Console.ReadLine();
            string newMessage = "";

            newMessage = (newUserChoice == "1") ? "boat" : "strand of lint";

            //Console.Write("You won a ");
            //Console.Write(newMessage);
            //Console.Write(".");

            //use replacement character(s)
            Console.Write("You won a {0} Because you entered {1}.", newMessage, newUserChoice);

            /*
             * An expression is a single line statement
             * An expression is made up of operands and operators
             * An operand is something like a variable - something to be acted upon
             * An operator does something to one or more operands (ie addition, subtraction, etc)
            */

            //keep at the bottom to keep window open to see program results
            Console.ReadLine();
        }
    }
}
