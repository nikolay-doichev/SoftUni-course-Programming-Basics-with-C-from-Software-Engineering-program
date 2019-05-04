using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double banana = 0;
            double apple = 0;
            double orange = 0;
            double grapefruit = 0;
            double kiwi = 0;
            double pineapple = 0;
            double grapes = 0;
            double price = 0;

            if (day=="Monday" || day== "Tuesday" || day== "Wednesday" || day== "Thursday" || day== "Friday")
            {
                if (fruit== "banana")
                {
                    banana = 2.5;
                    price = quantity * banana;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit== "apple")
                {
                    apple = 1.2;
                    price = quantity * apple;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "orange")
                {
                    orange = 0.85;
                    price = quantity * orange;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "grapefruit")
                {
                    grapefruit = 1.45;
                    price = quantity * grapefruit;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "kiwi")
                {
                    kiwi = 2.7;
                    price = quantity * kiwi;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "pineapple")
                {
                    pineapple = 5.5;
                    price = quantity * pineapple;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "grapes")
                {
                    grapes = 3.85;
                    price = quantity * grapes;
                    Console.WriteLine($"{price:F2}");
                }
                else if (price <= 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day== "Saturday" || day=="Sunday")
            {
                if (fruit == "banana")
                {
                    banana = 2.7;
                    price = quantity * banana;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "apple")
                {
                    apple = 1.25;
                    price = quantity * apple;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "orange")
                {
                    orange = 0.90;
                    price = quantity * orange;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "grapefruit")
                {
                    grapefruit = 1.60;
                    price = quantity * grapefruit;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "kiwi")
                {
                    kiwi = 3;
                    price = quantity * kiwi;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "pineapple")
                {
                    pineapple = 5.6;
                    price = quantity * pineapple;
                    Console.WriteLine($"{price:F2}");
                }
                else if (fruit == "grapes")
                {
                    grapes = 4.20;
                    price = quantity * grapes;
                    Console.WriteLine($"{price:F2}");
                }
                else if(price<=0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
