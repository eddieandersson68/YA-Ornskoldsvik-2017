using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {



            Dictionary<int, string> staff = new Dictionary<int, string>();

            staff.Add(100, "Per Persson");
            staff.Add(101, "Adam Adamsson");
            staff.Add(102, "Kurt Kurtsson");

            foreach (var employee in staff)
            {
                Console.WriteLine(staff[100]); 
            }
            

            Console.WriteLine("\n*** Element med nyckeln 101 ***");
            Console.WriteLine(staff[101]);
            Console.ReadKey();
            staff.Reverse();
            foreach (var employee in staff)
            {
                Console.WriteLine(employee.Key + " : " + employee.Value);
            }

            Console.ReadLine();
        }
    }
}
