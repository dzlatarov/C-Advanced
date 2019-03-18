using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class ParkingLot
    {
        static void Main(string[] args)
        {
            var carInfo = new HashSet<string>();
            
            while(true)
            {
                string[] input = Console.ReadLine().Split(',',StringSplitOptions.RemoveEmptyEntries);

                if(input[0] == "END")
                {
                    break;
                }

                string direction = input[0];
                string carNumber = input[1];

                if(direction == "IN")
                {
                    carInfo.Add(carNumber);
                }
                else if(direction == "OUT")
                {
                    carInfo.Remove(carNumber);
                }
            }

            if(carInfo.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in carInfo)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
