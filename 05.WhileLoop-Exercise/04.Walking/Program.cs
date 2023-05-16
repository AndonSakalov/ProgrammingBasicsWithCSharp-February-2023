using System;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int goal = 10000;
            bool stepsAchieved = false;
            int allSteps = 0;
            while (!stepsAchieved) 
            { 
                string currentSteps = Console.ReadLine();
                if (currentSteps == "Going home")
                {
                    int finalSteps = int.Parse(Console.ReadLine());
                    allSteps += finalSteps;
                    if (allSteps >= goal)
                    {
                        stepsAchieved = true;
                    }
                    break;
                }
                else
                {
                    int currentStepsNum = int.Parse(currentSteps);
                    allSteps += currentStepsNum;                   
                }
                if (allSteps >= goal)
                {
                    stepsAchieved = true;
                    break;
                }
            }
            if (stepsAchieved)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{allSteps - goal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{goal - allSteps} more steps to reach goal.");
            }
        }
    }
}
