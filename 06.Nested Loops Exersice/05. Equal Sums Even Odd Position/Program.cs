using System;

namespace _05._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            
            

            for (int i = a; i <= b; i++)
            {
                string num = i.ToString();
                int lenght = num.Length;
                int sumOdd = 0;
                int sumEven = 0;
                int process = i;

                for (int k = 0; k < lenght; k++)
                {
                    int modul = process % 10;
                    if (k%2 !=0)
                    {
                        sumEven+=modul;
                    }
                    else
                    {
                        sumOdd+=modul;
                    }
                    process = process / 10;
                }
                if (sumOdd==sumEven)
                {
                    Console.Write(i + " ");
                }
               
            }
        }
    }
}
