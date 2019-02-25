using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeMoves
{
    class SnakeMoves
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[][] matrix = new char[sizes[0]][];

            var snakeStr = Console.ReadLine().ToCharArray();

            Queue<char> snakeQueue = new Queue<char>(snakeStr);

            for (int row = 0; row < sizes[0]; row++)
            {
                matrix[row] = new char[sizes[1]];
                for (int col = 0; col < sizes[1]; col++)
                {
                    char charToAdd = snakeQueue.Dequeue();
                    matrix[row][col] = charToAdd;
                    snakeQueue.Enqueue(charToAdd);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(r => string.Join("",r))));
        }
    }
}
