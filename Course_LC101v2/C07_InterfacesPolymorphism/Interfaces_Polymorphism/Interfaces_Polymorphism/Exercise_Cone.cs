using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Polymorphism
{
    public class Exercise_Cone : Exercise_Ingredient
    {
        public Exercise_Cone(string name, double cost, List<string> allergens) : base(name, cost, allergens) { }
    }
}
