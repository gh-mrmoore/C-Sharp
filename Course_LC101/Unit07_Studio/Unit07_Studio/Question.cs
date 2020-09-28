using System;
using System.Collections.Generic;
using System.Text;

namespace Unit07_Studio
{
    public abstract class Question
    {
        //fields for the Question class
        private static int thisQuestionID = 0;
        public int questionID { get; set; }
        public string questionText { get; set; }
        public string correctAnswer { get; set; }

        //Constructor for Question class
        public Question()
        {
            questionID = thisQuestionID++;
        }
    }
}