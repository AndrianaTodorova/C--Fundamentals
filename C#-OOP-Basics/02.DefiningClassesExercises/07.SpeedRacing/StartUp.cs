using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07.SpeedRacing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int countCar = int.Parse(Console.ReadLine());
            Queue<Car> queue = new Queue<Car>(); 
            for (int i = 0; i < countCar; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
               queue.Enqueue(new Car(data[0], double.Parse(data[1]), double.Parse(data[2])));
            }

            var driveCar = Console.ReadLine().Split();
            while (driveCar[0] != "End")
            {
                var currentCar = queue.Where(c => c.Model == driveCar[1]).FirstOrDefault();
                if (currentCar != null)
                {
                    currentCar.Drive(double.Parse(driveCar[2]));
                }
                driveCar = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(Environment.NewLine, queue.Select(m => $"{m.Model} {m.FuelAmount:f2} {m.Distance}")));
        }
    }
}
