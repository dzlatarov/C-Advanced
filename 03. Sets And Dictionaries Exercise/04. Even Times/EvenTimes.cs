using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class EvenTimes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var evenNumbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());


                if (!evenNumbers.ContainsKey(input))
                {
                    evenNumbers.Add(input, 1);
                }
                else
                {
                    evenNumbers[input]++;
                }

            }

            foreach (var item in evenNumbers)
            {
                if(item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
