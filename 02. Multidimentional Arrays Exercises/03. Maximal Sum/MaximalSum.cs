using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            long[] sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            long[,] matrix = new long[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                long[] rowsInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowsInput[col];
                }
            }
            long maxSum = long.MinValue;
            long rowIndex = 0;
            long colIndex = 0;

            for (long row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (long col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2,col] + matrix[row + 2,col +1] + matrix[row + 2,col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (long row = rowIndex; row < rowIndex + 3; row++)
            {
                for (long col = colIndex; col < colIndex + 3; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
