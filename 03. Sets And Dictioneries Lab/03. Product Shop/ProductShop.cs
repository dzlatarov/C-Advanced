using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class ProductShop
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(',',StringSplitOptions.RemoveEmptyEntries);

                if(input[0] == "Revision")
                {
                    break;
                }

                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if(dict.ContainsKey(shop) == false)
                {
                    dict.Add(shop, new Dictionary<string, double>());
                    dict[shop].Add(product, price);
                }
                else
                {
                    dict[shop].Add(product, price);
                }
            }

            foreach (var shop in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product:{item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
