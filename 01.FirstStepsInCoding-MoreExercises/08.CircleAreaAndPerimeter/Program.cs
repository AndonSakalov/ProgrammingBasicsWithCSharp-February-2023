using System;

namespace _08.CircleAreaAndPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double areaOfCircle = Math.PI * (radius * radius);
            double diameter = radius * 2.00;
            double parameterOfCircle = Math.PI * diameter;

            Console.WriteLine($"{areaOfCircle:f2}");
            Console.WriteLine($"{parameterOfCircle:f2}");
        }
    }
}
