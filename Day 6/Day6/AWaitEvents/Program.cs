using System;
using System.Threading;

namespace AWaitEvents
{
    class Program
    {
        static ManualResetEvent resetEvent;
        static ManualResetEvent threadCompletedEvent;

        static void Worker()
        {
            Console.WriteLine("Thread starts.");
            Console.WriteLine("Doing some work: ");
            //
            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            Console.WriteLine();
            //Wait for a signal to continue.
            resetEvent.WaitOne();
            Console.WriteLine("Do some more work and quit.");
            Thread.Sleep(2000);
            Console.WriteLine("Thread quits.");
            threadCompletedEvent.Set();
        }

        static void Main(string[] args)
        {
            resetEvent = new ManualResetEvent(false);
            threadCompletedEvent = new ManualResetEvent(false);
            Thread t = new Thread(Worker);
            t.Start();

            Console.WriteLine("Main: now do something while the thread is running.");
            Thread.Sleep(2000);

            Console.WriteLine("Let the thread go.");
            resetEvent.Set();

            Console.WriteLine("Wait for T to complete: ");
            while (! threadCompletedEvent.WaitOne(100))
            {
                Console.Write(".");
            }
            Console.WriteLine();
            

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
