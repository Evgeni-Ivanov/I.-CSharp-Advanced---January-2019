using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
        .ProfessionalModules
        .CSharpWebDeveloper
        .CSharpFundamentals
        .CSharpFundamentalsJanuary2019
        .CSharpAdvancedJanuary2019
        .Lecture03SetsAndDictionariesAdvanced
        .Exercises
        .Problem02v01SetsOfElements
{
    public class SetsOfElements
    {
        public static void Main()
        {
            int[] setsLengths = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstSetLength = setsLengths[0];
            int secondSetLength = setsLengths[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetLength; i++)
            {
                int number = int.Parse(Console.ReadLine());

                firstSet.Add(number);
            }

            for (int i = 0; i < secondSetLength; i++)
            {
                int number = int.Parse(Console.ReadLine());

                secondSet.Add(number);
            }

            HashSet<int> thirdSet = new HashSet<int>();

            foreach (var currentNumber in firstSet)
            {
                if (secondSet.Contains(currentNumber))
                {
                    thirdSet.Add(currentNumber);
                }
            }

            foreach (var currentNumber in thirdSet)
            {
                Console.Write($"{currentNumber} ");
            }
        }
    }
}