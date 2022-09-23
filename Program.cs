﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую Вас в калькуляторе доходов!");
            Console.WriteLine("Введите сумму Вашего месячного дохода в гривнах (используя числовой формат записи)");
            string profit = Console.ReadLine();
            decimal profitInDecimal = Convert.ToDecimal(profit);
            decimal singleTaxPercentage = 0.05m;
            decimal singleTax = profitInDecimal * singleTaxPercentage;
            decimal singleDepositPercentage = 0.22m;
            int minProfit = 6500;
            decimal singleDeposit = minProfit * singleDepositPercentage;
            decimal profitAfterTaxes = profitInDecimal - singleTax - singleDeposit;

            Console.WriteLine("Сумма вашего дохода составляет " + profitInDecimal + "грн");
            Console.WriteLine("Единый налог составит " + singleTax + "грн");
            Console.WriteLine("Единый социальный вклад составит " + singleDeposit + "грн");
            Console.WriteLine("Ваш доход за вычетом налогов составит " + profitAfterTaxes + "грн");

            Console.ReadKey();

        }
    }
}
