using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int row = 0; row < size; row++)
            {
                int[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];

                    if(row == col)
                    {
                        primaryDiagonalSum += input[col];
                    }

                    if (col == ((size - 1) - row))
                    {
                        secondaryDiagonalSum += input[col];
                    }
                }
            }
            int totalSum = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);

            Console.WriteLine(totalSum);
        }
    }
}
