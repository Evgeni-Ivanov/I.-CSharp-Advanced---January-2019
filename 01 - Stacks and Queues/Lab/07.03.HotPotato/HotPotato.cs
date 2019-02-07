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