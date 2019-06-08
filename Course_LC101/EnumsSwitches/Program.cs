using System;
using System.Collections.Generic;

namespace EnumsSwitches
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> taskList = new List<Task>()
            {
                new Task { taskDescription = "Grocery Shopping", taskStatus = Status.NotStarted, taskDate = Convert.ToDateTime("2019, 6, 7"), taskComplete = false },
                new Task { taskDescription = "Vacuum", taskStatus = Status.NotStarted, taskDate = Convert.ToDateTime("2019, 6, 7"), taskComplete = false },
                new Task { taskDescription = "Laundry", taskStatus = Status.InProgress, taskDate = Convert.ToDateTime("2019, 6, 7"), taskComplete = false },
                new Task { taskDescription = "Dishes", taskStatus = Status.Completed, taskDate = Convert.ToDateTime("2019, 6, 7"), taskComplete = false }
            };

            PrintAssessment(taskList);
        }

        private static void PrintAssessment(List<Task> taskList)
        {
            foreach (var task in taskList)
            {
                switch (task.taskStatus)
                {
                    case Status.NotStarted:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine(task.taskDescription);
                        break;
                    case Status.InProgress:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(task.taskDescription);
                        break;
                    case Status.OnHold:
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.WriteLine(task.taskDescription);
                        break;
                    case Status.Completed:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine(task.taskDescription);
                        break;
                    case Status.Abandoned:
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(task.taskDescription);
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                }
            }
        }
    }
    
    class Task
    {
        public String taskDescription { get; set; }
        public Status taskStatus { get; set; }   //use an enumeration to limit the number of user choices
        public DateTime taskDate { get; set; }
        public bool taskComplete { get; set; }
    }

    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Abandoned
    }
}
