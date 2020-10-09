using System;
using System.Threading;

namespace CMoreThreads
{
    class Program
    {
        static bool isRunning = false;
        static string ThreadResult;
        static void ThreadWorker(object data)
        {
            for (int i = 0; i < (int)data; i++)
            {
                Thread.Sleep(1000);
            }
            ThreadResult = "42";
            isRunning = false;
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(start: ThreadWorker);

            isRunning = true;
            Console.Write("Progress: ");

            t1.Start(5);

            while (isRunning)
            {
                //Do something while the t1 is running...
                Console.Write(".");
                Thread.Sleep(300);
            }
            Console.WriteLine();
            Console.WriteLine("Thread result: " + ThreadResult);

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
