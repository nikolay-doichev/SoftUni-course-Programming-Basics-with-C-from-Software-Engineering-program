using System;

namespace _08._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageOfLily = int.Parse(Console.ReadLine());
            double priceOfWashingMachine = double.Parse(Console.ReadLine());
            int priceOfToy = int.Parse(Console.ReadLine());
            int toyCounter = 0;
            int moneyGift = 0;
            int badBrotherCounter = 0;

            for (int i = 1; i <= ageOfLily; i++)
            {
                if (i % 2 == 0)
                {
                    badBrotherCounter++;
                    moneyGift += 10 * badBrotherCounter;

                }
                else
                {
                    toyCounter++;

                }
            }
            double moneyFromToys = toyCounter * priceOfToy;

            double result = (moneyFromToys + moneyGift) - badBrotherCounter;
            if (result >= priceOfWashingMachine)
            {
                Console.WriteLine($"Yes! {(result - priceOfWashingMachine):F2}");
            }
            else
            {
                Console.WriteLine($"No! {(priceOfWashingMachine - result):F2}");
            }
        }
    }
}
