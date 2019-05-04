using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacantion = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            int counter = 0;
            int counterSpend = 0;
                   

            while (true)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                counter++;
                if (command=="spend")
                {
                    counterSpend++;
                    if (counterSpend == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine(counter);
                        return;
                    }
                    currentMoney -= money;                    
                    if (currentMoney < 0)
                    {
                        currentMoney = 0;
                    }                 
                                   
                }

                else if (command=="save")
                {
                    counterSpend = 0;
                    currentMoney += money;
                   
                }
                if (currentMoney >= moneyForVacantion)
                {
                    Console.WriteLine($"You saved the money for {counter} days.");
                    break;
                }
                

            }
            
        }
    }
}
