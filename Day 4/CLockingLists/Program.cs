using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CLockingLists
{
    class Program
    {
        static List<string> stringList = new List<string>();

        static void Worker()
        {
            for (int i = 0; i < 1000; i++)
            {
                Guid g = Guid.NewGuid();
                lock (stringList)
                {
                    stringList.Add(g.ToString());
                }
            }
        }

        static void Main(string[] args)
        {
            var threads = Enumerable
                .Range(1, 100)
                .Select(i => new Thread(Worker))
                .ToList();
            foreach (var t in threads) t.Start();
            Console.WriteLine("Working...");
            foreach (var t in threads) t.Join();

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();

        }
    }
}
