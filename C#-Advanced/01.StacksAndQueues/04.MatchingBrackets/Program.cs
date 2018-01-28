using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIndex = stack.Pop();
                    string contents = input.Substring(startIndec, i - startIndex + 1);
                    Console.WriteLine(contents);
                }
               
            }
        }
    }
}
