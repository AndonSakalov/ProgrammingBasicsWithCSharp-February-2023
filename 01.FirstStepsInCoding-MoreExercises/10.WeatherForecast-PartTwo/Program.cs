using System;

namespace _10.WeatherForecast_PartTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());

            if (temperature >= 26.00 && temperature <= 35.00)
                {
                    Console.WriteLine("Hot");
                }
            else if (temperature >= 20.01 && temperature <= 25.99)
            {
                Console.WriteLine("Warm");
            }
            else if (temperature >= 15.00 && temperature <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (temperature >= 12.00 && temperature <= 14.99)
            {
                Console.WriteLine("Cool");
            }
            else if (temperature >= 5.00 && temperature <= 11.99)
            {
                Console.WriteLine("Cold");
            }

            else 
            {
                Console.WriteLine("unknown"); 
            }


        }
    }
}
