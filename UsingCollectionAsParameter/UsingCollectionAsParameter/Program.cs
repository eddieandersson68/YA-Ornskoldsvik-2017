using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingCollectionAsParameter
{
    class Program
    {
        static void Main(string[] args)
        {

             int Sum(int[] list)
            {
                int total = 0;
                foreach (int i in list)
                {
                    total += i;
                }
                return total;
            }
            int[] numbers = { 1, 2, 3, 4 };
            int totalas = Sum(numbers);
            Console.WriteLine(totalas);
            Console.ReadLine();
        }
    }
}
