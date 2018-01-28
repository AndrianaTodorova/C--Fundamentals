using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RecursiveFibonacci
{
    class Program
    {
        static long[] memoization;
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            memoization = new long[n];
            Console.WriteLine(getFibonacci(n));
        }
        static long getFibonacci(long n)
        {
            if (memoization[n - 1] == 0)
            {
                if (n <= 2)
                {
                    memoization[n - 1] = 1;
                }
                else
                {
                    memoization[n - 1] = getFibonacci(n - 1) + getFibonacci(n - 2);
                }
            }

            return memoization[n - 1];
        }
    }
}
