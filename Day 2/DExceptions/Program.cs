using System;
using System.Net;
using System.Threading;

namespace DExceptions
{
    enum ThreadResult { Success, Canceled, Error }
    class Program
    {
        static string threadOutput;
        static ThreadResult threadResult;

        static void FaultyWorker()
        {
            try
            {
                Console.WriteLine("I am about to fail...");
                Thread.Sleep(1500);
                int i = 0, b = 10, c = b / i;
                threadOutput = "I did something great!";
                threadResult = ThreadResult.Success;
            }
            catch
            {
                threadResult = ThreadResult.Error;
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(FaultyWorker);
            t.Start();

            Console.WriteLine("Wait for the thread to finish...");
            t.Join();

            if (threadResult == ThreadResult.Success)
            {
                Console.WriteLine("And the result is: " + threadOutput);
            }
            else
            {
                Console.WriteLine("Operation failed.");
            }

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}
