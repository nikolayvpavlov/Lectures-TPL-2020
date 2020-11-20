using System;
using System.Threading.Tasks;

namespace DTasksContinued
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string> t = Task.Run(() =>
           {
               throw new Exception("Something went wrong");
               return "Hello";
           });

            try
            {
                t.Wait();
                string taskResult = t.Result;
                Console.WriteLine("Task result: " + taskResult);
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Actual exception text: " + ex.InnerException.Message);
            }
            

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
