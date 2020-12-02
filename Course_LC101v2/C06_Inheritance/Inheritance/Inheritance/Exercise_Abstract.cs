using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public abstract class Exercise_Abstract
    {
        // field(s) and/or property(ies)
        public int ExerciseId { get; set; }
        private static int countId = 1;

        public Exercise_Abstract()
        {
            ExerciseId = countId;
            countId++;
        }
    }
}
