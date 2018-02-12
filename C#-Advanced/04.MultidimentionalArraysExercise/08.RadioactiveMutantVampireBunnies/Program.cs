using System;
using System.Linq;

namespace _08.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];
            char[][] matrix = new char[rows][];
            int playerRow = 0;
            int playerCol = 0;
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
                if (matrix[i].Contains('P'))
                {
                    playerRow = i;
                    playerCol = Array.IndexOf(matrix[i], 'P');
                    matrix[playerRow][playerCol] = '.';
                }
            }
                        string commands = Console.ReadLine();
            foreach(char move in commands)
            {
                int oldPlayerRow = playerRow;
                int oldPlayerCol = playerCol;
                switch (move)
                {
                    case 'U':
                        playerRow--;
                        break;
                    case 'D':
                        playerRow++;
                        break;
                    case 'L':
                        playerCol--;
                        break;
                    case 'R':
                        playerCol++;
                        break;

                }
                matrix = SpreadingBunnies(matrix, rows - 1, cols - 1);
                //Print result

                if (playerRow < 0 || playerRow >= rows || playerCol < 0 || playerCol >= cols)
                {
                    foreach (var wonRow in matrix)
                    {
                        Console.WriteLine(string.Join("", wonRow));
                    }
                    Console.WriteLine($"won: {oldPlayerRow} {oldPlayerCol}");
                    return;
                }
                if (matrix[playerRow][playerCol] == 'B')
                {
                    foreach (var wonRow in matrix)
                    {
                        Console.WriteLine(string.Join("", wonRow));
                    }
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    return;
                }
            }
        }
        private static char[][] SpreadingBunnies(char[][] matrix, int rows, int cols)
        {
            var newLair = new char[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                newLair[i] = (char[])matrix[i].Clone();
            }
            for (int row = 0; row <= rows; row++)
            {
                for (int col = 0; col <= cols; col++)
                {
                    if (matrix[row][col] == 'B')
                    {
                        if (row > 0)
                        {
                            newLair[row - 1][col] = 'B';
                        }
                        if (row < rows)
                        {
                            newLair[row + 1][col] = 'B';
                        }
                        if (col > 0)
                        {
                            newLair[row][col - 1] = 'B';
                        }
                        if (col < cols)
                        {
                            newLair[row][col + 1] = 'B';
                        }
                    }
                   
                }
            }
           
            return newLair;
        }
      
    }
}
