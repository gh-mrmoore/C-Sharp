using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Polymorphism
{
    public class Lesson_HouseCat : Lesson_Cat
    {
        // fields and/or properties
        public string Name { get; set; }
        public string HouseCatSpecies { get; } = "Felis catus";

        public Lesson_HouseCat(string name, double weight) : base(weight)
        {
            Name = name;
        }

        // constructor using no-arg constructor from Cat class


        public bool IsSatisfied()
        {
            return !CatHungry && !CatTired;
        }

        public override string Noise()
        {
            return "Hello, my name is " + Name + "!";
        }

        public string Purr()
        {
            return "I am a housecat.";
        }
    }
}
