using System;

namespace _04._Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int lenght = number.ToString().Length;

            int firstPartOfTheNumber = 0;
            

            for (int i = 0; i < lenght; i++)
            {

                firstPartOfTheNumber = number % 10;
                if (firstPartOfTheNumber==0)
                {
                    Console.Write("ZERO");
                    
                }
                for (int j = 0; j < firstPartOfTheNumber; j++)
                {
                    int charValue = firstPartOfTheNumber + 33;
                    Console.Write((char)(charValue));
                }
                number =(number- firstPartOfTheNumber) / 10;
                Console.WriteLine();
            }
        }
    }
}
