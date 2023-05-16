using System;

namespace _03.Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargoCount = int.Parse(Console.ReadLine());
            int microBus = 0; int truck = 0; int train = 0;
            for (int i = 0; i < cargoCount; i++)
            {
                int cargoWeightInTons = int.Parse(Console.ReadLine());
                if (cargoWeightInTons <= 3)
                {
                    microBus += cargoWeightInTons;
                }
                else if (cargoWeightInTons <= 11)
                {
                    truck += cargoWeightInTons;
                }
                else
                {
                    train += cargoWeightInTons;
                }
            }
            double allCargoPrice = (microBus * 200) + (truck * 175) + (train * 120);
            int allCargoTons = microBus + truck + train;
            double averagePricePerTonCargo = allCargoPrice / allCargoTons;
            Console.WriteLine($"{averagePricePerTonCargo:F2}");
            Console.WriteLine($"{(double) microBus / allCargoTons * 100:F2}%");
            Console.WriteLine($"{(double) truck / allCargoTons * 100:F2}%");
            Console.WriteLine($"{(double) train / allCargoTons * 100:F2}%");
        }
    }
}
