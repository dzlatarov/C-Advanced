using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sizes = commands[0];
            int numbersToDequeue = commands[1];
            int numberToFind = commands[2];

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < sizes && i < numbers.Length; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < numbersToDequeue && queue.Count > 0; i++)
            {
                queue.Dequeue();
            }

            if(queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            else if(queue.Contains(numberToFind))
            {
                Console.WriteLine("true");
                return;
            }
            else
            {
                Console.WriteLine($"{queue.Min()}");
                return;
            }
        }
    }
}
