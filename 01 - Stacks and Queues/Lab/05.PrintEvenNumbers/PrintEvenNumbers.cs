using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues
{
    public class PrintEvenNumbers
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    queue.Enqueue(numbers[i]);
                }
            }

            while (queue.Count > 1)
            {
                Console.Write(queue.Dequeue());
                Console.Write(", ");
            }

            if (queue.Peek() % 2 == 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}