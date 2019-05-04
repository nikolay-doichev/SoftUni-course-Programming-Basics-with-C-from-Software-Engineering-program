using System;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradus = int.Parse(Console.ReadLine());
            string typeOfTheDay = Console.ReadLine().ToLower();

            if (gradus >= 10 && gradus <= 18)
            {
                if (typeOfTheDay == "morning")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Sweatshirt and Sneakers.");
                }
                else if (typeOfTheDay == "afternoon")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Shirt and Moccasins.");
                }
                else if (typeOfTheDay == "evening")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Shirt and Moccasins.");
                }

            }
            else if (gradus>18 && gradus <= 24)
            {
                if (typeOfTheDay == "morning")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Shirt and Moccasins.");
                }
                else if (typeOfTheDay == "afternoon")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your T-Shirt and Sandals.");
                }
                else if (typeOfTheDay == "evening")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Shirt and Moccasins.");
                }

            }
            else if (gradus >= 25)
            {
                if (typeOfTheDay == "morning")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your T-Shirt and Sandals.");
                }
                else if (typeOfTheDay == "afternoon")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Swim Suit and Barefoot.");
                }
                else if (typeOfTheDay == "evening")
                {
                    Console.WriteLine($"It's {gradus} degrees, get your Shirt and Moccasins.");
                }

            }
        }
    }
}
