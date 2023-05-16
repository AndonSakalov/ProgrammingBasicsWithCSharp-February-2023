using System;

namespace _03.CatLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string catType = Console.ReadLine();
            char catGender = char.Parse(Console.ReadLine());
            double catMonths = 0;
            int pplMonths = 0;
            switch (catType) 
            {
                case "British Shorthair":
                    if (catGender == 'm')
                    {
                        pplMonths = 13 * 12;
                        catMonths = pplMonths / 6.0;
                    }
                    else if (catGender == 'f')
                    {
                        pplMonths = 14 * 12;
                        catMonths = pplMonths / 6.0;
                    }
                    break;
                case "Siamese":
                    if (catGender == 'm')
                    {
                        pplMonths = 15 * 12;
                        catMonths = pplMonths / 6.0;
                    }
                    else if (catGender == 'f')
                    {
                        pplMonths = 16 * 12;
                        catMonths = pplMonths / 6.0;
                    }
                    break;
                case "Persian":
                    if (catGender == 'm')
                    {
                        pplMonths = 14 * 12;
                        catMonths = pplMonths / 6.0;
                    }
                    else if (catGender == 'f')
                    {
                        pplMonths = 15 * 12;
                        catMonths = pplMonths / 6.0;
                    }
                    break;
                case "Ragdoll":
                    if (catGender == 'm')
                    {
                        pplMonths = 16 * 12;
                        catMonths = pplMonths / 6.0;
                    }
                    else if (catGender == 'f')
                    {
                        pplMonths = 17 * 12;
                        catMonths = pplMonths / 6.0;
                    }
                    break;
                case "American Shorthair":
                    if (catGender == 'm')
                    {
                        pplMonths = 12 * 12;
                        catMonths = pplMonths / 6.0;
                    }
                    else if (catGender == 'f')
                    {
                        pplMonths = 13 * 12;
                        catMonths = pplMonths / 6.0;
                    }
                    break;
                case "Siberian":
                    if (catGender == 'm')
                    {
                        pplMonths = 11 * 12;
                        catMonths = pplMonths / 6.0;
                    }
                    else if (catGender == 'f')
                    {
                        pplMonths = 12 * 12;
                        catMonths = pplMonths / 6.0;
                    }
                    break;
                default: 
                    Console.WriteLine($"{catType} is invalid cat!");
                    break;
            }
            if (catMonths != 0)
            {
                Console.WriteLine($"{Math.Floor(catMonths)} cat months");
            }
            
        }
    }
}
