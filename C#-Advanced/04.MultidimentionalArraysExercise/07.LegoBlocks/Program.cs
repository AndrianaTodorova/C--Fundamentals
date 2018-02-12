using System;
using System.Linq;
using System.Text;

namespace _07.LegoBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfJaggedRows = int.Parse(Console.ReadLine());
            long[][] firstJagged = new long[numberOfJaggedRows][];
            long[][] secondJagged = new long[numberOfJaggedRows][];
            redingJaggedArrays(firstJagged, secondJagged);

            bool isEqual = false;
            int currentLength = firstJagged[0].Length + secondJagged[0].Length;
            int sum = currentLength;
            for (int i = 1; i < firstJagged.Length; i++)
            {
                if (firstJagged[i].Length + secondJagged[i].Length == currentLength)
                {
                    isEqual = true;

                }
                else
                {
                    isEqual = false;
                    break;
                }
            }

            if (!isEqual)
            {
                for (int i = 1; i < firstJagged.Length; i++)
                {
                    sum += firstJagged[i].Length + secondJagged[i].Length;
                }
                Console.WriteLine($"The total number of cells is: {sum}");
            }
            else
            {
                for (int i = 0; i < firstJagged.Length; i++)
                {
                    string a = string.Join(", ", firstJagged[i]);
                    string b = string.Join(", ", secondJagged[i]);
                    string result = a + ", " + b;
                    Console.WriteLine($"[{result}]");
                }
            }

        }
        private static void redingJaggedArrays(long[][] firstJagged, long[][] secondJagged)
        {
            // reading the first jagged array
            for (int i = 0; i < firstJagged.Length; i++)
            {
                string[] inputNumbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                firstJagged[i] = new long[inputNumbers.Length];
                for (int j = 0; j < firstJagged[i].Length; j++)
                {
                    firstJagged[i][j] = long.Parse(inputNumbers[j]);
                }
            }
            //reading the second jagged array
            for (int i = 0; i < secondJagged.Length; i++)
            {
                string[] inputNumbers = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
                
                secondJagged[i] = new long[inputNumbers.Length];
                for (int j = 0; j < secondJagged[i].Length; j++)
                {
                    secondJagged[i][j] = long.Parse(inputNumbers[j]);
                }
            }

        }
    
    }
}
