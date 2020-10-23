using System;
using System.Threading;

namespace BRandomSumLocking
{
    class Program
    {
        static int sum = 0;
        static object objLock = new object();
        static Random rand = new Random();

        static void Worker()
        {
            lock (objLock)
            {
                int n = rand.Next(100);
                sum += n;
            }
        }

        static void Main(string[] args)
        {
            int threadCount = 10;
            Thread[] threads = new Thread[threadCount];
            for (int i = 0; i < threadCount; i++)
            {
                threads[i] = new Thread(Worker);
                threads[i].Start();
            }
            foreach (var t in threads) t.Join();

            Console.WriteLine("Total: " + sum);
            Console.ReadLine();
        }
    }
}
