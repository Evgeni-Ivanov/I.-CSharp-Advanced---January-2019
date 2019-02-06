using System;
using System.Collections.Generic;

namespace StacksAndQueues
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