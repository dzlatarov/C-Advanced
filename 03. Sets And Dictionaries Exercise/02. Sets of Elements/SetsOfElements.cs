using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class SetsOfElements
    {
        static void Main(string[] args)
        {
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            List<int> result = new List<int>();


            int[] length = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = length[0];
            int m = length[1];

            for (int i = 0; i < n; i++)
            {
                int firstInput = int.Parse(Console.ReadLine());

                firstSet.Add(firstInput);
            }
            for (int i = 0; i < m; i++)
            {
                int secondInput = int.Parse(Console.ReadLine());

                secondSet.Add(secondInput);
            }

            foreach (var element in firstSet)
            {
                if(secondSet.Contains(element))
                {
                    result.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
