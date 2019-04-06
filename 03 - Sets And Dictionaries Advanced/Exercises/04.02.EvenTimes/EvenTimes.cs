using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
        .ProfessionalModules
        .CSharpWebDeveloper
        .CSharpFundamentals
        .CSharpFundamentalsJanuary2019
        .CSharpAdvancedJanuary2019
        .Lecture03SetsAndDictionariesAdvanced
        .Exercises
        .Problem04v02EvenTimes
{
    public class EvenTimes
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (numbers.ContainsKey(number) == false)
                {
                    numbers.Add(number, 0);
                }

                numbers[number]++;
            }

            foreach (var foundNumber in numbers.Where(x => x.Value % 2 == 0))
            {
                Console.WriteLine(foundNumber.Key);

                // In this case there is no need to use break,
                // because there will be only one number in the collection that is even.
                //break;
            }

            // Or:
            //int foundNumber = numbers.FirstOrDefault(x => x.Value % 2 == 0).Key;
            //Console.WriteLine(foundNumber);
        }
    }
}