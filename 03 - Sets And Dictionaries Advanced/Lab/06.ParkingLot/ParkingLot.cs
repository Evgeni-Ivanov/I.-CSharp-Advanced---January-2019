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
        .Problem06ParkingLot
{
    public class ParkingLot
    {
        public static void Main()
        {
            HashSet<string> carNumbers = new HashSet<string>();

            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                string command = input[0];
                string carNumber = input[1];

                if (input[0] == "IN")
                {
                    carNumbers.Add(carNumber);
                }
                else
                {
                    carNumbers.Remove(carNumber);
                }

                input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (carNumbers.Count > 0)
            {
                foreach (var currentCarNumber in carNumbers)
                {
                    Console.WriteLine(currentCarNumber);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}