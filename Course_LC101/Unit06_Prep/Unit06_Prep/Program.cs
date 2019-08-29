using System;
using System.Collections.Generic;

namespace Unit06_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Student1 = new Student("John", 12, 20, 3.2);
            Student Student2 = new Student("Jane");

            Console.WriteLine(Student1);
            Student1.AddGrade(4, 3.0);
            Console.WriteLine(Student1);
            Console.WriteLine(Student2);
            Console.WriteLine(Student1.Equals(Student2));
        }
    }
}
