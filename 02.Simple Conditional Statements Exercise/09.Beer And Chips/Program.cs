using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer_And_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheFan = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int numberOfBottles = int.Parse(Console.ReadLine());
            double numberOfPacketChips = double.Parse(Console.ReadLine());

            double priceBeer = 1.2;
            double priceChips = (numberOfBottles * priceBeer) * 0.45;
            double wholeChipsMoney = Math.Ceiling(priceChips * numberOfPacketChips);
            double wholeBeerMoney = priceBeer * numberOfBottles;
            double wholeSum = wholeChipsMoney + wholeBeerMoney;
            if (budget >= wholeSum)
            {
                Console.WriteLine($"{nameOfTheFan} bought a snack and has {(budget - wholeSum):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"{nameOfTheFan} needs {(wholeSum - budget):F2} more leva!");
            }
        }
    }
}
