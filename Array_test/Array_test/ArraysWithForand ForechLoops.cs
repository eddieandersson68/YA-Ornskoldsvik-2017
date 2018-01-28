using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_test
{

    public class Program
    {
        static void Main(string[] args)
        {

            string[] dayOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            // finds index of a particular item in the array, Index of is a static method in the array class and thus not need to be instatiated
            // int indexOfTues = Array.IndexOf(dayOfWeek, "Tuesday");

            // finds index of first element that starts with a 'W' and displays it and it's index Nr, FindIndex is a static method in the array class and thus not need to be instatiated  
            int indexOfW = Array.FindIndex(dayOfWeek, x => x[0] == 'W');// this part is a predicate: x => x[0] == 'W' 
            //that evaluates each element of the array until it finds one that return true, then return the index of that element.
            Console.WriteLine(indexOfW);
            // this  bit gets the element name of the found Index
            Console.WriteLine(dayOfWeek[indexOfW] + "\n");
            //Console.WriteLine("\n");


            // find all days with excatly 6 letters using findAll, FindAll is a static method in the array class and thus not need to be instatiated   
            string[] AllWith6Chars = Array.FindAll(dayOfWeek, x => x.Length == 6);
            foreach(var item in AllWith6Chars)
                Console.WriteLine(item); 

            
            
            
            
            //Exorcise_14_Arrays.ArrayWithForeachLoop();

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




            //int[] minArray = { 0, 1, 2, 3, 4, 5 };
            //Console.WriteLine(minArray.Length + " elements");
            //Console.WriteLine(minArray.Count() + " elements");
            //for (int i = 0; i < length; i++)
            //{

            //}




            Console.ReadLine();
        }

    }
}
