using System;
using System.Collections.Generic;
using System.Text;

namespace Unit07_Prep
{
    public class HouseCat : Cat
    {
        public string Name { get; set; }

        private string species = "Felis catus";
        public string Species
        {
            get { return species; }
            private set { species = value; }
        }

        public HouseCat(string name, double weight) : base(weight)
        {
            Name = name;
        }

        public bool IsSatisfied()
        {
            return !IsHungry && !IsTired;
        }

        public override string Noise()
        {
            return "Hello, my name is " + Name + "!";
        }

        public string Purr()
        {
            return "I'm a HouseCat";
        }
    }
}
