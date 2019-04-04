using System;
using System.Collections.Generic;

namespace SoftUni
        .ProfessionalModules
        .CSharpWebDeveloper
        .CSharpFundamentals
        .CSharpFundamentalsJanuary2019
        .CSharpAdvancedJanuary2019
        .Lecture03SetsAndDictionariesAdvanced
        .Exercises
        .Problem03PeriodicTable
{
    public class PeriodicTable
    {
        public static void Main()
        {
            int linesOfChemicalCompoundsCount = int.Parse(Console.ReadLine());

            SortedSet<string> chemicalCompounds = new SortedSet<string>();

            for (int currentLine = 0; currentLine < linesOfChemicalCompoundsCount; currentLine++)
            {
                string[] elements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int currentElement = 0; currentElement < elements.Length; currentElement++)
                {
                    chemicalCompounds.Add(elements[currentElement]);
                }
            }

            foreach (var currentChemicalCompound in chemicalCompounds)
            {
                Console.Write($"{string.Join(' ', currentChemicalCompound)} ");
            }
        }
    }
}