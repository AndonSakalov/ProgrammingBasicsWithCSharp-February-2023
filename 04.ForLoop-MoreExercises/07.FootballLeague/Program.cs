using System;

namespace _07.FootballLeague
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int allFansCount = int.Parse(Console.ReadLine());
            int a = 0; int b = 0; int v = 0; int g = 0;
            for (int i = 0; i < allFansCount; i++)
            {
                string sector = Console.ReadLine();
                if (sector == "A")
                {
                    a++;
                }
                else if (sector == "B")
                {
                    b++;
                }
                else if (sector == "V")
                {
                    v++;
                }
                else if (sector == "G") 
                {
                    g++;
                }
            }
            Console.WriteLine($"{(double) a / allFansCount * 100:F2}%");
            Console.WriteLine($"{(double) b / allFansCount * 100:F2}%");
            Console.WriteLine($"{(double) v / allFansCount * 100:F2}%");
            Console.WriteLine($"{(double) g / allFansCount * 100:F2}%");
            Console.WriteLine($"{(double) allFansCount / stadiumCapacity * 100:F2}%");
        }
    }
}
