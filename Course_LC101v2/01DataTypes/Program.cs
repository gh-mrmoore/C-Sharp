using System;

namespace DataTypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Prep work
            //Console.WriteLine("Hello TempConverter!");
            //double fahrenheit;
            //double celsius;
            //string input;

            //Console.WriteLine("Temperature in F: ");
            //input = Console.ReadLine();
            //fahrenheit = double.Parse(input);

            //celsius = (fahrenheit - 32) * 5 / 9;
            //Console.WriteLine("The temperature in C is: " + celsius);
            ////Console.ReadLine();

            //int[] numberArray = { 10, 15, 20 };
            //String[] anotherStringArray = { "Matthew", "Robert", "Moore" };

            //Console.WriteLine(numberArray[1]);
            //Console.WriteLine(anotherStringArray[2]);

            //string NewMessage = Hello.DisplayMessage("sp");
            //string NewerMessage = Hello.DisplayMessage("fr");
            //Console.WriteLine(NewMessage);
            //Console.WriteLine(NewerMessage);

            ////Exercises
            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Hello " + userName);

            //Console.WriteLine("What is the rectangle length");
            //string RectangleLength = Console.ReadLine();
            //double RectangleLengthInt = double.Parse(RectangleLength);
            //Console.WriteLine("What is the rectangle width");
            //string RectangleWidth = Console.ReadLine();
            //double RectangleWidthInt = double.Parse(RectangleWidth);
            //double RectangleArea = RectangleLengthInt * RectangleWidthInt;
            //Console.WriteLine("The area of the rectangle is: " + RectangleArea);

            //Console.WriteLine("How many miles have you driven?");
            //double MilesDriven = double.Parse(Console.ReadLine());
            //Console.WriteLine("How many gallons of gas did you use?");
            //double GallonsUsed = double.Parse(Console.ReadLine());
            //double MilesPerGallon = MilesDriven / GallonsUsed;
            //Console.WriteLine("Your fuel efficiency was: " + MilesPerGallon);

            //string Alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            //string LowerCaseAlice = Alice.ToLower();
            //Console.WriteLine("For what string do you wish to search?");
            //string SearchTerm = Console.ReadLine().ToLower();
            //Console.WriteLine(LowerCaseAlice.Contains(SearchTerm));
            //Console.WriteLine("Your search term appears at index: " + LowerCaseAlice.IndexOf(SearchTerm));
            //Console.WriteLine("Your search string is " + SearchTerm.Length + " characters long.");

            //string NewAlice = Alice.Remove(LowerCaseAlice.IndexOf(SearchTerm), SearchTerm.Length);
            //Console.WriteLine(NewAlice);

            //Studio
            //Console.WriteLine("What is the radius of the circle?");
            //double CircleRadius = double.Parse(Console.ReadLine());
            //double CircleArea = Math.Pow(CircleRadius, 2) * Math.PI;
            //Console.WriteLine("The area of the circle is: " + CircleArea);

            double CircleRadius = -1;
            do
            { Console.WriteLine("What is the radius of the circle?");
                CircleRadius = double.Parse(Console.ReadLine());
            }
            while (CircleRadius < 0);
            double CircleArea = Math.Pow(CircleRadius, 2) * Math.PI;
            Console.WriteLine("The area of the circle is: " + CircleArea);
        }
    }
}
