using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Polymorphism
{
    public class Exercise_Case
    {
        public List<Exercise_Flavor> Flavors { get; set; }
        public List<Exercise_Cone> Cones { get; set; }

        public Exercise_Case()
        {
            Cones = new List<Exercise_Cone>();
            Exercise_Cone cone1 = new Exercise_Cone("Waffle", 1.25, new List<string> { "gluten" });
            Exercise_Cone cone2 = new Exercise_Cone("Sugar", 0.75, new List<string> { "gluten" });
            Exercise_Cone cone3 = new Exercise_Cone("Wafer", 0.50, new List<string> { "gluten" });
            Exercise_Cone cone4 = new Exercise_Cone("Bowl", 0.05, new List<string> { "none" });
            Cones.Add(cone1);
            Cones.Add(cone2);
            Cones.Add(cone3);
            Cones.Add(cone4);

            Flavors = new List<Exercise_Flavor>();
            Exercise_Flavor flavor1 = new Exercise_Flavor("Vanilla", 0.75, new List<string> { "dairy" });
            Exercise_Flavor flavor2 = new Exercise_Flavor("Chocolate", 0.75, new List<string> { "dairy" });
            Exercise_Flavor flavor3 = new Exercise_Flavor("Red Velvet", 0.85, new List<string> { "dairy", "red #5" });
            Exercise_Flavor flavor4 = new Exercise_Flavor("Rocky Road", 0.85, new List<string> { "dairy", "nuts", "gelatin" });
            Exercise_Flavor flavor5 = new Exercise_Flavor("Strawberry Sorbet", 0.50, new List<string> { "strawberry" });
            Flavors.Add(flavor1);
            Flavors.Add(flavor2);
            Flavors.Add(flavor3);
            Flavors.Add(flavor4);
            Flavors.Add(flavor5);
        }
    }
}
