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
        .Problem03ProductShop
{
    public class ProductShop
    {
        public static void Main()
        {
            SortedDictionary<string, Dictionary<string, double>> shopsDictionary =
                new SortedDictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Revision")
            {
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (shopsDictionary.ContainsKey(shop) == false)
                {
                    shopsDictionary.Add(shop, new Dictionary<string, double>());

                    if (shopsDictionary[shop].ContainsKey(product) == false)
                    {
                        shopsDictionary[shop].Add(product, price);
                    }
                }
                else
                {
                    shopsDictionary[shop].Add(product, price);
                }

                input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var currentShop in shopsDictionary)
            {
                Console.WriteLine($"{currentShop.Key}->");

                foreach (var currentProduct in currentShop.Value)
                {
                    Console.WriteLine($"Product: {currentProduct.Key}, Price: {currentProduct.Value}");
                }
            }
        }
    }
}