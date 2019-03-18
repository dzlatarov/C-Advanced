using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var symbols = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!symbols.ContainsKey(text[i]))
                {
                    symbols.Add(text[i], 1);
                }
                else
                {
                    symbols[text[i]]++;
                }
            }

            foreach (var item in symbols.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
