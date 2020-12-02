using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public abstract class Exercise_Computer : Exercise_Abstract
    {
        // fields and-or properties (need at least 3)
        public double RamMemory { get; set; }
        public double HardDriveSpace { get; set; }
        public const string Brand = "Apple";

        // constructor(s)
        public Exercise_Computer() { }
        public Exercise_Computer(double computerRam, double computerHdd)
        {
            RamMemory = computerRam;
            HardDriveSpace = computerHdd;
        }

        // methods
        public bool EnoughRam(double computerRam)
        {
            if(computerRam > 8)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public string EnoughHddSpace(double hardDriveSize)
        {
            if(hardDriveSize > 120)
            {
                return "You are probably okay with that hard drive size.";
            } else
            {
                return "You may want to consider upgrading to a larger hard drive size.";
            }
        }


    }
}
