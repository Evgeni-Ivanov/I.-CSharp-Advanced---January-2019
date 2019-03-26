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
        .Lab
        .Problem02AverageStudentGrades
{
    public class AverageStudentGrades
    {
        public static void Main()
        {
            int numberOfGrades = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsWithGrades =
                new Dictionary<string, List<double>>();

            for (int gradesCount = 0; gradesCount < numberOfGrades; gradesCount++)
            {
                string[] studentWithGrade = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string student = studentWithGrade[0];
                double grade = double.Parse(studentWithGrade[1]);

                // if (!studentsWithGrades.ContainsKey(student))
                // or
                if (studentsWithGrades.ContainsKey(student) == false)
                {
                    studentsWithGrades.Add(student, new List<double>() { grade });
                    // or
                    // studentsWithGrades[student] = new List<double>() { grade };
                }
                else
                {
                    studentsWithGrades[student].Add(grade);
                }
            }

            foreach (var currentStudent in studentsWithGrades)
            {
                Console.Write($"{currentStudent.Key} -> ");

                foreach (var currentGrade in currentStudent.Value)
                {
                    Console.Write($"{currentGrade:F2} ");
                }

                Console.WriteLine($"(avg: {currentStudent.Value.Average():F2})");
            }
        }
    }
}