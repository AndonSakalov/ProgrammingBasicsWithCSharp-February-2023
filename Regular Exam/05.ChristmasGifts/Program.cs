using System;

namespace _05.ChristmasGifts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int toyCount = 0;
            int sweatersCount = 0;
            int kidsCount = 0;
            int adultsCount = 0;
            while (input != "Christmas")
            {
                int age = int.Parse(input);
                if (age <= 16)
                {
                    toyCount++;
                    kidsCount++;
                }
                else 
                {
                    sweatersCount++;
                    adultsCount++;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Number of adults: {adultsCount}");
            Console.WriteLine($"Number of kids: {kidsCount}");
            Console.WriteLine($"Money for toys: {(double)toyCount * 5.0}");
            Console.WriteLine($"Money for sweaters: {(double)sweatersCount * 15.0}");
        }
    }
}
