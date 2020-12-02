using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Exercise_Laptop : Exercise_Computer
    {
        // fields and-or properties (need at least one additional)
        public double MonitorSize { get; set; }

        // constructor(s)
        public Exercise_Laptop(double monitorSize, double laptopRam, double laptopHdd) : base(laptopRam, laptopHdd)
        {
            MonitorSize = monitorSize;
        }

        // method(s)

        // special methods
        public override string ToString()
        {
            return "the monitor size is: " + MonitorSize;
        }
    }
}
