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
        .Problem08v01TrafficJam
{
    public class TrafficJam
    {
        public static void Main()
        {
            // n - Number of cars that can pass during a green light
            int n = int.Parse(Console.ReadLine());

            Queue<string> carsInTraffic = new Queue<string>();

            int totalNumberOfPassedCars = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                if (input == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (carsInTraffic.Count > 0)
                        {
                            string carThatPassed = carsInTraffic.Dequeue();
                            Console.WriteLine($"{carThatPassed} passed!");

                            totalNumberOfPassedCars++;
                        }
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