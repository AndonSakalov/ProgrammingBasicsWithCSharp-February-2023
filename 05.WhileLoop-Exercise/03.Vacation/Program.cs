using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double requaredMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int spendingDays = 0;
            bool cantSaveMoney = false;
            int days = 0;
            while (availableMoney < requaredMoney)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                days++;
                if (action == "spend")
                {
                    availableMoney -= sum;
                    spendingDays++;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                    if (spendingDays == 5)
                    {
                        cantSaveMoney = true;
                        break;
                    }
                }
                else if (action == "save")
                {
                    spendingDays = 0;
                    availableMoney += sum;
                }
            }
            if (cantSaveMoney == true)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            else
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
