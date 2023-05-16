using System;

namespace _07.SchoolCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int overNightStaysCount = int.Parse(Console.ReadLine());
            double costPerNight = 0;
            double finalCost = 0;
            string sport = string.Empty;

            switch (season) 
            {
                case "Winter":
                    if (groupType == "boys")
                    {
                        costPerNight = 9.60;
                        sport = "Judo";
                    }
                    else if (groupType == "girls")
                    {
                        costPerNight = 9.60;
                        sport = "Gymnastics";
                    }
                    else if (groupType == "mixed")
                    {
                        costPerNight = 10;
                        sport = "Ski";
                    }
                    break;
                case "Spring":
                    if (groupType == "boys")
                    {
                        costPerNight = 7.20;
                        sport = "Tennis";
                    }
                    else if (groupType == "girls")
                    {
                        costPerNight = 7.20;
                        sport = "Athletics";
                    }
                    else if (groupType == "mixed")
                    {
                        costPerNight = 9.50;
                        sport = "Cycling";
                    }
                    break;
                case "Summer":
                    if (groupType == "boys")
                    {
                        costPerNight = 15;
                        sport = "Football";
                    }
                    else if (groupType == "girls")
                    {
                        costPerNight = 15;
                        sport = "Volleyball";
                    }
                    else if (groupType == "mixed")
                    {
                        costPerNight = 20;
                        sport = "Swimming";
                    }     
                    break;
            }
            if (studentsCount >= 50)
            {
                finalCost = (costPerNight * overNightStaysCount * studentsCount) * 0.50;
            }
            else if (studentsCount >= 20 && studentsCount < 50)
            {
                finalCost = (costPerNight * overNightStaysCount * studentsCount) * 0.85;
            }
            else if (studentsCount >= 10 && studentsCount < 20)
            {
                finalCost = (costPerNight * overNightStaysCount * studentsCount) * 0.95;
            }
            else
            {
                finalCost = (costPerNight * overNightStaysCount * studentsCount);
            }
            
            if (costPerNight != 0)
            {
                Console.WriteLine($"{sport} {finalCost:F2} lv.");
            }
            
        }
    }
}
