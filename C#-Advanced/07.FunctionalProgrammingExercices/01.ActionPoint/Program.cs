using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Action<string> newNames = input => Console.WriteLine(string.Join('\n', input.Split(' ')));
            newNames(Console.ReadLine());
        }
    }
}
