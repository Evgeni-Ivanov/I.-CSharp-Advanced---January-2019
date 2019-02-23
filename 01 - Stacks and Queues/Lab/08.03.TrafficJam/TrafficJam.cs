using System;
using System.Collections.Generic;

namespace SoftUni
        .ProfessionalModules
        .CSharpWebDeveloper
        .CSharpFundamentals
        .CSharpFundamentalsJanuary2019
        .CSharpAdvancedJanuary2019
        .Lecture01StacksAndQueues
        .Lab
        .Problem08v03TrafficJam
{
    public class TrafficJam
    {
        public static void Main()
        {
            // n - Number of cars that can pass during a green light
            int n = int.Parse(Console.ReadLine());

            string input = string.Empty;

            Queue<string> carsInTraffic = new Queue<string>();

            int totalNumberOfPassedCars = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    int passedCars = Math.Min(n, carsInTraffic.Count);

                    for (int i = 0; i < passedCars; i++)
                    {
                        string carThatPassed = carsInTraffic.Dequeue();
                        Console.WriteLine($"{carThatPassed} passed!");

                        totalNumberOfPassedCars++;
                    }
                }
                else
                {
                    carsInTraffic.Enqueue(input);
                }
            }

            Console.WriteLine($"{totalNumberOfPassedCars} cars passed the crossroads.");
        }
    }
}