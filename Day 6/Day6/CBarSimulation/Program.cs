using System;
using System.Linq;
using System.Threading;

namespace CBarSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Bar bar = new Bar();
            var students = 
                Enumerable.Range(1, 51)
                .Select(i => new Student { Name = i.ToString(), Bar = bar })
                .ToList();

            foreach (var student in students)
            {
                student.PaintTheTownRed();
            }

            while (students.Any (s => ! s.AtHome))
            {

            }
            Console.WriteLine("Show is over.");
            Console.ReadLine();
        }
    }
}
