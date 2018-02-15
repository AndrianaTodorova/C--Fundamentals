using System;

namespace _01.RhombusOfStars
{
    class StartUp
    {
        static void Main()
        {
            
            
            int rhombusSize = int.Parse(Console.ReadLine());
            for (int starSize = 1; starSize <= rhombusSize; starSize++)
            {
                PrintRow(rhombusSize, starSize);
            }

            for (int starSize = rhombusSize - 1; starSize >= 1; starSize--)
            {
                PrintRow(rhombusSize, starSize);
            }
        }
        public static void PrintRow(int rhombusSize, int starSize)
        {
            for (int i = 0; i <= rhombusSize - starSize; i++)
            {
                Console.Write(" ");
            }

            for (int col = 1; col < starSize; col++)
            {
                Console.Write("* ");
            }

            Console.WriteLine("*");
        }
    }
}
