using System;
using System.Linq;
using System.Text;

namespace _01.MatrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] rowsAndCols = Console.ReadLine().Split(' ').ToArray();
            int rows = int.Parse(rowsAndCols[0]);
            int cols = int.Parse(rowsAndCols[1]);
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            string[,] matrixToPrint = new string [rows,cols];
            for (int matrixRow = 0; matrixRow < matrixToPrint.GetLength(0); matrixRow++)
            {
                for (int matrixCol = 0; matrixCol < matrixToPrint.GetLength(1); matrixCol++)
                {
                    StringBuilder reminder = new StringBuilder();
                    reminder.Append(alphabet[matrixRow]);
                    reminder.Append(alphabet[matrixRow + matrixCol]);
                    reminder.Append(alphabet[matrixRow]);
                    matrixToPrint[matrixRow,matrixCol] = reminder.ToString();
                }
            }
         
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <cols; j++)
                {
                    Console.Write(matrixToPrint[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
