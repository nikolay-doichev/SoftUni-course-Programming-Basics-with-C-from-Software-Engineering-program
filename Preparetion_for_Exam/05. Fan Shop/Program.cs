using System;

namespace _05._Fan_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int itemsCount = int.Parse(Console.ReadLine());
            int sum = 0;
            string singleItems;

            for (int i = 1; i <= itemsCount; i++)
            {
                singleItems = Console.ReadLine();

                switch (singleItems)
                {
                    case "hoodie": sum += 30;break;
                    case "keychain": sum += 4;break;
                    case "T-shirt": sum += 20;break;
                    case "flag": sum += 15;break;
                    default:sum += 1;
                        break;
                }
            }
            if (budget>=sum)
            {
                Console.WriteLine($"You bought {itemsCount} items and left with {budget-sum} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sum-budget} more lv.");
            }
        }
    }
}
