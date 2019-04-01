using System;
using System.Collections.Generic;

namespace SoftUni
        .ProfessionalModules
        .CSharpWebDeveloper
        .CSharpFundamentals
        .CSharpFundamentalsJanuary2019
        .CSharpAdvancedJanuary2019
        .Lecture03SetsAndDictionariesAdvanced
        .Exercises
        .Problem01UniqueUsernames
{
    public class UniqueUsernames
    {
        public static void Main()
        {
            int usernamesCount = int.Parse(Console.ReadLine());

            HashSet<string> usernames = new HashSet<string>();

            for (int i = 0; i < usernamesCount; i++)
            {
                string username = Console.ReadLine();

                usernames.Add(username);
            }

            foreach (var currentUsername in usernames)
            {
                Console.WriteLine(currentUsername);
            }
        }
    }
}