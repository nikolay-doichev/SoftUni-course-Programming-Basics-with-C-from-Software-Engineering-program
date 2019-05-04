using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numberOfCookers = int.Parse(Console.ReadLine());
            int numberOfTheCakes = int.Parse(Console.ReadLine());
            int numberOfTheWaffles = int.Parse(Console.ReadLine());
            int numberOfthePancakes = int.Parse(Console.ReadLine());

            double priceOfCakes = 45;
            double priceOfWaffles = 5.8;
            double priceOfPancakes = 3.2;

            double amaountOfCakes = priceOfCakes * numberOfTheCakes;
            double amaountOfWaffles = priceOfWaffles * numberOfTheWaffles;
            double amaountOfThePancakes = priceOfPancakes * numberOfthePancakes;
            double totalDailyPrice = (amaountOfCakes + amaountOfThePancakes + amaountOfWaffles)*numberOfCookers;

            double totalPrice = totalDailyPrice * days;
            double totalPriceCost = totalPrice - (totalPrice / 8);
            Console.WriteLine($"{totalPriceCost:f2}");
        }
    }
}
