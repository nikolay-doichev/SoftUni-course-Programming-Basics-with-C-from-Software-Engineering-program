using System;

namespace _05._01._Game_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = string.Empty;
            int sequelOfMatch = 0;
            int penalties = 0;
            double sumDuration = 0;
            double average = 0;

            while (true)
            {
                team = Console.ReadLine();
                int games = int.Parse(Console.ReadLine());
                for (int i = 0; i < games; i++)
                {
                    double durataionOfMatch = double.Parse(Console.ReadLine());
                    sumDuration += durataionOfMatch;
                    if (durataionOfMatch>90 && durataionOfMatch<=120)
                    {
                        sequelOfMatch++;                        
                    }
                    if (durataionOfMatch > 120)
                    {
                        penalties++;
                    }
                }
                average = sumDuration / games;
                Console.WriteLine($"{team} has played {sumDuration} minutes." +
                    $" Average minutes per game: {average:F2}");
                Console.WriteLine($"Games with penalties: {penalties}");
                Console.WriteLine($"Games with additional time: {sequelOfMatch}");
                break;
            }
        }
    }
}
