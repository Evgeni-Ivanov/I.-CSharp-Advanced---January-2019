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
        .Problem04v01FastFood
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

            Queue<int> queueOfOrders = new Queue<int>();

            for (int i = 0; i < orders.Length; i++)
            {
                queueOfOrders.Enqueue(orders[i]);
            }

            int biggestOrder = queueOfOrders.Max();

            while (queueOfOrders.Count > 0)
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
                Console.Write("Orders left: ");
                Console.Write(String.Join(" ", queueOfOrders));
            }
        }
    }
}