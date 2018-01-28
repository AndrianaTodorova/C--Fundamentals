using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PoisonousPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var days = new int[plants.Length];
            calculateSpan(plants, n, days);
            Console.WriteLine(days.Max());
        }
        static void calculateSpan(int[] plants, int n, int[] S)
        {
            Stack<int> st = new Stack<int>();
            st.Push(0);

            S[0] = 1;

            for (int i = 1; i < plants.Length; i++)
            {
                int maxDays = 0;
                while (st.Count != 0 && plants[st.Peek()] >= plants[i])
                {
                    maxDays = Math.Max(S[st.Pop()], maxDays);
                }
                if (st.Count > 0)
                {
                    S[i] = maxDays + 1;
                }

                st.Push(i);
            }
        }
    }
}
