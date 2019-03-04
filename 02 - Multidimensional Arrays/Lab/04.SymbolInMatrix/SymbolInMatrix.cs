using System;

namespace SoftUni
        .ProfessionalModules
        .CSharpWebDeveloper
        .CSharpFundamentals
        .CSharpFundamentalsJanuary2019
        .CSharpAdvancedJanuary2019
        .Lecture02MultidimensionalArrays
        .Lab
        .Problem04SymbolInMatrix
{
    public class SymbolInMatrix
    {
        public static void Main()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] columnElements = Console.ReadLine()
                    .ToCharArray();

                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = columnElements[column];
                }
            }

            char symbolToSearchFor = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    char currentSymbol = matrix[row, column];

                    if (currentSymbol == symbolToSearchFor)
                    {
                        int rowIndex = row;
                        int columnIndex = column;

                        Console.WriteLine($"({rowIndex}, {columnIndex})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbolToSearchFor} does not occur in the matrix");
        }
    }
}