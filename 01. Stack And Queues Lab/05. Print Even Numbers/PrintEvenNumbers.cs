using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class PrintEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(nums);
            Queue<int> evenNumbers = new Queue<int>();

            foreach (var item in queue)
            {
                if(item % 2 == 0)
                {
                    evenNumbers.Enqueue(item);
                }
            }
            Console.WriteLine(string.Join(", ",evenNumbers));
        }
    }
}
