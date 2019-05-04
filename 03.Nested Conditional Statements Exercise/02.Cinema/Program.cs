using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeTicket = Console.ReadLine();

            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double ticketPricePremiere = 12.00;
            double ticketPriceNormal = 7.50;
            double ticketPriceDiscount = 5.00;


            int numberOfSeats = row * column; 

            if (typeTicket== "Premiere")
            {
                double income = numberOfSeats * ticketPricePremiere;
                Console.WriteLine($"{income:F2} leva");
            }
            else if (typeTicket== "Normal")
            {
                double income = numberOfSeats * ticketPriceNormal;
                Console.WriteLine($"{income:F2} leva");
            }
            else if (typeTicket== "Discount")
            {
                double income = numberOfSeats * ticketPriceDiscount;
                Console.WriteLine($"{income:F2} leva");
            }
        }
    }
}
