using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            Stack<char> stackOfParentheses = new Stack<char>();

            string input = Console.ReadLine();

            char[] openParentheses = new char[] { '(', '[', '{' };
            bool isValid = true;

            for (int i = 0; i < input.Length; i++)
            {
                char currentBracket = input[i];

                if(openParentheses.Contains(currentBracket))
                {
                    stackOfParentheses.Push(currentBracket);
                    continue;
                }

                if(stackOfParentheses.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if(stackOfParentheses.Peek() == '(' && currentBracket == ')')
                {
                    stackOfParentheses.Pop();
                }
                else if(stackOfParentheses.Peek() == '{' && currentBracket == '}')
                {
                    stackOfParentheses.Pop();
                }
                else if(stackOfParentheses.Peek() == '[' && currentBracket == ']')
                {
                    stackOfParentheses.Pop();
                }
            }
            if(stackOfParentheses.Count == 0 && isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
