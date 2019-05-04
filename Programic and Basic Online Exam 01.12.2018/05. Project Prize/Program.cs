using System;

namespace _05._Project_Prize
{
    class Program
    {
        static void Main(string[] args)
        {
            int projectParts = int.Parse(Console.ReadLine());
            double partsPrice = double.Parse(Console.ReadLine());
            int sumPoints = 0; 

            for (int i = 1; i <= projectParts; i++)
            {
                int points = int.Parse(Console.ReadLine());
                sumPoints += points;
                if (i%2==0)
                {
                    sumPoints += points;
                }
                
            }
            double sum = partsPrice * sumPoints;
            Console.WriteLine($"The project prize was {sum:F2} lv.");
        }
    }
}
