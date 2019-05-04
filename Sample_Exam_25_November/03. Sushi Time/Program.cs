using System;

namespace _03._Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheSushi = Console.ReadLine();
            string nameOfTheRestourant = Console.ReadLine();
            int numberOfPortion = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double purchaseValue = 0;
            double totalPrice = 0;

            if (nameOfTheRestourant!= "Sushi Zone" && nameOfTheRestourant!= "Sushi Time"
                && nameOfTheRestourant!= "Sushi Bar" && nameOfTheRestourant!="Asian Pub")
            {
                Console.WriteLine($"{nameOfTheRestourant} is invalid restaurant!");
                return;
            }
            if (nameOfTheRestourant== "Sushi Zone")
            {
                switch (nameOfTheSushi)
                {
                    case "sashimi":purchaseValue += 4.99*numberOfPortion;break;
                    case "maki":purchaseValue += 5.29*numberOfPortion;break;
                    case "uramaki": purchaseValue += 5.99*numberOfPortion;break;
                    case "temaki": purchaseValue += 4.29*numberOfPortion;break;
                    default:
                        break;
                }
            }
            else if (nameOfTheRestourant == "Sushi Time")
            {
                switch (nameOfTheSushi)
                {
                    case "sashimi": purchaseValue += 5.49 * numberOfPortion; break;
                    case "maki": purchaseValue += 4.69 * numberOfPortion; break;
                    case "uramaki": purchaseValue += 4.49 * numberOfPortion; break;
                    case "temaki": purchaseValue += 5.19 * numberOfPortion; break;
                    default:
                        break;
                }
            }
            else if (nameOfTheRestourant == "Sushi Bar")
            {
                switch (nameOfTheSushi)
                {
                    case "sashimi": purchaseValue += 5.25 * numberOfPortion; break;
                    case "maki": purchaseValue += 5.55 * numberOfPortion; break;
                    case "uramaki": purchaseValue += 6.25 * numberOfPortion; break;
                    case "temaki": purchaseValue += 4.75 * numberOfPortion; break;
                    default:
                        break;
                }
            }
            else if (nameOfTheRestourant == "Asian Pub")
            {
                switch (nameOfTheSushi)
                {
                    case "sashimi": purchaseValue += 4.50 * numberOfPortion; break;
                    case "maki": purchaseValue += 4.80 * numberOfPortion; break;
                    case "uramaki": purchaseValue += 5.5 * numberOfPortion; break;
                    case "temaki": purchaseValue += 5.5 * numberOfPortion; break;
                    default:
                        break;
                }
            }
            if (symbol=="Y")
            {
                totalPrice = Math.Ceiling(purchaseValue * 1.2);
            }           

            if (symbol=="N")
            {
                totalPrice = Math.Ceiling(purchaseValue);
            }
            Console.WriteLine($"Total price: {totalPrice} lv.");
        }
    }
}
