using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> honor = input => input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList()
            .ForEach(p => Console.WriteLine($"Sir {p}"));
            honor(Console.ReadLine());
        }
    }
}
