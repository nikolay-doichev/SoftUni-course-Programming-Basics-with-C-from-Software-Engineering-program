using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double payments = double.Parse(Console.ReadLine());
            double moneyInBank = 0;
            int payment = 0;

            while (true)
            {
                double deposit = double.Parse(Console.ReadLine());
                if (deposit <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {moneyInBank:F2}");
                    break;
                }
                moneyInBank += deposit;
                Console.WriteLine($"Increase: {deposit:F2}");
                payment++;
                
                if (payment == payments)
                {
                    Console.WriteLine($"Total: {moneyInBank:F2}");
                    break;
                }
            }
            
        }
    }
}
