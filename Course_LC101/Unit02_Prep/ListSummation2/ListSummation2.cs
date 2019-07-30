using System;
using System.Collections.Generic;

namespace ListSummation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello List Summation 2!");
            List<double> findSum = new List<double>();
            findSum.Add(1);
            findSum.Add(2);
            findSum.Add(3);
            findSum.Add(4);
            findSum.Add(5);
            findSum.Add(6);
            findSum.Add(7);
            findSum.Add(8);
            findSum.Add(9);
            findSum.Add(10);

            Console.Write(CalcSum(findSum));
        }

        public static double CalcSum(List<double> findSum)
        {
            double sum = 0;
            foreach (double i in findSum)
            {
                sum = sum + i;
            }

            return sum;
        }
    }
}
