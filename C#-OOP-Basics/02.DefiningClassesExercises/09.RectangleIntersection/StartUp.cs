using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.RectangleIntersection
{
    class StartUp
    {
        static void Main()
        {
            string[] data = Console.ReadLine().Split(' ');
            int countRect = int.Parse(data[0]);
            int check = int.Parse(data[1]);
            List<Rectangle> list = new List<Rectangle>();

            for (int i = 0; i < countRect; i++)
            {
                string[] recData = Console.ReadLine().Split(' ');
                list.Add(new Rectangle(recData[0],double.Parse(recData[1]),double.Parse(recData[2]),double.Parse(recData[3]),double.Parse(recData[4])));
            }

            for (int i = 0; i < check; i++)
            {
                string[] print = Console.ReadLine().Split(' ');
                var firstRect = list.Where(x => x.Id == print[0]).FirstOrDefault();
                var secondRect = list.Where(x => x.Id == print[1]).FirstOrDefault();

                if (firstRect.RectangleIntersect(secondRect) == false)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }
            }
        }
    }
}
