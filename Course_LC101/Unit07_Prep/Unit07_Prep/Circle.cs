using System;
using System.Collections.Generic;
using System.Text;

namespace Unit07_Prep
{
    public class Circle : Shape
    {
        //Field(s) for the circle class
        public double circleRadius { get; set; }

        //Constructor(s) for the circle class
        public Circle(double newCircleRadius)
        {
            circleRadius = newCircleRadius;
            shapeArea = circleRadius * circleRadius * 3.14159;
        }
    }
}
