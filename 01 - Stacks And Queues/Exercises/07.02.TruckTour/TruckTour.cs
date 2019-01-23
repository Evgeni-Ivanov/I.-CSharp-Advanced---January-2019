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
        .Problem07v02TruckTour
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

            int indexOfStartPump = 0;

            while (true)
            {
                int totalFuel = 0;

                foreach (var currentPump in queueOfPumps)
                {
                    int amountOfPetrol = currentPump[0];
                    int distanceToNextPetrolPump = currentPump[1];

                    totalFuel += amountOfPetrol - distanceToNextPetrolPump;

                    if (totalFuel < 0)
                    {
                        int[] newStartingPump = queueOfPumps.Dequeue();
                        queueOfPumps.Enqueue(newStartingPump);
                        indexOfStartPump++;
                        break;
                    }
                }

                if (totalFuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(indexOfStartPump);
        }
    }
}