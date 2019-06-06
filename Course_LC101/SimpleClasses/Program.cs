using System;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car oneCar = new Car("Chevrolet", "Traverse", 2015, "White");

            Car.MyMethod();
            /*oneCar.Make = "Chevrolet";
            oneCar.Model = "Traverse";
            oneCar.Year = 2015;
            oneCar.Color = "White";*/

            Car twoCar = new Car();   //constructor auto-generated
            //twoCar = oneCar;       //referencing the same memory address
            twoCar.Make = "Dodge";
            twoCar.Model = "Journey";
            twoCar.Year = 2014;
            twoCar.Color = "Black";


            Console.WriteLine("Make: " + oneCar.Make + ", Model: " + oneCar.Model);
            Console.WriteLine("Value: {0:C}", oneCar.DetermineMarketValue());

            //decimal value = CalculateMarketValue(oneCar);
            //Console.WriteLine("{0:C}", value);


            oneCar = null;
        }
        //helper method on main
        private static decimal CalculateMarketValue(Car car)
        {
            decimal carValue = 100.0M;
            return carValue;
        }
    }

    //define class for a car
    class Car    //class is the blueprint, instantiation creates the object which is built from the class
    {
        //abbreviated version of getter-setter use propfull + [tab] + [tab] for more complete creation
        public String Make { get; set; }
        public String Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //constructor
        public Car()
        {
            this.Make = "Nissan";     //this keyword can be optional here - part of the class definition
            //load from a configuration file or a database....
        }

        public Car(string make, string model, int year, string color)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }

        //set helper method
        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 2000)
                carValue = 10000;
            else
                carValue = 5000;

            return carValue;
        }

        //static, not instance, member of the class
        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
            //Console.WriteLine(Make);
        }
    }
}
