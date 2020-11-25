using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Polymorphism
{
    public class Exercise_CompareFlavors : IComparer<Exercise_Flavor>
    {
        public Exercise_CompareFlavors() { }
        public int Compare(Exercise_Flavor first, Exercise_Flavor second)
        {
            return string.Compare(first.Name, second.Name);
        }
    }
}
