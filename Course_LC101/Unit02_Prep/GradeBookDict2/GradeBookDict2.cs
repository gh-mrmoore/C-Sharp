using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBookDict2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("Student Name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's grade
                    Console.Write("ID: ");
                    int newID = int.Parse(Console.ReadLine());

                    students.Add(newStudent, newID);
                }
            }
            while (newStudent != "");

            // Print roster
            /*
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<string, int> student in students)
            {
                Console.WriteLine("Name (key): " + student.Key + " || ID (value): " + student.Value);
            }
            */

            //Print roster using StringBuilder
            
            foreach (KeyValuePair<string, int> student in students)
            {
                StringBuilder studentString = new StringBuilder("Name: ");
                studentString.Append(student.Key);
                studentString.Append(" || ID: ");
                studentString.Append(student.Value);
                Console.WriteLine(studentString);
            }
        }
    }
}
