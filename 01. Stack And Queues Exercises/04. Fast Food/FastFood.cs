using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class FastFood
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);
            int theBiggestOrder = queue.Max();

            while (queue.Any())
            {
                if (foodQuantity <= 0)
                {
                    break;
                }
                if (foodQuantity - queue.Peek() >= 0)
                {
                    foodQuantity -= queue.Dequeue();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(theBiggestOrder);

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}
