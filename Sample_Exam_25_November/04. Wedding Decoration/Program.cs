using System;

namespace _04._Wedding_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            double balloons = 0.1;
            double flowers = 1.5;
            double candles = 0.5;
            double ribbon = 2;
            double purchase = 0;
            double totalPurchase=0;

            int balloonsCounter = 0;
            int flowersCounter = 0;
            int candlesCounter = 0;
            int ribbonCounter = 0;

            double budget = double.Parse(Console.ReadLine());
            string stock = string.Empty;

            while (true)
            {
                stock = Console.ReadLine();
                if (stock == "stop")
                {
                    Console.WriteLine($"Spend money: {totalPurchase:F2}");
                    Console.WriteLine($"Money left: {budget:F2}");
                    Console.WriteLine($"Purchased decoration is {balloonsCounter} balloons," +
                        $" {ribbonCounter} m ribbon, {flowersCounter} flowers and {candlesCounter} candles.");
                    return;
                }
                int stockCount = int.Parse(Console.ReadLine());

                if (stock=="balloons")
                {
                    purchase = balloons * stockCount;
                    budget -= purchase;
                    balloonsCounter += stockCount;
                }
                else if (stock=="candles")
                {
                    purchase = candles * stockCount;
                    budget -= purchase;
                    candlesCounter += stockCount;
                }
                else if (stock== "flowers")
                {
                    purchase = flowers * stockCount;
                    budget -= purchase;
                    flowersCounter += stockCount;
                }
                else if (stock== "ribbon")
                {
                    purchase = ribbon * stockCount;
                    budget -= purchase;
                    ribbonCounter += stockCount;
                }
                totalPurchase = balloons * balloonsCounter + ribbon * ribbonCounter + candles * candlesCounter + flowers * flowersCounter;
                if (budget<=0)
                {
                    Console.WriteLine($"All money is spent!");
                    Console.WriteLine($"Purchased decoration is {balloonsCounter} balloons," +
                        $" {ribbonCounter} m ribbon, {flowersCounter} flowers and {candlesCounter} candles.");
                    return;
                }
                
            }
        }
    }
}
