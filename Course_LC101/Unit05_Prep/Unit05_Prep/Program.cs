using System;

namespace Unit05_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld hello = new HelloWorld();

            hello.sayHello();

        }
    }

    public class Student
    {
        public String Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(String name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
            : this(name, studentId, 0, 0) { }
    }

    public class HelloWorld
    {
        private string message = "Hello World";

        public void sayHello()
        {
            String message = "Good morning";

            Console.WriteLine(message);
            Console.WriteLine(this.message);
        }
    }
}
