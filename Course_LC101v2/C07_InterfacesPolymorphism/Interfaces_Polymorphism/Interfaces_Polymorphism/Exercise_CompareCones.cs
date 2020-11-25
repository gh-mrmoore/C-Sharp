using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Polymorphism
{
    class Exercise_CompareCones : IComparer<Exercise_Cone>
    {
        public Exercise_CompareCones() { }

        public int Compare(Exercise_Cone firstCone, Exercise_Cone secondCone)
        {
            if((firstCone.Cost - secondCone.Cost) > 0)
            {
                return 1;
            } else if ((firstCone.Cost - secondCone.Cost) < 0)
            {
                return -1;
            } else
            {
                return 0;
            }
        }
    }
}
