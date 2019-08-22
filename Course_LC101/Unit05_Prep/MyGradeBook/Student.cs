using System;
using System.Collections.Generic;
using System.Text;

namespace MyGradeBook
{
    class Student
    {
        private static int nextStudentId = 1;
        public String Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(String name, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = nextStudentId++;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
            : this(name, 0, 0) { }
    }
}
