using System;
using System.ComponentModel.Design;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            char operatoR = char.Parse(Console.ReadLine());
            double answer = 0;

            switch (operatoR) 
            {
                case '+':
                    answer = numberOne + numberTwo;
                    if (answer % 2 == 0)
                    {
                        Console.WriteLine($"{numberOne} + {numberTwo} = {answer} - even");
                    }
                    else 
                    {
                        Console.WriteLine($"{numberOne} + {numberTwo} = {answer} - odd");
                    }
                    break;
                
                case '-':
                    answer = numberOne - numberTwo;
                    if (answer % 2 == 0)
                    {
                        Console.WriteLine($"{numberOne} - {numberTwo} = {answer} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numberOne} - {numberTwo} = {answer} - odd");
                    }
                    break;
                
                case '*':
                    answer = numberOne * numberTwo;
                    if (answer % 2 == 0)
                    {
                        Console.WriteLine($"{numberOne} * {numberTwo} = {answer} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numberOne} * {numberTwo} = {answer} - odd");
                    }
                    break;

                case '/':
                case '%':
                    if (operatoR == '/')
                    {
                        if (numberTwo != 0)
                        {
                            answer = (double) numberOne / numberTwo;
                            Console.WriteLine($"{numberOne} / {numberTwo} = {answer:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"Cannot divide {numberOne} by zero");
                        }
                        
                    }
                    else if (operatoR == '%')
                    {
                        if (numberTwo != 0)
                        {
                            answer = numberOne % numberTwo;
                            Console.WriteLine($"{numberOne} % {numberTwo} = {answer}");
                        }
                        else
                        {
                            Console.WriteLine($"Cannot divide {numberOne} by zero");
                        }
                    }
                    break;

            }
        }
    }
}
