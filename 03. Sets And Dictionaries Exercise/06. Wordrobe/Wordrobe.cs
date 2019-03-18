using System;
using System.Collections.Generic;
using System.Linq;

namespace Wordrobe
{
    class Wordrobe
    {
        static void Main(string[] args)
        {
            var wordrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());           

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string[] clothes = input[1].Split(',');

                foreach (var item in clothes)
                {
                    if (!wordrobe.ContainsKey(color))
                    {
                        wordrobe.Add(color, new Dictionary<string, int>());
                        wordrobe[color].Add(item, 1);
                    }
                    else
                    {
                        if (wordrobe[color].ContainsKey(item) == false)
                        {
                            wordrobe[color].Add(item, 1);
                        }
                        else
                        {
                            wordrobe[color][item]++;
                        }
                    }
                }
            }
            string[] colorAndItem = Console.ReadLine().Split();

            string colorToFind = colorAndItem[0];
            string clothToFind = colorAndItem[1];

            foreach (var item in wordrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var clo in item.Value)
                {
                    if (item.Key == colorToFind && clo.Key == clothToFind)
                    {
                        Console.WriteLine($"* {clo.Key} - {clo.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clo.Key} - {clo.Value}");

                    }
                }
            }
        }
    }
}
