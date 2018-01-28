using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SumMatrixElements
{
    public class Program
    {
        static int[][] matrix;
        static void Main(string[] args)
        {
            int[] dimmensions = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //int[,] matrix = new int[dimmensions[0], dimmensions[1]];
            matrix = new int[dimmensions[0]][];

            for (int i = 0; i < dimmensions[0]; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    string[] arguments = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //    //if arguments length is equals to matrix.GetLength(1), you can use it instead arguments array
            //    for (int j = 0; j < arguments.Length; j++)
            //    {
            //        matrix[i, j] = int.Parse(arguments[j]);
            //    }
            //}

            Console.WriteLine(dimmensions[0]);
            Console.WriteLine(dimmensions[1]);
            //long sumOfElements = 0;
            long sumOfElements =  matrix.Select(arr => arr.Sum()).Sum();
            //foreach (int[] item in matrix)
            //{
            //    sumOfElements += item.Sum();
            //}
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        sumOfElements += matrix[row, col];
            //    }
            //}

            Console.WriteLine(sumOfElements);
        }
    }
}
