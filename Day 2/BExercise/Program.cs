using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Xml.Schema;

namespace BExercise
{
    class Program
    {
        static int[] numbers;
        static Thread[] threads;

        static void Worker(object index)
        {
            Random rand = new Random();
            int num = rand.Next(100);
            int idx = (int)index;
            numbers[idx] = num;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of threads: ");
            int count = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            numbers = new int[count];
            threads = new Thread[count];
            for (int i = 0; i < count; i++)
            {
                threads[i] = new Thread(Worker);
                threads[i].Start(i);
            }

            foreach (var t in threads)
            {
                t.Join();
            }

            int sum = numbers.Sum();
            Console.WriteLine("Total: " + sum.ToString());
            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
