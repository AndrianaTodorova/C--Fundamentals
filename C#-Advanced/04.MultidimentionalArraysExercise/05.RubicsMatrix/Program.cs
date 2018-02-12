using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RubicsMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int matrixRow = dimentions[0];
            int matrixColumn = dimentions[1];
            int start = 1;
            int[,] matrix = new int[matrixRow, matrixColumn];
            
            for (int row = 0; row < matrixRow; row++)
            {
                for (int col = 0; col < matrixColumn; col++)
                {
                    matrix[row, col] = start;
                    start++;
                }
            }
            int N = int.Parse(Console.ReadLine());
            int index = 0;
            int steps = 0;
            string command = string.Empty;
         
            for (int i = 0; i < N; i++)
            {
                string[] commands = Console.ReadLine().Split(' ');
                index = int.Parse(commands[0]);
                command = commands[1];
                steps = int.Parse(commands[2]);

                switch (command)
                {
                    case "up":
                        moveCol(matrix, index, steps, matrixRow);
                        break;
                    case "down":
                        moveCol(matrix, index, matrixRow - (steps % matrixRow), matrixRow);   
                        break;
                    case "left":
                        moveRow(matrix, index, steps, matrixColumn);
                        break;
                    case "right":
                        moveRow(matrix, index, matrixColumn - (steps % matrixColumn), matrixColumn);
                        break;
                    default:
                        break;
                }

            }
            reArange(matrix, matrixRow, matrixColumn);
        }

        private static void moveCol(int [,] matrix, int col, int moves, int rows)
        {
            int[] newCols = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                newCols[i] = matrix[(moves + i) % rows, col];
            }
            for (int i = 0; i < rows; i++)
            {
                matrix[i, col] = newCols[i];
            }
        }
        private static void moveRow(int [,] matrix, int row, int moves, int cols)
        {
            int[] newRows = new int[cols];
            for (int i = 0; i < cols; i++)
            {
                newRows[i] = matrix[row, (i + moves) % cols];
            }
            for (int i = 0; i < cols; i++)
            {
                matrix[row, i] = newRows[i];
            }
        }
        private static void printMatrix(int [,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        private static void reArange(int [,] matrix, int rows, int cols)
        {
            int expected = 1;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row,col] != expected)
                    {
                        for (int row1 = 0; row1 < rows; row1++)
                        {
                            for (int col1 = 0; col1 < cols; col1++)
                            {
                                if (matrix[row1,col1] == expected)
                                {
                                    Console.WriteLine($"Swap ({row}, {col}) with ({row1}, {col1})");
                                    int temp = matrix[row1, col1];
                                    matrix[row1, col1] = matrix[row,col];
                                    matrix[row, col] = temp;

                                }
                              
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"No swap required");
                    }
                    expected++;
                }
               
            }
          
        }
        
    }
}
