using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class FashionBoutique
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int capacityOfRack = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothes);
            int newRack = 1;
            int sum = 0;

            while(stack.Count > 0)
            {
                if(sum + stack.Peek() <= capacityOfRack)
                {
                    sum += stack.Pop();
                }
                else
                {
                    sum = 0;
                    newRack++;
                }
            }
            Console.WriteLine(newRack);
        }
    }
}
