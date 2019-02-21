using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRepairTheService
{
    class AutoRepairTheService
    {
        static void Main(string[] args)
        {            
            string[] carsModels = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            Stack<string> servedVechicles = new Stack<string>();
            Queue<string> vechicles = new Queue<string>(carsModels);
            

            while(true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    if (vechicles.Count != 0)
                    {
                        Console.WriteLine($"Vehicles for service: {string.Join(", ", vechicles)}");
                    }
                    Console.WriteLine($"Served vehicles: {string.Join(", ", servedVechicles)}");
                    return;
                }

                if (command == "Service")
                {
                    if(vechicles.Count != 0)
                    {
                        string served = vechicles.Dequeue();
                        Console.WriteLine($"Vehicle {served} got served.");
                        servedVechicles.Push(served);
                    }                                      
                }
                else if(command == "History")
                {
                    Console.WriteLine(string.Join(", ",servedVechicles));
                }
                else
                {
                    string[] tokens = command.Split('-').ToArray();
                    string model = tokens[1];

                    if(vechicles.Contains(model))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }                
            }
        }
    }
}
