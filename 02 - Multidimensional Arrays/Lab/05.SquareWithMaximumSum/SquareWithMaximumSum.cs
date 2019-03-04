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
        .Problem05SquareWithMaximumSum
{
    public class SquareWithMaximumSum
    {
        public static void Main()
        {
            int[] sizesOfMatrix = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numberOfRows = sizesOfMatrix[0];
            int numberOfColumns = sizesOfMatrix[1];

            int[,] matrix = new int[numberOfRows, numberOfColumns];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columnElements = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
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

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int column = 0; column < matrix.GetLength(1) - 1; column++)
                {
                    int currentSum = matrix[row, column] +
                                     matrix[row, column + 1] +
                                     matrix[row + 1, column] +
                                     matrix[row + 1, column + 1];

                    if (currentSum > maximumSum)
                    {
                        maximumSum = currentSum;
                        rowIndex = row;
                        columnIndex = column;
                    }
                }
            }

            for (int row = rowIndex; row < rowIndex + 2; row++)
            {
                for (int column = columnIndex; column < columnIndex + 2; column++)
                {
                    Console.Write($"{matrix[row, column]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maximumSum);
        }
    }
}