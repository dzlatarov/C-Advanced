using System;
using System.Collections.Generic;
using System.Linq;

namespace CitiesByContinentAndCountry
{
    class CitiesByContinentAndCountry
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, string>>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if(!dict.ContainsKey(continent))
                {
                    dict.Add(continent, new Dictionary<string, string>());
                    dict[continent].Add(country, city);
                }
                else
                {
                    if(dict[continent].ContainsKey(country))
                    {
                        dict[continent][country] = dict[continent][country] + ", " + city;
                    }
                    else
                    {
                        dict[continent].Add(country, city);
                    }
                }
            }

            foreach (var cont in dict)
            {
                Console.WriteLine($"{cont.Key}:");
                foreach (var item in cont.Value)
                {
                    Console.WriteLine($"  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
