
namespace Socks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Socks
    {
        public static void Main(string[] args)
        {
            int[] leftSocks = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] rightSocks = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Reverse().Select(int.Parse).ToArray();

            Stack<int> left = new Stack<int>(leftSocks);
            Stack<int> right = new Stack<int>(rightSocks);

            List<int> pairs = new List<int>();

            while(left.Any() && right.Any())
            {
                int leftSock = left.Peek();
                int rightSock = right.Peek();

                if (leftSock == rightSock)
                {
                    right.Pop();
                    left.Pop();
                    left.Push(leftSock + 1);
                }
                else if(rightSock > leftSock)
                {
                    left.Pop();
                    right.Pop();
                    right.Push(rightSock);
                }
                else if(leftSock > rightSock)
                {
                    left.Pop();
                    right.Pop();
                    pairs.Add(leftSock + rightSock);
                }
            }

            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(" ",pairs));
        }
    }
}
