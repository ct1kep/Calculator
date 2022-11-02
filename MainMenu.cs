﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MainMenu
    {
        public void ShowMenu()
        {
            Console.WriteLine("Для выбора приложения введите цифру, которая соответствует нужному пункту в меню.\n1.Простой калькулятор\n2.Калькулятор возраста\n3.Калькулятор налогов");
            string mainchoice = Console.ReadLine();
            
            if(mainchoice == "1")
            {
                Console.Clear();
                Console.WriteLine("Простой калькулятор");
                Console.ReadKey();
            }
            else if(mainchoice == "2")
            {
                Console.Clear();
                Console.WriteLine("Калькулятор возраста");
                Console.ReadKey();
            }
            else if (mainchoice == "3")
            {
                Console.Clear();
                TaxCalculator taxCalculator = new TaxCalculator();
                taxCalculator.Show();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("------------------------------\nНе удалось выбрать калькулятор\n------------------------------");
                ShowMenu();
            }
        }
    }
}
