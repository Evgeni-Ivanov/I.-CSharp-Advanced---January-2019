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
        .Problem11KeyRevolver
{
    public class KeyRevolver
    {
        public static void Main()
        {
            int priceOfBullet = int.Parse(Console.ReadLine());

            int sizeOfGunBarrel = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] locks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int intelligenceValue = int.Parse(Console.ReadLine());

            // Sam starts to shoot the locks front-to-back,
            Queue<int> locksQueue = new Queue<int>(locks);

            // while going through the bullets back-to-front.
            Stack<int> bulletsStack = new Stack<int>(bullets);

            int bulletsShot = 0;

            // The program ends when Sam either runs out of bullets, or the safe runs out of locks.
            while (bulletsStack.Count > 0 && locksQueue.Count > 0)
            {
                int currentBullet = bulletsStack.Peek();
                int currentLock = locksQueue.Peek();

                // if (currentBullet <= currentLock)
                if (currentLock >= currentBullet)
                {
                    // If the bullet has a smaller or equal size to the current lock, print “Bang!”, then remove the lock.
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();
                    bulletsStack.Pop();

                    bulletsShot++;
                }
                else
                {
                    // If not, print “Ping!”, leaving the lock intact. The bullet is removed in both cases.
                    Console.WriteLine("Ping!");
                    bulletsStack.Pop();

                    bulletsShot++;
                }

                // If Sam runs out of bullets in his barrel, print “Reloading!” on the console, then continue shooting.
                // If there aren’t any bullets left, don’t print it.
                if (bulletsShot >= sizeOfGunBarrel && bulletsStack.Count > 0)
                {
                    Console.WriteLine("Reloading!");

                    bulletsShot = 0;
                }
            }

            // If Sam runs out of bullets before the safe runs out of locks, print:
            if (bulletsStack.Count <= 0 && locksQueue.Count > 0)
            {
                int locksLeft = locksQueue.Count();

                Console.WriteLine($"Couldn't get through. Locks left: {locksLeft}");
            }

            // If Sam manages to open the safe, print:
            if (locksQueue.Count <= 0)
            {
                int bulletsLeft = bulletsStack.Count;
                int totalBulletsShot = bullets.Count() - bulletsLeft;
                int moneyEarned = intelligenceValue - (totalBulletsShot * priceOfBullet);

                Console.WriteLine($"{bulletsLeft} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}