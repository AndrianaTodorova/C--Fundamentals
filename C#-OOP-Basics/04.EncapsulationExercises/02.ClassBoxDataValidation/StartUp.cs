using System;

namespace _02.ClassBoxDataValidation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                var box = new Box(length, width, height);
                Console.WriteLine(box.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                
            }
            
        }
    }
}
