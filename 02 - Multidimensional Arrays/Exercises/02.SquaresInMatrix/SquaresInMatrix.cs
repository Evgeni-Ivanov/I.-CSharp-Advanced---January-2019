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
        .Problem02SquaresInMatrix
{
    public class SquaresInMatrix
    {
        public static void Main()
        {
            int[] sizesOfMatrix = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = sizesOfMatrix[0];
            int columns = sizesOfMatrix[1];

            char[,] matrix = new char[rows, columns];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] columnElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = columnElements[column];
                }
            }

            int numberOfSquareMatrixes = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int column = 0; column < matrix.GetLength(1) - 1; column++)
                {
                    if (matrix[row, column] == matrix[row, column + 1] &&
                        matrix[row, column] == matrix[row + 1, column] &&
                        matrix[row, column] == matrix[row + 1, column + 1])
                    {
                        numberOfSquareMatrixes++;
                    }
                }
            }

            if (numberOfSquareMatrixes > 0)
            {
                Console.WriteLine(numberOfSquareMatrixes);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}