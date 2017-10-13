using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Dog
    {
        public  int Age { get; set; }
        public string Name { get; set; }





        //public Dog(string Name, int Age)
        //{
        //    Name = string;
        //    Age = Value;
        //}
        //public void DoggyStyle()
        //{

        //    AgeClass a2 = new AgeClass();

        //    Console.WriteLine("I'm a dog and I'm 7 years old");
        //    a2.Age(7);
        //}

        public override string ToString()
        {
            return string.Format(" I'm a dog, and my name is {0} and I'm {1} years old", Name, Age);
        }

    }
}
