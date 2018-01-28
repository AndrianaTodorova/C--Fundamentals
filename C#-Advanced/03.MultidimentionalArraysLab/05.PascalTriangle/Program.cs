using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long rows = long.Parse(Console.ReadLine());

            long[][] jaggedTriangle = new long[rows][];

            long currentWidth = 1;

            for (long height = 0; height < rows; height++)
            {
                jaggedTriangle[height] = new long[currentWidth];
                long[] currentRow = jaggedTriangle[height];
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;
                currentWidth++;

                if (currentRow.Length > 2)
                {
                    for (long i = 1; i < currentRow.Length - 1; i++)
                    {
                        long[] previousRow = jaggedTriangle[height - 1];
                        long previousRowSum = previousRow[i] + previousRow[i - 1];
                        currentRow[i] = previousRowSum;
                    }
                }
            }

            foreach (var row in jaggedTriangle)
            {
                Console.WriteLine(string.Join(" ", row));
            }

        }
    }
}
