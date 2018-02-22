using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.CatLady
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var hierarchy = new Hierarchy(new List<Cymric>(),new List<Siamese>(),new List<StreetExtraordinaire>());
            while (input != "End")
            {
                string[] catData = input.Split(' ');
               
                string typeCat = catData[0];
                switch (typeCat)
                {
                    case "Cymric":
                        var cymric = new Cymric(catData[1],double.Parse(catData[2]));
                        hierarchy.Cymric.Add(cymric);
                        break;
                    case "Siamese":
                        var siamese = new Siamese(catData[1], catData[2]);
                        hierarchy.Siamese.Add(siamese);
                        break;
                    case "StreetExtraordinaire":
                        var street = new StreetExtraordinaire(catData[1], catData[2]);
                        hierarchy.Street.Add(street);
                        break;
                }

                input = Console.ReadLine();
            }

            string catName = Console.ReadLine();
            if (hierarchy.Siamese.Any(n => n.Name == catName))
            {
                string ear ="";
                foreach (var i in hierarchy.Siamese)
                {
                    if (i.Name == catName)
                    {
                        ear = i.EarSize;
                    }
                }
                Console.WriteLine("Siamese " + catName + $" {ear}");
            }
            else if (hierarchy.Street.Any(n => n.Name == catName))
            {
                string decibel = "";
                foreach (var i in hierarchy.Street)
                {
                    if (i.Name == catName)
                    {
                        decibel = i.Decibels;
                    }
                }
                Console.WriteLine("StreetExtraordinaire " + catName + $" {decibel}");
            }
            else
            {
                double fur = 0;
                foreach (var i in hierarchy.Cymric)
                {
                    if (i.Name == catName)
                    {
                        fur = i.FurLength;
                    }
                }
                Console.WriteLine("Cymric " + catName + $" {fur:f2}");
            }
        }
    }
}
