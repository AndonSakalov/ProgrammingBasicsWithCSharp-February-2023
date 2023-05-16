using System;
using System.Threading;

namespace _05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sum = decimal.Parse(Console.ReadLine());
            int countOfCoins = 0;
            while (sum > 0)
            {
                if (sum >= 2)
                {
                    sum -= 2;
                    countOfCoins++;
                }
                else if (sum >= 1)
                {
                    sum -= 1;
                    countOfCoins++;
                }
                else if (sum >= 0.5m)
                {
                    sum -= 0.5m;
                    countOfCoins++;
                }
                else if (sum >= 0.20m)
                {
                    sum -= 0.20m;
                    countOfCoins++;
                }
                else if (sum >= 0.10m)
                {
                    sum -= 0.10m;
                    countOfCoins++;
                }
                else if (sum >= 0.05m)
                {
                    sum -= 0.05m;
                    countOfCoins++;
                }
                else if (sum >= 0.02m)
                {
                    sum -= 0.02m;
                    countOfCoins++;
                }
                else
                {
                    sum -= 0.01m;
                    countOfCoins++;
                }
            }
            Console.WriteLine(countOfCoins);
        }
    }
}
