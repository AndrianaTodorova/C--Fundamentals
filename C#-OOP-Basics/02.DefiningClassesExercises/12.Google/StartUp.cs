using System;
using System.Collections.Generic;

namespace _12.Google
{
    class StartUp
    {
        static void Main()
        {
            string command = Console.ReadLine();
            var person = new Dictionary<string, Person>();
            while (command != "End")
            {
                string[] personData = command.Split(' ');
                string personName = personData[0];
                if (!person.ContainsKey(personName))
                {
                    person.Add(personName, new Person(personName));
                }
                string data = personData[1];
                switch (data)
                {
                    case "company":
                        var company = new Company(personData[2], personData[3], decimal.Parse(personData[4]));
                        person[personName].Company = company;
                        break;
                    case "car":
                        var car = new Car(personData[2], double.Parse(personData[3]));
                        person[personName].Car = car;
                        break;
                    case "pokemon":
                        var pokemon = new Pokemons(personData[2], personData[3]);
                        person[personName].Pokemons.Add(pokemon);
                        break;
                    case "parents":
                        var parents = new Parents(personData[2], personData[3]);
                        person[personName].Parents.Add(parents);
                        break;
                    case "children":
                        var children = new Children(personData[2], personData[3]);
                        person[personName].Children.Add(children);
                        break;
                }

                command = Console.ReadLine();
            }

            string nameData = Console.ReadLine();

            Console.Write(person[nameData].ToString());
        }
    }
}
