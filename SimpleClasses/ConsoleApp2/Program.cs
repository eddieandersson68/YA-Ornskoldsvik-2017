using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            
            myCar.Make = "Volvo";
            myCar.Model = "V70";
            myCar.Year = 2013;
            myCar.Color = "Green";

            Console.WriteLine("{0} {1} {2} {3}", 
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.Color);

           //decimal value = DetermineMarketValue(myCar);
           // Console.WriteLine("{0:C}", value);

            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
            Console.ReadLine();
        }
        //private static decimal DetermineMarketValue(Car car)
        //{
        //    decimal carValue = 100000M;
        //    // Someday I might look up the car
        //    // online to get a more acurate vaule
        //    return carValue;
        //}
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 2000)
                carValue = 100000;
            else
                carValue = 2000;
            return carValue;

            
        }
    }
}
