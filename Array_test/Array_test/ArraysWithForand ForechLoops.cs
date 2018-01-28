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
            // creating an array to hold the weekdays
            string[] daysOfWeek =
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
            int indexOfW = Array.FindIndex(daysOfWeek, x => x[0] == 'W');// this part is a predicate: x => x[0] == 'W' 
            //that evaluates each element of the array until it finds one that return true, then return the index of that element.
            Console.WriteLine(indexOfW);
            // this  bit gets the element name of the found Index
            Console.WriteLine(daysOfWeek[indexOfW] + "\n");
            //Console.WriteLine("\n");


            // find all days with excatly 6 letters using findAll, FindAll is a static method in the array class and thus not need to be instatiated   
            string[] AllWith6Chars = Array.FindAll(daysOfWeek, x => x.Length == 6);
            foreach(var item in AllWith6Chars)
                Console.WriteLine(item);



            // implementing the ICollection interface casting the previous daysOfWeek Array into it
            // trying 3 different ways of counting the elements of the collection
            ICollection<string> collection = (ICollection<string>)daysOfWeek;
            Console.WriteLine("ICollection.Count:  = " + collection.Count);
            Console.WriteLine("IEmumerableExtesion.Count:  = "  + collection.Count());
            Console.WriteLine("ArrayLength Count:  = " + daysOfWeek.Length);

            // how to replace an element in the array, in this case saturday at index 5
            (collection as string[])[5] = "Slaveday";

            if (!collection.IsReadOnly)
                collection.Add("Slaveday");
            else

                Console.WriteLine("collection is read-only");
            foreach(var day in collection)
                Console.WriteLine(day);

            var presidents = new List<string>
            {
                "Jimmy Carter",
                "Ronald Reagan",
                "George W Bush",
                "Bill Clinton",
                "George Bush"
            };
            Console.WriteLine("\nBefore: ");
            Console.WriteLine("count: " + presidents.Count);
            Console.WriteLine("Count = " + presidents.Capacity + "\r\n");

            presidents.Add("Barack Obama");
            presidents.Add("Bill Gates");
            presidents.Add("Steven Spielberg");

            Console.WriteLine("After: ");
            Console.WriteLine("count: " + presidents.Count);
            Console.WriteLine("Capacity: " + presidents.Capacity + "\r\n");

            foreach(var president in presidents)
                Console.WriteLine(president);


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
