using System;

namespace _03._Football_Souvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string stock = Console.ReadLine();
            int numberOfStocks = int.Parse(Console.ReadLine());
            double sum = 0;

            if (team != "Argentina" && team != "Brazil" && team != "Croatia" && team != "Denmark")
            {
                Console.WriteLine("Invalid country!");
                return;
            }
            //if (stock != "flags" || stock != "caps" || stock != "posters" || stock != "stickers")
            //{
            //    Console.WriteLine("Invalid stock!");
            //}
            if (team == "Argentina")
            {
                switch (stock)
                {
                    case "flags": sum = numberOfStocks * 3.25; break;
                    case "caps": sum = numberOfStocks * 7.20; break;
                    case "posters": sum = numberOfStocks * 5.10; break;
                    case "stickers": sum = numberOfStocks * 1.25; break;
                    default:
                        Console.WriteLine("Invalid stock!");
                        return;
                }
            }
            else if (team=="Brazil")
            {
                switch (stock)
                {
                    case "flags": sum = numberOfStocks * 4.2; break;
                    case "caps": sum = numberOfStocks * 8.50; break;
                    case "posters": sum = numberOfStocks * 5.35; break;
                    case "stickers": sum = numberOfStocks * 1.20; break;
                    default:
                        Console.WriteLine("Invalid stock!");
                        return;
                }
            }
            else if (team == "Croatia")
            {
                switch (stock)
                {
                    case "flags": sum = numberOfStocks * 2.75; break;
                    case "caps": sum = numberOfStocks * 6.9; break;
                    case "posters": sum = numberOfStocks * 4.95; break;
                    case "stickers": sum = numberOfStocks * 1.10; break;
                    default:
                        Console.WriteLine("Invalid stock!");
                        return;
                }
            }
            else if (team == "Denmark")
            {
                switch (stock)
                {
                    case "flags": sum = numberOfStocks * 3.10; break;
                    case "caps": sum = numberOfStocks * 6.5; break;
                    case "posters": sum = numberOfStocks * 4.80; break;
                    case "stickers": sum = numberOfStocks * 0.90; break;
                    default:
                        Console.WriteLine("Invalid stock!");
                        return;
                }
            }
            Console.WriteLine($"Pepi bought {numberOfStocks} {stock} of {team} for {sum:F2} lv.");
        }
    }
}
