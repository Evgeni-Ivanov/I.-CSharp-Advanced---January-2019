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
        .Problem05FashionBoutique
{
    public class FashionBoutique
    {
        public static void Main()
        {
            int[] sequenceOfClothes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(sequenceOfClothes);

            int numberOfRacks = 1;
            int currentRackCapacity = rackCapacity;

            while (clothes.Count > 0)
            {
                int peekCloth = clothes.Peek();

                if (currentRackCapacity >= peekCloth)
                {
                    int currentCloth = clothes.Pop();

                    currentRackCapacity -= currentCloth;
                }
                else
                {
                    currentRackCapacity = rackCapacity;
                    numberOfRacks++;
                }
            }

            Console.WriteLine(numberOfRacks);
        }
    }
}