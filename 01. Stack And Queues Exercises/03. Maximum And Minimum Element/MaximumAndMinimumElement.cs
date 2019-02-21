using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class MaximumAndMinimumElement
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();
            maxNumbers.Push(int.MinValue);
            Stack<int> minNumbers = new Stack<int>();
            minNumbers.Push(int.MaxValue);

            for (int i = 0; i < queries; i++)
            {
                int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (commands[0] == 1)
                {
                    stack.Push(commands[1]);

                    if (stack.Peek() > maxNumbers.Peek())
                    {
                        maxNumbers.Push(commands[1]);
                    }
                    if (stack.Peek() < minNumbers.Peek())
                    {
                        minNumbers.Push(commands[1]);
                    }
                }
                else if (commands[0] == 2)
                {
                    if(stack.Count > 0)
                    {
                        if (stack.Pop() == maxNumbers.Peek())
                        {
                            maxNumbers.Pop();
                        }
                        else if (stack.Pop() == minNumbers.Peek())
                        {
                            minNumbers.Pop();
                        }
                    }                    
                }
                else if (commands[0] == 3)
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
                else if (commands[0] == 4)
                {
                    Console.WriteLine(minNumbers.Peek());
                }
            }
            if (stack.Count > 0)
            {
                Console.WriteLine(string.Join(", ", stack));
            }
        }
    }
}
