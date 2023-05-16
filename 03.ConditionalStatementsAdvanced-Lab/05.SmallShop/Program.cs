using System;

namespace _05.SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double priceOfProduct = 0;

            switch (city)
            {
                case "Sofia":
                    if (product == "coffee")
                    {
                        priceOfProduct = 0.50;
                    }
                    else if (product == "water")
                    {
                        priceOfProduct = 0.80;
                    }
                    else if (product == "beer")
                    {
                        priceOfProduct = 1.20;
                    }
                    else if (product == "sweets")
                    {
                        priceOfProduct = 1.45;
                    }
                    else if (product == "peanuts")
                    {
                        priceOfProduct = 1.60;
                    }
                    break;

                case "Plovdiv":
                    if (product == "coffee")
                    {
                        priceOfProduct = 0.40;
                    }
                    else if (product == "water")
                    {
                        priceOfProduct = 0.70;
                    }
                    else if (product == "beer")
                    {
                        priceOfProduct = 1.15;
                    }
                    else if (product == "sweets")
                    {
                        priceOfProduct = 1.30;
                    }
                    else if (product == "peanuts")
                    {
                        priceOfProduct = 1.50;
                    }
                    break;

                case "Varna":
                    if (product == "coffee")
                    {
                        priceOfProduct = 0.45;
                    }
                    else if (product == "water")
                    {
                        priceOfProduct = 0.70;
                    }
                    else if (product == "beer")
                    {
                        priceOfProduct = 1.10;
                    }
                    else if (product == "sweets")
                    {
                        priceOfProduct = 1.35;
                    }
                    else if (product == "peanuts")
                    {
                        priceOfProduct = 1.55;
                    }
                    break;
            }
            Console.WriteLine(quantity * priceOfProduct);
        }
    }
}
