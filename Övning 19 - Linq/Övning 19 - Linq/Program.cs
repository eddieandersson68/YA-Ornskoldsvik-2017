using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_19___Linq
{
    
    public class Kids
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public Kids(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        
        public static void CreateKids()
        {
            List<Kids> kids = new List<Kids>();
            
            //List<NameOfKids> Children = new List<NameOfKids>();
            kids.Add(new Kids ("Olle", 5));
            kids.Add(new Kids("Kalle", 3));
            kids.Add(new Kids("Lena", 12));
            kids.Add(new Kids("Sara", 9));

            //var barn from o in kids
            //         where o.Name.Contains("e")
            //         orderby o.Name
            //         select o;

            var barn = from p in kids
                       where p.Name.Contains("K")
                       orderby p.Name
                       select p;

            //Console.WriteLine(barn);


            foreach (var l in kids)
            {
                Console.WriteLine(l + "");
            }






        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            /*  1. Skapar en lista av typen int och lägg till några siffror mellan 1 och 10 (Ex. 1, 4, 7, 8, 10)
                2. Använd LINQ för att hämta ut de siffror som är större än 4
                3. Gör samma query som i övning 1 och skriv ut dessa i descending order.*/
            //List<int> numbers = new List<int> { 1, 4, 6, 10, 2 };

            //var query = from i in numbers
            //            where i > 4
            //            orderby i descending
            //            select i;

            //foreach (var p in query)
            //{
            //    Console.WriteLine(p);
            //}

            /*LINQ Övning 2

            Gör ett program som...
            1. Skapar en lista av typen string och lägg in några godtyckliga namn
            2. Använd LINQ för att hämta ut ett eller flera av namnen, godtyckligt filter
             * */


            List<string> names = new List<string> { "Eddie", "Markus", "Jonas", "Emma", "Frida", "Viktor", "Mattias" };

            var queryName = from o in names
                            where (o.Contains("k"))
                            orderby o ascending
                            select o;

            foreach (var o in queryName)
            {
                Console.WriteLine(o);
            }

            //Kids.CreateKids();

            Console.ReadLine();
        }
    }
}