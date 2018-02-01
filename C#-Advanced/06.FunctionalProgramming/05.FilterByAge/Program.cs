using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>(peopleCount);
            for (int i = 0; i < peopleCount; i++)
            {
                var nameAndAge = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                people.Add(nameAndAge[0], int.Parse(nameAndAge[1]));
            }
            var condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();
            var filter = GetFilter(condition, age);
            var print = CreatePrinter(format);
            foreach (var person in people)
            {
                if (filter(person))
                {
                    print(person);
                }
               
            }

        }
        static Func<KeyValuePair<string, int>, bool> GetFilter(string condition, int age)
        {
            if (condition == "younger")
            {
                return x => x.Value < age;
            }
            else
            {
                return x => x.Value >= age;
            }
        }
        static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return x => Console.WriteLine(x.Key);
                case "age":
                    return x => Console.WriteLine(x.Value);
                case "name age":
                    return x => Console.WriteLine($"{x.Key} - {x.Value}");
                default:
                    return x => Console.WriteLine("Invalid");
                    

            }
        }
    }
}
