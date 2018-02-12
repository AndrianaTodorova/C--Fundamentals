using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ParkingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int cols = dimentions[1];
            Dictionary<int, HashSet<int>> parking = new Dictionary<int, HashSet<int>>();
            string input = Console.ReadLine();
            int count = 0;
            while (input != "stop")
            {
                int[] integersLine = input.Split(' ').Select(int.Parse).ToArray();
                int carRow = integersLine[0];
                int desiredRow = integersLine[1];
                int desiredCol = integersLine[2];

                int parkingColumn = 0;
                if (!isParked(parking,desiredRow,desiredCol))
                {
                    parkingColumn = desiredCol;
                }
                else
                {
                    for (int i = 0; i < cols - 1; i++)
                    {
                        if (desiredCol - i > 0 && !isParked(parking,desiredRow,desiredCol - i))
                        {
                            parkingColumn = desiredCol - i;
                            break;
                        }
                        else if (desiredCol + i < cols && !isParked(parking,desiredRow,desiredCol + i))
                        {
                            parkingColumn = desiredCol + i;
                            break;
                        }
                    }
                }
                if (parkingColumn == 0)
                {
                    Console.WriteLine($"Row {desiredRow} full");
                }
                else
                {
                    parking[desiredRow].Add(parkingColumn);
                    int steps = Math.Abs(carRow - desiredRow) + 1 + parkingColumn;
                    Console.WriteLine(steps);
                }
               
                input = Console.ReadLine();
            }
       
        }
        private static bool isParked(Dictionary<int, HashSet<int>> parking, int row, int col)
        {
            if (parking.ContainsKey(row))
            {
                if (parking[row].Contains(col))
                {
                    return true;
                }
            }
            else
            {
                parking.Add(row, new HashSet<int>());
            }
            return false;
        }
    }
}
