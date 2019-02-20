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
        .Lab
        .Problem03v02SimpleCalculator
{
    public class SimpleCalculator
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                int firstOperand = int.Parse(stack.Pop());
                string operatorSign = stack.Pop();
                int secondOperand = int.Parse(stack.Pop());

                if (operatorSign == "+")
                {
                    int result = firstOperand + secondOperand;
                    stack.Push(result.ToString());
                }
                else
                {
                    int result = firstOperand - secondOperand;
                    stack.Push(result.ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}