using System;
using System.Collections.Concurrent;
using System.Threading;

namespace EConcurrentCollections
{
    class Program
    {
        static ConcurrentDictionary<int, string> cDict = new ConcurrentDictionary<int, string>();

        static void Worker()
        {
            for (int i = 0; i < 1000; i++)
            {
                cDict.TryAdd(i, i.ToString());
            }
        }

        static void Main(string[] args)
        {
            Thread t1, t2;
            t1 = new Thread(Worker);
            t2 = new Thread(Worker);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            //Optimized for speed to add elements concurrently.
            ConcurrentBag<string> bag = new ConcurrentBag<string>();
            bag.Add("some value");
            //Can read elements by index; ex: bag[0]
            string[] bagContent = bag.ToArray(); //Get the full content;
            foreach (string s in bag)
            {
                //.. or enumerate it.
            }

            Console.WriteLine("Done.  Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
