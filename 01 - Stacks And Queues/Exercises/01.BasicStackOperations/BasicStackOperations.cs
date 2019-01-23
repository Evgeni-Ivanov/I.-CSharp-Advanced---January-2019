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
        .Problem01BasicStackOperations
{
    public class BasicStackOperations
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split();

            int numberOfElementsToPush = int.Parse(input[0]);
            int numberOfElementsToPop = int.Parse(input[1]);
            int elementToLookFor = int.Parse(input[2]);

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackOfNumbers = new Stack<int>();

            for (int i = 0; i < numberOfElementsToPush; i++)
            {
                if (i < numbers.Length)
                {
                    stackOfNumbers.Push(numbers[i]);
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < numberOfElementsToPop; i++)
            {
                if (stackOfNumbers.Count > 0)
                {
                    stackOfNumbers.Pop();
                }
                else
                {
                    break;
                }
            }

            if (stackOfNumbers.Contains(elementToLookFor))
            {
                Console.WriteLine("true");
            }
            else if (stackOfNumbers.Count > 0)
            {
                int smallestElement = stackOfNumbers.Min();

                Console.WriteLine(smallestElement);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}