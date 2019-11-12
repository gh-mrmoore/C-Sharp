using System;
using System.Collections.Generic;
using System.Text;

namespace Unit07_Prep
{
    public abstract class Shape
    {
        //fields for the Shape class
        private static int thisShapeID = 1;
        public int shapeID { get; set; }
        public double shapeArea { get; set; }

        //Constructor for Shape
        public Shape()
        {
            shapeID = thisShapeID++;
            //shapeArea = newShapeArea;
        }
    }
}
