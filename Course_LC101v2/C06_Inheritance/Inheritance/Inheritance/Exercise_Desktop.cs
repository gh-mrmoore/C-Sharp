using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Exercise_Desktop : Exercise_Computer
    {
        // fields and-or properties (need at least 1 new)
        public string CoolingMethod { get; set; }
        public bool AllInOne { get; set; }

        // constructor(s)
        public Exercise_Desktop(string desktopCooling, bool allInOne, double desktopRam, double desktopHdd) : base(desktopRam, desktopHdd)
        {
            CoolingMethod = desktopCooling;
            AllInOne = allInOne;
        }

        // method(s)
        public string DesktopCooling(string desktopCooledBy)
        {
            if(desktopCooledBy == "Water")
            {
                return "Cool!";
            } else if (desktopCooledBy == "Fan")
            {
                return "Cool, but not AS cool!";
            } else
            {
                return "Not so cool...";
            }
        }

        public override string ToString()
        {
            return "Computer brand: " + Brand + " All in one system: " + AllInOne;
        }
    }
}
