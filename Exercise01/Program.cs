using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{

    class PassingRefByVal
    {
        static void Change(int[] pArray)
        {
            pArray[0] = 888;  // This change affects the original element.
            pArray = { -3, -1, -2, -3, -4 };   // This change is local.
            System.Console.WriteLine("Inside the method, the first element is: {0}", pArray[0]);
        }
        class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 5 };
            System.Console.WriteLine("Inside Main, before calling the method, the first element is: {0}", arr[0]);

            Change(arr);
            System.Console.WriteLine("Inside Main, after calling the method, the first element is: {0}", arr[0]);

                Console.ReadKey();
        }

        

            
        }
    }
        /* Output:
            Inside Main, before calling the method, the first element is: 1
            Inside the method, the first element is: -3
            Inside Main, after calling the method, the first element is: 888
        */


        //    int myValue = AddValues(5, 2);
        //    Console.Write(myValue);

        //    Console.ReadKey();

        //}

        //static int AddValues(int a, int b)
        //{
        //    return a + b;
        //}

        ///


        //MyClass Person = new MyClass();
        //    Person.city = "Kramfors";
        //    Person.adress = "Yxgatan 6";
        //    Person.name = "Eddie";
        //    Person.age = 49;
        //    Console.WriteLine(Person.city + "\n" + Person.adress + "\n" + Person.name + "\n" + Person.age);
        //    Console.ReadKey();


        //    StreamReader MyReader = new StreamReader("TextFile1");
        //    string line = "";
        //    while (line != null)
        //    {
        //        line = MyReader.ReadLine();
        //    }
        //    char[] CharArray = line.ToCharArray();
        //    for (int i = 0; i < CharArray.Length; i++)
        //    {

        //    }
        //    {
        //        Console.WriteLine("");

        //int MyValue = addValues(2, 5);
        //        Console.WriteLine(MyValue);
        //        Console.ReadKey();
        //    }
        //    Console.ReadLine();
        //}

        //static int addmethod(int a, int b)
        //{
        //    return a + b;
        //}
    
}

