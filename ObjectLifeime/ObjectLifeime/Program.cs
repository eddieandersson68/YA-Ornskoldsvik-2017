using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();
            //mycar.Make = "Volvo";
            //mycar.Model = "V70";
            //mycar.Year = 2013;
            //mycar.Color = "Blue";

            Car myOtherCar;
            myOtherCar = mycar;
            Console.WriteLine(" MyOtherCar {0} {1} {2} {3}", 
                myOtherCar.Make, 
                myOtherCar.Model,
                myOtherCar.Year, 
                myOtherCar.Color);
            Car.MyMethod();

            Car myThird = new Car("Saab","Aero 95" , 2014, "Green");
            myOtherCar = null;

            Console.WriteLine("{0} {1} {2} {3}", 
                myThird.Make,
                myThird.Model,
                myThird.Year, 
                myThird.Color) ;


            Console.ReadLine();
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public Car()
        {
            this.Make = "Nissan";
        }
        public static void MyMethod()
        {
            Console.WriteLine("Called my static  Method");
            
        }
    }
}
