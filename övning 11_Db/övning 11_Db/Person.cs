using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning_11_Db
{
    public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string  LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, int age)
        {
            Firstname = firstName;
            Age = age;
        }
    }
}
