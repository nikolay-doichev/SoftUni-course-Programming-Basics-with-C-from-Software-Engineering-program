using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double fishermansNumber = double.Parse(Console.ReadLine());
            double price = 0;

            if (season == "Spring")
            {
                price = 3000;
            }
            if (season == "Summer")
            {
                price = 4200;
            }
            if (season == "Autumn")
            {
                price = 4200;
            }
            if (season == "Winter")
            {
                price = 2600;
            }
            if (fishermansNumber <= 6)
            {
                price *= 0.9;
            }
            else if (fishermansNumber <= 11)
            {
                price *= 0.85;
            }
            else if (fishermansNumber > 12)
            {
                price *= 0.75;
            }
            if (fishermansNumber%2==0)
            {
                if (season != "Autumn")
                {
                    price *= 0.95;
                }
            }
            if (price <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:F2} leva.");
            }

        }
    }
}
