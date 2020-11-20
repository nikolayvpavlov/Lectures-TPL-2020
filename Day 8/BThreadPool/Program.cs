using System;
using System.Threading;

namespace BThreadPool
{
    class Program
    {
        static ManualResetEvent taskCompletedEvent = new ManualResetEvent(false);

        static void SomeBackgroundTask(object state)
        {
            Console.WriteLine("Hello from the Thread pool!");
            taskCompletedEvent.Set();
        }

        static void Main(string[] args)
        {
            ThreadPool.GetMinThreads(out int wt, out int iocpt);
            Console.WriteLine(wt + ", " + iocpt);            
            
            ThreadPool.QueueUserWorkItem(SomeBackgroundTask);

            taskCompletedEvent.WaitOne();


            Console.ReadLine();
        }
    }
}
