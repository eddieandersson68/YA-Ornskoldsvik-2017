using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class Person
    {
        private string _name = "";
        private int _age = 0;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
                
        public Person(string Name = "No name", int Age=0)
        {
            _name = Name;
            _age = Age;
        }

        public static void PrintPerson(List<Person> s) // Print method 
        {
            foreach (var item in s)
            {
                Console.WriteLine($" {item.Name} age {item.Age}");
            }
        }
    }
}




