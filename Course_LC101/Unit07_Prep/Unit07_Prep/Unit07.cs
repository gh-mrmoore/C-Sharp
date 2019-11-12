using System;

namespace Unit07_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseCat garfield = new HouseCat("Garfield", 12);
            garfield.Eat();
            Console.WriteLine(garfield.Noise());
            Console.WriteLine(garfield.IsHungry);
            Console.WriteLine(garfield.Family);

            //Shape, Square, Rectangle, Circle
            /*
             * Any Square, Rectangle or Circle is a Shape
             * Any Square is a Rectangle, although with 4 sides of equal length
             * Every shape has an area, although the calculation of the area depends upon the shape
             * The area of a square is calculated the same as the area of a rectangle, length times height
             * The area of a circle is pi (3.14159) multiplied by the radius squared
             *            Shape
             *       _______|_______
             *      |               |
             *  Rectangle        Circle
             *      |
             *    Square
            */

            Circle circle1 = new Circle(1);
            Console.WriteLine("Shape ID: " + circle1.shapeID + " Radius: " + circle1.circleRadius + " Area: " + circle1.shapeArea);

            Rectangle rectangle1 = new Rectangle(2, 3);
            Console.WriteLine("Shape ID: " + rectangle1.shapeID + " Height: " + rectangle1.rectangleHeight + " Width: " + rectangle1.rectangleWidth + " Area: " + rectangle1.shapeArea);

            Square square1 = new Square(3, 3);
            Console.WriteLine("Shape ID: " + square1.shapeID + " Area: " + square1.shapeArea);

            Square square2 = new Square(4);
            Console.WriteLine("Shape ID: " + square2.shapeID + " Area: " + square2.shapeArea);
        }
    }
}
