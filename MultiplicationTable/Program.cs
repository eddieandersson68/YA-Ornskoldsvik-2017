using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mulitplikationstabell ");
            Console.WriteLine("ange vilken tabell du vill se? \n");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(tal + " * " + i + " = " + tal * i);
            }




            //Console.WriteLine("skriv in 2 tal ");
            //int tal3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Skriv in tal 2 ");
            //int tal4 = int.Parse(Console.ReadLine());

            //int sum2 = tal3 + tal4;
            //Console.WriteLine(sum2);
            Console.ReadKey();
            //long theLong = 100;
            //int theInt = theLong;
            

        }
    }
}
