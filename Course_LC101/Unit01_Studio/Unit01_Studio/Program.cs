using System;

namespace Unit01_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circle Radius");
            String circleRadiusString = Console.ReadLine();

            double circleRadiusDouble = Convert.ToDouble(circleRadiusString);
            if (circleRadiusDouble < 0)
            {
                Console.WriteLine("Error, radius is negative");
            } else
            {
                double circleArea = 3.14159 * circleRadiusDouble * circleRadiusDouble;
                Console.WriteLine("Area of the circle is: " + circleArea);
            }
        }
    }
}
