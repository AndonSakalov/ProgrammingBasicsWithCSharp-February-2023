using System;
using System.Runtime.InteropServices;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i = 0; i < openTabs && salary > 0; i++)
            {
                string webSite = Console.ReadLine();
                if (webSite == "Facebook")
                {
                    salary -= 150;
                }
                else if (webSite == "Instagram")
                {
                    salary -= 100;
                }
                else if (webSite == "Reddit")
                {
                    salary -= 50;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }
            
        }
    }
}
