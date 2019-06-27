using System;

namespace Mileage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Miles Driven:");
            String milesString = Console.ReadLine();
            Console.WriteLine("Gallons of Fuel Used:");
            String gallonsString = Console.ReadLine();

            double milesNum = Convert.ToDouble(milesString);
            double gallonsNum = Convert.ToDouble(gallonsString);
            double gasMileage = milesNum / gallonsNum;
            Console.WriteLine(gasMileage + " miles per gallon");
        }
    }
}
