using System;
using System.Linq;
using System.Collections;

namespace _03._2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rowsAndCols = Console.ReadLine().Split(' ');
            int counter = 0;
            char[,] matrix = new char[int.Parse(rowsAndCols[0]), int.Parse(rowsAndCols[1])];
            //Read the matrix from the Console
            for (int i = 0; i < int.Parse(rowsAndCols[0]); i++)
            {
                string[] reminder = Console.ReadLine().Split(' ');
                for (int j = 0; j < int.Parse(rowsAndCols[1]); j++)
                {
                    matrix[i, j] = char.Parse(reminder[j]);
                }
            }

            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    if (matrix[i,j] == matrix[i,j+1] && matrix[i,j] == matrix[i+1,j] && matrix[i,j] == matrix[i+1,j+1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }

      
    }
}
