using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();                      
            while (destination != "End")
            {
                double sum = 0;
                double budget = double.Parse(Console.ReadLine());
                while (sum < budget)
                {
                    double money = double.Parse(Console.ReadLine());
                    sum += money;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
