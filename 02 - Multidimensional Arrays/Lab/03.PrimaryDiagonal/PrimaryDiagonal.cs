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
        .Problem03PrimaryDiagonal
{
    public class PrimaryDiagonal
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

            int sumOfMatrixPrimaryDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumOfMatrixPrimaryDiagonal += matrix[i, i];
            }

            Console.WriteLine(sumOfMatrixPrimaryDiagonal);
        }
    }
}