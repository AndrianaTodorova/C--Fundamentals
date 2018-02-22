using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        int countPeople = int.Parse(Console.ReadLine());
        var people = new HashSet<Person>();
        for (int i = 0; i < countPeople; i++)
        {
            string[] data = Console.ReadLine().Split(' ').ToArray();
            people.Add(new Person(data[0], int.Parse(data[1])));
        }
        PrintPeopleOlderThan30(people);
    }
    private static void PrintPeopleOlderThan30(HashSet<Person> people)
    {
        Console.WriteLine(string.Join(Environment.NewLine, people
            .Where(p => p.Age > 30)
            .OrderBy(p => p.Name)
            .Select(p => $"{p.Name} - {p.Age}")));
    }

}
