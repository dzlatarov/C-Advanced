using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class StackSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            
            string commandInfo = Console.ReadLine().ToLower();
            while(commandInfo != "end")
            {
                string[] tokens = commandInfo.Split();
                string command = tokens[0].ToLower();
               
                if(command == "add")
                {
                    int firstNumberToBeAdd = int.Parse(tokens[1]);
                    int secondNumberToBeAdd = int.Parse(tokens[2]);

                    stack.Push(firstNumberToBeAdd);
                    stack.Push(secondNumberToBeAdd);
                }
                else if(command == "remove")
                {
                    int numsToRemove = int.Parse(tokens[1]);

                    if(stack.Count > numsToRemove)
                    {
                        for (int i = 0; i < numsToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }                                      
                }
                commandInfo = Console.ReadLine().ToLower();
            }
            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
