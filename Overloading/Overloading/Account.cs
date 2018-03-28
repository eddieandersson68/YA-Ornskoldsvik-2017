using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Threading;

namespace Overloading
{

    public class Account
    {
       
        // public Guid ID;
      
        public decimal Balance { get; set; }  


        public bool Depostit (decimal amount)
        {
            if(amount > 0)
            {
                this.Balance += amount;
                return true;
            }
            return false;
        }

        public bool Withdraw (decimal amount)
        {
            if (amount < 0)
            {
                this.Balance -= amount;
                return true;
            }

            return false;
        }

        public bool TransferFunds(Account a1, Account a2, decimal amount)
        {
            if (a1.Balance >= amount)
            {
                a1.Balance -= amount;
                a2.Balance += amount;
                return true;
            }
            return false;
        }

    }
}
