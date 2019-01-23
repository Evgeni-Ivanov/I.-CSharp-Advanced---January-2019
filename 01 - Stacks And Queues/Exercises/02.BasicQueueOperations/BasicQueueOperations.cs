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
        .Problem02BasicQueueOperations
{
    public class BasicQueueOperations
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split();

            int numberOfElementsToEnqueue = int.Parse(input[0]);
            int numberOfElementsToDequeue = int.Parse(input[1]);
            int elementToLookFor = int.Parse(input[2]);

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queueOfNumbers = new Queue<int>();

            for (int i = 0; i < numberOfElementsToEnqueue; i++)
            {
                if (i < numbers.Length)
                {
                    queueOfNumbers.Enqueue(numbers[i]);
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < numberOfElementsToDequeue; i++)
            {
                if (queueOfNumbers.Count > 0)
                {
                    queueOfNumbers.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queueOfNumbers.Contains(elementToLookFor))
            {
                Console.WriteLine("true");
            }
            else if (queueOfNumbers.Count > 0)
            {
                int smallestElement = queueOfNumbers.Min();

                Console.WriteLine(smallestElement);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}