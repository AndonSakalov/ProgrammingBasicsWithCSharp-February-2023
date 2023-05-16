using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysNeeded = int.Parse(Console.ReadLine());
            
            int hoursNeeded= pages / pagesPerHour;
            int dailyHoursNeeded = hoursNeeded / daysNeeded;

            Console.WriteLine(dailyHoursNeeded);
        }   
    }
}
