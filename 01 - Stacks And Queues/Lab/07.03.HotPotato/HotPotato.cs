using System;
using System.Collections.Generic;

namespace SoftUni
        .ProfessionalModules
        .CSharpWebDeveloper
        .CSharpFundamentals
        .CSharpFundamentalsJanuary2019
        .CSharpAdvancedJanuary2019
        .Lecture01StacksAndQueues
        .Lab
        .Problem07v03HotPotato
{
    public class HotPotato
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int fatalToss = int.Parse(Console.ReadLine());

            Queue<string> players = new Queue<string>(input);

            int counter = 1;

            while (players.Count > 1)
            {
                if (counter % fatalToss == 0)
                {
                    string playerToRemove = players.Dequeue();

                    Console.WriteLine($"Removed {playerToRemove}");
                }
                else
                {
                    string player = players.Dequeue();
                    players.Enqueue(player);
                }

                counter++;
            }

            string lastPlayer = players.Dequeue();

            Console.WriteLine($"Last is {lastPlayer}");
        }
    }
}