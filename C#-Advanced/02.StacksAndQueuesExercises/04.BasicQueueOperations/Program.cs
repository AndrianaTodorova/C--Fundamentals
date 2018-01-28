using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] operations = Console.ReadLine().Split(' ').ToArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();
            try
            {
                int N = int.Parse(operations[0]);
                int S = int.Parse(operations[1]);
                int X = int.Parse(operations[2]);

                for (int i = 0; i < N; i++)
                {
                    queue.Enqueue(numbers[i]);
                }
                for (int i = 0; i < S; i++)
                {
                    queue.Dequeue();
                }
                if (queue.Contains(X))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }

            }
            catch (Exception)
            {

                Console.WriteLine(0); 
            }
            
        }
    }
}
