using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int division = int.Parse(Console.ReadLine());

            Action<List<int>> reversedAndExcluder = num =>
            {
                int divise = division;
                num.Reverse();
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i] % divise == 0)
                    {
                        num.Remove(num[i]);
                        i--;
                    }
                }
                Console.WriteLine(string.Join(" ", num));
            };

            reversedAndExcluder.Invoke(nums);
        }
    }
}
