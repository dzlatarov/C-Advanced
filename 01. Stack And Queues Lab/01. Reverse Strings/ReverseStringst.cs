using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseStrings
{
    class ReverseStrings
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Stack<string> stack = new Stack<string>(text.Length);

            for (int i = 0; i < text.Length; i++)
            {
                stack.Push(text[i].ToString());              
            }

            foreach (var item in stack)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
