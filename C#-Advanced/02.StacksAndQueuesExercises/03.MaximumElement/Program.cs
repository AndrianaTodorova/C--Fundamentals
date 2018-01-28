using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            Stack<int> maxValues = new Stack<int>();
            maxValues.Push(int.MinValue);

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                if (input.Length == 2)
                {
                    int numToPush = int.Parse(input[1]);
                    stack.Push(numToPush);

                    if (maxValues.Peek() <= numToPush)
                    {
                        maxValues.Push(numToPush);
                    }
                }
                else
                {
                    if (int.Parse(input[0]) == 2)
                    {
                        if (stack.Pop() == maxValues.Peek())
                        {
                            maxValues.Pop();
                        }
                    }
                    else
                    {

                        Console.WriteLine(maxValues.Peek());
                    }

                }
            }



        }
    }
}
