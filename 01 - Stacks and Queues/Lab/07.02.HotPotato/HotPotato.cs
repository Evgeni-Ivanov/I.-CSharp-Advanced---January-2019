﻿using System;
using System.Collections.Generic;

namespace StacksAndQueues
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
                string player = players.Dequeue();

                if (counter == fatalToss)
                {
                    Console.WriteLine($"Removed {player}");

                    counter = 1;
                }
                else
                {
                    players.Enqueue(player);

                    counter++;
                }
            }

            string lastPlayer = players.Dequeue();

            Console.WriteLine($"Last is {lastPlayer}");
        }
    }
}