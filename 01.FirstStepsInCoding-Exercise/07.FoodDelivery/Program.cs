using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegeterianMenu = int.Parse(Console.ReadLine());

            double chickenMenuCost = 10.35 * chickenMenu;
            double fishMenuCost = 12.40 * fishMenu;
            double vegeterianMenuCost = 8.15 *  vegeterianMenu; 

            double totalCostForAllMenus = chickenMenuCost + fishMenuCost + vegeterianMenuCost;
            double desertCost = totalCostForAllMenus * 20 * 0.01;

            double totalCost = desertCost + totalCostForAllMenus + 2.50;

            Console.WriteLine(totalCost);
        }
    }
}
