using System;

namespace CO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jack", 1, 0, 0);
            Console.WriteLine(student1.ToString());
            student1.AddGrade(4, 4);
            student1.AddGrade(4, 3);
            Console.WriteLine(student1.ToString());









            //Student student2 = new Student("Jill", 2, 0, 0);
            //Student student3 = new Student("Jack", 1, 0, 0);


            //Console.WriteLine(student2.ToString());

            //Console.WriteLine(student1 == student2);
            //Console.WriteLine(student1 == student3);

            //if(student1.Equals(student3))
            //{
            //    Console.WriteLine("Student1 and Student3 are equal.");
            //} else
            //{
            //    Console.WriteLine("Student1 and Student3 are not equal.");
            //}
        }
    }
}
