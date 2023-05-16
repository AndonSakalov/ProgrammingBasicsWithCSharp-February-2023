using System;

namespace _03.CourierExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double packageWeightInKGs = double.Parse(Console.ReadLine());
            string serviceType = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());
            double pricePerKm = 0;
            double markup= 0;
            switch (serviceType)
            {
                case "standard":
                    if (packageWeightInKGs < 1)
                    {
                        pricePerKm = 0.03;
                    }
                    else if (packageWeightInKGs > 1 && packageWeightInKGs < 10)
                    {
                        pricePerKm = 0.05;
                    }
                    else if (packageWeightInKGs < 40)
                    {
                        pricePerKm = 0.10;
                    }
                    else if (packageWeightInKGs < 90)
                    {
                        pricePerKm = 0.15;
                    }
                    else if (packageWeightInKGs < 150)
                    {
                        pricePerKm = 0.20;
                    }
                    break;
                case "express":
                    if (packageWeightInKGs < 1)
                    {
                        pricePerKm = 0.03;
                        markup = 0.03 * 0.80 * packageWeightInKGs;

                    }
                    else if (packageWeightInKGs > 1 && packageWeightInKGs < 10)
                    {
                        pricePerKm = 0.05 ;
                        markup = 0.05 * 0.40 * packageWeightInKGs;
                    }
                    else if (packageWeightInKGs < 40)
                    {
                        pricePerKm = 0.10 ;
                        markup = 0.10 * 0.05 * packageWeightInKGs;
                    }
                    else if (packageWeightInKGs < 90)
                    {
                        pricePerKm = 0.15 ;
                        markup = 0.15 * 0.02 * packageWeightInKGs;
                    }
                    else if (packageWeightInKGs < 150)
                    {
                        pricePerKm = 0.20;
                        markup = 0.20 * 0.01 * packageWeightInKGs;
                    }
                    break;
            }
            Console.WriteLine($"The delivery of your shipment with weight of {packageWeightInKGs:F3} kg. would cost {(pricePerKm * distance) + (markup * distance):F2} lv.");
        }
    }
}