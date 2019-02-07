using System;
using System.Collections.Generic;

namespace StacksAndQueues
{
    public class HotPotato
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();

            int fatalToss = int.Parse(Console.ReadLine());

            Queue<string> players = new Queue<string>();

            for (int i = 0; i < input.Length; i++)
            {
                players.Enqueue(input[i]);
            }

            while (players.Count > 1)
            {
                for (int i = 1; i < fatalToss; i++)
                {
                    players.Enqueue(players.Dequeue());
                }

                string playerToRemove = players.Dequeue();

                Console.WriteLine($"Removed {playerToRemove}");
            }

            string lastPlayer = players.Dequeue();

            Console.WriteLine($"Last is {lastPlayer}");
        }
    }
}