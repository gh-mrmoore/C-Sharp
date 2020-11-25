using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Polymorphism
{
    public class Exercise_Flavor : Exercise_Ingredient
    {
        public Exercise_Flavor(string name, double cost, List<string> allergens) : base(name, cost, allergens) { }
    }
}
