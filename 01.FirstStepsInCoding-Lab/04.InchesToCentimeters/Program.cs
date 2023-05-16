using System;

namespace _04.InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double centimeters = 2.54 * inches;
            Console.WriteLine(centimeters);
        }
    }
}
