﻿using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
           // double grades = double.Parse(Console.ReadLine());
            int grade = 1;
            int badgrades = 0;
            double allGrades = 0;
            while (grade <= 12)
            {
                double grades = double.Parse(Console.ReadLine());
                if (grades < 4.00) 
                {
                    badgrades++;
                    if (badgrades > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        return;
                    }
                    continue;
                }
                allGrades += grades;
                grade++;
                               
            }
            Console.WriteLine($"{name} graduated. Average grade: {allGrades / 12:F2}");
        }
    }
}
