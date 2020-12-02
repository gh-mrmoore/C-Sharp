using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Studio_Quiz
    {
        public List<Studio_Question> QuizQuestions { get; set; }
        public int QuizCorrect { get; set; }  //won't necessarily know how many questions in each quiz, so leave this flexible
        public int QuizIncorrect { get; set; }

        // constructor(s)
        public Studio_Quiz() { }

        public Studio_Quiz(List<Studio_Question> listOfQuestions)
        {
            QuizQuestions = listOfQuestions;
        }

        // let someone take the quiz
        public void TakeQuiz (/*List<Studio_Question> quizQuestions*/)
        {
            foreach(Studio_Question question in QuizQuestions)
            {
                // display questions
                Console.WriteLine(question.ToString());
                // display possible answers
                Console.WriteLine(question.ShowPossibleAnswers());
                // get answers
                string userQuestionAnswer = Console.ReadLine();
                // compare given answers to correct answers
                // add to score if the question is answered correctly
                if (question.GradeQuestion(userQuestionAnswer) == 1)
                {
                    QuizCorrect++;
                } else
                {
                    QuizIncorrect++;
                }
                // show the final score and results to the user
                Console.WriteLine(GradedQuiz());

            }


        }

        // add a question to a quiz
        public void AddQuestionToQuiz(Studio_Question questionAdded)
        {
            QuizQuestions.Add(questionAdded);
        }

        // remove a question from a quiz
        public void RemoveQuestionFromQuiz()
        {
            // code to remove question from quiz
        }

        // grade the quiz
        public string GradedQuiz()
        {
            return "You got " + QuizCorrect + " questions correct and " + QuizIncorrect + " questions incorrect.";
        }
    }
}
