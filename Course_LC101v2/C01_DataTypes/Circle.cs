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

        public static double CircleCircumference(double CircleRadius)
        {
            double Circumference = Math.PI * 2 * CircleRadius;
            return Circumference;
        }

        public static double CircleDiameter(double CircleRadius)
        {
            double Diameter = CircleRadius * 2;
            return Diameter;
        }

        public static double GetTrip(double circumference, double mpg)
        {
            double gallonsUsed = circumference / mpg;
            return gallonsUsed;
        }

        public static void GetTrip2(double circumference, double mpg)
        {
            double gallonsUsed = circumference / mpg;

            Console.WriteLine(gallonsUsed);
        }
    }
}
