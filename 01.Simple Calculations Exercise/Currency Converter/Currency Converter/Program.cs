using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string inputCurse = Console.ReadLine();
            string outputCurse = Console.ReadLine();
            double result = 0;
            double USD = 1.79549;
            double EUR = 1.95583;
            double GBP = 2.53405;
            if (inputCurse == "BGN")
            {
                if (outputCurse == "USD")
                {
                    result = money / USD;
                }
                else if (outputCurse == "EUR")
                {
                    result = money / EUR;
                }
                else if (outputCurse == "GPB")
                {
                    result = money / GBP;
                }
            }
            if (inputCurse == "USD")
            {
                if (outputCurse == "BGN")
                {
                    result = money * USD;
                }
                else if (outputCurse == "EUR")
                {
                    result = money *( USD / EUR);
                }
                else if (outputCurse == "GPB")
                {
                    result = money *( USD / GBP);
                }
            }
                    if (inputCurse=="GBP")
                    {
                        if (outputCurse=="BGN")
                        {
                            result = money * GBP;
                        }
                        else if (outputCurse=="USD")
                        {
                            result = money * (GBP / USD);
                        }
                        else if (outputCurse=="EUR")
                        {
                            result = money * (GBP / EUR);
                        }
                    }
            if (inputCurse=="EUR")
            {
                if (outputCurse=="BGN")
                {
                    result = money * EUR;
                }
                else if (outputCurse=="USD")
                {
                    result = money * (EUR / USD);
                }
                else if (outputCurse=="GBP")
                {
                    result = money * (EUR / GBP);
                }
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
