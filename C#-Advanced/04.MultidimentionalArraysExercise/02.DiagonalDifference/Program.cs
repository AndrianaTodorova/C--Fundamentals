using System;
using System.Linq;

namespace _02.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsAndCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowsAndCols, rowsAndCols];
            //Read the matrix from the Console
            for (int i = 0; i < rowsAndCols; i++)
            {
                string[] reminder = Console.ReadLine().Split(' ');
                for (int j = 0; j < rowsAndCols; j++)
                {
                    matrix[i, j] = int.Parse(reminder[j]);
                }
            }

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            //Get the sum of diagonals
            for (int i = 0; i < rowsAndCols; i++)
            {
                primaryDiagonal += matrix[i, i];
            }
            for (int i = 0; i < rowsAndCols; i++)
            {
                secondaryDiagonal += matrix[i, rowsAndCols - i - 1];
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}
