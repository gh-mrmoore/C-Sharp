using System;

namespace SimpleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Simple Arrays!");
            int maxInts = 6;
            int[] myArray = new int[maxInts];
            //values: 1, 1, 2, 3, 5, 8
            myArray[0] = 1;
            myArray[1] = 1;
            myArray[2] = 2;
            myArray[3] = 3;
            myArray[4] = 5;
            myArray[5] = 8;

            //can also create and initialize in a single line
            int[] myArray2 = { 2, 2, 4, 5, 8, 9 };


            foreach (int x in myArray)
            {
                Console.WriteLine(x);
            }

            foreach (int y in myArray2)
            {
                Console.WriteLine(y);
            }
        }
    }
}
