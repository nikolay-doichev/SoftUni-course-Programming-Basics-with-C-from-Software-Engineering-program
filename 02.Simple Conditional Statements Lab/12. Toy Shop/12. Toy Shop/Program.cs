using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            double travelPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int talkingdolls = int.Parse(Console.ReadLine());
            int flufybears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzlePrice = 2.6;
            double tallkingDollsPrice = 3.0;
            double bearPrice = 4.1;
            double minionsPrice = 8.2;
            double trucksPrice = 2.0;
            double startingSum = puzzles * puzzlePrice + talkingdolls * tallkingDollsPrice +
                               flufybears * bearPrice + minions * minionsPrice + trucks * trucksPrice;
            int toys = puzzles + talkingdolls + flufybears + minions + trucks;

            double discount = 0;
            if (toys >= 50)
            {
                discount = startingSum * 0.25;
            }
            double sumAfterDiscount = startingSum - discount;
            double finalSum = sumAfterDiscount * 0.9;


            if (finalSum >= travelPrice)
            {
                Console.WriteLine($"Yes! {finalSum - travelPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(travelPrice - finalSum):F2} lv needed.");
            }


        }
    }
}
