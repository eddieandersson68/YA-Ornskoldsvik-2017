using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOOP
{
    class Program
    {
        public class Person
        {
            // Private fields
            private string _name;
            private int _birthYear = 0;
            private string _address;
            private int _streetnumber = 0;
            // Counter for amount of objects created
            private static int counter;


            // Gör properties som inkapslar medlemsvariablerna Address och number

            // Encapsulation for the class fields

            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    _name = value;
                }
            }


            public int BirthYear
            {
                get
                {
                    return _birthYear;
                }
                set
                {
                    _birthYear = value;
                }
            }

            public string Address
            {
                get
                {
                    return _address;
                }
                set
                {
                    _address = value;
                }
            }

            public int Streetnumber
            {
                get
                {
                    return _streetnumber;
                }
                set
                {
                    _streetnumber = value;
                }
            }



            // Constructur that takes 4 parameters
            public Person(string name, int birthYear, string address, int streetnumber)
            {
                counter++;
                Name = name;
                BirthYear = birthYear;
                Address = address;
                Streetnumber = streetnumber;
                Console.WriteLine("You have made " + counter.ToString() + " objects");
            }
            //public string GetId()
            //{
            //    return name;
            //}
            //public void SetId(string newname)
            //{
            //    name = newname;
            //}
            
            //public string GetId()
            //{
            //    return Address;
            //}
            //public void SetId(string Newaddress)
            //{
            //    Address = Newaddress;
            //}


            //public int GetId2()
            //{
            //    return number;
            //}
            //public void SetId2(int NewNumber)
            //{
            //    number = NewNumber;
            //}



            // New construtor with two parameters
            //public Person(string name, int birthYear)
            //{
            //    _name = name;
            //    _birthYear = birthYear;
            //    Console.WriteLine("Name: {0}", name);
            //    Console.WriteLine("Bornyear: {0}", birthYear);
            //}
            //public string GetAll()
            //{
            //    return _name + " " + _birthYear.ToString();
            //}
        }
        /*
         * public Customer(int age, string name)
        {
            _age = age;
            _name = name;
        }

        public string GetAll()
        {
            return _name + " " + _age.ToString();
        }
         * 
         * 
         * 
        Skapa en konstruktor som tar två parametrar och sätter medlemsvariablerna
        Name och Birthyear
        Skapa en instans av klassen (Person) och använd konstruktorn
        Ex: Person p = new Person("Morgan", 28);

        */

        static void Main(string[] args)
        {
            Person p = new Person("Eddie Andersson ", 1968, "Yxgatan ", 6);
            Person t = new Person("Suanne Sundstöm ", 1977, "Yxgatan ", 6);

            Console.WriteLine(" ");
            Console.WriteLine(p.Name + " \n" + p.BirthYear.ToString() +" \n" + p.Address + "\n" + p.Streetnumber.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(t.Name + " \n" + t.BirthYear.ToString() + " \n" + t.Address + "\n" + t.Streetnumber.ToString());

            //Console.WriteLine(p.GetID());
            //Console.WriteLine(p.GetID2());
            //Person r = new Person();
            //r.SetId("Yxgatan");
            //r.SetId2(6);
            //Console.WriteLine(r.GetId());
            //Console.WriteLine(r.GetId2());


            //Person t = new Person("Susanne", 40);
            //Console.WriteLine(t.personName, PersonBornYear);


            Console.ReadLine();
        }
    }
}
