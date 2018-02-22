using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.GreedyTimes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            string[] safe = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var itemsData = new Dictionary<string, Dictionary<string, long>>();
           
            for (int i = 0; i < safe.Length; i += 2)
            {
                string name = safe[i];
                long count = long.Parse(safe[i + 1]);

                string type = string.Empty;

                if (name.Length == 3)
                {
                    type = "Cash";
                }
                else if (name.ToLower().EndsWith("gem"))
                {
                    type = "Gem";
                }
                else if (name.ToLower() == "gold")
                {
                    type = "Gold";
                }

                if (type == "")
                {
                    continue;
                }
                if (input < itemsData.Values.Select(x => x.Values.Sum()).Sum() + count)
                {
                    continue;
                }

                switch (type)
                {
                    case "Gem":
                        if (!itemsData.ContainsKey(type))
                        {
                            if (itemsData.ContainsKey("Gold"))
                            {
                                if (count > itemsData["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (itemsData[type].Values.Sum() + count > itemsData["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!itemsData.ContainsKey(type))
                        {
                            if (itemsData.ContainsKey("Gem"))
                            {
                                if (count > itemsData["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (itemsData[type].Values.Sum() + count > itemsData["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!itemsData.ContainsKey(type))
                {
                    itemsData[type] = new Dictionary<string, long>();
                }

                if (!itemsData[type].ContainsKey(name))
                {
                    itemsData[type][name] = 0;
                }
                long gold = 0;
                long gem = 0;
                long cash = 0;

                itemsData[type][name] += count;
                if (type == "Gold")
                {
                    gold += count;
                }
                else if (type == "Gem")
                {
                    gem += count;
                }
                else if (type == "Cash")
                {
                    cash += count;
                }
            }

            foreach (var x in itemsData)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }

        public static void FindName()
        {

        }
    }
}
