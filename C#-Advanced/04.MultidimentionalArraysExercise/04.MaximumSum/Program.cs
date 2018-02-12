using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var matrix = new int[dimensions[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split().Take(dimensions[1]).Select(int.Parse).ToArray();
            }

            var resultBigestIndex = new int[2];
            int maxSum = int.MinValue;
            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int col = 0; col < matrix[row].Length - 2; col++)
                {

                    int sum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2]
                + matrix[row + 1][col] + matrix[row + 2][col] + matrix[row + 1][col + 1] +
                matrix[row + 2][col + 2] + matrix[row + 1][col + 2] + matrix[row+2][col+1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        resultBigestIndex[0] = row;
                        resultBigestIndex[1] = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine(string.Join(Environment.NewLine, matrix
                .Skip(resultBigestIndex[0])
                .Take(3)
                .Select(row => string.Join(" ", row.Skip(resultBigestIndex[1]).Take(3)))));
        }
    }
}
