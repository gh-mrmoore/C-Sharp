using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public abstract class Studio_Question   // don't want any generic questions to be created...
    {
        // fields and/or properties
        public string QuestionText { get; set; }   // every question needs the text of the question
        public string CorrectAnswer { get; set; }  // might need to be changed/overriden depending on the kind of question

        // constructor(s)
        public Studio_Question() { }

        public Studio_Question(string questionText, string correctAnswer)
        {
            QuestionText = questionText;
            CorrectAnswer = correctAnswer;
        }

        // methods
        public abstract string ShowPossibleAnswers();
        public abstract int GradeQuestion(string userAnswer);
        public override string ToString()
        {
            return QuestionText;
        }
    }
}
