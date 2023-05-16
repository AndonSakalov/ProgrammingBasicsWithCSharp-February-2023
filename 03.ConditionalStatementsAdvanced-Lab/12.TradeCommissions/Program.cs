using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double salesQuantity = double.Parse(Console.ReadLine());
            double comissionPercentage = 0;
            switch (city)
            {
                case "Sofia":
                    if (salesQuantity >= 0 && salesQuantity <= 500)
                    {
                        comissionPercentage = 5;
                    }
                    else if (salesQuantity > 500 && salesQuantity <= 1000)
                    {
                        comissionPercentage = 7;
                    }
                    else if (salesQuantity > 1000 && salesQuantity <= 10000)
                    {
                        comissionPercentage = 8;
                    }
                    else if (salesQuantity > 10000)
                    {
                        comissionPercentage = 12;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "Varna":
                    if (salesQuantity >= 0 && salesQuantity <= 500)
                    {
                        comissionPercentage = 4.5;
                    }
                    else if (salesQuantity > 500 && salesQuantity <= 1000)
                    {
                        comissionPercentage = 7.5;
                    }
                    else if (salesQuantity > 1000 && salesQuantity <= 10000)
                    {
                        comissionPercentage = 10;
                    }
                    else if (salesQuantity > 10000)
                    {
                        comissionPercentage = 13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "Plovdiv":
                    if (salesQuantity >= 0 && salesQuantity <= 500)
                    {
                        comissionPercentage = 5.5;
                    }
                    else if (salesQuantity > 500 && salesQuantity <= 1000)
                    {
                        comissionPercentage = 8;
                    }
                    else if (salesQuantity > 1000 && salesQuantity <= 10000)
                    {
                        comissionPercentage = 12;
                    }
                    else if (salesQuantity > 10000)
                    {
                        comissionPercentage = 14.5;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }
            if (comissionPercentage > 0)
            {
                double comissionMoney = comissionPercentage * salesQuantity / 100;
                Console.WriteLine($"{comissionMoney:F2}");
            }

        }
    }
}
