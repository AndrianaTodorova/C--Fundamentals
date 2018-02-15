using System;

namespace _02.PointInRectangle
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] pointData = Console.ReadLine().Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
            var rect = new Rectangle(new Point(int.Parse(pointData[0]), int.Parse(pointData[1])),
                new Point(int.Parse(pointData[2]), int.Parse(pointData[3])));
            int countPoint = int.Parse(Console.ReadLine());

            for (int i = 0; i < countPoint; i++)
            {
                string[] checkPoint = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var point = new Point(int.Parse(checkPoint[0]), int.Parse(checkPoint[1]));
                Console.WriteLine(rect.Contains(point));
            }
        }
    }
}
