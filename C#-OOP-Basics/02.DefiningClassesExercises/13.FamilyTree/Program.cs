using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.FamilyTree
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataPerson = Console.ReadLine();
            var allPeople = new List<Person>();
            var person = new Person();
            var parent = new Parents();
            var child = new Children();
            if (dataPerson.Contains("/"))
            {
                person.BirthDay = dataPerson;
            }
            else
            {
                person.Name = dataPerson;
            }

            string personFamily = Console.ReadLine();
            while (personFamily != "End")
            {
                string[] split = personFamily.Split(new[] {" - "}, StringSplitOptions.RemoveEmptyEntries);
                if (split.Length > 1)
                {
                    var childToken = split[1];
                    var parentToken = split[0];
                    if (parentToken.Contains("/"))
                    {
                        parent.BirthDay = parentToken;
                    }
                    else
                    {
                        parent.Name = parentToken;
                    }

                    if (childToken.Contains("/"))
                    {
                        child.BirthDay = childToken;
                    }
                    else
                    {
                        child.Name = childToken;
                    }

                   
                }


                personFamily = Console.ReadLine();
            }
        }
    }
}
