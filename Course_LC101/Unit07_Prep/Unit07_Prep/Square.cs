using System;
using System.Collections.Generic;
using System.Text;

namespace Unit07_Prep
{
    public class Square : Rectangle
    {
        //Field(s) for the square class
        public double squareSide { get; set; }

        //Constructor(s) for the square class
        public Square(double newHeight, double newWidth) : base(newHeight, newWidth)
        {
            if (newHeight == newWidth)
            {
                shapeArea = newHeight * newWidth;
            }
            else
            {
                Console.WriteLine("This does not appear to be a square");
                shapeArea = 0;
            }
        }

        public Square(double newSide)
        {
            shapeArea = newSide * newSide;
        }

        //Methods for the square class
        public bool sameSides(double newHeight, double newWidth)
        {
            if (newHeight == newWidth)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
