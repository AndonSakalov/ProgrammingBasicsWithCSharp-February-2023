using System;

namespace _02.SleepyTomCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());
            int workingDays = 365 - restDays;
            int totalMinutesOfPlaying = restDays * 127 + workingDays * 63;

            if (totalMinutesOfPlaying > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{(totalMinutesOfPlaying - 30000) / 60} hours and {(totalMinutesOfPlaying - 30000) % 60} minutes more for play");
            }
            else if (totalMinutesOfPlaying < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{(30000 - totalMinutesOfPlaying) / 60} hours and {(30000 - totalMinutesOfPlaying) % 60} minutes less for play");
            }
        }
    }
}
