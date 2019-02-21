using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class HotPotato
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();

            Queue<string> queue = new Queue<string>(children);

            int number = int.Parse(Console.ReadLine());
            int counter = 1;

            while(queue.Count > 1)
            {
                var currentChildren = queue.Dequeue();

                if (counter % number != 0)
                {
                    queue.Enqueue(currentChildren);
                }
                else
                {
                    Console.WriteLine($"Removed {currentChildren}");
                }
                counter++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
