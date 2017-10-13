using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class AgeClass
    {
        public void Age(int Age)
        {
            Age *= 7;
            Console.WriteLine("That's {0} human years\n",Age);
        }
    }
}
