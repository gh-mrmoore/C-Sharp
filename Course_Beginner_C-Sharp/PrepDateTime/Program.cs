using System;

namespace PrepDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //formatting
            DateTime oneDate = DateTime.Now;
            Console.WriteLine(oneDate.ToString());
            Console.WriteLine(oneDate.ToShortDateString());
            Console.WriteLine(oneDate.ToShortTimeString());
            Console.WriteLine(oneDate.ToLongDateString());
            Console.WriteLine(oneDate.ToLongTimeString());
            Console.WriteLine();

            //adding, subtracting
            DateTime twoDate = DateTime.Now;
            Console.WriteLine(twoDate.AddDays(3).ToLongDateString());
            Console.WriteLine(twoDate.AddHours(4).ToLongTimeString());
            Console.WriteLine(twoDate.AddHours(-4).ToLongTimeString());

            Console.WriteLine(twoDate.Month);
            Console.WriteLine();

            //set date
            DateTime setDateOne = new DateTime(2019, 1, 1);
            Console.WriteLine(setDateOne.ToLongDateString());
            Console.WriteLine();


            //length of time
            DateTime setDateTwo = new DateTime(2019, 6, 6);
            TimeSpan yearThusFar = setDateTwo.Subtract(setDateOne);
            Console.WriteLine(yearThusFar.TotalDays);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
