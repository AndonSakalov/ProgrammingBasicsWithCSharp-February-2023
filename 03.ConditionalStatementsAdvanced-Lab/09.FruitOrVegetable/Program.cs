using System;

namespace _09.FruitOrVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string typeOfProduct = string.Empty;
            switch (product)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    typeOfProduct = "fruit";
                    Console.WriteLine(typeOfProduct);
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    typeOfProduct = "vegetable";
                    Console.WriteLine(typeOfProduct);
                    break;
                default:
                    typeOfProduct = "unknown";
                    Console.WriteLine(typeOfProduct);
                    break;
            }
        }
    }
}
