using System;

namespace _06._Safe_Passwords_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int counterDiapason = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 35; i < 55;)
            {              
                for (int j = 64; j < 96;)
                {
                 
                    for (int x = 1; x <= a; x++)
                    {
                        
                        for (int y = 1; y <= b; y++)
                        {
                            counter++;                            
                                Console.Write($"{(char)i}{(char)j}{x}{y}{(char)j}{(char)i}|");
                                
                                if (x == a && y == b)
                                {
                                    return;
                                }                                
                                i++;
                                j++;
                                if (i > 55)
                                {
                                    i = 35;
                                }
                                if (j > 96)
                                {
                                    j = 64;
                                }
                            if (counter>=counterDiapason)
                            {
                                return;
                            }                                                      
                          
                        }
                    }
                }
            }
        }
    }
}
