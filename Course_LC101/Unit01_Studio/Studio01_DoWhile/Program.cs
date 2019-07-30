using System;

namespace Studio01_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double circleRadiusDouble = 0;
            do
            {
                Console.Write("Circle Radius: ");
                String circleRadiusString = Console.ReadLine();
                circleRadiusDouble = Convert.ToDouble(circleRadiusString);
            }
            while (circleRadiusDouble <= 0);
            double circleArea = 3.14159 * circleRadiusDouble * circleRadiusDouble;
            Console.Write("Area of circle is: " + circleArea);
        }
    }
}
