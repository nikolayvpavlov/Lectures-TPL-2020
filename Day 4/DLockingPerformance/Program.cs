using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DLockingPerformance
{
    class Program
    {
        static object objLock = new object();

        static void LockMethod()
        {
            string s = "";
            for (int i = 0; i < 10_000; i++)
            {
                lock (objLock)
                {
                    s = s + i.ToString();
                }
            }
        }

        static void LocklessMethod()
        {
            string s = "";
            for (int i = 0; i < 10_000; i++)
            {
                s = s + i.ToString();
            }
        }

        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            LockMethod();
            watch.Stop();
            Console.WriteLine("Lock: " + watch.ElapsedMilliseconds);

            watch.Restart();
            LocklessMethod();
            watch.Stop();
            Console.WriteLine("Lockless: " + watch.ElapsedMilliseconds);
            
            Console.ReadLine();
        }
    }
}
