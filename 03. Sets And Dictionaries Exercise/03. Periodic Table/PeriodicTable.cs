using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> uniqueSet = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in input)
                {
                    uniqueSet.Add(item);
                }
            }

            foreach (var element in uniqueSet.OrderBy(x => x))
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
