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
        .Problem06v02Supermarket
{
    public class Supermarket
    {
        public static void Main()
        {
            Queue<string> people = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "End":
                        Console.WriteLine($"{people.Count} people remaining.");
                        return;

                    case "Paid":
                        int n = people.Count;
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine(people.Dequeue());
                        }
                        break;

                    default:
                        people.Enqueue(input);
                        break;
                }
            }
        }
    }
}