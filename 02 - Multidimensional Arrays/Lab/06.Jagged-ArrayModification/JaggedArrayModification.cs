using System;
using System.Linq;

namespace SoftUni
        .ProfessionalModules
        .CSharpWebDeveloper
        .CSharpFundamentals
        .CSharpFundamentalsJanuary2019
        .CSharpAdvancedJanuary2019
        .Lecture02MultidimensionalArrays
        .Lab
        .Problem06JaggedArrayModification
{
    public class JaggedArrayModification
    {
        public static void Main()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columnElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = columnElements[column];
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "END")
                {
                    break;
                }

                string command = input[0];
                int row = int.Parse(input[1]);
                int column = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if (row < 0 || row > matrix.GetLength(0) - 1 ||
                    column < 0 || column > matrix.GetLength(1) - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (command == "Add")
                    {
                        matrix[row, column] += value;
                    }
                    else
                    {
                        matrix[row, column] -= value;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write($"{matrix[row, column]} ");
                }

                Console.WriteLine();
            }
        }
    }
}