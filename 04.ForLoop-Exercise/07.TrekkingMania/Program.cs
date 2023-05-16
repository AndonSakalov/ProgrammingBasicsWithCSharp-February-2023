using System;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());
            int p1 = 0; int p2 = 0; int p3 = 0; int p4 = 0; int p5 = 0;
            int allPeople = 0;
            for (int i = 0; i < groupsCount; i++)
            {
                int peopleCountInTheGroup = int.Parse(Console.ReadLine());
                if (peopleCountInTheGroup <= 5)
                {
                    p1 += peopleCountInTheGroup;
                }
                else if (peopleCountInTheGroup <= 12)
                {
                    p2 += peopleCountInTheGroup;
                }
                else if (peopleCountInTheGroup <= 25)
                {
                    p3 += peopleCountInTheGroup;
                }
                else if (peopleCountInTheGroup <= 40)
                {
                    p4 += peopleCountInTheGroup;
                }
                else
                {
                    p5 += peopleCountInTheGroup;
                }
                allPeople += peopleCountInTheGroup;
            }
            Console.WriteLine($"{(double)p1 / allPeople * 100:F2}%");
            Console.WriteLine($"{(double)p2 / allPeople * 100:F2}%");
            Console.WriteLine($"{(double)p3 / allPeople * 100:F2}%");
            Console.WriteLine($"{(double)p4 / allPeople * 100:F2}%");
            Console.WriteLine($"{(double)p5 / allPeople * 100:F2}%");
        }
    }
}
