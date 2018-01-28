using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            int truckFuel = 0;
            int startIndex = 0;
            for (int i = 0; i < N; i++)
            {
                int[] amount = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int petrol = amount[0];
                int distance = amount[1];
            }
            Console.WriteLine(startIndex);
        }
    }
}
