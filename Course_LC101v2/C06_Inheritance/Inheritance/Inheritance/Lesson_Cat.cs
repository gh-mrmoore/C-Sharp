using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Lesson_Cat
    {
        // fields and/or properties
        public bool CatTired { get; set; } = false;
        public bool CatHungry { get; set; } = false;
        public string BioFamily { get; } = "Felidae";
        public double Weight { get; set; }

        // constructor(s)
        public Lesson_Cat(double weight)
        {
            Weight = weight;
        }

        // add no-argument constructor
        public Lesson_Cat()
        { }

        public void Sleep()
        {
            CatTired = false;
            CatHungry = true;
        }

        public void Eat()
        {
            if (!CatHungry)
            {
                CatTired = true;
            }
            CatHungry = false;
        }

        public virtual string Noise()
        {
            return "Meow!";
        }
    }
}