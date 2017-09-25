using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_test
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Övning 13
             * 
             * Skapa ett applikation där användaren matar in 5st namn i en loop. 
             * Datan ska lagras i en array som sedan ska skrivas ut fast i omvänd ordning 
             * som användaren skriv in dem!
             */

            // With Array [] and for loop
            Console.WriteLine("Please type 5 names: ");
            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                string name = Console.ReadLine();
            }
            // With Foreach loop
            //Console.WriteLine("Please type 5 names: ");
            //foreach (string index in names)
            //{
            //    string name = Console.ReadLine();
            //    Console.WriteLine(index);
            //}

            // Print in revers order
            // Alt 1
            Array.Reverse(names);
            Console.WriteLine("\n \nNamn:\n");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Index " + i + " " + names[i]);
            }
            //// Alt 2 With reversed for loop make not2 of "names.Lenght -1"

            //for (int i = names.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine("Index " + i + " " + names[i]);
            //}

            //// övning 14 With List and for loop
            //List<string> names2 = new List<string>();
            //Console.WriteLine("Please type 5 names: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    names2.Add(Console.ReadLine());
            //}

            //// Input with foreach loop
            //Console.WriteLine("Please type 5 names: ");
            //foreach (string name in names2)
            //{
            //    names2.Add(Console.ReadLine());
            //}
    
            //// Print with Foreach method
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

            //int[] minArray = { 0, 1, 2, 3, 4, 5 };
            //Console.WriteLine(minArray.Length + " elements");
            //Console.WriteLine(minArray.Count() + " elements");
            //for (int i = 0; i < length; i++)
            //{

            //}
        }
    }
}
