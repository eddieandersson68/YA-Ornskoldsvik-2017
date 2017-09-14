using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valutaväxlare
{
    public class Calculations
    {
        /// <summary>
        /// Method for converting SEK to USD
        /// </summary>
        public static void FromSekToUSD(double money = 0)
        {
            Double SEK, USD;
            if (money ==0)
            {
                Console.WriteLine("Enter the amount of SEK you want to exchange: \n");
                SEK = Double.Parse(Console.ReadLine());
            }
            else
            {
                SEK = money;
            }
            
            USD = SEK / 8.08; // SEK in USD
            Console.WriteLine("{0} SEK Equals to {1} USD \n\n", SEK, Math.Truncate(USD * 100) / 100);
            Console.WriteLine("which gives you: \n");
            int[] DollarNotes = { 100, 50, 20, 10, 5, 2, 1 }; // Array of value of dollar notes
            double[] Cent = { 0.50, 0.25, 0.10, 0.05, 0.01 }; // Array of cents

            USD = Math.Round(USD, 2);
            double Amount = USD; // Variable to keep track of USD out, called Amount
            int num;

            for (int i = 0; i < DollarNotes.Length; i++) // For loop to itterate the dollar values array
            {
                if (DollarNotes[i] < Amount)
                {
                    num = (int)Amount / DollarNotes[i];
                    Console.WriteLine(num + " st " + " " + DollarNotes[i] + "$");
                    Amount = Amount % DollarNotes[i];
                }
            }
            for (int i = 0; i < Cent.Length; i++) //For loop to itterate the cent values array
            {
                if (Cent[i] <= Amount)
                {
                    num = (int)(Amount / Cent[i]);
                    Console.WriteLine(num + " st " + " " + Math.Round((Cent[i]*100),2) + " Cents");
                    Amount = Math.Round(Amount % Cent[i],2);
                }
            }
        }
        /// <summary>
        /// Method for converting SEK to Euro
        /// </summary>
        public static void FromSekToEuro(double money = 0)
        {
            Double SEK, EUR;
            if (money == 0)
            {
                Console.WriteLine("Enter the amount of SEK you want to exchange: \n");
                SEK = Double.Parse(Console.ReadLine());
            }
            else
            {
                SEK = money;
            }
            EUR = SEK / 9.48;
            Console.WriteLine("{0} SEK Equals to {1} Euro \n\n", SEK, Math.Truncate(EUR * 100) / 100);
            Console.WriteLine("which gives you: \n");
            int[] EuroNotes = { 500, 200, 100, 50, 20, 10, 5, 2, 1 }; // Array of value of Euro notes
            double[] Cent = { 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 }; // Array of cents

            EUR = Math.Round(EUR,2);
            double Amount = EUR; // Variable to keep track of USD out, called Amount
            int num;

            for (int i = 0; i < EuroNotes.Length; i++) // For loop to itterate the EuroNotes values array
            {
                if (EuroNotes[i] < Amount)
                {
                    num = (int)Amount / EuroNotes[i];
                    Console.WriteLine(num + " st " + " " + EuroNotes[i] + " EUR");
                    Amount = Amount % EuroNotes[i];
                }
            }
            Amount = Math.Round(Amount, 2);
            for (int i = 0; i < Cent.Length; i++) //For loop to itterate the cent values array
            {
                if (Cent[i] <= Amount)
                {
                    num = (int)(Amount / Cent[i]);
                    Console.WriteLine(num + " st " + " " + (Cent[i]*100) + " Cents");
                    Amount = Amount % Cent[i];
                }
            }
        }
        /// <summary>
        /// Method for converting USD to SEK
        /// </summary>
        public static void FromUSDToSek(double money = 0 )
        {
            Double USD, SEK;
            if (money == 0)
            {
                Console.WriteLine("Enter the amount of USD you want to exchange: \n");
                USD = Double.Parse(Console.ReadLine());
            }
            else
            {
                USD = money;
            }
            SEK = USD * 8.08;
            
            Console.WriteLine("{0} USD Equals to {1} SEK \n\n", USD, Math.Round(SEK, 2));
            Console.WriteLine("which gives you: \n");
            int[] SwedishNotes = { 500, 100, 50, 20, }; // Array of value of SwedishNotes notes
            double[] Kr = { 10, 1 }; // Array of kr
            
            SEK = (int)Math.Floor(SEK + 0.5);
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
            for (int i = 0; i < Kr.Length; i++) //For loop to itterate the Kr values array
            {
                if (Kr[i] <= Amount)
                {
                    num = (int)(Amount / Kr[i]);
                    Console.WriteLine(num + " st " + " " + Kr[i] + " Kr");
                    Amount = Amount % Kr[i];
                }
            }
        }
        /// <summary>
        /// Method for converting USD to Euro
        /// </summary>
        public static void FromUSDToEuro(double money = 0)
        {
            Double USD, EUR;
            if (money == 0)
            {
                Console.WriteLine("Enter the amount of USD you want to exchange: \n");
                USD = Double.Parse(Console.ReadLine());
            }
            else
            {
                USD = money;
            }
            EUR = USD * 0.85;
            Console.WriteLine("{0} USD Equals to {1} Euro\n\n", USD, Math.Truncate(EUR * 100) / 100);
            Console.WriteLine("which gives you: \n");
            int[] EuroNotes = { 500, 200, 100, 50, 20, 10, 5, 2, 1 }; // Array of value of EuroNotes notes
            double[] Cent = { 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 }; // Array of cents
            EUR = Math.Round(EUR, 2);
            double Amount = EUR; // Variable to keep track of Euro out, called Amount
            int num;

            for (int i = 0; i < EuroNotes.Length; i++) // For loop to itterate the EuroNotes values array
            {
                if (EuroNotes[i] < Amount)
                {
                    num = (int)Amount / EuroNotes[i];
                    Console.WriteLine(num + " st " + " " + EuroNotes[i] + " EUR ");
                    Amount = Amount % EuroNotes[i];
                }
            }
            for (int i = 0; i < Cent.Length; i++) //For loop to itterate the cents values array
            {
                if (Cent[i] <= Amount)
                {
                    num = (int)(Amount / Cent[i]);
                    Console.WriteLine(num + " st " + " " + (Cent[i]*100) + " Cents");
                    Amount = Amount % Cent[i];
                }
            }
        }
        /// <summary>
        /// Method for converting Euro to SEK
        /// </summary>
        public static void FromEuroToSek(double money = 0)
        {
            Double EUR, SEK;
            if (money == 0)
            {
                Console.WriteLine("Enter the amount of Euro you want to exchange: \n");
                EUR = Double.Parse(Console.ReadLine());
            }
            else
            {
                EUR = money;
            }

            SEK = EUR * 9.48;
            Console.WriteLine("{0} Euro Equals to {1} SEK\n\n", EUR, Math.Truncate(SEK * 100) / 100);
            Console.WriteLine("which gives you: \n");
            int[] SwedishNotes = { 500, 100, 50, 20, }; // Array of value of SwedishNotes notes
            double[] Kr = { 10, 1 }; // Array of cents

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
            for (int i = 0; i < Kr.Length; i++) //For loop to itterate the Kr values array
            {
                if (Kr[i] <= Amount)
                {
                    num = (int)(Amount / Kr[i]);
                    Console.WriteLine(num + " st " + " " + Kr[i] + " Kr");
                    Amount = Amount % Kr[i];
                }
            }
        }
        /// <summary>
        /// Method for converting Euro to USD
        /// </summary>
        public static void FromEuroToUSD(double money = 0)
        {
            Double EUR, USD;
            if (money == 0)
            {
                Console.WriteLine("Enter the amount of Euro you want to exchange: \n");
                EUR = Double.Parse(Console.ReadLine());
            }
            else
            {
                EUR = money;
            }
            USD = EUR / 0.85;
            Console.WriteLine("{0} Euro Equals to {1} USD\n\n", EUR, Math.Truncate(USD * 100) / 100);
            Console.WriteLine("which gives you: \n");
            int[] DollarNotes = { 100, 50, 20, 10, 5, 2, 1 }; // Array of value of dollar notes
            double[] Cent = { 0.50, 0.25, 0.10, 0.05, 0.01 }; // Array of cents
            USD = Math.Round(USD, 2);
            double Amount = USD; // Variable to keep track of USD out, called Amount
            int num;

            for (int i = 0; i < DollarNotes.Length; i++) // For loop to itterate the cents values array
            {
                if (DollarNotes[i] < Amount)
                {
                    num = (int)Amount / DollarNotes[i];
                    Console.WriteLine(num + " st " + " " + DollarNotes[i] + "$");
                    Amount = Amount % DollarNotes[i];
                }
            }
            Amount = Math.Round(Amount, 2);
            for (int i = 0; i < Cent.Length; i++) //For loop to itterate the Kr values array
            {
                if (Cent[i] <= Amount)
                {
                    num = (int)(Amount / Cent[i]);
                    Console.WriteLine(num + " st " + " " + (Cent[i] *100)+ " Cents");
                    Amount = Amount % Cent[i];
                }
            }
        }
    }
}
