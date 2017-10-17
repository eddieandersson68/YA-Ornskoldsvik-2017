using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Dog : AnimalTypes
    {
        public int Tail { get; set; }
        //public string Name { get; set; }
        public int GetAge()
        {
            return Age;
          
        }

        


        public override string ToString()
        {
            return string.Format("I'm a {5}, and my name is {0} and I'm {1} years old, I'm a {2}.\nThese are my measurements I'm {3} cm's tall and {4} cm's long\nI got a {6} cm long tail\n", Name, Age, Breed, Hight, Length, Speices, Tail);
        }
        //public override Dog PrintHumanAge()
        //{
        //    Age *= 7;
        //    //Console.WriteLine("That's {0} human years\n", Age);
        //    return 

        //}
    }
}
