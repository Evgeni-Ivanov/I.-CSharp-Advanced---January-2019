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

            Stack<int> stackOfNumbers = new Stack<int>();

            for (int i = 0; i < numbersArray.Length; i++)
            {
                stackOfNumbers.Push(numbersArray[i]);
            }

            while (true)
            {
                string[] line = Console.ReadLine()
                    .ToLower()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (line[0] == "end")
                {
                    break;
                }

                string command = line[0];
                int firstNumber = int.Parse(line[1]);

                if (command == "add")
                {
                    int secondNumber = int.Parse(line[2]);

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