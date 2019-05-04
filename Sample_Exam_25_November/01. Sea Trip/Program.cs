using System;

namespace Sample_Exam_25_November
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFood = double.Parse(Console.ReadLine());
            double moneyForSuvenirs = double.Parse(Console.ReadLine());
            double moneyForHotelPerDay = double.Parse(Console.ReadLine());

            double moneyForTravel = 54.39;

            double firstDayCost = moneyForHotelPerDay * 0.9;
            double secondDayCost = moneyForHotelPerDay * 0.85;
            double thirtDayCost = moneyForHotelPerDay * 0.8;

            double allCost = moneyForTravel + 3 * moneyForFood + 3 * moneyForSuvenirs + firstDayCost + secondDayCost + thirtDayCost;

            Console.WriteLine($"Money needed: {allCost:F2}");
        }
    }
}
