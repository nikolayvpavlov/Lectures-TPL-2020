using System;
using System.Threading.Tasks;

namespace CIntroTasks
{
    class Program
    {
        static void Worker()
        {
            Console.WriteLine("My first task!");
        }

        static void Main(string[] args)
        {
            Task task = new Task(Worker);
            task.Start();

            Task another = Task.Run(() => Console.WriteLine("I am a task, too!"));

            Task longTask = new Task(() => /*Something slow*/ Console.WriteLine("I am a long-running task"), 
                TaskCreationOptions.LongRunning);
            longTask.Start();

            Task<int> taskWithResult = Task.Run(() => 42);
            var taskResult = taskWithResult.Result; //Will wait for the task to finish.
            Console.WriteLine("Task result is " + taskResult);

            Console.ReadLine();
        }
    }
}
