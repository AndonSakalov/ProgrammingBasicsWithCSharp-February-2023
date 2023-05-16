using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double ticketCost = 0;

            switch (projection)
            {
                case "Premiere":
                    ticketCost = 12;
                    break;
                case "Normal":
                    ticketCost = 7.50;
                    break;
                case "Discount":
                    ticketCost = 5;
                    break;
            }
            double totalEarnings = ticketCost * rows * cols;
            Console.WriteLine($"{totalEarnings:F2}");
        }
    }
}
