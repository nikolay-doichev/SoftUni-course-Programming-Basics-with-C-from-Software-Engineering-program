using System;

namespace Preparetion_for_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int sectors = int.Parse(Console.ReadLine());
            int diapason = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double totalIncome = diapason * ticketPrice;
            double incomeForSingleSector = totalIncome / sectors;
            double moneyForCharity = (totalIncome - (incomeForSingleSector * 0.75)) / 8;

            Console.WriteLine($"Total income - {totalIncome:F2} BGN");
            Console.WriteLine($"Money for charity - {moneyForCharity:F2} BGN");
        }
    }
}
