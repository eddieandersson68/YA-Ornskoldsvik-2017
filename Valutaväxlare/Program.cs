using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Valutaväxlare
{
    class Program
    {
        static void PrintStartMenu()
        {
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            CurrencyMenu();



            //switch (temp)
            //{
            //    case 1:
            //        FromSekToUSD();
            //        //Console.ReadKey();
            //        //Console.Clear();
            //        //Menu();
            //        break;
            //    case 2:
            //        FromUSDToEuro();
            //        break;
            //    case 3:
            //        FromSekToEuro();
            //        break;
            //    case 0:
            //        Environment.Exit(0);
            //        break;
            //    default:
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Not correct format, try again. ");
            //        break;
            //}
        }
        // My Method for SEK transactions
        static void CurrencyMenu()
        {

            int temp = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What currency do you want to excange? \nPress 1,2 or 3? \n");


            Console.WriteLine("1: SEK");
            Console.WriteLine("2: USD");
            Console.WriteLine("3: Euro");
            //Console.WriteLine("4: Go back up to main menu");
            Console.WriteLine("0: close program");
            int.TryParse(Console.ReadLine(), out temp);
            if (temp == 1)
            {
                Console.WriteLine("You chosed SEK");
                Console.WriteLine("In what currency do you want your money? \n");
                Console.WriteLine("1: USD");
                Console.WriteLine("2: Euro");
                int.TryParse(Console.ReadLine(), out temp);
                if (temp == 1)
                {
                    FromSekToUSD();
                }
                if (temp == 2)
                {
                    FromSekToEuro();
                }
            }
            if (temp == 2)
            {
                Console.WriteLine("You chosed USD");
                Console.WriteLine("In what currency do you want your money? \n");
                Console.WriteLine("1: SEK");
                Console.WriteLine("2: Euro");
                int.TryParse(Console.ReadLine(), out temp);
                if (temp == 1)
                {
                    USDToSek();
                }
                if (temp == 2)
                {
                    FromUSDToEuro();
                }
            }
            if (temp == 3)
            {
                Console.WriteLine("You chosed Euro");
                Console.WriteLine("In what currency do you want your money? \n");
                Console.WriteLine("1: SEK");
                Console.WriteLine("2: USD");
                int.TryParse(Console.ReadLine(), out temp);
                if (temp == 1)
                {
                    EuroToSek();
                }
                if(temp == 2)
                {
                    EuroToUSD();
                }
                

            }
            if (temp == 0)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not correct format, try again. ");
            }


        }
        /*static int FromSEKCurrencyMenu()
        {
            int temp = 0; // Temp value to use for a menu
                          //double SEKamount = 0; // Value to hold the amount of the entered amount

            //double.TryParse(Console.ReadLine(), out SEKamount);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("In what currency do you want your money? \n");
            Console.WriteLine("1: USD");
            Console.WriteLine("2: Euro");
            Console.WriteLine("3: Go back up to main menu");
            Console.WriteLine("0: close program");

            int.TryParse(Console.ReadLine(), out temp);
            //do
            //{
            switch (temp)
            {
                case 1:
                    FromSekToUSD();
                    //Console.ReadKey();
                    //Console.Clear();
                    //Menu();
                    break;
                case 2:
                    SekToEuro();
                    break;
                case 3:
                    // GO back!!!
                    return 0;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not correct format, try again. ");
                    break;
            }
            //} while (temp != 0);
            //return;
            return 1;
        }

        // My Method for USD transactions
        static int FromUSDCurrencyMenu()
        {
            int temp = 0; // Temp value to use for a menu
                          //double SEKamount = 0; // Value to hold the amount of the entered amount

            //double.TryParse(Console.ReadLine(), out SEKamount);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("In what currency do you want your money? ");
            Console.WriteLine("1: SEK");
            Console.WriteLine("2: Euro");
            Console.WriteLine("3: Go back up to main menu");
            Console.WriteLine("0: close program");

            int.TryParse(Console.ReadLine(), out temp);
            //do
            //{
            switch (temp)
            {
                case 1:
                    USDToSek();
                    //Console.ReadKey();
                    //Console.Clear();
                    //Menu();
                    break;
                case 2:
                    USDToEuro();
                    break;
                case 3:
                    return 0;
                //Console.Clear();
                //PrintStartMenu();
                //break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not correct format, try again. ");
                    break;
            }
            //} while (temp != 0);
            return 1;
        }
        // My Method for Euro transactions
        static int FromEuroCurrencyMenu()
        {
            int temp = 0; // Temp value to use for a menu
                          //double SEKamount = 0; // Value to hold the amount of the entered amount

            //double.TryParse(Console.ReadLine(), out SEKamount);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("In what currency do you want your money? ");
            Console.WriteLine("1: SEK");
            Console.WriteLine("2: USD");
            Console.WriteLine("3: Go back up to main menu");
            Console.WriteLine("0: close program");

            int.TryParse(Console.ReadLine(), out temp);
            //do
            //{
            switch (temp)
            {
                case 1:
                    EuroToSek();
                    //Console.ReadKey();
                    //Console.Clear();
                    //Menu();
                    break;
                case 2:
                    EuroToUSD();
                    break;
                case 3:
                    return 0;
                //Console.Clear();
                //PrintStartMenu();

                case 0:
                    Environment.Exit(0);
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not correct format, try again. ");
                    break;
            }
            //} while (temp != 0);
            return 1;
        }
        */
        /// ////////////////////////////////////////////////////////////////////////////////////////////////
        /// Method for converting SEK to USD
        static void FromSekToUSD()
        {
            double USDOut = 0;
            Double SEK, USD;
            Console.WriteLine("Enter the amount of SEK you want to exchange: \n");
            SEK = Double.Parse(Console.ReadLine());
            USD = SEK / 8.08;

            Console.WriteLine("{0} SEK Equals to  {1} USD \n\n", SEK, Math.Round(USD, 2));
            if (USD > 100)
                for (int i = 0; i > 100; i++)
                {

                }
            {
                USDOut = USD / 50;
                Console.WriteLine("You get " + Math.Round(USDOut, 2) + " $50 Notes");
            }
            if (USDOut < 50)
            {
                USDOut = USD / 20;

                int nrOf20Dollars = (int)(USD / 20);
                double rest = USD - (nrOf20Dollars * 20);


                Console.WriteLine("You get " + Math.Round(USDOut, 2) + " $20 Notes \n");
                Console.WriteLine("You get " + nrOf20Dollars + " $20 Dollar notes and " + Math.Round(rest, 2));
            }
            if (USDOut < 20)
            {
                USDOut = USD / 10;
                Console.WriteLine("You get " + Math.Round(USDOut, 2) + " $10 Notes");
            }
            if (USDOut < 10)
            {
                USDOut = USD / 5;
                Console.WriteLine("You get " + Math.Round(USDOut, 2) + " $5 Notes");
            }
            if (USDOut < 5)
            {
                USDOut = USD / 2;
                Console.WriteLine("You get " + Math.Round(USDOut, 2) + " $2 Notes");
            }
            if (USDOut < 2)
            {
                USDOut = USD / 1;
                Console.WriteLine("You get " + Math.Round(USDOut, 2) + " $1 Notes");
            }
            Console.ReadKey();
            Console.Clear();
            PrintStartMenu();
        }
        static void FromSekToEuro()
        {
            Double SEK, EURO;
            Console.WriteLine("Enter the amount of SEK you want to exchange: \n");
            SEK = Double.Parse(Console.ReadLine());
            EURO = SEK / 9.48;

            Console.WriteLine("{0} SEK Equals to  {1} EURO \n\n", SEK, Math.Round(EURO, 2));
            Console.ReadKey();
            Console.Clear();
            PrintStartMenu();
        }
        /// /////////////////////////////////////////////////////////////////////////////////////////////////
        /// Method for converting USD to SEK
        static void USDToSek()
        {
            Double USD, SEK;
            Console.WriteLine("Enter the amount of USD you want to exchange: \n");
            USD = Double.Parse(Console.ReadLine());
            SEK = USD * 8.08;
            Console.WriteLine("{0} USD Equals {1} SEK ", USD, Math.Round(SEK, 2));
            Console.WriteLine("Hit a key to go back to start menu");
            Console.ReadKey();
            Console.Clear();
            PrintStartMenu();
        }
        static void FromUSDToEuro()
        {
            Double USD, EURO;
            Console.WriteLine("Enter the amount of USD you want to exchange: \n");
            USD = Double.Parse(Console.ReadLine());
            EURO = USD / 1.4;
            Console.WriteLine("{0} USD Equals {1} Euro ", USD, Math.Round(EURO, 2));
            Console.WriteLine("Hit a key to go back to start menu");
            Console.ReadKey();
            //Console.Clear();
            //Menu();
        }
        /// /////////////////////////////////////////////////////////////////////////////////////
        /// Method for converting Euro to SEK
        static void EuroToSek()
        {
            Double Euro, SEK;
            Console.WriteLine("Enter the Euro Amount: ");
            Euro = Double.Parse(Console.ReadLine());
            SEK = Euro * 9.48;
            Console.WriteLine("{0} Euro Equals {1} SEK ", Euro, Math.Round(SEK, 2));
            Console.WriteLine("Hit a key to go back to start menu");
            Console.ReadKey();
            Console.Clear();
            PrintStartMenu();
        }
        // Method for converting Euro to USD
        static void EuroToUSD()
        {
            Double Euro, USD;
            Console.WriteLine("Enter the Euro Amount: ");
            Euro = Double.Parse(Console.ReadLine());
            USD = Euro * 1.4;
            Console.WriteLine("{0} Euro Equals {1} USD ", Euro, Math.Round(USD, 2));
            Console.WriteLine("Hit a key to go back to start menu");
            Console.ReadKey();
            Console.Clear();
            PrintStartMenu();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tCurrency Converter\n\n");
            PrintStartMenu();
            //string text = Console.ReadLine();
            //int menuChoise = int.Parse(text);
            //int inputResponse = 1;
            //do
            //{
            //    if (inputResponse == 0)
            //    {
            //        Console.Clear();
            //        PrintStartMenu();
            //        text = Console.ReadLine();
            //        menuChoise = int.Parse(text);
            //    }
            //    switch (menuChoise)
            //    {
            //        case 1:
            //            inputResponse = FromSEKCurrencyMenu();
            //            break;
            //        case 2:
            //            inputResponse = FromUSDCurrencyMenu();
            //            break;
            //        case 3:
            //            inputResponse = FromEuroCurrencyMenu();
            //            break;
            //        case 0:
            //            return;
            //        //Console.WriteLine("Program closes");

            //        default:
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("Not correct format, try again. ");
            //            PrintStartMenu();
            //            break;

            //    }
            //} while (menuChoise != 0);
            Console.ReadKey();

        }

    }
}
