using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[][] matrix = new int[rows][];

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            int maxRow = 0;
            int maxCol = 0;
            int maxSum = 0;

            for (int rowIndex = 0; rowIndex < matrix.Length - 1; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length - 1; colIndex++)
                {
                    var currentMaxSum = matrix[rowIndex][colIndex] + matrix[rowIndex + 1][colIndex] +
                         matrix[rowIndex][colIndex + 1] + matrix[rowIndex + 1][colIndex + 1];

                    if (currentMaxSum > maxSum)
                    {
                        maxSum = currentMaxSum;
                        maxRow = rowIndex;
                        maxCol = colIndex;
                    }
                }

            }
            Console.WriteLine($"{matrix[maxRow][maxCol]} {matrix[maxRow][maxCol + 1]}\n" +
                $"{matrix[maxRow + 1][maxCol]} {matrix[maxRow + 1][maxCol + 1]}");
            Console.WriteLine(maxSum);
        }
      
    }
}
