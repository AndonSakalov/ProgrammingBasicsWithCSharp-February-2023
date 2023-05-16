using System;

namespace _03.CelsiusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius = double.Parse(Console.ReadLine());

            double fahrenheit = 1.8 * celcius + 32;

            Console.WriteLine($"{fahrenheit:f2}");
        }
    }
}
