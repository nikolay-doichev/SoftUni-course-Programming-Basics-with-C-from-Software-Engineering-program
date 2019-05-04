using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int secondsFirstPlayer = int.Parse(Console.ReadLine());
            int secondsSecondPlayer = int.Parse(Console.ReadLine());
            int secondsThirdPlayer = int.Parse(Console.ReadLine());

            int wholETime = secondsFirstPlayer + secondsSecondPlayer + secondsThirdPlayer;
            int minutes = wholETime / 60;
            int seconds = wholETime % 60;
            if (seconds<=10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }


        }
    }
}
