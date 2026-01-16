// See https://aka.ms/new-console-template for more information

using System;

namespace TaskMaster
{
    // Value Type (Stack)
    struct TaskPriority
    {
        public int PriorityLevel;
    }

    // Reference Type (Heap)
    class UserTask
    {
        public string TaskName;
        public TaskPriority Priority;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // camelCase local variables
            TaskPriority taskPriority;
            taskPriority.PriorityLevel = 1;

            UserTask userTask = new UserTask();
            userTask.TaskName = "Task 1 Project";
            userTask.Priority = taskPriority;

            Console.WriteLine("Task Name: " + userTask.TaskName);
            Console.WriteLine("Priority Level: " + userTask.Priority.PriorityLevel);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
















