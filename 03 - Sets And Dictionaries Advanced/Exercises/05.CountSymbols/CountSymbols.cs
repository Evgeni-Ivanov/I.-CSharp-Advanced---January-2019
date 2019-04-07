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
        .Problem05CountSymbols
{
    public class CountSymbols
    {
        public static void Main()
        {
            char[] someText = Console.ReadLine().ToCharArray();

            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            for (int i = 0; i < someText.Length; i++)
            {
                char symbol = someText[i];

                if (symbols.ContainsKey(symbol) == false)
                {
                    symbols.Add(symbol, 0);
                }

                symbols[symbol]++;
            }

            foreach (var currentSymbol in symbols)
            {
                Console.WriteLine($"{currentSymbol.Key}: {currentSymbol.Value} time/s");
            }
        }
    }
}