using System;
using System.Linq;

namespace _03.JediGalaxy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] dimestions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int row = dimestions[0];
            int col = dimestions[1];

            int[,] matrix = new int[row, col];

            int valueMatrix = 0;
            for (int matrixRow = 0; matrixRow < row; matrixRow++)
            {
                for (int matrixCol = 0; matrixCol < col; matrixCol++)
                {
                    matrix[matrixRow, matrixCol] = valueMatrix++;
                }
            }

            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] ivoPosition = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int[] evilPosition = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int evilRow = evilPosition[0];
                int evilCol = evilPosition[1];
                MoveEvil(evilRow,evilCol,matrix);
              
                int ivoRow = ivoPosition[0];
                int ivoCol = ivoPosition[1];

                while (ivoRow >= 0 && ivoCol < matrix.GetLength(1))
                {
                    if (ivoRow >= 0 && ivoRow < matrix.GetLength(0) && ivoCol >= 0 && ivoCol < matrix.GetLength(1))
                    {
                        sum += matrix[ivoRow, ivoCol];
                    }

                    ivoCol++;
                    ivoRow--;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }

        public static void MoveEvil(int evilRow, int evilCol, int[,] matrix)
        {
            while (evilRow >= 0 && evilCol >= 0)
            {
                if (evilRow >= 0 && evilRow < matrix.GetLength(0) && evilCol >= 0 && evilCol < matrix.GetLength(1))
                {
                    matrix[evilRow, evilCol] = 0;
                }
                evilRow--;
                evilCol--;
            }
        }
    }
}
