using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateSequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            Queue<long> myElements = new Queue<long>();
            List<long> elementsToPrlong = new List<long>();
            myElements.Enqueue(N);
            elementsToPrlong.Add(N);
            while (elementsToPrlong.Count < 50)
            {
                long currentElement = myElements.Dequeue();
                long firstElement = currentElement + 1;
                long secondElement = (currentElement * 2) + 1;
                long thirdElement = currentElement + 2;

                myElements.Enqueue(firstElement);
                myElements.Enqueue(secondElement);
                myElements.Enqueue(thirdElement);

                elementsToPrlong.Add(firstElement);
                elementsToPrlong.Add(secondElement);
                elementsToPrlong.Add(thirdElement);
            }

            //Console.WriteLine(string.Join(" ", elementsToPrlong));

            for (int i = 0; i < 50; i++)
            {
                Console.Write(elementsToPrlong[i] + " ");
            }

        }
    }
}
