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
        .Problem02SumMatrixColumns
{
    public class SumMatrixColumns
    {
        public static void Main()
        {
            int[] sizesOfMatrix = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[sizesOfMatrix[0], sizesOfMatrix[1]];

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

            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                int columnSum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    columnSum += matrix[row, column];
                }

                Console.WriteLine(columnSum);
            }
        }
    }
}