using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass Person = new MyClass();
            Person.city = "Kramfors";
            Person.adress = "Yxgatan 6";
            Person.name = "Eddie";
            Person.age = 49;
            Console.WriteLine(Person.city+ "\n" + Person.adress + "\n"+ Person.name + "\n" + Person.age);
            Console.ReadKey();


            StreamReader MyReader = new StreamReader("TextFile1");
            string line = "";
            while(line !=null)
            {
                line = MyReader.ReadLine();
            }
            char[] CharArray = line.ToCharArray();
            for (int i = 0; i < CharArray.Length; i++)
            {

            }




            Console.ReadLine();

            

    }
    }
}
