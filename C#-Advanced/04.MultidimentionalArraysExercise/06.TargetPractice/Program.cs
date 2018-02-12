using System;
using System.Linq;

namespace _06.TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            string snake = Console.ReadLine();
            int[] shotParameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int elementRow = shotParameters[0];
            int elementCol = shotParameters[1];
            int elementRadius = shotParameters[2];
            char[][] matrix = new char[rows][];

            FillMatrix(snake, matrix, cols);
            FireShot(matrix, elementRow, elementCol, elementRadius);
            SwapDown(matrix);
            PrintMatrix(matrix);
          
        }
        private static void FillMatrix(string snake, char[][] matrix, int matrixWidth)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new char[matrixWidth];
            }

            bool isMovingLeft = true;
            int currentSymbolIndex = 0;

            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                int col = isMovingLeft ? matrixWidth - 1 : 0;
                int colUpdate = isMovingLeft ? -1 : 1;

                while (0 <= col && col < matrixWidth)
                {
                    if (currentSymbolIndex >= snake.Length)
                    {
                        currentSymbolIndex = 0;
                    }

                    matrix[row][col] = snake[currentSymbolIndex];

                    currentSymbolIndex++;
                    col += colUpdate;
                }

                isMovingLeft = !isMovingLeft;
            }
        }
        private static void FireShot(char[][] matrix, int elementRow, int elementCol, int elementRadius)
        {
            int matrixWidth = matrix[0].Length;

            for (int r = 0; r < matrix.Length; r++)
            {
                for (int c = 0; c < matrixWidth; c++)
                {
                    if (isInside(r,c,elementRow,elementCol,elementRadius))
                    {
                        matrix[r][c] = ' ';
                    }
                }
            }
           
        }
        private static bool isInside(int currentRow, int currentCol, int elementRow, int elementCol, int elementRadius)
        {
            int deltaRow = currentRow - elementRow;
            int deltaCol = currentCol - elementCol;
            bool insideRadius = deltaRow * deltaRow + deltaCol * deltaCol <= elementRadius * elementRadius;

            return insideRadius;
        }
        private static void SwapDown(char[][] matrix)
        {
            int width = matrix[0].Length;

            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                for (int col = 0; col < width; col++)
                {
                    if (matrix[row][col] != ' ')
                    {
                        continue;
                    }
                    int currentRow = row - 1;
                    while (currentRow >= 0)
                    {
                        if (matrix[currentRow][col] != ' ')
                        {
                            matrix[row][col] = matrix[currentRow][col];
                            matrix[currentRow][col] = ' ';
                            break;
                        }
                        currentRow--;
                    }
                }
            }
        }
        private static void PrintMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[0].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
