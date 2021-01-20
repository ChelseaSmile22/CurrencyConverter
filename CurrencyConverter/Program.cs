using System;

namespace CurrencyConverter
{
    class Program
    {
        private static double amount = 0;
        private static string currencyFrom = "";
        private static string currencyTo = "";


        private static string Enter()
        {
            Console.WriteLine("Enter amount and currency as \"10 usd to rub\" :  ");
            return Console.ReadLine();
        }

        private static void Parse(string input)
        {
            var InputArray = input.Split(' ');
            amount = Convert.ToDouble(InputArray[0]);
            currencyFrom = InputArray[1];
            currencyTo = InputArray[3];
        }

        private static double CalculateToUsd()
        {
            switch (currencyFrom)
            {
                case "usd": return amount;
                case "eur": return amount * Currencies.EUR;
                case "rub": return amount * Currencies.RUB;
                case "nigger": return amount * Currencies.NIGER;
                case "kike": return amount * Currencies.SHEKEL;
                default: 
                    Console.WriteLine("Введите правильную валюту");
                    return -1;
            }
        }

        private static double CalculateResult(double input)
        {
            switch (currencyTo)
            {
                case "usd": return input;
                case "eur": return input / Currencies.EUR;
                case "rub": return input / Currencies.RUB;
                case "nigger": return input / Currencies.NIGER;
                case "kike": return input / Currencies.SHEKEL;
                default:
                    Console.WriteLine("Введите правильную валюту");
                    return -1;
            }
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Parse(Enter());
                Console.WriteLine($"Выходит, что: { CalculateResult(CalculateToUsd())}");
            }
            
        }
    }
}
