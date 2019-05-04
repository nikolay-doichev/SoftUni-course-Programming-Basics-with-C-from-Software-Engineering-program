using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            double days = double.Parse(Console.ReadLine());

            double costApartment = 0.0;
            
            double costStudio = 0.0;

            if (mounth == "May" || mounth == "October")
            {
                if (days>7 && days<=14)
                {
                    costApartment = days * 65.0;
                    costStudio = days * 50.0*0.95;
                    Console.WriteLine($"Apartment: {costApartment:F2} lv.");
                    Console.WriteLine($"Studio: {costStudio:F2} lv.");
                }
                else if (days>14)
                {
                    costApartment = days * 65.0*0.90;
                    costStudio = days * 50.0 * 0.70;
                    Console.WriteLine($"Apartment: {costApartment:F2} lv.");
                    Console.WriteLine($"Studio: {costStudio:F2} lv.");
                }
                else if (days<=7 )
                {
                    costApartment = days * 65.0;
                    costStudio = days * 50.0 ;
                    Console.WriteLine($"Apartment: {costApartment:F2} lv.");
                    Console.WriteLine($"Studio: {costStudio:F2} lv.");
                }

            }
            else if (mounth == "June" || mounth == "September")
            {
                if (days>14)
                {
                    costApartment = days * 68.7 * 0.90;
                    costStudio = days * 75.20 * 0.80;
                    Console.WriteLine($"Apartment: {costApartment:F2} lv.");
                    Console.WriteLine($"Studio: {costStudio:F2} lv.");
                }
                else if (days<=14)
                {
                    costApartment = days * 68.7 ;
                    costStudio = days * 75.2;
                    Console.WriteLine($"Apartment: {costApartment:F2} lv.");
                    Console.WriteLine($"Studio: {costStudio:F2} lv.");
                }
            }
            else if (mounth == "July" || mounth == "August")
            {
                if (days>14)
                {
                    costApartment = days * 77.0*0.9;
                    costStudio = days * 76.0;
                    Console.WriteLine($"Apartment: {costApartment:F2} lv.");
                    Console.WriteLine($"Studio: {costStudio:F2} lv.");
                }
                else if (days > 0 && days <= 14)
                {
                    costApartment = days * 77.0;
                    costStudio = days * 76.0;
                    Console.WriteLine($"Apartment: {costApartment:F2} lv.");
                    Console.WriteLine($"Studio: {costStudio:F2} lv.");
                }
                
            }
        }
    }
}
