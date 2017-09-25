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

            // With Array[] and for loop

            //Console.WriteLine("Please type 5 names: ");
            //string[] names = new string[5];
            //for (int i = 0; i < names.Length; i++)
            //{
            //    names[i] = Console.ReadLine();
            //}

            // With Foreach loop
            //string[] names = new string[5];
            //int id = 0;
            //Console.WriteLine("Please type 5 names: ");
            //foreach (string index in names)
            //{
            //    string name = Console.ReadLine();
            //    names[id] = name;
            //    id++;
            //}


            //// Print in revers order
            //// Alt 1
            //Array.Reverse(names);
            //Console.WriteLine("\n \nNamn:\n");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine("Index " + i + " " + names[i]);
            //}


            //// Alt 2 With reversed for loop, make note of "names.Lenght -1"
            //for (int i = names.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine("Index " + i + " " + names[i]);
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
