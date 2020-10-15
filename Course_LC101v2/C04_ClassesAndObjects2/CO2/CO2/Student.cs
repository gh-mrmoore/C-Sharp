using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2
{
    public class Student
    {
        // Fields
        private static int nextStudentId = 1;
        private string name;
        private int studentId;
        private int numberOfCredits = 0;
        private double gpa = 0.0;

        // Getters and Setters
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 1)
                {
                    throw ArgumentException("Value is not long enough!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        private Exception ArgumentException(string v)
        {
            throw new NotImplementedException();
        }

        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        // Contructor(s)
        public Student(string name, int studentId, int creditNumber, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = creditNumber;
            Gpa = gpa;
        }

        // static methods

        // instance methods
        public void AddGrade(int courseCredits, double grade)
        {
            // get current gradepoints
            double currentGradePoints = this.NumberOfCredits * this.Gpa;
            double newGradePoints = currentGradePoints + (courseCredits * grade);

            // update number of credits
            int currentCredits = this.NumberOfCredits;
            int newCredits = currentCredits + courseCredits;
            this.NumberOfCredits = newCredits;

            // update GPA
            this.Gpa = newGradePoints / newCredits;
        }

        public string GetGradeLevel()
        {
            if (this.NumberOfCredits >= 90)
            {
                return "Senior";
            } else if (this.NumberOfCredits >= 60)
            {
                return "Junior";
            } else if (this.NumberOfCredits >= 30)
            {
                return "Sophomore";
            } else
            {
                return "Freshman";
            }
        }

        // Override Methods
        public override bool Equals(object forComparison)
        {
            // reference check
            if (forComparison == this)
            {
                return true;
            }

            // null check
            if (forComparison == null)
            {
                return false;
            }

            // class check
            if (forComparison.GetType() != this.GetType())
            {
                return false;
            }

            // cast
            Student checkingStudent = forComparison as Student;

            // custom comparison(s)
            if (checkingStudent.StudentId == StudentId && checkingStudent.Name == Name)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return Name + " (" + StudentId + ")" + " has a GPA of: " + Gpa + " and has taken " + NumberOfCredits + " credit hours.";
        }
    }
}
