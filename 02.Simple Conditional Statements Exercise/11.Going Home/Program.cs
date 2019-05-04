using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Going_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            double kmForGoHome = double.Parse(Console.ReadLine());
            double gasolineFor100km = double.Parse(Console.ReadLine());
            double gosolinePrice = double.Parse(Console.ReadLine());
            double winningMoney = double.Parse(Console.ReadLine());

            double costOfTheCar = (kmForGoHome * gasolineFor100km) / 100;
            double cummonCost = costOfTheCar * gosolinePrice;
            double partOfEveryOne = winningMoney / 5;

            if (winningMoney >= cummonCost)
            {
                Console.WriteLine($"You can go home. {(winningMoney - cummonCost):F2} money left.");
            }
            //Console.WriteLine(cummonCost);
            else
            {
                Console.WriteLine($"Sorry, you cannot go home. Each will receive {(partOfEveryOne):F2} money.");
            }
        }
    }
}
