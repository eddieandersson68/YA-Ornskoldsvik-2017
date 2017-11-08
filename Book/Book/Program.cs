using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks
{
    class Program
    {
        public List<Book> mybook;
        static void Main(string[] args)
        {
           
            List<Book> mybooks = new List<Book>();
            mybooks.Add(new Book("THGTTG", "Adams.Douglas", "B.Wahlstöms", "97891768900"));
            mybooks.Add(new Book("Främlingar", "Koontz.Dean.R", " Höganäs", " 9177521404"));
            mybooks.Add(new Book("DET", "King.Steven", "Albert Bonniers Förlag", "9789100174682"));

            foreach (var i in mybooks)
            {
               i.GetBookInfo();
            }
            //var minaböcker = from x in mybooks
            //                 orderby x.ToString()
            //                 select x;

            //foreach (Book x in minaböcker)
            //{
            //    Console.WriteLine((x));
            //}


            Console.ReadLine();

        }
    }
}
