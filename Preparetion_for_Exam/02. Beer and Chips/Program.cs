using System;

namespace _02._Beer_and_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beerBottles = int.Parse(Console.ReadLine());
            int chepsPackegs = int.Parse(Console.ReadLine());

            double totalMoneyForBeer = 1.2 * beerBottles;
            double moneyForOnePacketChips = totalMoneyForBeer * 0.45;
            double totalMoneyForChips = Math.Ceiling(moneyForOnePacketChips * chepsPackegs);
            double totalCost = totalMoneyForBeer + totalMoneyForChips;

            if (budget>=totalCost)
            {
                Console.WriteLine($"{name} bought a snack and has {(budget-totalCost):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {(totalCost-budget):F2} more leva!");
            }
        }
    }
}
