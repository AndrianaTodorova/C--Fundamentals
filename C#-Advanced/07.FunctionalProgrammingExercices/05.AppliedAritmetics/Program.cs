using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AppliedAritmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string commands = Console.ReadLine();
            Action<string> manipulateNums = operation =>
            {
                switch (operation)
                {
                    case "add":
                        nums = nums.Select(n => n + 1).ToArray();
                        break;
                    case "multiply":
                        nums = nums.Select(n => n * 2).ToArray();
                        break;
                    case "subtract":
                        nums = nums.Select(n => n - 1).ToArray();
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                }
            };

            while (commands != "end")
            {
                manipulateNums(commands);

                commands = Console.ReadLine();
            }
        }
    }
}
