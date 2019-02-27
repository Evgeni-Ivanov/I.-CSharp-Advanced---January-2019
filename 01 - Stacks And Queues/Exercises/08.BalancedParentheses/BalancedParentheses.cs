using System;
using System.Collections.Generic;

namespace SoftUni
        .ProfessionalModules
        .CSharpWebDeveloper
        .CSharpFundamentals
        .CSharpFundamentalsJanuary2019
        .CSharpAdvancedJanuary2019
        .Lecture01StacksAndQueues
        .Exercises
        .Problem08BalancedParentheses
{
    public class BalancedParentheses
    {
        public static void Main()
        {
            char[] input = Console.ReadLine()
                .ToCharArray();

            Stack<char> parentheses = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    parentheses.Push(input[i]);
                }
                else
                {
                    if (parentheses.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    if (input[i] == ')')
                    {
                        char lastParenthesis = parentheses.Pop();

                        if (lastParenthesis != '(')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else if (input[i] == ']')
                    {
                        char lastParenthesis = parentheses.Pop();

                        if (lastParenthesis != '[')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else if (input[i] == '}')
                    {
                        char lastParenthesis = parentheses.Pop();

                        if (lastParenthesis != '{')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                }
            }

            if (parentheses.Count == 0)
            {
                Console.WriteLine("YES");
            }
        }
    }
}