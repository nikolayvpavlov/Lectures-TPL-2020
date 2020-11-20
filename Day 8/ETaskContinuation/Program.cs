using System;
using System.Threading.Tasks;

namespace ETaskContinuation
{
    class Program
    {
        static void Main(string[] args)
        {
            //var first = new Task<int>(() => 42);
            //var second = first.ContinueWith(p => p.Result * 2);
            //var third = second.ContinueWith(p => p.Result.ToString());
            //var fourth = third.ContinueWith(p => Console.WriteLine(p.Result));

            //var first = new Task<int>(() => 42);
            //var last = first
            //    .ContinueWith(p => p.Result * 2)
            //    .ContinueWith(p => p.Result.ToString())
            //    .ContinueWith(p => Console.WriteLine(p.Result));


            var last = 
                Task.Run(() => 42)
                .ContinueWith(p => p.Result * 2)
                .ContinueWith(p => p.Result.ToString())
                .ContinueWith(p => Console.WriteLine(p.Result));
            

            try
            {
                last.Wait();
            }
            catch (AggregateException ex)
            {
                var e = ex.InnerException; //This is the exception you need.
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
