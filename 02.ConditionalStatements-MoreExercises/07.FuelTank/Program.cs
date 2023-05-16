using System;
using System.Threading.Tasks;

namespace _07.FuelTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double litersFuelInTank = double.Parse(Console.ReadLine());
            string fuelType2 = Console.ReadLine();
            if (fuelType == "Diesel" || fuelType == "Gasoline" || fuelType == "Gas")
            {
                if (litersFuelInTank >= 25 && fuelType == "Diesel")
                {
                    fuelType2 = "diesel";
                    Console.WriteLine($"You have enough {fuelType2}.");
                }
                else if (litersFuelInTank >= 25 && fuelType == "Gasoline")
                {
                    fuelType2 = "gasoline";
                    Console.WriteLine($"You have enough {fuelType2}.");
                }
                else if (litersFuelInTank >= 25 && fuelType == "Gas")
                {
                    fuelType2 = "gas";
                    Console.WriteLine($"You have enough {fuelType2}.");
                }
                else
                {
                    if (fuelType == "Diesel")
                    {
                        fuelType2 = "diesel";
                        Console.WriteLine($"Fill your tank with {fuelType2}!");
                    }
                    if (fuelType == "Gasoline")
                    {
                        fuelType2 = "gasoline";
                        Console.WriteLine($"Fill your tank with {fuelType2}!");
                    }
                    if (fuelType == "Gas")
                    {
                        fuelType2 = "gas";
                        Console.WriteLine($"Fill your tank with {fuelType2}!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
            
        }
    }
}
