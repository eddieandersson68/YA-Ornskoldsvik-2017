using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsPractice__14
{
    class Program
    {
        static void Main(string[] args)
        {
            //// övning 14 With List and for loop
            List<string> names2 = new List<string>();
            Console.WriteLine("Please type 5 names: ");
            for (int i = 0; i < 5; i++)
            {
                names2.Add(Console.ReadLine());
            }

            //// Input with foreach loop
            //List<string> names2 = new List<string>();
            //Console.WriteLine("Please type 5 names: ");

            //string name = null;
            //names2.Add(name);
            //foreach (string index in names2)
            //{
            //    name = Console.ReadLine();


            //}

            //// Print with Foreach and Lambda method
            names2.Sort();
            for (int i = 0; i < names2.Count; i++)
            {
                Console.WriteLine("\n" + names2[i]);

            }
            //Console.Write("\nWith Foreach method:");
            //names2.ForEach(i => Console.Write("{0}\n", i));
            //// Whith string.Join method
            //Console.WriteLine("With join string method: \n");
            //Console.WriteLine(string.Join("\n", names.Cast<string>().ToArray()));
            //// Print sorted 
            //names2.Sort();
            //names2.ForEach(i => Console.Write("{0}\n", i));





            //foreach (string elemnent in names)
            //    for (int i = 0; i < names.Count; i++)
            //    {
            //        Console.WriteLine("Please enter a name");
            //        names.Add(Console.ReadLine()); // HERE !!


            //    }
            //names.ForEach(Print);


            //names.ForEach(delegate (String name)
            //{Console.WriteLine(name);
            //});


            //void Print(string s)
            //{
            //    Console.WriteLine(s);
            //}
            Console.ReadLine();
        }
    }
}
