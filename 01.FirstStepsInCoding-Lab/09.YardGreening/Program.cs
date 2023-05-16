using System;

namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Божидара разполага с няколко къщи на Черноморието и желае да озелени дворовете на някои от тях,
            //като по този начин създаде уютна обстановка и комфорт на гостите си.За целта е наела фирма.
            //Напишете програма, която изчислява необходимате сума,
            //които Божидара ще трябва да заплати на фирмата изпълнител на проекта.Цената на един кв. м.е 7.61 лв със ДДС.
            //Понеже нейният двор е доста голям, фирмата изпълнител предлага 18 % отстъпка от крайната цена.
            
            //Вход
            //От конзолата се прочита само един ред:
            //1.Кв.метри, които ще бъдат озеленени – реално число в интервала[0.00 … 10000.00]
            
            //Изход
            //На конзолата се отпечатват два реда:
            //"The final price is: {крайна цена на услугата} lv."
            //"The discount is: {отстъпка} lv."
            double yardSize = double.Parse(Console.ReadLine());

            double startingPrice = yardSize * 7.61;
            double discount = startingPrice * 0.18;
            double finalPrice = startingPrice - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");

        }
    }
}
