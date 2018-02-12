using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindEvenOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = bounds[0];
            int ends = bounds[1];
            string evenOrOdd = Console.ReadLine();
            Predicate<int> oddPredicate = x =>
            {
                if (evenOrOdd == "even")
                {
                    return x % 2 == 0;
                }

                return x % 2 != 0;
            };
            List<int> list = new List<int>();
            for (int i = start; i <= ends; i++)
            {
                list.Add(i);
            }

             bounds = list.Where(x => oddPredicate.Invoke(x)).ToArray();

            foreach (var item in bounds)
            {
                Console.Write(item + " ");
            }
        }
    }
}
