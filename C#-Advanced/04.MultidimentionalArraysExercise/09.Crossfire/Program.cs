using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.Crossfire
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int matrixRow = dimentions[0];
            int matrixCol = dimentions[1];
            string inputCommands = Console.ReadLine();
            int[,] matrix = new int[matrixRow, matrixCol];
            int start = 1;
            for (int row = 0; row < matrixRow; row++)
            {
                for (int col = 0; col < matrixCol; col++)
                {
                    matrix[row, col] = start;
                    start++;
                }
            }

            while (inputCommands != "Nuke it from orbit")
            {

                int[] commands = inputCommands.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int elementRow =commands[0];
                int elementCol = commands[1];
                int elementRadius = Math.Abs(commands[2]);

                if (elementRow < 0 || elementCol < 0)
                {
                    inputCommands = Console.ReadLine();
                    continue;
                }

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (IsInsideRadius(row, col, elementRow, elementCol, elementRadius))
                        {
                            matrix[row, col] = -1;
                        }
                    }
                }

                int r = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {

                    int c = 0;
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == -1)
                        {
                            continue;
                        }
                        matrix[r, c] = matrix[row, col];
                        if (c != col)
                        {
                            matrix[row, col] = -1;
                        }
                        c++;
                    }
                    r++;
                }


                inputCommands = Console.ReadLine();
            }
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != -1)
                    {
                        if (j < matrix.GetLength(1) - 1)
                        {
                            sb.Append(matrix[i, j] + " ");
                        }
                        else
                        {
                            sb.Append(matrix[i, j]);
                        }

                    }
                }
                sb.Append(Environment.NewLine);

            }

            Console.WriteLine(sb.ToString().Trim());
        }
        private static bool IsInsideRadius(int checkRow, int checkCol, int impactRow, int impactCol, int shotRadius)
        {

            bool killMe = (checkRow == impactRow && (checkCol >= impactCol - shotRadius && checkCol <= impactCol + shotRadius));
            bool killMeTwice = (checkCol == impactCol && (checkRow >= impactRow - shotRadius && checkRow <= impactRow + shotRadius));

            return killMe || killMeTwice;
        }
    }
}
