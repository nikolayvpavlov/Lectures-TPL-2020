using System;
using System.Threading;

namespace BFirstThread
{
    class Program
    {
        static void ThreadWorker()
        {
            Console.WriteLine("Hello from a thread!");
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(ThreadWorker);
            Thread t2 = new Thread(ThreadWorker);

            t1.Start();
            t2.Start();

            Console.WriteLine("Done, press ENTER to quit.");
        }
    }
}
