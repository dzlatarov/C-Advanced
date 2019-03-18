using System;
using System.Collections.Generic;
using System.Linq;

namespace RecordUniqueNames
{
    class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                names.Add(input);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
