using System;
using System.Collections.Generic;
using System.Text;

namespace Unit07_Prep
{
    public abstract class Cat
    //Abstract classes are classes that may not be instantiated. In order to use the behavior of an abstract class, we must extend it.
    {
        public bool IsTired { get; set; } = false;
        public bool IsHungry { get; set; } = false;
        public double Weight { get; set; }

        // The biological Family for all cat species
        private string family = "Felidae";
        public string Family
        {
            get { return family; }
            private set { family = value; }
        }

        public Cat(double weight)
        {
            Weight = weight;
        }

        // A cat is rested and hungry after it sleeps
        public void Sleep()
        {
            IsTired = false;
            IsHungry = true;
        }

        // Eating makes a cat not hungry
        public void Eat()
        {

            // eating when not hungry makes a cat sleepy
            if (!IsHungry)
            {
                IsTired = true;
            }

            IsHungry = false;
        }

        public virtual string Noise()
        {
            return "Meeeeeeooooowww!";
        }
    }
}
