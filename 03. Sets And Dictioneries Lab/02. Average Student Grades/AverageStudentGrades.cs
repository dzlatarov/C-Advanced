using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            
            var studentsGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string student = input[0];
                double grade = double.Parse(input[1]);

                if(studentsGrades.ContainsKey(student) == false)
                {
                    studentsGrades.Add(student, new List<double>());
                    studentsGrades[student].Add(grade);
                }
                else
                {
                    studentsGrades[student].Add(grade);
                }
            }

            foreach (var item in studentsGrades)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var grades in item.Value)
                {
                    Console.Write($"{grades:f2} ");
                }
                    Console.WriteLine($"(avg: {item.Value.Average():f2})");
            }
        }
    }
}
