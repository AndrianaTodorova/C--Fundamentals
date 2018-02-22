using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.CarSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int countEngines = int.Parse(Console.ReadLine());
            var engine = new Stack<Engine>();
            for (int i = 0; i < countEngines; i++)
            {
                string[] engines = Console.ReadLine().Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries);
                engine.Push( new Engine(engines[0],int.Parse(engines[1])));
                if (engines.Length > 2)
                {
                    int displacement;
                    var isdigit = int.TryParse(engines[2], out displacement);

                    if (isdigit)
                    {
                        engine.Peek().Displacement = displacement;
                    }
                    else
                    {
                        engine.Peek().Efficiency = engines[2];
                    }

                    if (engines.Length > 3)
                    {
                        if (isdigit)
                        {
                            engine.Peek().Efficiency = engines[3];
                        }
                        else
                        {
                            engine.Peek().Displacement = int.Parse(engines[3]);
                        }
                    }
                }
            }

            int countCars = int.Parse(Console.ReadLine());
            var car = new Queue<Car>();
            for (int i = 0; i < countCars; i++)
            {
                string[] cars = Console.ReadLine().Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries);
                var currentCar = new Car(cars[0],engine.Where(e => e.Model == cars[1]).FirstOrDefault());
                if (cars.Length > 2)
                {
                    int weight;
                    var isDigit = int.TryParse(cars[2], out weight);

                    if (isDigit)
                    {
                        currentCar.Weight = weight;
                    }
                    else
                    {
                        currentCar.Color = cars[2];
                    }

                    if (cars.Length > 3)
                    {
                        if (isDigit)
                        {
                            currentCar.Color = cars[3];
                        }
                        else
                        {
                            currentCar.Weight = int.Parse(cars[3]);
                        }
                    }
                }
                car.Enqueue(currentCar);
            }

            foreach (var c in car)
            {
                Console.Write(c.ToString());
            }
        }
    }
}
