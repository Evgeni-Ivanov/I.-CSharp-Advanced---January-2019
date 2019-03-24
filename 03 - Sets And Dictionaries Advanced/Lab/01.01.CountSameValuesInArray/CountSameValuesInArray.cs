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
        .Lab
        .Problem01v01CountSameValuesInArray
{
    public class CountSameValuesInArray
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> numberOfOccurrences = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numberOfOccurrences.ContainsKey(numbers[i]) == false)
                {
                    numberOfOccurrences.Add(numbers[i], 1);
                }
                else
                {
                    numberOfOccurrences[numbers[i]]++;
                }
            }

            foreach (var number in numberOfOccurrences)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}