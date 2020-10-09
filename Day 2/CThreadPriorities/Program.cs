using System;
using System.Data;
using System.Threading;

namespace CThreadPriorities
{
    class Program
    {
        static Thread[] threads;
        static volatile bool shouldRun = true;

        static void Worker()
        {
            int i = 0;
            while (shouldRun)
            {
                i++;
            }
        }

        static void Main(string[] args)
        {
            threads = new Thread[Environment.ProcessorCount];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(Worker);
                threads[i].Priority = ThreadPriority.Lowest;
                threads[i].Start();
            }

            Console.WriteLine("Intensive computation is running...  Press ENTER to stop.");
            Console.ReadLine();
            shouldRun = false;

            foreach (var t in threads)
            {
                t.Join();
            }
            Console.WriteLine("Done.");
        }
    }
}
