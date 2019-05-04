using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double purchases = 0;
            double discount = 0;
            double Roses = 5;
            double Dahlias = 3.8;
            double Tulips = 2.8;
            double Narcissus = 3.0;
            double Gladiolus = 2.5;

            if (typeFlower == "Roses")
            {
                if (numberOfFlowers > 80)
                {
                    discount = (numberOfFlowers * Roses) * 0.10;
                    purchases = (numberOfFlowers * Roses) - discount;
                }
                else
                {
                    purchases = numberOfFlowers * Roses;
                }
            }
            else if (typeFlower == "Dahlias")
            {
                if (numberOfFlowers > 90)
                {
                    discount = (numberOfFlowers * Dahlias) * 0.15;
                    purchases = (numberOfFlowers * Dahlias) - discount;
                }
                else
                {
                    purchases = numberOfFlowers * Dahlias;
                }

            }
            else if (typeFlower == "Tulips")
            {
                if (numberOfFlowers > 80)
                {
                    discount = (numberOfFlowers * Tulips) * 0.15;
                    purchases = (numberOfFlowers * Tulips) - discount;
                }
                else
                {
                    purchases = numberOfFlowers * Tulips;
                }

            }
            else if (typeFlower == "Narcissus")
            {
                if (numberOfFlowers < 120)
                {
                    discount = (numberOfFlowers * Narcissus) * 0.15;
                    purchases = (numberOfFlowers * Narcissus) + discount;
                }
                else
                {
                    purchases = numberOfFlowers * Narcissus;
                }

            }
            else if (typeFlower == "Gladiolus")
            {
                if (numberOfFlowers < 80)
                {
                    discount = (numberOfFlowers * Gladiolus) * 0.20;
                    purchases = (numberOfFlowers * Gladiolus) + discount;
                }
                else
                {
                    purchases = numberOfFlowers * Gladiolus;
                }

            }
            if (budget >= purchases)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeFlower} and {(budget - purchases):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(purchases - budget):F2} leva more.");
            }

        }
    }
}
