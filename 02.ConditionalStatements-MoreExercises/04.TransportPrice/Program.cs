using System;

namespace _04.TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double price = 0;

            if (kilometers < 20)
            {
                if (dayOrNight == "day")
                {
                    price = 0.70 + 0.79 * kilometers;
                }
                else
                {
                    price = 0.70 + 0.90 * kilometers;
                }
            }
            else if (kilometers >= 20 && kilometers < 100)
            {
                price = kilometers * 0.09;
            }
            else
            {
                price = kilometers * 0.06;
            }

            if (price != 0)
            {
                Console.WriteLine($"{price:F2}");
            }
        }
    }
}
