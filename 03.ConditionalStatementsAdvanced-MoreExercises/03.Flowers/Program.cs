using System;

namespace _03.Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemumsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int tulipsCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holidayYesOrNo = Console.ReadLine();
            double chrysanthemumsCost = 0;
            double rosesCost = 0;
            double tulipsCost = 0;
            double bouquetCost = 0;
            switch (season)
            {
                case "Spring":
                case "Summer":
                    chrysanthemumsCost = 2.00;
                    rosesCost = 4.10;
                    tulipsCost = 2.50;
                    bouquetCost = chrysanthemumsCost * chrysanthemumsCount + rosesCost * rosesCount + tulipsCost * tulipsCount;
                    if (holidayYesOrNo == "Y")
                    {
                        bouquetCost = bouquetCost * 1.15;
                    }
                    if (tulipsCount > 7 && season == "Spring")
                    {
                        bouquetCost = 0.95 * bouquetCost;
                    }
                    if (tulipsCount + rosesCount + chrysanthemumsCount > 20)
                    {
                        bouquetCost = 0.80 * bouquetCost;
                    }
                    break;

                case "Winter":
                case "Autumn":
                    chrysanthemumsCost = 3.75;
                    rosesCost = 4.50;
                    tulipsCost = 4.15;
                    bouquetCost = chrysanthemumsCost * chrysanthemumsCount + rosesCost * rosesCount + tulipsCost * tulipsCount;
                    if (holidayYesOrNo == "Y")
                    {
                        bouquetCost = bouquetCost * 1.15;
                    }
                    if (rosesCount >= 10 && season == "Winter")
                    {
                        bouquetCost = bouquetCost * 0.90;
                    }
                    if (tulipsCount + rosesCount + chrysanthemumsCount > 20)
                    {
                        bouquetCost = 0.80 * bouquetCost;
                    }
                    break;
            }
                bouquetCost = bouquetCost + 2;
                Console.WriteLine($"{bouquetCost:F2}");
            
        }
    }
}
