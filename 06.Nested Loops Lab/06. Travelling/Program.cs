using System;

namespace _06._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {   
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                double budget = double.Parse(Console.ReadLine());
                double currentBudget = 0;
                while (currentBudget<budget)
                {              
                    double earnMoney = double.Parse(Console.ReadLine());
                    currentBudget += earnMoney;                     
                }
                Console.WriteLine($"Going to {input}!");
            }
        }
    }
}
