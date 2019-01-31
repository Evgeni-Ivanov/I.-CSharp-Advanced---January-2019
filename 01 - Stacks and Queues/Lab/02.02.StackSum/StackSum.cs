using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues
{
    public class StackSum
    {
        public static void Main()
        {
            int[] numbersArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackOfNumbers = new Stack<int>(numbersArray);

            while (true)
            {
                string line = Console.ReadLine().ToLower();

                if (line == "end")
                {
                    break;
                }

                string[] lineParts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = lineParts[0];
                int firstNumber = int.Parse(lineParts[1]);

                if (command == "add")
                {
                    int secondNumber = int.Parse(lineParts[2]);

                    stackOfNumbers.Push(firstNumber);
                    stackOfNumbers.Push(secondNumber);
                }
                else
                {
                    if (stackOfNumbers.Count < firstNumber)
                    {
                        continue;
                    }

                    for (int i = 0; i < firstNumber; i++)
                    {
                        stackOfNumbers.Pop();
                    }
                }
            }

            Console.WriteLine($"Sum: {stackOfNumbers.Sum()}");
        }
    }
}