using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Polymorphism
{
    public abstract class Exercise_Ingredient
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public List<string> Allergens { get; set; }

        public Exercise_Ingredient(string name, double cost, List<string> allergens)
        {
            Name = name;
            Cost = cost;
            Allergens = allergens;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\n" + "Cost: $" + Cost + "\n" + "Allergens: " + Allergens + "\n";
        }
    }
}
