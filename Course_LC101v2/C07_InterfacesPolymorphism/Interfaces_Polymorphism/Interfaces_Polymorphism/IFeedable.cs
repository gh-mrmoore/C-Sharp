using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Polymorphism
{
    public interface IFeedable
    {
        string Eat()
        {
            return "the feedable is eating";
        }

        void Nap()
        {
            Console.WriteLine("Snooooze");
        }
    }
}
