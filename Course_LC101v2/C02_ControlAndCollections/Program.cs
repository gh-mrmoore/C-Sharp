using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ControlAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prep and examples
            //Console.WriteLine("What is the number grade?");
            //int StudentGrade = int.Parse(Console.ReadLine());

            //if (StudentGrade < 60)
            //{
            //    Console.Write("Letter grade is F");
            //} else if (StudentGrade < 70)
            //{
            //    Console.WriteLine("Letter grade is D");
            //} else
            //{
            //    Console.WriteLine("Letter grade is neither D nor F");
            //}

            //Console.WriteLine("Enter a number from 1 to 3");
            //int DayNum = int.Parse(Console.ReadLine());
            //string day;
            //switch(DayNum)
            //{
            //    case 1:
            //        day = "Sunday";
            //        break;
            //    case 2:
            //        day = "Monday";
            //        break;
            //    case 3:
            //        day = "Tuesday";
            //        break;
            //    default:
            //        day = "I'm sorry, your input did not match any of the given cases.";
            //        break;
            //}
            //Console.WriteLine(day);

            //Console.WriteLine("Which code block would you like to run?");
            //string CodeBlock = Console.ReadLine();
            //string TestResult;
            //switch(CodeBlock)
            //{
            //    case "Studio":
            //        TestResult = "Studio Code Worked";
            //        break;
            //    case "Exercises":
            //        TestResult = "Exercises Code Worked";
            //        break;
            //    default:
            //        TestResult = "Other Code did not work";
            //        break;
            //}
            //Console.WriteLine(TestResult);

            //for (int i = 100; i >= 0; i-=10)
            //{
            //    Console.WriteLine(i);
            //}

            //Exercises
            //int[] exerciseOneList = { 1, 1, 2, 3, 5, 8 };
            //foreach(int x in exerciseOneList)
            //{
            //    Console.WriteLine(x);
            //}

            //Console.WriteLine("=====================================");

            //foreach(int y in exerciseOneList)
            //{
            //    if (y % 2 != 0)
            //    {
            //        Console.WriteLine(y);
            //    }
            //}
            //Console.WriteLine("=====================================");

            //string wouldNot = "I would not, could not, in a box. I would not, could not with a fox. " +
            //    "I will not eat them in a house. I will not eat them with a mouse.";

            //string[] wouldNotArray = wouldNot.Split(' ');
            //Console.WriteLine("=====================================");

            //Console.WriteLine("Split string");
            //foreach (string c in wouldNotArray)
            //{
            //    Console.WriteLine(c);
            //}
            //Console.WriteLine("=====================================");

            //char[] wouldNot2Array = wouldNot.ToCharArray();

            //Console.WriteLine("To Character Array");
            //foreach (char c in wouldNot.ToCharArray())
            //{
            //    Console.WriteLine("Character " + c + " " + char.IsLetter(c));
            //}

            //Console.WriteLine("=====================================");
            //Console.WriteLine(string.Join(",", wouldNotArray));
            //Console.WriteLine("=====================================");

            //int[] intArray = { 1, 2, 2, 3, 3, 4 };

            //Console.WriteLine(GetEvenSum(intArray));
            //Console.WriteLine("=====================================");

            //string[] newStringArray = { "Boooo", "Help", "Sharp", "Cool!", "Bat" };
            //FiveLetters(newStringArray);

            //Studio
            string SampleString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin. " +
                "Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. " +
                "Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, " +
                "dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            //create an empty dictionary to hold each letter/count pairing
            Dictionary<char, int> LetterCount = new Dictionary<char, int>();

            ////loop thru the string as an array of characters
            foreach (char c in SampleString.ToCharArray())
            {
                if(char.IsLetter(c))
                {
                    if(LetterCount.TryGetValue(c, out int result))
                    {
                        LetterCount[c] = result + 1;
                    }
                    else
                    {
                        LetterCount.Add(c, 1);
                    }
                }
            }

            ////iterate over the dictionary and display each key with its value
            foreach (KeyValuePair<char, int> abc in LetterCount)
            {
                Console.WriteLine("Key = {0}, Value = {1}", abc.Key, abc.Value);
            }

            /*
            Queue (FIFO, first-in, first-out)
            Queue<string> students = new Queue<string>();
            students.Enqueue("Student1");
            Console.WriteLine(students.Dequeue());

            Stack (last-in, first-out)
            Stack<string> states = new Stack<string>();
            states.Push("Kansas");
            states.Push("Missouri");
            Console.WriteLine(states.Pop());
            */
        }

        static int GetEvenSum(int[] IntArray)
        {
            int evensSum = 0;
            foreach(int x in IntArray)
            {
                if (x % 2 == 0)
                {
                    evensSum += + x;
                }
            }
            return evensSum;
        }

        static void FiveLetters(string[] StringArray)
        {
            foreach(string someString in StringArray)
            {
                if (someString.Length == 5)
                {
                    Console.WriteLine(someString);
                }
            }
        }
    }
}
