using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractice
{
    class Program
    {
        // Pratice 16 Read 5 names from user an
        static void Main(string[] args)
        {
            // Read 5 names to a stack
            Console.WriteLine("Type 5 names\n ");
            Stack<string> names = new Stack<string>();
            for (int i = 0; i < 5; i++)
            {
                names.Push(Console.ReadLine());
            }
            
            // Print stack content to console
            Console.WriteLine("\nNamn: \n");


            //foreach (string number in names)
            //{
            //    Console.WriteLine(number);
            //}


            // code to copy from Stack to an Array, found on MSDN


            //Console.WriteLine("\nPopping '{0}'", names.Pop());
            //Console.WriteLine("Peek at next item to destack: {0}",
            //    names.Peek());
            //Console.WriteLine("Popping '{0}'", names.Pop());
            //Stack<string> stack2 = new Stack<string>(names.ToArray());
            //Console.WriteLine("\nContents of the first copy:");
            //foreach (string number in stack2)
            //{
            //    Console.WriteLine(number);
            //}
            foreach (string c in names)
            {
                Console.Write(c + " ");
            }

            Console.ReadLine();
            
        }
    }
}
