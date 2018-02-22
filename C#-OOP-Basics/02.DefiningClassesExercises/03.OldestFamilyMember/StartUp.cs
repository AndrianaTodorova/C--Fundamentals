using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;

class StartUp
{
    static void Main()
    {
        int peopleCount = int.Parse(Console.ReadLine());
        
        Family family = new Family();
        for (int i = 0; i < peopleCount; i++)
        {
            string[] data = Console.ReadLine().Split(' ').ToArray();
            var member = new Person(data[0], int.Parse(data[1]));
            family.AddMember(member);
        }

        var oldestPerson = family.GetOldestMember();
        Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

    }
}
