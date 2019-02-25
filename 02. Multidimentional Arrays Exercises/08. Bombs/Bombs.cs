using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Bombs
    {
        static int[][] matrix;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            matrix = new int[size][];

            for (int row = 0; row < size; row++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                matrix[row] = input;
            }
            string[] bombs = Console.ReadLine()
                .Split();
            foreach (var item in bombs)
            {
                int[] coordinates = item.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int row = coordinates[0];
                int col = coordinates[1];

                int damage = matrix[row][col];

                if (damage > 0)
                {
                    BombCells(row,col - 1, damage);
                    BombCells(row, col + 1, damage);
                    BombCells(row + 1, col, damage);
                    BombCells(row - 1, col, damage);
                    BombCells(row + 1, col + 1, damage);
                    BombCells(row + 1, col - 1, damage);
                    BombCells(row - 1, col - 1, damage);
                    BombCells(row - 1, col + 1, damage);
                    matrix[row][col] = 0;
                }
            }
            int aliveCells = 0;
            int sum = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                int[] alive = matrix[row]
                    .Where(x => x > 0)
                    .ToArray();
                aliveCells += alive.Length;
                sum += alive.Sum();
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ",item));
            }
        }

        private static void BombCells(int row, int col, int damage)
        {
            if(row >= 0 && row < matrix.Length && col >= 0 && col < matrix.Length && matrix[row][col] > 0)
            {
                matrix[row][col] -= damage;
            }
        }
    }
}
