using System;
using System.Collections.Generic;
using System.Text;

namespace Unit06_Prep
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
                int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
            : this(name, studentId, 0, 0) { }

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // Update the appropriate properties: NumberOfCredits, Gpa
        public void AddGrade(int courseCredits, double grade)
        {
            //set the new number of total credits
            NumberOfCredits = NumberOfCredits + courseCredits;

            //calculate the "quality score" from the new class:
            double newTqs = courseCredits * grade;

            //calculate the student's current TQS
            double currentTqs = NumberOfCredits * Gpa;

            double newGpa = (newTqs + currentTqs) / (NumberOfCredits + courseCredits);

            Gpa = newGpa;
            //it'd be slighlty easier and probably more realistic to calculate GPA from
            //course credit hours and course scores in a collection of some sort
        }

        // Determine the grade level of the student based on NumberOfCredits
        public string GetGradeLevel()
        {
            if (NumberOfCredits > 90)
            {
                return "Senior";
            } else if (NumberOfCredits >= 60 && NumberOfCredits <= 89)
            {
                return "Junior";
            } else if (NumberOfCredits >= 30 && NumberOfCredits <= 59)
            {
                return "Sophomore";
            } else
            {
                return "Freshman";
            }
        }

        public override String ToString()
        {
            return Name + " | " + StudentId + " | " + " | " + GetGradeLevel() + " | Credits: " + NumberOfCredits + " | GPA: " + Gpa;
        }

        public override bool Equals(object obj)
        { 
            //reference check
            if (obj == this)
            {
                return true;
            }

            //null check
            if (obj == null)
            {
                return false;
            }

            //class check
            if (obj.GetType() != GetType())
            {
                return false;
            }

            //cast
            Student studentObj = obj as Student;
            return StudentId == studentObj.StudentId;

            //custom comparison
        }
    }
}
