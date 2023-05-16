using System;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();
            double allAverageGrades = 0;
            int presentationsCount = 0;
            while (presentationName != "Finish")
            {
                presentationsCount++;
                double allGrades = 0;
                double averageGrade = 0;
                for (int i = 0; i < juryCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    allGrades += grade;
                }
                averageGrade = allGrades / juryCount;
                Console.WriteLine($"{presentationName} - {averageGrade:F2}.");
                allAverageGrades += averageGrade;
                presentationName = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {allAverageGrades / presentationsCount:F2}.");
        }
    }
}
