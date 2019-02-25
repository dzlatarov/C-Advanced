using System;
using System.Collections.Generic;
using System.Linq;

namespace SymbolInMatrix
{
    class SymbolInMatrix
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                char[] array = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = array[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool isFound = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(matrix[row,col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        return;
                    }                      
                }
            }
            if (isFound == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");                              
            }
        }        
    }
}
