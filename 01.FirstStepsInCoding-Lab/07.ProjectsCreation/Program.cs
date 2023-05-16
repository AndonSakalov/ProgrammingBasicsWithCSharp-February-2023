using System;

namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която изчислява колко часа ще са необходими на един архитект, за да изготви проектите на няколко строителни обекта.
            //Изготвянето на един проект отнема три часа.

            //Вход
            //От конзолата се четат 2 реда:
            //1.Името на архитекта -текст
            //2.Брой на проектите, които трябва да изготви - цяло число в интервала[0 … 100]

            //Изход
            //На конзолата се отпечатва:
            //"The architect {името на архитекта} will need {необходими часове} hours to complete {брой на проектите} project/s."
            
            string nameOfArchitect = Console.ReadLine();
            int countOfProjects = int.Parse(Console.ReadLine());
            
            int hoursPerProject = 3;
            int hoursNeeded = countOfProjects * hoursPerProject;
            
            Console.WriteLine($"The architect {nameOfArchitect} will need {hoursNeeded} hours to complete {countOfProjects} project/s.");

        }
    }
}
