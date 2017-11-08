using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";

        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                if (i == 9)
                {
                    string l = i.ToString();
                }
                Console.WriteLine(i);
                //Console.WriteLine(l);

            }
            Console.WriteLine("\"Outside of the for loop\"" +" " + j);
            Console.WriteLine("\"Outside of the for loop\"" + " " + k);
            //Console.WriteLine(i);

            Car myCar = new Car();
            
            HelperMethod();
            myCar.DoSomething();
            Console.ReadLine();

            
        }
        static void HelperMethod ()
        {
            Console.WriteLine("Value of k from the HelperMethod ()" + k);
        }
    }
    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(HelperMethod());
        }
        private string HelperMethod()
            {
            return "Hello World";
            }
}

}
