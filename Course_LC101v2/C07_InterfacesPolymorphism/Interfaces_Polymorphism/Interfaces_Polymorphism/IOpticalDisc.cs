using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Polymorphism
{
    public interface IOpticalDisc
    {
        // discs will spin
        string SpinDisc();

        // CDs and DVDs and LaserDiscs will store data that can be read
        void AddData(double addSomething);
    }
}
