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
        .Problem06Wardrobe
{
    public class Wardrobe
    {
        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe =
                new Dictionary<string, Dictionary<string, int>>();

            for (int line = 0; line < numberOfLines; line++)
            {
                string[] currentLine = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = currentLine[0];

                if (wardrobe.ContainsKey(color) == false)
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                string[] clothes = currentLine[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < clothes.Length; i++)
                {
                    string clothItem = clothes[i];

                    if (wardrobe[color].ContainsKey(clothItem) == false)
                    {
                        wardrobe[color].Add(clothItem, 0);
                    }

                    wardrobe[color][clothItem]++;
                }
            }

            string[] clothToFind = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string clothToFindColor = clothToFind[0];
            string clothToFindType = clothToFind[1];


            foreach (var currentColor in wardrobe)
            {
                Console.WriteLine($"{currentColor.Key} clothes:");

                foreach (var currentCloth in currentColor.Value)
                {
                    if (currentColor.Key == clothToFindColor && currentCloth.Key == clothToFindType)
                    {
                        Console.WriteLine($"* {currentCloth.Key} - {currentCloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {currentCloth.Key} - {currentCloth.Value}");
                    }
                }
            }
        }
    }
}