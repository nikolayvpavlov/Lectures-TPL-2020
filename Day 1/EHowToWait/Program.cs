using System;
using System.Threading;

namespace EHowToWait
{
    class Program
    {
        static bool isRunning;
        static void Worker()
        {
            for (int i= 0; i < 10; i++)
            {
                Thread.Sleep(200);
            }
            isRunning = false;
            Console.WriteLine("Thread is done.");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(Worker);
            
            isRunning = true;
            t.Start();

            int i = 0;
            bool myInternalFlag = isRunning;
            while (myInternalFlag)
            {
                i++;
            }

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
