using System;

namespace _07._Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueName = 0;
            int maxName = int.MinValue;
            string maxNameWord = string.Empty;
            while (true)
            {
                string name = Console.ReadLine();
                if (name=="STOP")
                {
                    Console.WriteLine($"Winner is {maxNameWord} - {maxName}!");
                    break;
                }
                for (int i = 0; i < name.Length; i++)
                {
                    char valueLeter = name[i];                    
                    valueName  += valueLeter;
                }
                if (valueName>maxName)
                {
                    maxName = valueName;
                    maxNameWord = name;
                    valueName = 0;
                }
                valueName = 0;

            }
        }
    }
}
