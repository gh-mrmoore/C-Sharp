using System;
using System.Collections.Generic;
using System.Text;

namespace DataTypes
{
    public class Circle
    {
        public static double CircleRadiusCalc(double CircleRadius)
        {
            double CircleArea = Math.Pow(CircleRadius, 2) * Math.PI;

            return CircleArea;
        }
    }
}
