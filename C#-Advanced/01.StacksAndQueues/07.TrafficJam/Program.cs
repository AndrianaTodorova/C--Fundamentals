using System;
using System.Collections;
using System.Collections.Generic;

namespace _07.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            var input = Console.ReadLine();
            var queue = new Queue<string>();
            int counter = 0;
            while (input != "end")
            {
                if (input == "green")
                {
                    var carsThatPassed = Math.Min(queue.Count, carsCount);
                    for (int i = 0; i < carsThatPassed; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        counter++;
                       
                    }
                   
                }
                else
                {
                    queue.Enqueue(input);
                }
                

                input = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
