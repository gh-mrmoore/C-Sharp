using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle Height");
            String rectangleHeightString = Console.ReadLine();
            Console.WriteLine("Rectangle Width");
            String rectangleWidthString = Console.ReadLine();

            double rectangleHeightNum = Convert.ToDouble(rectangleHeightString);
            double rectangleWidthNum = Convert.ToDouble(rectangleWidthString);
            double rectangleArea = rectangleHeightNum * rectangleWidthNum;
            Console.WriteLine(rectangleArea);
        }
    }
}
