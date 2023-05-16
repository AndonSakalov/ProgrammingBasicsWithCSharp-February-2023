using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aqariumLength = int.Parse(Console.ReadLine());
            int aquariumWidth = int.Parse(Console.ReadLine());
            int aquariumHeigth = int.Parse(Console.ReadLine());
            double percentigeSpaceTaken = double.Parse(Console.ReadLine());

            double volume = aqariumLength * aquariumWidth * aquariumHeigth;
            double volumeInLiters = volume * 0.001;
            double litersNeeded = volumeInLiters * (1 - (percentigeSpaceTaken * 0.01)); 

            Console.WriteLine(litersNeeded);
        }
    }
}
