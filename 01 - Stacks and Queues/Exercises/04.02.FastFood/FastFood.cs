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
        .Exercises
        .Problem04v02FastFood
{
    public class FastFood
    {
        public static void Main()
        {
            int totalFoodQuantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queueOfOrders = new Queue<int>(orders);

            int biggestOrder = queueOfOrders.Max();

            int countOfQueueOfOrders = queueOfOrders.Count;

            for (int i = 0; i < countOfQueueOfOrders; i++)
            {
                int peekOrder = queueOfOrders.Peek();

                if (totalFoodQuantity >= peekOrder)
                {
                    int currentOrder = queueOfOrders.Dequeue();

                    totalFoodQuantity -= currentOrder;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(biggestOrder);

            if (queueOfOrders.Count < 1)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {String.Join(" ", queueOfOrders)}");
            }
        }
    }
}