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
            double vrata = 1.2 * 2;
            double prozorec = 1.5 * 1.5;
            //stenite
            double zadnaStena = x * x;
            double prednaStena = zadnaStena - vrata;
            double stranichnaStena1 = x * y - prozorec;
            double stranichnaStena2 = stranichnaStena1;
            //dolna chast na kushtata
            double dolnaChastNaKushtata = zadnaStena + prednaStena + stranichnaStena1 + stranichnaStena2;

            double golqmaChastNaPokriva = (x * y) * 2;
            double triugulnaChastNaPokriva = ((x * h) / 2.00) * 2;
            double roof = golqmaChastNaPokriva + triugulnaChastNaPokriva;

            double greenPaintQuantityInLiters = dolnaChastNaKushtata / 3.4;
            double redPaintQuantityInLiters = roof / 4.3;

            Console.WriteLine($"{greenPaintQuantityInLiters:f2}");
            Console.WriteLine($"{redPaintQuantityInLiters:f2}");



        }
    }
}
