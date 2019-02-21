using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>();
            int sizes = commands[0];
            int numbersToPop = commands[1];
            int numberToFind = commands[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < sizes && i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < numbersToPop && stack.Count > 0; i++)
            {
                stack.Pop();
            }

            if(stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if(stack.Contains(numberToFind))
            {
                Console.WriteLine("true");
                return;
            }
            else
            {
                Console.WriteLine($"{stack.Min()}");
                return;
            }
        }
    }
}
