using System;

namespace PrepB
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 12; i++)
            {
                Console.WriteLine(i);
                /*if (i == 7)
                {
                    Console.WriteLine("Found Number Seven");
                    break;
                }*/
            }

            //arrays

            int[] numbers = new int[5];    //don't have to give this a specific size, compiler can determine
            numbers[0] = 3;
            numbers[1] = 5;
            numbers[2] = 2;
            numbers[3] = 4;
            numbers[4] = 6;
            //numbers[5] = 18;     //cannot add beyond the five 'spots' created above or get index out of range error

            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);

            string[] names = new string[] { "Joseph", "Mary", "Michael", "Matthew" };    //compiler will determine size

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            string longString = "This is just a really long line of text to demonstrate concatenation over" +
                "multiple lines in C-Sharp";

            char[] charArray = longString.ToCharArray();
            Array.Reverse(charArray);

            foreach (char longChar in charArray)
            {
                Console.Write(longChar);
            }

            //keep this at the bottom of the code block
            Console.ReadLine();
        }
    }
}
