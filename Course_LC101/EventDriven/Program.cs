using System;
using System.Timers;

namespace EventDriven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Events allow the developer to respond to the application's execution lifecycle
            Timer myTimer = new Timer(2000);

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;

            myTimer.Start();
            Console.ReadLine();
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Time expired at: " + e.SignalTime);
        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Time found at: " + e.SignalTime);
        }

    }
}
