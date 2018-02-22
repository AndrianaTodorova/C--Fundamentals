using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Hospital
{
    class StartUp

    {
        static void Main()
        {
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
            Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();


            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] data = command.Split();
                var departament = data[0];
                var firstName = data[1];
                var secondName = data[2];
                var patient = data[3];
                var fullName = firstName + secondName;

                if (!doctors.ContainsKey(fullName))
                {
                    doctors[fullName] = new List<string>();
                }
                if (!departments.ContainsKey(departament))
                {
                    departments[departament] = new List<List<string>>();
                    for (int rooms = 0; rooms < 20; rooms++)
                    {
                        departments[departament].Add(new List<string>());
                    }
                }

                bool isMoreSpace = departments[departament].SelectMany(x => x).Count() < 60;
                if (isMoreSpace)
                {
                    int room = 0;
                    doctors[fullName].Add(patient);
                    for (int roomCount = 0; roomCount < departments[departament].Count; roomCount++)
                    {
                        if (departments[departament][roomCount].Count < 3)
                        {
                            room = roomCount;
                            break;
                        }
                    }
                    departments[departament][room].Add(patient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();

                if (args.Length == 1)
                {
                    Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int room))
                {
                    Console.WriteLine(string.Join("\n", departments[args[0]][room - 1].OrderBy(x => x)));
                }
                else
                {
                    Console.WriteLine(string.Join("\n", doctors[args[0] + args[1]].OrderBy(x => x)));
                }
                command = Console.ReadLine();
            }
        }
    }
}
