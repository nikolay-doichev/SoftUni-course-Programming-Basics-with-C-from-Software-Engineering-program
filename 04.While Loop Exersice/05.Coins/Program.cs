using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine()) * 100;
            
            double coin = 0;

            while (money>=200)
            {
                money -= 200;
                coin++;
            }
            while (money >= 100)
            {
                money -= 100;
                coin++;
            }
            while (money >= 50)
            {
                money -= 50;
                coin++;
            }
            while (money >= 20)
            {
                money -= 20;
                coin++;
            }
            while (money >= 10)
            {
                money -= 10;
                coin++;
            }
            while (money >= 5)
            {
                money -= 5;
                coin++;
            }
            while (money >= 2)
            {
                money -= 2;
                coin++;
            }
            while (money >= 1)
            {
                money -= 1;
                coin++;
            }
            Console.WriteLine(coin);
        }
        
    }
}
