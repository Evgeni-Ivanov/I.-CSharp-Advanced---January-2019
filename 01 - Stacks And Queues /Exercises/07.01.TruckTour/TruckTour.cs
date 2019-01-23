using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
        .ProfessionalModules
        .CSharpWebDeveloper
        .CSharpFundamentals
        .CSharpFundamentalsJanuary2019
        .CSharpAdvancedJanuary2019
        .Lecture01StacksAndQueues
        .Exercises
        .Problem07v01TruckTour
{
    public class TruckTour
    {
        public static void Main()
        {
            int numberOfPumps = int.Parse(Console.ReadLine());

            Queue<int[]> queueOfPumps = new Queue<int[]>();

            for (int i = 0; i < numberOfPumps; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                queueOfPumps.Enqueue(input);
            }

            bool fullCircle = true;

            for (int i = 0; i < numberOfPumps; i++)
            {
                int totalFuel = 0;

                for (int j = 0; j < numberOfPumps; j++)
                {
                    int[] currentPump = queueOfPumps.Dequeue();

                    int amountOfPetrol = currentPump[0];
                    int distanceToNextPetrolPump = currentPump[1];

                    totalFuel += amountOfPetrol - distanceToNextPetrolPump;

                    if (totalFuel < 0)
                    {
                        fullCircle = false;
                    }

                    queueOfPumps.Enqueue(currentPump);
                }

                if (fullCircle == true)
                {
                    Console.WriteLine(i);
                    break;
                }

                int[] newStartingPump = queueOfPumps.Dequeue();
                queueOfPumps.Enqueue(newStartingPump);
                fullCircle = true;
            }
        }
    }
}