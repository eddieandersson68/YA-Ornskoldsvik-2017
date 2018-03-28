using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Threading;

namespace FormsBank
{

    public class Account
    {
       
        // public Guid ID;
      
        public decimal Balance { get; set; }
        public decimal sum { get; set; }


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

        public bool TransferFunds1(Account a1, Account a2, decimal transfer1)
        {
            if (a1.Balance >= 0 && a1.Balance >= transfer1 )
            {
                
                a1.Balance -= transfer1;
                a2.Balance += transfer1;
                return true;
            }

            else if(a1.Balance.Equals(transfer1) || a1.Balance < transfer1)
            {

                Form1.InsufficiantFunds(transfer1);
                //NotEnoughMoneyInAccount(transfer1);
            }

            return false;
        }

        public bool TransferFunds2(Account a2, Account a1, decimal transfer2)
        {
            if (a2.Balance >= 0 && a2.Balance >= transfer2 )
            {
                a2.Balance -= transfer2;
                a1.Balance += transfer2;
                return true;
            }
            else if(a2.Balance.Equals(transfer2) || a2.Balance < transfer2)
            {
                Form1.InsufficiantFunds(transfer2);
                //NotEnoughMoneyInAccount(transfer1);
            }

            return false;
        }

        public string NotEnoughMoneyInAccount(decimal amount)
        {
            
            string notEnoughFunds = $"Account does not have sufficient funds for that transaction {amount} ";
            
            return notEnoughFunds;
        }
    }
}
