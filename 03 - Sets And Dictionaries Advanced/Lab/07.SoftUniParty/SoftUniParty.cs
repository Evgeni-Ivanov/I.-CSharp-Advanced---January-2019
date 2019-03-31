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
        .Problem07SoftUniParty
{
    public class SoftUniParty
    {
        public static void Main()
        {
            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "PARTY")
                {
                    break;
                }

                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                if (char.IsDigit(input[0]))
                {
                    vipGuests.Remove(input);
                }
                else
                {
                    regularGuests.Remove(input);
                }
            }

            Console.WriteLine($"{vipGuests.Count + regularGuests.Count}");

            foreach (var vipGuest in vipGuests)
            {
                Console.WriteLine(vipGuest);
            }

            foreach (var regularGuest in regularGuests)
            {
                Console.WriteLine(regularGuest);
            }
        }
    }
}