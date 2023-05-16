using System;

namespace _03.StreamOfLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();
            bool cIsFound = false;
            bool oIsFound = false;
            bool nIsFound = false;
            string word = string.Empty;
            string allword = string.Empty;
            int sign = 0;
            while (symbol != "End") 
            {                
                char n = char.Parse(symbol);
                if (n >= 'A' && n <= 'Z' || n >= 'a' && n <= 'z')
                {
                    if (n == 'c')
                    {
                        if (cIsFound)
                        {
                            word += n;
                        }
                        else
                        {
                            sign++;
                            cIsFound = true;
                        }
                    
                    }
                    else if (n == 'o')
                    {
                        if(oIsFound)
                        {
                            word += n;
                        }
                        else
                        {
                            sign++;
                            oIsFound = true;
                        }                        
                    }
                    else if (n == 'n')
                    { 
                        if (nIsFound)
                        {
                            word += n;
                        }
                        else
                        {
                            sign++;
                            nIsFound = true;
                        }                         
                    }
                    else
                    {
                        word += n;
                    }
                }
                if (sign == 3)
                {
                    sign = 0;
                    allword += word +" ";  
                    word = string.Empty;
                    cIsFound = false;
                    oIsFound = false;
                    nIsFound = false;
                    
                }
                symbol = Console.ReadLine();
            }
            Console.WriteLine(allword);
        }
    }
}
