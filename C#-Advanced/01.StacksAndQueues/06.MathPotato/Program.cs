using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MathPotato
{
    class Program
    {
        static bool isPrime(int cycle)
        {
            if (cycle == 1) return false;
            if (cycle == 2) return true;
            if (cycle % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(cycle));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (cycle % i == 0) return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            var children = Console.ReadLine().Split(' ');
            var number = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(children);
            int cycle = 1;
            while (queue.Count != 1)
            {
                for (int i = 1; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
             
                if (isPrime(cycle))
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
               
                else
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                cycle++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
    
}
