using System;

namespace _02._Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double averageHeightOfAstronaut = double.Parse(Console.ReadLine());

            double roomForAstronaut = 2 * 2 * (averageHeightOfAstronaut + 0.4);
            double valueOfShip = width * length * height;

            double numberOfAstronauts = Math.Floor(valueOfShip / roomForAstronaut);
          
            if (numberOfAstronauts<3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (numberOfAstronauts>=3 && numberOfAstronauts<=10)
            {
                Console.WriteLine($"The spacecraft holds {numberOfAstronauts} astronauts.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }

        }
    }
}
