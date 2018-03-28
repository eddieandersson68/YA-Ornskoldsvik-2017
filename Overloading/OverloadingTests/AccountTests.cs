using Microsoft.VisualStudio.TestTools.UnitTesting;
using Overloading;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading.Tests
{
    [TestClass()]
    public class AccountTests
    {

        [TestMethod()]
        public void Depostit100Test()
        {
            Account a1 = new Account();
            var result = a1.Depostit(0);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void WithdrawTest()
        {
            Account a1 = new Account();
            a1.Depostit(100);
            var result = a1.Withdraw(100);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void TransferFundsTest()
        {
            var a1 = new Account();
            var a2 = new Account();

            var result = a1.TransferFunds(a1, a2, 200);
            Assert.IsFalse(result);
        }
    }
}