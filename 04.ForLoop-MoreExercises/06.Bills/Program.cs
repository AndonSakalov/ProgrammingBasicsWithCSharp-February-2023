using System;

namespace _06.Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            int waterBill = 20; int internetBill = 15; double others = 0; double electricityBillMoney = 0;
            for (int i = 0; i < months; i++)
            {
                double electricityBill = double.Parse(Console.ReadLine());
                electricityBillMoney += electricityBill;
                others += (electricityBill + waterBill + internetBill) * 1.20;
            }
            Console.WriteLine($"Electricity: {electricityBillMoney:F2} lv");
            Console.WriteLine($"Water: {waterBill * months:F2} lv");
            Console.WriteLine($"Internet: {internetBill * months:F2} lv");
            Console.WriteLine($"Other: {others:F2} lv");
            Console.WriteLine($"Average: {((waterBill * months) + (internetBill * months) + electricityBillMoney + others) /months:F2} lv");
        }
    }
}
