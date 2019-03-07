using System;
using System.Linq;

namespace SoftUni
        .ProfessionalModules
        .CSharpWebDeveloper
        .CSharpFundamentals
        .CSharpFundamentalsJanuary2019
        .CSharpAdvancedJanuary2019
        .Lecture02MultidimensionalArrays
        .Exercises
        .Problem03v01MaximalSum
{
    public class MaximalSum
    {
        public static void Main()
        {
            int[] sizesOfMatrix = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = sizesOfMatrix[0];
            int columns = sizesOfMatrix[1];

            int[,] matrix = new int[rows, columns];

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

            int maximumSum = int.MinValue;
            int rowIndex = 0;
            int columnIndex = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int column = 0; column < matrix.GetLength(1) - 2; column++)
                {
                    int currentSum = matrix[row, column] + matrix[row, column + 1] + matrix[row, column + 2] +
                                     matrix[row + 1, column] + matrix[row + 1, column + 1] + matrix[row + 1, column + 2] +
                                     matrix[row + 2, column] + matrix[row + 2, column + 1] + matrix[row + 2, column + 2];

                    if (currentSum > maximumSum)
                    {
                        maximumSum = currentSum;
                        rowIndex = row;
                        columnIndex = column;
                    }
                }
            }

            Console.WriteLine($"Sum = {maximumSum}");

            for (int row = rowIndex; row < rowIndex + 3; row++)
            {
                for (int column = columnIndex; column < columnIndex + 3; column++)
                {
                    Console.Write($"{matrix[row, column]} ");
                }

                Console.WriteLine();
            }
        }
    }
}