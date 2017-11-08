using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryBooks;

namespace LibraryBooks
{
    class Book
    {

        /*Skapa en klass Book för att hålla reda på bok-objekt. 
             * Varje bok-objekt ska ha en titel, författare, förlag och ISBN. 
             * Du kan för enkelhets skull låta ISBN vara av typen string istället för någon numerisk typ. 
             * Detta gör att ISBN kan ha en 0:a som första siffra eller inkludera någon bokstav.
             * Klassen ska också ha en metod, DisplayBook(), som skriver ut informationen till konsolfönstret.
             * Testkör programmet genom att skapa minst tre stycken bok-objekt.*/


        private string _title { get; set; }
        private string _author { get; set; }
        private string _publisher { get; set; }
        private string _isbn { get; set; }


        
        public Book()
        {

        }


        public Book(string Title, string Author, string Publisher, string ISBN)
        {
            _title = Title;
            _author = Author;
            _publisher = Publisher;
            _isbn = ISBN;
        }


        public void GetBookInfo()
        {
            
                Console.WriteLine("Title {0}\nAuthor {1}\nPublisher {2}\nISBN {3}\n", _title, _author, _publisher, _isbn);
                        //return string.Format("Title {0}\nAuthor {1}\nPublisher {2}\nISBN {3}\n", _title, _author, _publisher, _isbn);

        }


        //public override string ToString()
        //{
        //    return string.Format("Title {0}\nAuthor {1}\nPublisher {2}\nISBN {3}\n", _title, _author, _publisher, _isbn);
        //}
    }
}
