using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            string city = Console.ReadLine();
            double quality = double.Parse(Console.ReadLine());

            if (city=="Sofia")
            {
                if (productName== "coffee")
                {
                    Console.WriteLine(quality*0.5);
                }
                else if (productName== "water")
                {
                    Console.WriteLine(quality * 0.8);
                }
                else if (productName=="beer")
                {
                    Console.WriteLine(quality * 1.2);
                }
                else if (productName == "sweets")
                {
                    Console.WriteLine(quality * 1.45);
                }
                else if (productName == "peanuts")
                {
                    Console.WriteLine(quality * 1.6);
                }
            }
            else if (city=="Plovdiv")
            {
                if (productName == "coffee")
                {
                    Console.WriteLine(quality * 0.4);
                }
                else if (productName == "water")
                {
                    Console.WriteLine(quality * 0.7);
                }
                else if (productName == "beer")
                {
                    Console.WriteLine(quality * 1.15);
                }
                else if (productName == "sweets")
                {
                    Console.WriteLine(quality * 1.30);
                }
                else if (productName == "peanuts")
                {
                    Console.WriteLine(quality * 1.5);
                }
            }
            else if (city=="Varna")
            {
                if (productName == "coffee")
                {
                    Console.WriteLine(quality * 0.45);
                }
                else if (productName == "water")
                {
                    Console.WriteLine(quality * 0.7);
                }
                else if (productName == "beer")
                {
                    Console.WriteLine(quality * 1.1);
                }
                else if (productName == "sweets")
                {
                    Console.WriteLine(quality * 1.35);
                }
                else if (productName == "peanuts")
                {
                    Console.WriteLine(quality * 1.55);
                }
            }
        }
    }
}
