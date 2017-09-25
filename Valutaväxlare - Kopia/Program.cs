using System;
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
            Console.WriteLine("3: EUR");
            Console.WriteLine("0: close program");

            int.TryParse(Console.ReadLine(), out int temp);
            

            if (temp == 1)
            {
                Console.WriteLine("You chosed SEK");
                Console.WriteLine("In what currency do you want your money? \n");
                Console.WriteLine("1: USD");
                Console.WriteLine("2: EUR");
                int.TryParse(Console.ReadLine(), out temp);
                if (temp == 1)
                {
                    Calculations.FromSekToUSD();
                    ReturnToCurrencyMenu();
                }
                if (temp == 2)
                {
                    Calculations.FromSekToEuro();
                    ReturnToCurrencyMenu();
                }
                else
                {
                    WrongSelection();
                }
            }
            if (temp == 2)
            {
                Console.WriteLine("You chosed USD");
                Console.WriteLine("In what currency do you want your money? \n");
                Console.WriteLine("1: SEK");
                Console.WriteLine("2: EUR");
                int.TryParse(Console.ReadLine(), out temp);
                if (temp == 1)
                {
                    Calculations.FromUSDToSek();
                    ReturnToCurrencyMenu();
                }
                if (temp == 2)
                {
                    Calculations.FromUSDToEuro();
                    ReturnToCurrencyMenu();
                }
                else
                {
                    WrongSelection();
                }
            }
            if (temp == 3)
            {
                Console.WriteLine("You chosed EUR");
                Console.WriteLine("In what currency do you want your money? \n");
                Console.WriteLine("1: SEK");
                Console.WriteLine("2: USD");
                int.TryParse(Console.ReadLine(), out temp);
                if (temp == 1)
                {
                    Calculations.FromEuroToSek();
                    ReturnToCurrencyMenu();
                }
                if (temp == 2)
                {
                    Calculations.FromEuroToUSD();
                    ReturnToCurrencyMenu();
                }
                else
                {
                    WrongSelection();
                }
            }
            if (temp == 0)
            {
                Environment.Exit(0);
            }
            else
            {
                WrongSelection();
            }
        }
        static void ReturnToCurrencyMenu()
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
            if (args.Length == 3)
            {
                switch (args[1])
                {
                    case "SEK":
                        if (args[2] == "USD")
                        {
                            Calculations.FromSekToUSD(Convert.ToDouble(args[0]));
                        }
                        else if (args[2] == "EUR")
                        {
                            Calculations.FromSekToEuro(Convert.ToDouble(args[0]));
                        }
                        break;
                    case "USD":
                        if (args[2] == "SEK")
                        {
                            Calculations.FromUSDToSek(Convert.ToDouble(args[0]));
                        }
                        else if (args[2] == "EUR")
                        {
                            Calculations.FromUSDToEuro(Convert.ToDouble(args[0]));
                        }
                        break;
                    case "EUR":
                        if (args[2] == "SEK")
                        {
                            Calculations.FromEuroToSek(Convert.ToDouble(args[0]));
                        }
                        else if (args[2] == "USD")
                        {
                            Calculations.FromEuroToUSD(Convert.ToDouble(args[0]));
                        }
                        break;
                }
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\tCurrency Converter\n\n");
                CurrencyMenu();
                Console.ReadKey();
                System.Threading.Thread.Sleep(4000);
            }
        }
    }
}
