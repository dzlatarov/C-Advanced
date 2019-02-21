using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class CupsAndBottles
    {
        static void Main(string[] args)
        {
            int[] cupsValue = Console.ReadLine().Split().Reverse().Select(int.Parse).ToArray();
            int[] bottlesValue = Console.ReadLine().Split().Reverse().Select(int.Parse).ToArray();

            Stack<int> cups = new Stack<int>(cupsValue);
            Queue<int> bottles = new Queue<int>(bottlesValue);

            int wastedWater = 0;

            while (true)
            {
                if(cups.Count == 0 || bottles.Count == 0)
                {
                    break;
                }

                int currentBottle = bottles.Dequeue();
                int currentCup = cups.Pop();

                if (currentBottle >= currentCup)
                {
                    wastedWater += currentBottle - currentCup;                    
                }
                else if (currentCup > currentBottle)
                {                    
                    cups.Push(currentCup - currentBottle);                    
                }               
            }
            if (bottles.Count != 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");                
            }
            else if (cups.Count != 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");                
            }
        }
    }
}
