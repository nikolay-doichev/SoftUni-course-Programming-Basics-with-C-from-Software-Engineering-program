using System;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string tonw = Console.ReadLine();
            double money = double.Parse(Console.ReadLine());
            double percent = 0;
            double comision = 0;
            if (tonw== "Sofia")
            {
                if (money>=0 && money<=500)
                {
                    percent = 0.05;
                    comision = money * percent;
                    Console.WriteLine($"{comision:F2}");
                }
                else if (money > 500 && money <= 1000)
                {
                    percent = 0.07;
                    comision = money * percent;
                    Console.WriteLine($"{comision:F2}");
                }
                else if (money > 100 && money <= 10000)
                {
                    percent = 0.08;
                    comision = money * percent;
                    Console.WriteLine($"{comision:F2}");
                }
                else if (money > 10000)
                {
                    percent = 0.12;
                    comision = money * percent;
                    Console.WriteLine($"{comision:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (tonw == "Varna")
            {
                if (money >= 0 && money <= 500)
                {
                    percent = 0.045;
                    comision = money * percent;
                    Console.WriteLine($"{comision:F2}");
                }
                else if (money > 500 && money <= 1000)
                {
                    percent = 0.075;
                    comision = money * percent;
                    Console.WriteLine($"{comision:F2}");
                }
                else if (money > 100 && money <= 10000)
                {
                    percent = 0.1;
                    comision = money * percent;
                    Console.WriteLine($"{comision:F2}");
                }
                else if (money > 10000)
                {
                    percent = 0.13;
                    comision = money * percent;
                    Console.WriteLine($"{comision:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (tonw == "Plovdiv")
            {
                if (money >= 0 && money <= 500)
                {
                    percent = 0.055;
                    comision = money * percent;
                    Console.WriteLine($"{comision:F2}");
                }
                else if (money > 500 && money <= 1000)
                {
                    percent = 0.08;
                    comision = money * percent;
                    Console.WriteLine($"{comision:F2}");
                }
                else if (money > 100 && money <= 10000)
                {
                    percent = 0.12;
                    comision = money * percent;
                    Console.WriteLine($"{comision:F2}");
                }
                else if (money > 10000)
                {
                    percent = 0.145;
                    comision = money * percent;
                    Console.WriteLine($"{comision:F2}");
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
