using System;

namespace PrepIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;

            while (displayMenu)               // don't need to add '== true' to evaluate
            {
                displayMenu = MainMenu();
            }
            //MainMenu();
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an Option: ");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Add Numbers");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                AddNumbers();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers");
            Console.Write("Type a number: ");
            int userInput = int.Parse(Console.ReadLine());
            int numberIncrement = 1;
            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine(i + numberIncrement);
            }
            Console.ReadLine();
        }

        private static void AddNumbers()
        {
            Console.Clear();
            int x = 0;
            Console.WriteLine("Add Numbers");
            Console.Write("Type a number: ");
            int userInput = int.Parse(Console.ReadLine());
            for (int i = 0; i <= userInput; i++)
            {
                x = x + i;
            }
            Console.WriteLine("Summation is: " + x);
            Console.ReadLine();
        }

        private static void MultiplyNumbers()
        {
            Console.WriteLine("Multiply Numbers");
            Console.ReadLine();
        }
    }
}
