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
            double litersNeeded = volumeInLiters * (1 - (percentigeSpaceTaken * 0.01)); //litrite, koito sa ni nujni da napulnim akvariuma = obema v litri * (obema v litri - zaetiqt obem.
              //NB a * (1 - (c*0,01) ) = (a * 1) - (a * zaetiqt obem) = a - zaetiqt obem

            Console.WriteLine(litersNeeded);
        }
    }
}
