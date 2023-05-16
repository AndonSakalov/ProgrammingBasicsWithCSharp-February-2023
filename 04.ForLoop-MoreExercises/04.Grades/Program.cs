using System;

namespace _04.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int fail = 0; int average = 0; int good = 0; int veryGood = 0;
            double averageSuccess = 0;
            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                averageSuccess += grade;
                if (grade >= 2 && grade <= 2.99)
                {
                    fail++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    average++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    good++;
                }
                else if (grade >= 5)
                {
                    veryGood++;
                }

            }
            averageSuccess /= students;
            Console.WriteLine($"Top students: {(double) veryGood / students * 100:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(double) good / students * 100:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(double) average / students * 100:F2}%");
            Console.WriteLine($"Fail: {(double) fail / students * 100:F2}%");
            Console.WriteLine($"Average: {(double) averageSuccess:F2}");

        }
    }
}
