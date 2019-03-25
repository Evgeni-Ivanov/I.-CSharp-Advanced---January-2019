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
        .Problem01v02CountSameValuesInArray
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

            foreach (var number in numbers)
            {
                if (numberOfOccurrences.ContainsKey(number) == false)
                {
                    numberOfOccurrences.Add(number, 1);
                }
                else
                {
                    numberOfOccurrences[number]++;
                }
            }

            foreach (var item in numberOfOccurrences)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}