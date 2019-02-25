using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner
{
    class Miner
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();
            char[][] matrix = new char[size][];

            int playerRow = -1;
            int playerCol = -1;
            int coalLeft = 0;

            for (int row = 0; row < size; row++)
            {
                char[] input = Console.ReadLine().Replace(" ", "").ToCharArray();

                matrix[row] = input;

                if (matrix[row].Contains('s'))
                {
                    playerRow = row;
                    playerCol = Array.IndexOf(matrix[row], 's');
                    matrix[row][playerCol] = '*';
                }
                coalLeft += matrix[row].Where(x => x == 'c').Count();
            }

            
            foreach (var command in commands)
            {
                switch (command)
                {
                    case "up": playerRow = playerRow - 1 < 0 ? playerRow : playerRow - 1; break;
                    case "down": playerRow = playerRow + 1 >= size ? playerRow : playerRow + 1; break;
                    case "left": playerCol = playerCol - 1 < 0 ? playerCol : playerCol - 1; break;
                    case "right": playerCol = playerCol + 1 >= size ? playerCol : playerCol + 1; break;
                }

                if (matrix[playerRow][playerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({playerRow},{playerCol})");
                    return;
                }
                else if (matrix[playerRow][playerCol] == 'c')
                {
                    matrix[playerRow][playerCol] = '*';
                    coalLeft--;

                    if (coalLeft == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({playerRow},{playerCol})");
                        return;
                    }
                }
            }           
            Console.WriteLine($"{coalLeft} coals left. ({playerRow}, {playerCol})");
        }
    }
}
