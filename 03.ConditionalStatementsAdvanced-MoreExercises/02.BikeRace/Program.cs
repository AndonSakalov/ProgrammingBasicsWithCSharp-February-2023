using System;

namespace _02.BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniorBikersCount = int.Parse(Console.ReadLine());
            int seniorBikersCount = int.Parse(Console.ReadLine());  
            string routeType = Console.ReadLine();
            double juniorTax = 0;
            double seniorTax = 0;
            double donatedMoney = 0;
            switch (routeType)
            {
                case "trail":
                    juniorTax = 5.50;
                    seniorTax = 7;
                    donatedMoney = juniorTax * juniorBikersCount + seniorTax * seniorBikersCount;
                    break;

                case "cross-country":
                    juniorTax = 8;
                    seniorTax = 9.50;
                    if (juniorBikersCount + seniorBikersCount >= 50 )
                    {
                        juniorTax = juniorTax * 0.75;
                        seniorTax = seniorTax * 0.75;
                    }
                    donatedMoney = juniorTax * juniorBikersCount + seniorTax * seniorBikersCount;
                    break;

                case "downhill":
                    juniorTax = 12.25;
                    seniorTax = 13.75;
                    donatedMoney = juniorTax * juniorBikersCount + seniorTax * seniorBikersCount;
                    break;

                case "road":
                    juniorTax = 20;
                    seniorTax = 21.50;
                    donatedMoney = juniorTax * juniorBikersCount + seniorTax * seniorBikersCount;
                    break;
            }
            donatedMoney = 0.95 * donatedMoney;
            if (juniorTax != 0)
            {
                Console.WriteLine($"{donatedMoney:F2}");
            }
            
        }
    }
}
