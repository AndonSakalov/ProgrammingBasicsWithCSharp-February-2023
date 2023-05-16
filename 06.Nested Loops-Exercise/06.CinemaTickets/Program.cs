using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int allTickets = 0;
            int totalStudentTickets = 0;
            int totalStandardTickets = 0;
            int totalKidTickets = 0;
            while (movieName != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();
                int currentMovieTickets = 0;
                while (ticketType != "End")
                {
                    int studentTickets = 0;
                    int standardTickets = 0;
                    int kidTickets = 0;
                    switch (ticketType)
                    {
                        case "student":
                            studentTickets++;
                            currentMovieTickets++;
                            allTickets++;
                            totalStudentTickets++;
                            break;
                        case "standard":
                            standardTickets++;
                            currentMovieTickets++;
                            allTickets++;
                            totalStandardTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            currentMovieTickets++;
                            allTickets++;
                            totalKidTickets++;
                            break;
                    }
                    if (currentMovieTickets >= freeSeats)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }
                Console.WriteLine($"{movieName} - {(double) currentMovieTickets / freeSeats * 100:F2}% full.");
                if (ticketType == "Finish")
                {
                    break; 
                }
                movieName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{(double) totalStudentTickets / allTickets * 100:F2}% student tickets.");
            Console.WriteLine($"{(double) totalStandardTickets / allTickets * 100:F2}% standard tickets.");
            Console.WriteLine($"{(double) totalKidTickets / allTickets * 100:F2}% kids tickets.");
        }   
    }
}
