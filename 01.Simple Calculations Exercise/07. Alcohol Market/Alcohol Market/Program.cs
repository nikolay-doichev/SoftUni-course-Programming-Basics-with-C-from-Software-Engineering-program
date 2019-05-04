using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfTheWhiskey = double.Parse(Console.ReadLine());
            double amountOfTheBeer = double.Parse(Console.ReadLine());
            double amountOfTheWine = double.Parse(Console.ReadLine());
            double amountOfTheRakia = double.Parse(Console.ReadLine());
            double amountOfTheWhiskey = double.Parse(Console.ReadLine());

            double rakiAPrice = priceOfTheWhiskey / 2;
            double winEPrece = rakiAPrice * 0.6;
            double beeRPrece = rakiAPrice * 0.2;

            double rakiASum = amountOfTheRakia * rakiAPrice;
            double winESum = amountOfTheWine * winEPrece;
            double beeRSum = amountOfTheBeer * beeRPrece;
            double whiskeySum = amountOfTheWhiskey * priceOfTheWhiskey;

            double totaLSum = rakiASum + winESum + beeRSum + whiskeySum;

            Console.WriteLine($"{totaLSum:f2}");
        }
    }
}
