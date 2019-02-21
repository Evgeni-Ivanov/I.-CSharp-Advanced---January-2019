using System;
using System.Collections.Generic;

namespace SoftUni
        .ProfessionalModules
        .CSharpWebDeveloper
        .CSharpFundamentals
        .CSharpFundamentalsJanuary2019
        .CSharpAdvancedJanuary2019
        .Lecture01StacksAndQueues
        .Lab
        .Problem06v01Supermarket
{
    public class Supermarket
    {
        public static void Main()
        {
            Queue<string> people = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                if (input == "Paid")
                {
                    foreach (var person in people)
                    {
                        Console.WriteLine(person);
                    }

                    people.Clear();
                }
                else
                {
                    people.Enqueue(input);
                }
            }

            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}