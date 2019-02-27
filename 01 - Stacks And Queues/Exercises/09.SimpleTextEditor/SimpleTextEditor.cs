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
        .Problem09SimpleTextEditor
{
    public class SimpleTextEditor
    {
        public static void Main()
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            string text = "";

            Stack<string> textVersions = new Stack<string>();
            textVersions.Push(text);

            for (int currentOperation = 0; currentOperation < numberOfOperations; currentOperation++)
            {
                string[] operation = Console.ReadLine()
                    .Split();

                string command = operation[0];

                if (command == "1")
                {
                    string textToAppend = operation[1];
                    text += textToAppend;
                    textVersions.Push(text);
                }
                else if (command == "2")
                {
                    int numberOfElementsToErase = int.Parse(operation[1]);
                    text = text.Substring(0, text.Length - numberOfElementsToErase);
                    textVersions.Push(text);
                }
                else if (command == "3")
                {
                    int indexOfElement = int.Parse(operation[1]);
                    Console.WriteLine(text[indexOfElement - 1]);
                }
                else if (command == "4")
                {
                    if (textVersions.Count >= 2)
                    {
                        textVersions.Pop();
                        text = textVersions.Peek();
                    }
                }
            }
        }
    }
}