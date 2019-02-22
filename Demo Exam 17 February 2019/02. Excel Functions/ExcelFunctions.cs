namespace ExcelFunctions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExcelFunctions
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[][] matrix = new string[size][];
            var headerInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            matrix[0] = headerInput;

            for (int i = 1; i < size; i++)
            {
                var innerInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                matrix[i] = innerInput;
            }

            var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var colIndex = Array.IndexOf(matrix[0], commands[1]);

            if (commands[0] == "hide")
            {
                Console.WriteLine(string.Join(" | ", matrix[0].Where(x => x != commands[1])));

                for (int i = 1; i < matrix.Length; i++)
                {
                    Console.WriteLine(string.Join(" | ", matrix[i].Where((x, y) => y != colIndex)));
                }
            }
            else if (commands[0] == "sort")
            {
                Console.WriteLine(string.Join(" | ", matrix[0]));

                foreach (var item in matrix.OrderBy(x => x[colIndex]))
                {
                    if (!item.Contains(commands[1]))
                    {
                        Console.WriteLine(string.Join(" | ", item));
                    }
                }
            }
            else if(commands[0] == "filter")
            {
                var value = commands[2];

                Console.WriteLine(string.Join(" | ",matrix[0]));

                for (int i = 1; i < matrix.Length; i++)
                {
                    if(matrix[i][colIndex] == value)
                    {
                        Console.WriteLine(string.Join(" | ",matrix[i]));
                    }
                }
            }
        }
    }
}