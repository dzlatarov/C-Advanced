using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Ranking
    {
        static void Main(string[] args)
        {
            var contestAndPasswords = new Dictionary<string, string>();
            var usernameAndPoints = new Dictionary<string, Dictionary<string,int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of contests")
                {
                    break;
                }

                string[] tokens = input.Split(':', StringSplitOptions.RemoveEmptyEntries);

                string contest = tokens[0];
                string password = tokens[1];

                if (!contestAndPasswords.ContainsKey(contest))
                {
                    contestAndPasswords.Add(contest, password);
                }
            }

            while (true)
            {
                string secondInput = Console.ReadLine();
                if (secondInput == "end of submissions")
                {
                    break;
                }

                string[] tokens = secondInput.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contestAndPasswords.ContainsKey(contest) && contestAndPasswords[contest].Contains(password))
                {
                    if (!usernameAndPoints.ContainsKey(username))
                    {
                        usernameAndPoints.Add(username, new Dictionary<string, int>());
                        usernameAndPoints[username].Add(contest, points);
                    }
                    if(usernameAndPoints[username].ContainsKey(contest))
                    {
                        if(usernameAndPoints[username][contest] < points)
                        {
                            usernameAndPoints[username][contest] = points;
                        }
                    }
                    else
                    {
                        usernameAndPoints[username].Add(contest, points);
                    }
                }
            }
            var bestCandidate = new Dictionary<string, int>();

            foreach (var item in usernameAndPoints)
            {
                bestCandidate[item.Key] = item.Value.Values.Sum();
            }
            string bestName = bestCandidate
                .Keys
                .Max();
            int bestPoints = bestCandidate
                .Values
                .Max();

            foreach (var kvp in bestCandidate)
            {
                if(kvp.Value == bestPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");
                }
            }
            Console.WriteLine("Ranking:");

            foreach (var kvp in usernameAndPoints.OrderBy(x => x.Key))
            {
                string username = kvp.Key;
                Console.WriteLine(username);
                foreach (var cont in kvp.Value.OrderByDescending(x => x.Value))
                {
                    string contest = cont.Key;
                    int point = cont.Value;
                    Console.WriteLine($"#  {contest} -> {point}");
                }
            }
        }
    }
}
