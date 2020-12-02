using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Exercise_ChromeBook : Exercise_Laptop
    {
        // fields and/or properties (add one more)
        public bool UltraPortable { get; set; } = true;

        public Exercise_ChromeBook(bool superPortable, double screenSize, double puterRam, double chromeHdd) : base(screenSize, puterRam, chromeHdd)
        {
            UltraPortable = superPortable;
        }
    }
}
