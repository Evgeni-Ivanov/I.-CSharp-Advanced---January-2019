using System;
using System.Collections.Generic;

namespace SoftUni
        .ProfessionalModules
        .CSharpWebDeveloper
        .CSharpFundamentals
        .CSharpFundamentalsJanuary2019
        .CSharpAdvancedJanuary2019
        .Lecture01StacksAndQueues
        .Exercises
        .Problem06AutoRepairAndService
{
    public class AutoRepairAndService
    {
        public static void Main()
        {
            string[] sequenceOfVehicles = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Queue<string> vehiclesForService = new Queue<string>(sequenceOfVehicles);
            Stack<string> servedVehicles = new Stack<string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(new char[] { '-' });

                if (command[0] == "End")
                {
                    break;
                }
                else if (command[0] == "Service")
                {
                    if (vehiclesForService.Count > 0)
                    {
                        string servedVehicle = vehiclesForService.Dequeue();

                        servedVehicles.Push(servedVehicle);

                        Console.WriteLine($"Vehicle {servedVehicle} got served.");
                    }
                }
                else if (command[0] == "CarInfo")
                {
                    if (vehiclesForService.Count > 0)
                    {
                        string vehicleToSearchFor = command[1];

                        if (vehiclesForService.Contains(vehicleToSearchFor))
                        {
                            Console.WriteLine("Still waiting for service.");
                        }
                        else
                        {
                            Console.WriteLine("Served.");
                        }
                    }
                }
                else
                // if (command[0] == "History")
                {
                    if (servedVehicles.Count > 0)
                    {
                        Console.WriteLine(string.Join(", ", servedVehicles));
                    }
                }
            }

            if (vehiclesForService.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", vehiclesForService)}");
            }

            if (servedVehicles.Count > 0)
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", servedVehicles)}");
            }
        }
    }
}