using System;
using System.Collections.Generic;
using System.Linq;

namespace MatrixShuffling
{
    class MatrixShuffling
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowsInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowsInput[col];
                }
            }

            string[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int firstRow = 0;
            int firstCol = 0;
            int secondRow = 0;
            int secondCol = 0;

            while (command[0]?.ToLower() != "end")
            {
                if (command.Length == 5)
                {
                    firstRow = int.Parse(command[1]);
                    firstCol = int.Parse(command[2]);
                    secondRow = int.Parse(command[3]);
                    secondCol = int.Parse(command[4]);
                }
                if (command[0]?.ToLower() != "swap" || command.Length != 5 || firstRow < 0 || firstRow > matrix.GetLength(0) - 1 || firstCol < 0 || firstCol > matrix.GetLength(1) - 1 || secondRow < 0 && secondRow > matrix.GetLength(0) - 1 || secondCol < 0 && secondCol > matrix.GetLength(1) - 1)
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    continue;                    
                }
                else
                {
                    string oldRowAndCol = matrix[firstRow, firstCol];
                    matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                    matrix[secondRow, secondCol] = oldRowAndCol;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write($"{matrix[row, col]} ");
                        }
                        Console.WriteLine();
                    }
                }
                command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
