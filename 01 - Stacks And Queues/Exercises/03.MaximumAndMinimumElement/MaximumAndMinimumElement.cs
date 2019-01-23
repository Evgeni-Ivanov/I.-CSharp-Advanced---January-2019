using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
        .ProfessionalModules
        .CSharpWebDeveloper
        .CSharpFundamentals
        .CSharpFundamentalsJanuary2019
        .CSharpAdvancedJanuary2019
        .Lecture01StacksAndQueues
        .Exercises
        .Problem03MaximumAndMinimumElement
{
    public class MaximumAndMinimumElement
    {
        public static void Main()
        {
            Stack<int> stackOfNumbers = new Stack<int>();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split();

                int command = int.Parse(commands[0]);

                if (command == 1)
                {
                    int numberToPush = int.Parse(commands[1]);

                    stackOfNumbers.Push(numberToPush);
                }
                else if (command == 2 && stackOfNumbers.Any())
                {
                    stackOfNumbers.Pop();
                }
                else if (command == 3 && stackOfNumbers.Any())
                {
                    int maximumElement = stackOfNumbers.Max();
                    Console.WriteLine(maximumElement);
                }
                else if (command == 4 && stackOfNumbers.Any())
                {
                    int minimumElement = stackOfNumbers.Min();
                    Console.WriteLine(minimumElement);
                }
            }

            Console.WriteLine(String.Join(", ", stackOfNumbers));
        }
    }
}