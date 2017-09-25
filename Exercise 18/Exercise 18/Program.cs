using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> Data = new List<IPerson>(); // List to store 5 instances of the the class Person
            {
                for (int i = Data.Count; i < 5; i++)
                {
                    Person person = new Person();
                    Console.WriteLine("Please typ five names and ages? ");
                    Console.WriteLine("name: {0}", Data.Count +1);
                    
                    person.Name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Now an age? ");
                    person.Age = Convert.ToInt32(Console.ReadLine());
                    Data.Add(person);
                }
                //Data.Reverse();

                Person.PrintPersons(Data);
            }
            Console.ReadLine();
        }
        /* Gör övning 13, men låt användaren skriva in namn och ålder istället 
         * för enbart namn. Lagra namn och ålder i en klass Person som ni skapar. 
         * Lagra alla inmatade personer (objekt) i en List och skriv sedan ut dem i omvändordning
         */
    }
}

 