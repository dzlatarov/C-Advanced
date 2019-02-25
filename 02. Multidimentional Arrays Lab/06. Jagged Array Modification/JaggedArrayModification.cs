using System;
using System.Collections.Generic;
using System.Linq;

namespace JaggedArrayModification
{
    class JaggedArrayModification
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[size][];

            for (int row = 0; row < size; row++)
            {
                int[] currentColumn = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                jaggedArray[row] = currentColumn;
            }

            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

            while(input[0]?.ToLower() != "end")
            {
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if(row < 0 || row > jaggedArray.Length - 1 ||
                    col < 0 || col > jaggedArray[row].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    continue;                    
                }
               
                switch(input[0]?.ToLower())
                {
                    case "add":
                        jaggedArray[row][col] += value;
                        break;
                    case "subtract":
                        jaggedArray[row][col] -= value;
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(string.Join(" ",item));
            }
        }
    }
}
