using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] arr = new int[4,4];
            //for (int row = 0; row < 4; row++)
            //{
            //    int counter = 1 + row;
            //    for (int col = 0; col < 4; col++)
            //    {
            //        arr[row, col] = counter;
            //        counter += 4;
            //    }
            //}

            //for (int row = 0; row < arr.GetLength(0); row++)
            //{
            //    for (int col = 0; col < arr.GetLength(1); col++)
            //    {
            //        Console.Write($"{arr[row,col]} ");
            //    }

            //    Console.WriteLine();
            //}


            
            int rowsAndColsSize = int.Parse(Console.ReadLine());
            char pattern = (char)Console.Read();

            int[,] matrix = new int[rowsAndColsSize, rowsAndColsSize];
            int currentNumber = 1;
            if (Char.ToUpper(pattern).Equals('A'))
            {
                for (int col = 0; col < rowsAndColsSize; col++)
                {
                    for (int row = 0; row < rowsAndColsSize; row++)
                    {
                        matrix[row, col] = currentNumber;
                        currentNumber++;
                    }
                }
            }
            else if (Char.ToUpper(pattern).Equals('B'))
            {
                for (int col = 0; col < rowsAndColsSize; col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < rowsAndColsSize; row++)
                        {
                            matrix[row, col] = currentNumber;
                            currentNumber++;
                        }
                    }
                    else
                    {
                        for (int row = rowsAndColsSize - 1; row >= 0; row--)
                        {
                            matrix[row, col] = currentNumber;
                            currentNumber++;
                        }
                    }
                }
            }

            for (int row = 0; row < rowsAndColsSize; row++)
            {
                for (int col = 0; col < rowsAndColsSize; col++)
                {
                    Console.Write("{0,2} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
