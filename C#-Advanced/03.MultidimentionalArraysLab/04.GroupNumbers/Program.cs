using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            List<int> reminder0 = new List<int>();
            List<int> reminder1 = new List<int>();
            List<int> reminder2 = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 3 == 0)
                {
                    reminder0.Add(nums[i]);
                }
                else if (nums[i] % 3 == 1 || nums[i] % 3 == -1)
                {
                    reminder1.Add(nums[i]);
                }
                else if (nums[i] % 3 == 2 || nums[i] % 3 == -2)
                {
                    reminder2.Add(nums[i]);
                }
            }

            Console.WriteLine(string.Join(" ", reminder0));
            Console.WriteLine(string.Join(" ", reminder1));
            Console.WriteLine(string.Join(" ", reminder2));
        }
    }
}
