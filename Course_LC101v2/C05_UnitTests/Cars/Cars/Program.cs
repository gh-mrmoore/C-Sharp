using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Tests!");
            Car car = new Car("Toyota", "Prius", 10, 50);
            Console.WriteLine(car.Make + " - " + car.Model);
        }
    }
}
