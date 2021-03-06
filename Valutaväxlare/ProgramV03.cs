﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Valutaväxlare
{
    public class Program
    {
        
        public static void CurrencyMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What currency do you want to exchange? \nPress 1,2 or 3? \n");
            Console.WriteLine("1: SEK");
            Console.WriteLine("2: USD");
            Console.WriteLine("3: Euro");
            Console.WriteLine("0: close program");
            int.TryParse(Console.ReadLine(), out int menu);

            /// Menu option for exchanging SEK 
            if (menu == 1)
            {
                Console.WriteLine("You chosed SEK");
                Console.WriteLine("In what currency do you want your money? \n");
                Console.WriteLine("1: USD");
                Console.WriteLine("2: Euro");
                int.TryParse(Console.ReadLine(), out menu);
                if (menu == 1)
                {
                    Calculations.FromSekToUSD();
                    ReturnToCurrencyMenu();
                }
                if (menu == 2)
                {
                    Calculations.FromSekToEuro();
                    ReturnToCurrencyMenu();
                }
                else
                {
                    WrongSelection();
                }
            }
            /// Menu option for exchanging USD
            if (menu == 2)
            {
                Console.WriteLine("You chosed USD");
                Console.WriteLine("In what currency do you want your money? \n");
                Console.WriteLine("1: SEK");
                Console.WriteLine("2: Euro");
                int.TryParse(Console.ReadLine(), out menu);
                if (menu == 1)
                {
                    Calculations.FromUSDToSek();
                    ReturnToCurrencyMenu();
                }
                if (menu == 2)
                {
                    Calculations.FromUSDToEuro();
                    ReturnToCurrencyMenu();
                }
                else
                {
                    WrongSelection();
                }
            }
            /// Menu option for exchanging Euro 
            if (menu == 3)
            {
                Console.WriteLine("You chosed Euro");
                Console.WriteLine("In what currency do you want your money? \n");
                Console.WriteLine("1: SEK");
                Console.WriteLine("2: USD");
                int.TryParse(Console.ReadLine(), out menu);
                if (menu == 1)
                {
                    Calculations.FromEuroToSek();
                    ReturnToCurrencyMenu();
                }
                if (menu == 2)
                {
                    Calculations.FromEuroToUSD();
                    ReturnToCurrencyMenu();
                }
                else
                {
                    WrongSelection();
                }
            }
            /// Menu option to close application 
            if (menu == 0)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not correct format, try again. \n \n ");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                CurrencyMenu();
                while(true)
                {
                    ConsoleReadKey();
                }
            }
        }
        public void ReturnToCurrencyMenu()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            CurrencyMenu();
        }
        
        static void WrongSelection()
        { 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Not correct format, try again. \n \n ");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            CurrencyMenu();
        }
        static void Main(string[] args)
        {
           
        }
    }
}
