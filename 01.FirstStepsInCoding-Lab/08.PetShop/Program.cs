using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която пресмята нужните разходи за закупуването на храна за кучета и котки.
            //Храната се пазарува от зоомагазин, като една опаковка храна за кучета е на цена 2.50 лв,
            //а опаковка храна за котки струва 4 лв.

            //Вход
            //От конзолата се четат 2 реда:
            //1.Броят на опаковките храна за кучета – цяло число в интервала[0… 100]
            //2.Броят на опаковките храна за котки –  цяло число в интервала[0… 100]

            //Изход
            //На конзолата се отпечатва:
            //"{крайната сума} lv."
            double dogFoodPrice = 2.50;
            double catFoodPrice = 4.00;

            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            double finalPrice= dogFood * dogFoodPrice + catFood * catFoodPrice;

            Console.WriteLine($"{finalPrice} lv.");


        }
    }
}
