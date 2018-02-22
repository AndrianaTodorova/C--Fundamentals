using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PokemonTrainers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();

            var list = new List<Trainer>();
            while (data != "Tournament")
            {
                string[] pokemonData = data.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string trainerName = pokemonData[0];
                string pokemonName = pokemonData[1];
                string pokemonElement = pokemonData[2];
                int pokemonHealth = int.Parse(pokemonData[3]);

                var trainer = list.FirstOrDefault(t => t.Name == trainerName);

                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                    list.Add(trainer);
                }
                trainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));

                data = Console.ReadLine();
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                list.Where(t => t.Pokemons.Any(p => p.Element == input))
                    .ToList()
                    .ForEach(t => t.Badge++);

                var aintMatch = list.Where(t => t.Pokemons.All(p => p.Element != input));

                foreach (var non in aintMatch)
                {
                    non.Pokemons.ForEach(p => p.Health -= 10);
                    non.Pokemons = non.Pokemons.Where(p => p.Health > 0)
                        .ToList();
                }
            }

            list.OrderByDescending(t => t.Badge).ToList().ForEach(t => Console.WriteLine(t.ToString()));
           

        }
    }
}

