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
        .Problem12CupsAndBottles
{
    public class CupsAndBottles
    {
        public static void Main()
        {
            int[] cups = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] bottles = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> cupsStack = new Stack<int>(cups.Reverse());
            Stack<int> bottlesStack = new Stack<int>(bottles);

            int totalWastedWater = 0;

            while (cupsStack.Count > 0 && bottlesStack.Count > 0)
            {
                int currentBottle = bottlesStack.Peek();
                int currentCup = cupsStack.Peek();
                int currentWastedWater = 0;

                if (currentBottle >= currentCup)
                {
                    bottlesStack.Pop();
                    cupsStack.Pop();

                    currentWastedWater = currentBottle - currentCup;
                    totalWastedWater += currentWastedWater;
                }
                else
                {
                    currentCup -= currentBottle;
                    bottlesStack.Pop();
                    cupsStack.Pop();

                    cupsStack.Push(currentCup);
                }
            }

            if (bottlesStack.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(' ', bottlesStack)}");
                Console.WriteLine($"Wasted litters of water: {totalWastedWater}");
            }
            else if (cupsStack.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(' ', cupsStack)}");
                Console.WriteLine($"Wasted litters of water: {totalWastedWater}");
            }
        }
    }
}