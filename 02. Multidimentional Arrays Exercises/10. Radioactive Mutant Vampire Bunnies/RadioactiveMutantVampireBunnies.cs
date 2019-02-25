using System;
using System.Collections.Generic;
using System.Linq;


class RadioactiveMutantVampireBunnies
{
    static void Main(string[] args)
    {
        var demensions = Console.ReadLine().Split();
        int rows = int.Parse(demensions[0]);
        int cols = int.Parse(demensions[1]);
        char[][] bunnyLair = new char[rows][];
        int playerRow = 0;
        int playerCol = 0;

        for (int i = 0; i < rows; i++)
        {
            bunnyLair[i] = Console.ReadLine().ToCharArray();

            if (bunnyLair[i].Contains('P'))
            {
                playerRow = i;
                playerCol = Array.IndexOf(bunnyLair[i], 'P');
                bunnyLair[playerRow][playerCol] = '.';
            }
        }
        string directions = Console.ReadLine();

        foreach (var direction in directions)
        {
            int oldPlayerRow = playerRow;
            int oldPlayerCol = playerCol;

            switch (direction)
            {
                case 'U': playerRow--; break;
                case 'D': playerRow++; break;
                case 'L': playerCol--; break;
                case 'R': playerCol++; break;                
            }

            bunnyLair = SpreadBunnies(bunnyLair, rows - 1, cols - 1);

            if(playerRow < 0 || playerRow >= rows ||
                playerCol < 0 || playerCol >= cols)
            {
                PrintResult(bunnyLair, oldPlayerRow, oldPlayerCol, "won");
                return;
            }

            if(bunnyLair[playerRow][playerCol] == 'B')
            {
                PrintResult(bunnyLair, playerRow, playerCol, "dead");
                return;
            }
        }
    }

    private static void PrintResult(char[][] bunnyLair, int oldPlayerRow, int oldPlayerCol, string outPut)
    {
        foreach (var item in bunnyLair)
        {
            Console.WriteLine(string.Join("",item));
        }
        Console.WriteLine($"{outPut}: {oldPlayerRow} {oldPlayerCol}");       
    }

    private static char[][] SpreadBunnies(char[][] matrix, int row, int col)
    {
        char[][] newLair = new char[matrix.Length][];
        for (int i = 0; i < matrix.Length; i++)
        {
            newLair[i] = (char[])matrix[i].Clone();
        }

        for (int i = 0; i <= row; i++)
        {
            for (int j = 0; j <= col; j++)
            {
                if(matrix[i][j] == 'B')
                {
                    if(i > 0)
                    {
                        newLair[i - 1][j] = 'B';
                    }

                    if(i < row)
                    {
                        newLair[i + 1][j] = 'B';
                    }

                    if(j > 0)
                    {
                        newLair[i][j - 1] = 'B';
                    }

                    if(j < col)
                    {
                        newLair[i][j + 1] = 'B';
                    }
                }
            }
        }
        return newLair;
    }
}

