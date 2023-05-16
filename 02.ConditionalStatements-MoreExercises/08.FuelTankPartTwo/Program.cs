using System;

namespace _08.FuelTankPartTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelQuantity = double.Parse(Console.ReadLine());
            string clubCardYesOrNo = Console.ReadLine();
            double finalPrice = 0;
            double fuelPricePerLiter = 0;

            if (fuelType == "Gas")
            {
                fuelPricePerLiter = 0.93;
                if (clubCardYesOrNo == "Yes")
                {
                    fuelPricePerLiter = fuelPricePerLiter - 0.08;
                }         
            }
            else if (fuelType == "Gasoline")
            {
                fuelPricePerLiter = 2.22;
                if (clubCardYesOrNo == "Yes")
                {
                    fuelPricePerLiter = fuelPricePerLiter - 0.18;
                }
            }
            else if (fuelType == "Diesel")
            {
                fuelPricePerLiter = 2.33;
                if (clubCardYesOrNo == "Yes")
                {
                    fuelPricePerLiter = fuelPricePerLiter - 0.12;
                }
            }
            if (fuelPricePerLiter != 0)
            {
                finalPrice = fuelPricePerLiter * fuelQuantity;
                if (fuelQuantity >= 20 && fuelQuantity <= 25)
                {
                    finalPrice = finalPrice * 0.92;
                }
                else if (fuelQuantity > 25)
                {
                    finalPrice = finalPrice * 0.90;
                }
                Console.Write($"{finalPrice:F2} lv.");
            }     
            
        }
    }
}
