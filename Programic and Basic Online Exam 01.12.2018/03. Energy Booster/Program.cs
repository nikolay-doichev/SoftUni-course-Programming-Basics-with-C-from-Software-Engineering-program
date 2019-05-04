using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string rangeOfSet = Console.ReadLine();
            int numberSets = int.Parse(Console.ReadLine());
            double purchase = 0;
            double sum = 0;
            double sumWithDiscount = 0;

            if (rangeOfSet=="small")
            {
                if (fruit== "Watermelon")
                {
                    purchase = 56 * numberSets*2;
                    sum += purchase;
                }
                else if (fruit== "Mango")
                {
                    purchase = 36.66 * numberSets*2;
                    sum += purchase;
                }
                else if (fruit== "Pineapple")
                {
                    purchase = 42.10 * numberSets*2;
                    sum += purchase;
                }
                else if (fruit== "Raspberry")
                {
                    purchase = 20 * numberSets*2;
                    sum += purchase;
                }
                
            }
            else if (rangeOfSet=="big")
            {
                if (fruit == "Watermelon")
                {
                    purchase = 28.7 * numberSets*5;
                    sum += purchase;
                }
                else if (fruit == "Mango")
                {
                    purchase = 19.60 * numberSets*5;
                    sum += purchase;
                }
                else if (fruit == "Pineapple")
                {
                    purchase = 24.80 * numberSets*5;
                    sum += purchase;
                }
                else if (fruit == "Raspberry")
                {
                    purchase = 15.20 * numberSets*5;
                    sum += purchase;
                }
            }
            if (sum>=400 && sum <= 1000)
            {
                sumWithDiscount = sum * 0.85;
                Console.WriteLine($"{sumWithDiscount:F2} lv.");
            }
            else if (sum>1000)
            {
                sumWithDiscount = sum * 0.5;
                Console.WriteLine($"{sumWithDiscount:F2} lv.");
            }
            else
            {
                Console.WriteLine($"{sum:F2} lv.");
            }
        }
    }
}
