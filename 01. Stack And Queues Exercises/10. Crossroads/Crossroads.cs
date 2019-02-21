using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Crossroads
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());


            Queue<string> cars = new Queue<string>();
            int passedCars = 0;

            while(true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                if(input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    if(cars.Any())
                    {
                        int currentDuration = greenLight;

                        while(currentDuration > 0)
                        {
                            string currentCar = cars.Peek();

                            if (currentCar.Length <= currentDuration)
                            {
                                passedCars++;
                                currentDuration -= cars.Dequeue().Length;

                                if(cars.Count == 0)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                currentCar = currentCar.Substring(currentDuration, currentCar.Length - currentDuration);
                                if(currentCar.Length <= freeWindow)
                                {
                                    cars.Dequeue();
                                    passedCars++;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{cars.Dequeue()} was hit at {currentCar[freeWindow]}.");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}
