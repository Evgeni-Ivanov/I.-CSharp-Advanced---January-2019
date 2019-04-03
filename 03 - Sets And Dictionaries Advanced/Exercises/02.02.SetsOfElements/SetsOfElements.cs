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
        .Problem02v02SetsOfElements
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

            firstSet.IntersectWith(secondSet);
            Console.WriteLine($"{string.Join(' ', firstSet)}");

            // Or:
            // Console.WriteLine($"{string.Join(' ', firstSet.Intersect(secondSet))}");
        }
    }
}