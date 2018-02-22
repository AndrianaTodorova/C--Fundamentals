using System;

namespace _15.DrawingTool
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "Square")
            {
                int size = int.Parse(Console.ReadLine());
                Square square = new Square(size);
                square.Draw();
            }
            else
            {
                int width = int.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle(width, height);
                rectangle.Draw();
            }
        }
    }
}
