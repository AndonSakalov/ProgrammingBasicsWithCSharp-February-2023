using System;

namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());
            int examTimeInMinutes = examHour * 60 + examMinute;
            int arrivalTimeInMinutes = arrivalHour * 60 + arrivalMinute;
            int timeDiff = examTimeInMinutes - arrivalTimeInMinutes;

            if (timeDiff <= 30 && timeDiff >= 0)
            {
                Console.WriteLine("On time");
                if (examTimeInMinutes != arrivalTimeInMinutes)
                {
                    Console.WriteLine(timeDiff + " minutes before the start");
                }
            }
            else if (timeDiff > 30)
            {
                Console.WriteLine("Early");
                if (timeDiff >= 60)
                {
                    if (timeDiff % 60 < 10)
                    {
                        Console.WriteLine($"{timeDiff / 60}:0{timeDiff % 60} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{timeDiff / 60}:{timeDiff % 60} hours before the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{timeDiff} minutes before the start");
                }
            }
            else if (timeDiff < 0)
            {
                int absoluteNumber = Math.Abs(timeDiff);
                Console.WriteLine("Late");
                if (absoluteNumber >= 60)
                {
                    if (absoluteNumber % 60 < 10)
                    {
                        Console.WriteLine($"{absoluteNumber / 60}:0{absoluteNumber % 60} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{absoluteNumber / 60}:{absoluteNumber % 60} hours after the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{absoluteNumber} minutes after the start");
                }
            }
        }
    }
}
