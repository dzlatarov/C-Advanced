using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueUserNames
{
    class UniqueUserNames
    {
        static void Main(string[] args)
        {
            int usernamesCount = int.Parse(Console.ReadLine());

            HashSet<string> usernames = new HashSet<string>();

            for (int i = 0; i < usernamesCount; i++)
            {
                string input = Console.ReadLine();

                usernames.Add(input);
            }

            foreach (var names in usernames)
            {
                Console.WriteLine(names);
            }
        }
    }
}
