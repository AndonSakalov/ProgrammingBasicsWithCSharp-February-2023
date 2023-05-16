using System;

namespace _05.TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //shirina na rabotnoto mqsto - 70 cm.
            //duljina na rabotnoto mqsto - 120 cm.
            double wLength = double.Parse(Console.ReadLine());
            double hWidth = double.Parse(Console.ReadLine());

            double wDuljinaCM = wLength * 100;
            double hShirinaCM = hWidth * 100;

            double hShirinaBezKoridora = hShirinaCM - 100;
            double rabotniMestaNaRed = hShirinaBezKoridora / 70; 

            double redove = wDuljinaCM / 120;

            //A way to convert double into int. By converting redove and rabotniMestaNaRed from double to int, the calculations are now with whole numbers and are correct!
            int b = 0;
            b = (int)redove;

            int c = 0;
            c = (int)rabotniMestaNaRed;
            //A way to convert double into int. By converting redove and rabotniMestaNaRed from double to int, the calculations are now with whole numbers and are correct!
            
            int broiRabotniMesta = (b * c - 3);

            Console.WriteLine(broiRabotniMesta);
        }
    }
}

