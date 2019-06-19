using System;

namespace PrepVariableScope
{
    class Program
    {
        //field(s) for the class
        private static string k = "";
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I is: " + i);
                k = i.ToString();
            }

            int x = 0;
            while (x < 10)
            {
                Console.WriteLine("X equals: " + x);
                x++;
            }

            Console.WriteLine("Final Value of x is: " + x);
            Console.WriteLine("Final value of k is: " + k);

            HelperMethod();

            //public and private methods for a separate class
            //encapsulating data, important for OOP
            //once items fall out of scope, they'll be garbage-collected
            Car newCar = new Car();
            newCar.carDoSomething();
        }

        //helper methods for main
        static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod: " + k);
        }
    }

    class Car
    {
        public void carDoSomething()
        {
            Console.WriteLine(carHello());
        }

        private string carHello()
        {
            return "Car says hello!";
        }
    }
}
