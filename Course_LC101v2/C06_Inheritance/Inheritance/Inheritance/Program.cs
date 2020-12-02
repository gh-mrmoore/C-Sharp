using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /* code for exercises */
            //Exercise_Desktop MyDesktop = new Exercise_Desktop("Water", true, 16.0, 256.0);
            //Console.WriteLine(MyDesktop.ToString());

            /* code for studio */

            // create some questions for the quiz
            StudioTrueFalse firstTrueFalse = new StudioTrueFalse("LaunchCode is Cool", "True");
            StudioTrueFalse secondTrueFalse = new StudioTrueFalse("Dogs are the best", "True");

            // create a quiz and add questions to the quiz
            List<Studio_Question> thisQuizQuestions = new List<Studio_Question>();
            Studio_Quiz thisQuiz = new Studio_Quiz(thisQuizQuestions);
            thisQuiz.AddQuestionToQuiz(firstTrueFalse);
            thisQuiz.AddQuestionToQuiz(secondTrueFalse);

            // run the quiz
            thisQuiz.TakeQuiz();
        }
    }
}
