using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{

    /*1. Skapa en klass BankAccount som har attributen amount och name
      2. Skapa en konstruktor så att man kan skapa en instans med: new BankAccount("Krösus Sork", 250000)
      3. Skapa en medlems-metod som skriver ut ett konto
      4. Överlagra + -operatorn så att man kan slå samman två BankAccounts. När två BankAccount slås samman, 
         så ska en ny BankAccount skapas med namnen sammanslagna samt amount adderade*/
    class BankAccount
    {
        public Guid ID;
        public int amount { get; set; }
        public string olle { get; set; }


        //public BankAccount (int amount, string name)
        //{
            
            
        //}
        
        public static BankAccount operator + (BankAccount ba1, BankAccount ba2)
        {
           


        }

        public BankAccount SummonAccount
        {
        BankAccount b1 = new BankAccount(10000);
        BankAccount b2 = new BankAccount(5000);
        BankAccount b3 = b1 + b2;
        }
    }
}