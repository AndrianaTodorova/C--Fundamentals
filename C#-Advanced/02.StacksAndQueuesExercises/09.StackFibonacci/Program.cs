using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<long> fib = new Stack<long>();
            fib.Push(0);
            fib.Push(1);

            for (int i = 0; i < n-1; i++)
            {
                long a = fib.Pop();
                long b = fib.Peek();
                fib.Push(a);
                fib.Push(a + b);
            }

            Console.WriteLine(fib.Pop());
        }
    }
}
