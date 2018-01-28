using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> text = new Stack<char>();

            foreach (var character in input)
            {
                text.Push(character);
            }

            while (text.Count != 0)
            {
                Console.Write(text.Pop());
            }
            Console.WriteLine();
        }
    }
}
