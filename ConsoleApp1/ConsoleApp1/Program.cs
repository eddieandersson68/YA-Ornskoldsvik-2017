using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userValue = 2;
            string message = (userValue == 1) ? "boat" : "car";
            Console.WriteLine("{1} - {0}", userValue, message);

            Console.ReadLine();
        }
    }
}
