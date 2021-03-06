﻿using System;
using System.Collections.Generic;

namespace SoftUni
        .ProfessionalModules
        .CSharpWebDeveloper
        .CSharpFundamentals
        .CSharpFundamentalsJanuary2019
        .CSharpAdvancedJanuary2019
        .Lecture01StacksAndQueues
        .Lab
        .Problem04MatchingBrackets
{
    public class MatchingBrackets
    {
        public static void Main()
        {
            string expression = Console.ReadLine();

            Stack<int> openingBracketsIndexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openingBracketsIndexes.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int substringStartIndex = openingBracketsIndexes.Pop();
                    int substringLength = i - substringStartIndex + 1;
                    string result = expression.Substring(substringStartIndex, substringLength);

                    Console.WriteLine(result);
                }
            }
        }
    }
}