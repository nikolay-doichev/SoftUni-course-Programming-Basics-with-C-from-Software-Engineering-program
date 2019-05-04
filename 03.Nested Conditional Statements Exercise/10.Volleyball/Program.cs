using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine();
            int numberOfHolydays = int.Parse(Console.ReadLine());
            int numberOfWeekendsToGoHome = int.Parse(Console.ReadLine());

            double suturdayGames = (48 - numberOfWeekendsToGoHome)*(3.0/4);
            double holydaysGames = numberOfHolydays * (2.0 / 3);
            double allGames = suturdayGames + numberOfWeekendsToGoHome + holydaysGames;

            if (typeYear=="leap")
            {
                double bonusGames = allGames * 0.15;
                double gamesWithBonus = Math.Floor(allGames + bonusGames);
                Console.WriteLine(gamesWithBonus);
            }
            else if (typeYear=="normal")
            {
                Console.WriteLine($"{Math.Floor(allGames)}");
                
            }
        }
    }
}
