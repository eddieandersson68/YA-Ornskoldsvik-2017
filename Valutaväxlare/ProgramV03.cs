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
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What currency do you want to excange? \nPress 1,2 or 3? \n");
            Console.WriteLine("1: SEK");
            Console.WriteLine("2: USD");
            Console.WriteLine("3: Euro");
            Console.WriteLine("0: close program");
            int.TryParse(Console.ReadLine(), out int temp);
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
            Double SEK, USD;
            Console.WriteLine("Enter the amount of SEK you want to exchange: \n");
            SEK = Double.Parse(Console.ReadLine());
            USD = SEK / 8.08; // SEK in USD
                Console.WriteLine("{0} SEK Equals to  {1} USD \n\n", SEK, Math.Truncate(USD * 100) / 100);
                Console.WriteLine("which gives you: \n");
                int[] DollarNotes = { 100, 50, 20, 10, 5, 2, 1 }; // Array of value of dollar notes
                double[] Coins = { 0.50, 0.25, 0.10, 0.05, 0.01 }; // Array of cents
              

                double Amount = USD; // Variable to keep track of USD out, called Amount
                int num;

                for (int i = 0; i < DollarNotes.Length; i++) // For loop to itterate the dollar values array
                {
                    if (DollarNotes[i] < Amount)
                    {
                        num = (int)Amount / DollarNotes[i];
                        Console.WriteLine(num + " st " + " " + DollarNotes[i]+" Dollar notes") ;
                        Amount = Amount % DollarNotes[i];
                    }
                }
                for (int i = 0; i < Coins.Length; i++) //For loop to itterate the cent values array
                {
                    if (Coins[i] <= Amount)
                    {
                        num = (int)(Amount / Coins[i]);
                        Console.WriteLine(num + " st " + " " + Coins[i] + " Cents");
                        Amount = Amount % Coins[i];
                    }
                }
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
            Console.WriteLine("{0} SEK Equals to  {1} Euro \n\n", SEK, Math.Truncate(EURO * 100) / 100);
            Console.WriteLine("which gives you: \n");
            int[] EuroNotes = { 500, 200, 100, 50, 20, 10, 5, 2, 1 }; // Array of value of Euro notes
            double[] Coins = { 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 }; // Array of cents

            double Amount = EURO; // Variable to keep track of USD out, called Amount
            int num;

            for (int i = 0; i < EuroNotes.Length; i++) // For loop to itterate the EuroNotes values array
            {
                if (EuroNotes[i] < Amount)
                {
                    num = (int)Amount / EuroNotes[i];
                    Console.WriteLine(num + " st " + " " + EuroNotes[i] + " Euro notes");
                    Amount = Amount % EuroNotes[i];
                }
            }
            for (int i = 0; i < Coins.Length; i++) //For loop to itterate the cent values array
            {
                if (Coins[i] <= Amount)
                {
                    num = (int)(Amount / Coins[i]);
                    Console.WriteLine(num + " st " + " " + Coins[i] + " Cents");
                    Amount = Amount % Coins[i];
                }
            }
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
            Console.WriteLine("{0} USD Equals to  {1} SEK \n\n", USD, Math.Truncate(SEK * 100) / 100);
            Console.WriteLine("which gives you: \n");
            int[] SwedishNotes = { 1000, 500, 100, 50, 20, 10, 1 }; // Array of value of SwedishNotes notes
            //double[] Kr = { 0.50, 0.25, 0.10, 0.05, 0.02, 0.01 }; // Array of kr

            double Amount = SEK; // Variable to keep track of USD out, called Amount
            int num;

            for (int i = 0; i < SwedishNotes.Length; i++) // For loop to itterate the SwedishNotes values array
            {
                if (SwedishNotes[i] < Amount)
                {
                    num = (int)Amount / SwedishNotes[i];
                    Console.WriteLine(num + " st " + " " + SwedishNotes[i] + " Kr ");
                    Amount = Amount % SwedishNotes[i];
                }
            }
            //for (int i = 0; i < Kr.Length; i++) //For loop to itterate the Kr values array
            //{
            //    if (Kr[i] <= Amount)
            //    {
            //        num = (int)(Amount / Kr[i]);
            //        Console.WriteLine(num + " st " + " " + Kr[i] + " Kr");
            //        Amount = Amount % Kr[i];
            //    }
            //}
            Console.ReadKey();
            Console.Clear();
            CurrencyMenu();
        }
        static void FromUSDToEuro()
        {
            Double USD, EURO;
            Console.WriteLine("Enter the amount of USD you want to exchange: \n");
            USD = Double.Parse(Console.ReadLine());
            EURO = USD * 0.85;
            Console.WriteLine("{0} USD Equals to  {1} Euro\n\n", USD, Math.Truncate(EURO * 100) / 100);
            Console.WriteLine("which gives you: \n");
            int[] EuroNotes = {  500, 200, 100, 50, 20, 10, 5, 2, 1 }; // Array of value of EuroNotes notes
            double[] Cent = { 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 }; // Array of cents

            double Amount = EURO; // Variable to keep track of Euro out, called Amount
            int num;

            for (int i = 0; i < EuroNotes.Length; i++) // For loop to itterate the EuroNotes values array
            {
                if (EuroNotes[i] < Amount)
                {
                    num = (int)Amount / EuroNotes[i];
                    Console.WriteLine(num + " st " + " " + EuroNotes[i] + " Euro ");
                    Amount = Amount % EuroNotes[i];
                }
            }
            for (int i = 0; i < Cent.Length; i++) //For loop to itterate the cents values array
            {
                if (Cent[i] <= Amount)
                {
                    num = (int)(Amount / Cent[i]);
                    Console.WriteLine(num + " st " + " " + Cent[i] + " Cents");
                    Amount = Amount % Cent[i];
                }
            }
            Console.ReadKey();
            Console.Clear();
            CurrencyMenu();
        }
        /// <summary>
        /// Method for converting Euro to SEK
        /// </summary>
        static void FromEuroToSek()
        {
            Double EURO, SEK;
            Console.WriteLine("Enter the Euro Amount: ");
            EURO = Double.Parse(Console.ReadLine());
            SEK = EURO * 9.48;
            Console.WriteLine("{0} Euro Equals to  {1} SEK\n\n", EURO, Math.Truncate(SEK * 100) / 100);
            Console.WriteLine("which gives you: \n");
            int[] SwedishNotes = { 1000, 500, 100, 50, 20, 10, 1 }; // Array of value of SwedishNotes notes

            //double[] Kr = { 0.50, 0.25, 0.10, 0.05, 0.02, 0.01 }; // Array of cents
            double Amount = SEK; // Variable to keep track of SEK out, called Amount

            int num;

            for (int i = 0; i < SwedishNotes.Length; i++) // For loop to itterate the cents values array
            {
                if (SwedishNotes[i] < Amount)
                {
                    num = (int)Amount / SwedishNotes[i];
                    Console.WriteLine(num + " st " + " " + SwedishNotes[i] + " Kr");
                    Amount = Amount % SwedishNotes[i];
                }
            }
            //for (int i = 0; i < Kr.Length; i++) //For loop to itterate the Kr values array
            //{
            //    if (Kr[i] <= Amount)
            //    {
            //        num = (int)(Amount / Kr[i]);
            //        Console.WriteLine(num + " st " + " " + Kr[i] + " Kr");
            //        Amount = Amount % Kr[i];
            //    }
            //    Console.ReadKey();
            //    Console.Clear();
            //    CurrencyMenu();
            //}
            Console.ReadKey();
            Console.Clear();
            CurrencyMenu();
        }
        /// <summary>
        /// Method for converting Euro to USD
        /// </summary>
        static void FromEuroToUSD()
        {
            Double EURO, USD;
            Console.WriteLine("Enter the Euro Amount: ");
            EURO = Double.Parse(Console.ReadLine());
            USD = EURO / 0.85;
            Console.WriteLine("{0} Euro Equals to  {1} USD\n\n", EURO, Math.Truncate(USD * 100) / 100);
            Console.WriteLine("which gives you: \n");
            int[] DollarNotes = { 100, 50, 20, 10, 5, 2, 1 }; // Array of value of dollar notes
            double[] Coins = { 0.50, 0.25, 0.10, 0.05, 0.01 }; // Array of cents

            double Amount = USD; // Variable to keep track of USD out, called Amount
            int num;

            for (int i = 0; i < DollarNotes.Length; i++) // For loop to itterate the cents values array
            {
                if (DollarNotes[i] < Amount)
                {
                    num = (int)Amount / DollarNotes[i];
                    Console.WriteLine(num + " st " + " " + DollarNotes[i] + " Dollar notes ");
                    Amount = Amount % DollarNotes[i];
                }
            }
            for (int i = 0; i < Coins.Length; i++) //For loop to itterate the Kr values array
            {
                if (Coins[i] <= Amount)
                {
                    num = (int)(Amount / Coins[i]);
                    Console.WriteLine(num + " st " + " " + Coins[i] + " Cents");
                    Amount = Amount % Coins[i];
                }
                
            }
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
