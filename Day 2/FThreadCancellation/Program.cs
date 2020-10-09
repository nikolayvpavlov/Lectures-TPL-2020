using System;
using System.Threading;

namespace FThreadCancellation
{
    enum ThreadResult { Working, Success, Canceled, Error }
    class Program
    {
        static string threadOutput;
        static volatile bool flagCancel = false;
        static volatile ThreadResult threadResult;

        static void Worker()
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    if (flagCancel)
                    {
                        //We must stop working.
                        threadOutput = ""; //Always clean after yourself.
                        threadResult = ThreadResult.Canceled;
                        return;
                    }
                    Thread.Sleep(1000);
                    threadOutput = threadOutput + (Char)('A' + i);
                }
                threadResult = ThreadResult.Success;
            }
            catch
            {
                threadResult = ThreadResult.Error;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Work in progress. Press 'c' to cancel.");

            Thread t = new Thread(Worker);
            t.Start();
            threadResult = ThreadResult.Working;

            while (threadResult == ThreadResult.Working)
            {
                if (Console.KeyAvailable)
                {
                    char ch = Console.ReadKey(true).KeyChar;
                    if (ch == 'c')
                    {
                        flagCancel = true;
                        t.Join();
                    }
                }
                Console.Write(".");
                Thread.Sleep(300);
            }
            Console.WriteLine();

            switch (threadResult)
            {
                case ThreadResult.Success:
                    Console.WriteLine("Result: " + threadOutput);
                    break;
                case ThreadResult.Canceled:
                    Console.WriteLine("Operation was canceled.");
                    break;
                case ThreadResult.Error:
                    Console.WriteLine("Some error has occured.");
                    break;
                default:
                    throw new Exception("Operation not supported, call the developers!");
            }
            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
