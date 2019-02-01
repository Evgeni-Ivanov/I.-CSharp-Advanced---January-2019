using System;
using System.Collections.Generic;

namespace StacksAndQueues
{
    public class SimpleCalculator
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split();

            Stack<string> stack = new Stack<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }

            while (stack.Count > 1)
            {
                int firstOperand = int.Parse(stack.Pop());
                string operatorSign = stack.Pop();
                int secondOperand = int.Parse(stack.Pop());

                int result = 0;

                switch (operatorSign)
                {
                    case "+":
                        result = firstOperand + secondOperand;
                        break;

                    case "-":
                        result = firstOperand - secondOperand;
                        break;

                    default:
                        break;
                }

                stack.Push(result.ToString());
            }

            Console.WriteLine(stack.Pop());
        }
    }
}