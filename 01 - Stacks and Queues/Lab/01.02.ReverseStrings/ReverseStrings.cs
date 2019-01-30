using System;
using System.Collections.Generic;

namespace StacksAndQueues
{
    public class ReverseStrings
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            for (int i = stack.Count - 1; i >= 0; i--)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}