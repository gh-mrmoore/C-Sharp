using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    public class Student
    {
        //declare Class fields
        private static int nextStudentId = 1;
        private string name;
        private int studentId;
        private int numberOfCredits = 0;
        private double gpa = 0.0;

        //create getters and setters
        public string Name
        {
            get { return name; }
            set { if (value.Length < 1)
                {
                    throw new ArgumentException("Value is not long enough.");
                } }
        }

        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }


        //create constructor(s)
        public Student(string name, int studentId, int numberOfCredits, double gpa)  //primary constructor
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        //public Student(string name, int studentId)  //overload constructor
        //{
        //    Name = name;
        //    StudentId = studentId;
        //    NumberOfCredits = 0;
        //    Gpa = 0.0;
        //}

        public Student(string name, int studentId)
            : this(name, studentId, 0, 0) {}  // this chains the constructor

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }
        // don't have to create no-arg constructor, but have to supply one if you create _any_ constructor in your class

        //instance methods
        public String StudentInfo()
        {
            return (Name + " has a GPA of " + Gpa);
        }
    }
}
