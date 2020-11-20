using System;
using System.Linq;
using System.Threading.Tasks;

namespace FMultipleTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks =
                Enumerable
                .Range(0, 10)
                .Select(i => Task.Run(() =>
                  {
                      Random rand = new Random();
                      return rand.Next(10);
                  })
               ).ToArray();

            try
            {
                Task.WaitAll(tasks);
            }
            catch (AggregateException ex)
            {
                //Remember to check the InnerException and do something about it, right?
            }

            Task.Delay(100).Wait(); //The right way to sleep.

            Console.WriteLine("Total :" + tasks.Sum(t => t.Result));
            Console.ReadLine();
        }
    }
}
