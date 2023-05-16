using System;
using System.Collections.Generic;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfBadGrades = int.Parse(Console.ReadLine());
            string problemName = Console.ReadLine();
            int grade = int.Parse(Console.ReadLine());
            int badGrades = 0;
            bool resultIsBad = false;
            int allGrades = 0;
            int gradesCount = 0;
            int problemCount = 0;
            string lastProblem = string.Empty;
            while (problemName != "Enough")
            {
                allGrades += grade;
                gradesCount++;
                problemCount++;
                lastProblem = problemName;
                if (grade <= 4)
                {
                    badGrades++;
                    if (badGrades == countOfBadGrades)
                    {
                        resultIsBad = true;
                        break;
                    }
                }
                problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    break;
                }
                grade = int.Parse(Console.ReadLine());
            }
            if (resultIsBad == true)
            {
                Console.WriteLine($"You need a break, {badGrades} poor grades."); 
            }
            else
            {
                Console.WriteLine($"Average score: {(double) allGrades / gradesCount:F2}");
                Console.WriteLine($"Number of problems: {problemCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
