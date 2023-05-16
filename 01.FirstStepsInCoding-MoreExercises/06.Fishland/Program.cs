using System;

namespace _06.Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cena na skumriqta na kilogram
            double mackerelPrice = double.Parse(Console.ReadLine());
            //cena na cacata na kilogram
            double spratPrice = double.Parse(Console.ReadLine());
            //kilograma palamud
            double bonitoQuantity = double.Parse(Console.ReadLine());
            //kilograma safrid
            double safridQuantity = double.Parse(Console.ReadLine());
            //kilograma midi
            int musselQuantity = int.Parse(Console.ReadLine());


            double bonitoPrice = mackerelPrice * 1.60;
            double safridPrice = spratPrice * 1.80;

            double bonitoCost = bonitoPrice * bonitoQuantity;
            double safridCost = safridQuantity * safridPrice;
            double musselCost = musselQuantity * 7.50;
            double totalCost = bonitoCost + safridCost + musselCost;

            Console.WriteLine($"{totalCost:f2}");
            

            
        }

    }
}
