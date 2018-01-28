using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] operations = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            Stack<int> stack = new Stack<int>();

            try
            {
                int N = int.Parse(operations[0]);
                int S = int.Parse(operations[1]);
                int X = int.Parse(operations[2]);

                for (int i = 0; i < N; i++)
                {
                    stack.Push(int.Parse(numbers[i]));
                }
                for (int i = 0; i < S; i++)
                {
                    stack.Pop();
                }

                if (stack.Contains(X))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Pop()); 
                }
             
            }
            catch (Exception)
            {

                Console.WriteLine(0);
            }
            
        }
    }
}
