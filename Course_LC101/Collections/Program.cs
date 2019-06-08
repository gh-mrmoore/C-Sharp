using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carOne = new Car();
            carOne.Make = "Chevrolet";
            carOne.Model = "Traverse";
            carOne.VIN = "C1";

            Car carTwo = new Car();
            carTwo.Make = "Dodge";
            carTwo.Model = "Journey";
            carTwo.VIN = "C2";

            //can speed up the above without custom constructors by using the default constructor
            //object initializer syntax
            Car carThree = new Car() { Make = "Subaru", Model = "Forester", VIN = "C3" };

            Book bookOne = new Book();
            bookOne.Title = "A Game of Thrones";
            bookOne.Author = "George R.R. Martin";
            bookOne.Genre = "Fantasy";

            //ArrayList collection - dynamically sized
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(carOne);
            myArrayList.Add(carTwo);
            //no way to limit the type of data coming in to the ArrayList
            //older-style collections are not strongly typed

            foreach(Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }

            //newer-style collections
            //Generic Lists - use List<T>
            //specify the type of data coming in to the List
            List<Car> carList = new List<Car>();
            carList.Add(carOne);
            carList.Add(carTwo);
            carList.Add(carThree);

            foreach (Car car in carList)
            {
                Console.WriteLine(car.Model);
            }

            //dictionary
            //key-definition(value) pairings
            //Dictionary<TKey, TValue> - key must be unique to each item in the dictionary
            Dictionary<string, Car> carDict = new Dictionary<string, Car>();
            carDict.Add(carOne.VIN, carOne);
            carDict.Add(carTwo.VIN, carTwo);

            Console.WriteLine("Make of Car: " + carDict["C1"].Make);

            //collection initializer
            List<Car> carInventory = new List<Car>() {
                new Car { Make = "Ford", Model = "Expedition", VIN = "C5" }
            };

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
    }
}
