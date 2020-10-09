using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ABranchPrediction
{
    class Program
    {
        const int size = 10_000_000;
        static int[] data = new int[size];

        static void GenerateRandomData()
        {
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                data[i] = rand.Next(10);
            }
        }

        static int CountBoundary(int boundary)
        {
            int result = 0;
            for (int i = 0; i < size; i++)
            {
                if (data[i] < boundary) result++;
            }
            return result;
        }

        static void Main(string[] args)
        {
            GenerateRandomData();

            for (int i = 0; i < 11; i++)
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                int count = CountBoundary(i);
                watch.Stop();
                Console.WriteLine($"Boundary {i}: Count = {count}, Elapsed = {watch.ElapsedTicks}");
            }
            Console.WriteLine("Ready.  Press ENTER to quit.");
            Console.ReadLine();

        }
    }
}
