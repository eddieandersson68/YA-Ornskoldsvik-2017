using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning20Generics
{
    public class GenericNumers<T>
    { 
        //int Number;


        //private int MyInt = 0;
        //private double  MyDouble =0;
       
        

        private List<T> NumbersList = new List<T>();

        public void AddtoList(T x)
        {
            NumbersList.Add(x);
        }
        public void PrintList()
        {
            foreach (T i in NumbersList)
            {
                Console.WriteLine(i);
            }
        }
    }

    //class MyNames
    //{
    //    public static void Shuffle<T>(this IList<T> list)
    //    {
    //        int n = list.Count;
    //        Random rnd = new Random();
    //        while (n > 1)
    //        {
    //            int k = (rnd.Next(0, n) % n);
    //            n--;
    //            T value = list[k];
    //            list[k] = list[n];
    //            list[n] = value;
    //        }
    //    }
    //}
    class Program
    {

        static void Main(string[] args)
        {

            // IntsList
            GenericNumers <int> MyIntNumbersList = new GenericNumers<int>();

            MyIntNumbersList.AddtoList(12);
            MyIntNumbersList.AddtoList(34);
            MyIntNumbersList.AddtoList(67);
            MyIntNumbersList.AddtoList(71);
            MyIntNumbersList.AddtoList(90);

            MyIntNumbersList.PrintList();
            Console.WriteLine("");

            // DoublesList
            GenericNumers<double> MyDoubleNumbersList = new GenericNumers<double>();

            MyDoubleNumbersList.AddtoList(12.5);
            MyDoubleNumbersList.AddtoList(34.2);
            MyDoubleNumbersList.AddtoList(6.7);
            MyDoubleNumbersList.AddtoList(71.45);
            MyDoubleNumbersList.AddtoList(9.56);

            MyDoubleNumbersList.PrintList();
            Console.WriteLine("");

            // StringList
            GenericNumers<string> MyStringsList = new GenericNumers<string>();

            MyStringsList.AddtoList("Eddie");
            MyStringsList.AddtoList("Sussi");
            MyStringsList.AddtoList("Melissa");
            MyStringsList.AddtoList("Alex");
            MyStringsList.AddtoList("Sanna");

            MyStringsList.PrintList();



            //List<String> VehicleNames = new List<string>();
            //VehicleNames.Add("Petrus");
            //VehicleNames.Add("Judas Taddeus");
            //VehicleNames.Add("Johannes");
            //VehicleNames.Add("Judas Iskariot");
            //VehicleNames.Add("Matteus");
            //VehicleNames.Add("Tomas");
            //VehicleNames.Add("Jakob");
            //VehicleNames.Add("Andreas");
            //VehicleNames.Add("Filippos");
            //VehicleNames.Add("Jakob2");
            //VehicleNames.Add("Simon");
            //VehicleNames.Add("Bartolomaios");
            //Random rnd = new Random();

            //for (int i = 0; i < VehicleNames.Count; i++)
            //{
            //    Console.WriteLine(VehicleNames[rnd.Next(0, VehicleNames.Count)]);
            //}

            Console.ReadLine();
        }
        //Console.WriteLine("Add 3 integers");

        //int Number = int.Parse(Console.ReadLine());

        //GenericNumers<int> NumbersList = new GenericNumers<int>();

        //NumbersList.AddtoList(Number);




    }
}
