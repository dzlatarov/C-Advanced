using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class CountSameValuesInArray
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var dict = new Dictionary<double, int>();

            foreach (var nums in numbers)
            {
                if(dict.ContainsKey(nums) == false)
                {
                    dict.Add(nums, 1);
                }
                else
                {
                    dict[nums]++;
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
