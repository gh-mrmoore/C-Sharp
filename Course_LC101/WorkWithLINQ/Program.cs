using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>()
            {
                new Car() { Make = "BMW", Model = "550i", VIN = "C1" },
                new Car() { Make = "Subaru", Model = "Forester", VIN = "C2" },
                new Car() { Make = "BMW", Model = "i5", VIN = "C3" },
            };

            //LINQ query
            var beamers = from car in carList where car.Make == "BMW" select car;
            foreach (var car in beamers)
            {
                Console.WriteLine(car.VIN);
            }


            var orderedCars = from car in carList orderby car.Make descending select car;
            foreach (var car in orderedCars)
            {
                Console.WriteLine("Ordered: " + car.Make);
            }


            //LINQ method
            var bmwCars = carList.Where(p => p.Make == "BMW" && p.Model == "550i");   //using lambda expression, a mini-method
            //var above is not the same as var in JavaScript or VisualBasic
            //var allows compiler to determine what kind of variable type this will need to be when code is compiled

            foreach (var car in bmwCars)
            {
                Console.WriteLine(car.VIN);
            }

            //sorting with method
            var methodOrderedCars = carList.OrderByDescending(p => p.Make);
            foreach (var car in methodOrderedCars)
            {
                Console.WriteLine("Method Order: " + car.VIN);
            }

            //method chaining
            var methodCars = carList.OrderByDescending(p => p.Make).First(p => p.Model == "Forester");
            Console.WriteLine(methodCars.VIN);

            //aggregate functions and simplified operators
            Console.WriteLine(carList.TrueForAll(p => p.Make == "BMW"));

            carList.ForEach(x => Console.WriteLine("VIN each: " + x.VIN));

            Console.WriteLine("Is there a Chevy? " + carList.Exists(y => y.Make == "Chevrolet"));


        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
    }
}
