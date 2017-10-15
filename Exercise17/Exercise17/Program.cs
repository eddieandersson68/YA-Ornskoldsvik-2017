using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Person> Data = new List<Person>(); // List to store 5 instances of the the class Person
            {
                for (int i = Data.Count; i < 5 ; i++)
                {
                    Person person = new Person();
                    Console.WriteLine("Please type five names? ");
                    person.Name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Now an age? ");
                    person.Age = Convert.ToInt32(Console.ReadLine());
                    Data.Add(person);
                }
                Data.Reverse();
                
                Person.PrintPerson(Data);
            }
            Console.ReadLine();
        }
        /* Gör övning 13, men låt användaren skriva in namn och ålder istället 
         * för enbart namn. Lagra namn och ålder i en klass Person som ni skapar. 
         * Lagra alla inmatade personer (objekt) i en List och skriv sedan ut dem i omvändordning
         */
    }
}
