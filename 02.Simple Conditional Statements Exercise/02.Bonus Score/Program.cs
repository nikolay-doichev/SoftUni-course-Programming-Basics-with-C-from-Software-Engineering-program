﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            double bonusScore = 0;

            if (score <= 100)
            {
                bonusScore += 5;

            }
            else if (score > 100 && score < 1000)
            {
                bonusScore = score * 0.2;
            }
            else if (score >=1000)
            {
                bonusScore = score * 0.1;
            }
            if (score % 2 == 0)
            {
                bonusScore++;
            }
            else if (score % 10 == 5)
            {
                bonusScore += 2;
            }
            Console.WriteLine(bonusScore);
            Console.WriteLine(bonusScore+score);
        }
    }
}
