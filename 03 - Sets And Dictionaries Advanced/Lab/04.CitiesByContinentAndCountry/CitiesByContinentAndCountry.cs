using System;
using System.Collections.Generic;

namespace SoftUni
        .ProfessionalModules
        .CSharpWebDeveloper
        .CSharpFundamentals
        .CSharpFundamentalsJanuary2019
        .CSharpAdvancedJanuary2019
        .Lecture03SetsAndDictionariesAdvanced
        .Lab
        .Problem04CitiesByContinentAndCountry
{
    public class CitiesByContinentAndCountry
    {
        public static void Main()
        {
            int numberOfRecords = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> dictionary =
                new Dictionary<string, Dictionary<string, List<string>>>();

            for (int recordNumber = 0; recordNumber < numberOfRecords; recordNumber++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (dictionary.ContainsKey(continent) == false)
                {
                    dictionary.Add(continent, new Dictionary<string, List<string>>());
                }

                if (dictionary[continent].ContainsKey(country) == false)
                {
                    dictionary[continent].Add(country, new List<string>());
                }

                dictionary[continent][country].Add(city);
            }

            foreach (var currentContinent in dictionary)
            {
                Console.WriteLine($"{currentContinent.Key}:");

                foreach (var currentCountry in currentContinent.Value)
                {
                    Console.WriteLine($"  {currentCountry.Key} -> {string.Join(", ", currentCountry.Value)}");
                }
            }
        }
    }
}