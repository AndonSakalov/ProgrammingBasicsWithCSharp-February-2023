using System;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double squareArea = side * side;
                Console.WriteLine($"{squareArea:f3}");
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double rectangleArea = sideA * sideB;
                Console.WriteLine($"{rectangleArea:f3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * (radius * radius);
                Console.WriteLine($"{circleArea:f3}");
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double triangleArea = 0.5 * side * h;
                Console.WriteLine($"{triangleArea:f3}");
            }
        }
    }
}
