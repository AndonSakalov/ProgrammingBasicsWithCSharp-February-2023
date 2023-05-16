using System;

namespace _03.Time_15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int bonusTime = 15;
            
            if (minutes + bonusTime > 59) 
            {
                hours++;
                minutes = (minutes + 15) % 60;
            }
            else
            {
                minutes = minutes + bonusTime;
            }
            if (hours > 23) 
            {
                hours = 0;
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
            
    }
}
