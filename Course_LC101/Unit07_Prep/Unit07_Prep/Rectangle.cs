using System;
using System.Collections.Generic;
using System.Text;

namespace Unit07_Prep
{
    public class Rectangle : Shape
    {
        //Field(s) for the Rectangle class
        public double rectangleHeight { get; set; }
        public double rectangleWidth { get; set; }

        //Constructor(s) for the rectangle class
        public Rectangle(double newHeight, double newWidth)
        {
            rectangleHeight = newHeight;
            rectangleWidth = newWidth;
            shapeArea = rectangleHeight * rectangleWidth;
        }

        public Rectangle()
        {
            rectangleHeight = 0;
            rectangleWidth = 0;
            shapeArea = 0;
        }
    }
}
