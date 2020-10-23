using System;
using System.Threading;

namespace AWhyLocking
{
    class Program
    {
        static int data = 100;
        static object objLock = new object();

        static void ThreadWorkerMonitor(object tag)
        {
            for (int i = 0; i < 10; i++)
            {
                Monitor.Enter(objLock);
                try
                {
                    data++;
                    Thread.Sleep(3);
                    data--;
                    Console.WriteLine($"{tag}: {data}");
                }
                finally
                {
                    Monitor.Exit(objLock);
                }
            }
        }

        static void ThreadWorker(object tag)
        {
            for (int i = 0; i < 10; i++)
            {
                int localData;
                lock (objLock)
                {
                    data++;
                    Thread.Sleep(3);
                    data--;
                    localData = data;
                }
                Console.WriteLine($"{tag}: {localData}");

            }
        }

        static void Main(string[] args)
        {
            Thread threadA, threadB;
            threadA = new Thread(ThreadWorker);
            threadB = new Thread(ThreadWorker);

            threadA.Start("A");
            threadB.Start("B");

            threadA.Join();
            threadB.Join();

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
