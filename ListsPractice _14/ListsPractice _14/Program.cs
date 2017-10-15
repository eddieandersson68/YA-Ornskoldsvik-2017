using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListsPractice__14
{
    class Program
    {
        static void Main(string[] args)
        {
            //// övning 14 With List and for loop


            //List<string> names2 = new List<string>();
            //Console.WriteLine("Please type 5 names: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    names2.Add(Console.ReadLine());
            //}

            //// Input with a foreach loop

            //List<string> names2 = new List<string>();
            //Console.WriteLine("Please type 5 names: ");

            //string name = null;
            //names2.Add(name);
            //foreach (string index in names2)
            //{
            //    name = Console.ReadLine();


            //}

            //// Print with Foreach and Lambda method


            //names2.Sort();
            //for (int i = 0; i < names2.Count; i++)
            //{
            //    Console.WriteLine("\n" + names2[i]);

            //}



            //Console.Write("\nWith Foreach method:");
            //names2.ForEach(i => Console.Write("{0}\n", i));
            //// Whith string.Join method
            //Console.WriteLine("With join string method: \n");
            //Console.WriteLine(string.Join("\n", names.Cast<string>().ToArray()));
            //// Print sorted 
            //names2.Sort();
            //names2.ForEach(i => Console.Write("{0}\n", i));





            //foreach (string elemnent in names)
            //    for (int i = 0; i < names.Count; i++)
            //    {
            //        Console.WriteLine("Please enter a name");
            //        names.Add(Console.ReadLine()); // HERE !!


            //    }
            //names.ForEach(Print);


            //names.ForEach(delegate (String name)
            //{Console.WriteLine(name);
            //});


            //void Print(string s)
            //{
            //    Console.WriteLine(s);
            //}
            Car car1 = new Car();
            car1.Make = "Volvo";
            car1.Model = "V70";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Saab";
            car2.Model = "Aero 9-5";
            car2.VIN = "B2";

            Book book1 = new Book();
            book1.Title = "THGTTG";
            book1.Author = "";
            book1.ISBN = "98970378442-234";

            // ArrayList are dynamically sized
            // Cool features like sorting and removing elements

            //ArrayList myArrayList = new ArrayList();
            //myArrayList.Add(car1);
            //myArrayList.Add(car2);
            //myArrayList.Add(book1);
            //myArrayList.Remove(book1);
            //foreach (Car car in myArrayList)

            //{
            //    Console.WriteLine(car.Make);
            //}
            //Console.WriteLine("");

            // Generic List <T>
            //List<Car> myList = new List<Car>();
            //myList.Add(car1);
            //myList.Add(car2);
            ////myList.Add(book1);
            //foreach(Car car in myList)
            //{
            //    Console.WriteLine(car.Make);
            //}


            // Dictionary <TKey,TValue>

            //Dictionary<string,Car> myDictionary = new Dictionary<string, Car>();
            //myDictionary.Add(car1.VIN, car1);
            //myDictionary.Add(car2.VIN, car2);

            //Console.WriteLine(myDictionary["B2"].Make);

            string[] names = { "Steve", "Adam", "Helen", "Mike" };


            List<Car> myCars = new List<Car>(){
                new Car { Make = "Volvo", Model = "V70" ,Year = 2013 , VIN = "A1" },
                new Car { Make = "Citroen", Model = "C4",Year = 2002, VIN = "C 48892" },
                new Car { Make = "Saab", Model = "Aero 9-5", Year = 1997, VIN = "A6" },
                new Car { Make = "Volvo", Model = "XC90", Year = 2000, VIN = "C 6792" },
                new Car { Make = "Ww", Model = "Bug", Year = 1976, VIN = "5685695" },
                new Car { Make = "Saab", Model = "900", Year = 1995, VIN = "98765" }
            };
            //foreach (Car car in myList)
            //{
            //    Console.WriteLine($"{car.Make} {car.Model} {car.VIN}");
            //}

            // LINQ Query
            //var Volvos = from car in myCars
            //             where car.Make == "Volvo"
            //             select car;


            //var OrderedCars = from car in myCars
            //                  orderby car.Year, car.Make descending
            //                  select car;
            // LiNQ as Method
            //var Volvos = myCars.Where(p => p.Make == "Volvo");
            var OrderedCars = myCars.OrderByDescending(p => p.Year);

            foreach (var car in OrderedCars)
            {
                Console.WriteLine("{0} {1}",car.Year, car.Make);
            }

            Console.ReadLine();
        }
    }
    class Car

    {
        public int Year { get; set; }
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
