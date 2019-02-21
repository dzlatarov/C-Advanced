using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class TrafficJam
    {
        static void Main(string[] args)
        {
            int carsToPass = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            int passedCars = 0;


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    Console.WriteLine($"{passedCars} cars passed the crossroads.");
                    return;
                }
                else if (command == "green")
                {
                    int carsCount = cars.Count;
                    for (int i = 0; i < Math.Min(carsCount, carsToPass); i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        passedCars++;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }
        }
    }
}
