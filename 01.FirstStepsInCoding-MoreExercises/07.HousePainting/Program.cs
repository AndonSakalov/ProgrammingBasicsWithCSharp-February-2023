using System;

namespace _07.HousePainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            //vrata i prozorec
            double door = 1.2 * 2;
            double window = 1.5 * 1.5;
            //stenite
            double backWall = x * x;
            double frontWall = backWall - door;
            double sideWall1 = x * y - window;
            double sideWall2 = sideWall1;
            //dolna chast na kushtata
            double lowerPartOfTheHouse = backWall + frontWall + sideWall1 + sideWall2;

            double biggerPartOfTheRoof = (x * y) * 2;
            double trianglePartOfTheRoof = ((x * h) / 2.00) * 2;
            double roof = biggerPartOfTheRoof + trianglePartOfTheRoof;

            double greenPaintQuantityInLiters = lowerPartOfTheHouse / 3.4;
            double redPaintQuantityInLiters = roof / 4.3;

            Console.WriteLine($"{greenPaintQuantityInLiters:f2}");
            Console.WriteLine($"{redPaintQuantityInLiters:f2}");



        }
    }
}
