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
        .Problem10Crossroads
{
    public class Crossroads
    {
        public static void Main()
        {
            int greenLightInSeconds = int.Parse(Console.ReadLine());
            int freeWindowInSeconds = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int totalPassedCars = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    int remainingSeconds = greenLightInSeconds;

                    while (remainingSeconds > 0 && cars.Count > 0)
                    {
                        string currentCar = cars.Peek();
                        int currentCarLength = currentCar.Length;

                        if (currentCarLength <= remainingSeconds)
                        {
                            cars.Dequeue();
                            remainingSeconds -= currentCarLength;
                            totalPassedCars++;
                        }
                        else if (currentCarLength <= remainingSeconds + freeWindowInSeconds)
                        {
                            cars.Dequeue();
                            remainingSeconds = 0;
                            totalPassedCars++;
                        }
                        else
                        {
                            int remainingTime = remainingSeconds + freeWindowInSeconds;

                            for (int i = 0; i < currentCarLength; i++)
                            {
                                remainingTime--;

                                if (remainingTime < 0)
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{currentCar} was hit at {currentCar[i]}.");
                                    return;
                                }
                            }
                        }
                    }

                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalPassedCars} total cars passed the crossroads.");
        }
    }
}