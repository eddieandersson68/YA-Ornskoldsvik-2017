using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public abstract class AnimalTypes
    {
        public string Speices { get; set; }
        public string Type { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Hight { get; set; }
        public int Length { get; set; }

        public int GetAge()
        {
            return Age;
        }

        public void PrintHumanAge()
        {
            Age *= 7;
            Console.WriteLine("that's {0} human years\n", Age);
        }


        public override string ToString()
        {
            return string.Format("I'm a {5}, and my name is {0} and I'm {1} years old, I'm a {2}.\nThese are my measurements I'm {3} cm's tall and {4} cm's long\n", Name, Age, Breed, Hight, Length, Speices);
        }

    }
}
