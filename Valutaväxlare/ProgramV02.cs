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
                Console.WriteLine("2: Euro");
                int.TryParse(Console.ReadLine(), out temp);
                if (temp == 1)
                {
                    FromUSDToSek();
                }
                if (temp == 2)
                {
                    FromUSDToEuro();
                }
                else
                {
                    WrongSelection();
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
                    FromEuroToSek();
                }
                if (temp == 2)
                {
                    FromEuroToUSD();
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not correct format, try again. \n \n ");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                CurrencyMenu();
            }
        }
        /// <summary>
        /// Method for converting SEK to USD
        /// </summary>
        static void FromSekToUSD()

        {
            double USDOut = 0;
            //double DollarNote100 = 100;
            int [] DollarNotes = { 100, 50, 20, 10, 5, 2, 1 };
            double[] DollarCents = { 1, 0.50, 0.25, 0.10, 0.05, 0.02, 0.01 };
            Double SEK, USD;
            Console.WriteLine("Enter the amount of SEK you want to exchange: \n");
            SEK = Double.Parse(Console.ReadLine());
            USD = SEK / 8.08;
            {
                Console.WriteLine("{0} SEK Equals to  {1} USD \n\n", SEK, Math.Round(USD, 2));
                //USDOut = USD / 50;
                //Console.WriteLine("You get " + Math.Round(USDOut, 2) + " $50 Notes");
            }
            USDOut = USD;
            if (USDOut > 100)
            {
                //USDOut = USDOut / 100;
                int nrOf100Dollars = (int)(USD / 100);
                Console.WriteLine("You get " + nrOf100Dollars + " $100 Notes");
                double rest = USD - (nrOf100Dollars * 100);
                //Console.WriteLine("You get " + nrOf20Dollars + " $20 Dollar notes and " + Math.Round(rest, 2));
                if (rest > 50)
                {
                    int nrOf50Dollars = (int)(rest / 50);
                    Console.WriteLine("You get " + nrOf50Dollars + " $50 Notes");

                    double rest2 = rest - nrOf50Dollars * 50;
                    if(rest2 > 20)
                    {
                        int nrOf20Dollars = (int)(rest2 / 20);
                        Console.WriteLine("You get " + nrOf20Dollars + " $20 Notes");

                        double rest3 = rest2 - nrOf20Dollars * 20;
                        if (rest3 >1)
                        {
                            int nrOf10Dollars = (int)(rest3 / 10);
                            Console.WriteLine("You get " + nrOf10Dollars + " $10 Notes");
                            double rest4 = rest3 - nrOf10Dollars * 10;
                            if(rest4 >1)
                            {
                                int nrOf5Dollars = (int)(rest4 / 5);
                                Console.WriteLine("You get " + nrOf5Dollars + " $5 Notes");
                                double rest5 = rest4 - nrOf5Dollars * 5;
                                if(rest5 > 1)
                                {
                                    int nrOf2Dollars = (int)(rest5 / 2);
                                    Console.WriteLine("You get " + nrOf2Dollars + " $2 Notes");
                                    double rest6 = rest5 - nrOf2Dollars * 2;
                                    if (rest6 > 1)
                                    {
                                        int nrOf1Dollars = (int)(rest6 / 1);
                                        Console.WriteLine("You get " + nrOf1Dollars + " $1 Notes");
                                        double rest7 = rest6 - nrOf1Dollars * 1;
                                            if (rest7 >= 0.50 || rest7 > 0.25)
                                        {
                                            double nrOf25Cents = (double) (rest7 / 0.25);
                                            Console.WriteLine("You get " + Math.Round(nrOf25Cents,2) + " 25 Cents");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                }
            }
            //if (USDOut >50 )
            //{
            //    //USDOut = USD / 50;
                
            //    int nrOf50Dollars = (int)(USD / 50);
            //    Console.WriteLine("You get " + nrOf50Dollars + " $50 Notes");
            //    double rest = USD - (nrOf50Dollars * 50);
            //}
            //if (USDOut < 20)
            //{
            //    //USDOut = USD / 20;
            //    int nrOf20Dollars = (int)(USD / 20);
            //    Console.WriteLine("You get " + Math.Round(USDOut, 2) + " $20 Notes");
            //}
            //if (USDOut < 10)
            //{
            //    //USDOut = USD / 10;
            //    int nrOf10Dollars = (int)(USD / 10);
            //    Console.WriteLine("You get " + Math.Round(USDOut, 2) + " $10 Notes");
            //}
            //if (USDOut < 5)
            //{
            //    //USDOut = USD / 5;
            //    int nrOf5Dollars = (int)(USD / 5);
            //    Console.WriteLine("You get " + Math.Round(USDOut, 2) + " $5 Notes");
            //}
            //if (USDOut < 2)
            //{
            //    //USDOut = USD / 2;
            //    int nrOf2Dollars = (int)(USD / 2);
            //    Console.WriteLine("You get " + Math.Round(USDOut, 2) + " $2 Notes");
            //}
            //if (USDOut <= 1)
            //{
            //    //USDOut = USD / 1;
            //    int nrOf1Dollars = (int)(USD / 1);
            //    Console.WriteLine("You get " + Math.Round(USDOut, 2) + " $1 Notes");
            //}
            Console.ReadKey();
            Console.Clear();
            CurrencyMenu();
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
            CurrencyMenu();
        }
        /// <summary>
        /// Method for converting USD to SEK
        /// </summary>
        static void FromUSDToSek()
        {
            Double USD, SEK;
            Console.WriteLine("Enter the amount of USD you want to exchange: \n");
            USD = Double.Parse(Console.ReadLine());
            SEK = USD * 8.08;
            Console.WriteLine("{0} USD Equals {1} SEK ", USD, Math.Round(SEK, 2));
            Console.WriteLine("Hit a key to go back to start menu");
            Console.ReadKey();
            Console.Clear();
            CurrencyMenu();
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
            Console.Clear();
            CurrencyMenu();
        }
        /// <summary>
        /// Method for converting Euro to SEK
        /// </summary>
        static void FromEuroToSek()
        {
            Double Euro, SEK;
            Console.WriteLine("Enter the Euro Amount: ");
            Euro = Double.Parse(Console.ReadLine());
            SEK = Euro * 9.48;
            Console.WriteLine("{0} Euro Equals {1} SEK ", Euro, Math.Round(SEK, 2));
            Console.WriteLine("Hit a key to go back to start menu");
            Console.ReadKey();
            Console.Clear();
            CurrencyMenu();
        }
        /// <summary>
        /// Method for converting Euro to USD
        /// </summary>
        static void FromEuroToUSD()
        {
            Double Euro, USD;
            Console.WriteLine("Enter the Euro Amount: ");
            Euro = Double.Parse(Console.ReadLine());
            USD = Euro * 1.4;
            Console.WriteLine("{0} Euro Equals {1} USD ", Euro, Math.Round(USD, 2));
            Console.WriteLine("Hit a key to go back to start menu");
            Console.ReadKey();
            Console.Clear();
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
            Console.WriteLine("\t\t\tCurrency Converter\n\n");
            CurrencyMenu();
            Console.ReadKey();
        }
    }
}
