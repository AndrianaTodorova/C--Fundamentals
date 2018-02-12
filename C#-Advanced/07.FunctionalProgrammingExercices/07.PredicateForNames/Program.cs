using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = Console.ReadLine().Split(' ').ToList();

            Action<List<string>> result = str =>
            {
                foreach (var item in str)
                {
                    if (item.Length <= n)
                    {
                        Console.WriteLine(item);
                    }
                }
            };
            result.Invoke(list);
        }
    }
}
