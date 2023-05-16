using System;

namespace _05.TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double wLength = double.Parse(Console.ReadLine());
            double hWidth = double.Parse(Console.ReadLine());

            double wLengthCM = wLength * 100;
            double hWidthCM = hWidth * 100;

            double hWidthWithoutTheCoridoor = hWidthCM - 100;
            double workPlacesPerRol = hWidthWithoutTheCoridoor / 70; 

            double rols = wLengthCM / 120;

            //A way to convert double into int. By converting redove and rabotniMestaNaRed from double to int, the calculations are now with whole numbers and are correct!
            int b = 0;
            b = (int)rols;

            int c = 0;
            c = (int)workPlacesPerRol;
            //A way to convert double into int. By converting redove and rabotniMestaNaRed from double to int, the calculations are now with whole numbers and are correct!
            
            int countOfWorkPlaces = (b * c - 3);

            Console.WriteLine(countOfWorkPlaces);
        }
    }
}

