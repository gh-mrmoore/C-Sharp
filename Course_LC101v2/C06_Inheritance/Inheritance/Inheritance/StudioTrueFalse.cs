using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class StudioTrueFalse : Studio_Question
    {
        // fields and/or properties

        // constructor(s)
        public StudioTrueFalse(string trueFalseText, string trueFalseAnswer) : base(trueFalseText, trueFalseAnswer)
        { }

        // methods
        public override string ShowPossibleAnswers()
        {
            // show the possible answers for this question
            return "True or False";
        }

        public override int GradeQuestion(string userAnswer)
        {
            if (userAnswer == CorrectAnswer)
            {
                return 1;
            } else
            {
                return 0;
            }
        }
    }
}
