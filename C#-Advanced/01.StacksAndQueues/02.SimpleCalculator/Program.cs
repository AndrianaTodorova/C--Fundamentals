using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            var values = numbers.Split(' ');
            var stack = new Stack<string>(values.Reverse());

         while(stack.Count > 1)
            { 
                int first = int.Parse(stack.Pop());
                string operand = stack.Pop();
                int second = int.Parse(stack.Pop());

                if (operand == "+")
                {
                    stack.Push((first + second).ToString());
                }
                else
                {
                    stack.Push((first - second).ToString());
                }
            }
            Console.WriteLine(stack.Pop()); 
        }
    }
}
