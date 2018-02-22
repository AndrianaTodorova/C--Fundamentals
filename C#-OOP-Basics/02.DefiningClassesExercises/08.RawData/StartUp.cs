using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.RawData
{
    class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Queue<Car> cars = new Queue<Car>();
            for (int i = 0; i < count; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                var engine = new Engine(int.Parse(data[1]), int.Parse(data[2]));
                var cargo = new Cargo(int.Parse(data[3]), data[4]);
                var tires = new Tire[]
                {
                    new Tire(int.Parse(data[6]), double.Parse(data[7])),
                    new Tire(int.Parse(data[8]), double.Parse(data[7])),
                    new Tire(int.Parse(data[10]), double.Parse(data[9])),
                    new Tire(int.Parse(data[12]), double.Parse(data[11]))
                };
                cars.Enqueue(new Car(data[0],engine,cargo,tires));
            }

            string typeToPrint = Console.ReadLine();
            
                Console.WriteLine(string.Join(Environment.NewLine, cars.Where(c => c.Cargo.Type == typeToPrint && typeToPrint == "fragile"
                        ? c.Tires
                              .Where(t => t.Pressure < 1)
                              .FirstOrDefault() != null
                        : c.Engine.Power > 250)
                    .Select(c => c.Model)));
        }
    }
}
