using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double initialPoints = double.Parse(Console.ReadLine());    
            int juryCount = int.Parse(Console.ReadLine());
            double points = initialPoints;
            for (int i = 0; i < juryCount && points < 1250.5; i++)
            {
                string juryName = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());
                points += juryName.Length * juryPoints / 2; 
            }
            if (points > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:F1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - points:F1} more!");
            }
        }
    }
}
