using System;
using System.Collections.Generic;

namespace StacksAndQueues
{
    public class TrafficJam
    {
        public static void Main()
        {
            // n - Number of cars that can pass during a green light
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Queue<string> carsInTraffic = new Queue<string>();

            int totalNumberOfPassedCars = 0;

            while (input != "end")
            {
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

                input = Console.ReadLine();
            }

            Console.WriteLine($"{totalNumberOfPassedCars} cars passed the crossroads.");
        }
    }
}